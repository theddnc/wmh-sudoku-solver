using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMHSudokuSolver
{
    class PhenotypeView
    {
        public int Iteration { get; set; }
        public int Fitness { get; set; }
        private Sudoku Sudoku { get; set; }

        public PhenotypeView(Phenotype phenotype, int iterationNumber)
        {
            this.Iteration = iterationNumber;
            this.Fitness = phenotype.Fitness;
            this.Sudoku = phenotype.Sudoku;
        }

        public PhenotypeView(Sudoku sudoku, int fitness, int iterationNumber)
        {
            this.Iteration = iterationNumber;
            this.Fitness = fitness;
            this.Sudoku = sudoku;
        }
    }
}
