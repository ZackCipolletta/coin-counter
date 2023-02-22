using System;
using System.Collections.Generic;

namespace Coins.Models
{
  public class Change
  {
    public double ChangeValue { get; set; }
    public Change (double userChange) 
    {
      ChangeValue = userChange;
    }

    public string GetMoney()
    {
      string coinsList = coinsList;
      if ( (ChangeValue / .25) >= 1 )
      {
        string quarters = $"you are getting {Convert.ToInt32(ChangeValue / .25)} quarters back";
        coinsList = coinsList + quarters;
        return coinsList;

      }
      else if ( (ChangeValue / .10) >= 1 )
      {
        return $"you are getting {Convert.ToInt32(ChangeValue / .10)} dimes back";
      }
      else if ( (ChangeValue / .05) >= 1 )
      {
        return $"you are getting {Convert.ToInt32(ChangeValue / .05)} nickels back";
      }
      else
      {
        return $"you are getting {ChangeValue * 100} pennies back";
      }
    }
  }
}