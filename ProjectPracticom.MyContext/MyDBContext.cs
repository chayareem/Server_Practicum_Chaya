using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectPracticom.Repositories.Entities;
using ProjectPracticom.Repositories.Interfaces;
using System.Diagnostics.Metrics;
using System;

namespace ProjectPracticom.MyContext
{
    public class MyDBContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            option.UseSqlServer("Data Source=sqlsrv;Initial Catalog=PracticumChayaReem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite");
        }

    }
}
