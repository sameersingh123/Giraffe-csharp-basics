using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
     class Movie
    {
        public string title;
        public string director;
        private string rating;
        public static int movieCount = 0;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
            movieCount++;
        }
        
        public int MovieCount()
        {
            return movieCount;
        }

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if(value == "G" || value=="PG-13" || value == "PG-16")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
