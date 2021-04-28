using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrate
{
   public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
