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

		//private List<string> _genre;
		public string Genre { get;set;}

		public int RottenTomatoesScore { get; set; }

		public decimal BoxOffice { get; set; }
	}

	/*
	 *  Used this function for testing
	 */
	public class Emp
    {
		private int _ID;
		public int ID { get => this._ID; set { this._ID = value; } }		
		
		private string _director;
		public string Director { get => this._director; set { this._director = value; } }
	}
}
