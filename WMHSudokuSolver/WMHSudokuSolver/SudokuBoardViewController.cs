using System;
using System.Drawing;
using System.Windows.Forms;

namespace WMHSudokuSolver
{
    class SudokuBoardViewController
    {
        public DataGridView SudokuBoardView { get; set; }
        private const int cColWidth = 50;
        private const int cRowHeigth = 50;
        private const int cMaxCell = Sudoku.ColumnFieldsCount;
        private const int cSidelength = cColWidth * cMaxCell + 3;

        public SudokuBoardViewController()
        {
            SudokuBoardView = getNewBoardView();
        }

        public DataGridView updateBoardView(Sudoku sudoku, Sudoku startingSudoku = null)
        {
            for (int sectionId = 0; sectionId < Sudoku.SectionCount; sectionId++)
            {
                for (int fieldY = 0; fieldY < Sudoku.SectionRowCount; fieldY++)
                {
                    for (int fieldX = 0; fieldX < Sudoku.SectionRowCount; fieldX++)
                    {
                        int id = sectionId * Sudoku.SectionCount + fieldY * Sudoku.SectionRowCount + fieldX;
                        int value = sudoku.Board[id];
                        int rowId = (sectionId / Sudoku.SectionRowCount) * Sudoku.SectionRowCount + fieldY;
                        int colId = sectionId % Sudoku.SectionRowCount * Sudoku.SectionRowCount + fieldX;
                        int startingValue = startingSudoku != null ? startingSudoku.Board[id] : value;
                        updateCell(startingValue, value, rowId, colId);
                    }
                }
            }
            return SudokuBoardView;
        }

        private void updateCell(int startingValue, int value, int rowId, int colId)
        {
            if (value != Sudoku.EmptyFieldMarker)
            {
                SudokuBoardView.Rows[rowId].Cells[colId].Value = value;
                SudokuBoardView.Rows[rowId].Cells[colId].Style.ForeColor = startingValue != value ? Color.DarkGreen : Color.Black;
            }
            else
            {
                SudokuBoardView.Rows[rowId].Cells[colId].Value = null;
            }
        }

        private DataGridView getNewBoardView()
        {
            DataGridView DGV = new DataGridView();
            DGV.Name = "DGV";
            DGV.AllowUserToResizeColumns = false;
            DGV.AllowUserToResizeRows = false;
            DGV.AllowUserToAddRows = false;
            DGV.RowHeadersVisible = false;
            DGV.ColumnHeadersVisible = false;
            DGV.GridColor = Color.Black;
            DGV.DefaultCellStyle.BackColor = Color.DarkGray;
            DGV.ScrollBars = ScrollBars.None;
            DGV.Size = new Size(cSidelength, cSidelength);
            DGV.Location = new Point(15, 15);
            DGV.Font = new System.Drawing.Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            DGV.ForeColor = Color.Black;
            DGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            DGV.SelectionChanged += selectionHandlerUnselectAll;
            // add 81 cells
            for (int i = 0; i < cMaxCell; i++)
            {
                DataGridViewTextBoxColumn TxCol = new DataGridViewTextBoxColumn();
                TxCol.MaxInputLength = 1;   // only one digit allowed in a cell
                TxCol.ReadOnly = true;
                DGV.Columns.Add(TxCol);
                DGV.Columns[i].Name = "Col " + (i + 1).ToString();
                DGV.Columns[i].Width = cColWidth;
                DGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewRow row = new DataGridViewRow();
                row.Height = cRowHeigth;
                DGV.Rows.Add(row);
            }
            // mark the 9 square areas consisting of 9 cells
            DGV.Columns[2].DividerWidth = 2;
            DGV.Columns[5].DividerWidth = 2;
            DGV.Rows[2].DividerHeight = 2;
            DGV.Rows[5].DividerHeight = 2;
            return DGV;
        }

        private void selectionHandlerUnselectAll(object sender, EventArgs e)
        {
            SudokuBoardView.ClearSelection();
        }
    }
}
