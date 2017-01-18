namespace WMHSudokuSolver
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.inputTab = new System.Windows.Forms.TabPage();
            this.solveButton = new System.Windows.Forms.Button();
            this.mutationProbabilityLabel = new System.Windows.Forms.Label();
            this.crossingCountLabel = new System.Windows.Forms.Label();
            this.iterationCountLabel = new System.Windows.Forms.Label();
            this.mutationProbabilityBox = new System.Windows.Forms.NumericUpDown();
            this.crossingProbabilityBox = new System.Windows.Forms.NumericUpDown();
            this.iterationCountBox = new System.Windows.Forms.NumericUpDown();
            this.populationSizeLabel = new System.Windows.Forms.Label();
            this.populationSizeBox = new System.Windows.Forms.NumericUpDown();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.diffLevelComboBox = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.resultTab = new System.Windows.Forms.TabPage();
            this.probResultLabel = new System.Windows.Forms.Label();
            this.crossCountResultLabel = new System.Windows.Forms.Label();
            this.itCountResultLabel = new System.Windows.Forms.Label();
            this.popSizeResultLabel = new System.Windows.Forms.Label();
            this.chartLabel = new System.Windows.Forms.Label();
            this.resultsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.resultInputLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.inputTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutationProbabilityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossingProbabilityBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationCountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeBox)).BeginInit();
            this.resultTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.inputTab);
            this.tabControl1.Controls.Add(this.resultTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 499);
            this.tabControl1.TabIndex = 3;
            // 
            // inputTab
            // 
            this.inputTab.Controls.Add(this.solveButton);
            this.inputTab.Controls.Add(this.mutationProbabilityLabel);
            this.inputTab.Controls.Add(this.crossingCountLabel);
            this.inputTab.Controls.Add(this.iterationCountLabel);
            this.inputTab.Controls.Add(this.mutationProbabilityBox);
            this.inputTab.Controls.Add(this.crossingProbabilityBox);
            this.inputTab.Controls.Add(this.iterationCountBox);
            this.inputTab.Controls.Add(this.populationSizeLabel);
            this.inputTab.Controls.Add(this.populationSizeBox);
            this.inputTab.Controls.Add(this.itemTypeLabel);
            this.inputTab.Controls.Add(this.diffLevelComboBox);
            this.inputTab.Controls.Add(this.generateButton);
            this.inputTab.Location = new System.Drawing.Point(4, 22);
            this.inputTab.Name = "inputTab";
            this.inputTab.Padding = new System.Windows.Forms.Padding(3);
            this.inputTab.Size = new System.Drawing.Size(785, 473);
            this.inputTab.TabIndex = 0;
            this.inputTab.Text = "Input";
            this.inputTab.UseVisualStyleBackColor = true;
            // 
            // solveButton
            // 
            this.solveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.solveButton.Location = new System.Drawing.Point(475, 276);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(293, 28);
            this.solveButton.TabIndex = 27;
            this.solveButton.Text = "Solve!";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // mutationProbabilityLabel
            // 
            this.mutationProbabilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationProbabilityLabel.AutoSize = true;
            this.mutationProbabilityLabel.Location = new System.Drawing.Point(475, 252);
            this.mutationProbabilityLabel.Name = "mutationProbabilityLabel";
            this.mutationProbabilityLabel.Size = new System.Drawing.Size(101, 13);
            this.mutationProbabilityLabel.TabIndex = 26;
            this.mutationProbabilityLabel.Text = "Mutation probability:";
            // 
            // crossingCountLabel
            // 
            this.crossingCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crossingCountLabel.AutoSize = true;
            this.crossingCountLabel.Location = new System.Drawing.Point(475, 226);
            this.crossingCountLabel.Name = "crossingCountLabel";
            this.crossingCountLabel.Size = new System.Drawing.Size(105, 13);
            this.crossingCountLabel.TabIndex = 25;
            this.crossingCountLabel.Text = "Crossings probability:";
            // 
            // iterationCountLabel
            // 
            this.iterationCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iterationCountLabel.AutoSize = true;
            this.iterationCountLabel.Location = new System.Drawing.Point(475, 200);
            this.iterationCountLabel.Name = "iterationCountLabel";
            this.iterationCountLabel.Size = new System.Drawing.Size(78, 13);
            this.iterationCountLabel.TabIndex = 24;
            this.iterationCountLabel.Text = "Iteration count:";
            // 
            // mutationProbabilityBox
            // 
            this.mutationProbabilityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mutationProbabilityBox.DecimalPlaces = 3;
            this.mutationProbabilityBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.mutationProbabilityBox.Location = new System.Drawing.Point(648, 250);
            this.mutationProbabilityBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mutationProbabilityBox.Name = "mutationProbabilityBox";
            this.mutationProbabilityBox.Size = new System.Drawing.Size(120, 20);
            this.mutationProbabilityBox.TabIndex = 23;
            // 
            // crossingProbabilityBox
            // 
            this.crossingProbabilityBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crossingProbabilityBox.DecimalPlaces = 3;
            this.crossingProbabilityBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.crossingProbabilityBox.Location = new System.Drawing.Point(648, 224);
            this.crossingProbabilityBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.crossingProbabilityBox.Name = "crossingProbabilityBox";
            this.crossingProbabilityBox.Size = new System.Drawing.Size(120, 20);
            this.crossingProbabilityBox.TabIndex = 22;
            // 
            // iterationCountBox
            // 
            this.iterationCountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iterationCountBox.Location = new System.Drawing.Point(648, 198);
            this.iterationCountBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.iterationCountBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationCountBox.Name = "iterationCountBox";
            this.iterationCountBox.Size = new System.Drawing.Size(120, 20);
            this.iterationCountBox.TabIndex = 21;
            this.iterationCountBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // populationSizeLabel
            // 
            this.populationSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populationSizeLabel.AutoSize = true;
            this.populationSizeLabel.Location = new System.Drawing.Point(475, 174);
            this.populationSizeLabel.Name = "populationSizeLabel";
            this.populationSizeLabel.Size = new System.Drawing.Size(81, 13);
            this.populationSizeLabel.TabIndex = 20;
            this.populationSizeLabel.Text = "Population size:";
            // 
            // populationSizeBox
            // 
            this.populationSizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.populationSizeBox.Location = new System.Drawing.Point(648, 172);
            this.populationSizeBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.populationSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.populationSizeBox.Name = "populationSizeBox";
            this.populationSizeBox.Size = new System.Drawing.Size(120, 20);
            this.populationSizeBox.TabIndex = 19;
            this.populationSizeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Location = new System.Drawing.Point(476, 84);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(72, 13);
            this.itemTypeLabel.TabIndex = 9;
            this.itemTypeLabel.Text = "Difficulty level";
            // 
            // diffLevelComboBox
            // 
            this.diffLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.diffLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diffLevelComboBox.FormattingEnabled = true;
            this.diffLevelComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diffLevelComboBox.Location = new System.Drawing.Point(479, 100);
            this.diffLevelComboBox.Name = "diffLevelComboBox";
            this.diffLevelComboBox.Size = new System.Drawing.Size(286, 21);
            this.diffLevelComboBox.TabIndex = 8;
            this.diffLevelComboBox.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(478, 127);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(287, 26);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate sudoku!";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // resultTab
            // 
            this.resultTab.Controls.Add(this.probResultLabel);
            this.resultTab.Controls.Add(this.crossCountResultLabel);
            this.resultTab.Controls.Add(this.itCountResultLabel);
            this.resultTab.Controls.Add(this.popSizeResultLabel);
            this.resultTab.Controls.Add(this.chartLabel);
            this.resultTab.Controls.Add(this.resultsChart);
            this.resultTab.Controls.Add(this.resultsLabel);
            this.resultTab.Controls.Add(this.resultGridView);
            this.resultTab.Controls.Add(this.resultInputLabel);
            this.resultTab.Location = new System.Drawing.Point(4, 22);
            this.resultTab.Margin = new System.Windows.Forms.Padding(0);
            this.resultTab.Name = "resultTab";
            this.resultTab.Padding = new System.Windows.Forms.Padding(3);
            this.resultTab.Size = new System.Drawing.Size(785, 473);
            this.resultTab.TabIndex = 1;
            this.resultTab.Text = "Results";
            this.resultTab.UseVisualStyleBackColor = true;
            // 
            // probResultLabel
            // 
            this.probResultLabel.AutoSize = true;
            this.probResultLabel.Location = new System.Drawing.Point(8, 406);
            this.probResultLabel.Name = "probResultLabel";
            this.probResultLabel.Size = new System.Drawing.Size(101, 13);
            this.probResultLabel.TabIndex = 30;
            this.probResultLabel.Text = "Mutation probability:";
            // 
            // crossCountResultLabel
            // 
            this.crossCountResultLabel.AutoSize = true;
            this.crossCountResultLabel.Location = new System.Drawing.Point(8, 380);
            this.crossCountResultLabel.Name = "crossCountResultLabel";
            this.crossCountResultLabel.Size = new System.Drawing.Size(85, 13);
            this.crossCountResultLabel.TabIndex = 29;
            this.crossCountResultLabel.Text = "Crossings count:";
            // 
            // itCountResultLabel
            // 
            this.itCountResultLabel.AutoSize = true;
            this.itCountResultLabel.Location = new System.Drawing.Point(8, 354);
            this.itCountResultLabel.Name = "itCountResultLabel";
            this.itCountResultLabel.Size = new System.Drawing.Size(78, 13);
            this.itCountResultLabel.TabIndex = 28;
            this.itCountResultLabel.Text = "Iteration count:";
            // 
            // popSizeResultLabel
            // 
            this.popSizeResultLabel.AutoSize = true;
            this.popSizeResultLabel.Location = new System.Drawing.Point(8, 328);
            this.popSizeResultLabel.Name = "popSizeResultLabel";
            this.popSizeResultLabel.Size = new System.Drawing.Size(81, 13);
            this.popSizeResultLabel.TabIndex = 27;
            this.popSizeResultLabel.Text = "Population size:";
            // 
            // chartLabel
            // 
            this.chartLabel.AutoSize = true;
            this.chartLabel.Location = new System.Drawing.Point(412, 7);
            this.chartLabel.Name = "chartLabel";
            this.chartLabel.Size = new System.Drawing.Size(146, 13);
            this.chartLabel.TabIndex = 22;
            this.chartLabel.Text = "Chart (displaying best fitness):";
            // 
            // resultsChart
            // 
            this.resultsChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.resultsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.resultsChart.Legends.Add(legend1);
            this.resultsChart.Location = new System.Drawing.Point(274, 23);
            this.resultsChart.Name = "resultsChart";
            this.resultsChart.Size = new System.Drawing.Size(503, 273);
            this.resultsChart.TabIndex = 21;
            this.resultsChart.TabStop = false;
            this.resultsChart.Text = "Results:";
            this.resultsChart.Visible = false;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(11, 7);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(156, 13);
            this.resultsLabel.TabIndex = 20;
            this.resultsLabel.Text = "Results (displaying best fitness):";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.AllowUserToResizeRows = false;
            this.resultGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.resultGridView.Location = new System.Drawing.Point(11, 23);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.resultGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultGridView.Size = new System.Drawing.Size(257, 273);
            this.resultGridView.TabIndex = 19;
            // 
            // resultInputLabel
            // 
            this.resultInputLabel.AutoSize = true;
            this.resultInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultInputLabel.Location = new System.Drawing.Point(8, 303);
            this.resultInputLabel.Name = "resultInputLabel";
            this.resultInputLabel.Size = new System.Drawing.Size(74, 13);
            this.resultInputLabel.TabIndex = 1;
            this.resultInputLabel.Text = "Parameters:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(478, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 26);
            this.button2.TabIndex = 4;
            this.button2.Text = "Generate sudoku!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Sudoku Mega Solver";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.inputTab.ResumeLayout(false);
            this.inputTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mutationProbabilityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crossingProbabilityBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationCountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSizeBox)).EndInit();
            this.resultTab.ResumeLayout(false);
            this.resultTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage resultTab;
        private System.Windows.Forms.Label resultInputLabel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart resultsChart;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label chartLabel;
        private System.Windows.Forms.Label probResultLabel;
        private System.Windows.Forms.Label crossCountResultLabel;
        private System.Windows.Forms.Label itCountResultLabel;
        private System.Windows.Forms.Label popSizeResultLabel;
        private System.Windows.Forms.TabPage inputTab;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label mutationProbabilityLabel;
        private System.Windows.Forms.Label crossingCountLabel;
        private System.Windows.Forms.Label iterationCountLabel;
        private System.Windows.Forms.NumericUpDown mutationProbabilityBox;
        private System.Windows.Forms.NumericUpDown crossingProbabilityBox;
        private System.Windows.Forms.NumericUpDown iterationCountBox;
        private System.Windows.Forms.Label populationSizeLabel;
        private System.Windows.Forms.NumericUpDown populationSizeBox;
        private System.Windows.Forms.Label itemTypeLabel;
        private System.Windows.Forms.ComboBox diffLevelComboBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button button2;
    }
}

