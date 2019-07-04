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

namespace VoIPCall
{
    /// <summary>
    /// Interaction logic for CallingNotification.xaml
    /// </summary>
    public partial class CallingNotification : Window
    {
        public CallingNotification()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
