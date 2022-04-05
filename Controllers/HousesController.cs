using gregglistc.Services;
using gregglistc.Models;
using Microsoft.AspNetCore.Mvc;

namespace gregglistc.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesServices _hs;
    public HousesController(HousesServices hs)
    {
      _hs = hs;
    }

    [HttpGet]
    public ActionResult<List<House>> get()
    {
      try
      {
        List<House> houses = _hs.GetAll();
        return Ok(houses);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}