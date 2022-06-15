using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudUsingBlazor.Shared;

namespace CrudUsingBlazor.Server.Database
{
    public class ContextClass : IdentityDbContext
    {
        public ContextClass(DbContextOptions<ContextClass> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<UserModel> Users { get; set; }
    }
}
