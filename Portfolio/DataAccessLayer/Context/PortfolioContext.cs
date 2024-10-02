using Microsoft.EntityFrameworkCore;
using Portfolio.DataAccessLayer.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Portfolio.DataAccessLayer.Context
{
    public class PortfolioContext:DbContext
    {
        //bağlantı stringini verecek olan method. ovvirride işlemi ile işlevin olduğu gibi kalması fakat işlein istenilen şekilde gelmesini amaçladık
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; initial Catalog=DbPortfolio; integrated Security=true;");
        }

            //c# tan sql tarafına yansıtılacak tablolar
            public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MyPortfolio> MyPortfolios { get; set; }
        public DbSet<Skills> Skillss { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        
    }
}
