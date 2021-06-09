using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace crud_music.Models
{
    public class dbMusicContext : DbContext
    {
  
        public dbMusicContext(DbContextOptions<dbMusicContext> options)
            : base(options)
        { 
        }

        public DbSet<Artists> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artists>()
                .HasKey(b => b.ArtistID)
                .HasName("PrimaryKey_ArtistID");
        }
    }
}
