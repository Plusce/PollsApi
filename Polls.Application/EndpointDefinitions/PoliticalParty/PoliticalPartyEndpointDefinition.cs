﻿using Polls.Core.Interfaces;
using Polls.Infrastructure.Persistence.Repository;

namespace Polls.Application.EndpointDefinitions.PoliticalParty;

public class PoliticalPartyEndpointDefinition : IEndpointDefinition
{
    public void DefineServices(IServiceCollection services)
    {
        services.AddScoped<IPoliticalPartiesRepository, PoliticalPartiesRepository>();
    }

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/political-parties", ReadPoliticalPartyQueries.ReadPoliticalParties)
            .Produces<IEnumerable<string?>>(); // FluentApi approach
    }
}