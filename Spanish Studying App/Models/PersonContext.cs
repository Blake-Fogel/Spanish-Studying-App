using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Spanish_Studying_App.Models
{
    public class PersonContext : DbContext
    {
        DbSet<Person> persons {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["Database"].ConnectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
