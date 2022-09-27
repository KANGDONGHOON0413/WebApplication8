using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.DataContext
{
    public class DContext : DbContext
    {
        public DbSet<User> Users { get; set; } // User는 클래스 이름, Users는 테이블명
        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = test; Uid= sa; Password= alencia");
        }
    }
}
