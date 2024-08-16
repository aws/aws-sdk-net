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
        public void TestMockability_DocumentScan()
        {
            var mockTable = new Mock<ITable>();
            mockTable
                .Setup(x => x.Scan(It.IsAny<ScanOperationConfig>()))
                .Returns(CreateSearchMock(new List<Document>()
                {
                    new Document(){ {"id", 1}, {"name", "Bob"} },
                    new Document(){ {"id", 2}, {"name", "Tom"} }
                }));
            var table = mockTable.Object;

            var search = table.Scan((ScanOperationConfig)null);

            var results = search.GetNextSet();
            Assert.AreEqual(2, results.Count);

            Assert.AreEqual(1, results[0]["id"].AsInt());
            Assert.AreEqual("Bob", results[0]["name"].AsString());

            Assert.AreEqual(2, results[1]["id"].AsInt());
            Assert.AreEqual("Tom", results[1]["name"].AsString());
        }

        [TestMethod]
        public void TestMockability_DocumentQuery()
        {
            var mockTable = new Mock<ITable>();
            mockTable
                .Setup(x => x.Query(It.IsAny<QueryOperationConfig>()))
                .Returns(CreateSearchMock(new List<Document>()
                {
                    new Document(){ {"id", 1}, {"name", "Bob"} },
                    new Document(){ {"id", 2}, {"name", "Tom"} }
                }));
            var table = mockTable.Object;

            var search = table.Query((QueryOperationConfig)null);

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
