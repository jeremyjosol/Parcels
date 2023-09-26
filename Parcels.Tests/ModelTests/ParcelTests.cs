using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelsTests
  {
    [TestMethod]
    public void Parcel_CreatesInstanceOfParcelAndChecksLength_Parcel()
    {
      Parcel newParcel = new Parcel(10, 10, 10, 150);
      Assert.AreEqual(10, newParcel.Length);
    }
    [TestMethod]
    public void Parcel_CreatesInstanceOfParcelAndChecksWidth_Parcel()
    {
      Parcel newParcel = new Parcel(10, 10, 10, 150);
      Assert.AreEqual(10, newParcel.Width);
    }
    [TestMethod]
    public void Parcel_CreatesInstanceOfParcelAndChecksHeight_Parcel()
    {
      Parcel newParcel = new Parcel(10, 10, 10, 150);
      Assert.AreEqual(10, newParcel.Height);
    }
    [TestMethod]
    public void Parcel_CreatesInstanceOfParcelAndChecksWeight_Parcel()
    {
      Parcel newParcel = new Parcel(10, 10, 10, 150);
      Assert.AreEqual(150, newParcel.Weight);
    }
  }
}