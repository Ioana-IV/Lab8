using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ivanov_Ioana_Lab8.Models;

namespace Ivanov_Ioana_Lab8.Data
{
    public class Ivanov_Ioana_Lab8Context : DbContext
    {
        public Ivanov_Ioana_Lab8Context (DbContextOptions<Ivanov_Ioana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ivanov_Ioana_Lab8.Models.Book> Book { get; set; }
    }
}
