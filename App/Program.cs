using Core;

namespace App
{
    /// <summary>
    /// Hlavní třída aplikace, která obsahuje vstupní bod programu.
    /// Spouští validaci hesla a následně interaktivní konzolovou kalkulačku.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Vstupní bod programu (Main metoda).
        /// Uživatel nejprve zadá heslo, které je ověřeno pomocí třídy <see cref="HesloValidator"/>.
        /// Po úspěšném ověření je spuštěna jednoduchá konzolová kalkulačka s možností
        /// provádět základní aritmetické operace.
        /// </summary>
        /// <param name="args">Argumenty příkazové řádky (nepoužívají se).</param>
        static void Main(string[] args)
        {
            // Inicializace validátoru hesla
            var validator = new HesloValidator();

            Console.Write("Zadej heslo: ");
            string heslo = Console.ReadLine();

            // Opakované zadávání hesla, dokud není validní
            while (!validator.IsValidPassword(heslo))
            {
                Console.WriteLine("Heslo není validní. Musí mít minimálně 6 znaků a obsahovat číslici.");
                Console.Write("Zadej heslo znovu: ");
                heslo = Console.ReadLine();
            }

            Console.WriteLine("Heslo ověřeno. Vítejte v kalkulačce!");

            // Vytvoření instance kalkulačky
            var kalkulacka = new Kalkulacka();
            bool konec = false;

            // Hlavní smyčka menu kalkulačky
            while (!konec)
            {
                Console.WriteLine("1) Ruční zadání operandů a výpis operací");
                Console.WriteLine("2) Statický součet a+b");
                Console.WriteLine("3) Statický rozdíl a-b");
                Console.WriteLine("4) Statický součin a*b");
                Console.WriteLine("5) Bezpečné dělení (PodilSafe)");
                Console.WriteLine("0) Konec");
                Console.Write("Volba: ");

                var volba = Console.ReadLine();
                double a, b;

                // Zpracování volby uživatele
                switch (volba)
                {
                    /// <summary>
                    /// Volba 1 — ruční zadání čísel a výpis všech základních operací.
                    /// </summary>
                    case "1":
                        Console.Write("a = ");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.Write("b = ");
                        if (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        kalkulacka.Cislo1 = a;
                        kalkulacka.Cislo2 = b;

                        Console.WriteLine($"Součet: {kalkulacka.Soucet()}");
                        Console.WriteLine($"Rozdíl: {kalkulacka.Rozdil()}");
                        Console.WriteLine($"Součin: {kalkulacka.Soucin()}");
                        Console.WriteLine($"Podíl: {kalkulacka.Podil()}");
                        break;

                    /// <summary>
                    /// Volba 2 — výpočet součtu pomocí statické metody <see cref="Kalkulacka.Soucet(double, double)"/>.
                    /// </summary>
                    case "2":
                        Console.Write("a = ");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.Write("b = ");
                        if (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.WriteLine($"Součet: {Kalkulacka.Soucet(a, b)}");
                        break;

                    /// <summary>
                    /// Volba 3 — výpočet rozdílu pomocí statické metody <see cref="Kalkulacka.Rozdil(double, double)"/>.
                    /// </summary>
                    case "3":
                        Console.Write("a = ");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.Write("b = ");
                        if (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.WriteLine($"Rozdíl: {Kalkulacka.Rozdil(a, b)}");
                        break;

                    /// <summary>
                    /// Volba 4 — výpočet součinu pomocí statické metody <see cref="Kalkulacka.Soucin(double, double)"/>.
                    /// </summary>
                    case "4":
                        Console.Write("a = ");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.Write("b = ");
                        if (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.WriteLine($"Součin: {Kalkulacka.Soucin(a, b)}");
                        break;

                    /// <summary>
                    /// Volba 5 — bezpečné dělení (ošetřuje dělení nulou).
                    /// </summary>
                    case "5":
                        Console.Write("dividend = ");
                        if (!double.TryParse(Console.ReadLine(), out a))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        Console.Write("divisor = ");
                        if (!double.TryParse(Console.ReadLine(), out b))
                        {
                            Console.WriteLine("Neplatný vstup."); 
                            break;
                        }

                        try
                        {
                            Console.WriteLine($"Výsledek: {Kalkulacka.PodilSafe(a, b)}");
                        }

                        catch (DivideByZeroException exception)
                        {
                            Console.WriteLine(exception.Message);
                        }
                        break;

                    /// <summary>
                    /// Volba 0 — ukončení programu.
                    /// </summary>
                    case "0":
                        konec = true;
                        break;

                    default:
                        Console.WriteLine("Neplatná volba.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("Konec programu. Stiskni libovolnou klávesu.");
            Console.ReadKey();
        }
    }
}
