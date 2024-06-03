using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

namespace IT3B_Kostky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Kostka[] kostky = new Kostka[]
        {
            new Kostka(),
            new Kostka(),
            new Kostka(),
            new Kostka(),
            new Kostka(),
            new Kostka()
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_hod_Click(object sender, RoutedEventArgs e)
        {
            foreach (var kostka in kostky)
            {
                kostka.Hod();
            }
            ZobrazKostky();
            UlozHodnoty();
        }
        private void ZobrazKostku(Label label, int cislo)
        {
            label.Content = cislo.ToString();

        }
        private void ZobrazKostky()
        {
            ZobrazKostku(lbl1, kostky[0].Hodnota);
            ZobrazKostku(lbl2, kostky[1].Hodnota);
            ZobrazKostku(lbl3, kostky[2].Hodnota);
            ZobrazKostku(lbl4, kostky[3].Hodnota);
            ZobrazKostku(lbl5, kostky[4].Hodnota);
            ZobrazKostku(lbl6, kostky[5].Hodnota);
        }
        private void UlozHodnoty()
        {
            string json = JsonConvert.SerializeObject(kostky);
            File.WriteAllText("data.json", json);


        }
    }
}