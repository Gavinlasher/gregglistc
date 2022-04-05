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

  }
}