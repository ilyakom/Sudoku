using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Sudoku.Interactive.Annotations;

namespace Sudoku.Interactive
{
	internal sealed class Model : INotifyPropertyChanged
	{
		private static Model _model;

		internal readonly List<string> Labels;
		internal SudokuBoard.Sudoku CurrentSudoku;

		private Enums.SudokuDifficulty _currentDifficulty;
		private Enums.SymmetryType _currentSymmetry;
		private int _currentDifficultyPoints;
		private bool _isSolveAvailable;
		private bool _isGenerateAvailable;

		public Enums.SymmetryType SudokuSymmetry
		{
			get => _currentSymmetry;
			set
			{
				_currentSymmetry = value;
				OnPropertyChanged(nameof(SudokuSymmetry));
			}
		}

		public Enums.SudokuDifficulty SudokuDifficulty
		{
			get => _currentDifficulty;
			set
			{
				_currentDifficulty = value;

				switch (value)
				{
					case Enums.SudokuDifficulty.Easy:
						DifficultyPoints = SudokuBoard.Sudoku.EasyThreshold;
						break;
					case Enums.SudokuDifficulty.Medium:
						DifficultyPoints = SudokuBoard.Sudoku.MediumThreshold;
						break;
					case Enums.SudokuDifficulty.Hard:
						DifficultyPoints = SudokuBoard.Sudoku.HardThreshold;
						break;
					case Enums.SudokuDifficulty.Samurai:
						DifficultyPoints = SudokuBoard.Sudoku.SamuraiThreshold;
						break;
				}

				OnPropertyChanged(nameof(SudokuDifficulty));
			}
		}

		public int DifficultyPoints
		{
			get => _currentDifficultyPoints;
			set
			{
				_currentDifficultyPoints = value;

				if (value != SudokuBoard.Sudoku.EasyThreshold && value != SudokuBoard.Sudoku.MediumThreshold && value != SudokuBoard.Sudoku.HardThreshold &&
				    value != SudokuBoard.Sudoku.SamuraiThreshold)
					SudokuDifficulty = Enums.SudokuDifficulty.Custom;

				OnPropertyChanged(nameof(DifficultyPoints));
			}
		}

		public bool IsSolveAvailable
		{
			get => _isSolveAvailable;
			set
			{
				_isSolveAvailable = value;
				OnPropertyChanged(nameof(IsSolveAvailable));
			}
		}

		public bool IsGenerateAvailable
		{
			get => _isGenerateAvailable;
			set
			{
				_isGenerateAvailable = value;
				OnPropertyChanged(nameof(IsGenerateAvailable));
			}
		}

		private Model()
		{
			_isSolveAvailable = false;
			_isGenerateAvailable = true;
			Labels = new List<string>();
			_currentDifficulty = Enums.SudokuDifficulty.Easy;
		}

		public static Model GetInstance()
		{
			return _model ?? (_model = new Model());
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
