using System.Collections.Generic;
using System.Linq;

namespace WMHSudokuSolver
{
    class Phenotype
    {
        public Phenotype(Genotype genotype, Sudoku solution)
        {
            this.Genotype = genotype;
            this.Fitness = this.evaluateFitness();
        }

        public Phenotype(Sudoku puzzle, Sudoku solution)
        {
            this.Genotype = new Genotype(puzzle);
            this.Fitness = this.evaluateFitness();
        }

        public Genotype Genotype { get; private set; }
        public float Fitness { get; private set; }
        private FitnessEvaluator evaluator;
        public List<int> getRowWithIndex(int index)
        {
            List<int> row = new List<int>();
            const int numbersOfRowsInRowSection = 3;
            int sectionNumber = index / numbersOfRowsInRowSection;
            const int numberOfFieldsInThreeRows = 27;
            const int remainingFieldsInSquareSection = 7;

            int startIdx = sectionNumber * numberOfFieldsInThreeRows + (index % numbersOfRowsInRowSection) * 3;
            int nextIdx = startIdx;

            foreach (int i in Enumerable.Range(0, Sudoku.RowFieldsCount))
            {
                row.Add(this.Genotype.GeneSequence[nextIdx]);
                nextIdx = i % 3 == 0 ? nextIdx + remainingFieldsInSquareSection : nextIdx + 1;
            }

            return row;
        }

        public List<int> getColumnWithIndex(int index)
        {
            List<int> column = new List<int>();
            const int numberOfColumnsInColumnSection = 3;
            const int remainingFieldsInSquareSection = 7;
            const int numberOfFieldsInThreeRows = 27;

            int startIdx = remainingFieldsInSquareSection * index / numberOfColumnsInColumnSection + index % numberOfColumnsInColumnSection;
            int nextIdx = startIdx;

            foreach (int i in Enumerable.Range(0, Sudoku.ColumnFieldsCount))
            {
                column.Add(this.Genotype.GeneSequence[nextIdx]);
                nextIdx = i % 3 == 0 ? nextIdx + numberOfFieldsInThreeRows : nextIdx + 3;
            }

            return column;
        }

        private float evaluateFitness()
        {
            this.evaluator = new FitnessEvaluator(this);
            return this.evaluator.Evaluate();
        }

        public static int Compare(Phenotype a, Phenotype b)
        {
            return a.Fitness - b.Fitness < 0 ? -1 : 1;
        }

    }
}
