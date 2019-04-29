using System.Collections.Generic;
using NUnit.Framework;
using Sudoku.Adapter;
using Sudoku.Application;

namespace Sudoku.Test
{
	public class GeneratorTest
	{
		[Test]
		[TestCase(Enums.SudokuDifficulty.Easy, Domain.Sudoku.EasyThreshold)]
		[TestCase(Enums.SudokuDifficulty.Medium, Domain.Sudoku.MediumThreshold)]
		[TestCase(Enums.SudokuDifficulty.Hard, Domain.Sudoku.HardThreshold)]
		[TestCase(Enums.SudokuDifficulty.Samurai, Domain.Sudoku.SamuraiThreshold)]
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
			Assert.GreaterOrEqual(sudoku.DifficultyPoints, Domain.Sudoku.MediumThreshold);

		}

		private static bool CheckSudoku(Domain.Sudoku sudoku)
		{
			var vHash = new HashSet<int>();
			var hHash = new HashSet<int>();

			for (var i = 0; i < 9; i++)
			{
				for (var j = 0; j < 9; j++)
				{
					vHash.Clear();
					hHash.Clear();
					for (var k = 0; k < Domain.Sudoku.BigSide; k++)
					{
						if (vHash.Contains(sudoku[i, k]))
							return false;
						vHash.Add(sudoku[i, k]);

						if (hHash.Contains(sudoku[k, j]))
							return false;
						hHash.Add(sudoku[k, j]);
					}

					var rowStart = i - i % Domain.Sudoku.SmallSide;
					var columnStart = j - j % Domain.Sudoku.SmallSide;

					vHash.Clear();
					for (var m = 0; m < Domain.Sudoku.SmallSide; m++)
					{
						for (var k = 0; k < Domain.Sudoku.SmallSide; k++)
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
