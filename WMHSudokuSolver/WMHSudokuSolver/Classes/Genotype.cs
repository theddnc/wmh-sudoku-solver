using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class Genotype
    {
        public Genotype(List<int> sequence)
        {
            this.GeneSequence = sequence;
        }

        public Genotype(Phenotype phenotype)
        {
            this.GeneSequence = new List<int>(phenotype.Genotype.GeneSequence);
            //this.GeneSequence = Enumerable.Range(1, count).OrderBy(a => Randomizer.Instance.GetProbability()).ToList();
        }
        
        public Genotype(Genotype toCopy)
        {
            this.GeneSequence = new List<int>(toCopy.GeneSequence);
        }
        public List<int> GeneSequence { get; private set; }

        public void Mutate()
        {
            int firstGene = Randomizer.Instance.GetRandomInt(0, GeneSequence.Count);
            int secondGene = Randomizer.Instance.GetRandomInt(0, GeneSequence.Count);
            int temp = GeneSequence[firstGene];
            GeneSequence[firstGene] = GeneSequence[secondGene];
            GeneSequence[secondGene] = temp;
        }
    }
}
