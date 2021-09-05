using System;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		char expressionOperator = ' ';
		string displayNumber = "0";
		string fullExpression = "";
		double? runningValue = null;
		bool enterPressed = false;

		public Calculator()
		{
			InitializeComponent();
		}

		private void DisplayChanges()
		{
			numberBox.Text = displayNumber;
			expressionBox.Text = fullExpression + displayNumber;  // displayNumber added to fullExpression later. Makes it easier to add negative signs.
			enterPressed = false;
		}

		private void number_Click(object sender, EventArgs e)
		{
			// All number buttons are named "button[number]," so the last character of the sender name can be used to see which number was pressed
			char expressionAdd = ((Button)sender).Name[6];

			// At first "0" is displayed, so when a non-zero number is pressed it'll replace the "0"
			if ((displayNumber == "0" || displayNumber == "-0") && expressionAdd != '0')
				displayNumber = displayNumber[..^1];

			// If a number is pressed after enter is pressed, then it will finish clearing the calculator
			if (enterPressed)
				displayNumber = "";

			// Combined with the last if statement, this makes sure that leading zeros can't be added
			if (displayNumber != "0")
			{
				displayNumber += expressionAdd;
				DisplayChanges();
			}

			enterPressed = false;
		}

		private void floatButton_Click(object sender, EventArgs e)
		{
			// Ensures that there won't be multiple decimal points
			if (!displayNumber.Contains("."))
				displayNumber += ".";
			DisplayChanges();
		}

		private void negativeButton_Click(object sender, EventArgs e)
		{
			if (displayNumber.Contains("-"))
				displayNumber = displayNumber[1..];
			else
				displayNumber = "-" + displayNumber;
			DisplayChanges();
		}

		private void ApplyOperator(char op)
		{
			// displayNumber is reset to "" after an operator is pressed, so this ensures that you can't press two operators in a row
			if (displayNumber != "")
			{
				ApplyExpression();
				expressionOperator = op;
				fullExpression += displayNumber + " " + op + " ";
				displayNumber = "";
				DisplayChanges();
			}
		}

		private void ApplyExpression()
		{
			// runningValue will be null when the first operator is pressed, so the displayNumber is stored in runningValue.
			// The operator is then stored after this is called because the second number in the expression isn't known yet.
			// Every time this is run after the first operator, it'll have both numbers for the previous operator pressed, so it will apply that.
			try
			{
				if (runningValue.HasValue)
				{
					switch (expressionOperator)
					{
						case '+':
							runningValue += double.Parse(displayNumber);
							break;

						case '-':
							runningValue -= double.Parse(displayNumber);
							break;

						case '*':
							runningValue *= double.Parse(displayNumber);
							break;

						case '/':
							runningValue /= double.Parse(displayNumber);
							break;
					}
				}
				else
				{
					runningValue = double.Parse(displayNumber);
				}
			} catch (OverflowException)
			{
				ClearCalculator();
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			ApplyOperator('+');
		}

		private void subtractButton_Click(object sender, EventArgs e)
		{
			ApplyOperator('-');
		}

		private void multiplyButton_Click(object sender, EventArgs e)
		{
			ApplyOperator('*');
		}

		private void divideButton_Click(object sender, EventArgs e)
		{
			ApplyOperator('/');
		}

		private void enterButton_Click(object sender, EventArgs e)
		{
			ApplyExpression();

			expressionBox.Text = fullExpression + displayNumber;
			displayNumber = runningValue.ToString();

			// Handle dividing by zero
			if (double.IsInfinity((double)runningValue))
			{
				numberBox.Text = "undefined";
				displayNumber = "";
				
			} else
			{
				numberBox.Text = displayNumber + "";
			}

			// If an operator is pressed after enter is pressed, the entire expression will be replaced by the enter result
			// If a number is pressed, then the calculator is almost fully reset except for displayNumber
			fullExpression = "";
			runningValue = null;
			enterPressed = true;
		}

		private void ClearCalculator()
		{
			displayNumber = "0";
			fullExpression = "";
			runningValue = null;

			DisplayChanges();
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			ClearCalculator();
		}
	}
}
