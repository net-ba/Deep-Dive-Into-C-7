using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JakubSturc.CSharp7DeepDive.Examples.OutParameters
{
    [TestClass]
    public class OutVariablesExample
    {
        public bool Convert(string str, out int i)
        {
            return int.TryParse(str, out i);
        }

        [TestMethod]
        public void Using_out_CSharp6()
        {
            int i;
            var res = Convert("123", out i);

            Assert.IsTrue(res);
            Assert.AreEqual(123, i);
        }

        [TestMethod]
        public void Using_out_CSharp7_with_explicit_type_declaration()
        {
            var res = Convert("123", out int i);

            Assert.IsTrue(res);
            Assert.AreEqual(123, i);
        }

        [TestMethod]
        public void Using_out_CSharp7_with_var()
        {
            var res = Convert("abc", out var i);

            Assert.IsFalse(res);
            Assert.AreEqual(0, i);
        }

        public void Using_out_CSharp7_ingnoring_out()
        {            
            var res1 = Convert("abc", out _);
            var res2 = Convert("42", out _);            

            Assert.IsFalse(res1);
            Assert.IsTrue(res2);            
        }
    }
}
