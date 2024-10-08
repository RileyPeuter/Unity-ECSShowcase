using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.Entities;
using UnityEngine;
using Unity.Burst;
using Unity.Jobs;

[BurstCompile]
public partial struct UnitActionJob : IJobEntity
{
    private void Execute(ref Unit unit)
    {
        if (unit.aIMode == AIMode.AttackMove || unit.aIMode == AIMode.HoldPosition)
        {
            switch (unit.unitType)
            {
                case UnitType.Soldier:
                    //attackAllInRange();
                    break;

                case UnitType.Mage:
                    //CheckCastAbility();
                    break;

                case UnitType.Healer:
                    //HealCharactersInRange();
                    break;
            }
        }
    }
}
