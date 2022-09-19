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
using CalcsDLL;

namespace PROGPOEPart1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string moduleCodeTransfer;

        public MainWindow()
        {
            InitializeComponent();

        }

        Module module = new Module();

        public string ModuleCodeTransfer { get => moduleCodeTransfer; set => moduleCodeTransfer = value; }

        private void btnAddModule_Click(object sender, RoutedEventArgs e)
        {
            if ((tbModuleCode.Text == "") && (tbModuleName.Text == "") && (tbCredits.Text == "") && (tbClassHrs.Text == ""))
            {
                tbError.Text = "Please complete all necessary fields";
            }
            else
            {
                tbError.Text = "";
                module.ModuleCode = tbModuleCode.Text;
                module.ModuleName = tbModuleName.Text;
                module.Credits = Convert.ToInt32(tbCredits.Text);
                module.ClassesPerWeek = Convert.ToInt32(tbClassHrs.Text);

                dgModule.Items.Add(module);

            }







        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown();
            }

        }

        private void btnAddStudy_Click(object sender, RoutedEventArgs e)
        {
            tbCourseCode.Text = dpStudy.Text;
        }

        private void imgExit_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown();
            }

        }
    }
}
