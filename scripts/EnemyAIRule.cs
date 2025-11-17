using System;
using UnityEngine;

namespace KingdomArlin.Battle
{
    public enum EnemyAIConditionType
    {
        Always,
        TurnInterval,
        HPBelowPercent,
        HPNearOrBelowPercent,
        TargetHasStatus,
        SelfHasStatus,
        UsedOnce,
        IfBuffActive
    }

    [Serializable]
    public class EnemyAIRule
    {
        public EnemyAIConditionType conditionType = EnemyAIConditionType.Always;
        public int intervalTurns = 3;
        [Range(0, 100)] public int hpThresholdPercent = 50;
        public StatusType statusCheck = StatusType.None;
        public bool negateCondition;

        // Targeting hints
        public bool focusLowestDEF;
        public bool focusHighestATK;
        public bool focusHighestSPD;
        public bool focusPoisoned;
        public bool focusBleeding;
        public bool focusMarkedTarget;

        // Ability to use
        public AbilityDefinition ability;

        public bool oncePerBattle;
        [NonSerialized] public bool hasFired;

        public int priority;
    }
}
