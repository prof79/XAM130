// MainPage.xaml.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        #region Fields

        private int currentState = 1;
        private string mathOperator;
        private double firstNumber, secondNumber;

        #endregion

        #region Constructors

        public MainPage()
		{
			InitializeComponent();
		}

        #endregion

        #region Methods

        private void OnSelectNumber(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                var pressed = button.Text;

                if (this.resultText.Text == "0" || currentState < 0)
                {
                    this.resultText.Text = "";

                    if (currentState < 0)
                    {
                        currentState *= -1;
                    }
                }

                this.resultText.Text += pressed;

                double number;

                if (double.TryParse(this.resultText.Text, out number))
                {
                    this.resultText.Text = number.ToString();

                    if (currentState == 1)
                    {
                        firstNumber = number;
                    }
                    else
                    {
                        secondNumber = number;
                    }
                }
            }
        }

        private void OnSelectOperator(object sender, EventArgs e)
        {
            currentState = -2;

            if (sender is Button button)
            {
                mathOperator = button.Text;
            }
        }

        private void OnClear(object sender, EventArgs e)
        {
            firstNumber = 0;

            secondNumber = 0;

            currentState = 1;

            this.resultText.Text = "0";
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                var result = SimpleCalculator.Calculate(firstNumber, secondNumber, mathOperator);

                this.resultText.Text = result.ToString();

                firstNumber = result;

                currentState = -1;
            }
        }

        #endregion
    }
}
