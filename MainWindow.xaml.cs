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

            //Application.Current.Shutdown();

            //AddModule am = new AddModule();
            //am.Show();
            //string moduleCode = am.tbModuleCode.Text;
            //tbModuleCodeMain.Text = moduleCode;
            //tbModuleName.Text = moduleCodeTransfer;

            module.ModuleCode = tbModuleCode.Text;
            module.ModuleName = tbModuleName.Text;
            module.Credits = Convert.ToInt32(tbCredits.Text);
            module.NumWeeks = Convert.ToInt32(tbClassHrs.Text);

            dgModule.Items.Add(module);

        }
    }
}
