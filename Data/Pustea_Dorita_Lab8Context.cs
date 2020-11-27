using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pustea_Dorita_Lab8.Models;

namespace Pustea_Dorita_Lab8.Data
{
    public class Pustea_Dorita_Lab8Context : DbContext
    {
        public Pustea_Dorita_Lab8Context (DbContextOptions<Pustea_Dorita_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Pustea_Dorita_Lab8.Models.Book> Book { get; set; }

        public DbSet<Pustea_Dorita_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Pustea_Dorita_Lab8.Models.Category> Category { get; set; }

        public DbSet<Pustea_Dorita_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
