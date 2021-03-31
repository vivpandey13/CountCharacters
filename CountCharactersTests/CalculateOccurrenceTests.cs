using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountCharacters.Tests
{
    [TestClass()]
    public class CalculateOccurrenceTests
    {
        [TestMethod()]
        public void VerifyFindCharacterOccurence()
        {
            //Arrange.
            CalculateOccurrence calculateOccurrence = new CalculateOccurrence("Techterm");
            calculateOccurrence.FindCharacterOccureceInString();

            //Act.
            var result = calculateOccurrence.FilterValidData();

            //Assert.
            
            Assert.IsTrue(result.Exists(x => x.Character == 'T' && x.Occurrence == 2));
            Assert.IsTrue(result.Exists(x => x.Character == 'E' && x.Occurrence == 2));
            Assert.IsTrue(result.Exists(x => x.Character == 'M' && x.Occurrence == 1));
        }
    }
}