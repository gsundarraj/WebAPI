using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Commands;
using WebApplication1.Queries;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : BaseController
    {       
        
        [HttpPost]
        public async Task<IActionResult> Create(CreateBlogCommand command)
        {
            return Ok(new { id = await Mediator.Send(command) });
        }

        [HttpGet("blogslist")]
        public async Task<IActionResult> GetBlogs()
        {
            return Ok(await Mediator.Send(new GetBlogsQuery()));
        }

    }
}
