﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace weatherwebinarService.WeatherModels
{
    public class Coord
    {
        [JsonProperty("lon")]
        public double Longitude { get; set; } = 0;

        [JsonProperty("lat")]
        public double Latitude { get; set; } = 0;
    }

    public class Sys
    {

        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty;
    }

    public class Weather
    {
        [JsonProperty("id")]
        public int Id { get; set; } = 0;

        [JsonProperty("main")]
        public string Main { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("icon")]
        public string Icon { get; set; } = string.Empty;
    }

    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; } = 0;
        [JsonProperty("pressure")]
        public double Pressure { get; set; } = 0;

        [JsonProperty("humidity")]
        public double Humidity { get; set; } = 0;
        [JsonProperty("temp_min")]
        public double MinTemperature { get; set; } = 0;

        [JsonProperty("temp_max")]
        public double MaxTemperature { get; set; } = 0;
    }

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; } = 0;

        [JsonProperty("deg")]
        public double WindDirectionDegrees { get; set; } = 0;

    }

    public class Clouds
    {

        [JsonProperty("all")]
        public int CloudinessPercent { get; set; } = 0;
    }

    public class WeatherRoot
    {
        [JsonProperty("coord")]
        public Coord Coordinates { get; set; } = new Coord();

        [JsonProperty("sys")]
        public Sys System { get; set; } = new Sys();

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; } = new List<Weather>();

        [JsonProperty("main")]
        public Main MainWeather { get; set; } = new Main();

        [JsonProperty("wind")]
        public Wind Wind { get; set; } = new Wind();

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; } = new Clouds();

        [JsonProperty("id")]
        public int CityId { get; set; } = 0;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("dt")]
        public string Date { get; set; } = string.Empty;

        [JsonProperty("temp")]
        public List<Temperature> Temperature { get; set; } = new List<Temperature>();

    }

    public class WeatherForecastRoot
    {
        [JsonProperty("city")]
        public City City { get; set; }
        [JsonProperty("cod")]
        public string Vod { get; set; }
        [JsonProperty("message")]
        public double Message { get; set; }
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        [JsonProperty("list")]
        public List<ForecastListRoot> Items { get; set; } = new List<ForecastListRoot>();
    }

    public class ForecastListRoot
    {
        [JsonProperty("dt")]
        public string Date { get; set; } = string.Empty;

        [JsonProperty("temp")]
        public Temperature temp { get; set; }

        [JsonProperty("pressure")]
        public string pressure { get; set; } = string.Empty;

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; } = new List<Weather>();

        [JsonProperty("speed")]
        public string Speed { get; set; } = string.Empty;

        [JsonProperty("deg")]
        public double WindDirectionDegrees { get; set; } = 0;

        [JsonProperty("clouds")]
        public int clouds { get; set; } = 0;

        [JsonProperty("rain")]
        public string Rain { get; set; } = string.Empty;

    }

    public class Temperature
    {
        [JsonProperty("day")]
        public double day_temp { get; set; }
        [JsonProperty("min")]
        public double min_temp { get; set; }
        [JsonProperty("max")]
        public double max_temp { get; set; }
        [JsonProperty("night")]
        public double night_temp { get; set; }
        [JsonProperty("eve")]
        public double eve_temp { get; set; }
        [JsonProperty("morn")]
        public double morning_temp { get; set; }

    }


    public class City
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("coord")]
        public Coord Coord { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("population")]
        public int Population { get; set; }
        [JsonProperty("sys")]
        public Sys Sys { get; set; }
    }

}