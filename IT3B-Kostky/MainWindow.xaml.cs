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
            ZobrazKostkzu(lbl1, kostky[0].Hodnota);
            ZobrazKostkzu(lbl2, kostky[1].Hodnota);
            ZobrazKostkzu(lbl3, kostky[2].Hodnota);
            ZobrazKostkzu(lbl4, kostky[3].Hodnota);
            ZobrazKostkzu(lbl5, kostky[4].Hodnota);
            ZobrazKostkzu(lbl6, kostky[5].Hodnota);
        }
        private void ZobrazKostkzu(Label label, int cislo)
        {
            label.Content = cislo.ToString();
        }
    }
}