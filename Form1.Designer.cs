
namespace Calculator
{
	partial class Calculator
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numberBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.subtractButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.negativeButton = new System.Windows.Forms.Button();
			this.floatButton = new System.Windows.Forms.Button();
			this.button0 = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.divideButton = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.enterButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.expressionBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// numberBox
			// 
			this.numberBox.Cursor = System.Windows.Forms.Cursors.No;
			this.numberBox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.numberBox.Location = new System.Drawing.Point(12, 12);
			this.numberBox.Name = "numberBox";
			this.numberBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.numberBox.Size = new System.Drawing.Size(190, 43);
			this.numberBox.TabIndex = 0;
			this.numberBox.Text = "0";
			this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(13, 221);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.number_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(59, 221);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 2;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.number_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(105, 221);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 3;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.number_Click);
			// 
			// subtractButton
			// 
			this.subtractButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.subtractButton.Location = new System.Drawing.Point(161, 221);
			this.subtractButton.Name = "subtractButton";
			this.subtractButton.Size = new System.Drawing.Size(40, 40);
			this.subtractButton.TabIndex = 4;
			this.subtractButton.Text = "–";
			this.subtractButton.UseVisualStyleBackColor = true;
			this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.addButton.Location = new System.Drawing.Point(161, 267);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(40, 40);
			this.addButton.TabIndex = 8;
			this.addButton.Text = "+";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// negativeButton
			// 
			this.negativeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.negativeButton.Location = new System.Drawing.Point(105, 267);
			this.negativeButton.Name = "negativeButton";
			this.negativeButton.Size = new System.Drawing.Size(40, 40);
			this.negativeButton.TabIndex = 7;
			this.negativeButton.Text = "(-)";
			this.negativeButton.UseVisualStyleBackColor = true;
			this.negativeButton.Click += new System.EventHandler(this.negativeButton_Click);
			// 
			// floatButton
			// 
			this.floatButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.floatButton.Location = new System.Drawing.Point(59, 267);
			this.floatButton.Name = "floatButton";
			this.floatButton.Size = new System.Drawing.Size(40, 40);
			this.floatButton.TabIndex = 6;
			this.floatButton.Text = ".";
			this.floatButton.UseVisualStyleBackColor = true;
			this.floatButton.Click += new System.EventHandler(this.floatButton_Click);
			// 
			// button0
			// 
			this.button0.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button0.Location = new System.Drawing.Point(13, 267);
			this.button0.Name = "button0";
			this.button0.Size = new System.Drawing.Size(40, 40);
			this.button0.TabIndex = 5;
			this.button0.Text = "0";
			this.button0.UseVisualStyleBackColor = true;
			this.button0.Click += new System.EventHandler(this.number_Click);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.multiplyButton.Location = new System.Drawing.Point(161, 175);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(40, 40);
			this.multiplyButton.TabIndex = 16;
			this.multiplyButton.Text = "X";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button6.Location = new System.Drawing.Point(105, 175);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(40, 40);
			this.button6.TabIndex = 15;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.number_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button5.Location = new System.Drawing.Point(59, 175);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(40, 40);
			this.button5.TabIndex = 14;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.number_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button4.Location = new System.Drawing.Point(13, 175);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(40, 40);
			this.button4.TabIndex = 13;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.number_Click);
			// 
			// divideButton
			// 
			this.divideButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.divideButton.Location = new System.Drawing.Point(161, 129);
			this.divideButton.Name = "divideButton";
			this.divideButton.Size = new System.Drawing.Size(40, 40);
			this.divideButton.TabIndex = 12;
			this.divideButton.Text = "÷";
			this.divideButton.UseVisualStyleBackColor = true;
			this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button9.Location = new System.Drawing.Point(105, 129);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(40, 40);
			this.button9.TabIndex = 11;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.number_Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button8.Location = new System.Drawing.Point(59, 129);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(40, 40);
			this.button8.TabIndex = 10;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.number_Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button7.Location = new System.Drawing.Point(13, 129);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(40, 40);
			this.button7.TabIndex = 9;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.number_Click);
			// 
			// enterButton
			// 
			this.enterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.enterButton.Location = new System.Drawing.Point(105, 322);
			this.enterButton.Name = "enterButton";
			this.enterButton.Size = new System.Drawing.Size(96, 40);
			this.enterButton.TabIndex = 17;
			this.enterButton.Text = "Enter";
			this.enterButton.UseVisualStyleBackColor = true;
			this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.clearButton.Location = new System.Drawing.Point(13, 73);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(86, 40);
			this.clearButton.TabIndex = 18;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// expressionBox
			// 
			this.expressionBox.Cursor = System.Windows.Forms.Cursors.No;
			this.expressionBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.expressionBox.Location = new System.Drawing.Point(105, 73);
			this.expressionBox.Multiline = true;
			this.expressionBox.Name = "expressionBox";
			this.expressionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.expressionBox.Size = new System.Drawing.Size(96, 40);
			this.expressionBox.TabIndex = 19;
			this.expressionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(214, 371);
			this.Controls.Add(this.expressionBox);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.enterButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.divideButton);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.negativeButton);
			this.Controls.Add(this.floatButton);
			this.Controls.Add(this.button0);
			this.Controls.Add(this.subtractButton);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.numberBox);
			this.Name = "Calculator";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox numberBox;
		private System.Windows.Forms.TextBox expressionBox;

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button subtractButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button divideButton;

		private System.Windows.Forms.Button negativeButton;
		private System.Windows.Forms.Button floatButton;

		private System.Windows.Forms.Button enterButton;
		private System.Windows.Forms.Button clearButton;

		private System.Windows.Forms.Button button0;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
	}
}

