namespace Ice_Task_4_Y2_S1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();

            //adding subscribers to the event
            calc.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed addition {num1} + {num2}");
            calc.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed subtraction {num1} - {num2}");
            calc.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed multiplication {num1} * {num2}");
            calc.OperationPerformed += (num1, num2) => Console.WriteLine($"Performed division {num1} / {num2}");


            double num1 = Convert.ToDouble( txtbxNum1.Text);

            Console.WriteLine("Enter num2: ");
            double num2 = Convert.ToDouble(txtbxNum2.Text);
            string display = "";
            display += $"add result: {calc.Add(num1, num2)}";
            display += $"subtract result: {calc.Subtract(num1, num2)}";
            display += $"multiply result: {calc.Multiply(num1, num2)}";
            display += $"divide result: {calc.Divide(num1, num2)}";
            rbxDisplay.Text = display;
        }

        private void txtbxNum1_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxNum1.Clear();
        }

        private void txtbxNum2_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxNum2.Clear();
        }
    }
}
