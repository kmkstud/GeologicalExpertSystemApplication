namespace GeologicalExpertSystemApplication
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.questionLabel = new System.Windows.Forms.Label();
			this.yesRadioButton = new System.Windows.Forms.RadioButton();
			this.ratherYesRadioButton = new System.Windows.Forms.RadioButton();
			this.noRadioButton = new System.Windows.Forms.RadioButton();
			this.ratherNoRadioButton = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// questionLabel
			// 
			this.questionLabel.AutoSize = true;
			this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.questionLabel.Location = new System.Drawing.Point(16, 14);
			this.questionLabel.Name = "questionLabel";
			this.questionLabel.Size = new System.Drawing.Size(0, 13);
			this.questionLabel.TabIndex = 0;
			// 
			// yesRadioButton
			// 
			this.yesRadioButton.AutoSize = true;
			this.yesRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.yesRadioButton.Location = new System.Drawing.Point(19, 45);
			this.yesRadioButton.Name = "yesRadioButton";
			this.yesRadioButton.Size = new System.Drawing.Size(40, 17);
			this.yesRadioButton.TabIndex = 1;
			this.yesRadioButton.Text = "Да";
			this.yesRadioButton.UseVisualStyleBackColor = false;
			// 
			// ratherYesRadioButton
			// 
			this.ratherYesRadioButton.AutoSize = true;
			this.ratherYesRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ratherYesRadioButton.Location = new System.Drawing.Point(97, 45);
			this.ratherYesRadioButton.Name = "ratherYesRadioButton";
			this.ratherYesRadioButton.Size = new System.Drawing.Size(77, 17);
			this.ratherYesRadioButton.TabIndex = 2;
			this.ratherYesRadioButton.Text = "Скорее да";
			this.ratherYesRadioButton.UseVisualStyleBackColor = false;
			// 
			// noRadioButton
			// 
			this.noRadioButton.AutoSize = true;
			this.noRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.noRadioButton.Location = new System.Drawing.Point(19, 68);
			this.noRadioButton.Name = "noRadioButton";
			this.noRadioButton.Size = new System.Drawing.Size(44, 17);
			this.noRadioButton.TabIndex = 3;
			this.noRadioButton.Text = "Нет";
			this.noRadioButton.UseVisualStyleBackColor = false;
			// 
			// ratherNoRadioButton
			// 
			this.ratherNoRadioButton.AutoSize = true;
			this.ratherNoRadioButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ratherNoRadioButton.Location = new System.Drawing.Point(97, 68);
			this.ratherNoRadioButton.Name = "ratherNoRadioButton";
			this.ratherNoRadioButton.Size = new System.Drawing.Size(82, 17);
			this.ratherNoRadioButton.TabIndex = 4;
			this.ratherNoRadioButton.Text = "Скорее нет";
			this.ratherNoRadioButton.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.yesRadioButton);
			this.panel1.Controls.Add(this.ratherNoRadioButton);
			this.panel1.Controls.Add(this.questionLabel);
			this.panel1.Controls.Add(this.noRadioButton);
			this.panel1.Controls.Add(this.ratherYesRadioButton);
			this.panel1.Location = new System.Drawing.Point(12, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(595, 92);
			this.panel1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::GeologicalExpertSystemApplication.Properties.Resources.слои1;
			this.ClientSize = new System.Drawing.Size(619, 261);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Определение типа геологической породы";
			
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label questionLabel;
		private System.Windows.Forms.RadioButton yesRadioButton;
		private System.Windows.Forms.RadioButton ratherYesRadioButton;
		private System.Windows.Forms.RadioButton noRadioButton;
		private System.Windows.Forms.RadioButton ratherNoRadioButton;
		private System.Windows.Forms.Panel panel1;
	}
}

