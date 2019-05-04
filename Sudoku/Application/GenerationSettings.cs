namespace Sudoku.Application
{
	/// <summary>
	/// Generator settings
	/// </summary>
	public sealed class GenerationSettings
	{
		public Enums.SudokuDifficulty Difficulty { get; set; }
		public Enums.SymmetryType Symmetry { get; set; }
		public int DifficultyPoints { get; set; }

		public GenerationSettings()
		{
			Difficulty = Enums.SudokuDifficulty.Easy;
			Symmetry = Enums.SymmetryType.None;
			DifficultyPoints = 0;
		}
	}
}
