using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Commands
{
    public class CreateBlogCommand : IRequest<string>
    {
        public int BlogId { get; set; }
        public string BlogName { get; set; }
    }
}
