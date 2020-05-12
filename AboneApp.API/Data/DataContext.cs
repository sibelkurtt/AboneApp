using AboneApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AboneApp.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Abone> Abones { get; set; } //Buradaki parametrelerden emin değilim.
        
    }
}