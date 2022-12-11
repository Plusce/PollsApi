﻿using Gymmer.Core.Interfaces;
using Gymmer.Infrastructure.Persistence.Repository;

namespace Gymmer.Application.EndpointDefinitions.PoliticalParty;

public class PoliticalPartyEndpointDefinition : IEndpointDefinition
{
    public void DefineServices(IServiceCollection services)
    {
        services.AddScoped<IExercisesRepository, ExercisesRepository>();
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/exercises", ReadExerciseQueries.ReadExercises)
            .Produces<IEnumerable<string?>>(); // FluentApi approach
    }
}