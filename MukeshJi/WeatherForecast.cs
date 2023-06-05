namespace MukeshJi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public string? Summary2 { get; set; }

		//Committed by mukesh ji soyam
        public string? Summary100 { get; set; }

       //Committed 
        public string? Summary2100 { get; set; }

    }
}