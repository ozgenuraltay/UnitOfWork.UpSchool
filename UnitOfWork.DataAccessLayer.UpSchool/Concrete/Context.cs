using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EntityLayer.UpSchool.Concrete;

namespace UnitOfWork.DataAccessLayer.UpSchool.Concrete
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8GBIAO0U\\SQLEXPRESS;Database=DbUnitOfWork;integrated security=true");
        }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<ProcessDetail> ProcessDetails { get; set; }
    }
}
