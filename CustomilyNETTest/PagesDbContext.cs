using CustomilyNETTest.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;

namespace CustomilyNETTest
{
    public class PagesDbContext : DbContext
    {        
        public DbSet<Page> Pages { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Image> Images { get; set; }
    }

    //public class MyConfiguration : DbConfiguration
    //{
    //    public MyConfiguration()
    //    {
    //        var name = "Npgsql";

    //        SetProviderFactory(providerInvariantName: name,
    //                           providerFactory: NpgsqlFactory.Instance);

    //        SetProviderServices(providerInvariantName: name,
    //                            provider: NpgsqlServices.Instance);

    //        SetDefaultConnectionFactory(connectionFactory: new NpgsqlConnectionFactory());
    //    }
    //}
}