using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins.Models;

namespace Coins.Tests
{
  [TestClass]
  public class CoinsTests
  {

    [TestMethod]
  public void ChangeConstructor_CreatesInstanceOfChange_Change()
    {
      Change newChange = new Change(.07);
    }
    [TestMethod]
    public void GetChangeValue_ReturnChangeValue_Float()//.....code
    {
      //Arrange
      double userChange = 0.01;
      Change newChange = new Change(userChange);
      //Act
      double result = newChange.ChangeValue;
      //Assert
      Assert.AreEqual(userChange, result);
    }
  }
}

//0.01 - 0.99 cents