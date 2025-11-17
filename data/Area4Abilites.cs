using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area4Abilities
    {
        // =========================================================
        // Fallen Templar
        // =========================================================

        public static readonly AbilityBlueprint FallenTemplar_RighteousCleave =
            new AbilityBlueprint
            {
                Id = "FallenTemplar_RighteousCleave",
                DisplayName = "Righteous Cleave",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.1f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "RighteousCleave",
                CanCrit = true
            };

        public static readonly AbilityBlueprint FallenTemplar_AegisPrayer =
            new AbilityBlueprint
            {
                Id = "FallenTemplar_AegisPrayer",
                DisplayName = "Aegis Prayer",
                Category = AbilityCategory.Support,
                Element = ElementType.Holy,
                Power = 0f,
                MpCost = 6,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 1,
                CueText = "A fractured hymn resonates.",
                CueAnimationTrigger = "AegisPrayer_Windup",
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
                        RequiredElement = ElementType.Shadow,
                        RequiresDispelStanceOrBuff = false,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        // =========================================================
        // Shade Archer
        // =========================================================

        public static readonly AbilityBlueprint ShadeArcher_UmbralShot =
            new AbilityBlueprint
            {
                Id = "ShadeArcher_UmbralShot",
                DisplayName = "Umbral Shot",
                Category = AbilityCategory.Physical,
                Element = ElementType.Shadow,
                Power = 1.0f,
                MpCost = 0,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "UmbralShot",
                CanCrit = true,
                StatusOnHit = new List<StatusOnHitBlueprint>
                {
                    new StatusOnHitBlueprint
                    {
                        Status   = StatusType.Fear,
                        Chance   = 0.20f,
                        Potency  = 0f,
                        Duration = 2
                    }
                }
            };

        public static readonly AbilityBlueprint ShadeArcher_MarkedKill =
            new AbilityBlueprint
            {
                Id = "ShadeArcher_MarkedKill",
                DisplayName = "Marked Kill",
                Category = AbilityCategory.Physical,
                Element = ElementType.Pierce,
                Power = 1.3f,
                MpCost = 4,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "A sigil locks over a hero.",
                CueAnimationTrigger = "MarkedKill_Windup",
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
                        RequiredElement = ElementType.Holy,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Siege Pyromancer
        // =========================================================

        public static readonly AbilityBlueprint SiegePyro_Firelance =
            new AbilityBlueprint
            {
                Id = "SiegePyro_Firelance",
                DisplayName = "Firelance",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.1f,
                MpCost = 4,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "Firelance",
                CanCrit = true
            };

        public static readonly AbilityBlueprint SiegePyro_OilSlick =
            new AbilityBlueprint
            {
                Id = "SiegePyro_OilSlick",
                DisplayName = "Oil Slick",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 8,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Oil splashes underfoot.",
                CueAnimationTrigger = "OilSlick_Windup",
                CanCrit = false,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.Cancel
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Water,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        public static readonly AbilityBlueprint SiegePyro_IgniteField =
            new AbilityBlueprint
            {
                Id = "SiegePyro_IgniteField",
                DisplayName = "Ignite Field",
                Category = AbilityCategory.Magical,
                Element = ElementType.Fire,
                Power = 1.4f,
                MpCost = 10,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "He raises a spark over the slick.",
                CueAnimationTrigger = "IgniteField_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Water,
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
        // Knight-Marshal Vaust
        // =========================================================

        public static readonly AbilityBlueprint Vaust_FormationBreaker =
            new AbilityBlueprint
            {
                Id = "Vaust_FormationBreaker",
                DisplayName = "Formation Breaker",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.1f,
                MpCost = 0,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 0,
                CueText = "",
                CueAnimationTrigger = "FormationBreaker",
                CanCrit = true
            };

        public static readonly AbilityBlueprint Vaust_MarshalsEdict =
            new AbilityBlueprint
            {
                Id = "Vaust_MarshalsEdict",
                DisplayName = "Marshal's Edict",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 6,
                TargetScope = TargetScope.AllAllies,
                HitsAllies = true,
                WindupTurns = 1,
                CueText = "Vaust plants his banner.",
                CueAnimationTrigger = "MarshalsEdict_Windup",
                CanCrit = false,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.Cancel
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.ElementHit,
                        RequiredElement = ElementType.Pierce,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        public static readonly AbilityBlueprint Vaust_DuelistsVerdict =
            new AbilityBlueprint
            {
                Id = "Vaust_DuelistsVerdict",
                DisplayName = "Duelist's Verdict",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.6f,
                MpCost = 6,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "He salutes; blade gleams.",
                CueAnimationTrigger = "DuelistsVerdict_Windup",
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

        // =========================================================
        // Commander Serah of Arlin
        // =========================================================

        public static readonly AbilityBlueprint Serah_RoyalGuardArts =
            new AbilityBlueprint
            {
                Id = "Serah_RoyalGuardArts",
                DisplayName = "Royal Guard Arts",
                Category = AbilityCategory.Support,
                Element = ElementType.None,
                Power = 0f,
                MpCost = 0,
                TargetScope = TargetScope.Self,
                HitsAllies = true,
                WindupTurns = 0,
                CueText = "She shifts her stance.",
                CueAnimationTrigger = "RoyalGuardArts",
                CanCrit = false
            };

        public static readonly AbilityBlueprint Serah_OathbreakerArc =
            new AbilityBlueprint
            {
                Id = "Serah_OathbreakerArc",
                DisplayName = "Oathbreaker Arc",
                Category = AbilityCategory.Physical,
                Element = ElementType.Slash,
                Power = 1.2f,
                MpCost = 6,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "Her cape snaps in a cutting arc.",
                CueAnimationTrigger = "OathbreakerArc_Windup",
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
                        RequiredElement = ElementType.Shadow,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        public static readonly AbilityBlueprint Serah_RadiantReproach =
            new AbilityBlueprint
            {
                Id = "Serah_RadiantReproach",
                DisplayName = "Radiant Reproach",
                Category = AbilityCategory.Magical,
                Element = ElementType.Holy,
                Power = 1.4f,
                MpCost = 10,
                TargetScope = TargetScope.SingleEnemy,
                HitsAllies = false,
                WindupTurns = 1,
                CueText = "A sigil of Arlin blooms.",
                CueAnimationTrigger = "RadiantReproach_Windup",
                CanCrit = true,
                Counters = new List<CounterBlueprint>
                {
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Dispel,
                        RequiredElement = ElementType.None,
                        RequiresDispelStanceOrBuff = true,
                        Result = CounterResultType.Cancel
                    },
                    new CounterBlueprint
                    {
                        CounterType = CounterType.Interrupt,
                        RequiredElement = ElementType.None,
                        Result = CounterResultType.Cancel
                    }
                }
            };

        public static readonly AbilityBlueprint Serah_CrownsJudgment =
            new AbilityBlueprint
            {
                Id = "Serah_CrownsJudgment",
                DisplayName = "Crown's Judgment",
                Category = AbilityCategory.Magical,
                Element = ElementType.Holy,
                Power = 1.6f,
                MpCost = 16,
                TargetScope = TargetScope.AllEnemies,
                HitsAllies = false,
                WindupTurns = 2,
                CueText = "Serah plants her sword; the sigil climbs the sky.",
                CueAnimationTrigger = "CrownsJudgment_Windup",
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
                        CounterType = CounterType.ExploitWeakness,
                        RequiredElement = ElementType.Shadow,
                        Result = CounterResultType.ReduceDamage50
                    }
                }
            };

        // =========================================================
        // Utility – enumerate all
        // =========================================================

        public static IEnumerable<AbilityBlueprint> GetAll()
        {
            yield return FallenTemplar_RighteousCleave;
            yield return FallenTemplar_AegisPrayer;

            yield return ShadeArcher_UmbralShot;
            yield return ShadeArcher_MarkedKill;

            yield return SiegePyro_Firelance;
            yield return SiegePyro_OilSlick;
            yield return SiegePyro_IgniteField;

            yield return Vaust_FormationBreaker;
            yield return Vaust_MarshalsEdict;
            yield return Vaust_DuelistsVerdict;

            yield return Serah_RoyalGuardArts;
            yield return Serah_OathbreakerArc;
            yield return Serah_RadiantReproach;
            yield return Serah_CrownsJudgment;
        }
    }
}