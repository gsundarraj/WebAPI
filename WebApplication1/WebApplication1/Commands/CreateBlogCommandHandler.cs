using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.DatabaseContext;
using WebApplication1.Entities;

namespace WebApplication1.Commands
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, string>
    {
        private readonly IWebAppDBContext _context;

        public CreateBlogCommandHandler(IWebAppDBContext context)
        {
            _context = context;
        }

        public async Task<string> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var entity = new Blog
            {
                BlogId = request.BlogId,
                BlogName = request.BlogName
            };

            _context.Blogs.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.BlogId.ToString();
        }
    }
}
