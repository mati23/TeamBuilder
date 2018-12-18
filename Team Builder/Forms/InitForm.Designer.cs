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
			this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
			this.metroTile1 = new MetroFramework.Controls.MetroTile();
			this.metroTile2 = new MetroFramework.Controls.MetroTile();
			this.metroTile3 = new MetroFramework.Controls.MetroTile();
			this.metroPanel1.SuspendLayout();
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
			this.metroPanel1.Size = new System.Drawing.Size(305, 415);
			this.metroPanel1.TabIndex = 0;
			this.metroPanel1.VerticalScrollbarBarColor = true;
			this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
			this.metroPanel1.VerticalScrollbarSize = 10;
			this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
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
			// InitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 433);
			this.Controls.Add(this.metroPanel1);
			this.Name = "InitForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.InitForm_Load);
			this.metroPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
		private MetroFramework.Controls.MetroTile metroTile3;
	}
}