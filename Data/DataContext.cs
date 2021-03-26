using AmalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AmalApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public virtual DbSet<Patient> Patients{ get; set; }
    }
}