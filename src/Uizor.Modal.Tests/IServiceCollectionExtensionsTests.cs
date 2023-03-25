using Microsoft.Extensions.DependencyInjection;

namespace Uizor.Modal.Tests
{
    public class IServiceCollectionExtensionsTests
    {
        [Fact(DisplayName ="Checks that we are return the servicecollection.")]
        public void AddUizorModel01()
        {
            //arrange
            var serviceCollection = new ServiceCollection();


            //act
            var result = serviceCollection.AddUizorModal();

            //assert
            Assert.NotNull(result);
            Assert.Equal(serviceCollection, result);
        }

        [Fact(DisplayName = "Checks that we throwing a exception if the arg is NULL.")]
        public void AddUizorModel02()
        {
            //arrange
            ServiceCollection? serviceCollection = null;

            //act
#pragma warning disable CS8604 // Mögliches Nullverweisargument.
            Assert.Throws<ArgumentNullException>(() => IServiceCollectionExtensions.AddUizorModal(serviceCollection));
#pragma warning restore CS8604 // Mögliches Nullverweisargument.

        }

    }
}