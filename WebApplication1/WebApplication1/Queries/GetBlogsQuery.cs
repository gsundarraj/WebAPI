using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Queries
{
    public class GetBlogsQuery : IRequest<List<BlogViewModel>>
    {
    }
}
