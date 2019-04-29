using System.ComponentModel;
using System.Runtime.CompilerServices;
using Sudoku.Interactive.Annotations;

namespace Sudoku.Interactive
{
	internal sealed class Model : INotifyPropertyChanged
	{
		private static Model _model;
		internal Domain.Sudoku CurrentSudoku;

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
						DifficultyPoints = Domain.Sudoku.EasyThreshold;
						break;
					case Enums.SudokuDifficulty.Medium:
						DifficultyPoints = Domain.Sudoku.MediumThreshold;
						break;
					case Enums.SudokuDifficulty.Hard:
						DifficultyPoints = Domain.Sudoku.HardThreshold;
						break;
					case Enums.SudokuDifficulty.Samurai:
						DifficultyPoints = Domain.Sudoku.SamuraiThreshold;
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

				if (value != Domain.Sudoku.EasyThreshold && value != Domain.Sudoku.MediumThreshold && value != Domain.Sudoku.HardThreshold &&
				    value != Domain.Sudoku.SamuraiThreshold)
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
