using AMS23_Caroussel.Models;
using Microsoft.EntityFrameworkCore;

namespace AMS23_Carousel.Data.Repository
{
    public class ApplicationDataContext: DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext>options): base(options)
        {
            
        }

        public DbSet<CategoryModel> Category{get;set;}
    }

    
}