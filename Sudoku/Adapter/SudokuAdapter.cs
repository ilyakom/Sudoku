﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace Sudoku.Adapter
{
	/// <summary>
	/// Adapter
	/// </summary>
	public static class SudokuAdapter
	{
		private const string LocalFile = "./save";

		/// <summary>
		/// Import Sudoku from file
		/// </summary>
		/// <param name="path">Path to .txt file</param>
		/// <returns><see cref="Domain.Sudoku"/></returns>
		public static async Task<Domain.Sudoku> ReadFromFileAsync(string path)
		{
			if (!File.Exists(path)) return null;

			var fileInfo = new FileInfo(path);

			var sudoku = new Domain.Sudoku();

			var lineNumber = 0;
			using (var stream = new StreamReader(fileInfo.OpenRead()))
			{
				while (stream.Peek() >= 0)
				{
					var line = await stream.ReadLineAsync();

					if (line.Length != Domain.Sudoku.BigSide) throw new Exception($"Incorrect sudoku. Line {lineNumber} has length of {line.Length}");

					for (var column = 0; column < line.Length; column++)
					{
						if (int.TryParse(line[column].ToString(), out var num) && num != 0)
						{
							sudoku[lineNumber, column] = num;
						}
						else
							sudoku[lineNumber, column] = 0;
					}

					lineNumber++;
				}
			}

			return sudoku;
		}

		/// <summary>
		/// Save sudoku to local file named <see cref="LocalFile"/>
		/// </summary>
		/// <param name="sudoku"><see cref="Domain.Sudoku"/>></param>
		/// <returns></returns>
		public static async Task SaveSudokuAsync(Domain.Sudoku sudoku)
		{
			if(sudoku == null) throw new NullReferenceException(nameof(sudoku));

			using (var fileStream = new FileStream(LocalFile, FileMode.Create))
			using (var stream = new StreamWriter(fileStream))
			{
				await stream.WriteAsync(sudoku.ToString());
			}
		}

		/// <summary>
		/// Load previously saved sudoku from file <see cref="LocalFile"/>
		/// </summary>
		/// <returns></returns>
		public static async Task<Domain.Sudoku> LoadSavedSudoku()
		{
			return await ReadFromFileAsync(LocalFile);
		}
	}
}
