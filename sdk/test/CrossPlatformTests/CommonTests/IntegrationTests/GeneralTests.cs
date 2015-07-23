using Amazon.Util.Internal;
using CommonTests.Framework;
using NUnit.Framework;
using System.Linq;

namespace CommonTests.IntegrationTests
{
    /// <summary>
    /// Test class for testing various AWS protocols.
    /// </summary>
    [TestFixture]
    public class GeneralTests
    {
        [Test]
        public void TestITypeInfo()
        {
            var type = typeof(CommonTests.IntegrationTests.DynamoDB.DynamoDBTests.Employee3);
            var ti = TypeFactory.GetTypeInfo(type);

            Assert.IsNotNull(ti);
            //Console.WriteLine("ti is " + ti.GetType().FullName);
            var members = ti.GetMembers();
            //var text = string.Join("\r\n", members.Select(m => m.ToString()));
            //Console.WriteLine(text);
            Assert.AreEqual(32, members.Length);
        }
    }
}
