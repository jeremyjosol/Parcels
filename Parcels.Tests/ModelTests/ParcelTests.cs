using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelsTests
  {
    [TestMethod]
    public void Parcel_CreatesInstanceOfParcelAndChecksValuesAreCorrect_Parcel()
    {
      Parcel newParcel = new Parcel(10, 10, 10, 150);
      Assert.AreEqual(10, newParcel.Length);
      Assert.AreEqual(10, newParcel.Width);
      Assert.AreEqual(10, newParcel.Height);
      Assert.AreEqual(150, newParcel.Weight);
    }
  }
}