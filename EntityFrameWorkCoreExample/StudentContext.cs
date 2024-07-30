using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCoreExample
{
	public class StudentContext : DbContext
	{
        // ctor is constructor
        public StudentContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = the desired name for database
            // Server = the server we are connecting too. LocalDB is included with VS
            // Trusted_Connection - indicates that our windows account should be used 
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }

}
