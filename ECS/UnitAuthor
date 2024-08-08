public class UnitAuthor : MonoBehaviour
{}

class UnitBaker : Baker<UnitAuthor>
{
    public override void Bake(UnitAuthor authoring)
    {
        Entity entity = GetEntity(TransformUsageFlags.None);
        AddComponent(entity, new Unit
        {
            unitType = UnitType.Soldier,
            health = 100, 
            controlled = true
        });
    }
}
