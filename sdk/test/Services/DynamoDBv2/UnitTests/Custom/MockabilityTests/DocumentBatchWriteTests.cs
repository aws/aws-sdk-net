using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class DocumentBatchWriteTests
    {
        [TestMethod]
        public void TestMockability_DocumentBatchWrite()
        {
            var itemsToPut = new List<Document>();
            var inMemoryTable = new List<Document>();

            var mockTable = new Mock<ITable>();
            mockTable.Setup(x => x.CreateBatchWrite()).Returns(CreateDocumentBatchWriteMock(itemsToPut, inMemoryTable));
            var table = mockTable.Object;

            var batchWrite = table.CreateBatchWrite();

            Assert.AreEqual(0, inMemoryTable.Count);
            Assert.AreEqual(0, itemsToPut.Count);

            batchWrite.AddDocumentToPut(new Document { { "key1", "value1" } });
            batchWrite.AddDocumentToPut(new Document { { "key2", "value2" } });
            Assert.AreEqual(2, itemsToPut.Count);
            Assert.AreEqual(0, inMemoryTable.Count);

            batchWrite.Execute();
            Assert.AreEqual(0, itemsToPut.Count);
            Assert.AreEqual(2, inMemoryTable.Count);

            var firstDoc = inMemoryTable.First();
            Assert.AreEqual("value1", firstDoc["key1"].AsString());
            
            var secondDoc = inMemoryTable.Skip(1).First();
            Assert.AreEqual("value2", secondDoc["key2"].AsString());
        }

        [TestMethod]
        public void TestMockability_MultiTableDocumentBatchWrite()
        {
            var itemsToPut_table1 = new List<Document>();
            var inMemory_table1 = new List<Document>();
            var batchWrite_table1 = CreateDocumentBatchWriteMock(itemsToPut_table1, inMemory_table1);
            batchWrite_table1.AddDocumentToPut(new Document { { "key1", "value1" } });

            var itemsToPut_table2 = new List<Document>();
            var inMemory_table2 = new List<Document>();
            var batchWrite_table2 = CreateDocumentBatchWriteMock(itemsToPut_table2, inMemory_table2);
            batchWrite_table2.AddDocumentToPut(new Document { { "key2", "value2" } });

            var multiBatchWrite = CreateMultiTableDocumentBatchWriteMock();
            multiBatchWrite.AddBatch(batchWrite_table1);
            multiBatchWrite.AddBatch(batchWrite_table2);

            Assert.AreEqual(0, inMemory_table1.Count);
            Assert.AreEqual(0, inMemory_table2.Count);

            multiBatchWrite.Execute();
            Assert.AreEqual(1, inMemory_table1.Count);
            Assert.AreEqual(1, inMemory_table2.Count);
            Assert.AreEqual("value1", inMemory_table1.First()["key1"].AsString());
            Assert.AreEqual("value2", inMemory_table2.First()["key2"].AsString());
        }

        public IDocumentBatchWrite CreateDocumentBatchWriteMock(List<Document> itemsToPut, List<Document> inMemoryTable)
        {
            var batchWrite = new Mock<IDocumentBatchWrite>();

            batchWrite
                .Setup(x => x.AddDocumentToPut(It.IsAny<Document>()))
                .Callback((Document item) => itemsToPut.Add(item));

            batchWrite.
                Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var item in itemsToPut)
                    {
                        inMemoryTable.Add(item);
                    }

                    itemsToPut.Clear();
                });

            return batchWrite.Object;
        }

        public IMultiTableDocumentBatchWrite CreateMultiTableDocumentBatchWriteMock()
        {
            var multiBatchWrite = new Mock<IMultiTableDocumentBatchWrite>();
            var batches = new List<IDocumentBatchWrite>();

            multiBatchWrite
                .Setup(x => x.AddBatch(It.IsAny<IDocumentBatchWrite>()))
                .Callback((IDocumentBatchWrite batch) =>
                {
                    batches.Add(batch);
                });

            multiBatchWrite
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var batch in batches)
                    {
                        batch.Execute();
                    }
                });

            return multiBatchWrite.Object;
        }
    }
}
