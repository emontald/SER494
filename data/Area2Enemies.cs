using System.Collections.Generic;
using KingdomArlin.Battle;

namespace KingdomArlin.Data
{
    public static class Area2Enemies
    {
        // =========================================================
        // Bog Shambler
        // =========================================================

        public static readonly EnemyBlueprint BogShambler =
            new EnemyBlueprint
            {
                Id = "Enemy_BogShambler",
                DisplayName = "Bog Shambler",
                Stats = new BattleStats
                {
                    level = 4,
                    maxHP = 110,
                    maxMP = 12,
                    atk = 14,
                    mag = 10,
                    def = 14,
                    res = 12,
                    spd = 7
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = true,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Fire,  Multiplier = 2.0f }, // Weak: Fire
                    new AffinityBlueprint { Element = ElementType.Blunt, Multiplier = 0.5f }  // Resist: Blunt
                },
                AbilityIds = new List<string>
                {
                    Area2Abilities.BogShambler_MireSlam.Id,
                    Area2Abilities.BogShambler_SoddenGrasp.Id
                },
                DefaultAttackId = Area2Abilities.BogShambler_MireSlam.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 28,
                    Gold = 22,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "MireResin",  Chance = 0.30f },
                        new DropBlueprint { ItemId = "SpongyCore", Chance = 0.08f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area2Abilities.BogShambler_SoddenGrasp.Id,
                        Priority = 5
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area2Abilities.BogShambler_MireSlam.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Fen Pixie
        // =========================================================

        public static readonly EnemyBlueprint FenPixie =
            new EnemyBlueprint
            {
                Id = "Enemy_FenPixie",
                DisplayName = "Fen Pixie",
                Stats = new BattleStats
                {
                    level = 4,
                    maxHP = 75,
                    maxMP = 30,
                    atk = 8,
                    mag = 16,
                    def = 7,
                    res = 12,
                    spd = 15
                },
                ImmuneFear = true,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Blunt,    Multiplier = 2.0f }, // Weak: Blunt
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 2.0f }, // Weak: Lightning
                    new AffinityBlueprint { Element = ElementType.Ice,       Multiplier = 0.5f }  // Resist: Ice
                },
                AbilityIds = new List<string>
                {
                    Area2Abilities.FenPixie_GlamerBolt.Id,
                    Area2Abilities.FenPixie_WispVeil.Id
                },
                DefaultAttackId = Area2Abilities.FenPixie_GlamerBolt.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 30,
                    Gold = 24,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "PixieDust",    Chance = 0.25f },
                        new DropBlueprint { ItemId = "GossamerWing", Chance = 0.06f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area2Abilities.FenPixie_WispVeil.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.IfBuffActive,
                        Negate = true, // if NOT buffed
                        AbilityId = Area2Abilities.FenPixie_WispVeil.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area2Abilities.FenPixie_GlamerBolt.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Swamp Leech
        // =========================================================

        public static readonly EnemyBlueprint SwampLeech =
            new EnemyBlueprint
            {
                Id = "Enemy_SwampLeech",
                DisplayName = "Swamp Leech",
                Stats = new BattleStats
                {
                    level = 5,
                    maxHP = 95,
                    maxMP = 15,
                    atk = 13,
                    mag = 10,
                    def = 9,
                    res = 10,
                    spd = 11
                },
                ImmuneFear = false,
                ImmuneBleed = true,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Fire,   Multiplier = 2.0f }, // Weak: Fire
                    new AffinityBlueprint { Element = ElementType.Pierce, Multiplier = 0.5f }  // Resist: Pierce
                },
                AbilityIds = new List<string>
                {
                    Area2Abilities.SwampLeech_DrainBite.Id,
                    Area2Abilities.SwampLeech_SwellSpurt.Id
                },
                DefaultAttackId = Area2Abilities.SwampLeech_DrainBite.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 32,
                    Gold = 26,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "CoagulatedIchor", Chance = 0.30f },
                        new DropBlueprint { ItemId = "LeechTongue",     Chance = 0.05f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area2Abilities.SwampLeech_SwellSpurt.Id,
                        Priority = 5
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area2Abilities.SwampLeech_DrainBite.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Mini-Boss: Muckrime Matron
        // =========================================================

        public static readonly EnemyBlueprint MuckrimeMatron =
            new EnemyBlueprint
            {
                Id = "Enemy_MuckrimeMatron",
                DisplayName = "Muckrime Matron",
                Stats = new BattleStats
                {
                    level = 5,
                    maxHP = 280,
                    maxMP = 50,
                    atk = 16,
                    mag = 20,
                    def = 14,
                    res = 16,
                    spd = 10
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = true,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = false,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 2.0f }, // Weak: Lightning
                    new AffinityBlueprint { Element = ElementType.Fire,      Multiplier = 0.5f }  // Resist: Fire
                },
                AbilityIds = new List<string>
                {
                    Area2Abilities.Matron_AcidGlob.Id,
                    Area2Abilities.Matron_BroodCall.Id,
                    Area2Abilities.Matron_CausticFlood.Id
                },
                DefaultAttackId = Area2Abilities.Matron_AcidGlob.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 95,
                    Gold = 90,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "MatronSlime", Chance = 0.12f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 1,
                        AbilityId = Area2Abilities.Matron_BroodCall.Id,
                        OncePerBattle = true,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 3,
                        AbilityId = Area2Abilities.Matron_CausticFlood.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area2Abilities.Matron_AcidGlob.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Boss: The Bracken Warden
        // =========================================================

        public static readonly EnemyBlueprint BrackenWarden =
            new EnemyBlueprint
            {
                Id = "Enemy_BrackenWarden",
                DisplayName = "The Bracken Warden",
                Stats = new BattleStats
                {
                    level = 6,
                    maxHP = 420,
                    maxMP = 70,
                    atk = 18,
                    mag = 24,
                    def = 16,
                    res = 18,
                    spd = 12
                },
                ImmuneFear = false,
                ImmuneBleed = false,
                ImmunePoison = false,
                ImmuneBurn = false,
                ImmuneStagger = false,
                ImmuneSlow = true,
                Affinities = new List<AffinityBlueprint>
                {
                    new AffinityBlueprint { Element = ElementType.Lightning, Multiplier = 2.0f }, // Weak: Lightning
                    new AffinityBlueprint { Element = ElementType.Ice,       Multiplier = 0.5f }  // Resist: Ice
                },
                AbilityIds = new List<string>
                {
                    Area2Abilities.Warden_ThornBarrage.Id,
                    Area2Abilities.Warden_BoglightJudgment.Id,
                    Area2Abilities.Warden_MirePact.Id
                },
                DefaultAttackId = Area2Abilities.Warden_ThornBarrage.Id,
                Reward = new RewardBlueprint
                {
                    Exp = 160,
                    Gold = 170,
                    Drops = new List<DropBlueprint>
                    {
                        new DropBlueprint { ItemId = "WardensSigil", Chance = 0.10f }
                    }
                },
                AIRules = new List<AIRuleBlueprint>
                {
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.HPBelowPercent,
                        HpThresholdPercent = 50,
                        AbilityId = Area2Abilities.Warden_MirePact.Id,
                        Priority = 10
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 4,
                        AbilityId = Area2Abilities.Warden_MirePact.Id,
                        Priority = 7
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.TurnInterval,
                        IntervalTurns = 2,
                        AbilityId = Area2Abilities.Warden_BoglightJudgment.Id,
                        Priority = 6
                    },
                    new AIRuleBlueprint
                    {
                        ConditionType = EnemyAIConditionType.Always,
                        AbilityId = Area2Abilities.Warden_ThornBarrage.Id,
                        Priority = 1
                    }
                }
            };

        // =========================================================
        // Utility: enumerate all
        // =========================================================

        public static IEnumerable<EnemyBlueprint> GetAll()
        {
            yield return BogShambler;
            yield return FenPixie;
            yield return SwampLeech;
            yield return MuckrimeMatron;
            yield return BrackenWarden;
        }
    }
}
