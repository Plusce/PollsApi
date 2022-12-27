﻿using Gymmer.Core.Models;
using Gymmer.Infrastructure.Persistence.Models.Base;

namespace Gymmer.Infrastructure.Persistence.Models;

public class TrainingDefinitionModel : Entity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<TrainingDefinitionExerciseOptionModel>? Exercises { get; set; }
}