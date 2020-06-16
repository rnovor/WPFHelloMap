﻿using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace WPFHelloMap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Location redrock = new Location(37.39366, -122.07888);
            Map.SetView(redrock, 20);
        }

        public void Map_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Location ll = Map.ViewportPointToLocation(e.GetPosition(Map));
            MessageBox.Show("Lat: " + ll.Latitude + ", Lon:" + ll.Longitude);
        }
    }
}
