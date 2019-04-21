using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Solvers
{
	public class SimpleSolver
	{
		private readonly List<SudokuBoard.Sudoku> _solutions;
		private int _currentIterationsCount;


		public SimpleSolver()
		{
			_solutions = new List<SudokuBoard.Sudoku>();
		}
		
		/// <summary>
		/// Count number of solutions for given sudoku
		/// </summary>
		/// <param name="sudoku"></param>
		/// <returns></returns>
		public int CountSolutions(SudokuBoard.Sudoku sudoku)
		{
			if (sudoku == null) throw new ArgumentNullException(nameof(sudoku));

			ClearAndSolve(sudoku.Copy(), 0, Enums.TopType.Any, int.MaxValue);
			return _solutions.Count;
		}

		/// <summary>
		/// Solve sudoku and return first available solution
		/// </summary>
		/// <param name="sudoku"></param>
		/// <returns></returns>
		public SudokuBoard.Sudoku SolveSudoku(SudokuBoard.Sudoku sudoku)
		{
			if (sudoku == null) throw new ArgumentNullException(nameof(sudoku));

			ClearAndSolve(sudoku.Copy(), 0, Enums.TopType.Any, 1);

			return _solutions.FirstOrDefault();
		}

		/// <summary>
		/// Solve sudoku and return given number of solutions in given order
		/// </summary>
		/// <param name="sudoku"> Sudoku to solve </param>
		/// <param name="count"> Number of solutions to return </param>
		/// <param name="topType"> Sort order </param>
		/// <returns></returns>
		public List<SudokuBoard.Sudoku> GetTopNSolutions(SudokuBoard.Sudoku sudoku, int count, Enums.TopType topType)
		{
			if (sudoku == null) throw  new ArgumentNullException(nameof(sudoku));
			if (count < 0) throw new Exception("Number of solutions can not be negative value");

			ClearAndSolve(sudoku.Copy(), 0, topType, count);

			return topType == Enums.TopType.Hardest 
				? _solutions.Skip(Math.Max(0, _solutions.Count - count)).ToList() 
				: _solutions.ToList();
		}

		private void ClearAndSolve(SudokuBoard.Sudoku sudoku, int currentIndex, Enums.TopType type, int count)
		{
			_currentIterationsCount = 0;
			_solutions.Clear();

			SolveBruteForce(sudoku, currentIndex, type, count);
		}

		private bool SolveBruteForce(SudokuBoard.Sudoku sudoku, int currentIndex, Enums.TopType type, int count)
		{
			while (true)
			{
				if (currentIndex == SudokuBoard.Sudoku.BigSide * SudokuBoard.Sudoku.BigSide)
				{
					var solutionBoard = sudoku.Copy();
					solutionBoard.DifficultyPoints = _currentIterationsCount;
					_solutions.Add(solutionBoard);
					return true;
				}
				else
				{
					var row = currentIndex / SudokuBoard.Sudoku.BigSide;
					var column = currentIndex % SudokuBoard.Sudoku.BigSide;

					if (sudoku[row, column] != 0)
					{
						currentIndex = currentIndex + 1;
						continue;
					}

					for (var i = 1; i <= SudokuBoard.Sudoku.BigSide; i++)
					{
						_currentIterationsCount++;
						if (!ConsistentIfPut(sudoku, row, column, i)) continue;

						sudoku[row, column] = i;
						if (SolveBruteForce(sudoku, currentIndex + 1, type, count) &&
						    (type == Enums.TopType.Any || type == Enums.TopType.Easiest) && _solutions.Count >= count) 
							return true;
						sudoku[row, column] = 0;
					}
				}

				return false;
			}
		}

		private static bool ConsistentIfPut(SudokuBoard.Sudoku board, int row, int column, int value)
		{
			for (var i = 0; i < SudokuBoard.Sudoku.BigSide; i++)
			{
				if (board[row, i] == value) return false;
				if (board[i, column] == value) return false;
			}

			var rowStart = row - row % SudokuBoard.Sudoku.SmallSide;
			var columnStart = column - column % SudokuBoard.Sudoku.SmallSide;

			for (var m = 0; m < SudokuBoard.Sudoku.SmallSide; m++)
			{
				for (var k = 0; k < SudokuBoard.Sudoku.SmallSide; k++)
				{
					if (board[rowStart + k, columnStart + m] == value) return false;
				}
			}
			return true;
		}
	}
}
