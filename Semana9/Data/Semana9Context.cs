using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Semana9.Data
{
    public class Semana9Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Semana9Context() : base("name=Semana9Context")
        {
        }

        public System.Data.Entity.DbSet<Semana9.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<Semana9.Models.Product> Products { get; set; }
    }
}
