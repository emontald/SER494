using System;
using System.Collections.Generic;

namespace KingdomArlin.Battle
{
    public enum TelegraphState
    {
        Pending,
        CounteredReduced,
        CounteredCanceled,
        CounteredSelfStagger,
        Resolved
    }

    public class TelegraphedAction
    {
        public AbilityDefinition ability;
        public ICombatActor caster;
        public List<ICombatActor> targets;
        public int turnsRemaining;
        public TelegraphState state = TelegraphState.Pending;
        public CounterResultType counterResult = CounterResultType.None;

        public TelegraphedAction(AbilityDefinition ability, ICombatActor caster, List<ICombatActor> targets)
        {
            this.ability = ability;
            this.caster = caster;
            this.targets = targets;
            turnsRemaining = ability.windupTurns;
        }
    }

    public class TelegraphManager
    {
        public static TelegraphManager Instance { get; private set; }

        public event Action<TelegraphedAction> OnTelegraphStarted;
        public event Action<TelegraphedAction> OnTelegraphUpdated;
        public event Action<TelegraphedAction> OnTelegraphResolved;

        readonly List<TelegraphedAction> _pending = new();

        public TelegraphManager()
        {
            Instance = this;
        }

        public void RegisterTelegraph(TelegraphedAction action)
        {
            _pending.Add(action);
            OnTelegraphStarted?.Invoke(action);
        }

        public void TickTelegraphs()
        {
            for (int i = _pending.Count - 1; i >= 0; i--)
            {
                var t = _pending[i];
                if (t.state == TelegraphState.Resolved)
                {
                    _pending.RemoveAt(i);
                    continue;
                }

                t.turnsRemaining--;
                if (t.turnsRemaining <= 0)
                {
                    OnTelegraphResolved?.Invoke(t);
                    _pending.RemoveAt(i);
                }
                else
                {
                    OnTelegraphUpdated?.Invoke(t);
                }
            }
        }

        public void RegisterCounter(
            ICombatActor caster,
            AbilityDefinition ability,
            CounterType counterType,
            ElementType elementUsed,
            bool dispelledBuffOrStance,
            bool exploitedWeakness)
        {
        }
    }
}
