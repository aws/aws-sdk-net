using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom.MockabilityTests
{
    [TestClass]
    public class AsyncSearchTests
    {
        [TestMethod]
        public async Task TestMockability_ScanAsync()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.ScanAsync<string>(It.IsAny<IEnumerable<ScanCondition>>()))
                .Returns(CreateMockAsyncSearch(new List<string> { "item1", "item2" }));

            var ddbContext = mockContext.Object;
            var asyncSearch = ddbContext.ScanAsync<string>((IEnumerable<ScanCondition>)null);

            var results = await asyncSearch.GetNextSetAsync();
            Assert.AreEqual(2, results.Count);
            Assert.AreEqual("item1", results[0]);
            Assert.AreEqual("item2", results[1]);
        }

        [TestMethod]
        public async Task TestMockability_FromScanAsync()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.FromScanAsync<string>(It.IsAny<ScanOperationConfig>()))
                .Returns(CreateMockAsyncSearch(new List<string> { "item1", "item2" }));

            var ddbContext = mockContext.Object;
            var asyncSearch = ddbContext.FromScanAsync<string>(null);

            var results = await asyncSearch.GetNextSetAsync();
            Assert.AreEqual(2, results.Count);
            Assert.AreEqual("item1", results[0]);
            Assert.AreEqual("item2", results[1]);
        }

        [TestMethod]
        public async Task TestMockability_QueryAsync()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.QueryAsync<string>(It.IsAny<object>()))
                .Returns(CreateMockAsyncSearch(new List<string> { "item1", "item2" }));

            var ddbContext = mockContext.Object;
            var asyncSearch = ddbContext.QueryAsync<string>(null);

            var results = await asyncSearch.GetNextSetAsync();
            Assert.AreEqual(2, results.Count);
            Assert.AreEqual("item1", results[0]);
            Assert.AreEqual("item2", results[1]);
        }

        [TestMethod]
        public async Task TestMockability_FromQueryAsync()
        {
            var mockContext = new Mock<IDynamoDBContext>();
            mockContext
                .Setup(x => x.FromQueryAsync<string>(It.IsAny<QueryOperationConfig>()))
                .Returns(CreateMockAsyncSearch(new List<string> { "item1", "item2" }));

            var ddbContext = mockContext.Object;
            var asyncSearch = ddbContext.FromQueryAsync<string>(null);

            var results = await asyncSearch.GetNextSetAsync();
            Assert.AreEqual(2, results.Count);
            Assert.AreEqual("item1", results[0]);
            Assert.AreEqual("item2", results[1]);
        }

        public IAsyncSearch<T> CreateMockAsyncSearch<T>(List<T> items)
        {
            var mockAsyncSearch = new Mock<IAsyncSearch<T>>();

            mockAsyncSearch
                .Setup(x => x.GetNextSetAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult(items));

            return mockAsyncSearch.Object;
        }
    }
}
