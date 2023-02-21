
namespace Coins.Models
{
  public class Change
  {
    public double ChangeValue { get; set; }

    public Change (double userChange) 
    {
      ChangeValue = userChange;
    }
  }
}