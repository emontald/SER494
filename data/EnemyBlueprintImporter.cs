#if UNITY_EDITOR
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using KingdomArlin.Battle;
using KingdomArlin.Data;

public static class EnemyBlueprintImporter
{
    private const string EnemyAssetPath = "Assets/GameData/Enemies";
    private const string AbilityAssetPath = "Assets/GameData/Abilities";

    [MenuItem("Arlin/Generate Abilities From Blueprints")]
    public static void GenerateAbilities()
    {
        Directory.CreateDirectory(AbilityAssetPath);

        var allAbilityBps =
            Area1Abilities.GetAll()
            .Concat(Area2Abilities.GetAll());
            .Concat(Area3Abilities.GetAll())
            .Concat(Area4Abilities.GetAll());

        foreach (var bp in allAbilityBps)
        {
            var path = $"{AbilityAssetPath}/{bp.Id}.asset";
            var asset = AssetDatabase.LoadAssetAtPath<AbilityDefinition>(path);
            if (asset == null)
            {
                asset = ScriptableObject.CreateInstance<AbilityDefinition>();
                AssetDatabase.CreateAsset(asset, path);
            }

            asset.abilityId = bp.Id;
            asset.displayName = bp.DisplayName;
            asset.description = ""; // optional
            asset.category = bp.Category;
            asset.element = bp.Element;
            asset.power = bp.Power;
            asset.mpCost = bp.MpCost;
            asset.targetScope = bp.TargetScope;
            asset.hitsAllies = bp.HitsAllies;
            asset.windupTurns = bp.WindupTurns;
            asset.cueText = bp.CueText;
            asset.cueAnimationTrigger = bp.CueAnimationTrigger;
            asset.canCrit = bp.CanCrit;
            asset.ignoresDefense = bp.IgnoresDefense;
            asset.isUltimate = bp.IsUltimate;

            // Counters
            asset.counters.Clear();
            foreach (var c in bp.Counters)
            {
                var cond = new CounterCondition
                {
                    counterType = c.CounterType,
                    requiredElement = c.RequiredElement,
                    requiresDispelStanceOrBuff = c.RequiresDispelStanceOrBuff,
                    resultOnSuccess = c.Result
                };
                asset.counters.Add(cond);
            }

            // Status on hit
            asset.statusOnHit.Clear();
            foreach (var s in bp.StatusOnHit)
            {
                var soh = new StatusOnHit
                {
                    statusType = s.Status,
                    chance = s.Chance,
                    potency = s.Potency,
                    durationTurns = s.Duration
                };
                asset.statusOnHit.Add(soh);
            }

            EditorUtility.SetDirty(asset);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }

    [MenuItem("Arlin/Generate Enemies From Blueprints")]
    public static void GenerateEnemies()
    {
        Directory.CreateDirectory(EnemyAssetPath);

        var allEnemyBps =
            Area1Enemies.GetAll()
            .Concat(Area2Enemies.GetAll());
            .Concat(Area3Enemies.GetAll())
            .Concat(Area4Enemies.GetAll());

        foreach (var bp in allEnemyBps)
        {
            var path = $"{EnemyAssetPath}/{bp.Id}.asset";
            var asset = AssetDatabase.LoadAssetAtPath<EnemyDefinition>(path);
            if (asset == null)
            {
                asset = ScriptableObject.CreateInstance<EnemyDefinition>();
                AssetDatabase.CreateAsset(asset, path);
            }

            asset.enemyId = bp.Id;
            asset.displayName = bp.DisplayName;
            asset.baseStats = bp.Stats;

            // Affinities
            asset.affinities.Clear();
            foreach (var a in bp.Affinities)
            {
                asset.affinities.Add(new ElementAffinity(a.Element, a.Multiplier));
            }

            // Rewards
            asset.reward.exp = bp.Reward.Exp;
            asset.reward.gold = bp.Reward.Gold;
            asset.reward.drops = bp.Reward.Drops
                .Select(d => new DropEntry { itemId = d.ItemId, dropChance = d.Chance })
                .ToList();

            asset.immuneFear = bp.ImmuneFear;
            asset.immuneBleed = bp.ImmuneBleed;
            asset.immunePoison = bp.ImmunePoison;
            asset.immuneBurn = bp.ImmuneBurn;
            asset.immuneStagger = bp.ImmuneStagger;
            asset.immuneSlow = bp.ImmuneSlow;

            // Ability references
            asset.abilitySet.Clear();
            foreach (var abilityId in bp.AbilityIds)
            {
                var abilityPath = $"{AbilityAssetPath}/{abilityId}.asset";
                var ability = AssetDatabase.LoadAssetAtPath<AbilityDefinition>(abilityPath);
                if (ability != null)
                    asset.abilitySet.Add(ability);

                if (abilityId == bp.DefaultAttackId)
                    asset.defaultAttack = ability;
            }

            // AI rules
            asset.aiRules.Clear();
            foreach (var ruleBp in bp.AIRules)
            {
                var abilityPath = $"{AbilityAssetPath}/{ruleBp.AbilityId}.asset";
                var ability = AssetDatabase.LoadAssetAtPath<AbilityDefinition>(abilityPath);

                var rule = new EnemyAIRule
                {
                    conditionType = ruleBp.ConditionType,
                    intervalTurns = ruleBp.IntervalTurns,
                    hpThresholdPercent = ruleBp.HpThresholdPercent,
                    statusCheck = ruleBp.StatusCheck,
                    negateCondition = ruleBp.Negate,
                    focusLowestDEF = ruleBp.FocusLowestDEF,
                    focusHighestATK = ruleBp.FocusHighestATK,
                    focusHighestSPD = ruleBp.FocusHighestSPD,
                    focusPoisoned = ruleBp.FocusPoisoned,
                    focusBleeding = ruleBp.FocusBleeding,
                    focusMarkedTarget = ruleBp.FocusMarked,
                    ability = ability,
                    oncePerBattle = ruleBp.OncePerBattle,
                    priority = ruleBp.Priority
                };

                asset.aiRules.Add(rule);
            }

            EditorUtility.SetDirty(asset);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
    }
}
#endif