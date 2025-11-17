using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area1Enemies
    {
        public static readonly EnemyBlueprint HaystackShambler =
            new EnemyBlueprint
            {
                Id = "Enemy_HaystackShambler",
                DisplayName = "Haystack Shambler",
                Stats = new BattleStats
                {
                    level = 1,
                    maxHP = 65,
                    maxMP = 10,
                    atk = 10,
                    mag = 5,
                    def = 7,
                    res = 5,
                    spd = 8
                },
                ImmuneFear = true,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Fire,   Multiplier = 2.0f },
                    new AffinityBlueprint { Element = ElementType.Pierce, Multiplier = 0.5f }
                },
                AbilityIds = new List<string>
                {
                    Area1Abilities.Haystack_RustleSwipe.Id,
                    Area1Abilities.Haystack_KindlingPuff.Id
                },
                DefaultAttackId = Area1Abilities.Haystack_RustleSwipe.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 14,
                    Gold = 10,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "StrawClump",  Chance = 0.30f },
                        new DropBlueprint { ItemId = "TinderShard", Chance = 0.08f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area1Abilities.Haystack_KindlingPuff.Id,
                        Priority = 5
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TargetHasStatus,
                        StatusCheck = StatusType.Burn,
                        AbilityId = Area1Abilities.Haystack_RustleSwipe.Id,
                        FocusPoisoned = false,
                        Priority = 6
                    }
                }
            };

        public static readonly EnemyBlueprint FieldViper =
            new EnemyBlueprint
            {
                Id = "Enemy_FieldViper",
                DisplayName = "Field Viper",
                Stats = new BattleStats
                {
                    level = 2,
                    maxHP = 55,
                    maxMP = 12,
                    atk = 9,
                    mag = 7,
                    def = 5,
                    res = 7,
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
                    new AffinityBlueprint { Element = ElementType.Ice,   Multiplier = 2.0f }, // Weak: Ice
                    new AffinityBlueprint { Element = ElementType.Slash, Multiplier = 0.5f }  // Resist: Slash
                },
                AbilityIds = new List<string>
                {
                    Area1Abilities.FieldViper_FangJab.Id,
                    Area1Abilities.FieldViper_CoilLunge.Id
                },
                DefaultAttackId = Area1Abilities.FieldViper_FangJab.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 16,
                    Gold = 12,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "AntivenomHerb", Chance = 0.25f },
                        new DropBlueprint { ItemId = "ShedScale",     Chance = 0.10f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TargetHasStatus,
                        StatusCheck = StatusType.Poison,
                        AbilityId = Area1Abilities.FieldViper_FangJab.Id,
                        FocusPoisoned = true,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area1Abilities.FieldViper_CoilLunge.Id,
                        FocusHighestSPD = true,
                        Priority = 5
                    }
                }
            };

        public static readonly EnemyBlueprint RoadsideBrigand =
            new EnemyBlueprint
            {
                Id = "Enemy_RoadsideBrigand",
                DisplayName = "Roadside Brigand",
                Stats = new BattleStats
                {
                    level = 2,
                    maxHP = 80,
                    maxMP = 8,
                    atk = 12,
                    mag = 5,
                    def = 8,
                    res = 6,
                    spd = 10
                },
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Blunt,  Multiplier = 2.0f }, // Weak: Blunt
                    new AffinityBlueprint { Element = ElementType.Pierce, Multiplier = 0.5f }  // Resist: Pierce
                },
                AbilityIds = new List<string>
                {
                    Area1Abilities.Brigand_BackhandSlash.Id,
                    Area1Abilities.Brigand_FeignStrike.Id
                },
                DefaultAttackId = Area1Abilities.Brigand_BackhandSlash.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 18,
                    Gold = 15,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "TatteredBand", Chance = 0.20f },
                        new DropBlueprint { ItemId = "Whetstone",    Chance = 0.10f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area1Abilities.Brigand_FeignStrike.Id,
                        FocusLowestDEF = true,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area1Abilities.Brigand_BackhandSlash.Id,
                        FocusLowestDEF = true,
                        Priority = 1
                    }
                }
            };

        public static readonly EnemyBlueprint GallusScarecrowWarden =
            new EnemyBlueprint
            {
                Id = "Enemy_GallusScarecrowWarden",
                DisplayName = "Gallus, the Scarecrow Warden",
                Stats = new BattleStats
                {
                    level = 3,
                    maxHP = 200,
                    maxMP = 30,
                    atk = 16,
                    mag = 10,
                    def = 12,
                    res = 10,
                    spd = 9
                },
                ImmuneFear = true,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Fire,  Multiplier = 2.0f },
                    new AffinityBlueprint { Element = ElementType.Slash, Multiplier = 0.5f }
                },
                AbilityIds = new List<string>
                {
                    Area1Abilities.Gallus_PitchforkThrust.Id,
                    Area1Abilities.Gallus_StuffingBurst.Id,
                    Area1Abilities.Gallus_BindTheRows.Id
                },
                DefaultAttackId = Area1Abilities.Gallus_PitchforkThrust.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 60,
                    Gold = 50,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "WardensTwine", Chance = 0.15f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area1Abilities.Gallus_BindTheRows.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.HPBelowPercent,
                        HpThresholdPercent = 70,
                        AbilityId = Area1Abilities.Gallus_StuffingBurst.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area1Abilities.Gallus_PitchforkThrust.Id,
                        Priority = 1
                    }
                }
            };

        public static readonly EnemyBlueprint BanditCaptainMerrow =
            new EnemyBlueprint
            {
                Id = "Enemy_BanditCaptainMerrow",
                DisplayName = "Bandit Captain Merrow",
                Stats = new BattleStats
                {
                    level = 3,
                    maxHP = 320,
                    maxMP = 40,
                    atk = 20,
                    mag = 12,
                    def = 14,
                    res = 12,
                    spd = 12
                },
                ImmuneStagger = true,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Blunt, Multiplier = 2.0f }, // Weak: Blunt
                    new AffinityBlueprint { Element = ElementType.Slash, Multiplier = 0.5f }  // Resist: Slash
                },
                AbilityIds = new List<string>
                {
                    Area1Abilities.Merrow_CommandFocusFire.Id,
                    Area1Abilities.Merrow_Skullcracker.Id,
                    Area1Abilities.Merrow_SmokeBomb.Id,
                    Area1Abilities.Merrow_CaptainsUltimatum.Id
                },
                DefaultAttackId = Area1Abilities.Merrow_Skullcracker.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 120,
                    Gold = 120,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "CaptainsMace", Chance = 0.10f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area1Abilities.Merrow_CommandFocusFire.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.HPBelowPercent,
                        HpThresholdPercent = 50,
                        AbilityId = Area1Abilities.Merrow_CaptainsUltimatum.Id,
                        Priority = 8
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area1Abilities.Merrow_SmokeBomb.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area1Abilities.Merrow_Skullcracker.Id,
                        Priority = 1
                    }
                }
            };

        public static IEnumerable<EnemyBlueprint> GetAll()
        {
            yield return HaystackShambler;
            yield return FieldViper;
            yield return RoadsideBrigand;
            yield return GallusScarecrowWarden;
            yield return BanditCaptainMerrow;
        }
    }
}
