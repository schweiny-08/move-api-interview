using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_api_be.Domain.Models;

namespace movie_api_be.Application.DTOS
{
    public class GetMovieResponseDto
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public string Director { get; set; }
        public IEnumerable<string> Actors { get; set; }
        public decimal Rating { get; set; }

        public GetMovieResponseDto(string title, int year, IEnumerable<string> genres, string director, IEnumerable<string> actors, decimal rating)
        {
            Title = title;
            Year = year;
            Genres = genres;
            Director = director;
            Actors = actors;
            Rating = rating;
        }
    }
}