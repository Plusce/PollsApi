﻿using System.ComponentModel.DataAnnotations;
using Gymmer.Core.Models;

namespace Gymmer.Infrastructure.Persistence.Models;

public class ExerciseOptionModel : Entity
{
    public ExerciseOptionModel(string? name, string? description = null)
    {
        Name = name;
        Description = description;
        CreationDate = DateTime.UtcNow;
        EditionDate = DateTime.UtcNow;
    }

    public string? Name { get; set; }
    
    public string? Description { get; set; }
}