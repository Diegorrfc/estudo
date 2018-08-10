using Microsoft.EntityFrameworkCore;
using System;


namespace Tigre.Models{   
   
        public class Context : DbContext
    {
            public Context(DbContextOptions<Context> options) : base(options)
            { }
          
            public DbSet<Bot> Bot { get; set; }
            public DbSet<User> Usuarios { get; set; }

       
    }
    

}
