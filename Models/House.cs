using System.ComponentModel.DataAnnotations;

namespace gregglistc.Models

{
  public class House
  {
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Price { get; set; }
    public int Sqft { get; set; }
    public string Id { get; set; }
    public House(int bathrooms, int sqft, int price, int bedrooms)
    {
      this.Id = Guid.NewGuid().ToString();
      this.Price = price;
      this.Bathrooms = bathrooms;
      this.Sqft = sqft;
      this.Bedrooms = bedrooms;


    }
  }

}