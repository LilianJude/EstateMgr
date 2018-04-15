using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace EstateMgrCore.DataAccess
{
    public class AgencyDbContext : DbContext
    {

        #region Singleton

        private static AgencyDbContext _context = null;
        public static AgencyDbContext Current
        {
            get
            {
                if (_context == null)
                    throw new NullReferenceException("La base de données doit être initialisée.");
                return _context;
            }
        }
        public async static Task<AgencyDbContext> Initialize()
        {
            if (_context == null)
            {
                _context = new AgencyDbContext
                    (
                        Path.Combine
                        (
                            System.AppDomain.CurrentDomain.BaseDirectory,
                            "agency.db"
                        )
                    );
                await _context.Database.MigrateAsync();
            }
            return _context;
        }

        #endregion

        public string DatabasePath { get; }

        public DbSet<Models.Estate> Estate { get; set; }
        public DbSet<Models.Person> Person { get; set; }
        public DbSet<Models.Address> Address { get; set; }
        public DbSet<Models.Photos> Photos { get; set; }
        public DbSet<Models.RentTransaction> RentTransaction { get; set; }
        public DbSet<Models.SaleTransaction> SaleTransaction { get; set; }
        public DbSet<Models.Transaction> Transaction { get; set; }


        private AgencyDbContext(string databasePath)
        {
            DatabasePath = databasePath;
        }
        
        internal AgencyDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Estate>().HasOne(e => e.Referent).WithMany(p => p.Estates_Ref);

        }
    }
}
