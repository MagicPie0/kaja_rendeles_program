using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class szemely
    {
        string nev;
        int eletkor;
        string email;
        string jelszo1;
        string jelszo2;

        public szemely(string nev, int eletkor, string email, string jelszo1, string jelszo2)
        {
            this.Nev = nev;
            this.Eletkor = eletkor;
            this.Email = email;
            this.Jelszo1 = jelszo1;
            this.Jelszo2 = jelszo2;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Email { get => email; set => email = value; }
        public string Jelszo1 { get => jelszo1; set => jelszo1 = value; }
        public string Jelszo2 { get => jelszo2; set => jelszo2 = value; }
    }
}
