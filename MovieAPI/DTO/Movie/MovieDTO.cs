﻿using System.Text.Json.Serialization;
using MovieAPI.DTO.Director;
using MovieAPI.DTO.Platform;

namespace MovieAPI.DTO.Movie;

public class MovieDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ReleaseDate { get; set; }
    public string MovieTime { get; set; }
    public string PlatformName { get; set; }
    public string CategoryName { get; set; }
    public List<Player.PlayerDTO> Players { get; set; }
    public List<Director.DirectorDTO> Directors { get; set; }
    public List<MovieImage.MovieImageDTO> MovieImages { get; set; }
}