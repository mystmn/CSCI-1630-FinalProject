using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
	class Movie
	{
		public int ID { get; set; }

		public string Title { get; set; }

		public int Year { get; set; }

		public string Director { get; set; }

		public int Genre { get;set;}

		public int RottenTomatoesScore { get; set; }

		public decimal BoxOffice { get; set; }

        public int genreList(string name)
        {
                // Replace with the List<Movie> Genre function
                switch (name)
                {
                    case "Animation":
                        return 0;

                    case "Action":
                        return 1;

                    case "Comedy":
                        return 2;

                    case "Drama":
                        return 3;

                    case "Horror":
                        return 4;

                    case "Mystery":
                        return 5;

                    case "Romance":
                        return 6;

                    case "Science Fiction":
                        return 6;

                    case "Western":
                        return 7;

                    default:
                        return -1;
                }
            
        }

        // overloading genreList()
        public string genreList(int name)
        {
            switch (name)
            {
                case 0:
                    return "Animation";

                case 1:
                    return "Action";

                case 2:
                    return "Comedy";

                case 3:
                    return "Drama";

                case 4:
                    return "Horror";

                case 5:
                    return "Mystery";

                case 6:
                    return "Romance";

                case 7:
                    return "Science Fiction";

                case 8:
                    return "Western";

                default:
                    return "";
            }
        }
    }
}
