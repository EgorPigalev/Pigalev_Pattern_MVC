﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Паттерн_MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Model.tbResult = tbResult;
            Model.tbTextArithmeticOperation = tbTextArithmeticOperation;
            cbArithmeticOperation.ItemsSource = Model.dataListDisplay;
            cbArithmeticOperation.SelectedIndex = 0;
        }

        private void tbArithmeticOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Model.ArithmeticOperation = cbArithmeticOperation.SelectedIndex;
        }

        private void Field_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")))
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tbFirstField.Text != "")
                {
                    Model.numberFirst = Convert.ToDouble(tbFirstField.Text);
                }
                else
                {
                    Model.numberFirst = 0;
                }
                if (tbSecondlyField.Text != "")
                {
                    Model.numberSecondly = Convert.ToDouble(tbSecondlyField.Text);
                }
                else
                {
                    Model.numberSecondly = 0;
                }
                Model.CalculationResult = cbArithmeticOperation.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("При вычисление арифметической операции возникла ошибка");
            }
        }
    }
}
