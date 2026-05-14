using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class DocumentBatchGetTests
    {
        [TestMethod]
        public async Task TestMockability_DocumentBatchGet()
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
            mockTable.Setup(x => x.CreateBatchGet()).Returns(CreateDocumentBatchGetMock(dummyResults));
            var table = mockTable.Object;

            var docBatchGet = table.CreateBatchGet();

            Assert.AreEqual(0, docBatchGet.TotalKeys);
            Assert.AreEqual(0, docBatchGet.Results.Count);

            docBatchGet.AddKey("State");
            Assert.AreEqual(1, docBatchGet.TotalKeys);

            await docBatchGet.ExecuteAsync(CancellationToken.None);
            Assert.AreEqual(1, docBatchGet.Results.Count);
            Assert.AreEqual("CA", docBatchGet.Results[0]["State"].AsString());
            Assert.AreEqual("12345", docBatchGet.Results[0]["Zip"].AsString());
        }

        [TestMethod]
        public async Task TestMockability_MultiTableDocumentBatchGet()
        {
            var addressBatchGet = CreateDocumentBatchGetMock(new List<Document>
            {
                new Document()
                {
                    {"State", "CA"},
                    {"Zip", "12345"}
                }
            });

            var personBatchGet = CreateDocumentBatchGetMock(new List<Document>
            {
                new Document()
                {
                    {"FirstName", "John"},
                    {"LastName", "Doe"}
                }
            });

            var multiBatchGet = CreateMultiTableDocumentBatchGetMock();
            multiBatchGet.AddBatch(addressBatchGet);
            multiBatchGet.AddBatch(personBatchGet);

            Assert.AreEqual(0, multiBatchGet.TotalKeys);
            Assert.AreEqual(0, addressBatchGet.Results.Count);
            Assert.AreEqual(0, personBatchGet.Results.Count);

            addressBatchGet.AddKey("CA");
            personBatchGet.AddKey("John");
            Assert.AreEqual(2, multiBatchGet.TotalKeys);

            await multiBatchGet.ExecuteAsync(CancellationToken.None);

            Assert.AreEqual(1, addressBatchGet.Results.Count);
            Assert.AreEqual("CA", addressBatchGet.Results[0]["State"].AsString());
            Assert.AreEqual("12345", addressBatchGet.Results[0]["Zip"].AsString());

            Assert.AreEqual(1, personBatchGet.Results.Count);
            Assert.AreEqual("John", personBatchGet.Results[0]["FirstName"].AsString());
            Assert.AreEqual("Doe", personBatchGet.Results[0]["LastName"].AsString());
        }

        public IDocumentBatchGet CreateDocumentBatchGetMock(List<Document> results)
        {
            var documentBatchGet = new Mock<IDocumentBatchGet>();
            var dummyResults = new List<Document>();
            var keys = new List<string>();

            documentBatchGet
                .Setup(x => x.ExecuteAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask)
                .Callback(() =>
                {
                    dummyResults.Clear();
                    dummyResults.AddRange(results);
                });

            documentBatchGet
                .Setup(x => x.Results)
                .Returns(dummyResults);

            documentBatchGet
                .Setup(x => x.AddKey(It.IsAny<Primitive>()))
                .Callback((Primitive hashKey) =>
                {
                    keys.Add(hashKey.AsString());
                });

            documentBatchGet
               .SetupGet(x => x.TotalKeys)
               .Returns(() => keys.Count);

            return documentBatchGet.Object;
        }

        public IMultiTableDocumentBatchGet CreateMultiTableDocumentBatchGetMock()
        {
            var multiBatchGet = new Mock<IMultiTableDocumentBatchGet>();
            var batches = new List<IDocumentBatchGet>();

            multiBatchGet
                .Setup(x => x.ExecuteAsync(It.IsAny<CancellationToken>()))
                .Returns(async () =>
                {
                    foreach (var batch in batches)
                    {
                        await batch.ExecuteAsync(CancellationToken.None);
                    }
                });

            multiBatchGet
                .Setup(x => x.AddBatch(It.IsAny<IDocumentBatchGet>()))
                .Callback((IDocumentBatchGet batch) =>
                {
                    batches.Add(batch);
                });

            multiBatchGet.
                SetupGet(x => x.TotalKeys)
                .Returns(() =>
                {
                    var totalKeys = 0;
                    foreach (var batch in batches)
                    {
                        totalKeys += batch.TotalKeys;
                    }
                    return totalKeys;
                });

            return multiBatchGet.Object;
        }
    }
}
