using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Logick logick;
        public MainWindow()
        {
            InitializeComponent();
            logick = new Logick(ref this.Text);
        }

        private void numOne_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numOne);
            logick.updateSizeText();
        }

        private void numTwo_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numTwo);
            logick.updateSizeText();
        }

        private void numThree_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numThree);
            logick.updateSizeText();
        }

        private void numFour_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numFour);
            logick.updateSizeText();
        }

        private void numFive_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numFive);
            logick.updateSizeText();
        }

        private void numSix_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numSix);
            logick.updateSizeText();
        }

        private void numSeven_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numSeven);
            logick.updateSizeText();
        }

        private void numEight_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numEight);
            logick.updateSizeText();
        }

        private void numNine_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numNine);
            logick.updateSizeText();
        }

        private void numZero_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.numZero);
            logick.updateSizeText();
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.Point);
            logick.updateSizeText();
        }

        private void GetAnswer_Click(object sender, RoutedEventArgs e)
        {
            logick.Calculate();
            logick.updateSizeText();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.Plus);
            logick.updateSizeText();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.Minus);
            logick.updateSizeText();
        }

        private void Multiple_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.Multiple);
            logick.updateSizeText();
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.Division);
            logick.updateSizeText();
        }

       
        private void numPi_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref numPi);
            logick.updateSizeText();
        }

        private void LeftBracket_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.LeftBracket);
            logick.updateSizeText();
        }

        private void RightBracket_Click(object sender, RoutedEventArgs e)
        {
            logick.add(ref this.RightBracket);
            logick.updateSizeText();
        }

        private void Text_TextInput(object sender, TextCompositionEventArgs e)
        {
            logick.updateSizeText();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            this.Text.Clear();
        }

        private void ClearSymbolButton_Click(object sender, RoutedEventArgs e)
        {
            this.Text.Text = this.Text.Text.Remove(this.Text.Text.Length - 1, 1);
        }
    }
}
