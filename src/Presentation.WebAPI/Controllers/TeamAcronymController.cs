// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamAcronymController.cs" company="HumbleBets">
//     Copyright (c) HumbleBets. All rights reserved.
// </copyright>
// <summary>
// TeamAcronymController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamService.Presentation.WebAPI.Controllers
{
    using System.Net;
    using AutoMapper;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using TeamService.Domain.AggregateModels.Team;
    using TeamService.Presentation.WebAPI.Commands.CreateTeamAcronymCommand;
    using TeamService.Presentation.WebAPI.Dto.Input;
    using TeamService.Presentation.WebAPI.Dto.Output;
    using TeamService.Presentation.WebAPI.Utils;

    [ApiController]
    [Route("api/v1/TeamAcronym")]
    public class TeamAcronymController : Controller
    {
        private readonly IMapper mapper;

        private readonly IMediator mediator;

        public TeamAcronymController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(TeamAcronymDetailsDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> AddAcronymToTeamAsync(
            [FromQuery] GetByTeamIdDto filters,
            [FromBody] CreateTeamAcronymDto createAcronymDto,
            CancellationToken cancellationToken)
        {
            TeamAcronym acronym = await this.mediator.Send(new CreateTeamAcronymCommand
            {
                TeamId = filters.TeamId,
                Acronym = createAcronymDto.Acronym,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<TeamAcronymDetailsDto>(acronym));
        }
    }
}