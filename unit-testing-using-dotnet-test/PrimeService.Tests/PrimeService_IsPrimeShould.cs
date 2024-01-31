using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;
        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
   
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        public void IsPrime_ReturnTrue(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.True(result, $"{value} is prime");
        }

    }
}