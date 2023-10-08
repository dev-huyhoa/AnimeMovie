using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieContext.Model.Movie
{
    public class MovieAnimeContext : DbContext
    {
        public MovieAnimeContext(DbContextOptions<MovieAnimeContext> options)
          : base(options)
        {
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieEpisode> MovieEpisodes { get; set; }
        public DbSet<MovieGenreLink> MovieGenreLinks { get; set; }
        public DbSet<MoviePart> MovieParts { get; set; }
        public DbSet<MovieReview> MovieReviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);
                entity.Property(e => e.NameRole).HasMaxLength(150);
                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser);
                entity.Property(e => e.NameUser).HasMaxLength(150);
                entity.Property(e => e.Email).HasMaxLength(100);
                entity.HasOne(r => r.Role)
            .WithMany(u => u.Users)
            .HasForeignKey(r => r.RoleId);
            });

            modelBuilder.Entity<BlogPost>(entity =>
            {
                entity.HasKey(e => e.IdBlog);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);
            });

            modelBuilder.Entity<MovieGenreLink>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(r => r.Movie)
            .WithMany(u => u.MovieGenreLinks)
            .HasForeignKey(r => r.MovieId);
                entity.HasOne(r => r.MovieCategory)
            .WithMany(u => u.MovieGenreLinks)
            .HasForeignKey(r => r.CategoryId);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.IdMovie);
            });

            modelBuilder.Entity<MovieCategory>(entity =>
            {
                entity.HasKey(e => e.IdCategory);
            });

            modelBuilder.Entity<MovieEpisode>(entity =>
            {
                entity.HasKey(e => e.IdEpisode);
                entity.HasOne(r => r.Movie)
          .WithMany(u => u.MovieEpisode)
          .HasForeignKey(r => r.MovieId);
            });


            modelBuilder.Entity<MoviePart>(entity =>
            {
                entity.HasKey(e => e.IdPart);
                entity.HasOne(r => r.Movie)
          .WithMany(u => u.MovieParts)
          .HasForeignKey(r => r.MovieId);
            });
            modelBuilder.Entity<MovieReview>(entity =>
            {
                entity.HasKey(e => e.IdReview);
                entity.HasOne(r => r.Movie)
          .WithMany(u => u.MovieReviews)
          .HasForeignKey(r => r.MovieId);
            });

        }
    }
}
