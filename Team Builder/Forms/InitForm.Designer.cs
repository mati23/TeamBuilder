using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Team_Builder.Forms
{
    partial class InitForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.mtMainTab = new MetroFramework.Controls.MetroTabControl();
			this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
			this.teambuilderDataSet = new Team_Builder.teambuilderDataSet();
			this.teambuilderDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mtPlayerNameTXT = new MetroFramework.Controls.MetroTextBox();
			this.mtPlayersGrid = new MetroFramework.Controls.MetroGrid();
			this.metroPanel1.SuspendLayout();
			this.mtMainTab.SuspendLayout();
			this.metroTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.teambuilderDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teambuilderDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mtPlayersGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// metroPanel1
			// 
			this.metroPanel1.BackColor = System.Drawing.Color.Wheat;
			this.metroPanel1.Controls.Add(this.metroTile3);
			this.metroPanel1.Controls.Add(this.metroTile1);
			this.metroPanel1.Controls.Add(this.metroTile2);
			this.metroPanel1.HorizontalScrollbarBarColor = true;
			this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroPanel1.HorizontalScrollbarSize = 10;
			this.metroPanel1.Location = new System.Drawing.Point(0, 0);
			this.metroPanel1.Name = "metroPanel1";
			this.metroPanel1.Padding = new System.Windows.Forms.Padding(3);
			this.metroPanel1.Size = new System.Drawing.Size(144, 415);
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
			// 
			// metroTile3
			// 
			this.metroTile3.ActiveControl = null;
			this.metroTile3.BackColor = System.Drawing.Color.SeaGreen;
			this.metroTile3.Location = new System.Drawing.Point(6, 278);
			this.metroTile3.Name = "metroTile3";
			this.metroTile3.Size = new System.Drawing.Size(130, 130);
			this.metroTile3.TabIndex = 4;
			this.metroTile3.Text = "Add Player";
			this.metroTile3.TileImage = global::Team_Builder.Properties.Resources.icons8_mais_64__1_;
			this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
			this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile3.UseCustomBackColor = true;
			this.metroTile3.UseSelectable = true;
			this.metroTile3.UseTileImage = true;
			// 
			// metroTile1
			// 
			this.metroTile1.ActiveControl = null;
			this.metroTile1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.metroTile1.Location = new System.Drawing.Point(6, 6);
			this.metroTile1.Name = "metroTile1";
			this.metroTile1.Size = new System.Drawing.Size(130, 130);
			this.metroTile1.TabIndex = 3;
			this.metroTile1.Text = "Search Player";
			this.metroTile1.TileImage = global::Team_Builder.Properties.Resources.icons8_pesquisar_64;
			this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
			this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile1.UseCustomBackColor = true;
			this.metroTile1.UseSelectable = true;
			this.metroTile1.UseTileImage = true;
			// 
			// metroTile2
			// 
			this.metroTile2.ActiveControl = null;
			this.metroTile2.BackColor = System.Drawing.Color.SeaGreen;
			this.metroTile2.Location = new System.Drawing.Point(6, 142);
			this.metroTile2.Name = "metroTile2";
			this.metroTile2.Size = new System.Drawing.Size(130, 130);
			this.metroTile2.TabIndex = 2;
			this.metroTile2.Text = "Add Player";
			this.metroTile2.TileImage = global::Team_Builder.Properties.Resources.icons8_mais_64__1_;
			this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
			this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.metroTile2.UseCustomBackColor = true;
			this.metroTile2.UseSelectable = true;
			this.metroTile2.UseTileImage = true;
			this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
			// 
			// mtMainTab
			// 
			this.mtMainTab.Controls.Add(this.metroTabPage1);
			this.mtMainTab.Location = new System.Drawing.Point(150, 0);
			this.mtMainTab.Name = "mtMainTab";
			this.mtMainTab.SelectedIndex = 0;
			this.mtMainTab.Size = new System.Drawing.Size(652, 415);
			this.mtMainTab.TabIndex = 1;
			this.mtMainTab.UseSelectable = true;
			// 
			// metroTabPage1
			// 
			this.metroTabPage1.Controls.Add(this.mtPlayerNameTXT);
			this.metroTabPage1.Controls.Add(this.mtPlayersGrid);
			this.metroTabPage1.HorizontalScrollbarBarColor = true;
			this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.HorizontalScrollbarSize = 10;
			this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
			this.metroTabPage1.Name = "metroTabPage1";
			this.metroTabPage1.Size = new System.Drawing.Size(644, 373);
			this.metroTabPage1.TabIndex = 0;
			this.metroTabPage1.Text = "metroTabPage1";
			this.metroTabPage1.VerticalScrollbarBarColor = true;
			this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPage1.VerticalScrollbarSize = 10;
			// 
			// teambuilderDataSet
			// 
			this.teambuilderDataSet.DataSetName = "teambuilderDataSet";
			this.teambuilderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// teambuilderDataSetBindingSource
			// 
			this.teambuilderDataSetBindingSource.DataSource = this.teambuilderDataSet;
			this.teambuilderDataSetBindingSource.Position = 0;
			// 
			// mtPlayerNameTXT
			// 
			// 
			// 
			// 
			this.mtPlayerNameTXT.CustomButton.Image = null;
			this.mtPlayerNameTXT.CustomButton.Location = new System.Drawing.Point(143, 1);
			this.mtPlayerNameTXT.CustomButton.Name = "";
			this.mtPlayerNameTXT.CustomButton.Size = new System.Drawing.Size(21, 21);
			this.mtPlayerNameTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mtPlayerNameTXT.CustomButton.TabIndex = 1;
			this.mtPlayerNameTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mtPlayerNameTXT.CustomButton.UseSelectable = true;
			this.mtPlayerNameTXT.CustomButton.Visible = false;
			this.mtPlayerNameTXT.Lines = new string[] {
        "metroTextBox1"};
			this.mtPlayerNameTXT.Location = new System.Drawing.Point(4, 50);
			this.mtPlayerNameTXT.MaxLength = 32767;
			this.mtPlayerNameTXT.Name = "mtPlayerNameTXT";
			this.mtPlayerNameTXT.PasswordChar = '\0';
			this.mtPlayerNameTXT.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mtPlayerNameTXT.SelectedText = "";
			this.mtPlayerNameTXT.SelectionLength = 0;
			this.mtPlayerNameTXT.SelectionStart = 0;
			this.mtPlayerNameTXT.ShortcutsEnabled = true;
			this.mtPlayerNameTXT.Size = new System.Drawing.Size(165, 23);
			this.mtPlayerNameTXT.TabIndex = 3;
			this.mtPlayerNameTXT.Text = "metroTextBox1";
			this.mtPlayerNameTXT.UseSelectable = true;
			this.mtPlayerNameTXT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mtPlayerNameTXT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			this.mtPlayerNameTXT.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
			// 
			// mtPlayersGrid
			// 
			this.mtPlayersGrid.AllowUserToResizeRows = false;
			this.mtPlayersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.mtPlayersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mtPlayersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.mtPlayersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.mtPlayersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.mtPlayersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.mtPlayersGrid.DefaultCellStyle = dataGridViewCellStyle2;
			this.mtPlayersGrid.EnableHeadersVisualStyles = false;
			this.mtPlayersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.mtPlayersGrid.GridColor = System.Drawing.Color.Silver;
			this.mtPlayersGrid.Location = new System.Drawing.Point(4, 104);
			this.mtPlayersGrid.Name = "mtPlayersGrid";
			this.mtPlayersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.mtPlayersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.mtPlayersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.mtPlayersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.mtPlayersGrid.Size = new System.Drawing.Size(637, 204);
			this.mtPlayersGrid.TabIndex = 2;
			// 
			// InitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 419);
			this.Controls.Add(this.mtMainTab);
			this.Controls.Add(this.metroPanel1);
			this.Name = "InitForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.InitForm_Load);
			this.metroPanel1.ResumeLayout(false);
			this.mtMainTab.ResumeLayout(false);
			this.metroTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.teambuilderDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teambuilderDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mtPlayersGrid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile3;
		private MetroFramework.Controls.MetroTabControl mtMainTab;
		private MetroFramework.Controls.MetroTabPage metroTabPage1;
		private System.Windows.Forms.BindingSource teambuilderDataSetBindingSource;
		private teambuilderDataSet teambuilderDataSet;
		private MetroFramework.Controls.MetroTextBox mtPlayerNameTXT;
		private MetroFramework.Controls.MetroGrid mtPlayersGrid;
	}
}