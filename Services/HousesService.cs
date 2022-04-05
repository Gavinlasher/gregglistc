using gregglistc.Db;
using gregglistc.Models;

namespace gregglistc.Services
{
  public class HousesServices
  {
    internal List<House> GetAll()
    {
      return FakeDb.Houses;
    }
  }
}