using gregglistc.Models;

namespace gregglistc.Db
{
  public static class FakeDb
  {
    public static List<House> Houses { get; set; } = new List<House>(){
      new House(3,1555,50000,2),
      new House(32,2222,80000,4),
      new House(10,5500,120000,7),
      new House(1,900,20000,1),
    };
    public static List<Car> Cars { get; set; } = new List<Car>(){
new Car(2500,"red","coolredcar",56000),
new Car(3400,"blue","a green car",89000),
new Car(43000,"white","a clean white car",120)

    };

  }
}