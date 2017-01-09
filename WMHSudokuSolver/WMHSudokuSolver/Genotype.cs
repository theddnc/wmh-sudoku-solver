using System.Collections.Generic;
using System.Linq;

namespace WMHSudokuSolver
{
    class Genotype
    {
        const int GeneSequenceLength = 81;
        const int GenesInSectionCount = 9;
        const int GeneSequenceSectionCount = 9;

        public Genotype(List<int> sequence)
        {
            this.GeneSequence = sequence;
        }

        public Genotype(Phenotype phenotype)
        {
            this.GeneSequence = new List<int>(phenotype.Genotype.GeneSequence);
        }

        public Genotype(Sudoku puzzle)
        {
            this.ConstIndexes = puzzle.FilledFieldIndexes;
            List<int> numbersToDrawFrom = new List<int>();
            List<int> missingNumbersCountsList = puzzle.MissingNumbersCountsList;

            //build a list that contains missing numbers: 1, ..., 1, 2, ..., 2, ..., etc
            foreach (int number in missingNumbersCountsList)
            {
                numbersToDrawFrom.AddRange(Enumerable.Repeat(number, missingNumbersCountsList[number]));
            }

            //fill in the blanks randomly
            foreach (int number in Enumerable.Range(0, puzzle.EmptyFieldCount))
            {
                int randomIdx = Randomizer.Instance.GetRandomInt(0, numbersToDrawFrom.Count);
                int emptyIdx = puzzle.EmptyFieldIndexes[number];
                puzzle.Board[emptyIdx] = numbersToDrawFrom[randomIdx];
                numbersToDrawFrom.RemoveAt(randomIdx);
            }

            //all is done
            this.GeneSequence = new List<int>(puzzle.Board);
        }
        
        public Genotype(Genotype toCopy)
        {
            this.GeneSequence = new List<int>(toCopy.GeneSequence);
            this.ConstIndexes = toCopy.ConstIndexes;
        }
        public List<int> GeneSequence { get; private set; }
        public List<int> ConstIndexes { get; set; }

        public void Mutate()
        {
            int section = Randomizer.Instance.GetRandomInt(0, GeneSequenceSectionCount);
            int firstGene = this.selectMutationGeneInSection(section);
            int secondGene = this.selectMutationGeneInSection(section);
            int temp = GeneSequence[firstGene];
            GeneSequence[firstGene] = GeneSequence[secondGene];
            GeneSequence[secondGene] = temp;
        }

        private int selectMutationGeneInSection(int section)
        {
            int gene = -1;
            do
            {
                gene = section * GenesInSectionCount + Randomizer.Instance.GetRandomInt(0, GenesInSectionCount);
            } while (this.ConstIndexes.Contains(gene));

            return gene;
        }

        public List<Genotype> CrossOverWith(Genotype other)
        {
            List<int> maleGenes = new List<int>(this.GeneSequence);
            List<int> femaleGenes = new List<int>(other.GeneSequence);
            List<int> maleChild = new List<int>();
            List<int> femaleChild = new List<int>();
            int locus = GenesInSectionCount * Randomizer.Instance.GetRandomInt(0, GeneSequenceSectionCount);
            for (int i = 0; i < locus; ++i)
            {
                maleChild.Add(this.GeneSequence[i]);
                femaleChild.Add(other.GeneSequence[i]);
                maleGenes.Remove(femaleChild[i]);
                femaleGenes.Remove(maleChild[i]);
            }
            for (int i = 0; i < maleGenes.Count; ++i)
            {
                femaleChild.Add(maleGenes[i]);
                maleChild.Add(femaleGenes[i]);
            }
            List<Genotype> result = new List<Genotype>();
            result.Add(new Genotype(femaleChild)); result.Add(new Genotype(maleChild));
            return result;
        }
    }
}
