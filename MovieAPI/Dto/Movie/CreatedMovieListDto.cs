﻿namespace MovieAPI.DTO.Movie;

public class CreatedMovieListDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ReleaseDate { get; set; }
    public string? MovieTime { get; set; }
    public string? PlatformName { get; set; }
    public string? CategoryName { get; set; }
    public string? CreatedDate { get; set; }
}

