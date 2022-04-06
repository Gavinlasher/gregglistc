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

    internal House GetById(string id)
    {
      House found = FakeDb.Houses.Find(h => h.Id == id);
      if (found == null)
      {
        throw new Exception("invaild Id");
      }
      return found;
    }

    internal void Delete(string id)
    {
      House found = GetById(id);
      FakeDb.Houses.Remove(found);

    }
    internal House Create(House newHouse)
    {
      FakeDb.Houses.Add(newHouse);
      return newHouse;
    }

    internal House Edit(House updates)
    {
      House og = GetById(updates.Id);

      og.Bedrooms = updates.Bedrooms != null ? updates.Bedrooms : og.Bedrooms;
      og.Price = updates.Price != null ? updates.Price : og.Price;
      return og;
    }
  }
}