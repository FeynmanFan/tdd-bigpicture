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

        [Fact]
        public void Expo4to3Is64()
        {
            // arrange
            var calc = new Calculator();
            double value1 = 4;
            double value2 = 3;

            // act
            var observed = calc.Expo(value1, value2);

            // assert
            Assert.Equal(observed, 64);
        }

        [Fact]
        public void Expo2to8Is256()
        {
            // arrange
            var calc = new Calculator();
            double value1 = 2;
            double value2 = 8;

            // act
            var observed = calc.Expo(value1, value2);

            // assert
            Assert.Equal(observed, 256);
        }
    }
}