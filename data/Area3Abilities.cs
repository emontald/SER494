using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area3Abilities
    {
        // =========================================================
        // Cinder Imp
        // =========================================================

        public static readonly AbilityBlueprint CinderImp_SparkDart =
            new AbilityBlueprint
            {
                Id = "CinderImp_SparkDart",
                DisplayName = "Spark Dart",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.0f,
                MpCost = 3,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "SparkDart",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status  = StatusType.Burn,
                        Chance  = 0.30f,
                        Potency = 0.05f,
                        Duration = 3
                    }
                }
            };

        public static readonly AbilityBlueprint CinderImp_CoalHeart =
            new AbilityBlueprint
            {
                Id = "CinderImp_CoalHeart",
                DisplayName = "Coal Heart",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 5,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 0,
                CueText = "The imp’s core glows hotter.",
                CueAnimationTrigger = "CoalHeart",
                CanCrit = false
            };

        public static readonly AbilityBlueprint CinderImp_Flashflare =
            new AbilityBlueprint
            {
                Id = "CinderImp_Flashflare",
                DisplayName = "Flashflare",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.2f,
                MpCost = 8,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "The imp inhales cinders.",
                CueAnimationTrigger = "Flashflare_Windup",
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
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Ice,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Lava Wyrmling
        // =========================================================

        public static readonly AbilityBlueprint LavaWyrmling_TailCrush =
            new AbilityBlueprint
            {
                Id = "LavaWyrmling_TailCrush",
                DisplayName = "Tail Crush",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.1f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "TailCrush",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status   = StatusType.Stagger,
                        Chance   = 0.30f,
                        Potency  = 0f,
                        Duration = 1
                    }
                }
            };

        public static readonly AbilityBlueprint LavaWyrmling_MagmaSpit =
            new AbilityBlueprint
            {
                Id = "LavaWyrmling_MagmaSpit",
                DisplayName = "Magma Spit",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.1f,
                MpCost = 5,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Magma wells in its maw.",
                CueAnimationTrigger = "MagmaSpit_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Guard,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Ice,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Basalt Sentinel
        // =========================================================

        public static readonly AbilityBlueprint BasaltSentinel_GuardbreakChop =
            new AbilityBlueprint
            {
                Id = "BasaltSentinel_GuardbreakChop",
                DisplayName = "Guardbreak Chop",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.0f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "GuardbreakChop",
                CanCrit = true
            };

        public static readonly AbilityBlueprint BasaltSentinel_StoneStance =
            new AbilityBlueprint
            {
                Id = "BasaltSentinel_StoneStance",
                DisplayName = "Stone Stance",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 0,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 0,
                CueText = "It settles into an immovable stance.",
                CueAnimationTrigger = "StoneStance",
                CanCrit = false
            };

        public static readonly AbilityBlueprint BasaltSentinel_SeismicStamp =
            new AbilityBlueprint
            {
                Id = "BasaltSentinel_SeismicStamp",
                DisplayName = "Seismic Stamp",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.2f,
                MpCost = 6,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "The ground hums beneath its foot.",
                CueAnimationTrigger = "SeismicStamp_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.SpreadGuard,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Lightning,
                        Result = CounterResultType.SelfStagger
                    }
                }
            };

        // =========================================================
        // Pyrebound Duo – Ash
        // =========================================================

        public static readonly AbilityBlueprint Ash_FlameWhip =
            new AbilityBlueprint
            {
                Id = "Ash_FlameWhip",
                DisplayName = "Flame Whip",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.0f,
                MpCost = 4,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "FlameWhip",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status   = StatusType.Burn,
                        Chance   = 0.25f,
                        Potency  = 0.05f,
                        Duration = 3
                    }
                }
            };

        public static readonly AbilityBlueprint Ash_SearingLine =
            new AbilityBlueprint
            {
                Id = "Ash_SearingLine",
                DisplayName = "Searing Line",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.2f,
                MpCost = 8,
                TargetScope = TargetScope.RowEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Ash drags a fireline.",
                CueAnimationTrigger = "SearingLine_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.PositionSwap,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Ice,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Pyrebound Duo – Cask
        // =========================================================

        public static readonly AbilityBlueprint Cask_DetonatingToss =
            new AbilityBlueprint
            {
                Id = "Cask_DetonatingToss",
                DisplayName = "Detonating Toss",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.1f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "DetonatingToss",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status   = StatusType.Stagger,
                        Chance   = 0.20f,
                        Potency  = 0f,
                        Duration = 1
                    }
                }
            };

        public static readonly AbilityBlueprint Cask_PowderKeg =
            new AbilityBlueprint
            {
                Id = "Cask_PowderKeg",
                DisplayName = "Powder Keg",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.3f,
                MpCost = 10,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Cask rolls a hissing keg.",
                CueAnimationTrigger = "PowderKeg_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.DisplaceTarget,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.Cancel
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Ice,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        // =========================================================
        // Fusion Ultimate – shared blueprint
        // =========================================================

        public static readonly AbilityBlueprint Duo_Conflagrate =
            new AbilityBlueprint
            {
                Id = "Duo_Conflagrate",
                DisplayName = "Conflagrate",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.6f,
                MpCost = 15,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 2,
                CueText = "Ash and Cask sync their breath.",
                CueAnimationTrigger = "Conflagrate_Windup",
                CanCrit = true,
                IsUltimate = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Interrupt,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        // =========================================================
        // Obsidian Goliath
        // =========================================================

        public static readonly AbilityBlueprint Goliath_VolcanicBackhand =
            new AbilityBlueprint
            {
                Id = "Goliath_VolcanicBackhand",
                DisplayName = "Volcanic Backhand",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.3f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "VolcanicBackhand",
                CanCrit = true
            };

        public static readonly AbilityBlueprint Goliath_CoreOverheat =
            new AbilityBlueprint
            {
                Id = "Goliath_CoreOverheat",
                DisplayName = "Core Overheat",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 8,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 1,
                CueText = "Its chest cracks with inner light.",
                CueAnimationTrigger = "CoreOverheat_Windup",
                CanCrit = false,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Ice,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        public static readonly AbilityBlueprint Goliath_ObsidianShatter =
            new AbilityBlueprint
            {
                Id = "Goliath_ObsidianShatter",
                DisplayName = "Obsidian Shatter",
                Category = AbilityCategory.Physical,
                Element = ElementType.Pierce,
                Power = 1.2f,
                MpCost = 6,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Shards lift from its skin.",
                CueAnimationTrigger = "ObsidianShatter_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Guard,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Lightning,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        public static readonly AbilityBlueprint Goliath_CataclysmHeel =
            new AbilityBlueprint
            {
                Id = "Goliath_CataclysmHeel",
                DisplayName = "Cataclysm Heel",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.8f,
                MpCost = 10,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 2,
                CueText = "A crater marks your place.",
                CueAnimationTrigger = "CataclysmHeel_Windup",
                CanCrit = true,
                IsUltimate = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.DisplaceTarget,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Interrupt,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Utility – enumerate all
        // =========================================================

        public static IEnumerable<AbilityBlueprint> GetAll()
        {
            yield return CinderImp_SparkDart;
            yield return CinderImp_CoalHeart;
            yield return CinderImp_Flashflare;

            yield return LavaWyrmling_TailCrush;
            yield return LavaWyrmling_MagmaSpit;

            yield return BasaltSentinel_GuardbreakChop;
            yield return BasaltSentinel_StoneStance;
            yield return BasaltSentinel_SeismicStamp;

            yield return Ash_FlameWhip;
            yield return Ash_SearingLine;

            yield return Cask_DetonatingToss;
            yield return Cask_PowderKeg;

            yield return Duo_Conflagrate;

            yield return Goliath_VolcanicBackhand;
            yield return Goliath_CoreOverheat;
            yield return Goliath_ObsidianShatter;
            yield return Goliath_CataclysmHeel;
        }
    }
}
