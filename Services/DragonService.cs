using Microsoft.AspNetCore.Http.HttpResults;

namespace chore_score_but_dragons.Services;
public class DragonService(DragonRepository dragonRepository)
{
    private readonly DragonRepository _dragonRepository = dragonRepository;

    internal List<Dragon> GetDragons()
    {
        List<Dragon> dragons = _dragonRepository.GetDragons();
        return dragons;
    }
    internal Dragon GetDragonById(int dragonId)
    {
        if (dragonId == 0)
        {
            throw new Exception("Id cannot = 0");
        }
        Dragon dragon = _dragonRepository.GetDragonById(dragonId) ?? throw new Exception($"{dragonId} is not a valid Id");
        return dragon;
    }
    internal Dragon AddDragon(Dragon dragonData)
    {
        if (dragonData.Name == null)
        {
            throw new Exception("What type of dragon are you recording?");
        }
        if (dragonData.FoundAt == null)
        {
            throw new Exception("What part of the world did you find this dragon?");
        }
        Dragon dragon = _dragonRepository.AddDragon(dragonData);
        return dragon;
    }
    internal Dragon UpdateDragon(int dragonId, Dragon dragonData)
    {
        Dragon foundDragon = GetDragonById(dragonId);
        Dragon updatedDragon = DragonRepository.UpdateDragon(foundDragon, dragonData);
        return updatedDragon;
    }
}