using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PROGPOEPart1
{
    /// <summary>
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Window
    {

        public int timer = 0;
        private DispatcherTimer Timer;

        
        public LandingPage()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();  
         
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer++;
            tbTimer.Text = timer.ToString();
            
            pbLoad.Value= pbLoad.Value+33;
             
            if (timer == 4)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Hide();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddModule am = new AddModule();
            am.Show();
        }

        private void btnManageHours_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();

        }
    }
}
