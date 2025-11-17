using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area3Enemies
    {
        // =========================================================
        // Cinder Imp
        // =========================================================

        public static readonly EnemyBlueprint CinderImp =
            new EnemyBlueprint
            {
                Id = "Enemy_CinderImp",
                DisplayName = "Cinder Imp",
                Stats = new BattleStats
                {
                    level = 6,
                    maxHP = 130,
                    maxMP = 40,
                    atk = 12,
                    mag = 22,
                    def = 10,
                    res = 14,
                    spd = 16
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = true,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Ice,  Multiplier = 2.0f }, // Weak: Ice
                    new AffinityBlueprint { Element = ElementType.Fire, Multiplier = 0.5f }  // Resist: Fire
                },
                AbilityIds = new List<string>
                {
                    Area3Abilities.CinderImp_SparkDart.Id,
                    Area3Abilities.CinderImp_CoalHeart.Id,
                    Area3Abilities.CinderImp_Flashflare.Id
                },
                DefaultAttackId = Area3Abilities.CinderImp_SparkDart.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 44,
                    Gold = 36,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "ImpEmber",   Chance = 0.30f },
                        new DropBlueprint { ItemId = "SootedHorn", Chance = 0.07f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area3Abilities.CinderImp_CoalHeart.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.IfBuffActive,
                        AbilityId = Area3Abilities.CinderImp_Flashflare.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area3Abilities.CinderImp_Flashflare.Id,
                        Priority = 5
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area3Abilities.CinderImp_SparkDart.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Lava Wyrmling
        // =========================================================

        public static readonly EnemyBlueprint LavaWyrmling =
            new EnemyBlueprint
            {
                Id = "Enemy_LavaWyrmling",
                DisplayName = "Lava Wyrmling",
                Stats = new BattleStats
                {
                    level = 7,
                    maxHP = 170,
                    maxMP = 20,
                    atk = 22,
                    mag = 12,
                    def = 16,
                    res = 12,
                    spd = 11
                },
                ImmuneFear = true,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Ice,   Multiplier = 2.0f }, // Weak: Ice
                    new AffinityBlueprint { Element = ElementType.Slash, Multiplier = 0.5f }, // Resist: Slash
                    new AffinityBlueprint { Element = ElementType.Fire,  Multiplier = 0.5f }  // Resist: Fire
                },
                AbilityIds = new List<string>
                {
                    Area3Abilities.LavaWyrmling_TailCrush.Id,
                    Area3Abilities.LavaWyrmling_MagmaSpit.Id
                },
                DefaultAttackId = Area3Abilities.LavaWyrmling_TailCrush.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 48,
                    Gold = 40,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "ScaleFragment", Chance = 0.25f },
                        new DropBlueprint { ItemId = "MoltenCore",    Chance = 0.05f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area3Abilities.LavaWyrmling_MagmaSpit.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area3Abilities.LavaWyrmling_TailCrush.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Basalt Sentinel
        // =========================================================

        public static readonly EnemyBlueprint BasaltSentinel =
            new EnemyBlueprint
            {
                Id = "Enemy_BasaltSentinel",
                DisplayName = "Basalt Sentinel",
                Stats = new BattleStats
                {
                    level = 8,
                    maxHP = 200,
                    maxMP = 10,
                    atk = 24,
                    mag = 8,
                    def = 22,
                    res = 16,
                    spd = 8
                },
                ImmuneFear = false,
                ImmuneBleed = true,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 2.0f }, // Weak: Lightning
                    new AffinityBlueprint { Element = ElementType.Water,     Multiplier = 2.0f }, // Weak: Water
                    new AffinityBlueprint { Element = ElementType.Blunt,     Multiplier = 0.5f }  // Resist: Blunt
                },
                AbilityIds = new List<string>
                {
                    Area3Abilities.BasaltSentinel_GuardbreakChop.Id,
                    Area3Abilities.BasaltSentinel_StoneStance.Id,
                    Area3Abilities.BasaltSentinel_SeismicStamp.Id
                },
                DefaultAttackId = Area3Abilities.BasaltSentinel_GuardbreakChop.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 52,
                    Gold = 44,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "BasaltPlate",  Chance = 0.22f },
                        new DropBlueprint { ItemId = "EarthenSigil", Chance = 0.06f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area3Abilities.BasaltSentinel_StoneStance.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area3Abilities.BasaltSentinel_SeismicStamp.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area3Abilities.BasaltSentinel_GuardbreakChop.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Pyrebound Duo – Ash
        // =========================================================

        public static readonly EnemyBlueprint PyreboundAsh =
            new EnemyBlueprint
            {
                Id = "Enemy_PyreboundAsh",
                DisplayName = "Ash",
                Stats = new BattleStats
                {
                    level = 8,
                    maxHP = 220,
                    maxMP = 40,
                    atk = 20,
                    mag = 20,
                    def = 16,
                    res = 16,
                    spd = 14
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = true,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Ice,  Multiplier = 2.0f }, // Weak: Ice
                    new AffinityBlueprint { Element = ElementType.Fire, Multiplier = 0.5f }  // Resist: Fire
                },
                AbilityIds = new List<string>
                {
                    Area3Abilities.Ash_FlameWhip.Id,
                    Area3Abilities.Ash_SearingLine.Id,
                    Area3Abilities.Duo_Conflagrate.Id
                },
                DefaultAttackId = Area3Abilities.Ash_FlameWhip.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 170,
                    Gold = 180,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "AshsLash", Chance = 0.08f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 4,
                        AbilityId = Area3Abilities.Duo_Conflagrate.Id,
                        Priority = 9
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area3Abilities.Ash_SearingLine.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area3Abilities.Ash_FlameWhip.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Pyrebound Duo – Cask
        // =========================================================

        public static readonly EnemyBlueprint PyreboundCask =
            new EnemyBlueprint
            {
                Id = "Enemy_PyreboundCask",
                DisplayName = "Cask",
                Stats = new BattleStats
                {
                    level = 8,
                    maxHP = 220,
                    maxMP = 40,
                    atk = 20,
                    mag = 20,
                    def = 16,
                    res = 16,
                    spd = 14
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = true,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Ice,  Multiplier = 2.0f }, // Weak: Ice
                    new AffinityBlueprint { Element = ElementType.Fire, Multiplier = 0.5f }  // Resist: Fire
                },
                AbilityIds = new List<string>
                {
                    Area3Abilities.Cask_DetonatingToss.Id,
                    Area3Abilities.Cask_PowderKeg.Id,
                    Area3Abilities.Duo_Conflagrate.Id
                },
                DefaultAttackId = Area3Abilities.Cask_DetonatingToss.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 170,
                    Gold = 180,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "CasksBandolier", Chance = 0.08f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 4,
                        AbilityId = Area3Abilities.Duo_Conflagrate.Id,
                        Priority = 9
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area3Abilities.Cask_PowderKeg.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area3Abilities.Cask_DetonatingToss.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Boss: Obsidian Goliath
        // =========================================================

        public static readonly EnemyBlueprint ObsidianGoliath =
            new EnemyBlueprint
            {
                Id = "Enemy_ObsidianGoliath",
                DisplayName = "Obsidian Goliath",
                Stats = new BattleStats
                {
                    level = 9,
                    maxHP = 650,
                    maxMP = 60,
                    atk = 30,
                    mag = 22,
                    def = 26,
                    res = 20,
                    spd = 10
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = true,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 2.0f }, // Weak: Lightning
                    new AffinityBlueprint { Element = ElementType.Fire,      Multiplier = 0.5f }, // Resist: Fire
                    new AffinityBlueprint { Element = ElementType.Blunt,     Multiplier = 0.5f }  // Resist: Blunt
                },
                AbilityIds = new List<string>
                {
                    Area3Abilities.Goliath_VolcanicBackhand.Id,
                    Area3Abilities.Goliath_CoreOverheat.Id,
                    Area3Abilities.Goliath_ObsidianShatter.Id,
                    Area3Abilities.Goliath_CataclysmHeel.Id
                },
                DefaultAttackId = Area3Abilities.Goliath_VolcanicBackhand.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 260,
                    Gold = 300,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "GoliathCore", Chance = 0.10f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area3Abilities.Goliath_CoreOverheat.Id,
                        Priority = 8
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 2,
                        AbilityId = Area3Abilities.Goliath_ObsidianShatter.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.HPBelowPercent,
                        HpThresholdPercent = 50,
                        AbilityId = Area3Abilities.Goliath_CataclysmHeel.Id,
                        Priority = 9
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area3Abilities.Goliath_VolcanicBackhand.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Utility – enumerate all
        // =========================================================

        public static IEnumerable<EnemyBlueprint> GetAll()
        {
            yield return CinderImp;
            yield return LavaWyrmling;
            yield return BasaltSentinel;
            yield return PyreboundAsh;
            yield return PyreboundCask;
            yield return ObsidianGoliath;
        }
    }
}
