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

namespace Expenselt
{
    /// <summary>
    /// Логика взаимодействия для ExpenseltHome.xaml
    /// </summary>
    public partial class ExpenseltHome : Page
    {
        private void Button_Click(object sender, RoutedEventArgs e) { //View Expense Report ExpenseReportPage 
            ExpenseReportPage = new ExpenseReportPage(); 
            this.NavigationService.Navigate(ExpenseReportPage); 
        }  

        public ExpenseltHome()
        {
            InitializeComponent();
        }
    }
}
