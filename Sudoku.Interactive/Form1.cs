using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sudoku.Adapter;
using Sudoku.Application;

namespace Sudoku.Interactive
{
	public partial class MainForm : Form
	{
		private readonly Model _model = Model.GetInstance();

		public MainForm()
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
			const int lastElementIdx = Domain.Sudoku.BigSide * Domain.Sudoku.BigSide - 1;

			for (var i = 0; i < Domain.Sudoku.BigSide; i++)
			{
				for (var j = 0; j < Domain.Sudoku.BigSide; j++)
				{
					var current = i * Domain.Sudoku.BigSide + j;

					if (_model.CurrentSudoku[i, j] > 0)
					{
						SudokuGrid.Controls[lastElementIdx - current].Text = _model.CurrentSudoku[i, j].ToString();
						SudokuGrid.Controls[lastElementIdx - current].ForeColor = Color.Black;
					}
					else
					{
						SudokuGrid.Controls[lastElementIdx - current].Text = "";
						SudokuGrid.Controls[lastElementIdx - current].ForeColor = Color.Maroon;
					}
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
			_model.CurrentSudoku = await SudokuAdapter.ReadFromFileAsync(LoadSudokuFromFile.FileName);

			UpdateLabelsUi();

			_model.IsSolveAvailable = true;
		}

		private async void Cell_MouseClick(object sender, MouseEventArgs e)
		{
			if (_model.CurrentSudoku == null) return;

			var row = SudokuGrid.GetRow((Label)sender);
			var column = SudokuGrid.GetColumn((Label)sender);

			var curValue = ((Label)sender).Text == "" ? 0 : int.Parse(((Label)sender).Text);
			var initialValue = curValue;

			for (var i = 0; i < Domain.Sudoku.BigSide; i++)
			{
				_model.CurrentSudoku[row, column] = curValue >= 9 ? 0 : curValue + 1;

				if ( await Task.Run(() => Validations.ValidateSudoku(_model.CurrentSudoku)))
				{
					((Label) sender).Text = _model.CurrentSudoku[row, column] == 0 ? "" : _model.CurrentSudoku[row, column].ToString();
					return;
				}
				
				curValue = curValue >= 9 ? 0 : curValue + 1;
			}

			_model.CurrentSudoku[row, column] = initialValue;
		}

		private async void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			await SudokuAdapter.SaveSudoku(_model.CurrentSudoku);
		}

		private async void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				_model.CurrentSudoku = await SudokuAdapter.LoadSavedSudoku();

				if (_model.CurrentSudoku != null)
				{
					UpdateLabelsUi();
					_model.IsSolveAvailable = true;
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"Unable to load saved Sudoku! {Environment.NewLine} {exception}");
			}
		}
	}
}
