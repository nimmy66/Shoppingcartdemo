using NUnit.Framework;

namespace ShoppingCart.Test
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

      
         [Test]
            public void TestAdd()
            {
                var result = Addition(1, 2);

                Assert.AreEqual(3, result);
            }
            public int Addition(int a, int b)
            {
                return a + b;
            }
        [TestCase(12, 3, 4)]
        [TestCase(12, 2, 6)]
        [TestCase(12, 4, 3)]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

    }
    }