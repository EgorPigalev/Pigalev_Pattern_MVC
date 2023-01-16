using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Паттерн_MVC
{
    public static class Model
    {
        // блок с данными
        public static double numberFirst;
        public static double numberSecondly;
        public static List<string> dataListDisplay = new List<string>() { "Сложение", "Вычитание", "Умножение", "Деление" }; // Список для выбора из comboBox
        public static List<string> dataListValue = new List<string>() { "+", "-", "*", "/" }; // Список для вывода в textBox

        // блок для обращения к текстовым полям
        public static TextBlock tbTextArithmeticOperation;
        public static TextBox tbResult;

        // блок с бизнес-логикой
        public static int ArithmeticOperation  // свойтсво для отображения знака арифметической операции
        {
            set
            {
                tbTextArithmeticOperation.Text = dataListValue[value];
            }
        }
        public static int CalculationResult // свойтсво для отображения результата
        {
            set
            {
                switch(value)
                {
                    case 0:
                        tbResult.Text = Convert.ToString(numberFirst + numberSecondly);
                        break;
                    case 1:
                        tbResult.Text = Convert.ToString(numberFirst - numberSecondly);
                        break;
                    case 2:
                        tbResult.Text = Convert.ToString(numberFirst * numberSecondly);
                        break;
                    case 3:
                        if(numberSecondly == 0)
                        {
                            tbResult.Text = "Деление на 0 (ноль) не допустимо";
                        }
                        else
                        {
                            tbResult.Text = Convert.ToString(numberFirst / numberSecondly);
                        }
                        break;
                }
            }
        }
    }
}
