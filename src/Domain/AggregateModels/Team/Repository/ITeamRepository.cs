// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamRepository.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// ITeamRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Domain.AggregateModels.Team.Repository
{
    using TeamService.Domain.SeedWork;

    /// <summary>
    /// <see cref="ITeamRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Team}"/>
    public interface ITeamRepository : IRepository<Team>
    {
    }
}