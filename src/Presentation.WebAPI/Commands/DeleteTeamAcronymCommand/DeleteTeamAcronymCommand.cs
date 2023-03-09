// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteTeamAcronymCommand.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// DeleteTeamAcronymCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Commands.DeleteTeamAcronymCommand
{
    using MediatR;

    /// <summary>
    /// <see cref="DeleteTeamAcronymCommand"/>
    /// </summary>
    /// <seealso cref="MediatR.INotification"/>
    public class DeleteTeamAcronymCommand : INotification
    {
        /// <summary>
        /// Gets the team acronym identifier.
        /// </summary>
        /// <value>The team acronym identifier.</value>
        public Guid TeamAcronymId { get; init; }
    }
}