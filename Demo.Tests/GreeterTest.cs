using NUnit.Framework;

namespace Demo.Tests
{
    [TestFixture]
    public class GreeterTest
    {
        [Test]
        public void SaysHello()
        {
            var greeter = new Greeter();
            var greet = greeter.Greet();
            Assert.That(greet, Contains.Substring("hello"));
        }
    }
}
