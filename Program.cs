/*
Mostenire - clasa derivata primeste tot din clasa parinte

Rol - mecanism de reutilizare a codului
*/

namespace Mostenire
{
    class Persoana
    {
        protected string nume, prenume;
        protected int varsta;

        public Persoana(string n = null, string p = null, int v = 0)
        {
            nume = n;
            prenume = p;
            varsta = v;
        }
    }

    class Salariat : Persoana
    {
        protected string badge;

        public Salariat(string n, string p, int v, string b) : base(n, p, v)
        {
            //NU SE RECOMANDA ASTA
            // nume = n;
            // prenume = p;
            // varsta = v;
            badge = b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana("Popescu", "Ion", 30);
            Salariat s = new Salariat("Ionescu", "Vasile", 40, "A12345");

            Console.WriteLine("Hello, World!");
        }
    }
}