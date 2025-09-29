using NUnitTest;
using System.Numerics;

namespace UnitTest
{
    [TestFixture]
    public class Tests
    {

        [TestCase(2, true)]
        [TestCase(5, true)]
        [TestCase(4, false)]
        [TestCase(6, false)]
        public void TestIsPrimeGivenRightArgumentReturnsWell(int n, bool expected)
        {
            bool actual = Functions.IsPrime(n);

            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase(2, true)]
        [TestCase(4, true)]
        [TestCase(1, false)]
        [TestCase(3, false)]
        public void TestIsEvenGivenRightArgumentReturnsWell(int n, bool expected)
        {
            bool actual = Functions.IsEven(n);

            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase(153, true)]
        [TestCase(370, true)]
        [TestCase(123, false)]
        [TestCase(456, false)]
        [TestCase(0, true)]
        [TestCase(-30, false)]
        [TestCase(5, true)]
        public void TestIsArmstrongNumberGivenRightArgumentReturnsWell(int n, bool expected)
        {
            bool actual = Functions.IsArmstrongNumber(n);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(6, true)]
        [TestCase(28, true)]
        [TestCase(7, false)]
        [TestCase(10, false)]
        public void TestIsPerfectNumberGivenRightArgumentReturnsWell(int n, bool expected)
        {
            bool actual = Functions.IsPerfectNumber(n);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(10, "55")]
        [TestCase(300, "222232244629420445529739893461909967206666939096499764990979600")]
        public void TestFiboNumberGivenRightArgumentReturnsWell(int n, string expectedStr)
        {
            BigInteger expected = BigInteger.Parse(expectedStr);
            BigInteger actual = Functions.Fibonacci(n);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(0, typeof(ArgumentException))]
        [TestCase(10001, typeof(ArgumentException))]
        public void TestFiboGivenWrongArgumentThrowsException(int n, Type expectedException)
        {
            Assert.Throws(expectedException, () => Functions.Fibonacci(n));
        }

        // Test cases cho hàm IsPalindrome
        [TestCase(121, true)]
        [TestCase(12321, true)]
        [TestCase(123, false)]
        [TestCase(-121, false)]
        [TestCase(0, true)]
        [TestCase(7, true)]
        [TestCase(191120191021191, true)]
        public void TestIsPalindromeGivenRightArgumentReturnsWell(long n, bool expected)
        {
            bool actual = Functions.IsPalindrome(n);
            Assert.That(actual, Is.EqualTo(expected));
        }

        // Phương thức kiểm tra GradeStudent
        [TestCase(95, "A")]
        [TestCase(85, "B")]
        [TestCase(75, "C")]
        [TestCase(65, "D")]
        [TestCase(55, "F")]
        [TestCase(100, "A")]
        [TestCase(0, "F")]
        public void TestGradeStudentGivenRightArgumentReturnsWell(double score, string expected)
        {
            string actual = Functions.GradeStudent(score);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(-1.0)]
        [TestCase(101.0)]
        public void TestGradeStudentGivenInvalidScoreThrowsException(double score)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Functions.GradeStudent(score));
        }

        // Phương thức kiểm tra IsDecimal
        [TestCase("3.14", true)]
        [TestCase("42", false)]
        [TestCase("3.14.15", false)]
        [TestCase("0", false)]
        [TestCase("", false)]
        [TestCase("-2.5", true)]
        [TestCase("0.01", true)]
        public void TestIsDecimalGivenRightArgumentReturnsWell(string input, bool expected)
        {
            bool actual = Functions.IsDecimal(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}