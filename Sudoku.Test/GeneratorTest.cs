using System.Collections.Generic;
using NUnit.Framework;
using Sudoku.Sources;

namespace Sudoku.Test
{
	public class GeneratorTest
	{
		[Test]
		[TestCase(Enums.SudokuDifficulty.Easy, SudokuBoard.Sudoku.EasyThreshold)]
		[TestCase(Enums.SudokuDifficulty.Medium, SudokuBoard.Sudoku.MediumThreshold)]
		[TestCase(Enums.SudokuDifficulty.Hard, SudokuBoard.Sudoku.HardThreshold)]
		[TestCase(Enums.SudokuDifficulty.Samurai, SudokuBoard.Sudoku.SamuraiThreshold)]
		public void GenerateSudokuTest(Enums.SudokuDifficulty diff, int threshold)
		{
			var sudoku = SudokuGenerator.GenerateFull();

			sudoku.Transpose();
			Assert.AreEqual(true, CheckSudoku(sudoku));

			sudoku.SwapSmallRows(0, 0, 2);
			Assert.AreEqual(true, CheckSudoku(sudoku));

			sudoku.SwapBigRows(0, 2);
			Assert.AreEqual(true, CheckSudoku(sudoku));

			SudokuGenerator.RunShuffle(sudoku, 10);
			Assert.AreEqual(true, CheckSudoku(sudoku));

			sudoku = SudokuGenerator.Generate(Enums.SudokuDifficulty.Medium);
			Assert.GreaterOrEqual(sudoku.DifficultyPoints, SudokuBoard.Sudoku.MediumThreshold);

		}

		private static bool CheckSudoku(SudokuBoard.Sudoku sudoku)
		{
			var vHash = new HashSet<int>();
			var hHash = new HashSet<int>();

			for (var i = 0; i < 9; i++)
			{
				for (var j = 0; j < 9; j++)
				{
					vHash.Clear();
					hHash.Clear();
					for (var k = 0; k < SudokuBoard.Sudoku.BigSide; k++)
					{
						if (vHash.Contains(sudoku[i, k]))
							return false;
						vHash.Add(sudoku[i, k]);

						if (hHash.Contains(sudoku[k, j]))
							return false;
						hHash.Add(sudoku[k, j]);
					}

					var rowStart = i - i % SudokuBoard.Sudoku.SmallSide;
					var columnStart = j - j % SudokuBoard.Sudoku.SmallSide;

					vHash.Clear();
					for (var m = 0; m < SudokuBoard.Sudoku.SmallSide; m++)
					{
						for (var k = 0; k < SudokuBoard.Sudoku.SmallSide; k++)
						{
							if (vHash.Contains(sudoku[rowStart + k, columnStart + m]))
								return false;
							vHash.Add(sudoku[rowStart + k, columnStart + m]);
						}
					}
				}
			}
			return true;
		}
	}
}
