using Login_Captcha.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_Captcha.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Wender> wenders { get; set; }
    }
}
