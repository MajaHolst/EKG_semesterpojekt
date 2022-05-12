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
using System.Windows.Shapes;
using LiveCharts.Wpf;
using LiveCharts;
using Logic_tier2;
using Logic_tier;

namespace EKG_semesterprojekt
{
    /// <summary>
    /// Interaction logic for GrafWindow.xaml
    /// </summary>
    public partial class GrafWindow : Window
    {
        private LogicClass _logic;
        public ChartValues<double> YValues { get; set; }

        public GrafWindow()
        {

            InitializeComponent();
            _logic = new LogicClass();
            YValues = new ChartValues<double>();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in _logic.getEKGData1())
            {
                YValues.Add(item.EKG);
            }
            DataContext = this;
        }

        private void offDiagnoseBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
