using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area1Abilities
    {
        // ===== Haystack Shambler =====

        public static readonly AbilityBlueprint Haystack_RustleSwipe =
            new AbilityBlueprint
            {
                Id = "Haystack_RustleSwipe",
                DisplayName = "Rustle Swipe",
                Category = AbilityCategory.Physical,
                Element = ElementType.None,
                Power = 0.9f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Bleed,
                        Chance = 0.20f,
                        Potency = 0.05f,
                        Duration = 3
                    }
                }
            };

        public static readonly AbilityBlueprint Haystack_KindlingPuff =
            new AbilityBlueprint
            {
                Id = "Haystack_KindlingPuff",
                DisplayName = "Kindling Puff",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.2f,
                MpCost = 4,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Dry straw crackles...",
                CueAnimationTrigger = "KindlingPuff_Windup",
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
                        CounterType = CounterType.ApplyWet,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // ===== Field Viper =====

        public static readonly AbilityBlueprint FieldViper_FangJab =
            new AbilityBlueprint
            {
                Id = "FieldViper_FangJab",
                DisplayName = "Fang Jab",
                Category = AbilityCategory.Physical,
                Element = ElementType.Pierce,
                Power = 0.8f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Poison,
                        Chance = 0.40f,
                        Potency = 10f,
                        Duration = 3
                    }
                }
            };

        public static readonly AbilityBlueprint FieldViper_CoilLunge =
            new AbilityBlueprint
            {
                Id = "FieldViper_CoilLunge",
                DisplayName = "Coil & Lunge",
                Category = AbilityCategory.Physical,
                Element = ElementType.Pierce,
                Power = 1.2f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "The snake coils tightly...",
                CueAnimationTrigger = "CoilLunge_Windup",
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
                        Result = CounterResultType.SelfStagger
                    }
                }
            };

        // ===== Roadside Brigand =====

        public static readonly AbilityBlueprint Brigand_BackhandSlash =
            new AbilityBlueprint
            {
                Id = "Brigand_BackhandSlash",
                DisplayName = "Backhand Slash",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.0f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Bleed,
                        Chance = 0.25f,
                        Potency = 0.05f,
                        Duration = 3
                    }
                }
            };

        public static readonly AbilityBlueprint Brigand_FeignStrike =
            new AbilityBlueprint
            {
                Id = "Brigand_FeignStrike",
                DisplayName = "Feign & Strike",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.4f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "The brigand smirks and feints left.",
                CueAnimationTrigger = "FeignStrike_Windup",
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
                        RequiredElement = ElementType.Blunt,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // ===== Gallus, Scarecrow Warden =====

        public static readonly AbilityBlueprint Gallus_PitchforkThrust =
            new AbilityBlueprint
            {
                Id = "Gallus_PitchforkThrust",
                DisplayName = "Pitchfork Thrust",
                Category = AbilityCategory.Physical,
                Element = ElementType.Pierce,
                Power = 1.1f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                CanCrit = true
            };

        public static readonly AbilityBlueprint Gallus_StuffingBurst =
            new AbilityBlueprint
            {
                Id = "Gallus_StuffingBurst",
                DisplayName = "Stuffing Burst",
                Category = AbilityCategory.Magical,
                Element = ElementType.None,
                Power = 1.0f,
                MpCost = 6,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Gallus swells with gusting chaff!",
                CueAnimationTrigger = "StuffingBurst_Windup",
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
                        RequiredElement = ElementType.Fire,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        public static readonly AbilityBlueprint Gallus_BindTheRows =
            new AbilityBlueprint
            {
                Id = "Gallus_BindTheRows",
                DisplayName = "Bind the Rows",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 6,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Gallus knots the field lines.",
                CueAnimationTrigger = "BindRows_Windup",
                CanCrit = false,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Pierce,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        // ===== Bandit Captain Merrow =====

        public static readonly AbilityBlueprint Merrow_CommandFocusFire =
            new AbilityBlueprint
            {
                Id = "Merrow_CommandFocusFire",
                DisplayName = "Command: Focus Fire",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 0,
                TargetScope = TargetScope.AllAllies,
                HitsAllies = true,
                WindupTurns = 0,
                CueText = "Merrow barks orders to his crew!",
                CueAnimationTrigger = "Command",
                CanCrit = false
            };

        public static readonly AbilityBlueprint Merrow_Skullcracker =
            new AbilityBlueprint
            {
                Id = "Merrow_Skullcracker",
                DisplayName = "Skullcracker",
                Category = AbilityCategory.Physical,
                Element = ElementType.Blunt,
                Power = 1.4f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Merrow twirls his mace overhead.",
                CueAnimationTrigger = "Skullcracker_Windup",
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
                        CounterType = CounterType.Interrupt,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        public static readonly AbilityBlueprint Merrow_SmokeBomb =
            new AbilityBlueprint
            {
                Id = "Merrow_SmokeBomb",
                DisplayName = "Smoke Bomb",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 5,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "A thick smoke blankets the field.",
                CueAnimationTrigger = "SmokeBomb",
                CanCrit = false,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status = StatusType.Blind,
                        Chance = 1.0f,
                        Potency = 0f,
                        Duration = 2
                    }
                }
            };

        public static readonly AbilityBlueprint Merrow_CaptainsUltimatum =
            new AbilityBlueprint
            {
                Id = "Merrow_CaptainsUltimatum",
                DisplayName = "Captain's Ultimatum",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.3f,
                MpCost = 0,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 2,
                CueText = "Merrow bellows: 'Kneel or break!'",
                CueAnimationTrigger = "Ultimatum_Windup",
                CanCrit = true,
                IsUltimate = true,
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
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = true,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        public static IEnumerable<AbilityBlueprint> GetAll()
        {
            yield return Haystack_RustleSwipe;
            yield return Haystack_KindlingPuff;

            yield return FieldViper_FangJab;
            yield return FieldViper_CoilLunge;

            yield return Brigand_BackhandSlash;
            yield return Brigand_FeignStrike;

            yield return Gallus_PitchforkThrust;
            yield return Gallus_StuffingBurst;
            yield return Gallus_BindTheRows;

            yield return Merrow_CommandFocusFire;
            yield return Merrow_Skullcracker;
            yield return Merrow_SmokeBomb;
            yield return Merrow_CaptainsUltimatum;
        }
    }
}
