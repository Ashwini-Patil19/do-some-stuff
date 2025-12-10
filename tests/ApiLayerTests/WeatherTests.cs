namespace ApiLayerTests;

public class WeatherTests
{

    [Fact(Skip = "test file")]
    public void Should_convert_CtoF()
    {
        WeatherForecast weatherforecast = new WeatherForecast(DateOnly.FromDateTime(DateTime.Now), 25, "warm");
        Assert.Equal(76, weatherforecast.TemperatureF);
    }
}