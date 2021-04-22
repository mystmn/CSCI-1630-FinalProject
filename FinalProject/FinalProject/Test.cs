using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Test
    {
        private List<string> _pacman;
        public List<string> Pacman { get { return _pacman; } set { _pacman = value; } }

        public void test_db()
        {
            List<string> cows = new List<string>();

            cows.Add("First item");
            cows.Add("Second item");

            this._pacman = cows;
        }
    }
}
