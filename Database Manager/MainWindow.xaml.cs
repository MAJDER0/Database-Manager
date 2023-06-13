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
        public List<Zwierzetum>zwierzeta { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            using (ZooContext _context = new ZooContext())
            {
                zwierzeta = _context.Zwierzeta.ToList();
            }

            Animals.ItemsSource = zwierzeta;
        }

        private void Add_Record_Click(object sender, RoutedEventArgs e)
        {
            using (ZooContext _context = new ZooContext())
            {
                string typ = Typ.Text.ToLower();
                string nazwaZwierzecia = NazwaZwierzecia.Text.ToLower();
                string sposobOdzywiania = SposobOdzywiania.Text.ToLower();

                Zwierzetum newZwierze = new Zwierzetum()
                {
                    Nazwa = nazwaZwierzecia,
                    Typ = typ,
                    SposobOdzywiania = sposobOdzywiania
                };

                // Add the new Gady object to the DbSet
                _context.Zwierzeta.Add(newZwierze);

                switch (typ)
                {
                    case "ssak":
                        Ssaki newSsak = new Ssaki
                        {
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania

                        };
                        _context.Ssakis.Add(newSsak);
                        break;

                    case "gad":
                        Gady newGad = new Gady
                        {
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania
                        };
                        _context.Gadies.Add(newGad);
                        break;

                    case "ptak":
                        Ptaki newPtak = new Ptaki
                        {
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania
                        };
                        _context.Ptakis.Add(newPtak);
                        break;

                    case "plaz":
                        Plazy newPlaz = new Plazy
                        {
                            Nazwa = nazwaZwierzecia,
                            SposobOdzywiania = sposobOdzywiania
                        };
                        _context.Plazies.Add(newPlaz);
                        break;
                }

                _context.SaveChanges();
            }

        }
    }
}
