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

		/// <summary>
		/// Update values on board
		/// </summary>
		private void UpdateLabelsUi()
		{
			const int lastElementIdx = SudokuBoard.Sudoku.BigSide * SudokuBoard.Sudoku.BigSide - 1;

			for (var i = 0; i < SudokuBoard.Sudoku.BigSide; i++)
			{
				for (var j = 0; j < SudokuBoard.Sudoku.BigSide; j++)
				{
					var current = i * SudokuBoard.Sudoku.BigSide + j;

					if (_model.CurrentSudoku[i, j] > 0)
					{
						SudokuGrid.Controls[lastElementIdx - current].Text = _model.CurrentSudoku[i, j].ToString();
						SudokuGrid.Controls[lastElementIdx - current].Enabled = false;
					}
					else
					{
						SudokuGrid.Controls[lastElementIdx - current].Text = "";
						SudokuGrid.Controls[lastElementIdx - current].Enabled = true;
					}
				}
			}
		}

		/// <summary>
		/// Update sudoku in model after click
		/// </summary>
		private void UpdateModel()
		{
			const int lastElementIdx = SudokuBoard.Sudoku.BigSide * SudokuBoard.Sudoku.BigSide - 1;

			for (var i = 0; i < SudokuBoard.Sudoku.BigSide; i++)
			{
				for (var j = 0; j < SudokuBoard.Sudoku.BigSide; j++)
				{
					var currentIdx = i * SudokuBoard.Sudoku.BigSide + j;
					var currentValue = SudokuGrid.Controls[lastElementIdx - currentIdx].Text == ""
						? 0
						: int.Parse(SudokuGrid.Controls[lastElementIdx - currentIdx].Text);

					_model.CurrentSudoku[i, j] = currentValue;
				}
			}
		}

		private async void GenerateButton_Click(object sender, EventArgs e)
		{
			_model.IsGenerateAvailable = false;

			await Task.Run(() =>
			{
				_model.CurrentSudoku = SudokuGenerator.Generate(_model.SudokuDifficulty, _model.SudokuSymmetry, _model.DifficultyPoints);
			});

			UpdateLabelsUi();
			_model.IsSolveAvailable = true;
			_model.IsGenerateAvailable = true;
		}

		private async void SolveButton_Click(object sender, EventArgs e)
		{
			var solvedSudoku = await Task.Run(() =>
			{
				var solver = new SimpleSolver();
				return solver.SolveSudoku(_model.CurrentSudoku);
			});


			if (solvedSudoku == null)
			{
				MessageBox.Show(@"This Sudoku does not have any solution");
			}
			else
			{
				_model.CurrentSudoku = solvedSudoku;
				UpdateLabelsUi();
			}
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

			UpdateLabelsUi();

			_model.IsSolveAvailable = true;
		}

		private void Cell_MouseClick(object sender, MouseEventArgs e)
		{
			if(_model.CurrentSudoku == null) return;

			var curValue = ((Label)sender).Text == "" ? 0 : int.Parse(((Label)sender).Text);

			((Label)sender).Text = curValue >= 9 ? "" : (curValue + 1).ToString();

			UpdateModel();
		}
	}
}
