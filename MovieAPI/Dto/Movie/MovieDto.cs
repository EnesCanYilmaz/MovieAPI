﻿namespace MovieAPI.DTO.Movie;

public class MovieDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ReleaseDate { get; set; }
    public string? MovieTime { get; set; }
    public string? CreatedDate { get; set; }
    public string? UpdatedDate { get; set; }
    public string? PlatformName { get; set; }
    public string? CategoryName { get; set; }
    public List<PlayerDto>? Players { get; set; }
    public List<DirectorDto>? Directors { get; set; }
    public List<MovieImageDto>? MovieImages { get; set; }
}
