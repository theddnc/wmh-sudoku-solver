using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public sealed class Randomizer
    {
        static Randomizer _instance = new Randomizer();
        public static Randomizer Instance
        {
            get
            {
                return _instance;
            }
        }

        private Random Random { get;  set; }
        Randomizer()
        {
            this.Random = new Random();
        }

        public double GetProbability()
        {
            return this.Random.NextDouble();
        }

        public int GetRandomInt(int from, int to)
        {
            return this.Random.Next(from, to);
        }
    }
}
