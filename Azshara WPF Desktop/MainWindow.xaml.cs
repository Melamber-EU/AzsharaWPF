using Azshara_WPF_Desktop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Azshara_WPF_Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable dtTimers = new DataTable();
        DataTable dtRaiders = new DataTable();
        DataTable dtSetup = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            SetupGrid();
        }

        private void SetupGrid()
        {
            
            List<RaidersM> raidersData = RaidersModels.GetRaiders();
            ObservableCollection<RaidersM> observableCollection = new ObservableCollection<RaidersM>();
            foreach (var record in raidersData)
            {
                observableCollection.Add(new RaidersM {
                    name = record.name
                });
            }
            //Bind the DataGrid to the customer data
            dgvSoaks.DataContext = observableCollection;
        }
    }
}
