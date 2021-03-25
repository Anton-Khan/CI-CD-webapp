using CI_CD_webapp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CI_CD_UnitTest
{
    [TestClass]
    public class GreetingTest
    {
        [TestMethod]
        public void GreetMeTest()
        {
            ViewRepository repo = new ViewRepository();
            string expectedGreeting = "Hello Anton";
            string actualGreeting;

            actualGreeting = repo.GreetMe("Anton");

            Assert.AreEqual(expectedGreeting, actualGreeting);

        }
    }
}
