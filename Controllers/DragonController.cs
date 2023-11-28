namespace chore_score_but_dragons.Controllers;
[ApiController]
[Route("api/[controller]")]
public class DragonController(DragonService dragonService) : ControllerBase
{
    private readonly DragonService _dragonService = dragonService;

    [HttpGet]
    public ActionResult<List<Dragon>> GetDragons()
    {
        try
        {
            List<Dragon> dragons = _dragonService.GetDragons();
            return Ok(dragons);
        }
        catch (Exception error)
        {
            return BadRequest(error);
        }
    }
    // [HttpGet("{dragonId}")]
    // public ActionResult<Dragon> GetDragonById(int dragonId)
    // {
    //     try
    //     {
    //         Dragon dragon = _dragonService.GetDragonById(dragonId);
    //         return dragon;
    //     }
    //     catch (Exception error)
    //     {
    //         return BadRequest(error);
    //     }
    // }
    // [HttpPost]
    // public ActionResult<Dragon> AddDragon([FromBody] Dragon dragonData)
    // {
    //     try
    //     {
    //         Dragon dragon = _dragonService.AddDragon(dragonData);
    //         return Ok(dragon);
    //     }
    //     catch (Exception error)
    //     {
    //         return BadRequest(error.Message);
    //     }
    // }
    // [HttpPut("{dragonId}")]
    // public ActionResult<Dragon> UpdateDragon(int dragonId, [FromBody] Dragon dragonData)
    // {
    //     try
    //     {
    //         Dragon dragon = _dragonService.UpdateDragon(dragonId, dragonData);
    //         return dragon;
    //     }
    //     catch (Exception error)
    //     {
    //         return BadRequest(error.Message);
    //     }
    // }
    // [HttpDelete("{dragonId}")]
    // public ActionResult<Dragon> RemoveDragon(int dragonId)
    // {
    //     try
    //     {
    //         Dragon dragon = _dragonService.RemoveDragon(dragonId);
    //         return dragon;
    //     }
    //     catch (Exception error)
    //     {
    //         return BadRequest(error.Message);
    //     }
    // }
}