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
            this.ConstIndexes = new List<int>(phenotype.Genotype.ConstIndexes);
            this.GeneSequence = new List<int>(phenotype.Genotype.GeneSequence);
            this.Puzzle = phenotype.Genotype.Puzzle;
        }

        public Genotype(Sudoku puzzle)
        {
            this.ConstIndexes = puzzle.FilledFieldIndexes;
            this.Puzzle = puzzle;
            List<int> numbersToDrawFrom = new List<int>();
            List<int> missingNumbersCountsList = puzzle.MissingNumbersCountsList;

            //build a list that contains missing numbers: 1, ..., 1, 2, ..., 2, ..., etc
            for (int i = 1; i <= GenesInSectionCount; ++i)
            {
                for (int j = 0; j < missingNumbersCountsList[i]; j ++)
                {
                    numbersToDrawFrom.Add(i);
                }
            }

            var newBoard = new List<int>(puzzle.Board);

            //fill in the blanks randomly
            for (int i = 0; i < puzzle.EmptyFieldCount; ++i)
            {
                int randomIdx = Randomizer.Instance.GetRandomInt(0, numbersToDrawFrom.Count);
                int emptyIdx = puzzle.EmptyFieldIndexes[i];
                newBoard[emptyIdx] = numbersToDrawFrom[randomIdx];
                numbersToDrawFrom.RemoveAt(randomIdx);
            }

            //all is done
            this.GeneSequence = new List<int>(newBoard);
        }
        
        public Genotype(Genotype toCopy)
        {
            this.GeneSequence = new List<int>(toCopy.GeneSequence);
            this.ConstIndexes = new List<int>(toCopy.ConstIndexes);
            this.Puzzle = toCopy.Puzzle;
        }
        public List<int> GeneSequence { get; private set; }
        public List<int> ConstIndexes { get; set; }
        public Sudoku Puzzle;

        public void Mutate()
        {
            int firstGene = this.selectMutationGene();
            int secondGene = this.selectMutationGene();
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

        private int selectMutationGene()
        {
            int gene = -1;
            do
            {
                gene = Randomizer.Instance.GetRandomInt(0, GeneSequenceLength);
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

            var femaleGenotype = new Genotype(femaleChild);
            femaleGenotype.ConstIndexes = this.ConstIndexes;
            femaleGenotype.Puzzle = this.Puzzle;

            var maleGenotype = new Genotype(maleChild);
            maleGenotype.ConstIndexes = this.ConstIndexes;
            maleGenotype.Puzzle = this.Puzzle;

            result.Add(femaleGenotype); result.Add(maleGenotype);
            return result;
        }
    }
}
