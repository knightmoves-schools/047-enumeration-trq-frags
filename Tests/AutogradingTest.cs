namespace Tests;

using System.Text.RegularExpressions;
using knightmoves;
using Xunit;

public class AutogradingTest
{

    [Fact]
    public void Should_Define_An_Enumeration_Named_Days_That_Contains_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday_Sunday(){
      Assert.Equal("Monday", Days.Monday.ToString());
      Assert.Equal("Tuesday", Days.Tuesday.ToString());
      Assert.Equal("Wednesday", Days.Wednesday.ToString());
      Assert.Equal("Thursday", Days.Thursday.ToString());
      Assert.Equal("Friday", Days.Friday.ToString());
      Assert.Equal("Saturday", Days.Saturday.ToString());
      Assert.Equal("Sunday", Days.Sunday.ToString());
    }
}