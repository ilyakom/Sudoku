using System;
using System.IO;
using System.Threading.Tasks;

namespace Sudoku.Sources
{
	public static class SudokuReader
	{
		public static async Task<SudokuBoard.Sudoku> ReadFromFileAsync(string path)
		{
			if (!File.Exists(path)) return null;

			var fileInfo = new FileInfo(path);

			var sudoku = new SudokuBoard.Sudoku();

			var lineNumber = 0;
			using (var stream = new StreamReader(fileInfo.OpenRead()))
			{
				while (stream.Peek() >= 0)
				{
					var line = await stream.ReadLineAsync();

					if (line.Length != SudokuBoard.Sudoku.BigSide) throw new Exception($"Incorrect sudoku. Line {lineNumber} has length of {line.Length}");

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
	}
}
