using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public class StatusOnHitBlueprint
    {
        public StatusType Status;
        public float Chance;
        public float Potency;
        public int Duration;
    }

    public class CounterBlueprint
    {
        public CounterType CounterType;
        public ElementType RequiredElement;
        public bool RequiresDispelStanceOrBuff;
        public CounterResultType Result;
    }

    public class AbilityBlueprint
    {
        public string Id;
        public string DisplayName;
        public AbilityCategory Category;
        public ElementType Element;
        public float Power;
        public int MpCost;

        public TargetScope TargetScope;
        public bool HitsAllies;

        public int WindupTurns;
        public string CueText;
        public string CueAnimationTrigger;

        public bool CanCrit = true;
        public bool IgnoresDefense;
        public bool IsUltimate;

        public List<CounterBlueprint> Counters = new();
        public List<StatusOnHitBlueprint> StatusOnHit = new();
    }

    public class AffinityBlueprint
    {
        public ElementType Element;
        public float Multiplier;
    }

    public class DropBlueprint
    {
        public string ItemId;
        public float Chance;
    }

    public class RewardBlueprint
    {
        public int Exp;
        public int Gold;
        public List<DropBlueprint> Drops = new();
    }

    public class AIRuleBlueprint
    {
        public EnemyAIConditionType ConditionType;
        public int IntervalTurns;
        public int HpThresholdPercent;
        public StatusType StatusCheck;
        public bool Negate;

        public bool FocusLowestDEF;
        public bool FocusHighestATK;
        public bool FocusHighestSPD;
        public bool FocusPoisoned;
        public bool FocusBleeding;
        public bool FocusMarked;

        public string AbilityId;
        public bool OncePerBattle;
        public int Priority;
    }

    public class EnemyBlueprint
    {
        public string Id;
        public string DisplayName;
        public BattleStats Stats;

        public List<AffinityBlueprint> Affinities = new();
        public List<string> AbilityIds = new();
        public string DefaultAttackId;

        public RewardBlueprint Reward = new();

        public bool ImmuneFear;
        public bool ImmuneBleed;
        public bool ImmunePoison;
        public bool ImmuneBurn;
        public bool ImmuneStagger;
        public bool ImmuneSlow;

        public List<AIRuleBlueprint> AIRules = new();
    }
}
