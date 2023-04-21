using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.DatabaseContext
{
    public class WebAppDBContext:DbContext, IWebAppDBContext
    {
        public WebAppDBContext(DbContextOptions<WebAppDBContext> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {            
            return base.SaveChangesAsync(cancellationToken);
        }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
        public DbConnection GetDBConnection()
        {

            return base.Database.GetDbConnection();
        }

        public DbCommand GetDBCommand()
        {

            return base.Database.GetDbConnection().CreateCommand();
        }

    }    
}
