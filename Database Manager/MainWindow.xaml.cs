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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Database_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Zwierzetum>zwierzeta { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            using (ZooContext _context = new ZooContext())
            {
                List<Zwierzetum> zwierzetaList = _context.Zwierzeta.ToList();
                zwierzeta = new ObservableCollection<Zwierzetum>(zwierzetaList);
            }

            Animals.ItemsSource = zwierzeta;

            zwierzeta.CollectionChanged += Zwierzeta_CollectionChanged;
        }

        private void Zwierzeta_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Animals.Items.Refresh();
        }


        private void Add_Record_Click(object sender, RoutedEventArgs e)
        {
            using (ZooContext _context = new ZooContext())
            {
                string typ = Typ.Text;
                string nazwaZwierzecia = NazwaZwierzecia.Text;
                string sposobOdzywiania = SposobOdzywiania.Text;

                bool recordExists = _context.Zwierzeta.Any(z => z.Nazwa.ToLower() == nazwaZwierzecia.ToLower());
                if (recordExists)
                {
                    MessageBox.Show("Record you that you wanna add, already exists.");
                    return;
                }

                Zwierzetum newZwierze = new Zwierzetum()
                {
                    Nazwa = nazwaZwierzecia,
                    Typ = typ,
                    SposobOdzywiania = sposobOdzywiania
                };

                _context.Zwierzeta.Add(newZwierze);
                _context.SaveChanges();

                switch (typ.ToLower())
                {
                    case "ssak":
                        Ssaki newSsak = new Ssaki
                        {
                            ZwierzeId = newZwierze.Id,
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania

                        };
                        _context.Ssakis.Add(newSsak);
                        break;

                    case "gad":
                        Gady newGad = new Gady
                        {
                            ZwierzeId = newZwierze.Id,
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania
                        };
                        _context.Gadies.Add(newGad);
                        break;

                    case "ptak":
                        Ptaki newPtak = new Ptaki
                        {
                            ZwierzeId = newZwierze.Id,
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania
                        };
                        _context.Ptakis.Add(newPtak);
                        break;

                    case "plaz":
                        Plazy newPlaz = new Plazy
                        {
                            ZwierzeId = newZwierze.Id,
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania
                        };
                        _context.Plazies.Add(newPlaz);
                        break;
                }

                _context.SaveChanges();

                var updatedZwierzetaList = _context.Zwierzeta.ToList();
                zwierzeta.Clear();
                foreach (var item in updatedZwierzetaList)
                {
                    zwierzeta.Add(item);
                }

                MessageBox.Show("Record added successfully.");

                NazwaZwierzecia.Text = "";
                Typ.Text = "";
                SposobOdzywiania.Text = "";
            }
        }


        private void Delete_Record_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(DeleteRecord.Text, out int id))
            {
                using (ZooContext _context = new ZooContext())
                {
                    var zwierzeToDelete = _context.Zwierzeta.Find(id);

                    if (zwierzeToDelete != null)
                    {
                        _context.Zwierzeta.Remove(zwierzeToDelete);
                        _context.SaveChanges();
                     
                        var updatedZwierzetaList = _context.Zwierzeta.ToList();
                        zwierzeta.Clear();
                        foreach (var item in updatedZwierzetaList)
                        {
                            zwierzeta.Add(item);
                        }

                        MessageBox.Show("Record deleted successfully.");
                        DeleteRecord.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified ID.");
                        DeleteRecord.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID value entered.");
                DeleteRecord.Text = "";
            }
        }

        private void NextWindow_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
            Close();
        }
    }
}
