namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var angajati = new List<Angajat>
            {
                new Programmer("Gabrie", 3, ["C#" ,"JavaScript", "SQK"]),
                new Programmer("Temur", 5, ["Java", "Kotlin"]),
                new Manager("Ion", 3,8),
                new Contabil("Alexandra", 4,5)
            };
            foreach (var angajat in angajati)
            {
                Console.WriteLine(angajat.CalculeazaSalariu());
            }
        }
    }
}
