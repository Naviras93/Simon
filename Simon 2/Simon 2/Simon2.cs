using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Simon_2
{
	public partial class Simon2 : Form
	{


		public delegate void ResetSettingsHandler();
		Color yellow, blue, purple, brown;
		List<int> generatedSequence = new List<int>();
		int currentColorIndex = 0;
		int currentButtonPresses = 0;
		Random randomNumber = new Random();
		
		public Simon2()
		{
			InitializeComponent();
		}

		private void GenerateNewSequence()
		{
			generatedSequence.Clear();

			for (int i = 0; i < 4; i++)
				generatedSequence.Add(randomNumber.Next(4));
		}

		private void SwitchForEachColor(int color)
		{
			switch (color)
			{
				case 0:
					btnYellow.BackColor = DarkenColor(btnYellow.BackColor);
					break;
				case 1:
					btnBlue.BackColor = DarkenColor(btnBlue.BackColor);
					break;
				case 2:
					btnPurple.BackColor = DarkenColor(btnPurple.BackColor);
					break;
				case 3:
					btnBrown.BackColor = DarkenColor(btnBrown.BackColor);
					break;
			}
			Thread.Sleep(200);
			ColorReset();
			Thread.Sleep(200);
		}

		private void StartSequence()
		{
			foreach (int color in generatedSequence)
			{
				SwitchForEachColor(color);
			}

			ResetSettingsHandler reverseGroupBoxSettings = new ResetSettingsHandler(ReverseGroupBoxSettings);
			groupBox1.BeginInvoke(reverseGroupBoxSettings);

		}
		
		private void ColorReset()
		{
			btnYellow.BackColor = yellow;
			btnBlue.BackColor = blue;
			btnPurple.BackColor = purple;
			btnBrown.BackColor = brown;
		}

		private Color DarkenColor(Color backColor)
		{
			backColor = ControlPaint.Dark(backColor);
			return backColor;
		}
		
		private void TestClick(object number)
		{
			int color;
			if (int.TryParse(number.ToString(), out color))
			{
				ResetSettingsHandler changeScore = new ResetSettingsHandler(ChangeScore);
				SwitchForEachColor(color);
				if (generatedSequence[currentColorIndex] == color)
				{
					currentButtonPresses++;
					lblScorePoints.BeginInvoke(changeScore);
					currentColorIndex++;
				}

				else
				{
					ResetSettingsHandler reverseGroupBoxSettings = new ResetSettingsHandler(ReverseGroupBoxSettings);
					groupBox1.BeginInvoke(reverseGroupBoxSettings);
					MessageBox.Show("You fail! Final score: " + currentButtonPresses);
					ResetSettingsHandler reverseStartButtonSettings = new ResetSettingsHandler(ReverseStartButtonSettings);
					btnStart.BeginInvoke(reverseStartButtonSettings);
					currentColorIndex = 0;
					currentButtonPresses = 0;
					generatedSequence = new List<int>();
					return;
				}

				if (currentColorIndex >= generatedSequence.Count)
				{
					ResetSettingsHandler reverseGroupBoxSettings = new ResetSettingsHandler(ReverseGroupBoxSettings);
					groupBox1.BeginInvoke(reverseGroupBoxSettings);
					MessageBox.Show("Section completed! Press OK to continue");
					generatedSequence.Add(randomNumber.Next(0, 4));
					currentColorIndex = 0;
					new Thread(StartSequence).Start();

				}
			}

		}

		private void ChangeScore()
		{
			lblScorePoints.Text = currentButtonPresses.ToString();
		}

		private void ReverseGroupBoxSettings()
		{
			groupBox1.Enabled = !groupBox1.Enabled;
		}

		private void ReverseStartButtonSettings()
		{
			btnStart.Enabled = !btnStart.Enabled;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{

			btnStart.Enabled = false;

			yellow = btnYellow.BackColor;
			blue = btnBlue.BackColor;
			purple = btnPurple.BackColor;
			brown = btnBrown.BackColor;

			GenerateNewSequence();
			new Thread(StartSequence).Start();
		}

		private void btnYellow_Click(object sender, EventArgs e)
		{
			new Thread(new ParameterizedThreadStart(TestClick)).Start(0);
		}

		private void btnBlue_Click(object sender, EventArgs e)
		{
			new Thread(new ParameterizedThreadStart(TestClick)).Start(1);
		}

		private void btnPurple_Click(object sender, EventArgs e)
		{

			new Thread(new ParameterizedThreadStart(TestClick)).Start(2);
		}

		private void btnBrown_Click(object sender, EventArgs e)
		{
			new Thread(new ParameterizedThreadStart(TestClick)).Start(3);
		}
		
	}
}
