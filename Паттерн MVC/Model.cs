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
        public static string firstField;
        public static string secondlyField;
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
                try
                {
                    double numberFirst = 0;
                    double numberSecondly = 0;
                    if (firstField != "")
                    {
                        numberFirst = Convert.ToDouble(firstField);
                    }
                    if (secondlyField != "")
                    {
                        numberSecondly = Convert.ToDouble(secondlyField);
                    }
                    switch (value)
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
                            if (numberSecondly == 0)
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
                catch
                {
                    MessageBox.Show("При вычисление арифметической операции возникла ошибка");
                }
        }
        }
    }
}
