namespace Simon_2
{
	partial class Simon2
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
			this.btnStart = new System.Windows.Forms.Button();
			this.btnYellow = new System.Windows.Forms.Button();
			this.btnBlue = new System.Windows.Forms.Button();
			this.btnPurple = new System.Windows.Forms.Button();
			this.btnBrown = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblScoreText = new System.Windows.Forms.Label();
			this.lblScorePoints = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(13, 13);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(98, 38);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnYellow
			// 
			this.btnYellow.BackColor = System.Drawing.Color.Yellow;
			this.btnYellow.Location = new System.Drawing.Point(6, 19);
			this.btnYellow.Name = "btnYellow";
			this.btnYellow.Size = new System.Drawing.Size(169, 131);
			this.btnYellow.TabIndex = 1;
			this.btnYellow.UseVisualStyleBackColor = false;
			this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
			// 
			// btnBlue
			// 
			this.btnBlue.BackColor = System.Drawing.Color.Blue;
			this.btnBlue.Location = new System.Drawing.Point(192, 19);
			this.btnBlue.Name = "btnBlue";
			this.btnBlue.Size = new System.Drawing.Size(169, 131);
			this.btnBlue.TabIndex = 2;
			this.btnBlue.UseVisualStyleBackColor = false;
			this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
			// 
			// btnPurple
			// 
			this.btnPurple.BackColor = System.Drawing.Color.Purple;
			this.btnPurple.Location = new System.Drawing.Point(6, 156);
			this.btnPurple.Name = "btnPurple";
			this.btnPurple.Size = new System.Drawing.Size(169, 131);
			this.btnPurple.TabIndex = 3;
			this.btnPurple.UseVisualStyleBackColor = false;
			this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
			// 
			// btnBrown
			// 
			this.btnBrown.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnBrown.Location = new System.Drawing.Point(192, 156);
			this.btnBrown.Name = "btnBrown";
			this.btnBrown.Size = new System.Drawing.Size(169, 131);
			this.btnBrown.TabIndex = 4;
			this.btnBrown.UseVisualStyleBackColor = false;
			this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnYellow);
			this.groupBox1.Controls.Add(this.btnBrown);
			this.groupBox1.Controls.Add(this.btnBlue);
			this.groupBox1.Controls.Add(this.btnPurple);
			this.groupBox1.Enabled = false;
			this.groupBox1.Location = new System.Drawing.Point(13, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(367, 306);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			// 
			// lblScoreText
			// 
			this.lblScoreText.AutoSize = true;
			this.lblScoreText.Location = new System.Drawing.Point(181, 26);
			this.lblScoreText.Name = "lblScoreText";
			this.lblScoreText.Size = new System.Drawing.Size(106, 13);
			this.lblScoreText.TabIndex = 6;
			this.lblScoreText.Text = "Total button presses:";
			// 
			// lblScorePoints
			// 
			this.lblScorePoints.AutoSize = true;
			this.lblScorePoints.Location = new System.Drawing.Point(293, 26);
			this.lblScorePoints.Name = "lblScorePoints";
			this.lblScorePoints.Size = new System.Drawing.Size(13, 13);
			this.lblScorePoints.TabIndex = 7;
			this.lblScorePoints.Text = "0";
			// 
			// Simon2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 384);
			this.Controls.Add(this.lblScorePoints);
			this.Controls.Add(this.lblScoreText);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnStart);
			this.Name = "Simon2";
			this.Text = "Simon2";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnYellow;
		private System.Windows.Forms.Button btnBlue;
		private System.Windows.Forms.Button btnPurple;
		private System.Windows.Forms.Button btnBrown;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblScoreText;
		private System.Windows.Forms.Label lblScorePoints;
	}
}

