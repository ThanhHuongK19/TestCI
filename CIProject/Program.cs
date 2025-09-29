using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class Functions
    {
        public static double Devide(double a, double b)
        {
            return a / b;
        }

        // Hàm kiểm tra số nguyên tố 
        public static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Hàm kiểm tra số chẵn
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        // Dãy Fibonacci
        public static BigInteger Fibonacci(int n)
        {
            if (n < 1 || n > 10000)
            {
                throw new ArgumentException("Invalid argument");
            }

            BigInteger[] memo = new BigInteger[n + 1];
            memo[0] = 0;
            memo[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                memo[i] = memo[i - 1] + memo[i - 2];
            }
            return memo[n];
        }

        //Kiểm tra số có phải số Amstrong không
        public static bool IsArmstrongNumber(int n)
        {
            if (n < 0) return false;

            int sum = 0;
            int original = n;
            int numberOfDigits = n.ToString().Length;

            while (n > 0)
            {
                int digit = n % 10;
                sum += (int)Math.Pow(digit, numberOfDigits);
                n /= 10;
            }

            return sum == original;
        }

        // Hàm kiểm tra số hoàn hảo
        public static bool IsPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }

        // Hàm kiểm tra số đối xứng (Palindrome Number)
        public static bool IsPalindrome(long num)
        {
            long original = num, reversed = 0;
            while (num > 0)
            {
                long digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }
            return original == reversed;
        }

        public static string GradeStudent(double score)
        {

            if (score < 0 || score > 100)

            {

                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            }

            if (score >= 90) return "A";

            if (score >= 80) return "B"; if (score >= 70) return "C";

            if (score >= 60) return "D";

            return "F";
        }
        // Hàm kiểm tra số thập phân

        public static bool IsDecimal(string str)

        {

            if (string.IsNullOrEmpty(str)) return false;

            return double.TryParse(str, out _) && str.Contains(".");
        }

        static void Main(string[] args)
        {
            // Example usage of the functions
            Console.WriteLine("Is 5 prime? " + IsPrime(5)); // True
            Console.WriteLine("Is 4 even? " + IsEven(4)); // True
            Console.WriteLine("Fibonacci of 10: " + Fibonacci(10)); // 55
            Console.WriteLine("Is 153 an Armstrong number? " + IsArmstrongNumber(153)); // True
            Console.WriteLine("Is 6 a perfect number? " + IsPerfectNumber(6)); // True
            Console.WriteLine("Is 121 a palindrome? " + IsPalindrome(121)); // True
            Console.WriteLine("Grade for score 85: " + GradeStudent(85)); // B
            Console.WriteLine("Is '3.14' a decimal? " + IsDecimal("3.14")); // True
        }
    }
}