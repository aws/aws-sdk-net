using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class DocumentSearchTests
    {
        [TestMethod]
        public void TestMockability_DocumentSearch()
        {
            var search = CreateSearchMock(new List<Document>()
            {
                new Document(){ {"id", 1}, {"name", "Bob"} },
                new Document(){ {"id", 2}, {"name", "Tom"} }
            });

            var results = search.GetNextSet();
            Assert.AreEqual(2, results.Count);

            Assert.AreEqual(1, results[0]["id"].AsInt());
            Assert.AreEqual("Bob", results[0]["name"].AsString());

            Assert.AreEqual(2, results[1]["id"].AsInt());
            Assert.AreEqual("Tom", results[1]["name"].AsString());
        }

        public ISearch CreateSearchMock(List<Document> dummyResults)
        {
            var search = new Mock<ISearch>();

            search
                .Setup(x => x.GetNextSet())
                .Returns(dummyResults);

            return search.Object;
         }
    }
}
