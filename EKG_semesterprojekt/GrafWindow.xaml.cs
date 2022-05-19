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
using Data_tier;
using LiveCharts.Wpf;
using LiveCharts;
using Logic;

namespace EKG_semesterprojekt
{
    /// <summary>
    /// Interaction logic for GrafWindow.xaml
    /// </summary>
    public partial class GrafWindow : Window
    {
        private LogicClass _logic;
        //public ChartValues<DataBase> YValues { get; set; }
        public SeriesCollection Data { get; set; }
        public string[] Xakse { get; set; }
        public Func<double, string> Yakse { get; set; }

        public GrafWindow(LogicClass logic, int id)
        {
            InitializeComponent();
            _logic = logic;
            //YValues = new ChartValues<DataBase>();

            List<EKGData> ekgData = logic.GetDataBases(id);
            ChartValues<double> ekg = new ChartValues<double>();

            List<string> ekgDates = new List<string>();

            foreach (var item in ekgData)
            {
                ekg.Add(item.EKG);
                //ekgDates.Add(item.Date.ToString("d.MM").ToUpper());
            }

            Data = new SeriesCollection
            {
                new LineSeries
                {
                    Values = ekg,
                    Fill = Brushes.Transparent,
                    Title = "EKG fra Physionet",
                },

            };
            //Xakse = ekgDates.ToArray();
            Yakse = value => value.ToString("0.0");
            DataContext = this;

        }

       

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    foreach (var item in _logic.GetDataBases())
        //    {
        //        YValues.Add(item.GetEKGData());
        //    }
        //    DataContext = this;
        //}

        private void offDiagnoseBT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
