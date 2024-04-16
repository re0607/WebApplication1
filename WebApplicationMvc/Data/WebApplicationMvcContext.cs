using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace WebApplicationMvc.Data
{
    public class WebApplicationMvcContext : DbContext
    {
        public WebApplicationMvcContext (DbContextOptions<WebApplicationMvcContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Player> Player { get; set; } = default!;
    }
}
