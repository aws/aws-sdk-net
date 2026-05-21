using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class DocumentTransactGetTests
    {
        [TestMethod]
        public async Task TestMockability_DocumentTransactGet()
        {
            var dummyResults = new List<Document>()
            {
                new Document()
                {
                    {"State", "CA"},
                    {"Zip", "12345"}
                }
            };

            var mockTable = new Mock<ITable>();
            mockTable.Setup(x => x.CreateTransactGet()).Returns(CreateDocumentTransactGetMock(dummyResults));
            var table = mockTable.Object;

            var addressTransactGet = table.CreateTransactGet();

            Assert.AreEqual(0, addressTransactGet.Results.Count);

            await addressTransactGet.ExecuteAsync(CancellationToken.None);
            Assert.AreEqual(1, addressTransactGet.Results.Count);
            Assert.AreEqual("CA", addressTransactGet.Results[0]["State"].AsString());
            Assert.AreEqual("12345", addressTransactGet.Results[0]["Zip"].AsString());
        }

        [TestMethod]
        public async Task TestMockability_MultiTableDocumentTransactGet()
        {
            var addressTransactGet = CreateDocumentTransactGetMock(new List<Document>
            {
                new Document()
                {
                    {"State", "CA"},
                    {"Zip", "12345"}
                }
            });

            var personTransactGet = CreateDocumentTransactGetMock(new List<Document>
            {
                new Document()
                {
                    {"FirstName", "John"},
                    {"LastName", "Doe"}
                }
            });

            var multiTransactGet = CreateMultiTableDocumentTransactGetMock();
            multiTransactGet.AddTransactionPart(addressTransactGet);
            multiTransactGet.AddTransactionPart(personTransactGet);

            Assert.AreEqual(0, addressTransactGet.Results.Count);
            Assert.AreEqual(0, personTransactGet.Results.Count);

            await multiTransactGet.ExecuteAsync(CancellationToken.None);

            Assert.AreEqual(1, addressTransactGet.Results.Count);
            Assert.AreEqual("CA", addressTransactGet.Results[0]["State"].AsString());
            Assert.AreEqual("12345", addressTransactGet.Results[0]["Zip"].AsString());

            Assert.AreEqual(1, personTransactGet.Results.Count);
            Assert.AreEqual("John", personTransactGet.Results[0]["FirstName"].AsString());
            Assert.AreEqual("Doe", personTransactGet.Results[0]["LastName"].AsString());
        }

        public IDocumentTransactGet CreateDocumentTransactGetMock(List<Document> results)
        {
            var transactGet = new Mock<IDocumentTransactGet>();
            var dummyResults = new List<Document>();

            transactGet
                .Setup(x => x.ExecuteAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask)
                .Callback(() =>
                {
                    dummyResults.Clear();
                    dummyResults.AddRange(results);
                });

            transactGet
                .Setup(x => x.Results)
                .Returns(dummyResults);

            return transactGet.Object;
        }

        public IMultiTableDocumentTransactGet CreateMultiTableDocumentTransactGetMock()
        {
            var multiTransactGet = new Mock<IMultiTableDocumentTransactGet>();
            var batches = new List<IDocumentTransactGet>();

            multiTransactGet
                .Setup(x => x.ExecuteAsync(It.IsAny<CancellationToken>()))
                .Returns(async () =>
                {
                    foreach (var batch in batches)
                    {
                        await batch.ExecuteAsync(CancellationToken.None);
                    }
                });

            multiTransactGet
                .Setup(x => x.AddTransactionPart(It.IsAny<IDocumentTransactGet>()))
                .Callback((IDocumentTransactGet batch) =>
                {
                    batches.Add(batch);
                });

            return multiTransactGet.Object;
        }
    }
}
