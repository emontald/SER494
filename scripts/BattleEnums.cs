namespace KingdomArlin.Battle
{
    public enum ElementType { None, Slash, Pierce, Blunt, Fire, Ice, Water, Lightning, Holy, Shadow }
    public enum AbilityCategory { Physical, Magical, Support }
    public enum TargetScope { SingleEnemy, AllEnemies, SingleAlly, AllAllies, RowEnemies, Self, AllCombatants }
    public enum StatusType {Bleed, Poison, Burn, Shock, slow, Stagger, Fear, Blind, ArmorDown, ResDown, AtkUp, AtkDown, DefUp, ResUp, MagUp, SpdUp, SpdDown, Wet, EvasionUp, Marked}
    public enum CounterType { None, Guard, SpreadGuard, Dispel, ElementHit, Interrupt, PositionSwap, DisplaceTarget, ExploitWeakness, ApplyWet }
    public enum CounterResultType { None, ReduceDamage50, Cancel, SelfStagger }
    public enum MoraleEventType { WeaknessHit, TelegraphedAttackCountered, TelegraphedAttackLanded, ActorKO }
    public enum DamageSourceType { Physical, Magical }
}
