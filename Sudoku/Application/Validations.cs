namespace Sudoku.Application
{
	public static class Validations
	{
		/// <summary>
		/// Check if Sudoku remain consistent if we put number in specified location
		/// </summary>
		/// <param name="board">Board to check</param>
		/// <param name="row">row in board</param>
		/// <param name="column">column in board</param>
		/// <param name="value">value to put</param>
		/// <returns></returns>
		public static bool ConsistentIfPut(Domain.Sudoku board, int row, int column, int value)
		{
			for (var i = 0; i < Domain.Sudoku.BigSide; i++)
			{
				if (board[row, i] == value) return false;
				if (board[i, column] == value) return false;
			}

			var rowStart = row - row % Domain.Sudoku.SmallSide;
			var columnStart = column - column % Domain.Sudoku.SmallSide;

			for (var m = 0; m < Domain.Sudoku.SmallSide; m++)
			{
				for (var k = 0; k < Domain.Sudoku.SmallSide; k++)
				{
					if (board[rowStart + k, columnStart + m] == value) return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Validate sudoku if it's consistent
		/// </summary>
		/// <param name="board"></param>
		/// <returns></returns>
		public static bool ValidateSudoku(Domain.Sudoku board)
		{
			for (var i = 0; i < Domain.Sudoku.BigSide; i++)
			{
				if (!ValidateRowColumn(board, i))
					return false;
			}	

			for (var i = 0; i < Domain.Sudoku.BigSide; i += Domain.Sudoku.SmallSide)
			{
				for (var j = 0; j < Domain.Sudoku.BigSide; j += Domain.Sudoku.SmallSide)
				{
					if (!ValidateSubSquare(board, i, j))
						return false;
				}
			}

			return true;
		}

		private static bool ValidateRowColumn(Domain.Sudoku board, int idx)
		{
			var rowSet = new bool[Domain.Sudoku.BigSide + 1];
			var colSet = new bool[Domain.Sudoku.BigSide + 1];

			for (var i = 0; i < Domain.Sudoku.BigSide; i++)
			{
				if (board[idx, i] != 0 && rowSet[board[idx, i]])
					return false;

				if (board[i, idx] != 0 && colSet[board[i, idx]])
					return false;

				rowSet[board[idx, i]] = true;
				colSet[board[i, idx]] = true;
			}

			return true;
		}

		private static bool ValidateSubSquare(Domain.Sudoku board, int colStart, int rowStart)
		{
			var set = new bool[Domain.Sudoku.BigSide + 1];

			for (var i = 0; i < Domain.Sudoku.SmallSide; i++)
			{
				for (var j = 0; j < Domain.Sudoku.SmallSide; j++)
				{
					if (board[rowStart + i, colStart + j] != 0 && set[board[rowStart + i, colStart + j]])
						return false;

					set[board[rowStart + i, colStart + j]] = true;
				}
			}

			return true;
		}
	}
}
