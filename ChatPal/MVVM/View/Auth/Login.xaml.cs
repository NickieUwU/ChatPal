﻿using ChatPal.db;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ChatPal.MVVM.View.Auth
{
    /// <summary>
    /// Interakční logika pro Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void login(object sender, RoutedEventArgs e)
        {
            Db.logUser(txtUsername.Text, pswPassword.Password);
            Debug.WriteLine(Db.logUser(txtUsername.Text, pswPassword.Password).ToString());
        }
    }
}
