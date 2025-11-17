using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area4Enemies
    {
        // =========================================================
        // Fallen Templar
        // =========================================================

        public static readonly EnemyBlueprint FallenTemplar =
            new EnemyBlueprint
            {
                Id = "Enemy_FallenTemplar",
                DisplayName = "Fallen Templar",
                Stats = new BattleStats
                {
                    level = 9,
                    maxHP = 220,
                    maxMP = 30,
                    atk = 28,
                    mag = 12,
                    def = 24,
                    res = 18,
                    spd = 12
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Shadow, Multiplier = 2.0f }, // Weak: Shadow
                    new AffinityBlueprint { Element = ElementType.Holy,   Multiplier = 0.5f }  // Resist: Holy
                },
                AbilityIds = new List<string>
                {
                    Area4Abilities.FallenTemplar_RighteousCleave.Id,
                    Area4Abilities.FallenTemplar_AegisPrayer.Id
                },
                DefaultAttackId = Area4Abilities.FallenTemplar_RighteousCleave.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 60,
                    Gold = 55,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "CrackedRosary", Chance = 0.20f },
                        new DropBlueprint { ItemId = "TemplarPlate",  Chance = 0.05f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.IfBuffActive,
                        Negate = true,
                        AbilityId = Area4Abilities.FallenTemplar_AegisPrayer.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area4Abilities.FallenTemplar_RighteousCleave.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Shade Archer
        // =========================================================

        public static readonly EnemyBlueprint ShadeArcher =
            new EnemyBlueprint
            {
                Id = "Enemy_ShadeArcher",
                DisplayName = "Shade Archer",
                Stats = new BattleStats
                {
                    level = 10,
                    maxHP = 180,
                    maxMP = 25,
                    atk = 24,
                    mag = 18,
                    def = 14,
                    res = 16,
                    spd = 18
                },
                ImmuneFear = true,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Holy,   Multiplier = 2.0f }, // Weak: Holy
                    new AffinityBlueprint { Element = ElementType.Pierce, Multiplier = 0.5f }  // Resist: Pierce
                },
                AbilityIds = new List<string>
                {
                    Area4Abilities.ShadeArcher_UmbralShot.Id,
                    Area4Abilities.ShadeArcher_MarkedKill.Id
                },
                DefaultAttackId = Area4Abilities.ShadeArcher_UmbralShot.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 66,
                    Gold = 60,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "EbonFletching", Chance = 0.25f },
                        new DropBlueprint { ItemId = "ShadowThread",  Chance = 0.07f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area4Abilities.ShadeArcher_MarkedKill.Id,
                        FocusHighestATK = true,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area4Abilities.ShadeArcher_UmbralShot.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Siege Pyromancer
        // =========================================================

        public static readonly EnemyBlueprint SiegePyromancer =
            new EnemyBlueprint
            {
                Id = "Enemy_SiegePyromancer",
                DisplayName = "Siege Pyromancer",
                Stats = new BattleStats
                {
                    level = 10,
                    maxHP = 200,
                    maxMP = 60,
                    atk = 14,
                    mag = 28,
                    def = 16,
                    res = 20,
                    spd = 14
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Water, Multiplier = 2.0f }, // Weak: Water
                    new AffinityBlueprint { Element = ElementType.Ice,   Multiplier = 2.0f }, // Weak: Ice
                    new AffinityBlueprint { Element = ElementType.Fire,  Multiplier = 0.5f }  // Resist: Fire
                },
                AbilityIds = new List<string>
                {
                    Area4Abilities.SiegePyro_Firelance.Id,
                    Area4Abilities.SiegePyro_OilSlick.Id,
                    Area4Abilities.SiegePyro_IgniteField.Id
                },
                DefaultAttackId = Area4Abilities.SiegePyro_Firelance.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 70,
                    Gold = 65,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "Fireglass",   Chance = 0.22f },
                        new DropBlueprint { ItemId = "BattlePrimer", Chance = 0.06f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 4,
                        AbilityId = Area4Abilities.SiegePyro_OilSlick.Id,
                        Priority = 8
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area4Abilities.SiegePyro_IgniteField.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area4Abilities.SiegePyro_Firelance.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Knight-Marshal Vaust
        // =========================================================

        public static readonly EnemyBlueprint KnightMarshalVaust =
            new EnemyBlueprint
            {
                Id = "Enemy_KnightMarshalVaust",
                DisplayName = "Knight-Marshal Vaust",
                Stats = new BattleStats
                {
                    level = 11,
                    maxHP = 520,
                    maxMP = 50,
                    atk = 34,
                    mag = 18,
                    def = 28,
                    res = 24,
                    spd = 16
                },
                ImmuneFear = true,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = true,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 2.0f }, // Weak: Lightning
                    new AffinityBlueprint { Element = ElementType.Slash,     Multiplier = 0.5f }  // Resist: Slash
                },
                AbilityIds = new List<string>
                {
                    Area4Abilities.Vaust_FormationBreaker.Id,
                    Area4Abilities.Vaust_MarshalsEdict.Id,
                    Area4Abilities.Vaust_DuelistsVerdict.Id
                },
                DefaultAttackId = Area4Abilities.Vaust_FormationBreaker.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 230,
                    Gold = 240,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "MarshalBanner", Chance = 0.10f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area4Abilities.Vaust_MarshalsEdict.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area4Abilities.Vaust_FormationBreaker.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area4Abilities.Vaust_DuelistsVerdict.Id,
                        FocusHighestATK = true,
                        Priority = 5
                    }
                }
            };

        // =========================================================
        // Commander Serah of Arlin
        // =========================================================

        public static readonly EnemyBlueprint CommanderSerah =
            new EnemyBlueprint
            {
                Id = "Enemy_CommanderSerah",
                DisplayName = "Commander Serah of Arlin",
                Stats = new BattleStats
                {
                    level = 12,
                    maxHP = 900,
                    maxMP = 120,
                    atk = 36,
                    mag = 30,
                    def = 30,
                    res = 28,
                    spd = 20
                },
                ImmuneFear = true,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = true,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Shadow,   Multiplier = 2.0f }, // Weak: Shadow
                    new AffinityBlueprint { Element = ElementType.Holy,     Multiplier = 0.5f }, // Resist: Holy
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 0.5f } // Resist: Lightning
                },
                AbilityIds = new List<string>
                {
                    Area4Abilities.Serah_RoyalGuardArts.Id,
                    Area4Abilities.Serah_OathbreakerArc.Id,
                    Area4Abilities.Serah_RadiantReproach.Id,
                    Area4Abilities.Serah_CrownsJudgment.Id
                },
                DefaultAttackId = Area4Abilities.Serah_OathbreakerArc.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 420,
                    Gold = 500,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "SerahsEmblem", Chance = 0.15f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area4Abilities.Serah_RoyalGuardArts.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 2,
                        AbilityId = Area4Abilities.Serah_RoyalGuardArts.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.HPBelowPercent,
                        HpThresholdPercent = 60,
                        AbilityId = Area4Abilities.Serah_CrownsJudgment.Id,
                        Priority = 9
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 4,
                        AbilityId = Area4Abilities.Serah_CrownsJudgment.Id,
                        Priority = 8
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area4Abilities.Serah_RadiantReproach.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area4Abilities.Serah_OathbreakerArc.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Utility – enumerate all
        // =========================================================

        public static IEnumerable<EnemyBlueprint> GetAll()
        {
            yield return FallenTemplar;
            yield return ShadeArcher;
            yield return SiegePyromancer;
            yield return KnightMarshalVaust;
            yield return CommanderSerah;
        }
    }
}