using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using IndianInvestor.Models;

namespace IndianInvestor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
         public DbSet<Admin> Admins { get; set; }
         public DbSet<IndianInvestor.Models.AdminMV> AdminMV { get; set; }
    }
}
