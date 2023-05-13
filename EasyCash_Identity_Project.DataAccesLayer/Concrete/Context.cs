using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_Identity_Project.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Baglanti adresi
            optionsBuilder.UseSqlServer("server=DESKTOP-U82UVSC;initial catalog=EasyCashDB;integrated Security=true;"); 


        }
    }
}
