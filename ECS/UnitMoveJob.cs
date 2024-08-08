using System.ComponentModel;
using Unity.Entities;
using UnityEngine;
using Unity.Transforms;
using Unity.Burst;
using Unity.Jobs;
using Unity.VisualScripting;
using Unity.Mathematics;

[BurstCompile]
public partial struct UnitMoveJob : IJobEntity
{
    public float deltaTime;
    private void Execute(ref Unit unit, ref LocalTransform tranform)
    {
        switch (unit.aIMode)
        {
            case AIMode.AttackMove:
                tranform.Translate(new float3(1 * unit.moveSpeed * deltaTime, 0, 0));
                break;

            case AIMode.HoldPosition:
                //Doesn't move
                break;

            case AIMode.RunAway:
                tranform.Translate(new float3(-1 * unit.moveSpeed * deltaTime, 0, 0));
                break;
        }
    }
}
