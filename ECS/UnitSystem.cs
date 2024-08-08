public partial struct UnitSystem : ISystem
{
    public void OnUpdate(ref SystemState state)
    {
        UnitMoveJob moveJob = new UnitMoveJob { deltaTime = SystemAPI.Time.DeltaTime };
        moveJob.Schedule();

        UnitActionJob unitActionJob = new UnitActionJob();
        UnitActionJob.Schedule();
    }
}
