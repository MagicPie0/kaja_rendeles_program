﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random random = new Random();
        static int[] szazalekok = { 10, 20, 30, 40, 50 };
        static int[] nevek = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
                               16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        static int index;
        static int index2;
        static string felhasznalo = "";
        //előételek
        static int Etel1_ar = 2000;
        static int Etel1_akcio = 0;

        static int Etel2_ar = 300;
        static int Etel2_akcio = 0;

        static int Etel3_ar = 3500;
        static int Etel3_akcio = 0;

        static int Etel4_ar = 4000;
        static int Etel4_akcio = 0;

        static int Etel5_ar = 6000;
        static int Etel5_akcio = 0;

        static int Etel6_ar = 6500;
        static int Etel6_akcio = 0;
        //előételek
        //levesek
        static int Etel7_ar = 8000;
        static int Etel7_akcio = 0;

        static int Etel8_ar = 8200;
        static int Etel8_akcio = 0;

        static int Etel9_ar = 8150;
        static int Etel9_akcio = 0;

        static int Etel10_ar = 8250;
        static int Etel10_akcio = 0;

        static int Etel11_ar = 8300;
        static int Etel11_akcio = 0;

        static int Etel12_ar = 7600;
        static int Etel12_akcio = 0;
        //levesek
        //főételek
        static int Etel13_ar = 4000;
        static int Etel13_akcio = 0;

        static int Etel14_ar = 5000;
        static int Etel14_akcio = 0;

        static int Etel15_ar = 5500;
        static int Etel15_akcio = 0;

        static int Etel16_ar = 6300;
        static int Etel16_akcio = 0;

        static int Etel17_ar = 3900;
        static int Etel17_akcio = 0;

        static int Etel18_ar = 4200;
        static int Etel18_akcio = 0;

        //főételek
        //desszertek
        static int Etel19_ar = 600;
        static int Etel19_akcio = 0;

        static int Etel20_ar = 1200;
        static int Etel20_akcio = 0;

        static int Etel21_ar = 2000;
        static int Etel21_akcio = 0;

        static int Etel22_ar = 300;
        static int Etel22_akcio = 0;

        static int Etel23_ar = 350;
        static int Etel23_akcio = 0;

        static int Etel24_ar = 700;
        static int Etel24_akcio = 0;
        //desszertek
        //üdítők
        static int Etel25_ar = 500;
        static int Etel25_akcio = 0;

        static int Etel26_ar = 450;
        static int Etel26_akcio = 0;

        static int Etel27_ar = 400;
        static int Etel27_akcio = 0;

        static int Etel28_ar = 700;
        static int Etel28_akcio = 0;

        static int Etel29_ar = 700;
        static int Etel29_akcio = 0;

        static int Etel30_ar = 800;
        static int Etel30_akcio = 0;
        //üdítők
        static List<string> etelek = new List<string>();
        static int ossz_db = 0;
        static int ossz_ar = 0;

        static int termek_kateegoriak = 0;
        static int termek_1 = 0;
        static int termek_2 = 0;
        static int termek_3 = 0;
        static int termek_4 = 0;

        public MainWindow()
        {
            InitializeComponent();
            //design főoldal

            var oldalak = new[] { eloetelek, levesek, foetelek, desszertek, uditok, hiba, bejelentkezes,
                                  elfelejtett_jelszo_oldal, jelszo, coupon, kosar, profil, profil_ok};

            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};

            var gombok = new[] { vissza, tovabb, fo_button, coupon_button, account_gomb, kosar_button };
            var szazalekok_gomb = new[] { akcio_etel1, akcio_etel2, akcio_etel3, akcio_etel4, akcio_etel5,
                                     akcio_etel6, akcio_etel7, akcio_etel8, akcio_etel9, akcio_etel10,
                                     akcio_etel11, akcio_etel12, akcio_etel13, akcio_etel14, akcio_etel15,
                                     akcio_etel16, akcio_etel17, akcio_etel18, akcio_etel19, akcio_etel20,
                                     akcio_etel21, akcio_etel22, akcio_etel23, akcio_etel24, akcio_etel25,
                                     akcio_etel26, akcio_etel27, akcio_etel28, akcio_etel29, akcio_etel30};

            foreach (var item in oldalak) item.Visibility = Visibility.Hidden;
            foreach (var item in etelek_jelzok) item.Visibility = Visibility.Hidden;
            foreach (var item in gombok) item.Visibility = Visibility.Hidden;
            foreach (var item in szazalekok_gomb) item.Visibility = Visibility.Hidden;

            kijelzo.Content = "Regisztrálás";
            felhasznalonev_input.Focus();
            regisztralas.Visibility = Visibility.Visible;
            regisztralas_kep_fo.Visibility = Visibility.Visible;
            bejelentkezes_gomb.Visibility = Visibility.Visible;

            //előételek
            termek ter1 = new termek(Etel1_ar, Etel1_akcio, "Bruschetta");
            etel1_ar.Content = "Ár: " + ter1.Ar + "Ft";
            etel1_nev.Content = ter1.Nev;

            termek ter2 = new termek(Etel2_ar, Etel2_akcio, "Pogácsa");
            etel2_ar.Content = "Ár: " + ter2.Ar + "Ft";
            etel2_nev.Content = ter2.Nev;

            termek ter3 = new termek(Etel3_ar, Etel3_akcio, "Szendvics");
            etel3_ar.Content = "Ár: " + ter3.Ar + "Ft";
            etel3_nev.Content = ter3.Nev;

            termek ter4 = new termek(Etel4_ar, Etel4_akcio, "Saláta");
            etel4_ar.Content = "Ár: " + ter4.Ar + "Ft";
            etel4_nev.Content = ter4.Nev;

            termek ter5 = new termek(Etel5_ar, Etel5_akcio, "Rántotta");
            etel5_ar.Content = "Ár: " + ter5.Ar + "Ft";
            etel5_nev.Content = ter5.Nev;

            termek ter6 = new termek(Etel6_ar, Etel6_akcio, "Fasírt");
            etel6_ar.Content = "Ár: " + ter6.Ar + "Ft";
            etel6_nev.Content = ter6.Nev;
            //előételek
            //levesek
            termek ter7 = new termek(Etel7_ar, Etel7_akcio, "Paradicsom leves");
            etel7_ar.Content = "Ár: " + ter7.Ar + "Ft";
            etel7_nev.Content = ter7.Nev;

            termek ter8 = new termek(Etel8_ar, Etel8_akcio, "Sajtleves");
            etel8_ar.Content = "Ár: " + ter8.Ar + "Ft";
            etel8_nev.Content = ter8.Nev;

            termek ter9 = new termek(Etel9_ar, Etel9_akcio, "Bableves");
            etel9_ar.Content = "Ár: " + ter9.Ar + "Ft";
            etel9_nev.Content = ter9.Nev;

            termek ter10 = new termek(Etel10_ar, Etel10_akcio, "Fokhagymaleves");
            etel10_ar.Content = "Ár: " + ter10.Ar + "Ft";
            etel10_nev.Content = ter10.Nev;

            termek ter11 = new termek(Etel11_ar, Etel11_akcio, "Halászlé");
            etel11_ar.Content = "Ár: " + ter11.Ar + "Ft";
            etel11_nev.Content = ter11.Nev;

            termek ter12 = new termek(Etel12_ar, Etel12_akcio, "Ramen");
            etel12_ar.Content = "Ár: " + ter12.Ar + "Ft";
            etel12_nev.Content = ter12.Nev;
            //levesek
            //főételek
            termek ter13 = new termek(Etel13_ar, Etel13_akcio, "Omelette");
            etel13_ar.Content = "Ár: " + ter13.Ar + "Ft";
            etel13_nev.Content = ter13.Nev;

            termek ter14 = new termek(Etel14_ar, Etel14_akcio, "Mac 'N' Cheese");
            etel14_ar.Content = "Ár: " + ter14.Ar + "Ft";
            etel14_nev.Content = ter14.Nev;

            termek ter15 = new termek(Etel15_ar, Etel15_akcio, "Köfte");
            etel15_ar.Content = "Ár: " + ter15.Ar + "Ft";
            etel15_nev.Content = ter15.Nev;

            termek ter16 = new termek(Etel16_ar, Etel16_akcio, "Fisch And Chips");
            etel16_ar.Content = "Ár: " + ter16.Ar + "Ft";
            etel16_nev.Content = ter16.Nev;

            termek ter17 = new termek(Etel17_ar, Etel17_akcio, "Steak");
            etel17_ar.Content = "Ár: " + ter17.Ar + "Ft";
            etel17_nev.Content = ter17.Nev;

            termek ter18 = new termek(Etel18_ar, Etel18_akcio, "Teriyaki Tofu");
            etel18_ar.Content = "Ár: " + ter18.Ar + "Ft";
            etel18_nev.Content = ter18.Nev;
            //főételek
            //desszertek
            termek ter19 = new termek(Etel19_ar, Etel19_akcio, "Fagylalt");
            etel19_ar.Content = "Ár: " + ter19.Ar + "Ft";
            etel19_nev.Content = ter19.Nev;

            termek ter20 = new termek(Etel20_ar, Etel20_akcio, "Torta");
            etel20_ar.Content = "Ár: " + ter20.Ar + "Ft";
            etel20_nev.Content = ter20.Nev;

            termek ter21 = new termek(Etel21_ar, Etel21_akcio, "Pite");
            etel21_ar.Content = "Ár: " + ter21.Ar + "Ft";
            etel21_nev.Content = ter21.Nev;

            termek ter22 = new termek(Etel22_ar, Etel22_akcio, "Macaron");
            etel22_ar.Content = "Ár: " + ter22.Ar + "Ft";
            etel22_nev.Content = ter22.Nev;

            termek ter23 = new termek(Etel23_ar, Etel23_akcio, "Süti");
            etel23_ar.Content = "Ár: " + ter23.Ar + "Ft";
            etel23_nev.Content = ter23.Nev;

            termek ter24 = new termek(Etel24_ar, Etel24_akcio, "Fánk");
            etel24_ar.Content = "Ár: " + ter24.Ar + "Ft";
            etel24_nev.Content = ter24.Nev;
            //desszertek
            //üdítő
            termek ter25 = new termek(Etel25_ar, Etel25_akcio, "Coca-Cola");
            etel25_ar.Content = "Ár: " + ter25.Ar + "Ft";
            etel25_nev.Content = ter25.Nev;

            termek ter26 = new termek(Etel26_ar, Etel26_akcio, "Narancslé");
            etel26_ar.Content = "Ár: " + ter26.Ar + "Ft";
            etel26_nev.Content = ter26.Nev;

            termek ter27 = new termek(Etel27_ar, Etel27_akcio, "Almalé");
            etel27_ar.Content = "Ár: " + ter27.Ar + "Ft";
            etel27_nev.Content = ter27.Nev;

            termek ter28 = new termek(Etel28_ar, Etel28_akcio, "Kávé");
            etel28_ar.Content = "Ár: " + ter28.Ar + "Ft";
            etel28_nev.Content = ter28.Nev;

            termek ter29 = new termek(Etel29_ar, Etel29_akcio, "Tea");
            etel29_ar.Content = "Ár: " + ter29.Ar + "Ft";
            etel29_nev.Content = ter29.Nev;

            termek ter30 = new termek(Etel30_ar, Etel30_akcio, "Jeges tea");
            etel30_ar.Content = "Ár: " + ter30.Ar + "Ft";
            etel30_nev.Content = ter30.Nev;
            //üdítő


            index = random.Next(0, szazalekok.Length);
            index2 = random.Next(0, nevek.Length);

            //design főoldal
        }
        //design főoldal
        private void kosar_button_Click(object sender, RoutedEventArgs e)
        {
            //design
            kosar.Visibility = Visibility.Visible;
            eloetelek.Visibility = Visibility.Hidden;
            levesek.Visibility = Visibility.Hidden;
            foetelek.Visibility = Visibility.Hidden;
            desszertek.Visibility = Visibility.Hidden;
            uditok.Visibility = Visibility.Hidden;
            coupon.Visibility = Visibility.Hidden;
            profil.Visibility = Visibility.Hidden;
            kijelzo.Content = "Kosár";
            //design
            vissza.Visibility = Visibility.Hidden;
            tovabb.Visibility = Visibility.Hidden;
            eloetel_jelzo.Visibility = Visibility.Hidden;
            leves_jelzo.Visibility= Visibility.Hidden;
            foetel_jelzo.Visibility = Visibility.Hidden;
            desszert_jelzo.Visibility = Visibility.Hidden;
            udito_jelzo.Visibility = Visibility.Hidden;
            ossz_ki.Text = "Összegzés: " + ossz_db + "db " + ossz_ar + "Ft";

            string[] eloetelek_tomb = { "Bruschetta", "Pogácsa", "Szendvics", "Saláta", "Ránotta", "Fasírt" };
            string[] levesek_tomb = { "Paradicsom leves", "Sajtleves", "Bableves", "Fokhagymaleves", "Halászlé", "Ramen" };
            string[] foetelek_tomb = { "Omelette", "Mac 'N' Cheese", "Köfte", "Fisch And Chips", "Steak", "Teriyaki Tofu" };
            string[] desszertek_tomb = { "Fagylalt", "Torta", "Pite", "Macaron", "Süti", "Fánk" };

            termek_1 = random.Next(0, eloetelek_tomb.Length);
            termek_2 = random.Next(0, levesek_tomb.Length);
            termek_3 = random.Next(0, foetelek_tomb.Length);
            termek_4 = random.Next(0, desszertek_tomb.Length);

            switch (termek_1)
            {
                case 1:
                    termek1_kep.Source = Kep("/images/bruschetta.png");
                    termek1_nev.Text = "Bruschetta";
                    termek1_ar.Text = Etel1_ar + "Ft";
                    break;
                case 2:
                    termek1_kep.Source = Kep("/images/cake (1).png");
                    termek1_nev.Text = "Pogácsa";
                    termek1_ar.Text = Etel2_ar + "Ft";
                    break;
                case 3:
                    termek1_kep.Source = Kep("/images/sandwich.png");
                    termek1_nev.Text = "Szendvics";
                    termek1_ar.Text = Etel3_ar + "Ft";
                    break;
                case 4:
                    termek1_kep.Source = Kep("/images/salad (2).png");
                    termek1_nev.Text = "Saláta";
                    termek1_ar.Text = Etel4_ar + "Ft";
                    break;
                case 5:
                    termek1_kep.Source = Kep("/images/fried-rice.png");
                    termek1_nev.Text = "Rántotta";
                    termek1_ar.Text = Etel5_ar + "Ft";
                    break;
                case 6:
                    termek1_kep.Source = Kep("/images/meatballs.png");
                    termek1_nev.Text = "Fasírt";
                    termek1_ar.Text = Etel6_ar + "Ft";
                    break;
            }
            switch (termek_2)
            {
                case 1:
                    termek2_kep.Source = Kep("/images/meatball.png");
                    termek2_nev.Text = "Paradicsom leves";
                    termek2_ar.Text = Etel7_ar + "Ft";
                    break;
                case 2:
                    termek2_kep.Source = Kep("/images/soup.png");
                    termek2_nev.Text = "Sajtleves";
                    termek2_ar.Text = Etel8_ar + "Ft";
                    break;
                case 3:
                    termek2_kep.Source = Kep("/images/red-bean-soup.png");
                    termek2_nev.Text = "Bableves";
                    termek2_ar.Text = Etel9_ar + "Ft";
                    break;
                case 4:
                    termek2_kep.Source = Kep("/images/garlic-soup.png");
                    termek2_nev.Text = "Fokhagymaleves";
                    termek2_ar.Text = Etel10_ar + "Ft";
                    break;
                case 5:
                    termek2_kep.Source = Kep("/images/fish.png");
                    termek2_nev.Text = "Halászlé";
                    termek2_ar.Text = Etel11_ar + "Ft";
                    break;
                case 6:
                    termek2_kep.Source = Kep("/images/ramen.png");
                    termek2_nev.Text = "Ramen";
                    termek2_ar.Text = Etel12_ar + "Ft";
                    break;
            }
            switch (termek_3)
            {
                case 1:
                    termek3_kep.Source = Kep("/images/omelette.png");
                    termek3_nev.Text = "Omelette";
                    termek3_ar.Text = Etel13_ar + "Ft";
                    break;
                case 2:
                    termek3_kep.Source = Kep("/images/macaroni.png");
                    termek3_nev.Text = "Mac 'N' Cheese";
                    termek3_ar.Text = Etel14_ar + "Ft";
                    break;
                case 3:
                    termek3_kep.Source = Kep("/images/kofte.png");
                    termek3_nev.Text = "Köfte";
                    termek3_ar.Text = Etel15_ar + "Ft";
                    break;
                case 4:
                    termek3_kep.Source = Kep("/images/fish-and-chips.png");
                    termek3_nev.Text = "Fisch And Chips";
                    termek3_ar.Text = Etel16_ar + "Ft";
                    break;
                case 5:
                    termek3_kep.Source = Kep("/images/steak.png");
                    termek3_nev.Text = "Steak";
                    termek3_ar.Text = Etel17_ar + "Ft";
                    break;
                case 6:
                    termek3_kep.Source = Kep("/images/stinky-tofu.png");
                    termek3_nev.Text = "Teriyaki Tofu";
                    termek3_ar.Text = Etel18_ar + "Ft";
                    break;
            }
            switch (termek_4)
            {
                case 1:
                    termek4_kep.Source = Kep("/images/ice-cream.png");
                    termek4_nev.Text = "Fagylalt";
                    termek4_ar.Text = Etel19_ar + "Ft";
                    break;
                case 2:
                    termek4_kep.Source = Kep("/images/cake.png");
                    termek4_nev.Text = "Torta";
                    termek4_ar.Text = Etel20_ar + "Ft";
                    break;
                case 3:
                    termek4_kep.Source = Kep("/images/meat-pie.png");
                    termek4_nev.Text = "Pite";
                    termek4_ar.Text = Etel21_ar + "Ft";
                    break;
                case 4:
                    termek4_kep.Source = Kep("/images/macaron.png");
                    termek4_nev.Text = "Macaron";
                    termek4_ar.Text = Etel22_ar + "Ft";
                    break;
                case 5:
                    termek4_kep.Source = Kep("/images/choco-chip.png");
                    termek4_nev.Text = "Süti";
                    termek4_ar.Text = Etel23_ar + "Ft";
                    break;
                case 6:
                    termek4_kep.Source = Kep("/images/donut.png");
                    termek4_nev.Text = "Fánk";
                    termek4_ar.Text = Etel24_ar + "Ft";
                    break;
            }

        }

        private void fo_button_Click(object sender, RoutedEventArgs e)
        {
            var etelek_jelzok = new[] {leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            var oldalak = new[] { hiba, bejelentkezes,elfelejtett_jelszo_oldal,
                                  jelszo, coupon, kosar, profil, levesek, desszertek, foetelek, uditok, profil_ok};
            foreach (var item in etelek_jelzok) { item.Visibility = Visibility.Visible; item.IsChecked = false; }
            foreach (var item in oldalak) { item.Visibility = Visibility.Hidden; }
           
            tovabb.Visibility = Visibility.Visible;
            coupon.Visibility = Visibility.Hidden;
            kosar.Visibility = Visibility.Hidden;
            fooldal.Visibility = Visibility.Visible;
            eloetelek.Visibility = Visibility.Visible;
            kijelzo.Content = "Előételek";
            vissza.Visibility = Visibility.Hidden;
            eloetel_jelzo.Visibility = Visibility.Visible;
            eloetel_jelzo.IsChecked = true;
        }
        private void tovabb_Click(object sender, RoutedEventArgs e)
        {
            if (eloetelek.IsVisible == true)
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
            else if (levesek.IsVisible == true)
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
            else if (foetelek.IsVisible == true)
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
            else if (desszertek.IsVisible == true)
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
                var eltun = new[] { levesek, foetelek, desszertek, uditok };
                var jelzok = new[] { leves_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };

                foreach (var item in eltun) item.Visibility = Visibility.Hidden;
                foreach (var item in jelzok) item.IsChecked = false;

                eloetelek.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Hidden;
                tovabb.Visibility = Visibility.Visible;
                kijelzo.Content = "Előételek";
                eloetel_jelzo.IsChecked = true;
            }
            else if (foetelek.IsVisible == true)
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
            else if (desszertek.IsVisible == true)
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
            else if (uditok.IsVisible == true)
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

        private static string Jelszo_titkositas(string jelszo)
        {
            char[] titkositott_jelszo = jelszo.ToCharArray();

            for (int i = 0; i < titkositott_jelszo.Length; i++)
            {
                titkositott_jelszo[i] = (char)(titkositott_jelszo[i] + 10);
            }

            string titkos_jelszo = new string(titkositott_jelszo);
            return titkos_jelszo;
        }

        private static string Jelszo_visszaallitas(string jelszo)
        {
            char[] visszaforditando_jelszo = jelszo.ToCharArray();

            for (int i = 0; i < visszaforditando_jelszo.Length; i++)
            {
                visszaforditando_jelszo[i] = (char)(visszaforditando_jelszo[i] - 10);
            }

            string visszafejtett_jelszo = new string(visszaforditando_jelszo);
            return visszafejtett_jelszo;
        }

        static BitmapImage Kep(string kep)
        {
            BitmapImage kepek = new BitmapImage();
            kepek.BeginInit();
            kepek.UriSource = new Uri(kep, UriKind.Relative);
            kepek.EndInit();
            return kepek;
        }

        public int Akciozas(int ar, int szazalek)
        {
            int vegeredmeny = 0;
            double szazalekDecimal = szazalek / 100.0;

            if (szazalek == 10)
            {
                vegeredmeny = (int)(ar * szazalekDecimal);
            }
            else if (szazalek == 20)
            {
                vegeredmeny = (int)(ar * szazalekDecimal);
            }
            else if (szazalek == 30)
            {
                vegeredmeny = (int)(ar * szazalekDecimal);
            }
            else if (szazalek == 40)
            {
                vegeredmeny = (int)(ar * szazalekDecimal);
            }
            else if (szazalek == 50)
            {
                vegeredmeny = (int)(ar * szazalekDecimal);
            }
            else
            {
                vegeredmeny = (int)(ar * szazalekDecimal);
            }

            return ar - vegeredmeny;
        }
        private void regisztralas_gomb_Click(object sender, RoutedEventArgs e)
        {
            //ellenőrzés

            int engedély = 0;
            string nev2 = felhasznalonev_input.Text;
            felhasznalo = nev2;
            string be_kor = eletkor_input.Text;
            int kor;
            string email = email_input.Text;
            string nem = nem_input.Text;
            string jelszo1 = jelszo1_input.Password;
            string jelszo2 = jelszo2_input.Password;


            if (nev2 == "" & be_kor == "" & email == "" & jelszo1 == "" & jelszo2 == "")
            {
                hiba.Visibility = Visibility.Visible;
                hiba_out.Text = "Nem lehet üresen hagyott mező!";
                return;
            }
            else
            {
                if (File.Exists(nev2 + ".txt"))
                {
                    hiba.Visibility = Visibility.Visible;
                    hiba_out.Text = "Ez a felhasználónév már foglalt!";
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

                        if (nem == "férfi" | nem == "nő")
                        {
                            //tovább enged
                            engedély++; //2

                        }
                        else
                        {
                            //hiba
                            hiba.Visibility = Visibility.Visible;
                            hiba_out.Text = "A neme férfi vagy nő lehet csak!";
                            return;
                        }

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
                            engedély++;
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
            }
            var gombok = new[] { regisztralas_gomb, bejelentkezes_gomb };
            var beviteli_mezok = new[] { felhasznalonev_input, email_input, eletkor_input };
            var jelszavak = new[] { jelszo1_input, jelszo2_input };
            if (hiba.IsVisible == true)
            {
                foreach (var item in gombok) item.IsEnabled = false;
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
                    string file_name = nev2 + ".txt";
                    File.WriteAllText(file_name, nev2 + " " + kor + " " + email + " " + nem + " " + Jelszo_titkositas(jelszo1));
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
            var gombok = new[] { regisztralas_gomb, bejelentkezes_gomb };
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
            bejelentkezes_kep_fo.Visibility = Visibility.Visible;
            kijelzo.Content = "Bejelentkezés";
            felhasznalonev_input_bejelenktezes.Focus();
        }
        static string nev = "";

        private void bejelentekezes_fo_gomb_Click(object sender, RoutedEventArgs e)
        {
            nev = felhasznalonev_input_bejelenktezes.Text;
            felhasznalo = nev;
            string jelszo = jelszo_input_bejelentkezes.Password;

            string titkos_jelszo = Jelszo_titkositas(jelszo);

            if (File.Exists(nev + ".txt"))
            {
                string x = File.ReadAllText(nev + ".txt");
                string[] adatok = x.Split(' ');
                if (adatok[4] == titkos_jelszo)
                {
                    //tovább enged
                    var jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo, desszert_jelzo, udito_jelzo };
                    var gombok = new[] { tovabb, fo_button, coupon_button, account_gomb, kosar_button };
                    foreach (var item in jelzok) item.Visibility = Visibility.Visible;
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
        private void vissza_a_regisztracihoz_Click(object sender, RoutedEventArgs e)
        {
            bejelentkezes.Visibility = Visibility.Hidden;
            regisztralas.Visibility = Visibility.Visible;
            kijelzo.Content = "Regisztrálás";
        }
        //bejelentkezős oldal
        //elfelejtett jelszo
        private void elfelejtett_jelszo_Click(object sender, RoutedEventArgs e)
        {
            bejelentkezes.Visibility = Visibility.Hidden;
            elfelejtett_jelszo_oldal.Visibility = Visibility.Visible;
            kijelzo.Content = "Elfelejtett jelszó";
            bejelentkezes_kep_fo.Visibility = Visibility.Visible;

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
            if (File.Exists(felhasznalonev_input_elfelejtett.Text + ".txt"))
            {
                string x = File.ReadAllText(felhasznalonev_input_elfelejtett.Text + ".txt");
                string[] adatok = x.Split(' ');

                string email = email_input_elfelejtett.Text;

                string titkos_jelszo = Jelszo_visszaallitas(adatok[4]);

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

        private void vissza_a_bejelentkezeshez_Click(object sender, RoutedEventArgs e)
        {
            elfelejtett_jelszo_oldal.Visibility = Visibility.Hidden;
            bejelentkezes.Visibility = Visibility.Visible;
            kijelzo.Content = "Bejelentkezés";
        }

        //elfelejtett jelszo
        //coupon

        private void coupon_button_Click(object sender, RoutedEventArgs e)
        {
            //design
            var oldalak = new[] { eloetelek, levesek, foetelek, desszertek, uditok, hiba, bejelentkezes,
                                  elfelejtett_jelszo_oldal, jelszo, kosar, profil };

            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};

            foreach (var item in oldalak) { item.Visibility = Visibility.Hidden; }
            foreach (var item in etelek_jelzok) { item.Visibility = Visibility.Hidden; }

            for (int i = 0; i <= 30; i++)
            {
                if (i == nevek[index2])
                {
                    var gomb = (UIElement)this.FindName("akcio_etel" + i);
                    gomb.Visibility = Visibility.Visible;
                }
            }

            vissza.Visibility = Visibility.Hidden;
            tovabb.Visibility = Visibility.Hidden;
            coupon.Visibility = Visibility.Visible;
            kijelzo.Content = "Coupon";
            //design
            //logic

            int szazalek = szazalekok[index];
            coupon_szazalek.Value = szazalek;
            szazalek_kiiras.Text = szazalek + "%";

            int nev = nevek[index2];
            switch (nev)
            {
                case 1:
                    coupon_nev.Text = "Bruschetta";
                    coupon_kep.Source = Kep("/images/bruschetta.png");
                    Etel1_akcio = szazalek;
                    akcio_etel1.Content = "-" + szazalek + "%";
                    etel1_ar.Content = "Ár: " + Akciozas(Etel1_ar, szazalek) + "Ft";
                    Etel1_ar = Akciozas(Etel1_ar, szazalek);
                    break;
                case 2:
                    coupon_nev.Text = "Pogácsa";
                    coupon_kep.Source = Kep("/images/cake (1).png");
                    Etel2_akcio = szazalek;
                    akcio_etel2.Content = "-" + szazalek + "%";
                    etel2_ar.Content = "Ár: " + Akciozas(Etel2_ar, szazalek) + "Ft";
                    Etel2_ar = Akciozas(Etel2_ar, szazalek);
                    break;
                case 3:
                    coupon_nev.Text = "Szendvics";
                    coupon_kep.Source = Kep("/images/sandwich.png");
                    Etel3_akcio = szazalek;
                    akcio_etel3.Content = "-" + szazalek + "%";
                    etel3_ar.Content = "Ár: " + Akciozas(Etel3_ar, szazalek) + "Ft";
                    Etel3_ar = Akciozas(Etel3_ar, szazalek);
                    break;
                case 4:
                    coupon_nev.Text = "Saláta";
                    coupon_kep.Source = Kep("/images/salad (2).png");
                    Etel4_akcio = szazalek;
                    akcio_etel4.Content = "-" + szazalek + "%";
                    etel4_ar.Content = "Ár: " + Akciozas(Etel4_ar, szazalek) + "Ft";
                    Etel4_ar = Akciozas(Etel4_ar, szazalek);
                    break;
                case 5:
                    coupon_nev.Text = "Rántotta";
                    coupon_kep.Source = Kep("/images/fried-rice.png");
                    Etel5_akcio = szazalek;
                    akcio_etel5.Content = "-" + szazalek + "%";
                    etel5_ar.Content = "Ár: " + Akciozas(Etel5_ar, szazalek) + "Ft";
                    Etel5_ar = Akciozas(Etel5_ar, szazalek);
                    break;
                case 6:
                    coupon_nev.Text = "Fasírt";
                    coupon_kep.Source = Kep("/images/meatballs.png");
                    Etel6_akcio = szazalek;
                    etel6_ar.Content = "Ár: " + Akciozas(Etel6_ar, szazalek) + "Ft";
                    akcio_etel6.Content = "-" + szazalek + "%";
                    Etel6_ar = Akciozas(Etel6_ar, szazalek);
                    break;
                case 7:
                    coupon_nev.Text = "Paradicsom leves";
                    coupon_kep.Source = Kep("/images/meatball.png");
                    Etel7_akcio = szazalek;
                    akcio_etel7.Content = "-" + szazalek + "%";
                    etel7_ar.Content = "Ár: " + Akciozas(Etel7_ar, szazalek) + "Ft";
                    Etel7_ar = Akciozas(Etel7_ar, szazalek);
                    break;
                case 8:
                    coupon_nev.Text = "Sajtleves";
                    coupon_kep.Source = Kep("/images/soup.png");
                    Etel8_akcio = szazalek;
                    akcio_etel8.Content = "-" + szazalek + "%";
                    etel8_ar.Content = "Ár: " + Akciozas(Etel8_ar, szazalek) + "Ft";
                    Etel8_ar = Akciozas(Etel8_ar, szazalek);
                    break;
                case 9:
                    coupon_nev.Text = "Bableves";
                    coupon_kep.Source = Kep("/images/red-bean-soup.png");
                    Etel9_akcio = szazalek;
                    akcio_etel9.Content = "-" + szazalek + "%";
                    etel9_ar.Content = "Ár: " + Akciozas(Etel9_ar, szazalek) + "Ft";
                    Etel9_ar = Akciozas(Etel9_ar, szazalek);
                    break;
                case 10:
                    coupon_nev.Text = "Fokhagymaleves";
                    coupon_kep.Source = Kep("/images/garlic-soup.png");
                    Etel10_akcio = szazalek;
                    akcio_etel10.Content = "-" + szazalek + "%";
                    etel10_ar.Content = "Ár: " + Akciozas(Etel10_ar, szazalek) + "Ft";
                    Etel10_ar = Akciozas(Etel10_ar, szazalek);
                    break;
                case 11:
                    coupon_nev.Text = "Halászlé";
                    coupon_kep.Source = Kep("/images/fish.png");
                    Etel11_akcio = szazalek;
                    akcio_etel11.Content = "-" + szazalek + "%";
                    etel11_ar.Content = "Ár: " + Akciozas(Etel11_ar, szazalek) + "Ft";
                    Etel11_ar = Akciozas(Etel11_ar, szazalek);
                    break;
                case 12:
                    coupon_nev.Text = "Ramen";
                    coupon_kep.Source = Kep("/images/ramen.png");
                    Etel12_akcio = szazalek;
                    akcio_etel12.Content = "-" + szazalek + "%";
                    etel12_ar.Content = "Ár: " + Akciozas(Etel12_ar, szazalek) + "Ft";
                    Etel12_ar = Akciozas(Etel12_ar, szazalek);
                    break;
                case 13:
                    coupon_nev.Text = "Omelette";
                    coupon_kep.Source = Kep("/images/omelette.png");
                    Etel13_akcio = szazalek;
                    akcio_etel13.Content = "-" + szazalek + "%";
                    etel13_ar.Content = "Ár: " + Akciozas(Etel13_ar, szazalek) + "Ft";
                    Etel13_ar = Akciozas(Etel13_ar, szazalek);
                    break;
                case 14:
                    coupon_nev.Text = "Mac 'N' Cheese";
                    coupon_kep.Source = Kep("/images/macaroni.png");
                    Etel14_akcio = szazalek;
                    akcio_etel14.Content = "-" + szazalek + "%";
                    etel14_ar.Content = "Ár: " + Akciozas(Etel14_ar, szazalek) + "Ft";
                    Etel14_ar = Akciozas(Etel14_ar, szazalek);
                    break;
                case 15:
                    coupon_nev.Text = "Köfte";
                    coupon_kep.Source = Kep("/images/kofte.png");
                    Etel15_akcio = szazalek;
                    akcio_etel15.Content = "-" + szazalek + "%";
                    etel15_ar.Content = "Ár: " + Akciozas(Etel15_ar, szazalek) + "Ft";
                    Etel15_ar = Akciozas(Etel15_ar, szazalek);
                    break;
                case 16:
                    coupon_nev.Text = "Fisch And Chips";
                    coupon_kep.Source = Kep("/images/fish-and-chips.png");
                    Etel16_akcio = szazalek;
                    akcio_etel16.Content = "-" + szazalek + "%";
                    etel16_ar.Content = "Ár: " + Akciozas(Etel16_ar, szazalek) + "Ft";
                    Etel16_ar = Akciozas(Etel16_ar, szazalek);
                    break;
                case 17:
                    coupon_nev.Text = "Steak";
                    coupon_kep.Source = Kep("/images/steak.png");
                    Etel17_akcio = szazalek;
                    akcio_etel17.Content = "-" + szazalek + "%";
                    etel17_ar.Content = "Ár: " + Akciozas(Etel17_ar, szazalek) + "Ft";
                    Etel17_ar = Akciozas(Etel17_ar, szazalek);
                    break;
                case 18:
                    coupon_nev.Text = "Teriyaki Tofu";
                    coupon_kep.Source = Kep("/images/stinky-tofu.png");
                    Etel18_akcio = szazalek;
                    akcio_etel18.Content = "-" + szazalek + "%";
                    etel18_ar.Content = "Ár: " + Akciozas(Etel18_ar, szazalek) + "Ft";
                    Etel18_ar = Akciozas(Etel18_ar, szazalek);
                    break;
                case 19:
                    coupon_nev.Text = "Fagylalt";
                    coupon_kep.Source = Kep("/images/ice-cream.png");
                    Etel19_akcio = szazalek;
                    akcio_etel19.Content = "-" + szazalek + "%";
                    etel19_ar.Content = "Ár: " + Akciozas(Etel19_ar, szazalek) + "Ft";
                    Etel19_ar = Akciozas(Etel19_ar, szazalek);
                    break;
                case 20:
                    coupon_nev.Text = "Torta";
                    coupon_kep.Source = Kep("/images/cake.png");
                    Etel20_akcio = szazalek;
                    akcio_etel20.Content = "-" + szazalek + "%";
                    etel20_ar.Content = "Ár: " + Akciozas(Etel20_ar, szazalek) + "Ft";
                    Etel20_ar = Akciozas(Etel20_ar, szazalek);
                    break;
                case 21:
                    coupon_nev.Text = "Pite";
                    coupon_kep.Source = Kep("/images/meat-pie.png");
                    Etel21_akcio = szazalek;
                    akcio_etel21.Content = "-" + szazalek + "%";
                    etel21_ar.Content = "Ár: " + Akciozas(Etel21_ar, szazalek) + "Ft";
                    Etel21_ar = Akciozas(Etel21_ar, szazalek);
                    break;
                case 22:
                    coupon_nev.Text = "Macaron";
                    coupon_kep.Source = Kep("/images/macaron.png");
                    Etel22_akcio = szazalek;
                    akcio_etel22.Content = "-" + szazalek + "%";
                    etel22_ar.Content = "Ár: " + Akciozas(Etel22_ar, szazalek) + "Ft";
                    Etel22_ar = Akciozas(Etel22_ar, szazalek);
                    break;
                case 23:
                    coupon_nev.Text = "Süti";
                    coupon_kep.Source = Kep("/images/choco-chip.png");
                    Etel23_akcio = szazalek;
                    akcio_etel23.Content = "-" + szazalek + "%";
                    etel23_ar.Content = "Ár: " + Akciozas(Etel23_ar, szazalek) + "Ft";
                    Etel23_ar = Akciozas(Etel23_ar, szazalek);
                    break;
                case 24:
                    coupon_nev.Text = "Fánk";
                    coupon_kep.Source = Kep("/images/donut.png");
                    Etel24_akcio = szazalek;
                    akcio_etel24.Content = "-" + szazalek + "%";
                    etel24_ar.Content = "Ár: " + Akciozas(Etel24_ar, szazalek) + "Ft";
                    Etel24_ar = Akciozas(Etel24_ar, szazalek);
                    break;
                case 25:
                    coupon_nev.Text = "Coca-Cola";
                    coupon_kep.Source = Kep("/images/cola.png");
                    Etel25_akcio = szazalek;
                    akcio_etel25.Content = "-" + szazalek + "%";
                    etel25_ar.Content = "Ár: " + Akciozas(Etel25_ar, szazalek) + "Ft";
                    Etel25_ar = Akciozas(Etel25_ar, szazalek);
                    break;
                case 26:
                    coupon_nev.Text = "Narancslé";
                    coupon_kep.Source = Kep("/images/orange-juice.png");
                    Etel26_akcio = szazalek;
                    akcio_etel26.Content = "-" + szazalek + "%";
                    etel26_ar.Content = "Ár: " + Akciozas(Etel26_ar, szazalek) + "Ft";
                    Etel26_ar = Akciozas(Etel26_ar, szazalek);
                    break;
                case 27:
                    coupon_nev.Text = "Almalé";
                    coupon_kep.Source = Kep("/images/apple-juice.png");
                    Etel27_akcio = szazalek;
                    akcio_etel27.Content = "-" + szazalek + "%";
                    etel27_ar.Content = "Ár: " + Akciozas(Etel27_ar, szazalek) + "Ft";
                    Etel27_ar = Akciozas(Etel27_ar, szazalek);
                    break;
                case 28:
                    coupon_nev.Text = "Kávé";
                    coupon_kep.Source = Kep("/images/coffee-cup.png");
                    Etel28_akcio = szazalek;
                    akcio_etel28.Content = "-" + szazalek + "%";
                    etel28_ar.Content = "Ár: " + Akciozas(Etel28_ar, szazalek) + "Ft";
                    Etel28_ar = Akciozas(Etel28_ar, szazalek);
                    break;
                case 29:
                    coupon_nev.Text = "Tea";
                    coupon_kep.Source = Kep("/images/herbal-tea.png");
                    Etel29_akcio = szazalek;
                    akcio_etel29.Content = "-" + szazalek + "%";
                    etel29_ar.Content = "Ár: " + Akciozas(Etel29_ar, szazalek) + "Ft";
                    Etel29_ar = Akciozas(Etel29_ar, szazalek);
                    break;
                case 30:
                    coupon_nev.Text = "Jeges tea";
                    coupon_kep.Source = Kep("/images/ice-tea.png");
                    Etel30_akcio = szazalek;
                    akcio_etel30.Content = "-" + szazalek + "%";
                    etel30_ar.Content = "Ár: " + Akciozas(Etel30_ar, szazalek) + "Ft";
                    Etel30_ar = Akciozas(Etel30_ar, szazalek);
                    break;
            }

            //logic
        }

        private void elfogad_Click(object sender, RoutedEventArgs e)
        {
            coupon.Visibility = Visibility.Hidden;
            int nev = nevek[index2];
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek_jelzok) { item.Visibility = Visibility.Visible; }

            for (int i = 1; i <= 30; i++)
            {
                if (i == nev)
                {
                    var akcio_etel = FindName($"akcio_etel{i}") as UIElement;
                    akcio_etel.Visibility = Visibility.Visible;
                }
            }

            eloetelek.Visibility = (nev >= 1 && nev <= 6) ? Visibility.Visible : Visibility.Hidden;
            levesek.Visibility = (nev >= 7 && nev <= 12) ? Visibility.Visible : Visibility.Hidden;
            foetelek.Visibility = (nev >= 13 && nev <= 18) ? Visibility.Visible : Visibility.Hidden;
            desszertek.Visibility = (nev >= 19 && nev <= 24) ? Visibility.Visible : Visibility.Hidden;
            uditok.Visibility = (nev >= 25 && nev <= 30) ? Visibility.Visible : Visibility.Hidden;

            if (eloetelek.Visibility == Visibility.Visible)
            {
                tovabb.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Hidden;
                eloetel_jelzo.IsChecked = true;
            }
            else if (levesek.Visibility == Visibility.Visible)
            {
                tovabb.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                leves_jelzo.IsChecked = true;
            }
            else if (foetelek.Visibility == Visibility.Visible)
            {
                tovabb.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                foetel_jelzo.IsChecked = true;
            }
            else if (desszertek.Visibility == Visibility.Visible)
            {
                tovabb.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                desszert_jelzo.IsChecked = true;
            }
            else if (uditok.Visibility == Visibility.Visible)
            {
                tovabb.Visibility = Visibility.Visible;
                vissza.Visibility = Visibility.Visible;
                udito_jelzo.IsChecked = true;
            }
        }
        //coupon
        //profil
        private void account_gomb_Click(object sender, RoutedEventArgs e)
        {
            kosar.Visibility = Visibility.Hidden;
            eloetelek.Visibility = Visibility.Hidden;
            levesek.Visibility = Visibility.Hidden;
            foetelek.Visibility = Visibility.Hidden;
            desszertek.Visibility = Visibility.Hidden;
            uditok.Visibility = Visibility.Hidden;
            coupon.Visibility = Visibility.Hidden;
            profil.Visibility = Visibility.Visible;
            kijelzo.Content = "Felhasználó";
            profil_ferfi.IsEnabled = false;
            profil_no.IsEnabled = false;
            vissza.Visibility= Visibility.Hidden;
            tovabb.Visibility = Visibility.Hidden;
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            foreach (var item in etelek_jelzok) { item.Visibility = Visibility.Hidden; }

            if (File.Exists(felhasznalo + ".txt"))
            {
                string adat = File.ReadAllText(felhasznalo + ".txt");
                string[] adatok = adat.Split(' ');

                szemely sz = new szemely(adatok[0], Convert.ToInt32(adatok[1]), adatok[2], "", "");
                profil_nev.Text = "Név: " + sz.Nev;
                profil_kor.Text = "Kor: " + sz.Eletkor;
                profil_email.Text = "Email: " + sz.Email;

                if (adatok[3] == "férfi")
                {
                    profil_no.IsChecked = false;
                    profil_ferfi.IsChecked = true;

                    if (sz.Eletkor > 0 & sz.Eletkor < 18)
                    {
                        profil_kep.Source = Kep("/profil_images/teenage.png");
                    }
                    else if (sz.Eletkor > 18 & sz.Eletkor < 50)
                    {
                        profil_kep.Source = Kep("/profil_images/father.png");
                    }
                    else if (sz.Eletkor > 50 & sz.Eletkor < 120)
                    {
                        profil_kep.Source = Kep("/profil_images/man(1).png");
                    }
                }
                else
                {
                    profil_ferfi.IsChecked = false;
                    profil_no.IsChecked = true;

                    if (sz.Eletkor > 0 & sz.Eletkor < 18)
                    {
                        profil_kep.Source = Kep("/profil_images/teen.png");
                    }
                    else if (sz.Eletkor > 18 & sz.Eletkor < 50)
                    {
                        profil_kep.Source = Kep("/profil_images/mom.png");
                    }
                    else if (sz.Eletkor > 50 & sz.Eletkor < 120)
                    {
                        profil_kep.Source = Kep("/profil_images/grandmother.png");
                    }
                }
                profil_jelszo.Password = Jelszo_visszaallitas(adatok[4]);
            }
            else
            {
                return;
            }
        }
        private void profil_uj_jelszo_Click(object sender, RoutedEventArgs e)
        {
            string adat = File.ReadAllText(nev + ".txt");
            string[] adatok = adat.Split(' ');
            string fajl = nev + ".txt";
            if (profil_jelszo.Password.Length >= 8)
            {
                File.Delete(fajl);
                File.WriteAllText(fajl, adatok[0] + " " + adatok[1] + " " + adatok[2] + " " + adatok[3] + " " + Jelszo_titkositas(profil_jelszo.Password));
                profil_ok.Visibility = Visibility.Visible;
            }
            else
            {
                hiba.Visibility = Visibility.Visible;
                hiba_out.Text = "A jelszónak legalább 8 karakternek kell lennie!";
                return;
            }
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            var oldalak = new[] { eloetelek, levesek, foetelek, desszertek, uditok, hiba, regisztralas,
                                  elfelejtett_jelszo_oldal, jelszo, coupon, kosar, profil, profil_ok};
            var etelek_jelzok = new[] { eloetel_jelzo, leves_jelzo, foetel_jelzo,
                                        desszert_jelzo, udito_jelzo};
            var gombok = new[] { vissza, tovabb, fo_button, coupon_button, account_gomb, kosar_button };
            var szazalekok_gomb = new[] { akcio_etel1, akcio_etel2, akcio_etel3, akcio_etel4, akcio_etel5,
                                     akcio_etel6, akcio_etel7, akcio_etel8, akcio_etel9, akcio_etel10,
                                     akcio_etel11, akcio_etel12, akcio_etel13, akcio_etel14, akcio_etel15,
                                     akcio_etel16, akcio_etel17, akcio_etel18, akcio_etel19, akcio_etel20,
                                     akcio_etel21, akcio_etel22, akcio_etel23, akcio_etel24, akcio_etel25,
                                     akcio_etel26, akcio_etel27, akcio_etel28, akcio_etel29, akcio_etel30};
            foreach(var item in oldalak) { item.Visibility = Visibility.Hidden; }
            foreach (var item in etelek_jelzok) { item.Visibility = Visibility.Hidden; }
            foreach (var item in gombok) { item.Visibility = Visibility.Hidden; }
            foreach (var item in szazalekok_gomb) { item.Visibility = Visibility.Hidden; }
            bejelentkezes.Visibility = Visibility.Visible;
            jelszo_input_bejelentkezes.Password = null;
        }
        //profil
        
        //eloetelek gomb
        private void etel1_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel1_ar;
            etelek.Add("Bruschetta");

            int etel1 = 0;
            etel1 = etelek.Count(x => x == "Bruschetta");

            if (etel1 > 0)
            {
                if (etel1 > 1)
                {
                    kosar_tartalma.Items.Remove("Bruschetta " + (etel1 - 1) + "db " + ((Etel1_ar * etel1) - Etel1_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Bruschetta " + etel1 + "db " + (Etel1_ar * etel1) + "Ft" + "\t");
            }
        }

        private void etel2_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel2_ar;
            etelek.Add("Pogácsa");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Pogácsa");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Pogácsa " + (etel2 - 1) + "db " + ((Etel2_ar * etel2) - Etel2_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Pogácsa " + etel2 + "db " + (Etel2_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel3_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel3_ar;
            etelek.Add("Szendvics");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Szendvics");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Szendvics " + (etel2 - 1) + "db " + ((Etel3_ar * etel2) - Etel3_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Szendvics " + etel2 + "db " + (Etel3_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel4_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel4_ar;
            etelek.Add("Saláta");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Saláta");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Saláta " + (etel2 - 1) + "db " + ((Etel4_ar * etel2) - Etel4_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Saláta " + etel2 + "db " + (Etel4_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel5_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel5_ar;
            etelek.Add("Rántotta");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Rántotta");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Rántotta " + (etel2 - 1) + "db " + ((Etel5_ar * etel2) - Etel5_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Rántotta " + etel2 + "db " + (Etel5_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel6_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel6_ar;
            etelek.Add("Fasírt");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Fasírt");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Fasírt " + (etel2 - 1) + "db " + ((Etel6_ar * etel2) - Etel6_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Fasírt " + etel2 + "db " + (Etel6_ar * etel2) + "Ft" + "\t");
            }
        }
        //eloetelek gomb

        //levesek gomb
        private void etel7_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel7_ar;
            etelek.Add("Paradicsom leves");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Paradicsom leves");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Paradicsom leves" + (etel2 - 1) + "db " + ((Etel7_ar * etel2) - Etel7_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Paradicsom leves" + etel2 + "db " + (Etel7_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel8_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel8_ar;
            etelek.Add("Sajtleves");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Sajtleves");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Sajtleves" + (etel2 - 1) + "db " + ((Etel8_ar * etel2) - Etel8_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Sajtleves" + etel2 + "db " + (Etel8_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel9_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel9_ar;
            etelek.Add("Bableves");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Bableves");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Bableves" + (etel2 - 1) + "db " + ((Etel9_ar * etel2) - Etel9_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Bableves" + etel2 + "db " + (Etel9_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel10_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel10_ar;
            etelek.Add("Fokhagymaleves");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Fokhagymaleves");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Fokhagymaleves" + (etel2 - 1) + "db " + ((Etel10_ar * etel2) - Etel10_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Fokhagymaleves" + etel2 + "db " + (Etel10_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel11_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel11_ar;
            etelek.Add("Halászlé");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Halászlé");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Halászlé" + (etel2 - 1) + "db " + ((Etel11_ar * etel2) - Etel11_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Halászlé" + etel2 + "db " + (Etel11_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel12_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel12_ar;
            etelek.Add("Ramen");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Ramen");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Ramen" + (etel2 - 1) + "db " + ((Etel12_ar * etel2) - Etel12_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Ramen" + etel2 + "db " + (Etel12_ar * etel2) + "Ft" + "\t");
            }
        }
        //levesek gomb
        //főételek gomb
        private void etel13_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel13_ar;
            etelek.Add("Omelette");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Omelette");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Omelette" + (etel2 - 1) + "db " + ((Etel13_ar * etel2) - Etel13_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Omelette" + etel2 + "db " + (Etel13_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel14_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel14_ar;
            etelek.Add("Mac'N'Cheese");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Mac'N'Cheese");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Mac'N'Cheese" + (etel2 - 1) + "db " + ((Etel14_ar * etel2) - Etel14_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Mac'N'Cheese" + etel2 + "db " + (Etel14_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel15_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel15_ar;
            etelek.Add("Köfte");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Köfte");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Köfte" + (etel2 - 1) + "db " + ((Etel15_ar * etel2) - Etel15_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Köfte" + etel2 + "db " + (Etel15_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel16_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel16_ar;
            etelek.Add("Fisch and Chips");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Fisch and Chips");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Fisch and Chips" + (etel2 - 1) + "db " + ((Etel16_ar * etel2) - Etel16_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Fisch and Chips" + etel2 + "db " + (Etel16_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel17_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel17_ar;
            etelek.Add("Steak");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Steak");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Steak" + (etel2 - 1) + "db " + ((Etel17_ar * etel2) - Etel17_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Steak" + etel2 + "db " + (Etel17_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel18_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel18_ar;
            etelek.Add("Teriyaki Tofu");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Teriyaki Tofu");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Teriyaki Tofu" + (etel2 - 1) + "db " + ((Etel18_ar * etel2) - Etel18_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Teriyaki Tofu" + etel2 + "db " + (Etel18_ar * etel2) + "Ft" + "\t");
            }
        }
        //főételek gomb
        //desszertek gomb
        private void etel19_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel19_ar;
            etelek.Add("Fagylalt");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Fagylalt");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Fagylalt" + (etel2 - 1) + "db " + ((Etel19_ar * etel2) - Etel19_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Fagylalt" + etel2 + "db " + (Etel19_ar * etel2) + "Ft" + "\t");
            }

        }

        private void etel20_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel20_ar;
            etelek.Add("Torta");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Torta");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Torta" + (etel2 - 1) + "db " + ((Etel20_ar * etel2) - Etel20_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Torta" + etel2 + "db " + (Etel20_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel21_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel21_ar;
            etelek.Add("Pite");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Pite");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Pite" + (etel2 - 1) + "db " + ((Etel21_ar * etel2) - Etel21_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Pite" + etel2 + "db " + (Etel21_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel22_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel22_ar;
            etelek.Add("Macaron");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Macaron");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Macaron" + (etel2 - 1) + "db " + ((Etel22_ar * etel2) - Etel22_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Macaron" + etel2 + "db " + (Etel22_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel23_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel23_ar;
            etelek.Add("Süti");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Süti");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Süti" + (etel2 - 1) + "db " + ((Etel23_ar * etel2) - Etel23_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Süti" + etel2 + "db " + (Etel23_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel24_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel24_ar;
            etelek.Add("Fánk");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Fánk");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Fánk" + (etel2 - 1) + "db " + ((Etel24_ar * etel2) - Etel24_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Fánk" + etel2 + "db " + (Etel24_ar * etel2) + "Ft" + "\t");
            }
        }
        //desszertek gomb
        //üdítők gomb
        private void etel25_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel25_ar;
            etelek.Add("Coca-Cola");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Coca-Cola");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Coca-Cola" + (etel2 - 1) + "db " + ((Etel25_ar * etel2) - Etel25_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Coca-Cola" + etel2 + "db " + (Etel25_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel26_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel26_ar;
            etelek.Add("Narancslé");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Narancslé");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Narancslé" + (etel2 - 1) + "db " + ((Etel26_ar * etel2) - Etel26_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Narancslé" + etel2 + "db " + (Etel26_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel27_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel27_ar;
            etelek.Add("Almalé");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Almalé");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Almalé" + (etel2 - 1) + "db " + ((Etel27_ar * etel2) - Etel27_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Almalé" + etel2 + "db " + (Etel27_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel28_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel28_ar;
            etelek.Add("Kávé");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Kávé");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Kávé" + (etel2 - 1) + "db " + ((Etel28_ar * etel2) - Etel28_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Kávé" + etel2 + "db " + (Etel28_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel29_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel29_ar;
            etelek.Add("Tea");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Tea");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Tea" + (etel2 - 1) + "db " + ((Etel29_ar * etel2) - Etel29_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Tea" + etel2 + "db " + (Etel29_ar * etel2) + "Ft" + "\t");
            }
        }

        private void etel30_gomb_Click(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += Etel30_ar;
            etelek.Add("Jeges Tea");
            int etel2 = 0;
            etel2 = etelek.Count(x => x == "Jeges Tea");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Jeges Tea" + (etel2 - 1) + "db " + ((Etel30_ar * etel2) - Etel30_ar) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Jeges Tea" + etel2 + "db " + (Etel30_ar * etel2) + "Ft" + "\t");
            }
        }
        //üdítők gomb
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            etelek.Clear();
            kosar_tartalma.Items.Clear();
            ossz_ar = 0;
            ossz_db = 0;
            ossz_ki.Text = "Összegzés: " + ossz_db + "db " + ossz_ar + "Ft";

            MessageBox.Show("Az összes termék törölve lett!");
        }

        private void buy_Click(object sender, RoutedEventArgs e)
        {
            etelek.Clear();
            kosar_tartalma.Items.Clear();
            ossz_ar = 0;
            ossz_db = 0;
            ossz_ki.Text = "Összegzés: " + ossz_db + "db " + ossz_ar + "Ft";

            MessageBox.Show("A rendelés elküldve, várhatóan a következő napon érkezik a termék!");
        }
    }
}