using Microsoft.EntityFrameworkCore;
using StoredPrecedure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoredPrecedure.Data
{
    public class StoredProcedureDBContext : DbContext
    {
        
        public StoredProcedureDBContext(DbContextOptions<StoredProcedureDBContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        
    }
}
