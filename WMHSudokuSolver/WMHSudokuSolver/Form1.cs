
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WMHSudokuSolver
{
    public partial class MainWindow : Form
    {
        private Sudoku sudoku;
        private Phenotype bestPhenotype;
        private Sudoku solvedSudoku;
        private SudokuBoardViewController sudokuBoardViewController;
        public MainWindow()
        {
            InitializeComponent();
            diffLevelComboBox.DataSource = Enum.GetValues(typeof(Sudoku.DifficultyLevel));
            initChart();

            sudokuBoardViewController = new SudokuBoardViewController();
            inputTab.Controls.Add(sudokuBoardViewController.SudokuBoardView);
        }

        private void initChart()
        {
            Series series = new Series("phenotypes");
            series.ChartType = SeriesChartType.Line;
            resultsChart.Series.Add(series);
            resultsChart.Series[0].XValueMember = "Iteration";
            resultsChart.Series[0].YValueMembers = "Fitness";
            resultsChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0:0.00}";
            resultsChart.Series[0].IsVisibleInLegend = false;
            resultsChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SUDOKUUUUUUU", "About");            
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            generateButton.IsAccessible = false;
            String origText = generateButton.Text;
            generateButton.Text = "Getting your sudoku, stay put";
            Sudoku.DifficultyLevel diffLevel = (Sudoku.DifficultyLevel)diffLevelComboBox.SelectedValue;
            SudokuPuzzle generator = SudokuPuzzle.generatePuzzle(9);
            sudoku = generator.getSudoku(diffLevel);
            solvedSudoku = generator.getSudoku(Sudoku.DifficultyLevel.None);
            sudokuBoardViewController.updateBoardView(sudoku);
            generateButton.IsAccessible = true;
            generateButton.Text = origText;
        }

        private void solveButton_Click(object sender, EventArgs e)
        {        
            
            if (sudoku == null)
            {
                MessageBox.Show("Generate sudoku first!");
            }
            else if (populationSizeBox.Value <= 1)
            {
                MessageBox.Show("Population size must be greater than 1");
            }
            else if (iterationCountBox.Value == 0)
            {
                MessageBox.Show("Iteration count must be greater than 0");
            }
            else if (crossingProbabilityBox.Value == 0 && mutationProbabilityBox.Value == 0)
            {
                MessageBox.Show("Either mutation or crossings probability should be greater than 0");
            }
            else
            {
                //sudokuBoardViewController.updateBoardView(solvedSudoku, sudoku);

                solveButton.IsAccessible = false;
                solveButton.Text = "Solving...";
                List<PhenotypeView> bestPhenotypesViews = this.solve();
                resultGridView.DataSource = bestPhenotypesViews;
                this.updateChart(bestPhenotypesViews);
                this.displaySequence();
                tabControl1.SelectTab(1);
                sudokuBoardViewController.updateBoardView(new Sudoku(bestPhenotype.Genotype.GeneSequence), sudoku);
                solveButton.IsAccessible = true;
                solveButton.Text = "Solve";
            }
        }

        private List<PhenotypeView> solve()
        {
            List<PhenotypeView> bestPhenotypesViews = new List<PhenotypeView>();
            // Tworzenie solvera
            Solver.getInstance().Configure(this.sudoku, (int)populationSizeBox.Value, (int)iterationCountBox.Value, (float)crossingProbabilityBox.Value,(float)mutationProbabilityBox.Value);

            
            List<List<Phenotype>> populations = new List<List<Phenotype>>();
            populations = Solver.getInstance().Solve();
            bestPhenotype = populations[populations.Count - 1][0];

            int i = 1;
            foreach (List<Phenotype> population in populations)
            {
                bestPhenotypesViews.Add(new PhenotypeView(population[0], i));
                i++;
            }

            return bestPhenotypesViews;
        }

        private void updateChart(List<PhenotypeView> views)
        {
            
            resultsChart.DataSource = views;
            //Scale chart
            double min=views[0].Fitness;
            double max = views[0].Fitness;
            foreach (PhenotypeView pv in views)
            {
                min = Math.Min(min, pv.Fitness);
                max = Math.Max(max, pv.Fitness);
            }
            resultsChart.ChartAreas[0].AxisY.Maximum = max + (max*0.1);
            resultsChart.ChartAreas[0].AxisY.Minimum = min - (max*0.1);
            resultsChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            resultsChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            resultsChart.DataBind();
            resultsChart.Visible = true;
        }

        private void displaySequence()
        {
            popSizeResultLabel.Text = "Population size: " + Solver.getInstance().PopulationSize.ToString();
            probResultLabel.Text = "Mutation probablity: " + Solver.getInstance().MutationProbability.ToString();
            crossCountResultLabel.Text = "Crossing probability: " + Solver.getInstance().CrossOverProbability.ToString();
            itCountResultLabel.Text = "Iteration count: " + Solver.getInstance().IterationCount.ToString();
        }

    }
}
