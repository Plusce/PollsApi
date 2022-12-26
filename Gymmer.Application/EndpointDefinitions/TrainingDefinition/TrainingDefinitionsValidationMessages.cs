﻿using Gymmer.Core.Models;

namespace Gymmer.Application.EndpointDefinitions.TrainingDefinition;

public sealed record TrainingDefinitionsValidationMessages(string Message) : ValidationMessage(Message)
{
    public static readonly TrainingDefinitionsValidationMessages Duplicated =
        new(
            "Cannot name an training definition with '{0}' name. Training definition with this specific name has been already added.");
}