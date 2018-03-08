using NUnit.Framework;
using TestTeamCity;

namespace UnitTest.TeamCity
{
  [TestFixture]
  public class TestCalculator
  {
    [TestCase(1,2,3)]
    [TestCase(2,2,4)]
    public void TestSum(int a, int b, int expectedResult)
    {
      var calculator = new Calculator();
      var result = calculator.Sum(a, b);
      Assert.AreEqual(expectedResult, result);
    }
  }
}
