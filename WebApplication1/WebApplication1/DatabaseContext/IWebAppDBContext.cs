using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.DatabaseContext
{
    public interface IWebAppDBContext
    {
        public DbSet<Blog> Blogs { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbConnection GetDBConnection();
        DbCommand GetDBCommand();
    }
}
