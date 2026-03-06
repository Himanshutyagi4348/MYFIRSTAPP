using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using MYFIRSTAPP.Models;

namespace MYFIRSTAPP.Context
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {
           
        }
        public DbSet<Employee> employees { get; set; }  
    }
}
