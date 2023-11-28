namespace chore_score_but_dragons.Repositories;
public class DragonRepository(IDbConnection db)
{
    // private readonly List<Dragon> _dragons;
    private readonly IDbConnection _db = db;

    internal List<Dragon> GetDragons()
    {
        string sql = "SELECT * FROM dragons;";
        // get the everything from the dragons table
        List<Dragon> dragons = _db.Query<Dragon>(sql).ToList();
        // Every row is being turned into a dragon and then turn what comes back into a list. Now return the dragons back to the service.
        // NOTE We don't have to async and await since Dapper does it for us
        // We will have to async and await to talk to auth
        return dragons;
    }
    // internal Dragon GetDragonById(int dragonId)
    // {
    //     Dragon dragon = _dragons.Find(dragon => dragon.Id == dragonId);
    //     return dragon;
    // }
    // internal Dragon AddDragon(Dragon dragonData)
    // {
    //     Dragon array = _dragons[^1];
    //     if (array == null)
    //     {
    //         dragonData.Id = 1;
    //     }
    //     else
    //     {
    //         dragonData.Id = array.Id + 1;
    //     }
    //     _dragons.Add(dragonData);
    //     return dragonData;
    // }
    // internal static Dragon UpdateDragon(Dragon foundDragon, Dragon dragonData)
    // {
    //     foundDragon.Name = dragonData.Name;
    //     foundDragon.Fur = dragonData.Fur;
    //     foundDragon.CanFly = dragonData.CanFly;
    //     foundDragon.Feathers = dragonData.Feathers;
    //     foundDragon.Scales = dragonData.Scales;
    //     foundDragon.BreathType = dragonData.BreathType;
    //     foundDragon.Eyes = dragonData.Eyes;
    //     foundDragon.FoundAt = dragonData.FoundAt;
    //     foundDragon.Wings = dragonData.Wings;
    //     foundDragon.Legs = dragonData.Legs;
    //     return foundDragon;
    // }
    // internal void RemoveDragon(Dragon dragon)
    // {
    //     _dragons.Remove(dragon);
    // }
}