using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class TransactGetTests
    {
        [TestMethod]
        public void TestMockability_TransactGet()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateTransactGet<Address>())
                .Returns(CreateTransactGetMock(new List<Address>()
                {
                    { new Address() { State = "CA", Zip = "12345" }}
                }));

            var ddbContext = mockContext.Object;
            var addressTransactGet = ddbContext.CreateTransactGet<Address>();


            Assert.AreEqual(0, addressTransactGet.Results.Count);

            addressTransactGet.Execute();
            Assert.AreEqual(1, addressTransactGet.Results.Count);
            Assert.AreEqual("CA", addressTransactGet.Results[0].State);
            Assert.AreEqual("12345", addressTransactGet.Results[0].Zip);
        }

        [TestMethod]
        public void TestMockability_MultiTableTransactGet()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.CreateMultiTableTransactGet())
                .Returns(CreateMultiTableTransactGetMock());

            var ddbContext = mockContext.Object;
            var multiTransactGet = ddbContext.CreateMultiTableTransactGet();

            var addressTransactGet = CreateTransactGetMock(new List<Address>
            {
                { new Address() { State = "CA", Zip = "12345" }}
            });

            var personTransactGet = CreateTransactGetMock(new List<Person>
            {
                { new Person() { FirstName = "John", LastName = "Doe" }}
            });

            multiTransactGet.AddTransactionPart(addressTransactGet);
            multiTransactGet.AddTransactionPart(personTransactGet);

            Assert.AreEqual(0, addressTransactGet.Results.Count);
            Assert.AreEqual(0, personTransactGet.Results.Count);


            multiTransactGet.Execute();
            Assert.AreEqual(1, addressTransactGet.Results.Count);
            Assert.AreEqual("CA", addressTransactGet.Results[0].State);
            Assert.AreEqual("12345", addressTransactGet.Results[0].Zip);
            Assert.AreEqual(1, personTransactGet.Results.Count);
            Assert.AreEqual("John", personTransactGet.Results[0].FirstName);
            Assert.AreEqual("Doe", personTransactGet.Results[0].LastName);
        }

        public ITransactGet<T> CreateTransactGetMock<T>(List<T> results)
        {
            var transactGet = new Mock<ITransactGet<T>>();
            var dummyResults = new List<T>();
            var keys = new List<string>();

            transactGet
                .Setup(x => x.Execute())
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

        public IMultiTableTransactGet CreateMultiTableTransactGetMock()
        {
            var multiTransactGet = new Mock<IMultiTableTransactGet>();
            var batches = new List<ITransactGet>();

            multiTransactGet
                .Setup(x => x.Execute())
                .Callback(() =>
                {
                    foreach (var batch in batches)
                    {
                        batch.Execute();
                    }
                });

            multiTransactGet
                .Setup(x => x.AddTransactionPart(It.IsAny<ITransactGet>()))
                .Callback((ITransactGet batch) =>
                {
                    batches.Add(batch);
                });

            return multiTransactGet.Object;
        }
    }
}
