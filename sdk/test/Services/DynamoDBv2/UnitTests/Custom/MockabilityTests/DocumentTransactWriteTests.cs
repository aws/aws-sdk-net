using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class DocumentTransactWriteTests
    {
        [TestMethod]
        public void TestMockability_DocumentTransactWrite()
        {
            var itemsToPut = new List<Document>();
            var inMemoryTable = new List<Document>();

            var mockTable = new Mock<ITable>();
            mockTable.Setup(x => x.CreateTransactWrite()).Returns(CreateDocumentTransactWriteMock(itemsToPut, inMemoryTable));
            var table = mockTable.Object;

            var docTransactWrite = table.CreateTransactWrite();

            Assert.AreEqual(0, inMemoryTable.Count);
            Assert.AreEqual(0, itemsToPut.Count);

            docTransactWrite.AddDocumentToPut(new Document { { "key1", "value1" } });
            docTransactWrite.AddDocumentToPut(new Document { { "key2", "value2" } });
            Assert.AreEqual(2, itemsToPut.Count);
            Assert.AreEqual(0, inMemoryTable.Count);

            docTransactWrite.Execute();
            Assert.AreEqual(0, itemsToPut.Count);
            Assert.AreEqual(2, inMemoryTable.Count);

            var firstDoc = inMemoryTable.First();
            Assert.AreEqual("value1", firstDoc["key1"].AsString());

            var secondDoc = inMemoryTable.Skip(1).First();
            Assert.AreEqual("value2", secondDoc["key2"].AsString());
        }

        [TestMethod]
        public void TestMockability_MultiTableDocumentTransactWrite()
        {
            var itemsToPut_table1 = new List<Document>();
            var inMemory_table1 = new List<Document>();
            var transactWrite_table1 = CreateDocumentTransactWriteMock(itemsToPut_table1, inMemory_table1);
            transactWrite_table1.AddDocumentToPut(new Document { { "key1", "value1" } });

            var itemsToPut_table2 = new List<Document>();
            var inMemory_table2 = new List<Document>();
            var transactWrite_table2 = CreateDocumentTransactWriteMock(itemsToPut_table2, inMemory_table2);
            transactWrite_table2.AddDocumentToPut(new Document { { "key2", "value2" } });

            var multiTransactWrite = CreateMultiTableDocumentTransactWrite();
            multiTransactWrite.AddTransactionPart(transactWrite_table1);
            multiTransactWrite.AddTransactionPart(transactWrite_table2);

            Assert.AreEqual(0, inMemory_table1.Count);
            Assert.AreEqual(0, inMemory_table2.Count);

            multiTransactWrite.Execute();
            Assert.AreEqual(1, inMemory_table1.Count);
            Assert.AreEqual(1, inMemory_table2.Count);
            Assert.AreEqual("value1", inMemory_table1.First()["key1"].AsString());
            Assert.AreEqual("value2", inMemory_table2.First()["key2"].AsString());
        }

        public IDocumentTransactWrite CreateDocumentTransactWriteMock(List<Document> itemsToSave, List<Document> inMemoryTable)
        {
            var transactWrite = new Mock<IDocumentTransactWrite>();

            transactWrite
                .Setup(x => x.AddDocumentToPut(It.IsAny<Document>(), It.IsAny<TransactWriteItemOperationConfig>()))
                .Callback((Document item, TransactWriteItemOperationConfig config) => itemsToSave.Add(item));

            transactWrite
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var item in itemsToSave)
                    {
                        inMemoryTable.Add(item);
                    }
                    itemsToSave.Clear();
                });

            return transactWrite.Object;
        }

        public IMultiTableDocumentTransactWrite CreateMultiTableDocumentTransactWrite()
        {
            var multiTransactWrite = new Mock<IMultiTableDocumentTransactWrite>();
            var transactionParts = new List<IDocumentTransactWrite>();

            multiTransactWrite
                .Setup(x => x.AddTransactionPart(It.IsAny<IDocumentTransactWrite>()))
                .Callback((IDocumentTransactWrite part) =>
                {
                    transactionParts.Add(part);
                });

            multiTransactWrite
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var part in transactionParts)
                    {
                        part.Execute();
                    }
                });

            return multiTransactWrite.Object;
        }
    }
}
