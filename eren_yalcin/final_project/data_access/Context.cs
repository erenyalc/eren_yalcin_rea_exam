using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_access
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-LDCVGPO; Database=exam_db_1; Trusted_Connection=true");
        }

        public DbSet<categories> categories { get; set; }
        public DbSet<products> products { get; set; }
        public DbSet<tags> tags { get; set; }
        public DbSet<tags_products> tags_products { get; set; }
    }
}
