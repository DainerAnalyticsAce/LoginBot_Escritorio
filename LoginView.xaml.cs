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

namespace DduranmeBotApp.Vistas
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //Codigo para boton minimizar -
            WindowState = WindowState.Minimized;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            //Codigo para boton cerrar x
            Application.Current.Shutdown();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
