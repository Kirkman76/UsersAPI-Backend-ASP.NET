using ITCraft_backend.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITCraft_backend.Mocks
{
    public class DbObjectsMock
    {
        public static void Initial(UsersDBContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User { Name = "John", Active = true },
                    new User { Name = "Amanda", Active = false },
                    new User { Name = "Thomas", Active = true },
                    new User { Name = "Samuel", Active = true },
                    new User { Name = "Stefani", Active = false },
                    new User { Name = "James", Active = true },
                    new User { Name = "Courtney", Active = true },
                    new User { Name = "Peter", Active = false },
                    new User { Name = "Stephen", Active = true },
                    new User { Name = "Michael", Active = true }
                    );
                context.SaveChanges();
            }
        }
    }
}
