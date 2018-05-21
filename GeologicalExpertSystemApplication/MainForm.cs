using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeologicalExpertSystemApplication
{
	public partial class MainForm : Form
	{
		QuestionsSystem questionsSystem;

		public MainForm()
		{
			InitializeComponent();
			setupRadioButtons();
			questionsSystem = new QuestionsSystem(this);
			questionsSystem.Start();
		}

		public void SetNewQuestion(string question)
		{
			this.questionLabel.Text = question;
			this.yesRadioButton.Checked = false;
			this.ratherYesRadioButton.Checked = false;
			this.noRadioButton.Checked = false;
			this.ratherNoRadioButton.Checked = false;
		}

		public void SetResponse(string s)
		{
			MessageBox.Show("Результат: " + s, "Результат работы ЭС по выбору геологической породы", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void setupRadioButtons()
		{
			ratherNoRadioButton.Tag = Answers.RatherNo;
			yesRadioButton.Tag = Answers.Yes;
			noRadioButton.Tag = Answers.No;
			ratherYesRadioButton.Tag = Answers.RatherYes;
			ratherNoRadioButton.CheckedChanged += answerRadioButton_CheckedChanged;
			ratherYesRadioButton.CheckedChanged += answerRadioButton_CheckedChanged;
			yesRadioButton.CheckedChanged += answerRadioButton_CheckedChanged;
			noRadioButton.CheckedChanged += answerRadioButton_CheckedChanged;
		}

		private void answerRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			var rb = (RadioButton)sender;
			if (rb.Checked)
				questionsSystem.HandleAnswer((Answers)rb.Tag);
		}
	}
}
