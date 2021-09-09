using System;
using Xunit;
using Lecture1;
using System.IO;

namespace Lecture1.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test_isLeapYear_given_2000_returns_true(){
            var expected = true;
            
            var actual = new Program().IsLeapYear(2000);

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

        [Fact]
        public void Test_throw_exception_if_year_is_less_than_1582(){
            
            Assert.Throws<Exception>( () => new Program().IsLeapYear(1580));

        }

       /* [Fact]
        public void Test_throw_exception_if_userinput_is_a_string()
        {
            Console.SetIn(new StringReader("asdf"));
            Assert.Throws<Exception>(() => Program.main(new string[0]));

        }*/
    }
}
