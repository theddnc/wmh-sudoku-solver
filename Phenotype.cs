using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Phenotype
    {
        public Phenotype(Genotype genotype, Sudoku sudoku)
        {
            this.m_sudoku = sudoku;
            this.Genotype = genotype;
            this.Sequence = this.makeSequence(sudoku);
            this.Fitness = this.evaluateFitness();
        }

        public Phenotype(Sudoku sudoku)
        {
            this.m_sudoku = sudoku;
            this.Genotype = new Genotype(sudoku);
            this.Sequence = this.makeSequence(sudoku);
            this.Fitness = this.evaluateFitness();
        }

        public Genotype Genotype { get; private set; }
        public List<Material> Sequence { get; private set; }
        public float Fitness { get; private set; }

        private Sudoku m_sudoku;
        private FitnessEvaluator evaluator;

        private float evaluateFitness()
        {
            this.evaluator = new FitnessEvaluator(Sequence, m_sudoku);
            return this.evaluator.Evaluate();
        }
        private List<Material> makeSequence(Sudoku sudoku)
        {   
            List<Material> normalizedList = sudoku.NormalizedList;
            List<Material> sequence = new List<Material>(normalizedList.Count);
            foreach (int gene in Genotype.GeneSequence)
            {
                sequence.Add(normalizedList[gene-1]);
            }
            return sequence;
        }

        public static int Compare(Phenotype a, Phenotype b)
        {
            return a.Fitness - b.Fitness < 0 ? -1 : 1;
        }

    }
}
