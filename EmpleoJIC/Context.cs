namespace EmpleoJIC
{
    using Models;
    using System.Data.Entity;

    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Profile> Profile { get; set; }
        public DbSet<PraticalOffers> PraticalOffers { get; set; }
    }
}