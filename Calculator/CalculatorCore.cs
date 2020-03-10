using NCalc2;

namespace Calculator
{
    class CalculatorCore
    {
        public static void Calculate(MainWindow mw)
        {
            // Botón Dividir
            mw.btnDiv.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Length == 0 || mw.numbersPanel.Text.Equals("NaN"))
                    return;
                else if (!mw.numbersPanel.Text.EndsWith("+") && !mw.numbersPanel.Text.EndsWith("-") && !mw.numbersPanel.Text.EndsWith("*") && !mw.numbersPanel.Text.EndsWith("/"))
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "/";
            };

            // Botón Multiplicar
            mw.btnTimes.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Length == 0 || mw.numbersPanel.Text.Equals("NaN"))
                    return;
                else if (!mw.numbersPanel.Text.EndsWith("+") && !mw.numbersPanel.Text.EndsWith("-") && !mw.numbersPanel.Text.EndsWith("*") && !mw.numbersPanel.Text.EndsWith("/"))
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "*";
            };

            // Botón Menos
            mw.btnPast.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "-";
                else if (!mw.numbersPanel.Text.EndsWith("+") && !mw.numbersPanel.Text.EndsWith("-") && !mw.numbersPanel.Text.EndsWith("*") && !mw.numbersPanel.Text.EndsWith("/"))
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "-";
            };

            // Botón Sumar
            mw.btnPlus.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "+";
                else if (!mw.numbersPanel.Text.EndsWith("+") && !mw.numbersPanel.Text.EndsWith("-") && !mw.numbersPanel.Text.EndsWith("*") && !mw.numbersPanel.Text.EndsWith("/"))
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "+";
            };

            //----------------DECIMAL----------------//

            mw.btnDecimal.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Length == 0 || mw.numbersPanel.Text.Equals("NaN"))
                    return;
                else if (!mw.numbersPanel.Text.EndsWith("+") && !mw.numbersPanel.Text.EndsWith("-") && !mw.numbersPanel.Text.EndsWith("*") && !mw.numbersPanel.Text.EndsWith("/"))
                    mw.numbersPanel.Text = mw.numbersPanel.Text + ",";
            };

            //----------------NUMBERS----------------//

            mw.btnZero.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "0";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "0";
            };

            mw.btnOne.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "1";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "1";
            };

            mw.btnTwo.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "2";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "2";
            };

            mw.btnThree.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "3";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "3";
            };

            mw.btnFour.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "4";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "4";
            };

            mw.btnFive.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "5";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "5";
            };

            mw.btnSix.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "6";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "6";
            };

            mw.btnSeven.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "7";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "7";
            };

            mw.btnEight.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "8";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "8";
            };

            mw.btnNine.Click += (o, i) =>
            {
                if (mw.numbersPanel.Text.Equals("0") || mw.numbersPanel.Text.Equals("NaN"))
                    mw.numbersPanel.Text = "9";
                else
                    mw.numbersPanel.Text = mw.numbersPanel.Text + "9";
            };

            //----------------KEY PRESSED----------------//

            mw.numbersPanel.KeyDown += (o, i) =>
            {
                if (mw.numbersPanel.Text.Contains("NaN"))
                    mw.numbersPanel.Text = mw.numbersPanel.Text.Replace("NaN", "");
            };

            //----------------EQUAL----------------//
            mw.btnEqual.Click += (o, i) =>
            {
                mw.numbersPanel.Text = mw.numbersPanel.Text.Replace(",", ".");
                if (mw.numbersPanel.Text.Length == 0)
                    return;
                else if (!mw.numbersPanel.Text.EndsWith("+") && !mw.numbersPanel.Text.EndsWith("-") && !mw.numbersPanel.Text.EndsWith("*") && !mw.numbersPanel.Text.EndsWith("/"))
                    mw.numbersPanel.Text = ProcessExpression(mw.numbersPanel.Text).ToString().Replace(".", ",");
            };
        }

        // Método que procesa la expresión en String y devuelve un objeto para imprimir por pantalla.
        private static object ProcessExpression(string expression)
        {
            Expression e = new Expression(expression);
            object result;
            try
            {
                result = e.Evaluate();
            }
            catch
            {
                result = "NaN";
            }
            return result;
        }
    }
}
