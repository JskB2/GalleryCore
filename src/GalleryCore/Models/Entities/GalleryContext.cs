using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryCore.Models.Entities
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(DbContextOptions<GalleryContext> options)
            : base(options)
        { }


        public DbSet<GalleryPic> GalleryPics { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
