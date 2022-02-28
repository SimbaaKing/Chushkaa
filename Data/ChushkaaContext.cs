using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chushkaa.Data
{
    public class ChushkaaContext:DbContext
    {
        public ChushkaaContext(DbContextOptions<ChushkaaContext>op) : base(op)
        {

        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }

}
