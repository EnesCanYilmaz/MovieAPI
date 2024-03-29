﻿using MovieAPI.Infrastructure.Data.Entities.Base;

namespace MovieAPI.Infrastructure.Data.Entities.Player;

public class Player : BaseEntity
{
    public string? Name { get; set; }

    public int MovieId { get; set; }
    public virtual Movie.Movie? Movie { get; set; }
}

