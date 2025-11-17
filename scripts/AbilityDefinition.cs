using System;
using System.Collections.Generic;
using UnityEngine;

namespace KingdomArlin.Battle
{
    [Serializable]
    public struct StatusOnHit
    {
        public StatusType statusType;
        [Range(0f, 1f)] public float chance;
        public float potency;
        public int durationTurns;
    }

    [Serializable]
    public class CounterCondition
    {
        public CounterType counterType;
        public ElementType requiredElement = ElementType.None;
        public bool requiresDispelStanceOrBuff;
        public CounterResultType resultOnSuccess;
    }

    [CreateAssetMenu(menuName = "Arlin/Ability", fileName = "Ability_")]
    public class AbilityDefinition : ScriptableObject
    {
        public string abilityId;
        public string displayName;
        [TextArea] public string description;

        public AbilityCategory category;
        public ElementType element;
        public float power = 1f;
        public int mpCost;

        public TargetScope targetScope = TargetScope.SingleEnemy;
        public bool hitsAllies;

        public int windupTurns;
        [TextArea] public string cueText;
        public string cueAnimationTrigger;
        public List<CounterCondition> counters = new();

        public List<StatusOnHit> statusOnHit = new();
        public bool canCrit = true;

        public bool ignoresDefense;
        public bool isUltimate;
    }
}
