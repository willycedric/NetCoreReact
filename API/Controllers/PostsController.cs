using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Posts;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
      private readonly IMediator _mediator;
        public PostsController(IMediator mediator)
        {
            _mediator = mediator;

        }

        [HttpGet]
        public async Task<ActionResult<List<Post>>> List()
        {
            return await _mediator.Send( new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Post>>Details(Guid id)
        {
            return await _mediator.Send(new Details.Query{Id = id});
        }

    }
}