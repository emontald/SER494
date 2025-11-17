using System;
using System.Collections.Generic;
using UnityEngine;

namespace KingdomArlin.Battle
{
    [Serializable]
    public struct BattleStats
    {
        public int level, maxHP, maxMP, atk, mag, def, res, spd;
    }

    [Serializable]
    public struct ElementAffinity
    {
        public ElementType element;
        [Range(0.1f, 3f)] public float multiplier;
    }

    [Serializable]
    public class StatusInstance
    {
        public StatusType type;
        public float potency;
        public int remainingTurns;

        public StatusInstance(StatusType type, float potency, int duration)
        {
            this.type = type;
            this.potency = potency;
            this.remainingTurns = duration;
        }
    }
}
