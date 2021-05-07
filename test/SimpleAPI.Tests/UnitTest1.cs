using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController(null);

        [Fact]
        public void GetReturnsCorrectNumber()
        {
            var returnValue = controller.Get();
            // Assert.Equal("Les Jackson", returnValue.Value);
            foreach(var val in returnValue) 
            {
                Console.WriteLine($"{val.Date} {val.Summary} {val.TemperatureC} {val.TemperatureF}");
            }
            Assert.NotNull(returnValue);
        }
    }
}
