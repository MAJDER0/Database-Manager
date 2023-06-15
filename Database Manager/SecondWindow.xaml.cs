using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Database_Manager.Models;

namespace Database_Manager
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();

            List<string> zwierzeta = new List<string>
            {
                "Ssaki",
                "Gady",
                "Ptaki",
                "Ryby",
                "Płazy"
            };

            ChooseTable.ItemsSource = zwierzeta;
        }

        private void ChooseTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedTable = ChooseTable.SelectedItem as string;

            switch (selectedTable)
            {
                case "Ssaki":
                    using (var context = new ZooContext())
                    {
                        List<Ssaki> ssaki = context.Ssakis.ToList();
                        dataGrid.ItemsSource = ssaki;
                    }
                    break;
                case "Gady":
                    using (var context = new ZooContext())
                    {
                        List<Gady> gadies = context.Gadies.ToList();
                        dataGrid.ItemsSource = gadies;
                    }
                    break;
                case "Ryby":
                    using (var context = new ZooContext())
                    {
                        List<Ryby> ryby = context.Rybies.ToList();
                        dataGrid.ItemsSource = ryby;
                    }
                    break;
                case "Płazy":
                    using (var context = new ZooContext())
                    {
                        List<Plazy> plazy = context.Plazies.ToList();
                        dataGrid.ItemsSource = plazy;
                    }
                    break;
                case "Ptaki":
                    using (var context = new ZooContext())
                    {
                        List<Ptaki> ptaki = context.Ptakis.ToList();
                        dataGrid.ItemsSource = ptaki;
                    }
                    break;
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
