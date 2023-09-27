using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
   public int Length { get; set; }
   public int Width { get; set; }
   public int Height { get; set; }
   public int Weight { get; set; }
   public int Volume { get; set; }
   private static List<Parcel> _instances = new List<Parcel> { };
    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = CubicSize(length, width, height);
      _instances.Add(this);
    }
    public int CubicSize(int length, int width, int height)
    {
      return length * width * height;
    }
    public int ShippingPrice(int cubicSize, int weight)
    {
      int shippingPrice = 0;
      if (cubicSize > 1728)
      {
        int dimWeight = cubicSize / 166;
        if (weight > dimWeight)
        {
          shippingPrice = weight;
        }
        else
        {
          shippingPrice = dimWeight;
        }
      }
      else
      {
        shippingPrice = weight;
      }
      return shippingPrice;
    }
    public static List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}