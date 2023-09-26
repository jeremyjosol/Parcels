using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
   public int Length { get; set; }
   public int Width { get; set; }
   public int Height { get; set; }
   public int Weight { get; set; }
  
  public Parcel(int length, int width, int height, int weight)
  {
    Length = length;
    Width = width;
    Height = height;
    Weight = weight;
  }
  public int CubicSize(int length, int width, int height)
  {
    int cubicSize = length * width * height;
    return cubicSize;
  }
  }
}