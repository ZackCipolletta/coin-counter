using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins.Models;
using System;
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

    [TestMethod]
    public void GetMoney_DetermineTheNumberOfPenniesToReturn_String()
    {
      // Arrange
      Change penniesToReturn = new Change(.04);
      // Act
      string returnCoins = penniesToReturn.GetMoney();
      double numberOfPennies = penniesToReturn.ChangeValue *100;

      // Assert
      Assert.AreEqual($"you are getting {numberOfPennies} pennies back", returnCoins);
    }

    [TestMethod]
    public void GetMoney_DetermineTheNumberOfNickelsToReturn_String()
    {
      // Arrange
      Change nickelsToReturn = new Change(.07);
      // Act
      string returnCoins = nickelsToReturn.GetMoney();
      double numberOfNickels = Convert.ToInt32(nickelsToReturn.ChangeValue / .05);
      // int intNickels = Convert.ToInt32(numberOfNickels);
      // Assert
      Assert.AreEqual($"you are getting {numberOfNickels} nickels back", returnCoins);
    }

        [TestMethod]
    public void GetMoney_DetermineTheNumberOfDimesToReturn_String()
    {
      // Arrange
      Change DimesToReturn = new Change(.12);
      // Act
      string returnCoins = DimesToReturn.GetMoney();
      // Assert
      Assert.AreEqual("you are getting dimes back", returnCoins);
    }

            [TestMethod]
    public void GetMoney_DetermineTheNumberOfQuartersToReturn_String()
    {
      // Arrange
      Change QuartersToReturn = new Change(.27);
      // Act
      string returnCoins = QuartersToReturn.GetMoney();
      // Assert
      Assert.AreEqual("you are getting quarters back", returnCoins);
    }


  }
}

//0.01 - 0.99 cents