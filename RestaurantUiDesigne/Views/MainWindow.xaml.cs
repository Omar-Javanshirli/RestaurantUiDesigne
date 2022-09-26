﻿using RestaurantUiDesigne.ViewModels;
using System;
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

namespace RestaurantUiDesigne
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public WrapPanel CalculateWrap { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var vm = new AppViewModel(this);
            App.CalculateWrap = calcualeteWrapPanel;
            this.DataContext = vm;
        }
    }
}
