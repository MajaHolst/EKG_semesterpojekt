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
using Logic_tier2;

namespace EKG_semesterprojekt
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private LogicLogin logicRef;
        private MainWindow mainWRef;

        public LoginWindow()
        {
            InitializeComponent();
            
        }
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string userName = userNameTB.Text;
            string passWord = PWTB.Text;
            //mainWRef.LoginOK = logicRef.checkLogin(brugernavn, adgangskode);

            //if (mainWRef.LoginOK == true)
            //{
            //    mainWRef.SocSecNB = brugernavn;
            //    Close();
            //    mainWRef.usernameTB.Text = brugernavn;
            //}
            //else
            //{
            //    MessageBox.Show("Dette login er ikke gyldigt. Prøv venligst igen.");
            //}
        }
    }
}
