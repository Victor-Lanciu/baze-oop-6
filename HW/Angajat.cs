using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public abstract class Angajat
    {
        public string Nume { get; set; }
        public int Vechime { get; set; }
        protected Angajat(string nume, int vechime)
        {
            Nume = nume;
            Vechime = vechime;
        }
        public virtual decimal CalculeazaSalariu()
        {
            return 10000;
        }

    }
    public class Manager : Angajat
    {
        public int Experienta { get; set; }
        public Manager(string nume, int vechime, int experienta) : base(nume, vechime)
        {
            Experienta = experienta;
        }
        public override decimal CalculeazaSalariu()
        {
            decimal result = base.CalculeazaSalariu() + (decimal)0.3 * base.CalculeazaSalariu() * Experienta;
            return result;
        }
    }
    public class Programmer : Angajat
    {
        public List<string> Languages { get; set; }

        public Programmer(string nume, int vechime, List<string> languages) : base(nume, vechime)
        {
            Languages = languages;
        }
        public override decimal CalculeazaSalariu()
        {
            decimal result = base.CalculeazaSalariu();
            string Csharp = "C#";
            bool knowCsharp = false;
            if (Languages.Contains(Csharp))
            {
                result += base.CalculeazaSalariu() * 4;
                knowCsharp = true;
            }
            foreach (string element in Languages)
            {
                if (element != Csharp)
                {
                    result += base.CalculeazaSalariu() * (decimal)0.5;

                }
            }
            return result;
        }
    }
    public class Contabil : Angajat
    {
        public int Experienta { get; set; }

        public Contabil(string nume, int vechime, int experienta) : base(nume, vechime)
        {
            Experienta = experienta;
        }
        public override decimal CalculeazaSalariu()
        {
            decimal result = base.CalculeazaSalariu() + base.CalculeazaSalariu() * (decimal)0.2;
            return result;
        }
    }

}
