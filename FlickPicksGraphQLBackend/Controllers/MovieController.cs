﻿using Microsoft.AspNetCore.Mvc;
using FlickPicksGraphQLBackend.Graphql;
using System.Threading.Tasks;
using HotChocolate.Language;

namespace FlickPicksGraphQLBackend.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly FlickPicksSchema _schema;

        public MovieController(FlickPicksSchema schema)
        {
            _schema = schema;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLRequest request)
        {
            var result = await _schema.ExecuteAsync(request.Query, request.Variables);
            return Ok(result);
        }
    }
}