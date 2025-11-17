using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area2Abilities
    {
        // =========================================================
        // Bog Shambler
        // =========================================================

        public static readonly AbilityBlueprint BogShambler_MireSlam =
            new AbilityBlueprint
            {
                Id = "BogShambler_MireSlam",
                DisplayName = "Mire Slam",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.0f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "",
                CanCrit = true
            };

        public static readonly AbilityBlueprint BogShambler_SoddenGrasp =
            new AbilityBlueprint
            {
                Id = "BogShambler_SoddenGrasp",
                DisplayName = "Sodden Grasp",
                Category = AbilityCategory.Magical,
                Element = ElementType.None,
                Power = 1.1f,
                MpCost = 4,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Roots slither around your boots.",
                CueAnimationTrigger = "SoddenGrasp_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Guard,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.SelfStagger
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Lightning,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.SelfStagger
                    }
                }
            };

        // =========================================================
        // Fen Pixie
        // =========================================================

        public static readonly AbilityBlueprint FenPixie_GlamerBolt =
            new AbilityBlueprint
            {
                Id = "FenPixie_GlamerBolt",
                DisplayName = "Glamer Bolt",
                Category = AbilityCategory.Magical,
                Element = ElementType.None,
                Power = 1.0f,
                MpCost = 3,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "GlamerBolt",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Shock,
                        Chance = 0.25f,
                        Potency = 10f,
                        Duration = 2
                    }
                }
            };

        public static readonly AbilityBlueprint FenPixie_WispVeil =
            new AbilityBlueprint
            {
                Id = "FenPixie_WispVeil",
                DisplayName = "Wisp Veil",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 4,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 1,
                CueText = "Bell-like laughter echoes.",
                CueAnimationTrigger = "WispVeil_Windup",
                CanCrit = false,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.Cancel
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Blunt,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        // =========================================================
        // Swamp Leech
        // =========================================================

        public static readonly AbilityBlueprint SwampLeech_DrainBite =
            new AbilityBlueprint
            {
                Id = "SwampLeech_DrainBite",
                DisplayName = "Drain Bite",
                Category = AbilityCategory.Physical,
                Element = ElementType.None,
                Power = 0.9f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "DrainBite",
                CanCrit = true
            };

        public static readonly AbilityBlueprint SwampLeech_SwellSpurt =
            new AbilityBlueprint
            {
                Id = "SwampLeech_SwellSpurt",
                DisplayName = "Swell & Spurt",
                Category = AbilityCategory.Magical,
                Element = ElementType.None,
                Power = 1.0f,
                MpCost = 6,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "The leech bloats with stolen blood.",
                CueAnimationTrigger = "SwellSpurt_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ExploitWeakness,
                        RequiredElement = ElementType.Fire,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.Cancel
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Guard,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Muckrime Matron
        // =========================================================

        public static readonly AbilityBlueprint Matron_AcidGlob =
            new AbilityBlueprint
            {
                Id = "Matron_AcidGlob",
                DisplayName = "Acid Glob",
                Category = AbilityCategory.Magical,
                Element = ElementType.None,
                Power = 1.2f,
                MpCost = 3,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "AcidGlob",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.ArmorDown,
                        Chance = 0.50f,
                        Potency = 0.20f,
                        Duration = 2
                    }
                }
            };

        public static readonly AbilityBlueprint Matron_BroodCall =
            new AbilityBlueprint
            {
                Id = "Matron_BroodCall",
                DisplayName = "Brood Call",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 6,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 1,
                CueText = "Wet chirring beneath the muck.",
                CueAnimationTrigger = "BroodCall_Windup",
                CanCrit = false,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Interrupt,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        public static readonly AbilityBlueprint Matron_CausticFlood =
            new AbilityBlueprint
            {
                Id = "Matron_CausticFlood",
                DisplayName = "Caustic Flood",
                Category = AbilityCategory.Magical,
                Element = ElementType.None,
                Power = 1.3f,
                MpCost = 10,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "The Matron churns the mire!",
                CueAnimationTrigger = "CausticFlood_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Guard,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = true,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // The Bracken Warden
        // =========================================================

        public static readonly AbilityBlueprint Warden_ThornBarrage =
            new AbilityBlueprint
            {
                Id = "Warden_ThornBarrage",
                DisplayName = "Thorn Barrage",
                Category = AbilityCategory.Physical,
                Element = ElementType.Pierce,
                Power = 1.0f,
                MpCost = 0,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "ThornBarrage",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Bleed,
                        Chance = 0.30f,
                        Potency = 0.05f,
                        Duration = 3
                    }
                }
            };

        public static readonly AbilityBlueprint Warden_BoglightJudgment =
            new AbilityBlueprint
            {
                Id = "Warden_BoglightJudgment",
                DisplayName = "Boglight Judgment",
                Category = AbilityCategory.Magical,
                Element = ElementType.Lightning,
                Power = 1.3f,
                MpCost = 8,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Will-o’-wisps crown the Warden.",
                CueAnimationTrigger = "BoglightJudgment_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Guard,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ApplyWet,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        public static readonly AbilityBlueprint Warden_MirePact =
            new AbilityBlueprint
            {
                Id = "Warden_MirePact",
                DisplayName = "Mire Pact",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 8,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 2,
                CueText = "The swamp itself answers.",
                CueAnimationTrigger = "MirePact_Windup",
                CanCrit = false,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Poison,
                        Chance = 1.0f,
                        Potency = 18f,
                        Duration = 3
                    }
                },
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        // =========================================================
        // Utility: enumerate all
        // =========================================================

        public static IEnumerable<AbilityBlueprint> GetAll()
        {
            yield return BogShambler_MireSlam;
            yield return BogShambler_SoddenGrasp;

            yield return FenPixie_GlamerBolt;
            yield return FenPixie_WispVeil;

            yield return SwampLeech_DrainBite;
            yield return SwampLeech_SwellSpurt;

            yield return Matron_AcidGlob;
            yield return Matron_BroodCall;
            yield return Matron_CausticFlood;

            yield return Warden_ThornBarrage;
            yield return Warden_BoglightJudgment;
            yield return Warden_MirePact;
        }
    }
}
