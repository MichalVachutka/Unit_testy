using Core;

namespace UnitTesty.Tests
{
    /// <summary>
    /// Sada testů pro třídu <see cref="HesloValidator"/>.
    /// Ověřuje základní scénáře validace hesla (platné/ neplatné vstupy).
    /// </summary>
    public class TestHeslo
    {
        /// <summary>
        /// Ověřuje, že metoda správně vyhodnocuje platnost hesla podle zadaných kritérií.
        /// </summary>
        /// <param name="vstupniHeslo">Heslo, které se testuje.</param>
        /// <param name="ocekavanyVysledek">Očekávaný výsledek validace (true = platné heslo).</param>
        [Theory]
        [InlineData("Heslo123", true)]
        [InlineData("kratke", false)]
        [InlineData("", false)]
        [InlineData("BezCislic", false)]
        public void OtestujPlatnostHesla(string vstupniHeslo, bool ocekavanyVysledek)
        {
            var validator = new HesloValidator();
            Assert.Equal(ocekavanyVysledek, validator.IsValidPassword(vstupniHeslo));
        }
    }
}
