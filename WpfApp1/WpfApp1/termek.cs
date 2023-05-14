namespace WpfApp1
{
    internal class termek
    {
        int ar, akcio;
        string nev;
        public termek(int ar, int akcio, string nev)
        {
            this.ar = ar;
            this.akcio = akcio;
            this.nev = nev;
        }

        public int Ar { get => ar; set => ar = value; }
        public int Akcio { get => akcio; set => akcio = value; }
        public string Nev { get => nev; set => nev = value; }

    }
}
