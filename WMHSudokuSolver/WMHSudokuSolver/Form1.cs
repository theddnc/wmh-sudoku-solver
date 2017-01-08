
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
        private List<Phenotype> bestPhenotypes;
        private SudokuBoardViewController sudokuBoardViewController;
        public MainWindow()
        {
            InitializeComponent();
            diffLevelComboBox.DataSource = Enum.GetValues(typeof(Sudoku.DifficultyLevel));
            Series series = new Series("phenotypes");
            series.ChartType = SeriesChartType.Line;
            resultsChart.Series.Add(series);
            resultsChart.Series[0].XValueMember = "Iteration";
            resultsChart.Series[0].YValueMembers = "Fitness";
            resultsChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "{0:0.00}";
            //series.IsValueShownAsLabel = true;
            resultsChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            sudokuBoardViewController = new SudokuBoardViewController();
            inputTab.Controls.Add(sudokuBoardViewController.SudokuBoardView);
        }

        private void loadOrderFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SUDOKUUUUUUU", "About");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 81; i++)
            {
                list.Add(i % 9);
            }
            Sudoku sudoku = new Sudoku(list);
            sudokuBoardViewController.updateBoardView(sudoku);
        }

        private void solveButton_Click(object sender, EventArgs e)
        {        
            
            if (sudoku == null)
            {
                MessageBox.Show("Generate sudoku first!");
            }
            else if (populationSizeBox.Value == 0)
            {
                MessageBox.Show("Population size must be greater > 0");
            }
            else if (iterationCountBox.Value == 0)
            {
                MessageBox.Show("Iteration count must be greater > 0");
            }
            else if (crossingCountBox.Value*2>populationSizeBox.Value)
            {
                MessageBox.Show("Crossings count must be smaller that half of the population");
            }
            else
            {
              //  Solver.getInstance().Configure(order, (int)populationSizeBox.Value, (int)iterationCountBox.Value, (int)crossingCountBox.Value,(float)mutationProbabilityBox.Value);
              //  solveButton.IsAccessible = false;
              //  solveButton.Text = "Solving...";
              //  GetResults();
              ////  resultGridView.DataSource = medianPhenotypesViews;   
              //  resultGridView.DataSource = bestPhenotypesViews;
              //  loadChart(bestPhenotypesViews);
              //  displaySequence();
              //  tabControl1.SelectTab(1);
              //  solveButton.IsAccessible = true;
              //  solveButton.Text = "Solve";
            }
        }

        private void GetResults()
        {
            //bestPhenotypesViews = new List<PhenotypeView>();
            //List<List<Phenotype>> populations;
            //populations = Solver.getInstance().Solve();

            //int i = 1;
            //foreach (List<Phenotype> population in populations)
            //{
            //    bestPhenotypesViews.Add(new PhenotypeView(population[0].Fitness, i, population[0].UsedPipes.Count, population[0].UsedProfiles.Count, population[0].SumOfTheRings));
            //    i++;
            //}
            //bestPhenotype = populations[populations.Count - 1][0];                  
        }

        private void loadChart(List<Phenotype> views)
        {
            
            resultsChart.DataSource = views;
            //Scale chart
            double min=views[0].Fitness;
            double max = views[0].Fitness;
            foreach (Phenotype pv in views)
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
            crossCountResultLabel.Text = "Crossing count: " + Solver.getInstance().CrossOverCount.ToString();
            itCountResultLabel.Text = "Iteration count: " + Solver.getInstance().IterationCount.ToString();
            genotypeTextBox.Text = "";
            phenotypeTextBox.Text = "";
            foreach (int item in bestPhenotype.Genotype.GeneSequence)
            {
                genotypeTextBox.Text += item.ToString() + " ,";
            }
            //foreach (Material item in bestPhenotype.Sequence)
            //{
            //    phenotypeTextBox.Text += item.Type.ToString() +":"+item.Length.ToString() +" ,";
            //}
        }

    }
}
