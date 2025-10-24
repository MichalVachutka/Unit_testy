
namespace Core
{
    /// <summary>
    /// Reprezentuje jednoduchou kalkulačku s dvěma operandy a základními aritmetickými operacemi.
    /// </summary>
    public class Kalkulacka
    {
        /// <summary>
        /// První operand používaný při instančních operacích.
        /// </summary>
        public double Cislo1 { get; set; }

        /// <summary>
        /// Druhý operand používaný při instančních operacích.
        /// </summary>
        public double Cislo2 { get; set; }

        /// <summary>
        /// Vrátí součet <see cref="Cislo1"/> a <see cref="Cislo2"/>.
        /// </summary>
        /// <returns>Součet obou operandů jako <see cref="double"/>.</returns>
        public double Soucet() => Cislo1 + Cislo2;

        /// <summary>
        /// Vrátí rozdíl <see cref="Cislo1"/> - <see cref="Cislo2"/>.
        /// </summary>
        /// <returns>Rozdíl obou operandů jako <see cref="double"/>.</returns>
        public double Rozdil() => Cislo1 - Cislo2;

        /// <summary>
        /// Vrátí součin <see cref="Cislo1"/> a <see cref="Cislo2"/>.
        /// </summary>
        /// <returns>Součin obou operandů jako <see cref="double"/>.</returns>
        public double Soucin() => Cislo1 * Cislo2;

        /// <summary>
        /// Vrátí podíl <see cref="Cislo1"/> / <see cref="Cislo2"/> podle pravidel IEEE (může vrátit ±Infinity nebo NaN).
        /// </summary>
        /// <returns>Podíl obou operandů jako <see cref="double"/>.</returns>
        public double Podil() => Cislo1 / Cislo2;

        /// <summary>
        /// Bezpečná statická metoda pro dělení, která při dělení nulou vyhodí výjimku.
        /// </summary>
        /// <param name="dělenec">Číslo, které je děleno (numerátor).</param>
        /// <param name="dělitel">Číslo, kterým se dělí (denominátor).</param>
        /// <returns>Výsledek dělení jako <see cref="double"/>.</returns>
        /// <exception cref="DivideByZeroException">Vyhozeno pokud <paramref name="dělitel"/> je 0.</exception>
        public static double PodilSafe(double dělenec, double dělitel)
        {
            if (dělitel == 0) throw new DivideByZeroException("Dělení nulou není povoleno.");
            return dělenec / dělitel;
        }

        /// <summary>
        /// Statická pomocná metoda vracející součet dvou čísel.
        /// Užitečné pro rychlé volání z testů bez vytváření instance.
        /// </summary>
        /// <param name="a">První sčítanec.</param>
        /// <param name="b">Druhý sčítanec.</param>
        /// <returns>Součet <paramref name="a"/> a <paramref name="b"/>.</returns>
        public static double Soucet(double a, double b) => a + b;

        /// <summary>
        /// Statická metoda vracející rozdíl (a - b).
        /// </summary>
        /// <param name="a">Minuend (číslo, ze kterého se odčítá).</param>
        /// <param name="b">Subtrahend (číslo, které se odečítá).</param>
        /// <returns>Rozdíl <paramref name="a"/> - <paramref name="b"/>.</returns>
        public static double Rozdil(double a, double b) => a - b;

        /// <summary>
        /// Statická metoda vracející součin dvou čísel.
        /// </summary>
        /// <param name="a">První činitel.</param>
        /// <param name="b">Druhý činitel.</param>
        /// <returns>Součin <paramref name="a"/> a <paramref name="b"/>.</returns>
        public static double Soucin(double a, double b) => a * b;
    }
}
