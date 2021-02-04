using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public static class tempstorage
    {
        private static List<EnterMovie> movies = new List<EnterMovie>();

        public static IEnumerable<EnterMovie> EnterMovies => movies;

        public static void AddMovie(EnterMovie movie)
        {
            movies.Add(movie);
        }
    }
}
