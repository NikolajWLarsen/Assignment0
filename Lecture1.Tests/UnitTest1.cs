using System;
using Xunit;
using Lecture1;

namespace Lecture1.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test_isLeapYear_given_4_returns_true(){
            var expected = true;
            
            var actual = new Program().IsLeapYear(4);

            Assert.Equal(expected,actual);
        }

        [Fact]
        public void Test_isLeapYear_given_1600_returns_true()
        {
            var expected = true;

            var actual = new Program().IsLeapYear(1600);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_isLeapYear_given_1700_false(){
            var expected = false;

            var actual = new Program().IsLeapYear(1700);

            Assert.Equal(expected,actual);
        }
    }
}
