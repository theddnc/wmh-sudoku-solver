using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMHSudokuSolver
{
    class Sudoku
    {
        public const int EmptyFieldMarker = -1;
        public const int MinValue = 1;
        public const int MaxValue = 9;
        public const int MaxNumberCount = 9;
        public const int TotalFieldCount = 81;
        public const int RowFieldsCount = 9;
        public const int ColumnFieldsCount = 9;
        public const int RowsCount = 9;
        public const int ColumsCount = 9;
        public const int SectionRowCount = 3;
        public const int SectionCount = 9;

        public enum DifficultyLevel
        {
            None = 0,
            Easy = 20,
            Medium = 30,
            Hard = 40
        }
        public Sudoku(List<int> board)
        {
            this.Board = board;
        }

        public Sudoku(int[] board)
        {
            this.Board = board.ToList<int>();
        }
        public List<int> Board { get; private set; }

        public int EmptyFieldCount
        {
            get
            {
                return this.Board.Count(i => i == EmptyFieldMarker);
            }
        }

        public List<int> MissingNumbersCountsList
        {
            get
            {
                List<int> missingNumbers = new List<int>();
                foreach(int number in Enumerable.Range(MinValue, MaxValue)) {
                    missingNumbers[number] = MaxNumberCount - this.Board.Count(i => i == number);
                }
                return missingNumbers;
            }
        }

        public List<int> EmptyFieldIndexes
        {
            get
            {
                List<int> emptyFieldIndexes = new List<int>();
                for (int i = 0; i < TotalFieldCount; i++)
                {
                    if (this.Board[i] == EmptyFieldMarker)
                    {
                        emptyFieldIndexes.Add(i);
                    }
                }
                return emptyFieldIndexes;
            }
        }

        public List<int> FilledFieldIndexes
        {
            get
            {
                List<int> filledFieldIndexes = new List<int>();
                for (int i = 0; i < TotalFieldCount; i++)
                {
                    if (this.Board[i] != EmptyFieldMarker)
                    {
                        filledFieldIndexes.Add(i);
                    }
                }
                return filledFieldIndexes;
            }
        }
    }
}
