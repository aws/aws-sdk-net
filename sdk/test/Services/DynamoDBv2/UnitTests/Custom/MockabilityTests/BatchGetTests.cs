using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class BatchGetTests
    {
        [TestMethod]
        public void TestMockability_BatchGet()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateBatchGet<Address>())
                .Returns(CreateBatchGetMock(new List<Address>()
                {
                    { new Address() { State = "CA", Zip = "12345" }}
                }));

            var ddbContext = mockContext.Object;
            var addressBatchGet = ddbContext.CreateBatchGet<Address>();

            Assert.AreEqual(0, addressBatchGet.TotalKeys);
            Assert.AreEqual(0, addressBatchGet.Results.Count);

            addressBatchGet.AddKey("CA");
            Assert.AreEqual(1, addressBatchGet.TotalKeys);

            addressBatchGet.Execute();
            Assert.AreEqual(1, addressBatchGet.Results.Count);
            Assert.AreEqual("CA", addressBatchGet.Results[0].State);
            Assert.AreEqual("12345", addressBatchGet.Results[0].Zip);
        }

        [TestMethod]
        public void TestMockability_MultiTableBatchGet()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateMultiTableBatchGet())
                .Returns(CreateMultiTableBatchGetMock());

            var ddbContext = mockContext.Object;
            var multiBatchGet = ddbContext.CreateMultiTableBatchGet();

            var addressBatchGet = CreateBatchGetMock<Address>(new List<Address>
            {
                { new Address() { State = "CA", Zip = "12345" }}
            });

            var personBatchGet = CreateBatchGetMock<Person>(new List<Person>
            {
                { new Person() { FirstName = "John", LastName = "Doe" }}
            });

            multiBatchGet.AddBatch(addressBatchGet);
            multiBatchGet.AddBatch(personBatchGet);

            Assert.AreEqual(0, multiBatchGet.TotalKeys);
            Assert.AreEqual(0, addressBatchGet.Results.Count);
            Assert.AreEqual(0, personBatchGet.Results.Count);

            addressBatchGet.AddKey("CA");
            personBatchGet.AddKey("John");
            Assert.AreEqual(2, multiBatchGet.TotalKeys);

            multiBatchGet.Execute();
            Assert.AreEqual(1, addressBatchGet.Results.Count);
            Assert.AreEqual("CA", addressBatchGet.Results[0].State);
            Assert.AreEqual("12345", addressBatchGet.Results[0].Zip);
            Assert.AreEqual(1, personBatchGet.Results.Count);
            Assert.AreEqual("John", personBatchGet.Results[0].FirstName);
            Assert.AreEqual("Doe", personBatchGet.Results[0].LastName);
        }

        public IBatchGet<T> CreateBatchGetMock<T>(List<T> results)
        {
            var batchGet = new Mock<IBatchGet<T>>();
            var dummyResults = new List<T>();
            var keys = new List<string>();

            batchGet
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    dummyResults.Clear();
                    dummyResults.AddRange(results);
                });

            batchGet
                .Setup(x => x.Results)
                .Returns(dummyResults);

            batchGet
                .Setup(x => x.AddKey(It.IsAny<object>()))
                .Callback((object hashKey) =>
                {
                    keys.Add(hashKey.ToString());
                });

            batchGet
                .Setup(x => x.AddKey(It.IsAny<object>(), It.IsAny<object>()))
                .Callback((object hashKey, object rangeKey) =>
                {
                    keys.Add(hashKey.ToString() + rangeKey.ToString());
                });

            batchGet
                .SetupGet(x => x.TotalKeys)
                .Returns(() => keys.Count);

            return batchGet.Object;
        }

        public IMultiTableBatchGet CreateMultiTableBatchGetMock()
        {
            var multiBatchGet = new Mock<IMultiTableBatchGet>();
            var batches = new List<IBatchGet>();

            multiBatchGet
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var batch in batches)
                    {
                        batch.Execute();
                    }
                });

            multiBatchGet
                .Setup(x => x.AddBatch(It.IsAny<IBatchGet>()))
                .Callback((IBatchGet batch) =>
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

    public class Address
    {
        public string State { get; set; }
        public string Zip { get; set; }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
