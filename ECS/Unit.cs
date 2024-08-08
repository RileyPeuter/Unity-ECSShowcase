using Unity.Entities;

public struct Unit : IComponentData
{
    public AIMode aIMode;
    public UnitType unitType;    
    public int health;
    public bool controlled;
    public int moveSpeed;
}
