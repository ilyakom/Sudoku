using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Solvers
{
	internal class SmartBruteForce
	{
		private Dictionary<int, Dictionary<int, HashSet<int>>> _availableDigits;

		private void FillUpAvailableDigits()
		{
			var hashSet = new HashSet<int>();
		
			for (var i = 1; i <= SudokuBoard.Sudoku.BigSide; i++)
			{
				hashSet.Add(i);
			}

			for (var i = 0; i < SudokuBoard.Sudoku.BigSide; i++)
			{
				_availableDigits[i] = new Dictionary<int, HashSet<int>>();

				for (var j = 0; j < SudokuBoard.Sudoku.BigSide; j++)
				{
					_availableDigits[i][j] = new HashSet<int>(hashSet);
				}
			}
		}

		private void RemoveDefaults(SudokuBoard.Sudoku sudoku)
		{
			for (var i = 0; i < SudokuBoard.Sudoku.BigSide; i++)
			{
				for (var j = 0; j < SudokuBoard.Sudoku.BigSide; j++)
				{
					if (sudoku[i, j] == 0) continue;

					for (var m = 0; m < SudokuBoard.Sudoku.BigSide; m++)
					{
						if (_availableDigits[i][m].Contains(sudoku[i, j]))
							_availableDigits[i][m].Remove(sudoku[i, j]);

						if (_availableDigits[m][j].Contains(sudoku[i, j]))
							_availableDigits[m][j].Remove(sudoku[i, j]);
					}

					var rowStart = i - i % SudokuBoard.Sudoku.SmallSide;
					var columnStart = j - j % SudokuBoard.Sudoku.SmallSide;

					for (var m = 0; m < SudokuBoard.Sudoku.SmallSide; m++)
					{
						for (var k = 0; k < SudokuBoard.Sudoku.SmallSide; k++)
						{
							if (_availableDigits[rowStart + k][columnStart + m].Contains(sudoku[i, j]))
								_availableDigits[rowStart + k][columnStart + m].Remove(sudoku[i, j]);
						}
					}
				}
			}
		}


		private bool SolveSmartBruteForce(SudokuBoard.Sudoku sudoku)
		{
			FillUpAvailableDigits();
			RemoveDefaults(sudoku);

			 


		}
	}

