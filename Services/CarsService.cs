
using gregglistc.Db;
using gregglistc.Models;

namespace gregglistc.Services
{
  public class CarsService
  {
    internal List<Car> GetAll()
    {
      return FakeDb.Cars;
    }

    internal Car GetById(string id)
    {
      Car found = FakeDb.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("invaild Id");
      }
      return found;
    }

    internal void Delete(string id)
    {
      Car found = GetById(id);
      FakeDb.Cars.Remove(found);
    }

    internal Car CreateCar(Car newCar)
    {
      FakeDb.Cars.Add(newCar);
      return newCar;
    }

    internal Car Edit(Car updates)
    {
      if (updates.Id == null)
      {
        throw new Exception("invaild Id");
      }
      Car og = GetById(updates.Id);
      og.Color = updates.Color ?? og.Color;
      og.ImgUrl = updates.ImgUrl ?? og.ImgUrl;
      return og;
    }
  }
}
