using System;

namespace Uzdevumi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);

            Console.WriteLine("Kāds ir tavs vecums?");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int nextYearAge = age + 1;

            Console.WriteLine("Sveiks, nākamgad Tev paliks " + nextYearAge + " gadi. ");

            Console.WriteLine("Salīdzināsim divus skaitļus, kurš lielāks. Ievadiet pirmo skaitli: ");
            int firstInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet otro skaitli: ");
            int secondInput = int.Parse(Console.ReadLine());
            int maxNumber = Math.Max(firstInput, secondInput);
            Console.WriteLine("Lielākais skaitlis: {0}", maxNumber);

            Console.WriteLine("Salīdzināsim divus skaitļus, kurš mazāks. Ievadiet pirmo skaitli: ");
            int thirdInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet otro skaitli: ");
            int fourthInput = int.Parse(Console.ReadLine());
            int minNumber = Math.Min(thirdInput, fourthInput);
            Console.WriteLine("mazākais skaitlis: {0}", minNumber);

            Console.WriteLine("Iegūsim divu skaitļu dalījuma atlikumu. Ievadiet pirmo skaitli: ");
            int fifthInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet otro skaitli: ");
            int sixthInput = int.Parse(Console.ReadLine());
            int Remainder = fifthInput / sixthInput;
            Console.WriteLine("Abu skaitļu dalījums ir: " + Remainder);

            Console.WriteLine("Noskaidrosim, vai skaitlis ir pāra vai nepāra. Ievadiet skaitli: ");
            int seventhInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Vai šis is ir pāra skaitlis? " + (seventhInput % 2 == 0));

            Console.WriteLine("Aprēķināsim taisnstūra laukumu. Ievadiet malas A garumu: ");
            float eigthInput = float.Parse(Console.ReadLine());

            Console.WriteLine("Ievadiet malas B garumu: ");
            float ninthInput = float.Parse(Console.ReadLine());
            float Result = eigthInput * ninthInput;
            double rounded = Math.Round(Result, 2);

            Console.WriteLine("Taisnstūra laukums ir: " + rounded);

            Console.WriteLine("Aprēķināsim vienādsānu trijstūra laukumu. Ievadiet katetes garumu: ");
            float sideLength = float.Parse(Console.ReadLine());
            double area = (Math.Sqrt(3) / 4) * (sideLength * sideLength);

            Console.WriteLine("Trijstūra laukums ir: " + area);

            Console.WriteLine("Kāds ir tavs vārds? ");
            string userName1 = Console.ReadLine();

            Console.WriteLine("Kāds ir tavs vecums? ");
            int age1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sveiks, " + userName1 + ", Tavs vecums ir " + age1 + " gadi. ");
        }

    }
}
