using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web_Api.Models;

namespace Web_Api.Data
{
    public class Web_ApiContext : DbContext
    {
        public Web_ApiContext (DbContextOptions<Web_ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Web_Api.Models.ShopList> ShopList { get; set; } = default!;
    }
}
