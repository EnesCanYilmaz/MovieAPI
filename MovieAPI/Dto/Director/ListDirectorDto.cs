﻿namespace MovieAPI.DTO.Director;

public class ListDirectorDto
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public string? Name { get; set; }
    public string? CreatedDate { get; set; }
    public string? UpdatedDate { get; set; }
}

