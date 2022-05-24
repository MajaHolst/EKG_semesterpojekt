using RPI;
using RPI.Controller;
using RPI.Display;
using RPI.Heart_Rate_Monitor;
using RPI.IO;
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
using LiveCharts.Wpf;
using LiveCharts;
using Logic;

namespace EKG_semesterprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GrafWindow grafWindow;
        private LoginWindow loginWindow;
        private LogicClass logicRef;
        private int Id { get; set; }
        

        public MainWindow()
        {
            InitializeComponent();
            //loginWindow = new LoginWindow();
            logicRef = new LogicClass();
            //grafWindow = new GrafWindow(logicRef);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Hide();
            //loginWindow.ShowDialog();
            grafWindow.ShowDialog();

        }

        private void AnalyserDataBT_Click(object sender, RoutedEventArgs e)
        {
            grafWindow = new GrafWindow();
            grafWindow.ShowDialog();
        }
    }
}
