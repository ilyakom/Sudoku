using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace Sudoku.Interactive
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SudokuGrid = new System.Windows.Forms.TableLayoutPanel();
			this.label81 = new System.Windows.Forms.Label();
			this.label80 = new System.Windows.Forms.Label();
			this.label79 = new System.Windows.Forms.Label();
			this.label78 = new System.Windows.Forms.Label();
			this.label77 = new System.Windows.Forms.Label();
			this.label76 = new System.Windows.Forms.Label();
			this.label75 = new System.Windows.Forms.Label();
			this.label74 = new System.Windows.Forms.Label();
			this.label73 = new System.Windows.Forms.Label();
			this.label72 = new System.Windows.Forms.Label();
			this.label71 = new System.Windows.Forms.Label();
			this.label70 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.label68 = new System.Windows.Forms.Label();
			this.label67 = new System.Windows.Forms.Label();
			this.label66 = new System.Windows.Forms.Label();
			this.label65 = new System.Windows.Forms.Label();
			this.label64 = new System.Windows.Forms.Label();
			this.label63 = new System.Windows.Forms.Label();
			this.label62 = new System.Windows.Forms.Label();
			this.label61 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.label59 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.label57 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.label55 = new System.Windows.Forms.Label();
			this.label54 = new System.Windows.Forms.Label();
			this.label53 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.label51 = new System.Windows.Forms.Label();
			this.label50 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.label45 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.GenerateButton = new System.Windows.Forms.Button();
			this.SolveButton = new System.Windows.Forms.Button();
			this.DifficultyComboBox = new System.Windows.Forms.ComboBox();
			this.DifficultyTrackBar = new System.Windows.Forms.TrackBar();
			this.DifficultPointsLabel = new System.Windows.Forms.Label();
			this.label82 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SymmetryComboBox = new System.Windows.Forms.ComboBox();
			this.LoadSudokuFromFile = new System.Windows.Forms.OpenFileDialog();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.LoadFromFileButton = new System.Windows.Forms.Button();
			this.SudokuGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DifficultyTrackBar)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// SudokuGrid
			// 
			this.SudokuGrid.BackColor = System.Drawing.Color.Transparent;
			this.SudokuGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.SudokuGrid.ColumnCount = 9;
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11102F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11112F));
			this.SudokuGrid.Controls.Add(this.label81, 8, 8);
			this.SudokuGrid.Controls.Add(this.label80, 7, 8);
			this.SudokuGrid.Controls.Add(this.label79, 6, 8);
			this.SudokuGrid.Controls.Add(this.label78, 5, 8);
			this.SudokuGrid.Controls.Add(this.label77, 4, 8);
			this.SudokuGrid.Controls.Add(this.label76, 3, 8);
			this.SudokuGrid.Controls.Add(this.label75, 2, 8);
			this.SudokuGrid.Controls.Add(this.label74, 1, 8);
			this.SudokuGrid.Controls.Add(this.label73, 0, 8);
			this.SudokuGrid.Controls.Add(this.label72, 8, 7);
			this.SudokuGrid.Controls.Add(this.label71, 7, 7);
			this.SudokuGrid.Controls.Add(this.label70, 6, 7);
			this.SudokuGrid.Controls.Add(this.label69, 5, 7);
			this.SudokuGrid.Controls.Add(this.label68, 4, 7);
			this.SudokuGrid.Controls.Add(this.label67, 3, 7);
			this.SudokuGrid.Controls.Add(this.label66, 2, 7);
			this.SudokuGrid.Controls.Add(this.label65, 1, 7);
			this.SudokuGrid.Controls.Add(this.label64, 0, 7);
			this.SudokuGrid.Controls.Add(this.label63, 8, 6);
			this.SudokuGrid.Controls.Add(this.label62, 7, 6);
			this.SudokuGrid.Controls.Add(this.label61, 6, 6);
			this.SudokuGrid.Controls.Add(this.label60, 5, 6);
			this.SudokuGrid.Controls.Add(this.label59, 4, 6);
			this.SudokuGrid.Controls.Add(this.label58, 3, 6);
			this.SudokuGrid.Controls.Add(this.label57, 2, 6);
			this.SudokuGrid.Controls.Add(this.label56, 1, 6);
			this.SudokuGrid.Controls.Add(this.label55, 0, 6);
			this.SudokuGrid.Controls.Add(this.label54, 8, 5);
			this.SudokuGrid.Controls.Add(this.label53, 7, 5);
			this.SudokuGrid.Controls.Add(this.label52, 6, 5);
			this.SudokuGrid.Controls.Add(this.label51, 5, 5);
			this.SudokuGrid.Controls.Add(this.label50, 4, 5);
			this.SudokuGrid.Controls.Add(this.label49, 3, 5);
			this.SudokuGrid.Controls.Add(this.label48, 2, 5);
			this.SudokuGrid.Controls.Add(this.label47, 1, 5);
			this.SudokuGrid.Controls.Add(this.label46, 0, 5);
			this.SudokuGrid.Controls.Add(this.label45, 8, 4);
			this.SudokuGrid.Controls.Add(this.label44, 7, 4);
			this.SudokuGrid.Controls.Add(this.label43, 6, 4);
			this.SudokuGrid.Controls.Add(this.label42, 5, 4);
			this.SudokuGrid.Controls.Add(this.label41, 4, 4);
			this.SudokuGrid.Controls.Add(this.label40, 3, 4);
			this.SudokuGrid.Controls.Add(this.label39, 2, 4);
			this.SudokuGrid.Controls.Add(this.label38, 1, 4);
			this.SudokuGrid.Controls.Add(this.label37, 0, 4);
			this.SudokuGrid.Controls.Add(this.label36, 8, 3);
			this.SudokuGrid.Controls.Add(this.label35, 7, 3);
			this.SudokuGrid.Controls.Add(this.label34, 6, 3);
			this.SudokuGrid.Controls.Add(this.label33, 5, 3);
			this.SudokuGrid.Controls.Add(this.label32, 4, 3);
			this.SudokuGrid.Controls.Add(this.label31, 3, 3);
			this.SudokuGrid.Controls.Add(this.label30, 2, 3);
			this.SudokuGrid.Controls.Add(this.label29, 1, 3);
			this.SudokuGrid.Controls.Add(this.label28, 0, 3);
			this.SudokuGrid.Controls.Add(this.label27, 8, 2);
			this.SudokuGrid.Controls.Add(this.label26, 7, 2);
			this.SudokuGrid.Controls.Add(this.label25, 6, 2);
			this.SudokuGrid.Controls.Add(this.label24, 5, 2);
			this.SudokuGrid.Controls.Add(this.label23, 4, 2);
			this.SudokuGrid.Controls.Add(this.label22, 3, 2);
			this.SudokuGrid.Controls.Add(this.label21, 2, 2);
			this.SudokuGrid.Controls.Add(this.label20, 1, 2);
			this.SudokuGrid.Controls.Add(this.label19, 0, 2);
			this.SudokuGrid.Controls.Add(this.label18, 8, 1);
			this.SudokuGrid.Controls.Add(this.label17, 7, 1);
			this.SudokuGrid.Controls.Add(this.label16, 6, 1);
			this.SudokuGrid.Controls.Add(this.label15, 5, 1);
			this.SudokuGrid.Controls.Add(this.label14, 4, 1);
			this.SudokuGrid.Controls.Add(this.label13, 3, 1);
			this.SudokuGrid.Controls.Add(this.label12, 2, 1);
			this.SudokuGrid.Controls.Add(this.label11, 1, 1);
			this.SudokuGrid.Controls.Add(this.label10, 0, 1);
			this.SudokuGrid.Controls.Add(this.label9, 8, 0);
			this.SudokuGrid.Controls.Add(this.label8, 7, 0);
			this.SudokuGrid.Controls.Add(this.label7, 6, 0);
			this.SudokuGrid.Controls.Add(this.label6, 5, 0);
			this.SudokuGrid.Controls.Add(this.label5, 4, 0);
			this.SudokuGrid.Controls.Add(this.label4, 3, 0);
			this.SudokuGrid.Controls.Add(this.label3, 2, 0);
			this.SudokuGrid.Controls.Add(this.label2, 1, 0);
			this.SudokuGrid.Controls.Add(this.label1, 0, 0);
			this.SudokuGrid.ForeColor = System.Drawing.Color.Maroon;
			this.SudokuGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.SudokuGrid.Location = new System.Drawing.Point(12, 12);
			this.SudokuGrid.Name = "SudokuGrid";
			this.SudokuGrid.RowCount = 9;
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
			this.SudokuGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.SudokuGrid.Size = new System.Drawing.Size(676, 538);
			this.SudokuGrid.TabIndex = 0;
			// 
			// label81
			// 
			this.label81.AutoSize = true;
			this.label81.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label81.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label81.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label81.Location = new System.Drawing.Point(600, 473);
			this.label81.Margin = new System.Windows.Forms.Padding(0);
			this.label81.Name = "label81";
			this.label81.Size = new System.Drawing.Size(75, 64);
			this.label81.TabIndex = 81;
			this.label81.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label81.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label80
			// 
			this.label80.AutoSize = true;
			this.label80.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label80.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label80.Location = new System.Drawing.Point(525, 473);
			this.label80.Margin = new System.Windows.Forms.Padding(0);
			this.label80.Name = "label80";
			this.label80.Size = new System.Drawing.Size(74, 64);
			this.label80.TabIndex = 80;
			this.label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label80.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label79
			// 
			this.label79.AutoSize = true;
			this.label79.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label79.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label79.Location = new System.Drawing.Point(450, 473);
			this.label79.Margin = new System.Windows.Forms.Padding(0);
			this.label79.Name = "label79";
			this.label79.Size = new System.Drawing.Size(74, 64);
			this.label79.TabIndex = 79;
			this.label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label79.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label78
			// 
			this.label78.AutoSize = true;
			this.label78.BackColor = System.Drawing.SystemColors.Control;
			this.label78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label78.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label78.Location = new System.Drawing.Point(375, 473);
			this.label78.Margin = new System.Windows.Forms.Padding(0);
			this.label78.Name = "label78";
			this.label78.Size = new System.Drawing.Size(74, 64);
			this.label78.TabIndex = 78;
			this.label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label78.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label77
			// 
			this.label77.AutoSize = true;
			this.label77.BackColor = System.Drawing.SystemColors.Control;
			this.label77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label77.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label77.Location = new System.Drawing.Point(300, 473);
			this.label77.Margin = new System.Windows.Forms.Padding(0);
			this.label77.Name = "label77";
			this.label77.Size = new System.Drawing.Size(74, 64);
			this.label77.TabIndex = 77;
			this.label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label77.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label76
			// 
			this.label76.AutoSize = true;
			this.label76.BackColor = System.Drawing.SystemColors.Control;
			this.label76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label76.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label76.Location = new System.Drawing.Point(225, 473);
			this.label76.Margin = new System.Windows.Forms.Padding(0);
			this.label76.Name = "label76";
			this.label76.Size = new System.Drawing.Size(74, 64);
			this.label76.TabIndex = 76;
			this.label76.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label76.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label75
			// 
			this.label75.AutoSize = true;
			this.label75.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label75.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label75.Location = new System.Drawing.Point(151, 473);
			this.label75.Margin = new System.Windows.Forms.Padding(0);
			this.label75.Name = "label75";
			this.label75.Size = new System.Drawing.Size(73, 64);
			this.label75.TabIndex = 75;
			this.label75.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label75.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label74
			// 
			this.label74.AutoSize = true;
			this.label74.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label74.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label74.Location = new System.Drawing.Point(76, 473);
			this.label74.Margin = new System.Windows.Forms.Padding(0);
			this.label74.Name = "label74";
			this.label74.Size = new System.Drawing.Size(74, 64);
			this.label74.TabIndex = 74;
			this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label74.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label73
			// 
			this.label73.AutoSize = true;
			this.label73.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label73.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label73.Location = new System.Drawing.Point(1, 473);
			this.label73.Margin = new System.Windows.Forms.Padding(0);
			this.label73.Name = "label73";
			this.label73.Size = new System.Drawing.Size(74, 64);
			this.label73.TabIndex = 73;
			this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label73.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label72
			// 
			this.label72.AutoSize = true;
			this.label72.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label72.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label72.Location = new System.Drawing.Point(600, 414);
			this.label72.Margin = new System.Windows.Forms.Padding(0);
			this.label72.Name = "label72";
			this.label72.Size = new System.Drawing.Size(75, 58);
			this.label72.TabIndex = 72;
			this.label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label72.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label71
			// 
			this.label71.AutoSize = true;
			this.label71.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label71.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label71.Location = new System.Drawing.Point(525, 414);
			this.label71.Margin = new System.Windows.Forms.Padding(0);
			this.label71.Name = "label71";
			this.label71.Size = new System.Drawing.Size(74, 58);
			this.label71.TabIndex = 71;
			this.label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label71.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label70
			// 
			this.label70.AutoSize = true;
			this.label70.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label70.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label70.Location = new System.Drawing.Point(450, 414);
			this.label70.Margin = new System.Windows.Forms.Padding(0);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(74, 58);
			this.label70.TabIndex = 70;
			this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label70.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label69
			// 
			this.label69.AutoSize = true;
			this.label69.BackColor = System.Drawing.SystemColors.Control;
			this.label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label69.Location = new System.Drawing.Point(375, 414);
			this.label69.Margin = new System.Windows.Forms.Padding(0);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(74, 58);
			this.label69.TabIndex = 69;
			this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label69.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.BackColor = System.Drawing.SystemColors.Control;
			this.label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label68.Location = new System.Drawing.Point(300, 414);
			this.label68.Margin = new System.Windows.Forms.Padding(0);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(74, 58);
			this.label68.TabIndex = 68;
			this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label68.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label67
			// 
			this.label67.AutoSize = true;
			this.label67.BackColor = System.Drawing.SystemColors.Control;
			this.label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label67.Location = new System.Drawing.Point(225, 414);
			this.label67.Margin = new System.Windows.Forms.Padding(0);
			this.label67.Name = "label67";
			this.label67.Size = new System.Drawing.Size(74, 58);
			this.label67.TabIndex = 67;
			this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label67.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label66
			// 
			this.label66.AutoSize = true;
			this.label66.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label66.Location = new System.Drawing.Point(151, 414);
			this.label66.Margin = new System.Windows.Forms.Padding(0);
			this.label66.Name = "label66";
			this.label66.Size = new System.Drawing.Size(73, 58);
			this.label66.TabIndex = 66;
			this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label66.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label65
			// 
			this.label65.AutoSize = true;
			this.label65.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label65.Location = new System.Drawing.Point(76, 414);
			this.label65.Margin = new System.Windows.Forms.Padding(0);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(74, 58);
			this.label65.TabIndex = 65;
			this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label65.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label64
			// 
			this.label64.AutoSize = true;
			this.label64.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label64.Location = new System.Drawing.Point(1, 414);
			this.label64.Margin = new System.Windows.Forms.Padding(0);
			this.label64.Name = "label64";
			this.label64.Size = new System.Drawing.Size(74, 58);
			this.label64.TabIndex = 64;
			this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label64.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label63
			// 
			this.label63.AutoSize = true;
			this.label63.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label63.Location = new System.Drawing.Point(600, 355);
			this.label63.Margin = new System.Windows.Forms.Padding(0);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(75, 58);
			this.label63.TabIndex = 63;
			this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label63.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label62
			// 
			this.label62.AutoSize = true;
			this.label62.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label62.Location = new System.Drawing.Point(525, 355);
			this.label62.Margin = new System.Windows.Forms.Padding(0);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(74, 58);
			this.label62.TabIndex = 62;
			this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label62.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label61
			// 
			this.label61.AutoSize = true;
			this.label61.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label61.Location = new System.Drawing.Point(450, 355);
			this.label61.Margin = new System.Windows.Forms.Padding(0);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(74, 58);
			this.label61.TabIndex = 61;
			this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label61.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label60
			// 
			this.label60.AutoSize = true;
			this.label60.BackColor = System.Drawing.SystemColors.Control;
			this.label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label60.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label60.Location = new System.Drawing.Point(375, 355);
			this.label60.Margin = new System.Windows.Forms.Padding(0);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(74, 58);
			this.label60.TabIndex = 60;
			this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label60.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label59
			// 
			this.label59.AutoSize = true;
			this.label59.BackColor = System.Drawing.SystemColors.Control;
			this.label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label59.Location = new System.Drawing.Point(300, 355);
			this.label59.Margin = new System.Windows.Forms.Padding(0);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(74, 58);
			this.label59.TabIndex = 59;
			this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label59.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label58
			// 
			this.label58.AutoSize = true;
			this.label58.BackColor = System.Drawing.SystemColors.Control;
			this.label58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label58.Location = new System.Drawing.Point(225, 355);
			this.label58.Margin = new System.Windows.Forms.Padding(0);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(74, 58);
			this.label58.TabIndex = 58;
			this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label58.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label57.Location = new System.Drawing.Point(151, 355);
			this.label57.Margin = new System.Windows.Forms.Padding(0);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(73, 58);
			this.label57.TabIndex = 57;
			this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label57.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label56
			// 
			this.label56.AutoSize = true;
			this.label56.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label56.Location = new System.Drawing.Point(76, 355);
			this.label56.Margin = new System.Windows.Forms.Padding(0);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(74, 58);
			this.label56.TabIndex = 56;
			this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label56.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label55.Location = new System.Drawing.Point(1, 355);
			this.label55.Margin = new System.Windows.Forms.Padding(0);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(74, 58);
			this.label55.TabIndex = 55;
			this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label55.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label54
			// 
			this.label54.AutoSize = true;
			this.label54.BackColor = System.Drawing.SystemColors.Control;
			this.label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label54.Location = new System.Drawing.Point(600, 296);
			this.label54.Margin = new System.Windows.Forms.Padding(0);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(75, 58);
			this.label54.TabIndex = 54;
			this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label54.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label53
			// 
			this.label53.AutoSize = true;
			this.label53.BackColor = System.Drawing.SystemColors.Control;
			this.label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label53.Location = new System.Drawing.Point(525, 296);
			this.label53.Margin = new System.Windows.Forms.Padding(0);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(74, 58);
			this.label53.TabIndex = 53;
			this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label53.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label52
			// 
			this.label52.AutoSize = true;
			this.label52.BackColor = System.Drawing.SystemColors.Control;
			this.label52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label52.Location = new System.Drawing.Point(450, 296);
			this.label52.Margin = new System.Windows.Forms.Padding(0);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(74, 58);
			this.label52.TabIndex = 52;
			this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label52.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label51
			// 
			this.label51.AutoSize = true;
			this.label51.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label51.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label51.Location = new System.Drawing.Point(375, 296);
			this.label51.Margin = new System.Windows.Forms.Padding(0);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(74, 58);
			this.label51.TabIndex = 51;
			this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label51.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label50
			// 
			this.label50.AutoSize = true;
			this.label50.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label50.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label50.Location = new System.Drawing.Point(300, 296);
			this.label50.Margin = new System.Windows.Forms.Padding(0);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(74, 58);
			this.label50.TabIndex = 50;
			this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label50.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label49
			// 
			this.label49.AutoSize = true;
			this.label49.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label49.Location = new System.Drawing.Point(225, 296);
			this.label49.Margin = new System.Windows.Forms.Padding(0);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(74, 58);
			this.label49.TabIndex = 49;
			this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label49.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.BackColor = System.Drawing.SystemColors.Control;
			this.label48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label48.Location = new System.Drawing.Point(151, 296);
			this.label48.Margin = new System.Windows.Forms.Padding(0);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(73, 58);
			this.label48.TabIndex = 48;
			this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label48.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.BackColor = System.Drawing.SystemColors.Control;
			this.label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label47.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label47.Location = new System.Drawing.Point(76, 296);
			this.label47.Margin = new System.Windows.Forms.Padding(0);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(74, 58);
			this.label47.TabIndex = 47;
			this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label47.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.BackColor = System.Drawing.SystemColors.Control;
			this.label46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label46.Location = new System.Drawing.Point(1, 296);
			this.label46.Margin = new System.Windows.Forms.Padding(0);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(74, 58);
			this.label46.TabIndex = 46;
			this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label46.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.BackColor = System.Drawing.SystemColors.Control;
			this.label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label45.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label45.Location = new System.Drawing.Point(600, 237);
			this.label45.Margin = new System.Windows.Forms.Padding(0);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(75, 58);
			this.label45.TabIndex = 45;
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label45.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.BackColor = System.Drawing.SystemColors.Control;
			this.label44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label44.Location = new System.Drawing.Point(525, 237);
			this.label44.Margin = new System.Windows.Forms.Padding(0);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(74, 58);
			this.label44.TabIndex = 44;
			this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label44.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.BackColor = System.Drawing.SystemColors.Control;
			this.label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label43.Location = new System.Drawing.Point(450, 237);
			this.label43.Margin = new System.Windows.Forms.Padding(0);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(74, 58);
			this.label43.TabIndex = 43;
			this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label43.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label42.Location = new System.Drawing.Point(375, 237);
			this.label42.Margin = new System.Windows.Forms.Padding(0);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(74, 58);
			this.label42.TabIndex = 42;
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label42.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label41.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(300, 237);
			this.label41.Margin = new System.Windows.Forms.Padding(0);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(74, 58);
			this.label41.TabIndex = 41;
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label41.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(225, 237);
			this.label40.Margin = new System.Windows.Forms.Padding(0);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(74, 58);
			this.label40.TabIndex = 40;
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label40.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.BackColor = System.Drawing.SystemColors.Control;
			this.label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(151, 237);
			this.label39.Margin = new System.Windows.Forms.Padding(0);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(73, 58);
			this.label39.TabIndex = 39;
			this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label39.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.BackColor = System.Drawing.SystemColors.Control;
			this.label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label38.Location = new System.Drawing.Point(76, 237);
			this.label38.Margin = new System.Windows.Forms.Padding(0);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(74, 58);
			this.label38.TabIndex = 38;
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label38.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.BackColor = System.Drawing.SystemColors.Control;
			this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(1, 237);
			this.label37.Margin = new System.Windows.Forms.Padding(0);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(74, 58);
			this.label37.TabIndex = 37;
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label37.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.BackColor = System.Drawing.SystemColors.Control;
			this.label36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(600, 178);
			this.label36.Margin = new System.Windows.Forms.Padding(0);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(75, 58);
			this.label36.TabIndex = 36;
			this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label36.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.SystemColors.Control;
			this.label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Location = new System.Drawing.Point(525, 178);
			this.label35.Margin = new System.Windows.Forms.Padding(0);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(74, 58);
			this.label35.TabIndex = 35;
			this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label35.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.BackColor = System.Drawing.SystemColors.Control;
			this.label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(450, 178);
			this.label34.Margin = new System.Windows.Forms.Padding(0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(74, 58);
			this.label34.TabIndex = 34;
			this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label34.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(375, 178);
			this.label33.Margin = new System.Windows.Forms.Padding(0);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(74, 58);
			this.label33.TabIndex = 33;
			this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label33.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(300, 178);
			this.label32.Margin = new System.Windows.Forms.Padding(0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(74, 58);
			this.label32.TabIndex = 32;
			this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label32.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(225, 178);
			this.label31.Margin = new System.Windows.Forms.Padding(0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(74, 58);
			this.label31.TabIndex = 31;
			this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label31.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.BackColor = System.Drawing.SystemColors.Control;
			this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(151, 178);
			this.label30.Margin = new System.Windows.Forms.Padding(0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(73, 58);
			this.label30.TabIndex = 30;
			this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label30.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.BackColor = System.Drawing.SystemColors.Control;
			this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(76, 178);
			this.label29.Margin = new System.Windows.Forms.Padding(0);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(74, 58);
			this.label29.TabIndex = 29;
			this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label29.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.BackColor = System.Drawing.SystemColors.Control;
			this.label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(1, 178);
			this.label28.Margin = new System.Windows.Forms.Padding(0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(74, 58);
			this.label28.TabIndex = 28;
			this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label28.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(600, 119);
			this.label27.Margin = new System.Windows.Forms.Padding(0);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(75, 58);
			this.label27.TabIndex = 27;
			this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label27.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(525, 119);
			this.label26.Margin = new System.Windows.Forms.Padding(0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(74, 58);
			this.label26.TabIndex = 26;
			this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label26.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(450, 119);
			this.label25.Margin = new System.Windows.Forms.Padding(0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(74, 58);
			this.label25.TabIndex = 25;
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label25.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.BackColor = System.Drawing.SystemColors.Control;
			this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(375, 119);
			this.label24.Margin = new System.Windows.Forms.Padding(0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(74, 58);
			this.label24.TabIndex = 24;
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label24.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.BackColor = System.Drawing.SystemColors.Control;
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label23.Location = new System.Drawing.Point(300, 119);
			this.label23.Margin = new System.Windows.Forms.Padding(0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(74, 58);
			this.label23.TabIndex = 23;
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label23.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.SystemColors.Control;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(225, 119);
			this.label22.Margin = new System.Windows.Forms.Padding(0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(74, 58);
			this.label22.TabIndex = 22;
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label22.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(151, 119);
			this.label21.Margin = new System.Windows.Forms.Padding(0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(73, 58);
			this.label21.TabIndex = 21;
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label21.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(76, 119);
			this.label20.Margin = new System.Windows.Forms.Padding(0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(74, 58);
			this.label20.TabIndex = 20;
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(1, 119);
			this.label19.Margin = new System.Windows.Forms.Padding(0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(74, 58);
			this.label19.TabIndex = 19;
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label19.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(600, 60);
			this.label18.Margin = new System.Windows.Forms.Padding(0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(75, 58);
			this.label18.TabIndex = 18;
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label18.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(525, 60);
			this.label17.Margin = new System.Windows.Forms.Padding(0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(74, 58);
			this.label17.TabIndex = 17;
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label17.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(450, 60);
			this.label16.Margin = new System.Windows.Forms.Padding(0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 58);
			this.label16.TabIndex = 16;
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.SystemColors.Control;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(375, 60);
			this.label15.Margin = new System.Windows.Forms.Padding(0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(74, 58);
			this.label15.TabIndex = 15;
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.SystemColors.Control;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(300, 60);
			this.label14.Margin = new System.Windows.Forms.Padding(0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 58);
			this.label14.TabIndex = 14;
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.SystemColors.Control;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(225, 60);
			this.label13.Margin = new System.Windows.Forms.Padding(0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(74, 58);
			this.label13.TabIndex = 13;
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(151, 60);
			this.label12.Margin = new System.Windows.Forms.Padding(0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(73, 58);
			this.label12.TabIndex = 12;
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(76, 60);
			this.label11.Margin = new System.Windows.Forms.Padding(0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(74, 58);
			this.label11.TabIndex = 11;
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(1, 60);
			this.label10.Margin = new System.Windows.Forms.Padding(0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(74, 58);
			this.label10.TabIndex = 10;
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Maroon;
			this.label9.Location = new System.Drawing.Point(600, 1);
			this.label9.Margin = new System.Windows.Forms.Padding(0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 58);
			this.label9.TabIndex = 9;
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(525, 1);
			this.label8.Margin = new System.Windows.Forms.Padding(0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(74, 58);
			this.label8.TabIndex = 8;
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(450, 1);
			this.label7.Margin = new System.Windows.Forms.Padding(0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 58);
			this.label7.TabIndex = 7;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(375, 1);
			this.label6.Margin = new System.Windows.Forms.Padding(0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 58);
			this.label6.TabIndex = 6;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.Control;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(300, 1);
			this.label5.Margin = new System.Windows.Forms.Padding(0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 58);
			this.label5.TabIndex = 5;
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(225, 1);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 58);
			this.label4.TabIndex = 4;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(151, 1);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 58);
			this.label3.TabIndex = 3;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(76, 1);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 58);
			this.label2.TabIndex = 2;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1, 1);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 58);
			this.label1.TabIndex = 1;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Cell_MouseClick);
			// 
			// GenerateButton
			// 
			this.GenerateButton.Location = new System.Drawing.Point(714, 23);
			this.GenerateButton.Name = "GenerateButton";
			this.GenerateButton.Size = new System.Drawing.Size(147, 47);
			this.GenerateButton.TabIndex = 1;
			this.GenerateButton.Text = "Generate";
			this.GenerateButton.UseVisualStyleBackColor = true;
			this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
			// 
			// SolveButton
			// 
			this.SolveButton.Location = new System.Drawing.Point(714, 499);
			this.SolveButton.Name = "SolveButton";
			this.SolveButton.Size = new System.Drawing.Size(147, 47);
			this.SolveButton.TabIndex = 2;
			this.SolveButton.Text = "Solve";
			this.SolveButton.UseVisualStyleBackColor = true;
			this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
			// 
			// DifficultyComboBox
			// 
			this.DifficultyComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.DifficultyComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.DifficultyComboBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Samurai",
            "Custom"});
			this.DifficultyComboBox.Location = new System.Drawing.Point(6, 21);
			this.DifficultyComboBox.Name = "DifficultyComboBox";
			this.DifficultyComboBox.Size = new System.Drawing.Size(158, 24);
			this.DifficultyComboBox.TabIndex = 3;
			this.DifficultyComboBox.SelectedIndexChanged += new System.EventHandler(this.Difficulty_SelectedIndexChanged);
			// 
			// DifficultyTrackBar
			// 
			this.DifficultyTrackBar.Location = new System.Drawing.Point(6, 117);
			this.DifficultyTrackBar.Maximum = 1000000;
			this.DifficultyTrackBar.Name = "DifficultyTrackBar";
			this.DifficultyTrackBar.Size = new System.Drawing.Size(147, 56);
			this.DifficultyTrackBar.TabIndex = 4;
			this.DifficultyTrackBar.TickFrequency = 100;
			this.DifficultyTrackBar.Value = 10000;
			this.DifficultyTrackBar.Scroll += new System.EventHandler(this.DifficultyTrackBar_Scroll);
			// 
			// DifficultPointsLabel
			// 
			this.DifficultPointsLabel.AutoSize = true;
			this.DifficultPointsLabel.Location = new System.Drawing.Point(63, 70);
			this.DifficultPointsLabel.Name = "DifficultPointsLabel";
			this.DifficultPointsLabel.Size = new System.Drawing.Size(64, 17);
			this.DifficultPointsLabel.TabIndex = 5;
			this.DifficultPointsLabel.Text = "1000000";
			// 
			// label82
			// 
			this.label82.AutoSize = true;
			this.label82.Location = new System.Drawing.Point(6, 70);
			this.label82.Name = "label82";
			this.label82.Size = new System.Drawing.Size(51, 17);
			this.label82.TabIndex = 6;
			this.label82.Text = "Points:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DifficultyComboBox);
			this.groupBox1.Controls.Add(this.DifficultyTrackBar);
			this.groupBox1.Controls.Add(this.label82);
			this.groupBox1.Controls.Add(this.DifficultPointsLabel);
			this.groupBox1.Location = new System.Drawing.Point(705, 165);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(170, 179);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Difficulty";
			// 
			// SymmetryComboBox
			// 
			this.SymmetryComboBox.FormattingEnabled = true;
			this.SymmetryComboBox.Items.AddRange(new object[] {
            "None",
            "Vertical",
            "Horizontal"});
			this.SymmetryComboBox.Location = new System.Drawing.Point(6, 21);
			this.SymmetryComboBox.Name = "SymmetryComboBox";
			this.SymmetryComboBox.Size = new System.Drawing.Size(158, 24);
			this.SymmetryComboBox.TabIndex = 8;
			this.SymmetryComboBox.SelectedIndexChanged += new System.EventHandler(this.SymmetryComboBox_SelectedIndexChanged);
			// 
			// LoadSudokuFromFile
			// 
			this.LoadSudokuFromFile.FileName = "openFileDialog1";
			this.LoadSudokuFromFile.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadSudokuFromFile_FileOk);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.SymmetryComboBox);
			this.groupBox2.Location = new System.Drawing.Point(705, 350);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(170, 60);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Simmetry";
			// 
			// LoadFromFileButton
			// 
			this.LoadFromFileButton.Location = new System.Drawing.Point(714, 76);
			this.LoadFromFileButton.Name = "LoadFromFileButton";
			this.LoadFromFileButton.Size = new System.Drawing.Size(147, 47);
			this.LoadFromFileButton.TabIndex = 10;
			this.LoadFromFileButton.Text = "Load From File";
			this.LoadFromFileButton.UseVisualStyleBackColor = true;
			this.LoadFromFileButton.Click += new System.EventHandler(this.LoadFromFileButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 562);
			this.Controls.Add(this.LoadFromFileButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.SolveButton);
			this.Controls.Add(this.GenerateButton);
			this.Controls.Add(this.SudokuGrid);
			this.Name = "MainForm";
			this.Text = "Sudoku";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.SudokuGrid.ResumeLayout(false);
			this.SudokuGrid.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DifficultyTrackBar)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel SudokuGrid;
		private Label label81;
		private Label label80;
		private Label label79;
		private Label label78;
		private Label label77;
		private Label label76;
		private Label label75;
		private Label label74;
		private Label label73;
		private Label label72;
		private Label label71;
		private Label label70;
		private Label label69;
		private Label label68;
		private Label label67;
		private Label label66;
		private Label label65;
		private Label label64;
		private Label label63;
		private Label label62;
		private Label label61;
		private Label label60;
		private Label label59;
		private Label label58;
		private Label label57;
		private Label label56;
		private Label label55;
		private Label label54;
		private Label label53;
		private Label label52;
		private Label label51;
		private Label label50;
		private Label label49;
		private Label label48;
		private Label label47;
		private Label label46;
		private Label label45;
		private Label label44;
		private Label label43;
		private Label label42;
		private Label label41;
		private Label label40;
		private Label label39;
		private Label label38;
		private Label label37;
		private Label label36;
		private Label label35;
		private Label label34;
		private Label label33;
		private Label label32;
		private Label label31;
		private Label label30;
		private Label label29;
		private Label label28;
		private Label label27;
		private Label label26;
		private Label label25;
		private Label label24;
		private Label label23;
		private Label label22;
		private Label label21;
		private Label label20;
		private Label label19;
		private Label label18;
		private Label label17;
		private Label label16;
		private Label label15;
		private Label label14;
		private Label label13;
		private Label label12;
		private Label label11;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button GenerateButton;
		private Button SolveButton;
		private ComboBox DifficultyComboBox;
		private TrackBar DifficultyTrackBar;
		private Label DifficultPointsLabel;
		private Label label82;
		private GroupBox groupBox1;
		private ComboBox SymmetryComboBox;
		private OpenFileDialog LoadSudokuFromFile;
		private GroupBox groupBox2;
		private Button LoadFromFileButton;
	}
}

