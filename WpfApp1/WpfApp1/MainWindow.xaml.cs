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
using System.IO;

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
            //design főoldal
            
            var oldalak = new[] { eloetelek, levesek, foetelek, desszertek, uditok, hiba, bejelentkezes,
                                  elfelejtett_jelszo_oldal, jelszo};

            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};

            var gombok = new[] { vissza, tovabb, fo_button, coupon_button, account_gomb, kosar_button };


            foreach (var item in oldalak) item.Visibility = Visibility.Hidden;
            foreach (var item in etelek_jelzok) item.Visibility = Visibility.Hidden;
            foreach (var item in gombok) item.Visibility = Visibility.Hidden;

            kijelzo.Content = "Regisztrálás";
            felhasznalonev_input.Focus();
            regisztralas.Visibility = Visibility.Visible;
            regisztralas_kep_fo.Visibility = Visibility.Visible;
            bejelentkezes_gomb.Visibility = Visibility.Visible;

            //design főoldal
        }
        //design főoldal
        private void kosar_button_Click(object sender, RoutedEventArgs e)
        {
            kosar.Visibility = Visibility.Visible;
            var etelek = new[] { etel1_hatter, etel2_hatter, etel3_hatter,
                                 etel4_hatter, etel5_hatter, etel6_hatter,};
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek) item.Visibility = Visibility.Hidden;
            foreach (var item in etelek_jelzok) item.Visibility = Visibility.Hidden;


        }

        private void fo_button_Click(object sender, RoutedEventArgs e)
        {
            var etelek = new[] { etel1_hatter, etel2_hatter, etel3_hatter,
                                 etel4_hatter, etel5_hatter, etel6_hatter};
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek) item.Visibility = Visibility.Visible;
            foreach (var item in etelek_jelzok) item.Visibility = Visibility.Hidden;

            kosar.Visibility = Visibility.Hidden;
            fooldal.Visibility = Visibility.Visible;
        }

        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
            if (eloetelek.IsVisible == true)
            {
                var eltun = new[] { eloetelek, foetelek, desszertek, uditok };
                var jelzok = new[] { eloetel_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;   
                foreach(var item in jelzok) item.IsChecked = false;
                
                levesek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Levesek";
                leves_jelzo.IsChecked = true;
            }
            else if(levesek.IsVisible == true)
            {
                var eltun = new[] { eloetelek, levesek, desszertek, uditok };
                var jelzok = new[] { eloetel_jelzo, leves_jelzo, desszert_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                foetelek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Főétel";
                foetel_jelzo.IsChecked = true;
            }
            else if(foetelek.IsVisible == true)
            {
                var eltun = new[] { eloetelek, levesek, foetelek, uditok };
                var jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                desszertek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Desszertek";
                desszert_jelzo.IsChecked = true;
            }
            else if(desszertek.IsVisible == true)
            {
                var eltun = new[] { eloetelek, levesek, foetelek, desszertek };
                var jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo, desszert_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                uditok.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Hidden;
                kijelzo.Content = "Üdítők";
                udito_jelzo.IsChecked = true;
            }
        }

        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            if (levesek.IsVisible == true)
            {
                var eltun = new[] {levesek, foetelek, desszertek, uditok };
                var jelzok = new[] {leves_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                eloetelek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Hidden;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Előételek";
                eloetel_jelzo.IsChecked = true;
            }
            else if(foetelek.IsVisible == true)
            {
                var eltun = new[] { eloetelek, foetelek, desszertek, uditok };
                var jelzok = new[] { eloetel_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                levesek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Levesek";
                leves_jelzo.IsChecked = true;
            }
            else if(desszertek.IsVisible == true)
            {
                var eltun = new[] { eloetelek, levesek, desszertek, uditok };
                var jelzok = new[] { eloetel_jelzo, leves_jelzo, desszert_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                foetelek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Főételek";
                foetel_jelzo.IsChecked = true;
            }
            else if(uditok.IsVisible == true)
            {
                var eltun = new[] { eloetelek, levesek, foetelek, uditok };
                var jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                desszertek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Desszertek";
                desszert_jelzo.IsChecked = true;
            }
        }
        //design főoldal

        //regisztrációs oldal

        static string Jelszo_titkositas(string jelszo)
        {
            char[] titkositott_jelszo = jelszo.ToCharArray();

            for (int i = 0; i < titkositott_jelszo.Length; i++)
            {
                titkositott_jelszo[i] = (char)(titkositott_jelszo[i] + 10);
            }
            string titkos_jelszo = new string(titkositott_jelszo);
            return titkos_jelszo;
        }

        static string Jelszo_visszaallitas(string nev)
        {
            string x = File.ReadAllText(nev + ".txt");
            string[] adatok = x.Split(';');

            char[] visszaforditando_jelszo = adatok[3].ToCharArray();

            for (int i = 0; i < visszaforditando_jelszo.Length; i++)
            {
                visszaforditando_jelszo[i] = (char)(visszaforditando_jelszo[i] - 10);
            }
            string titkos_jelszo = new string(visszaforditando_jelszo);
            return titkos_jelszo;
        }

        private void regisztralas_gomb_Click(object sender, RoutedEventArgs e)
        {
            //ellenőrzés
            int engedély = 0;
            string nev = felhasznalonev_input.Text;
            string be_kor = eletkor_input.Text;
            int kor;
            string email = email_input.Text;
            string jelszo1 = jelszo1_input.Password;
            string jelszo2 = jelszo2_input.Password;

            if (nev == "" & be_kor == "" & email == "" & jelszo1 == "" & jelszo2 == "")
            {
                hiba.Visibility = Visibility.Visible;
                hiba_out.Text = "Nem lehet üresen hagyott mező!";
                return;
            }
            else
            {
                if (int.TryParse(be_kor, out kor))
                {
                    //tovább enged
                    if (kor > 0 & kor < 120)
                    {
                        //tovább enged
                        engedély++; //1
                    }
                    else
                    {
                        //hiba
                        hiba.Visibility = Visibility.Visible;
                        hiba_out.Text = "A kornak adott érték szürreális!";
                        return;
                    }
                }
                else
                {
                    //hiba
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "A kor nem tartalmazhat nem szám karaktereket!";
                    return;
                }

                if (email.Contains("@") == true)
                {
                    //tovább enged
                    engedély++; //2
                }
                else
                {
                    //hiba
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "Az email címnek tartalmaznia kell @ karaktert!";
                    return;
                }

                if (email.Contains(".") == true)
                {
                    //tovább enged
                    engedély++; //3
                }
                else
                {
                    //hiba
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "Az email címnek tartalmaznia kell . karaktert!";
                    return;
                }

                if (jelszo1 == jelszo2)
                {
                    engedély++; //4
                    //tovább enged
                    if (jelszo1.Length >= 8)
                    {
                        //tovább enged
                        engedély++; //5
                    }
                    else
                    {
                        //hiba
                        hiba.Visibility = Visibility.Visible;
                        hiba_out.Text = "A jelszóknak legalább 8 karakteresnek kell lennie!";
                        return;
                    }
                }
                else
                {
                    //hiba
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "A két jelszónak egyeznie kell!";
                    return;
                }
            }
            var gombok = new[] { regisztralas_gomb, bejelentkezes_gomb};
            var beviteli_mezok = new[] { felhasznalonev_input, email_input, eletkor_input };
            var jelszavak = new[] { jelszo1_input, jelszo2_input };
            if (hiba.IsVisible == true)
            {
                foreach(var item in gombok) item.IsEnabled = false;
                foreach (var item in beviteli_mezok) item.IsEnabled = false;
                foreach (var item in jelszavak) item.IsEnabled = false;

                engedély = 0;
                felhasznalonev_input.Focus();
            }
            else
            {
                foreach (var item in gombok) item.IsEnabled = true;
                foreach (var item in beviteli_mezok) item.IsEnabled = true;
                foreach (var item in jelszavak) item.IsEnabled = true;

                if (engedély == 5)
                {
                    var jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };
                    var gombok2 = new[] { tovabb, fo_button, coupon_button, account_gomb, kosar_button };

                    foreach (var item in jelzok) item.Visibility = Visibility.Visible;
                    foreach (var item in gombok2) item.Visibility = Visibility.Visible;

                    eloetelek.Visibility = Visibility.Visible;
                    kijelzo.Content = "Előételek";
                    eloetel_jelzo.IsChecked = true;
                    regisztralas_kep_fo.Visibility = Visibility.Hidden;
                    regisztralas.Visibility = Visibility.Hidden;
                    bejelentkezes_gomb.Visibility = Visibility.Hidden;

                    //fájlba mentés
                    string file_name = nev + ".txt";
                    File.WriteAllText(file_name, nev + ";" + kor + ";" + email + ";" + Jelszo_titkositas(jelszo1));
                    //fájlba mentés
                }
                else
                {
                    return;
                }
            }
            //ellenőrzés
        }

        private void rendben_gomb_Click(object sender, RoutedEventArgs e)
        {
            var gombok = new[] { regisztralas_gomb, bejelentkezes_gomb};
            var inputok = new[] { email_input, eletkor_input, eletkor_input };
            var jelszavak = new[] { jelszo1_input, jelszo2_input };

            foreach (var item in gombok) item.IsEnabled = true;
            foreach (var item in inputok) item.IsEnabled = true;
            foreach (var item in jelszavak) item.IsEnabled = true;

            foreach (var item in inputok) item.Text = null;
            foreach (var item in jelszavak) item.Password = null;

            felhasznalonev_input.Text = null;
            hiba.Visibility = Visibility.Hidden;
        }
        //regisztrációs oldal
        //bejelentekzős oldal
        private void bejelentkezes_gomb_Click(object sender, RoutedEventArgs e)
        {
            regisztralas.Visibility = Visibility.Hidden;
            bejelentkezes.Visibility = Visibility.Visible;
            kijelzo.Content = "Bejelentkezés";
        }
        static string nev = ""; 
        private void bejelentekezes_fo_gomb_Click(object sender, RoutedEventArgs e)
        {
            nev = felhasznalonev_input_bejelenktezes.Text;
            string jelszo = jelszo_input_bejelentkezes.Password;

            string titkos_jelszo = Jelszo_titkositas(jelszo);

            if (File.Exists(nev + ".txt"))
            {
                string x = File.ReadAllText(nev + ".txt");
                string[] adatok = x.Split(';');
                if (adatok[3] == titkos_jelszo)
                {
                    //tovább enged
                    var jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };
                    var gombok = new[] { tovabb, fo_button, coupon_button, account_gomb, kosar_button };
                    foreach(var item in jelzok) item.Visibility = Visibility.Visible;
                    foreach (var item in gombok) item.Visibility = Visibility.Visible;

                    eloetelek.Visibility = Visibility.Visible;
                    kijelzo.Content = "Előételek";
                    eloetel_jelzo.IsChecked = true;
                    bejelentkezes.Visibility = Visibility.Hidden;
                }
                else
                {
                    //hiba
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "Rossz jelszó!";
                    return;
                }
            }
            else
            {
                //hiba
                hiba.Visibility = Visibility.Visible;
                hiba_out.Text = "Nincs ilyen nevű fiók!";
                return;
            }
        }

        //bejelentkezős oldal
        //elfelejtett jelszo
        private void elfelejtett_jelszo_Click(object sender, RoutedEventArgs e)
        {
            bejelentkezes.Visibility = Visibility.Hidden;
            elfelejtett_jelszo_oldal.Visibility = Visibility.Visible;
            kijelzo.Content = "Elfelejtett jelszó";

            if (nev != "")
            {
                felhasznalonev_input_elfelejtett.Text = nev;
                email_input_elfelejtett.Focus();
            }
            else
            {
                felhasznalonev_input_elfelejtett.Focus();
            }
        }

        private void elfelejtett_fo_gomb_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(nev + ".txt"))
            {
                string x = File.ReadAllText(nev + ".txt");
                string[] adatok = x.Split(';');

                string email = email_input_elfelejtett.Text;

;               string titkos_jelszo = Jelszo_visszaallitas(nev);

                if (email == adatok[2])
                {
                    //tovább enged

                    jelszo.Visibility = Visibility.Visible;
                    jelszo_ki.Text = "A jelszó: " + titkos_jelszo;
                }
                else
                {
                    //hiba
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "Nincs ilyen email cím tárolva!";
                    return;
                }
            }
            else
            {
                //hiba
                hiba.Visibility = Visibility.Visible;
                hiba_out.Text = "Nincs ilyen nevű felhasználó!";
                return;
            }
        }

        private void vissza_a_bejelentkezes_oldalra_Click(object sender, RoutedEventArgs e)
        {
            jelszo.Visibility = Visibility.Hidden;
            elfelejtett_jelszo_oldal.Visibility = Visibility.Hidden;
            bejelentkezes.Visibility = Visibility.Visible;
            kijelzo.Content = "Bejelentkezés";
        }
        //elfelejtett jelszo
    }
}
