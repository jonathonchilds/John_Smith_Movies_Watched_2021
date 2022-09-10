using System;
using CsvHelper;
using Microsoft.EntityFrameworkCore;

namespace John_Smith_Movies_Watched_2021_API.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }
        public DateOnly Date_Added { get; set; }
        public int ReleaseYear { get; set; }
        public string Rating { get; set; }
        public string Listed_In { get; set; }
        public string Duration { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }

}