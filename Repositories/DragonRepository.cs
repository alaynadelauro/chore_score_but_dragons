namespace chore_score_but_dragons.Repositories;
public class DragonRepository
{
    private List<Dragon> _dragons;
    public DragonRepository()
    {
        _dragons = [
            new Dragon(1, "Amphitere", 2, 0, true, true, false, "poison", 2, true, "South America"),
            new Dragon(2, "Drake", 0, 4, true, false, false, "fire", 2, false, "Europe"),
            new Dragon(3, "Long", 0, 4, true, true, true, "Laser", 2, true, "Asia"),
            new Dragon(4, "Dragon", 2, 4, true, false, false, "Fire", 2, true, "Europe"),
            new Dragon(5, "Wyvern", 2, 2, true, false, false, "Fire", 2, true, "Europe"),
        ];
    }
    internal List<Dragon> GetDragons()
    {
        return _dragons;
    }
    internal Dragon GetDragonById(int dragonId)
    {
        Dragon dragon = _dragons.Find(dragon => dragon.Id == dragonId);
        return dragon;
    }
    internal Dragon AddDragon(Dragon dragonData)
    {
        Dragon array = _dragons[^1];
        if (array == null)
        {
            dragonData.Id = 1;
        }
        else
        {
            dragonData.Id = array.Id + 1;
        }
        _dragons.Add(dragonData);
        return dragonData;
    }
    internal static Dragon UpdateDragon(Dragon foundDragon, Dragon dragonData)
    {
        foundDragon.Name = dragonData.Name;
        foundDragon.Fur = dragonData.Fur;
        foundDragon.CanFly = dragonData.CanFly;
        foundDragon.Feathers = dragonData.Feathers;
        foundDragon.Scales = dragonData.Scales;
        foundDragon.BreathType = dragonData.BreathType;
        foundDragon.Eyes = dragonData.Eyes;
        foundDragon.FoundAt = dragonData.FoundAt;
        foundDragon.Wings = dragonData.Wings;
        foundDragon.Legs = dragonData.Legs;
        return foundDragon;
    }
    internal void RemoveDragon(Dragon dragon)
    {
        _dragons.Remove(dragon);
    }
}