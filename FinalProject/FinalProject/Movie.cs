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

		public string Genre { get; set; }

		public int RottenTomatoesScore { get; set; }

		public decimal BoxOffice { get; set; }
	}
}
