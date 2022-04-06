
namespace gregglistc.Models
{
  public class Car
  {
    public Car(int price, string color, string imgUrl, int miles)
    {
      Price = price;
      Color = color;
      ImgUrl = imgUrl;
      Miles = miles;
      Id = Guid.NewGuid().ToString();
    }

    public int Price { get; set; }
    public string? Color { get; set; }
    public int Miles { get; set; }
    public string? ImgUrl { get; set; }
    public string? Id { get; set; }
  }
}