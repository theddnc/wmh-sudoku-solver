using System.Linq;

namespace WMHSudokuSolver
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
                var r = this.Phenotype.getRowWithIndex(row);
                var duplicates = from field in r
                                 group field by field into g
                                 let count = g.Count() - 1
                                 select count;

                fitness += duplicates.Sum();
            }

            foreach (int row in Enumerable.Range(0, Sudoku.ColumsCount))
            {
                var c = this.Phenotype.getColumnWithIndex(row);
                var duplicates = from field in c
                                 group field by field into g
                                 let count = g.Count() - 1
                                 select count;

                fitness += duplicates.Sum();
            }

            foreach (int row in Enumerable.Range(0, Sudoku.SectionCount))
            {
                var s = this.Phenotype.getSectionWithIndex(row);
                var duplicates = from field in s
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

