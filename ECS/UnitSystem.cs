public partial struct UnitSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        UnitMoveAI unitAIJob = new UnitMoveAI { deltaTime = SystemAPI.Time.DeltaTime };
        unitAIJob.Schedule();

        UnitActionAI unitActionAIJob = new UnitActionAI();
        unitActionAIJob.Schedule();
    }
}
