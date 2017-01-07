using SudokuSolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMHSudokuSolver.Classes
{
    class Solver
    {
        private static Solver instance;
        private Solver()
        {

        }

        public static Solver getInstance()
        {
            if (instance == null)
            {
                instance = new Solver();
            }
            return instance;
        }

        public void Configure(Sudoku solution, Sudoku puzzle, int popSize, int iterCount, int crossOverCount, float mutationProbability)
        {
            this.Solution = solution;
            this.Puzzle = puzzle;
            this.PopulationSize = popSize;
            this.IterationCount = iterCount;
            this.CrossOverCount = crossOverCount;
            this.MutationProbability = mutationProbability;
            this.Population = new List<Phenotype>(PopulationSize);
            for (int i = 0; i < PopulationSize; ++i)
            {
                Population.Add(new Phenotype(this.Puzzle, this.Solution));
            }
        }

        public Sudoku Solution { get; private set; }
        public Sudoku Puzzle { get; private set; }
        public int PopulationSize { get; private set; } //mi
        public int IterationCount { get; private set; }
        public int CrossOverCount { get; private set; } //lambda - or probability?
        public float MutationProbability { get; private set; }

        private List<Phenotype> Population { get; set; }

        private void SelectBestFits()
        {
            this.Population.Sort(Phenotype.Compare);
            this.Population.RemoveRange(this.PopulationSize, this.Population.Count - this.PopulationSize);
        }

        private void Reproduce()
        {
            List<Phenotype> reproducers = DrawReproducers();
            for (int i = 0; i < reproducers.Count; i += 2)
            {
                List<Genotype> newGenotypes = reproducers[i].Genotype.CrossOverWith(reproducers[i + 1].Genotype);
                foreach (Genotype child in newGenotypes)
                {
                    if (Randomizer.Instance.GetProbability() < this.MutationProbability)
                    {
                        child.Mutate();
                    }
                    this.Population.Add(new Phenotype(child, this.Solution));
                }
            }
        }

        private List<Phenotype> DrawReproducers()
        {
            List<Phenotype> copiedPopulation = new List<Phenotype>(this.Population);
            List<Phenotype> crossOverParticipants = new List<Phenotype>();
            Randomizer rand = Randomizer.Instance;

            for (int i = 0; i < this.CrossOverCount * 2; ++i)
            {
                int r = rand.GetRandomInt(0, copiedPopulation.Count);
                Phenotype participant = copiedPopulation[r];
                crossOverParticipants.Add(participant);
                //copiedPopulation.Remove(participant); - Sampling Without Replacement?
            }

            return crossOverParticipants;
        }

        public List<List<Phenotype>> Solve()
        {
            List<List<Phenotype>> iterationPopulations = new List<List<Phenotype>>();
            for (int i = 0; i < this.IterationCount; ++i)
            {
                SelectBestFits();
                iterationPopulations.Add(new List<Phenotype>(this.Population));
                Reproduce();
            }
            return iterationPopulations;
        }

    }
}
