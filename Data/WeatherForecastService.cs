namespace HomeCinema.Data
{
	public class WeatherForecastService
	{
		private static readonly string[] Summaries = new[]
		{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

		public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate,int threshold = 5, CancellationToken cancellationToken = default)
		{
			return Task.FromResult(Enumerable.Range(1, threshold).Select(index => new WeatherForecast
			{
				Id = index,
				Date = startDate.AddDays(index),
				TemperatureC = Random.Shared.Next(-20, 55),
				Summary = Summaries[Random.Shared.Next(Summaries.Length)]
			}).ToArray());
		}
	}
}