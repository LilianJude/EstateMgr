using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstateMgrCore.DataAccess
{
    public class AgencyDbContextFactory : IDesignTimeDbContextFactory<AgencyDbContext>
    {
        public AgencyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AgencyDbContext>();
            optionsBuilder.UseSqlite("Data Source=agency.db");

            return new AgencyDbContext(optionsBuilder.Options);
        }
    }
}
