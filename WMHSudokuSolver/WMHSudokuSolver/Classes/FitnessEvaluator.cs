﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMHSudokuSolver.Classes;

namespace SudokuSolver
{
    class FitnessEvaluator
    {

        public FitnessEvaluator(Phenotype phenotype) {
            this.Phenotype = phenotype;
        }

        public int Evaluate() {
            int fitness = 0;

            foreach (int row in Enumerable.Range(0, Sudoku.RowsCount))
            {
                var duplicates = from field in this.Phenotype.getRowWithIndex(row)
                                 group field by field into g
                                 let count = g.Count() - 1
                                 select count;

                fitness += duplicates.Sum();
            }

            foreach (int row in Enumerable.Range(0, Sudoku.ColumsCount))
            {
                var duplicates = from field in this.Phenotype.getColumnWithIndex(row)
                                 group field by field into g
                                 let count = g.Count() - 1
                                 select count;

                fitness += duplicates.Sum();
            }

            return fitness;
        }

        public Phenotype Phenotype { get; private set; }
    }
}
