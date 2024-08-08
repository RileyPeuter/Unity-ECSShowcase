using System.ComponentModel;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Burst;
using Unity.Jobs;
using Unity.VisualScripting;
using Unity.Mathematics;

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
