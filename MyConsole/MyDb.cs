using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    using System.Data.Entity;
    public class MyDb:DbContext
    {
        public DbSet<Student> Student { get; set; }
    }
}
