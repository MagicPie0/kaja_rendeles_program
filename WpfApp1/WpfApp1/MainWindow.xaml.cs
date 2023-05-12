﻿using System;
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
            //design főoldal
            regisztralas.Visibility = Visibility.Visible;
            eloetelek.Visibility = Visibility.Hidden;
            levesek.Visibility = Visibility.Hidden;
            foetelek.Visibility = Visibility.Hidden;
            desszertek.Visibility = Visibility.Hidden;
            uditok.Visibility = Visibility.Hidden;
            hiba.Visibility = Visibility.Hidden;
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek_jelzok)
            {
                item.Visibility = Visibility.Hidden;
            }
            vissza.Visibility = Visibility.Hidden;
            tovabb.Visibility = Visibility.Hidden;
            fo_button.Visibility = Visibility.Hidden;
            coupon_button.Visibility = Visibility.Hidden;
            account_gomb.Visibility = Visibility.Hidden;
            kosar_button.Visibility = Visibility.Hidden;
            kijelzo.Content = "Regisztrálás";
            felhasznalonev_input.Focus();
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
                levesek.Visibility = Visibility.Visible;
                foetelek.Visibility = Visibility.Hidden;
                desszertek.Visibility = Visibility.Hidden;
                uditok.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Levesek";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = true;
                foetel_jelzo.IsChecked = false;
                desszert_jelzo.IsChecked = false;
                udito_jelzo.IsChecked = false;
            }
            else if(levesek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                levesek.Visibility = Visibility.Hidden;
                foetelek.Visibility = Visibility.Visible;
                desszertek.Visibility = Visibility.Hidden;
                uditok.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Főétel";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = false;
                foetel_jelzo.IsChecked = true;
                desszert_jelzo.IsChecked = false;
                udito_jelzo.IsChecked = false;
            }
            else if(foetelek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                levesek.Visibility = Visibility.Hidden;
                foetelek.Visibility = Visibility.Hidden;
                desszertek.Visibility = Visibility.Visible;
                uditok.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Desszertek";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = false;
                foetel_jelzo.IsChecked = false;
                desszert_jelzo.IsChecked = true;
                udito_jelzo.IsChecked = false;
            }
            else if(desszertek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                levesek.Visibility = Visibility.Hidden;
                foetelek.Visibility = Visibility.Hidden;
                desszertek.Visibility = Visibility.Hidden;
                uditok.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Hidden;
                kijelzo.Content = "Üdítők";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = false;
                foetel_jelzo.IsChecked = false;
                desszert_jelzo.IsChecked = false;
                udito_jelzo.IsChecked = true;
            }
            

        }

        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            if (levesek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Visible;
                levesek.Visibility = Visibility.Hidden;
                foetelek.Visibility = Visibility.Hidden;
                desszertek.Visibility = Visibility.Hidden;
                uditok.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Hidden;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Előételek";
                eloetel_jelzo.IsChecked = true;
                leves_jelzo.IsChecked = false;
                foetel_jelzo.IsChecked = false;
                desszert_jelzo.IsChecked = false;
            }
            else if(foetelek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                levesek.Visibility = Visibility.Visible;
                foetelek.Visibility = Visibility.Hidden;
                desszertek.Visibility = Visibility.Hidden;
                uditok.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;

                kijelzo.Content = "Levesek";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = true;
                foetel_jelzo.IsChecked = false;
                desszert_jelzo.IsChecked = false;
                udito_jelzo.IsChecked = false;
            }
            else if(desszertek.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                levesek.Visibility = Visibility.Hidden;
                foetelek.Visibility = Visibility.Visible;
                desszertek.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Főételek";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = false;
                foetel_jelzo.IsChecked = true;
                desszert_jelzo.IsChecked = false;
                udito_jelzo.IsChecked = false;
            }
            else if(uditok.IsVisible == true)
            {
                eloetelek.Visibility = Visibility.Hidden;
                levesek.Visibility = Visibility.Hidden;
                foetelek.Visibility = Visibility.Hidden;
                desszertek.Visibility = Visibility.Visible;
                uditok.Visibility = Visibility.Hidden;
                vissza.Visibility = Visibility.Visible;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Desszertek";
                eloetel_jelzo.IsChecked = false;
                leves_jelzo.IsChecked = false;
                foetel_jelzo.IsChecked = false;
                desszert_jelzo.IsChecked = true;
                udito_jelzo.IsChecked = false;
            }
            
        }
        //design főoldal

        //regisztrációs oldal
        private void regisztralas_gomb_Click(object sender, RoutedEventArgs e)
        {
            //design

            //design
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
                    engedély++; //1
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

            if (hiba.IsVisible == true)
            {
                regisztralas_gomb.IsEnabled = false;
                bejelentkezes_gomb.IsEnabled = false;
                felhasznalonev_input.IsEnabled = false;
                email_input.IsEnabled = false;
                jelszo1_input.IsEnabled = false;
                jelszo2_input.IsEnabled = false;
                eletkor_input.IsEnabled = false;
                engedély = 0;
            }
            else
            {
                regisztralas_gomb.IsEnabled = true;
                bejelentkezes_gomb.IsEnabled = true;
                felhasznalonev_input.IsEnabled = true;
                email_input.IsEnabled = true;
                jelszo1_input.IsEnabled = true;
                jelszo2_input.IsEnabled = true;
                eletkor_input.IsEnabled = true;
                if (engedély == 5)
                {
                    eloetelek.Visibility = Visibility.Visible;
                    kijelzo.Content = "Előételek";
                    eloetel_jelzo.IsChecked = true;
                    eloetel_jelzo.Visibility = Visibility.Visible;
                    leves_jelzo.Visibility = Visibility.Visible;
                    foetel_jelzo.Visibility = Visibility.Visible;
                    desszert_jelzo.Visibility = Visibility.Visible;
                    udito_jelzo.Visibility = Visibility.Visible;
                    tovabb.Visibility = Visibility.Visible;
                    fo_button.Visibility = Visibility.Visible;
                    coupon_button.Visibility = Visibility.Visible;
                    account_gomb.Visibility = Visibility.Visible;
                    kosar_button.Visibility = Visibility.Visible;

                    regisztralas_kep_fo.Visibility = Visibility.Hidden;
                    regisztralas.Visibility = Visibility.Hidden;
                    bejelentkezes_gomb.Visibility = Visibility.Hidden;
                }
                else
                {
                    return;
                }
            }

            //ellenőrzés
            //minden féle mentés fájlba meg ellenőrzések
        }

        private void rendben_gomb_Click(object sender, RoutedEventArgs e)
        {
            hiba.Visibility = Visibility.Hidden;
            regisztralas_gomb.IsEnabled = true;
            bejelentkezes_gomb.IsEnabled = true;
            felhasznalonev_input.IsEnabled = true;
            email_input.IsEnabled = true;
            jelszo1_input.IsEnabled = true;
            jelszo2_input.IsEnabled = true;
            eletkor_input.IsEnabled = true;

            felhasznalonev_input.Text = null;
            email_input.Text = null;
            jelszo1_input.Password = null;
            jelszo2_input.Password = null;
            eletkor_input.Text = null;
        }
        //regisztrációs oldal
    }
}