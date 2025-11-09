using BetweenSides.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenSides.Context
{
    public class ApplicationDbContext : DbContext
    {
        //	نستخدمها لتحديد سلسلة الاتصال (Connection String) التي تربط التطبيق بقاعدة البيانات.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            /*
             Data Source(server)=.;
            initial catalog(database) = 
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=True;
            Trust Server Certificate=True;
             Data Source=.; database= ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False
             
             */
            string con = "server =localhost\\MSSQLSERVER08; database = BetweenSideisDb;Integrated Security=True; Connect Timeout=30;Encrypt=True;Trust Server Certificate=True; ";
            optionsBuilder.UseSqlServer(con);
        }
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Defendant> Defendants { get; set; }
    }
}
