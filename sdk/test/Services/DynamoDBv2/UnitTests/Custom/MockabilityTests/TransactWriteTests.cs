using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class TransactWriteTests
    {
        [TestMethod]
        public void TestMockability_TransactWrite()
        {
            var itemsToSave = new List<string>();
            var inMemoryTable = new List<string>();

            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateTransactWrite<string>())
                .Returns(CreateTransactWriteMock(itemsToSave, inMemoryTable));

            var ddbContext = mockContext.Object;
            var transactWrite = ddbContext.CreateTransactWrite<string>();

            Assert.AreEqual(0, inMemoryTable.Count);
            Assert.AreEqual(0, itemsToSave.Count);

            transactWrite.AddSaveItem("item1");
            transactWrite.AddSaveItem("item2");
            Assert.AreEqual(2, itemsToSave.Count);
            Assert.AreEqual(0, inMemoryTable.Count);

            transactWrite.Execute();
            Assert.AreEqual(0, itemsToSave.Count);
            Assert.AreEqual(2, inMemoryTable.Count);
            Assert.IsTrue(inMemoryTable.Contains("item1"));
            Assert.IsTrue(inMemoryTable.Contains("item2"));
        }

        [TestMethod]
        public void TestMockability_MultiTableTransactWrite()
        {
            var itemsToSave_table1 = new List<string>();
            var inMemory_table1 = new List<string>();
            var transactWrite_table1 = CreateTransactWriteMock(itemsToSave_table1, inMemory_table1);
            transactWrite_table1.AddSaveItem("item1");

            var itemsToSave_table2 = new List<string>();
            var inMemory_table2 = new List<string>();
            var transactWrite_table2 = CreateTransactWriteMock(itemsToSave_table2, inMemory_table2);
            transactWrite_table2.AddSaveItem("item2");

            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateMultiTableTransactWrite())
                .Returns(CreateMultiTableTransactWriteMock());

            var ddbContext = mockContext.Object;
            var multiTransactWrite = ddbContext.CreateMultiTableTransactWrite();
            multiTransactWrite.AddTransactionPart(transactWrite_table1);
            multiTransactWrite.AddTransactionPart(transactWrite_table2);

            Assert.AreEqual(0, inMemory_table1.Count);
            Assert.AreEqual(0, inMemory_table2.Count);

            multiTransactWrite.Execute();
            Assert.AreEqual(1, inMemory_table1.Count);
            Assert.AreEqual(1, inMemory_table2.Count);
            Assert.IsTrue(inMemory_table1.Contains("item1"));
            Assert.IsTrue(inMemory_table2.Contains("item2"));
        }

        public ITransactWrite<T> CreateTransactWriteMock<T>(List<T> itemsToSave, List<T> inMemoryTable)
        {
            var transactWrite = new Mock<ITransactWrite<T>>();

            transactWrite
                .Setup(x => x.AddSaveItem(It.IsAny<T>()))
                .Callback((T item) => itemsToSave.Add(item));

            transactWrite.
                Setup(x => x.Execute())
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

        public IMultiTableTransactWrite CreateMultiTableTransactWriteMock()
        {
            var multiTransactWrite = new Mock<IMultiTableTransactWrite>();
            var transactionParts = new List<ITransactWrite>();

            multiTransactWrite
                .Setup(x => x.AddTransactionPart(It.IsAny<ITransactWrite>()))
                .Callback((ITransactWrite transactionPart) =>
                {
                    transactionParts.Add(transactionPart);
                });

            multiTransactWrite
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var batch in transactionParts)
                    {
                        batch.Execute();
                    }
                });

            return multiTransactWrite.Object;
        }
    }
}
