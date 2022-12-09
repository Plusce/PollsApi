﻿using Polls.Core.Interfaces;

namespace Polls.Application.EndpointDefinitions.PoliticalParty;

public class ReadPoliticalPartyQueries
{
    internal static readonly Func<IPoliticalPartiesRepository, CancellationToken, Task<IResult>> ReadPoliticalParties =
        async (repository, ct) =>
        {
            var politicalParties = (await repository.FindAllAsync(ct)).Select(party => party?.Name).ToList();
            return politicalParties.Count < 1 ? Results.Empty : Results.Ok(politicalParties);
        };
}