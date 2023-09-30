﻿using MovieAPI.DTO.Director;
using MovieAPI.DTO.Platform;
using MovieAPI.DTO.Player;

namespace MovieAPI.DTO;

public class MovieDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ReleaseDate { get; set; }
    public string MovieTime { get; set; }
    public int CategoryId { get; set; }
    public int PlatformId { get; set; }
    public string PlatformName { get; set; }
    public string CategoryName { get; set; }

    public List<PlayerDTO> Players { get; set; }
    public List<DirectorDTO> Directors { get; set; }
}
