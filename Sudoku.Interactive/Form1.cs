using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sudoku.Solvers;
using Sudoku.Sources;

namespace Sudoku.Interactive
{
	public partial class Form1 : Form
	{
		private readonly Model _model = Model.GetInstance();

		public Form1()
		{
			InitializeComponent();
			
			AddBinding("DifficultyPoints", "Text", DifficultPointsLabel);
			AddBinding("DifficultyPoints", "Value", DifficultyTrackBar);
			AddBinding("SudokuDifficulty", "Text", DifficultyComboBox);
			AddBinding("IsSolveAvailable", "Enabled", SolveButton);
			AddBinding("IsGenerateAvailable", "Enabled", GenerateButton);
			AddBinding("SudokuSymmetry", "Text", SymmetryComboBox);
		}

		private void AddBinding(string modelField, string property, IBindableComponent target)
		{
			var bind = new Binding(property, _model, modelField);
			target.DataBindings.Add(bind);
		}

		private void UpdateLabelsUi()
		{
			for (var i = 0; i < SudokuBoard.Sudoku.BigSide * SudokuBoard.Sudoku.BigSide; i++)
			{
				SudokuGrid.Controls[SudokuBoard.Sudoku.BigSide * SudokuBoard.Sudoku.BigSide - 1 - i].Text = _model.Labels[i];
			}
		}

		private void UpdateList()
		{
			_model.Labels.Clear();

			for (var i = 0; i < SudokuBoard.Sudoku.BigSide; i++)
			{
				for (var j = 0; j < SudokuBoard.Sudoku.BigSide; j++)
				{
					_model.Labels.Add(_model.CurrentSudoku[i, j] > 0 && _model.CurrentSudoku[i, j] < 10 ? _model.CurrentSudoku[i, j].ToString() : "");
				}
			}
		}


		private async void GenerateButton_Click(object sender, EventArgs e)
		{
			_model.IsGenerateAvailable = false;

			await Task.Run(() =>
			{
				_model.CurrentSudoku = SudokuGenerator.Generate(_model.SudokuDifficulty, _model.SudokuSymmetry, _model.DifficultyPoints);

				UpdateList();
			});

			UpdateLabelsUi();
			_model.IsSolveAvailable = true;
			_model.IsGenerateAvailable = true;
		}

		private async void SolveButton_Click(object sender, EventArgs e)
		{
			await Task.Run(() =>
			{
				var solver = new SimpleSolver();

				_model.CurrentSudoku = solver.SolveSudoku(_model.CurrentSudoku);

				UpdateList();
			});

			UpdateLabelsUi();
		}

		private void Difficulty_SelectedIndexChanged(object sender, EventArgs e)
		{
			_model.SudokuDifficulty = (Enums.SudokuDifficulty)DifficultyComboBox.SelectedIndex;
		}

		private void DifficultyTrackBar_Scroll(object sender, EventArgs e)
		{
			_model.DifficultyPoints = DifficultyTrackBar.Value;
		}

		private void SymmetryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_model.SudokuSymmetry = (Enums.SymmetryType)SymmetryComboBox.SelectedIndex;
		}

		private void LoadFromFileButton_Click(object sender, EventArgs e)
		{
			LoadSudokuFromFile.ShowDialog();
		}

		private async void LoadSudokuFromFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			_model.CurrentSudoku = await SudokuReader.ReadFromFileAsync(LoadSudokuFromFile.FileName);

			UpdateList();
			UpdateLabelsUi();

			_model.IsSolveAvailable = true;
		}
	}
}
