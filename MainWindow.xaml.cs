using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isOperationClicked = false;





        public MainWindow()
        {
            InitializeComponent();
        }

        private void HandleNumericButton(string number)
        {
            if (!isOperationClicked)
            {
                if (MainCalculateScreen.Text == "0")
                {
                    MainCalculateScreen.Text = number;
                    isOperationClicked = false;
                }
                else
                {
                    MainCalculateScreen.Text += number;
                    isOperationClicked = false;
                }
            }
            else
            {
                MainCalculateScreen.Text = number;
                isOperationClicked = false;
            }
        }

        private void ButtonZero(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("0");
        }
        private void ButtonOne(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("1");
        }

        private void ButtonTwo(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("2");
        }

        private void ButtonThree(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("3");
        }

        private void ButtonFour(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("4");
        }

        private void ButtonFive(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("5");
        }

        private void ButtonSix(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("6");
        }

        private void ButtonSeven(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("7");
        }

        private void ButtonEight(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("8");
        }

        private void ButtonNine(object sender, RoutedEventArgs e)
        {
            HandleNumericButton("9");
        }

        private void HandleOperationButton(string operation)
        {
            if (!isOperationClicked)
            {
                if (SecondaryScreen.Text.Length > 0)
                {
                    isOperationClicked = true;
                    int firstNumber = int.Parse(SecondaryScreen.Text.Split(' ')[0]);
                    int secondNumber = int.Parse(MainCalculateScreen.Text);
                    char op = SecondaryScreen.Text.Split(' ')[1][0];
                    switch (op)
                    {
                        case '+':
                            MainCalculateScreen.Text = (firstNumber + secondNumber).ToString();
                            SecondaryScreen.Text = MainCalculateScreen.Text + " " + op;
                            break;
                        case '-':
                            MainCalculateScreen.Text = (firstNumber - secondNumber).ToString();
                            SecondaryScreen.Text = MainCalculateScreen.Text + " " + op;
                            break;
                        case '×':
                            MainCalculateScreen.Text = (firstNumber * secondNumber).ToString();
                            SecondaryScreen.Text = MainCalculateScreen.Text + " " + op;
                            break;
                        case '÷':
                            if (secondNumber != 0)
                            {

                                MainCalculateScreen.Text = (firstNumber / secondNumber).ToString();
                                SecondaryScreen.Text = MainCalculateScreen.Text + " " + op;
                            }
                            else
                                MainCalculateScreen.Text = "Error";
                            break;
                    }
                }
                else
                {
                    SecondaryScreen.Text = MainCalculateScreen.Text + " " + operation;
                    isOperationClicked = true;
                }
            }
            else if (SecondaryScreen.Text.Length > 0)
            {
                SecondaryScreen.Text = MainCalculateScreen.Text + " " + operation;
            }
        }

        private void ButtonEqual(object sender, RoutedEventArgs e)
        {
            //HandleOperationButton("=");
        }

        private void ButtonPlus(object sender, RoutedEventArgs e)
        {
            HandleOperationButton("+");
        }

        private void ButtonSubtract(object sender, RoutedEventArgs e)
        {
            HandleOperationButton("-");
        }

        private void ButtonMultiple(object sender, RoutedEventArgs e)
        {
            HandleOperationButton("×");
        }

        private void ButtonDivide(object sender, RoutedEventArgs e)
        {
            HandleOperationButton("÷");
        }
        private void ButtonDecimalPoint(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonChangeSign(object sender, RoutedEventArgs e)
        {

        }










        private void ButtonSqrt(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPowerTwo(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonReciprocal(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBackspace(object sender, RoutedEventArgs e)
        {
            if (MainCalculateScreen.Text == "0")
                return;
            else if (MainCalculateScreen.Text.Length == 1)
                MainCalculateScreen.Text = "0";
            else
                MainCalculateScreen.Text = MainCalculateScreen.Text.Remove(MainCalculateScreen.Text.Length - 1, 1);
        }

        private void Buttonclear(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClearEntry(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRemainder(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMDown(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMS(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMSubtract(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMPlus(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMR(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMC(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonHistory(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMenu(object sender, RoutedEventArgs e)
        {

        }
    }
}