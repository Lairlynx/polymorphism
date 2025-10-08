/*
Mostenire - clasa derivata primeste tot din clasa parinte

Rol - mecanism de reutilizare a codului
*/

namespace Mostenire
{
    class Persoana : object
    {
        protected string nume, prenume;
        protected int varsta;

        public Persoana(string n, string p, int v)
        {
            nume = n;
            prenume = p;
            varsta = v;
        }

        public override string ToString()
        {
            return $"Persoana: {nume} {prenume} - ({varsta})";
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

        public override string ToString()
        {
            return base.ToString() + $" - badge: {badge}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Persoana p = new Persoana("Popescu", "Ion", 30);
            Salariat s = new Salariat("Ionescu", "Vasile", 40, "A12345");

            Console.WriteLine(s);
        }
    }
}