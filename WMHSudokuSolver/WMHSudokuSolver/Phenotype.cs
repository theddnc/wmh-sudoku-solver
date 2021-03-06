﻿using System.Collections.Generic;
using System.Linq;

namespace WMHSudokuSolver
{
    class Phenotype
    {
        public Phenotype(Genotype genotype, Sudoku puzzle)
        {
            this.Genotype = genotype;
            this.Sudoku = puzzle;
            this.Genotype.ConstIndexes = puzzle.FilledFieldIndexes;
            this.Fitness = this.evaluateFitness();
        }

        public Phenotype(Sudoku puzzle)
        {
            this.Genotype = new Genotype(puzzle);
            this.Fitness = this.evaluateFitness();
        }

        public Sudoku Sudoku { get; private set; }
        public Genotype Genotype { get; private set; }
        public int Fitness { get; private set; }
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

            for (int i = 0; i < Sudoku.RowFieldsCount; ++i)
            {
                row.Add(this.Genotype.GeneSequence[nextIdx]);
                nextIdx = (i+1) % 3 == 0 ? nextIdx + remainingFieldsInSquareSection : nextIdx + 1;
            }

            return row;
        }

        public List<int> getColumnWithIndex(int index)
        {
            List<int> column = new List<int>();
            const int numberOfColumnsInColumnSection = 3;
            const int remainingFieldsInSquareSection = 7;
            const int fieldsInSquareSection = 9;
            const int remainingNumberOfFieldsInThreeRows = 21;

            int startIdx = fieldsInSquareSection * (index / numberOfColumnsInColumnSection) + index % numberOfColumnsInColumnSection;
            int nextIdx = startIdx;

            foreach (int i in Enumerable.Range(0, Sudoku.ColumnFieldsCount))
            {
                column.Add(this.Genotype.GeneSequence[nextIdx]);
                nextIdx = (i+1) % 3 == 0 ? nextIdx + remainingNumberOfFieldsInThreeRows : nextIdx + 3;
            }

            return column;
        }

        public List<int> getSectionWithIndex(int index)
        {
            const int numberOfFieldsInSection = 9;

            return this.Genotype.GeneSequence.GetRange(index * numberOfFieldsInSection, numberOfFieldsInSection);
        }

        private int evaluateFitness()
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
