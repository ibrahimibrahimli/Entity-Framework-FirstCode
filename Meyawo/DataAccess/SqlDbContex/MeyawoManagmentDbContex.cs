using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meyawo.Entities.Concret;
using Microsoft.EntityFrameworkCore;

namespace Meyawo.DataAccess.SqlDbContex
{
    internal class MeyawoManagmentDbContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = IBRAHIMS\MSSQLSERVER01; Initial Catalog = MeyawoManagmentDbContex; Integrated Security = True; TrustServerCertificate = True");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Image> Images { get; set; }    
        public DbSet<Like> Likes { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<PricingData> PricingDatas {  get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set;}
        public DbSet<User> Users { get; set; }
    }
}
