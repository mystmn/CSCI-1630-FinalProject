using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class Messages
    {
        //private string _role;
        //public string Role { get => _role; set => _role  = value; }
        public enum validation { BoxOffice, Director, Genre, Title, Rotten, Year };

        //form validation
        public enum formVal { AddMovie_succ, AddMovie_fail, UpdateMovie_succ, UpdateMovie_fail, DeleteMovie_succ, DeleteMovie_fail }

        //database validation
        public enum dbVal { DB_Conn_succ, DB_Conn_fail }


        public string input(validation position)
        {
            switch (position)
            {
                case validation.BoxOffice:
                    return "Make sure your entering numeric values for Box Office";
                case validation.Director:
                    return "Missing Director";
                case validation.Genre:
                    return "What's the genre to your movie?";
                case validation.Title:
                    return "Please add the movie title";
                case validation.Rotten:
                    return "Missing Rotten Tomatoe score";
                case validation.Year:
                    return "Make sure your entering numeric values for Year";
                default:
                    return "";
            }
        }
        public string success(formVal take, string movieTitle = "")
        {
            string db = "database";

            switch (take)
            {
                case formVal.AddMovie_succ:
                    return $"Added {movieTitle} to {db}";
                case formVal.AddMovie_fail:
                    return $"Failed to add {movieTitle} to {db}";

                case formVal.UpdateMovie_succ:
                    return $"Updated {movieTitle} to {db}";
                case formVal.UpdateMovie_fail:
                    return $"Failed to update {movieTitle} to {db}";

                case formVal.DeleteMovie_succ:
                    return $"Deleted {movieTitle} to {db}";
                case formVal.DeleteMovie_fail:
                    return $"Failed to delete {movieTitle} to {db}";

                default:
                    return "";
            }
        }
        public string db_conn_status(dbVal take)
        {
            string db = "database";

            switch (take)
            {
                case dbVal.DB_Conn_succ:
                    return $"Connection was confirmed and data submitted to {db}";
                case dbVal.DB_Conn_fail:
                    return $"Failed to submit the data and make connection to {db}";
                default:
                    return "";
            }
        }
    }
}
