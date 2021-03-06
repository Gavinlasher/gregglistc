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
    public ActionResult<List<House>> GetAll()
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
    [HttpGet("{id}")]
    public ActionResult<House> GetById(string id)
    {
      try
      {
        House house = _hs.GetById(id);
        return Ok(house);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> Delete(string id)
    {
      try
      {
        _hs.Delete(id);
        return Ok("deleted");
      }
      catch (System.Exception e)
      {

        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<House> Create([FromBody] House newHouse)
    {
      try
      {
        House house = _hs.Create(newHouse);
        return Ok(house);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<House> Edit(string id, [FromBody] House updates)
    {
      try
      {
        updates.Id = id;
        House updated = _hs.Edit(updates);
        return Ok(updated);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}