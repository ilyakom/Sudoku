using System;

namespace Sudoku.SudokuBoard
{
	internal class Cell
	{
		private int _row;
		private int _column;
		private int _value;

		public Cell(int x, int y, int value)
		{
			_row = x;
			_column = y;
			_value = value;
		}

		public int Row
		{
			get => _row;
			set
			{
				if (value >= Sudoku.BigSide || value < 0 )
					throw new ArgumentOutOfRangeException($"Incorrect sudoku X position");

				_row = value;
			}
		}

		public int Column
		{
			get => _column;
			set
			{
				if (value >= Sudoku.BigSide || value < 0)
					throw new ArgumentOutOfRangeException($"Incorrect sudoku Y position");

				_column = value;
			}
		}

		public int Value
		{
			get => _value;
			set
			{
				if (value > Sudoku.BigSide || value < 0)
					throw new ArgumentOutOfRangeException($"Incorrect sudoku Value");

				_value = value;
			}
		}
	}
}
