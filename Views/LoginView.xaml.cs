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
using System.Windows.Shapes;
using WpfDemo.ViewModels;

namespace WpfDemo.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private LoginViewModel vm;
        public LoginView()
        {
            InitializeComponent();
            vm = new LoginViewModel();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vm.Login();
        }

        private void PasswordBox_PasswordChanged(object sender, EventArgs e)
        {
            vm.Password = ((PasswordBox)sender).Password;
        }
    }
}
