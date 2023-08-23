﻿namespace uge34mvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }


    }
}
