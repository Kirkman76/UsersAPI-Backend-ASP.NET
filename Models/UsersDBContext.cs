using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITCraft_backend.Models
{
    public class UsersDBContext: DbContext
    {
        public UsersDBContext(DbContextOptions<UsersDBContext> options) : base(options)
        {}

        public DbSet<User> Users { get; set; }

    }
}
