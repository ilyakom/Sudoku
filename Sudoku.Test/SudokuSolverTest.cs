using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sudoku.Adapter;
using Sudoku.Application;

namespace Sudoku.Test
{
	[TestFixture]
	public class SudokuSolverTest
	{
		[Test]
		[TestCase("./Resources/EmailExampleEasy.txt", 1)]
		[TestCase("./Resources/EmailExampleMedium.txt", 1)]
		[TestCase("./Resources/EmailExampleHard.txt", 1)]
		[TestCase("./Resources/EmailExampleSamurai.txt", 1)]
		[TestCase("./Resources/MultipleSolution.txt", 2)]
		[TestCase("./Resources/HardestEver.txt", 1)]
		public async Task SolveTest(string path, int solutionsCount)
		{
			var absPath = Path.Combine(TestContext.CurrentContext.TestDirectory, path);

			var sudoku = await SudokuAdapter.ReadFromFileAsync(absPath);
			var solver = new SimpleSolver();

			var actualSolutionsCount = solver.CountSolutions(sudoku);

			Assert.AreEqual(solutionsCount, actualSolutionsCount);
		}

		[Test]
		[TestCase("./Resources/MultipleSolution.txt", 1, Enums.TopType.Easiest, 1405)]
		[TestCase("./Resources/MultipleSolution.txt", 1, Enums.TopType.Hardest, 1657)]
		public async Task TestTopNSolutions(string path, int solutionsLimit, Enums.TopType type, int expectedDifficulty)
		{
			var absPath = Path.Combine(TestContext.CurrentContext.TestDirectory, path);

			var sudoku = await SudokuAdapter.ReadFromFileAsync(absPath);
			var solver = new SimpleSolver();

			var solutions = solver.GetTopNSolutions(sudoku, solutionsLimit, type);

			Assert.AreEqual(solutionsLimit, solutions.Count);
			Assert.AreEqual(expectedDifficulty, solutions.First().DifficultyPoints);
		}
	}
}
