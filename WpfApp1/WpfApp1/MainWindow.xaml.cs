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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            eloetelek.Visibility = Visibility.Visible;
            eloetel_jelzo.IsChecked = true;
            vissza.Visibility = Visibility.Hidden;
        }
        //design 
        private void kosar_button_Click(object sender, RoutedEventArgs e)
        {
            kosar.Visibility = Visibility.Visible;
            var etelek = new[] { etel1_hatter, etel2_hatter, etel3_hatter,
                                 etel4_hatter, etel5_hatter, etel6_hatter,};
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek)
            {
                item.Visibility = Visibility.Hidden;
            }
            foreach (var item in etelek_jelzok)
            {
                item.Visibility = Visibility.Hidden;
            }


        }

        private void fo_button_Click(object sender, RoutedEventArgs e)
        {
            var etelek = new[] { etel1_hatter, etel2_hatter, etel3_hatter,
                                 etel4_hatter, etel5_hatter, etel6_hatter};
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek)
            {
                item.Visibility = Visibility.Visible;
            }
            foreach (var item in etelek_jelzok)
            {
                item.Visibility = Visibility.Hidden;
            }

            kosar.Visibility = Visibility.Hidden;
            fooldal.Visibility = Visibility.Visible;
        }

        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
            if (eloetelek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                kijelzo.Content = "Levesek";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = true;
            }
        }

        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            if (eloetelek.IsVisible == false)
            {
                eloetelek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Hidden;
                kijelzo.Content = "Előételek";
                eloetel_jelzo.IsChecked = true;
                leves_jelzo.IsChecked = false;
            }
        }
        //design
    }
}
