using Newtonsoft.Json;

namespace newton
{
    class Program
    {
        static void Main()
        {
            string json = @"{
                ""coord"": {
                    ""lon"": -0.13,
                    ""lat"": 51.51
                },
                ""weather"": [
                    {
                        ""id"": 300,
                        ""main"": ""Drizzle"",
                        ""description"": ""light intensity drizzle"",
                        ""icon"": ""09d""
                    },
                    {
                        ""id"": 800,
                        ""main"": ""Clear"",
                        ""description"": ""clear sky"",
                        ""icon"": ""01n""
                    }
                ],
                ""base"": ""stations"",
                ""main"": {
                    ""temp"": 280.32,
                    ""pressure"": 1012,
                    ""humidity"": 81,
                    ""temp_min"": 279.15,
                    ""temp_max"": 281.15
                },
                ""visibility"": 10000,
                ""wind"": {
                    ""speed"": 4.1,
                    ""deg"": 80
                },
                ""clouds"": {
                    ""all"": 90
                },
                ""dt"": 1485789600,
                ""sys"": {
                    ""type"": 1,
                    ""id"": 5091,
                    ""message"": 0.0103,
                    ""country"": ""GB"",
                    ""sunrise"": 1485762037,
                    ""sunset"": 1485794875
                },
                ""id"": 2643743,
                ""name"": ""London"",
                ""cod"": 200
            }";

            WeatherInfo Info = JsonConvert.DeserializeObject<WeatherInfo>(json);

            Console.WriteLine(Info.Weather[1].id);
        }
    }

    public class WeatherInfo
    {
        public Weather[] Weather { get; set; }
        public Wind Wind { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }
}