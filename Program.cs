// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bitte ebene Sie ihre erste Zahl ein: ");
double Zahl1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Bitte geben Sie ihre zweite Zahl ein: \n");
double Zahl2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("{0} + {1} = {2}", Zahl1, Zahl2, Zahl1 + Zahl2);
Console.WriteLine("{0} - {1} = {2}", Zahl1, Zahl2, Zahl1 - Zahl2);
Console.WriteLine("{0} * {1} = {2}", Zahl1, Zahl2, Zahl1 * Zahl2);
Console.WriteLine("{0} / {1} = {2}", Zahl1, Zahl2, Zahl1 / Zahl2);
Console.WriteLine("{0} % {1} = {2}", Zahl1, Zahl2, Zahl1 % Zahl2);

Console.ReadKey();  


