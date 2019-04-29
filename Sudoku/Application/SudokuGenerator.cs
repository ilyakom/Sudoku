using System;
using System.Collections.Generic;
using System.Linq;
using Sudoku.Domain;

namespace Sudoku.Application
{
	public static class SudokuGenerator
	{
		private static readonly Random Random = new Random(Guid.NewGuid().GetHashCode());
		private static readonly SimpleSolver Solver = new SimpleSolver();
		private const int ShufflesCount = 10;

		/// <summary>
		/// Generates new Sudoku with given <see cref="Enums"/> Difficulty or Difficulty Points if Difficulty is Custom
		/// </summary>
		/// <param name="difficulty"> Difficulty Enum </param>
		/// <param name="symmetry"></param>
		/// <param name="customDifficultyPoints"> Difficulty Points in case of Difficulty = Custom </param>
		/// <returns><see cref="Sudoku"/></returns>
		public static Domain.Sudoku Generate(Enums.SudokuDifficulty difficulty,
			Enums.SymmetryType symmetry = Enums.SymmetryType.None, int customDifficultyPoints = 0)
		{
			var notCheckedPairs = new List<Tuple<int, int>>();

			for (var i = 0; i < Domain.Sudoku.BigSide; i++)
			{
				for (var j = 0; j < Domain.Sudoku.BigSide; j++) 
				{
					notCheckedPairs.Add(Tuple.Create(i,j));
				}
			}

			int difficultyPoints;
			switch (difficulty)
			{
				case Enums.SudokuDifficulty.Easy:
					difficultyPoints = Domain.Sudoku.EasyThreshold;
					break;
				case Enums.SudokuDifficulty.Medium:
					difficultyPoints = Domain.Sudoku.MediumThreshold;
					break;
				case Enums.SudokuDifficulty.Hard:
					difficultyPoints = Domain.Sudoku.HardThreshold;
					break;
				case Enums.SudokuDifficulty.Samurai:
					difficultyPoints = Domain.Sudoku.SamuraiThreshold;
					break;
				case Enums.SudokuDifficulty.Custom:
					difficultyPoints = customDifficultyPoints;
					break;
				default:
					throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, null);
			}

			var sudoku = GenerateFull();
			RunShuffle(sudoku, ShufflesCount);
			GenerateFromFull(sudoku, notCheckedPairs, difficultyPoints, symmetry);

			return sudoku;
		}

		private static bool GenerateFromFull(Domain.Sudoku sudoku, IEnumerable<Tuple<int, int>> notCheckedPositionsFromPrev,
			int difficultyPoints, Enums.SymmetryType symmetry)
		{
			var notCheckedPositions = new List<Tuple<int, int>>(notCheckedPositionsFromPrev);
			while (notCheckedPositions.Count > 0)
			{

				var removedCells = RemoveNext(sudoku, notCheckedPositions, symmetry);


				var solutions = Solver.GetTopNSolutions(sudoku, 2, Enums.TopType.Any);

				if (solutions.Count == 1 && solutions.First().DifficultyPoints > difficultyPoints)
				{
					sudoku.DifficultyPoints = solutions.First().DifficultyPoints;
					return true;
				}

				if (solutions.Count > 1)
				{
					RecoverCells(sudoku, removedCells);
					return false;
				}

				if(GenerateFromFull(sudoku, notCheckedPositions, difficultyPoints, symmetry))
				{
					return true;
				}
				else
				{
					RecoverCells(sudoku, removedCells);
				}
			}

			return false;
		}

		private static List<Cell> RemoveNext(Domain.Sudoku sudoku, IList<Tuple<int, int>> notCheckedPositions, Enums.SymmetryType symmetry)
		{
			var randomPosition = Random.Next(0, notCheckedPositions.Count - 1);

			var currentCell = notCheckedPositions[randomPosition];
			notCheckedPositions.RemoveAt(randomPosition);

			var row = currentCell.Item1;
			var column = currentCell.Item2;

			var removedValues = new List<Cell>()
				{new Cell(row, column, sudoku[row, column])};

			sudoku[row, column] = 0;

			if (symmetry == Enums.SymmetryType.Horizontal)
			{
				if (row == 4) return removedValues;

				var symmetricRow = Domain.Sudoku.BigSide - 1 - row;
				removedValues.Add(new Cell(symmetricRow, column , sudoku[symmetricRow, column]));
				notCheckedPositions.Remove(Tuple.Create(symmetricRow, column));

				sudoku[symmetricRow, column] = 0;
			}
			else if(symmetry == Enums.SymmetryType.Vertical)
			{
				if (column == 4) return removedValues;

				var symmetricColumn = Domain.Sudoku.BigSide - 1 - column;
				removedValues.Add(new Cell(row, symmetricColumn, sudoku[row, symmetricColumn]));
				notCheckedPositions.Remove(Tuple.Create(row, symmetricColumn));

				sudoku[row, symmetricColumn] = 0;
			}

			return removedValues;
		}

		private static void RecoverCells(Domain.Sudoku sudoku, IList<Cell> cellsToRecover)
		{
			foreach (var cell in cellsToRecover)
			{
				sudoku[cell.Row, cell.Column] = cell.Value;
			}

			cellsToRecover.Clear();
		}

		internal static Domain.Sudoku GenerateFull()
		{
			var sudoku = new Domain.Sudoku();

			for(var i = 0; i < Domain.Sudoku.BigSide; i++)
				for (var j = 0; j < Domain.Sudoku.BigSide; j++)
				{
					sudoku[i, j] = (i * Domain.Sudoku.SmallSide + i / Domain.Sudoku.SmallSide + j) % Domain.Sudoku.BigSide + 1;
				}

			return sudoku;
		}

		internal static void RunShuffle(Domain.Sudoku sudoku, int shufflesCount)
		{
			for (var i = 0; i < shufflesCount; i++)
			{
				var firstParam = Random.Next(0, 2);
				var secondParam = Random.Next(0, 2);
				var thirdParam = Random.Next(0, 2);

				// to avoid exchange between one row/column
				while (secondParam == thirdParam)
				{
					thirdParam = Random.Next(0, 2);
				}

				var shuffleMethod = Random.Next(0, 4);

				switch (shuffleMethod)
				{
					case 0:
						sudoku.Transpose();
						break;
					case 1:
						sudoku.SwapSmallRows(firstParam, secondParam, thirdParam);
						break;
					case 2:
						sudoku.SwapSmallColumns(firstParam, secondParam, thirdParam);
						break;
					case 3:
						sudoku.SwapBigRows(secondParam, thirdParam);
						break;
					case 4:
						sudoku.SwapBigColumns(secondParam, thirdParam);
						break;
				}
			}
		}
	}
}
