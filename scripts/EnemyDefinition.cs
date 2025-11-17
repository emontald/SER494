using System.Collections.Generic;
using UnityEngine;

namespace KingdomArlin.Battle
{
    [System.Serializable]
    public struct DropEntry
    {
        public string itemId;
        [Range(0f, 1f)] public float dropChance;
    }

    [System.Serializable]
    public struct RewardData
    {
        public int exp;
        public int gold;
        public List<DropEntry> drops;
    }

    [CreateAssetMenu(menuName = "Arlin/EnemyDefinition", fileName = "Enemy_")]
    public class EnemyDefinition : ScriptableObject
    {
        public string enemyId;
        public string displayName;
        public Sprite portrait;
        public BattleStats baseStats;

        public List<ElementAffinity> affinities = new();

        public List<AbilityDefinition> abilitySet = new();
        public List<EnemyAIRule> aiRules = new();
        public AbilityDefinition defaultAttack;

        public RewardData reward;

        public bool immuneFear;
        public bool immuneBleed;
        public bool immunePoison;
        public bool immuneBurn;
        public bool immuneStagger;
        public bool immuneSlow;

        public float GetElementMultiplier(ElementType element)
        {
            if (element == ElementType.None) return 1f;
            foreach (var a in affinities)
                if (a.element == element) return a.multiplier;
            return 1f;
        }
    }
}
