using Microsoft.EntityFrameworkCore;
using MutualApi.Web.Data.Entities;

namespace MutualApi.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cliente> ClientesDatos { get; set; }
     }
}