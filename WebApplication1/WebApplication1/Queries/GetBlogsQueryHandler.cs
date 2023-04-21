using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.DatabaseContext;
using WebApplication1.Models;

namespace WebApplication1.Queries
{
    public class GetBlogsQueryHandler : IRequestHandler<GetBlogsQuery, List<BlogViewModel>>
    {
        private readonly IWebAppDBContext _context;

        public GetBlogsQueryHandler(IWebAppDBContext context)
        {
            _context = context;
        }

        public async Task<List<BlogViewModel>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
        {
            var vm = await _context.Blogs.Select(x => new BlogViewModel { BlogId = x.BlogId, BlogName = x.BlogName }).ToListAsync(cancellationToken);
           
            return vm;
        }
    }
}
