using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class ApiDbContex:DbContext
    {
        public ApiDbContex(DbContextOptions<ApiDbContex> options) : base(options)
        {

        }
        public DbSet<Students> Students { get; set; }
    }
}
