using System;
using System.Windows;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private readonly CalculatorLogic _calculatorLogic = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.Button;
            if (ResultTextBox.Text == "0")
                ResultTextBox.Text = button.Content.ToString();
            else
                ResultTextBox.Text += button.Content.ToString();
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.Button;
            _calculatorLogic.FirstNumber = double.Parse(ResultTextBox.Text);
            _calculatorLogic.Operation = button.Content.ToString();
            ResultTextBox.Text = "0";
        }

        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            _calculatorLogic.SecondNumber = double.Parse(ResultTextBox.Text);
            try
            {
                double result = _calculatorLogic.Calculate();
                ResultTextBox.Text = result.ToString();
                _calculatorLogic.FirstNumber = result;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
                ResultTextBox.Text = _calculatorLogic.FirstNumber.ToString();
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            _calculatorLogic.FirstNumber = 0;
            _calculatorLogic.SecondNumber = 0;
            _calculatorLogic.Operation = string.Empty;
            ResultTextBox.Text = "0";
        }
    }
}
