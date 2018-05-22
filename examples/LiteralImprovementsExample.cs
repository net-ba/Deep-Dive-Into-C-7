using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JakubSturc.CSharp7DeepDive.Examples.OutParameters
{
    [TestClass]
    public class LiteralImprovementsExample
    {
        [TestMethod]
        public void Numeric_Literals_Are_Fun()
        {
            Assert.AreEqual(10000000, 10_000_000); 
            Assert.AreEqual(42, 0b0010_1010);      
            Assert.AreEqual(42, 0b_0010_1010);     
            Assert.AreEqual(42, 0x__2A);
            Assert.AreEqual(42F, 42D, delta : 0.000_001D);
        }
    }
}
