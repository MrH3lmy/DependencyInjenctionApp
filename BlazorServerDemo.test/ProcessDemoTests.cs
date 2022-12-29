using BlazorServerDemo.Data;
using Xunit;

namespace BlazorServerDemo.test
{
    public class ProcessDemoTests
    {
        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("2/1/2000"));
            ProcessDemo p = new(t);

            int expected = 29;
            int actual = p.getDaysInMonth();
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void GetDaysInMonth_ShouldReturnProperNumberForNonLeapYear()
        {
            TestingDemo t = new(DateTime.Parse("2/1/1999"));
            ProcessDemo p = new(t);

            int expected = 28;
            int actual = p.getDaysInMonth();
            Assert.Equal(expected, actual);
        }

        public class TestingDemo : IDemo
        {
            public DateTime StartupTime { get ; init ; }

            public TestingDemo(DateTime startupTime)
            {
                StartupTime = startupTime;
            }
        }
    }
}