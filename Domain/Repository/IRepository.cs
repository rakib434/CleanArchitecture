﻿using Domain.Entities;

namespace Domain.Repository
{
    public interface IRepository
    {
        WeatherEntity GetWeather(string cityName);
    }
}
