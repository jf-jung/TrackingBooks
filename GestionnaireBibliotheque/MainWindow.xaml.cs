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

namespace GestionnaireBibliotheque
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.WindowState = WindowState.Maximized;
            InitializeComponent();
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {

            AddBookLayout addBookWindow = new AddBookLayout();
            Window win = new Window();
            win.Content = addBookWindow;
            win.SizeToContent = SizeToContent.WidthAndHeight;
            win.ResizeMode = System.Windows.ResizeMode.NoResize;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.ShowDialog();
        
         
        }

        private void lendBook_Click(object sender, RoutedEventArgs e)
        {
            PretGeneral p = new PretGeneral();
            Window w = new Window();

            w.Content = p;
            w.Title = "Prêter un livre";
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;

            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            w.ShowDialog();
        }

        private void getBackBook_Click(object sender, RoutedEventArgs e)
        {
            PretGeneral p = new PretGeneral();
            Window w = new Window();

            w.Content = p;
            w.Title = "Retour d'un livre";
            w.SizeToContent = SizeToContent.WidthAndHeight;
            w.ResizeMode = System.Windows.ResizeMode.NoResize;

            w.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            w.ShowDialog();
        }
    }
}
