using System;
using Xunit;
using PrimeNumbersLab;

namespace PrimeTester
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2)]
        [InlineData(2, 3)]
        [InlineData(11, 31)]
        [InlineData(7, 17)]
        [InlineData(20, 71)]
        public void Test1(int a, int expected)
        {
            int result = Prime.PrimeNum(a);
            Assert.Equal(expected, result);
        }

        //[Theory]
        //[InlineData(2)]
        //[InlineData(3)]
        //[InlineData(5)]
        //[InlineData(11)]
        //[InlineData(53)]
        //public void NumberIsPrime(int number)
        //{
        //    bool actual = Prime.IsPrime(number);

        //    Assert.True(actual);
        //}

    }
}
