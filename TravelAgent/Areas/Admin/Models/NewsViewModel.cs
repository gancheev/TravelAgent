using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelAgent.Areas.Admin.Controllers
{
    
    public class NewsViewModel
    {
        
        public int ID { get; set; } 
        public string Title { get; set; } 
        public DateTime ReleaseDate { get; set; } 
        public string Text { get; set; }  

    }
    public class NewsDBContext : DbContext
    {
        public DbSet<NewsViewModel> News { get; set; }
    } 
}