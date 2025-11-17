namespace KingdomArlin.Battle
{
    public interface ICombatActor
    {
        string DisplayName { get; }
        BattleStats BaseStats { get; }
        int CurrentHP { get; }
        int CurrentMP { get; }
        bool IsAlive { get; }

        int GetCurrentATK();
        int GetCurrentMAG();
        int GetCurrentDEF();
        int GetCurrentRES();
        int GetCurrentSPD();

        void ApplyDamage(int amount, ElementType element, DamageSourceType source, ICombatActor sourceActor, bool isCrit);
        void ConsumeMP(int amount);
        void ApplyStatus(StatusInstance status, ICombatActor sourceActor);
        bool HasStatus(StatusType type);
        void RemoveStatus(StatusType type);

        void OnTurnStart();
        void OnTurnEnd();
    }

    public interface IMoraleEventSink
    {
        void OnMoraleEvent(MoraleEventType type, ICombatActor source, ICombatActor target);
        float GetDamageMultiplier();
        float GetHealingMultiplier();
    }
}
