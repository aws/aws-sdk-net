using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using DynamoDBContextConfig = Amazon.DynamoDBv2.DataModel.DynamoDBContextConfig;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests that exercise a real Save, inspecting the <see cref="UpdateItemRequest"/> the SDK sends. Document
    /// round-trips through ToDocument and FromDocument do not reach the update-expression and condition-expression
    /// code, so server-managed behaviour (optimistic locking, atomic counters, UpdateBehavior.IfNotExists) has to
    /// be verified here. These tests are not gated: the code under test is shared by every target framework.
    /// </summary>
    [TestClass]
    public class DataModelSaveExpressionTests
    {
        private Mock<IAmazonDynamoDB> _client;
        private List<UpdateItemRequest> _requests;

        [TestInitialize]
        public void Initialize()
        {
            _requests = new List<UpdateItemRequest>();
            _client = new Mock<IAmazonDynamoDB>();
            _client.Setup(c => c.UpdateItemAsync(It.IsAny<UpdateItemRequest>(), It.IsAny<CancellationToken>()))
                .Returns((UpdateItemRequest request, CancellationToken token) =>
                {
                    _requests.Add(request);

                    // A model with a counter or an UpdateBehavior.IfNotExists member asks for ALL_NEW and then
                    // populates the instance from the response, so echo the key back to stand in for the item the
                    // service would return.
                    var attributes = new Dictionary<string, AttributeValue>();
                    if (request.Key != null)
                    {
                        foreach (var entry in request.Key)
                            attributes[entry.Key] = entry.Value;
                    }

                    return Task.FromResult(new UpdateItemResponse { Attributes = attributes });
                });
        }

        private DynamoDBContext CreateContext()
        {
            return new DynamoDBContext(_client.Object,
                new DynamoDBContextConfig { DisableFetchingTableMetadata = true });
        }

        private UpdateItemRequest SingleRequest()
        {
            Assert.AreEqual(1, _requests.Count, "Expected exactly one UpdateItem call.");
            return _requests[0];
        }

        // V4 leaves request collections null when unset, so these read them defensively.
        private static string AttributeNames(UpdateItemRequest request)
        {
            return request.ExpressionAttributeNames == null
                ? string.Empty
                : string.Join(",", request.ExpressionAttributeNames.Values);
        }

        private static IEnumerable<AttributeValue> AttributeValues(UpdateItemRequest request)
        {
            return request.ExpressionAttributeValues?.Values ?? Enumerable.Empty<AttributeValue>();
        }

        #region Nested flattened version

        public class InnerAudit
        {
            public string ModifiedBy { get; set; }

            [DynamoDBVersion]
            public int? Version { get; set; }
        }

        public class OuterAudit
        {
            public string Source { get; set; }

            [DynamoDBFlatten]
            public InnerAudit Inner { get; set; }
        }

        public class NestedVersionEntity
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public OuterAudit Outer { get; set; }
        }

        // A version one level down, for comparison with the nested case.
        public class DirectVersionEntity
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public InnerAudit Audit { get; set; }
        }

        [TestMethod]
        public async Task Save_WithVersionInNestedFlattenChain_ChecksTheLoadedVersion()
        {
            // The version sits two levels down. It must still be captured during serialization, otherwise the
            // optimistic-locking condition degrades to attribute_not_exists and every update of an existing item
            // fails its condition check.
            var context = CreateContext();

            await context.SaveAsync(new NestedVersionEntity
            {
                Id = "n1",
                Outer = new OuterAudit
                {
                    Source = "api",
                    Inner = new InnerAudit { ModifiedBy = "bob", Version = 4 }
                }
            });

            var request = SingleRequest();

            StringAssert.Contains(request.ConditionExpression, "=",
                "Expected an equality check against the loaded version. Actual: " + request.ConditionExpression);
            Assert.IsFalse(request.ConditionExpression.Contains("attribute_not_exists"),
                "A loaded version must not produce attribute_not_exists. Actual: " + request.ConditionExpression);
            Assert.IsTrue(AttributeValues(request).Any(v => v.N == "4"),
                "The condition must compare against the loaded version value 4.");
        }

        [TestMethod]
        public async Task Save_WithVersionInDirectFlatten_ChecksTheLoadedVersion()
        {
            var context = CreateContext();

            await context.SaveAsync(new DirectVersionEntity
            {
                Id = "d1",
                Audit = new InnerAudit { ModifiedBy = "bob", Version = 4 }
            });

            var request = SingleRequest();

            Assert.IsFalse(request.ConditionExpression.Contains("attribute_not_exists"),
                "Actual: " + request.ConditionExpression);
            Assert.IsTrue(AttributeValues(request).Any(v => v.N == "4"));
        }

        [TestMethod]
        public async Task Save_WithUnsetVersionInNestedFlattenChain_RequiresTheItemToBeAbsent()
        {
            // The complement: a new item whose version has never been set must still use attribute_not_exists.
            var context = CreateContext();

            await context.SaveAsync(new NestedVersionEntity
            {
                Id = "n2",
                Outer = new OuterAudit { Source = "api", Inner = new InnerAudit { ModifiedBy = "bob" } }
            });

            StringAssert.Contains(SingleRequest().ConditionExpression, "attribute_not_exists");
        }

        #endregion

        #region Ignored server-managed descendants

        public class ChildWithIgnoredCounter
        {
            public string Note { get; set; }

            [DynamoDBIgnore]
            [DynamoDBAtomicCounter]
            public long? IgnoredHits { get; set; }

            [DynamoDBAtomicCounter]
            public long? Hits { get; set; }
        }

        public class IgnoredCounterEntity
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public ChildWithIgnoredCounter Child { get; set; }
        }

        public class TopLevelIgnoredCounterEntity
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBIgnore]
            [DynamoDBAtomicCounter]
            public long? IgnoredHits { get; set; }
        }

        [TestMethod]
        public async Task Save_DoesNotIncrementAnIgnoredFlattenedCounter()
        {
            // An ignored counter must not reach the update expression, where DynamoDB would change server-side
            // state for an attribute the model says is not persisted.
            var context = CreateContext();

            await context.SaveAsync(new IgnoredCounterEntity
            {
                Id = "c1",
                Child = new ChildWithIgnoredCounter { Note = "n" }
            });

            var request = SingleRequest();
            var expression = request.UpdateExpression ?? string.Empty;
            var names = AttributeNames(request);

            Assert.IsFalse(expression.Contains("IgnoredHits") || names.Contains("IgnoredHits"),
                $"The ignored counter must not appear in the update. Expression: {expression} Names: {names}");
            Assert.IsTrue(names.Contains("Hits"),
                $"The non-ignored counter must still be incremented. Names: {names}");
        }

        [TestMethod]
        public async Task Save_DoesNotIncrementAnIgnoredTopLevelCounter()
        {
            var context = CreateContext();

            await context.SaveAsync(new TopLevelIgnoredCounterEntity { Id = "c2" });

            var request = SingleRequest();
            var expression = request.UpdateExpression ?? string.Empty;
            var names = AttributeNames(request);

            Assert.IsFalse(expression.Contains("IgnoredHits") || names.Contains("IgnoredHits"),
                $"Expression: {expression} Names: {names}");
        }

        public class ChildWithIgnoredIfNotExists
        {
            public string Note { get; set; }

            [DynamoDBIgnore]
            [DynamoDbUpdateBehavior(UpdateBehavior.IfNotExists)]
            public string IgnoredOwner { get; set; }
        }

        public class IgnoredIfNotExistsEntity
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public ChildWithIgnoredIfNotExists Child { get; set; }
        }

        [TestMethod]
        public async Task Save_DoesNotApplyIfNotExistsToAnIgnoredFlattenedMember()
        {
            var context = CreateContext();

            await context.SaveAsync(new IgnoredIfNotExistsEntity
            {
                Id = "u1",
                Child = new ChildWithIgnoredIfNotExists { Note = "n", IgnoredOwner = "alice" }
            });

            var request = SingleRequest();
            var expression = request.UpdateExpression ?? string.Empty;
            var names = AttributeNames(request);

            Assert.IsFalse(expression.Contains("IgnoredOwner") || names.Contains("IgnoredOwner"),
                $"Expression: {expression} Names: {names}");

            // An ignored member must not make the SDK request the whole updated item back and then reconcile it
            // onto the instance. That is the observable cost of leaving it in the collector.
            Assert.AreNotEqual(ReturnValue.ALL_NEW, request.ReturnValues,
                "No persisted member uses UpdateBehavior.IfNotExists, so ALL_NEW must not be requested.");
        }

        public class ChildWithRealIfNotExists
        {
            public string Note { get; set; }

            [DynamoDbUpdateBehavior(UpdateBehavior.IfNotExists)]
            public string Owner { get; set; }
        }

        public class RealIfNotExistsEntity
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public ChildWithRealIfNotExists Child { get; set; }
        }

        [TestMethod]
        public async Task Save_StillAppliesIfNotExistsToAPersistedFlattenedMember()
        {
            // The complement, so the filtering cannot be over-applied.
            var context = CreateContext();

            await context.SaveAsync(new RealIfNotExistsEntity
            {
                Id = "u2",
                Child = new ChildWithRealIfNotExists { Note = "n", Owner = "alice" }
            });

            var request = SingleRequest();

            Assert.AreEqual(ReturnValue.ALL_NEW, request.ReturnValues);
            StringAssert.Contains(AttributeNames(request), "Owner");
        }

        #endregion
    }
}
