using System;
using System.Collections.Generic;

namespace Sudoku.SudokuBoard
{
	public class Sudoku
	{
		private Dictionary<int, Cell> _matrix;

		internal int DifficultyPoints;

		public const int BigSide = 9;
		public const int SmallSide = 3;
		public const int EasyThreshold = 10_000;
		public const int MediumThreshold = 25_000;
		public const int HardThreshold = 200_000;
		public const int SamuraiThreshold = 625_000;

		public Enums.SudokuDifficulty Difficulty
		{
			get
			{
				if (DifficultyPoints < 25000) return Enums.SudokuDifficulty.Easy;
				if (DifficultyPoints < 200000) return Enums.SudokuDifficulty.Medium;
				return DifficultyPoints < 625000 ? Enums.SudokuDifficulty.Hard : Enums.SudokuDifficulty.Samurai;
			}
		}

		private Sudoku(bool noInitialInit)
		{
			_matrix = new Dictionary<int, Cell>();

			if (noInitialInit) return;

			InitWithZeros();
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Sudoku()
		{
			_matrix = new Dictionary<int, Cell>();
			InitWithZeros();
		}

		private void InitWithZeros()
		{
			for (var i = 0; i < BigSide; i++)
			{
				for (var j = 0; j < BigSide; j++)
				{
					_matrix.Add(i * BigSide + j, new Cell(i, j, 0)) ;
				}
			}
		}

		/// <summary>
		/// Iterates over the matrix
		/// </summary>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>
		public int this[int row, int col]
		{
			get => _matrix.TryGetValue(row * BigSide + col, out var value)
				? value.Value
				: throw new Exception($"Out of range [{row},{col}]");
			set
			{
				if (!_matrix.ContainsKey(row * BigSide + col)) throw new Exception($"Out of range [{row}, {col}]");

				_matrix[row * BigSide + col].Value = value;
			}

		}

		/// <summary>
		/// Print sudoku
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			var result = "";
			for (var i = 0; i < BigSide; i++)
			{
				for (var j = 0; j < BigSide; j++)
					result += this[i, j];
				result += '\n';
			}
			return result;
		}

		/// <summary>
		/// Create a copy of sudoku
		/// </summary>
		/// <returns></returns>
		public Sudoku Copy()
		{
			var newSudoku = new Sudoku(true) { DifficultyPoints = DifficultyPoints };

			for (var i = 0; i < _matrix.Count; i++)
			{
				var currentElem = _matrix[i];
				newSudoku._matrix.Add(i, new Cell(currentElem.Row, currentElem.Column, currentElem.Value));
			}

			return newSudoku;
		}

		protected internal void Transpose()
		{
			var transposed = new Dictionary<int, Cell>();

			for (var row = 0; row < BigSide; row++)
			for (var column = 0; column < BigSide; column++)
				transposed.Add(row * BigSide + column, new Cell(row, column, this[column, row]));

			_matrix = transposed;
		}

		protected internal void SwapSmallRows(int bigLine, int smallLineFirst, int smallLineSecond)
		{
			for (var i = 0; i < BigSide; i++)
			{
				var temp = this[bigLine * 3 + smallLineFirst, i];
				this[bigLine * 3 + smallLineFirst, i] = this[bigLine * 3 + smallLineSecond, i];
				this[bigLine * 3 + smallLineSecond, i] = temp;
			}
		}

		protected internal void SwapBigRows(int bigLineFirst, int bigLineSecond)
		{
			for (var i = 0; i < BigSide; i++)
			for (var j = 0; j < SmallSide; j++)
			{
				var temp = this[bigLineFirst * 3 + j, i];
				this[bigLineFirst * 3 + j, i] = this[bigLineSecond * 3 + j, i];
				this[bigLineSecond * 3 + j, i] = temp;
			}
		}

		protected internal void SwapSmallColumns(int bigColumn, int smallColumnFirst, int smallColumnSecond)
		{
			Transpose();
			SwapSmallRows(bigColumn, smallColumnFirst, smallColumnSecond);
			Transpose();
		}

		protected internal void SwapBigColumns(int bigColumnFirst, int bigColumnSecond)
		{
			Transpose();
			SwapBigRows(bigColumnFirst, bigColumnSecond);
			Transpose();
		}
	}
}
