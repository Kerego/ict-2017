using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using Ict2017.Common.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ict2017.Common
{

    public class IctDbContext : DbContext
    {
        public IctDbContext(DbContextOptions<IctDbContext> options) : base(options)
        {
        }

        public DbSet<Presentation> Presentations { get; set; }
        public DbSet<Presenter> Presenters { get; set; }
        public DbSet<Asset> Assets { get; set; }
    }
}