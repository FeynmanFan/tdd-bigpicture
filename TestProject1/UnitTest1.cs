using ConsoleApp1;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Square5Equal25()
        {
            // arrange
            var calc = new Calculator();
            double value = 5;

            // act
            var observed = calc.Square(value);

            // assert
            var expected = 25d;

            Assert.Equal(expected, observed);
        }
    }
}