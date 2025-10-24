using Core;

namespace UnitTesty.Tests
{
    /// <summary>
    /// Testovací třída obsahující testy pro třídu <see cref="Kalkulacka"/>.
    /// Obsahuje testy instance i statických metod a také test ověřující správné zpracování dělení nulou.
    /// </summary>
    public class TestVypocty
    {
        /// <summary>
        /// Testuje instanční operace <see cref="Kalkulacka.Soucet"/>, <see cref="Kalkulacka.Rozdil"/>,
        /// <see cref="Kalkulacka.Soucin"/> a <see cref="Kalkulacka.Podil"/>.
        /// Vytvoří instanci s <c>Cislo1 = 5</c> a <c>Cislo2 = 3</c> a ověří očekávané výsledky.
        /// </summary>
        [Fact]
        public void InstanceOperations_WorkCorrectly()
        {
            var kalkulacka = new Kalkulacka { Cislo1 = 5, Cislo2 = 3 };
            Assert.Equal(8, kalkulacka.Soucet());
            Assert.Equal(2, kalkulacka.Rozdil());
            Assert.Equal(15, kalkulacka.Soucin());
            Assert.Equal(5.0 / 3.0, kalkulacka.Podil());
        }

        /// <summary>
        /// Testuje statické pomocné metody <see cref="Kalkulacka.Soucet(double,double)"/>,
        /// <see cref="Kalkulacka.Rozdil(double,double)"/> a <see cref="Kalkulacka.Soucin(double,double)"/>.
        /// Tyto metody jsou užitečné pro rychlé volání bez vytváření instance.
        /// </summary>
        [Fact]
        public void StaticOperations_WorkCorrectly()
        {
            Assert.Equal(4, Kalkulacka.Soucet(2, 2));
            Assert.Equal(0, Kalkulacka.Rozdil(2, 2));
            Assert.Equal(6, Kalkulacka.Soucin(2, 3));
        }

        /// <summary>
        /// Ověřuje, že metoda <see cref="Kalkulacka.PodilSafe(double,double)"/> vyhodí
        /// <see cref="DivideByZeroException"/> při pokusu o dělení nulou.
        /// </summary>
        [Fact]
        public void PodilSafe_ThrowsOnZero()
        {
            Assert.Throws<DivideByZeroException>(() => Kalkulacka.PodilSafe(1, 0));
        }
    }
}
