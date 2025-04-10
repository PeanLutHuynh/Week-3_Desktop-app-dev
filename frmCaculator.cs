namespace Caculator
{
    public partial class frmCaculator : Form
    {
        private double _currentValue = 0;
        private double _previousValue = 0;
        private string _currentOperation = string.Empty;

        public frmCaculator()
        {
            InitializeComponent();
            AssignButtonEvents();
        }

        private void AssignButtonEvents()
        {
            // Assign number buttons (0-9) to the same event handler
            foreach (var button in this.Controls.OfType<Button>().Where(b => char.IsDigit(b.Text, 0) || b.Text == "."))
            {
                button.Click += NumberButton_Click;
            }

            // Assign operation buttons (+, -, *, /) to the same event handler
            foreach (var button in this.Controls.OfType<Button>().Where(b => "+-*/".Contains(b.Text)))
            {
                button.Click += OperationButton_Click;
            }

            // Assign function buttons (CE, C, =) to the same event handler
            foreach (var button in this.Controls.OfType<Button>().Where(b => "CE C =".Split(' ').Contains(b.Text)))
            {
                button.Click += FunctionButton_Click;
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // Handle number button click
            if (button.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                {
                    txtResult.Text += button.Text;
                }
            }
            else
            {
                txtResult.Text += button.Text;
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // Store the current value and the selected operation
            _previousValue = double.Parse(txtResult.Text);
            _currentOperation = button.Text;
            txtResult.Text = string.Empty; // Clear the display for the next number
        }

        private void FunctionButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Text)
            {
                case "CE":
                    txtResult.Text = string.Empty;
                    _currentValue = 0;
                    _previousValue = 0;
                    _currentOperation = string.Empty;
                    break;
                case "C":
                    if (txtResult.Text.Length > 0)
                    {
                        txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                    }
                    break;
                case "=":
                    _currentValue = double.Parse(txtResult.Text);
                    double result = 0;
                    switch (_currentOperation)
                    {
                        case "+":
                            result = _previousValue + _currentValue;
                            break;
                        case "-":
                            result = _previousValue - _currentValue;
                            break;
                        case "*":
                            result = _previousValue * _currentValue;
                            break;
                        case "/":
                            if (_currentValue != 0)
                            {
                                result = _previousValue / _currentValue;
                            }
                            else
                            {
                                MessageBox.Show("Cannot divide by zero");
                            }
                            break;
                    }
                    txtResult.Text = result.ToString();
                    _previousValue = result; // Store the result for further calculations
                    _currentOperation = string.Empty;
                    break;
            }
        }
    }
}
