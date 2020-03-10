using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            CalculatorCore.Calculate(this);
        }

        private void NumericOnly(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsTextNumeric(e.Text);
        }

        public static bool IsTextNumeric(string str)
        {
            Regex reg;
            if (str.Length == 0)
            {
                reg = new Regex("[^0-9]");
            }
            else
            {
                reg = new Regex("[^0-9*/+,-]");
            }
            return reg.IsMatch(str);
        }
    }
}
