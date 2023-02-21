using System;


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
      if ( (ChangeValue / .25) >= 1 )
      {
        return "you are getting quarters back";
      }
      else if ( (ChangeValue / .10) >= 1 )
      {
        return "you are getting dimes back";
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