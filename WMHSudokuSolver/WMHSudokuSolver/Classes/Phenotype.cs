using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Phenotype
    {
        public Phenotype(Genotype genotype)
        {
            this.Genotype = genotype;
            this.Fitness = this.evaluateFitness();
        }

        public Genotype Genotype { get; private set; }
        //public List<Material> Sequence { get; private set; }
        public float Fitness { get; private set; }
        private FitnessEvaluator evaluator;

        private float evaluateFitness()
        {
            this.evaluator = new FitnessEvaluator(Genotype);
            return this.evaluator.Evaluate();
        }

        public static int Compare(Phenotype a, Phenotype b)
        {
            return a.Fitness - b.Fitness < 0 ? -1 : 1;
        }

    }
}
