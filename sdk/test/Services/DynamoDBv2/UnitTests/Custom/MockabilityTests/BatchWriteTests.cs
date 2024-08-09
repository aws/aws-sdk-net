using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class BatchWriteTests
    {
        [TestMethod]
        public void TestMockability_BatchWrite()
        {
            var itemsToPut = new List<string>();
            var inMemoryTable = new List<string>();

            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateBatchWrite<string>())
                .Returns(CreateBatchWriteMock(itemsToPut, inMemoryTable));

            var ddbContext = mockContext.Object;
            var batchWrite = ddbContext.CreateBatchWrite<string>();

            Assert.AreEqual(0, inMemoryTable.Count);
            Assert.AreEqual(0, itemsToPut.Count);

            batchWrite.AddPutItem("item1");
            batchWrite.AddPutItem("item2");
            Assert.AreEqual(2, itemsToPut.Count);
            Assert.AreEqual(0, inMemoryTable.Count);

            batchWrite.Execute();
            Assert.AreEqual(0, itemsToPut.Count);
            Assert.AreEqual(2, inMemoryTable.Count);
            Assert.IsTrue(inMemoryTable.Contains("item1"));
            Assert.IsTrue(inMemoryTable.Contains("item2"));
        }

        [TestMethod]
        public void TestMockability_MultiTableBatchWrite()
        {
            var itemsToPut_table1 = new List<string>();
            var inMemory_table1 = new List<string>();
            var batchWrite_table1 = CreateBatchWriteMock(itemsToPut_table1, inMemory_table1);
            batchWrite_table1.AddPutItem("item1");

            var itemsToPut_table2 = new List<string>();
            var inMemory_table2 = new List<string>();
            var batchWrite_table2 = CreateBatchWriteMock(itemsToPut_table2, inMemory_table2);
            batchWrite_table2.AddPutItem("item2");

            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateMultiTableBatchWrite())
                .Returns(CreateMultiTableBatchWriteMock());

            var ddbContext = mockContext.Object;
            var multiBatchWrite = ddbContext.CreateMultiTableBatchWrite();
            multiBatchWrite.AddBatch(batchWrite_table1);
            multiBatchWrite.AddBatch(batchWrite_table2);

            Assert.AreEqual(0, inMemory_table1.Count);
            Assert.AreEqual(0, inMemory_table2.Count);

            multiBatchWrite.Execute();
            Assert.AreEqual(1, inMemory_table1.Count);
            Assert.AreEqual(1, inMemory_table2.Count);
            Assert.IsTrue(inMemory_table1.Contains("item1"));
            Assert.IsTrue(inMemory_table2.Contains("item2"));
        }

        public IBatchWrite<T> CreateBatchWriteMock<T>(List<T> itemsToPut, List<T> inMemoryTable)
        {
            var batchWrite = new Mock<IBatchWrite<T>>();

            batchWrite
                .Setup(x => x.AddPutItem(It.IsAny<T>()))
                .Callback((T item) => itemsToPut.Add(item));

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

        public IMultiTableBatchWrite CreateMultiTableBatchWriteMock()
        {
            var multiBatchWrite = new Mock<IMultiTableBatchWrite>();
            var batches = new List<IBatchWrite>();

            multiBatchWrite
                .Setup(x => x.AddBatch(It.IsAny<IBatchWrite>()))
                .Callback((IBatchWrite batch) =>
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
