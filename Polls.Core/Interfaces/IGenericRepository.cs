﻿using Polls.Core.Models;

namespace Polls.Core.Interfaces;

public interface IGenericRepository<T> where T : Entity
{
    public Task<T?> FindByIdAsync(long id, CancellationToken ct = default);
    public Task<List<T?>> FindAllAsync(CancellationToken ct = default);
    public IQueryable<T> ReadOnlyQuery();
}