
namespace Core
{
    /// <summary>
    /// Jednoduchá validace hesla: minimální délka 6 znaků a alespoň jedna číslice.
    /// </summary>
    public class HesloValidator
    {
        /// <summary>
        /// Ověří, zda zadané heslo splňuje definovaná pravidla.
        /// </summary>
        /// <param name="heslo">Heslo, které se ověřuje.</param>
        /// <returns>
        /// <c>true</c>, pokud heslo není null/empty, má délku alespoň 6 znaků a obsahuje
        /// alespoň jednu číslici; jinak <c>false</c>.
        /// </returns>
        /// </summary>
        public bool IsValidPassword(string heslo)
        {
            if (string.IsNullOrEmpty(heslo) || heslo.Length < 6)
                return false;

            return heslo.Any(char.IsDigit);
        }
    }
}
