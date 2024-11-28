using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5VKUOBI; Database=TraversalDB; Integrated Security=True; TrustServerCertificate=True;");


        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> About2s { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Features2s { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLatter> Newslatters { get; set; }
        public DbSet<SubAbout> Subabouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
