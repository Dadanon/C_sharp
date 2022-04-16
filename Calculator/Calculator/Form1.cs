namespace Calculator
{
    public partial class Form1 : Form
    {
        private List<decimal> NumbersMemory = new List<decimal>();
        private List<string> OperatorsMemory = new List<string>(1);
        private List<string> Operators = new List<string>() { "+", "-", "*", "/"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "1";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "2";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "3";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "4";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "5";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "6";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "7";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "8";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("0"))
            {
                if (!Operators.Contains(textBox1.Text))
                {
                    textBox1.Text += "9";
                }
                else
                {
                    OperatorsMemory.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Text += "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!Operators.Contains(textBox1.Text) && textBox1.Text != "")
            {
                textBox1.Text += "0";
            }
            else
            {
                OperatorsMemory.Add(textBox1.Text);
                textBox1.Clear();
                textBox1.Text += "0";
            }
        }

        // Divide button
        private void button11_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) | !string.IsNullOrEmpty(textBox2.Text))
            {
                if (!textBox1.Text[^1].Equals(","))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        NumbersMemory.Add(Convert.ToDecimal(textBox1.Text)); ;
                        textBox1.Text = "/";
                        if (OperatorsMemory.Count != 0)
                        {
                            decimal result;
                            switch (OperatorsMemory[0])
                            {
                                case "+":
                                    result = NumbersMemory[0] + NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "-":
                                    result = NumbersMemory[0] - NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "/":
                                    if (NumbersMemory[1] != 0)
                                    {
                                        result = NumbersMemory[0] / NumbersMemory[1];
                                        textBox2.Text = result.ToString();
                                        NumbersMemory.Clear();
                                        NumbersMemory.Add(result);
                                    }
                                    else
                                    {
                                        textBox2.Text = "ERROR";
                                        NumbersMemory.Clear();
                                    }
                                    break;
                                case "*":
                                    result = NumbersMemory[0] * NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                            }
                        }
                        OperatorsMemory.Clear();
                    }
                }
            }
        }

        // Multiply button
        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) | !string.IsNullOrEmpty(textBox2.Text))
            {
                if (!textBox1.Text[^1].Equals(","))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        NumbersMemory.Add(Convert.ToDecimal(textBox1.Text)); ;
                        textBox1.Text = "*";
                        if (OperatorsMemory.Count != 0)
                        {
                            decimal result;
                            switch (OperatorsMemory[0])
                            {
                                case "+":
                                    result = NumbersMemory[0] + NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "-":
                                    result = NumbersMemory[0] - NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "/":
                                    if (NumbersMemory[1] != 0)
                                    {
                                        result = NumbersMemory[0] / NumbersMemory[1];
                                        textBox2.Text = result.ToString();
                                        NumbersMemory.Clear();
                                        NumbersMemory.Add(result);
                                    }
                                    else
                                    {
                                        textBox2.Text = "ERROR";
                                        NumbersMemory.Clear();
                                    }
                                    break;
                                case "*":
                                    result = NumbersMemory[0] * NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                            }
                        }
                        OperatorsMemory.Clear();
                    }
                }
            }
        }

        // Minus button
        private void button13_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) | !string.IsNullOrEmpty(textBox2.Text))
            {
                if (!textBox1.Text[^1].Equals(","))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        NumbersMemory.Add(Convert.ToDecimal(textBox1.Text)); ;
                        textBox1.Text = "-";
                        if (OperatorsMemory.Count != 0)
                        {
                            decimal result;
                            switch (OperatorsMemory[0])
                            {
                                case "+":
                                    result = NumbersMemory[0] + NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "-":
                                    result = NumbersMemory[0] - NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "/":
                                    if (NumbersMemory[1] != 0)
                                    {
                                        result = NumbersMemory[0] / NumbersMemory[1];
                                        textBox2.Text = result.ToString();
                                        NumbersMemory.Clear();
                                        NumbersMemory.Add(result);
                                    }
                                    else
                                    {
                                        textBox2.Text = "ERROR";
                                        NumbersMemory.Clear();
                                    }
                                    break;
                                case "*":
                                    result = NumbersMemory[0] * NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                            }
                        }
                        OperatorsMemory.Clear();
                    }
                }
            }
        }

        // Plus button
        private void button14_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) | !string.IsNullOrEmpty(textBox2.Text))
            {
                if (!textBox1.Text[^1].Equals(","))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        NumbersMemory.Add(Convert.ToDecimal(textBox1.Text));
                        textBox1.Text = "+";
                        if (OperatorsMemory.Count != 0)
                        {
                            decimal result;
                            switch (OperatorsMemory[0])
                            {
                                case "+":
                                    result = NumbersMemory[0] + NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "-":
                                    result = NumbersMemory[0] - NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "/":
                                    if (NumbersMemory[1] != 0)
                                    {
                                        result = NumbersMemory[0] / NumbersMemory[1];
                                        textBox2.Text = result.ToString();
                                        NumbersMemory.Clear();
                                        NumbersMemory.Add(result);
                                    }
                                    else
                                    {
                                        textBox2.Text = "ERROR";
                                        NumbersMemory.Clear();
                                    }
                                    break;
                                case "*":
                                    result = NumbersMemory[0] * NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                            }
                        }
                        OperatorsMemory.Clear();
                    }
                }
            }       
        }

        // Delete button
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text[0..^1];
            }
        }

        // Comma button
        private void button16_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!textBox1.Text.Contains(','))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        textBox1.Text += ",";
                    }
                }
            }
        }

        // Clear button
        private void button17_Click(object sender, EventArgs e)
        {
            NumbersMemory.Clear();
            OperatorsMemory.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Equals button
        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                if (!textBox1.Text[^1].Equals(","))
                {
                    if (!Operators.Contains(textBox1.Text))
                    {
                        NumbersMemory.Add(Convert.ToDecimal(textBox1.Text)); ;
                        textBox1.Text = "";
                        if (OperatorsMemory.Count != 0)
                        {
                            decimal result;
                            switch (OperatorsMemory[0])
                            {
                                case "+":
                                    result = NumbersMemory[0] + NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "-":
                                    result = NumbersMemory[0] - NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                                case "/":
                                    if (NumbersMemory[1] != 0)
                                    {
                                        result = NumbersMemory[0] / NumbersMemory[1];
                                        textBox2.Text = result.ToString();
                                        NumbersMemory.Clear();
                                        NumbersMemory.Add(result);
                                    }
                                    else
                                    {
                                        textBox2.Text = "ERROR";
                                        NumbersMemory.Clear();
                                    }
                                    break;
                                case "*":
                                    result = NumbersMemory[0] * NumbersMemory[1];
                                    textBox2.Text = result.ToString();
                                    NumbersMemory.Clear();
                                    NumbersMemory.Add(result);
                                    break;
                            }
                        }
                        OperatorsMemory.Clear();
                    }
                }
            }
        }
    }
}