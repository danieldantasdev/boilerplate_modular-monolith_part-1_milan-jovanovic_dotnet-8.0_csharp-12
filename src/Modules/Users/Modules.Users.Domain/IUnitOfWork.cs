﻿namespace Modules.Users.Domain;

/// <summary>
/// Represents the users module unit of work.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Saves all of the pending changes in the unit of work.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The completed task.</returns>
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
