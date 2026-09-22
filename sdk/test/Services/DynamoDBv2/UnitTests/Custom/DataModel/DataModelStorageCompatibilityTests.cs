using System;
using System.Collections.Generic;
using System.Linq;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

using DynamoDBContextConfig = Amazon.DynamoDBv2.DataModel.DynamoDBContextConfig;

namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Verifies that the DataModel stores and reads the same DynamoDB attributes regardless of which build of
    /// the SDK is used, so that an application which wrote items while targeting .NET Standard 2.0 / .NET
    /// Framework / .NET Core 3.1 can still read and update those items after it is retargeted to .NET 8 or later.
    /// <para>
    /// The assertions outside <c>#if NET8_0_OR_GREATER</c> run on every target framework, so a change that made
    /// the stored shape depend on the target framework would fail this class on at least one target. The
    /// assertions inside <c>#if NET8_0_OR_GREATER</c> additionally check that the .NET 8 constructor-binding path
    /// (used for records, other immutable types, and value types) is wire-compatible with the mutable model that
    /// older targets support.
    /// </para>
    /// </summary>
    [TestClass]
    public class DataModelStorageCompatibilityTests
    {
        // Leaf of a nested [DynamoDBFlatten] chain: its members are stored at the top level of the item.
        public class Trace
        {
            public string TraceId { get; set; }
        }

        // Flattened member that itself contains a flattened member.
        public class Audit
        {
            public string ModifiedBy { get; set; }

            [DynamoDBFlatten]
            public Trace Trace { get; set; }
        }

        // Nested complex member, stored as a map under its own attribute.
        public class Address
        {
            public string City { get; set; }
            public string Zip { get; set; }
        }

        /// <summary>
        /// Mutable model with a public parameterless constructor. This shape is supported by every build of the
        /// SDK, so it represents data written by an application before it was retargeted to .NET 8.
        /// </summary>
        public class MutableOrder
        {
            [DynamoDBHashKey]
            public string OrderId { get; set; }

            [DynamoDBRangeKey]
            public int LineNumber { get; set; }

            [DynamoDBProperty("cust")]
            public string Customer { get; set; }

            public List<string> Tags { get; set; }

            public Address ShipTo { get; set; }

            [DynamoDBFlatten]
            public Audit Audit { get; set; }
        }

        /// <summary>
        /// The exact set of attribute names the model above must produce, on every target framework. Flattened
        /// members contribute their leaf names at the top level ("ModifiedBy", "TraceId"); the nested complex
        /// member contributes a single map attribute ("ShipTo").
        /// </summary>
        private static readonly string[] ExpectedAttributeNames =
        {
            "Audit",        // sanity: must NOT be present - see assertion below
        };

        private static readonly string[] ExpectedStoredAttributeNames =
        {
            "OrderId", "LineNumber", "cust", "Tags", "ShipTo", "ModifiedBy", "TraceId"
        };

        private DynamoDBContext CreateContext()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            return new DynamoDBContext(mockClient.Object,
                new DynamoDBContextConfig { DisableFetchingTableMetadata = true });
        }

        private static MutableOrder CreateMutableOrder()
        {
            return new MutableOrder
            {
                OrderId = "order-1",
                LineNumber = 7,
                Customer = "Alice",
                Tags = new List<string> { "red", "blue" },
                ShipTo = new Address { City = "Seattle", Zip = "98101" },
                Audit = new Audit { ModifiedBy = "bob", Trace = new Trace { TraceId = "t-42" } }
            };
        }

        /// <summary>
        /// The reference item as an older build of the SDK would have written it.
        /// </summary>
        private static Document CreateStoredDocument()
        {
            return new Document
            {
                ["OrderId"] = new Primitive("order-1"),
                ["LineNumber"] = new Primitive("7", true),
                ["cust"] = new Primitive("Alice"),
                ["Tags"] = new PrimitiveList(DynamoDBEntryType.String)
                {
                    Entries = { new Primitive("red"), new Primitive("blue") }
                },
                ["ShipTo"] = new Document
                {
                    ["City"] = new Primitive("Seattle"),
                    ["Zip"] = new Primitive("98101")
                },
                ["ModifiedBy"] = new Primitive("bob"),
                ["TraceId"] = new Primitive("t-42")
            };
        }

        private static void AssertAttributeNames(Document document)
        {
            CollectionAssert.AreEquivalent(
                ExpectedStoredAttributeNames,
                document.Keys.ToArray(),
                "The set of stored attribute names must not depend on the target framework. Actual: " +
                string.Join(", ", document.Keys.OrderBy(k => k, StringComparer.Ordinal)));

            // A flattened member is never stored under its own name; only its leaves are.
            Assert.IsFalse(document.ContainsKey(ExpectedAttributeNames[0]),
                "A [DynamoDBFlatten] member must not be stored under its own attribute name.");
        }

        private static void AssertStoredValues(Document document)
        {
            Assert.AreEqual("order-1", document["OrderId"].AsString());
            Assert.AreEqual(7, document["LineNumber"].AsInt());
            Assert.AreEqual("Alice", document["cust"].AsString());
            CollectionAssert.AreEqual(new[] { "red", "blue" }, document["Tags"].AsListOfString().ToArray());
            Assert.AreEqual("Seattle", document["ShipTo"].AsDocument()["City"].AsString());
            Assert.AreEqual("98101", document["ShipTo"].AsDocument()["Zip"].AsString());
            Assert.AreEqual("bob", document["ModifiedBy"].AsString());
            Assert.AreEqual("t-42", document["TraceId"].AsString());
        }

        private static void AssertMutableOrder(MutableOrder order)
        {
            Assert.IsNotNull(order);
            Assert.AreEqual("order-1", order.OrderId);
            Assert.AreEqual(7, order.LineNumber);
            Assert.AreEqual("Alice", order.Customer);
            CollectionAssert.AreEqual(new[] { "red", "blue" }, order.Tags.ToArray());
            Assert.IsNotNull(order.ShipTo);
            Assert.AreEqual("Seattle", order.ShipTo.City);
            Assert.AreEqual("98101", order.ShipTo.Zip);
            Assert.IsNotNull(order.Audit);
            Assert.AreEqual("bob", order.Audit.ModifiedBy);
            Assert.IsNotNull(order.Audit.Trace, "A nested [DynamoDBFlatten] member must be reconstructed on load.");
            Assert.AreEqual("t-42", order.Audit.Trace.TraceId);
        }

        [TestMethod]
        public void MutableModel_StoredShapeIsIdenticalOnEveryTargetFramework()
        {
            var context = CreateContext();

            var document = context.ToDocument(CreateMutableOrder());

            AssertAttributeNames(document);
            AssertStoredValues(document);
        }

        [TestMethod]
        public void MutableModel_ReadsDocumentWrittenByAnOlderSdkBuild()
        {
            var context = CreateContext();

            var order = context.FromDocument<MutableOrder>(CreateStoredDocument());

            AssertMutableOrder(order);
        }

        [TestMethod]
        public void MutableModel_RoundTripsOnEveryTargetFramework()
        {
            var context = CreateContext();

            var order = context.FromDocument<MutableOrder>(context.ToDocument(CreateMutableOrder()));

            AssertMutableOrder(order);
        }

        #region Nested [DynamoDBFlatten] upgrade behaviour

        // Three levels of flattening, with a renamed leaf attribute, to pin the stored shape of the nested-flatten
        // load fix. Older builds already wrote these leaves at the top level; only reading them back was broken.
        public class DeepTrace
        {
            [DynamoDBProperty("span")]
            public string SpanId { get; set; }
        }

        public class DeepAudit
        {
            public string ModifiedBy { get; set; }

            [DynamoDBFlatten]
            public DeepTrace Trace { get; set; }
        }

        public class DeepWrapper
        {
            public string Source { get; set; }

            [DynamoDBFlatten]
            public DeepAudit Audit { get; set; }
        }

        public class DeepRoot
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public DeepWrapper Wrapper { get; set; }
        }

        [TestMethod]
        public void NestedFlatten_StoredShapeIsUnchangedByTheLoadFix()
        {
            // Every level's leaf is stored as a top-level attribute, and no level is stored under its own name.
            // This is the format older builds already wrote, which is why the load fix needs no data migration.
            var context = CreateContext();

            var document = context.ToDocument(new DeepRoot
            {
                Id = "d1",
                Wrapper = new DeepWrapper
                {
                    Source = "api",
                    Audit = new DeepAudit { ModifiedBy = "bob", Trace = new DeepTrace { SpanId = "s-1" } }
                }
            });

            CollectionAssert.AreEquivalent(
                new[] { "Id", "Source", "ModifiedBy", "span" },
                document.Keys.ToArray(),
                "Actual: " + string.Join(", ", document.Keys.OrderBy(k => k, StringComparer.Ordinal)));
        }

        [TestMethod]
        public void NestedFlatten_ReadsEveryLevelFromDocumentWrittenByAnOlderSdkBuild()
        {
            var context = CreateContext();
            var stored = new Document
            {
                ["Id"] = new Primitive("d1"),
                ["Source"] = new Primitive("api"),
                ["ModifiedBy"] = new Primitive("bob"),
                ["span"] = new Primitive("s-1")
            };

            var root = context.FromDocument<DeepRoot>(stored);

            Assert.AreEqual("api", root.Wrapper.Source);
            Assert.AreEqual("bob", root.Wrapper.Audit.ModifiedBy);
            Assert.IsNotNull(root.Wrapper.Audit.Trace, "The second level of flattening must be reconstructed.");
            Assert.AreEqual("s-1", root.Wrapper.Audit.Trace.SpanId);
        }

        [TestMethod]
        public void NestedFlatten_AbsentChildAttributes_YieldEmptyInstancesAtEveryLevel()
        {
            // Documents the one observable behaviour change of the nested-flatten load fix: when none of a nested
            // flattened member's attributes are stored (it was null when the item was saved), loading now produces
            // an empty instance instead of null. This matches how the outermost flattened member has always
            // behaved, so every level of a flatten chain is now consistently non-null.
            var context = CreateContext();

            var root = context.FromDocument<DeepRoot>(new Document { ["Id"] = new Primitive("d1") });

            Assert.IsNotNull(root.Wrapper);
            Assert.IsNotNull(root.Wrapper.Audit);
            Assert.IsNotNull(root.Wrapper.Audit.Trace);
            Assert.IsNull(root.Wrapper.Audit.Trace.SpanId);
        }

        // A flattened member whose type cannot be reconstructed when the item is loaded.
        public class UninstantiableChild
        {
            public UninstantiableChild(string value) { Value = value; }
            public string Value { get; set; }
        }

        public class FlattensUninstantiableChild
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public UninstantiableChild Child { get; set; }
        }

        [TestMethod]
        public void NestedFlatten_UninstantiableChildType_IsRejectedOnSaveAndOnLoad()
        {
            // Saving already failed before the load fix; loading silently produced a null member. Both now fail
            // at configuration time with the same message, which names the offending property.
            var context = CreateContext();

            var onSave = Assert.ThrowsExactly<InvalidOperationException>(() =>
                context.ToDocument(new FlattensUninstantiableChild { Id = "u1", Child = new UninstantiableChild("v") }));

            var onLoad = Assert.ThrowsExactly<InvalidOperationException>(() =>
                context.FromDocument<FlattensUninstantiableChild>(
                    new Document { ["Id"] = new Primitive("u1"), ["Value"] = new Primitive("v") }));

            StringAssert.Contains(onSave.Message, "'Child'");
            StringAssert.Contains(onSave.Message, "[DynamoDBFlatten]");
            Assert.AreEqual(onSave.Message, onLoad.Message,
                "Saving and loading must fail the same way so the problem cannot be discovered only at read time.");
        }

        #endregion

        #region Ignored flattened descendants

        // A flattened descendant that is both a version property and ignored. Denormalize excludes it, so it is
        // never written to the inner document, and the save path must not try to read it back out.
        public class AuditWithIgnoredVersion
        {
            public string ModifiedBy { get; set; }

            [DynamoDBIgnore]
            [DynamoDBVersion]
            public int? Version { get; set; }
        }

        // A plain mutable parent, so this exercises the shared save path on every target framework rather than
        // the .NET 8 constructor-binding path.
        public class MutableParentWithIgnoredVersionDescendant
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public AuditWithIgnoredVersion Audit { get; set; }
        }

        [TestMethod]
        public void FlattenedIgnoredVersionDescendant_RoundTripsOnEveryTargetFramework()
        {
            var context = CreateContext();

            var document = context.ToDocument(new MutableParentWithIgnoredVersionDescendant
            {
                Id = "v1",
                Audit = new AuditWithIgnoredVersion { ModifiedBy = "bob", Version = 7 }
            });

            CollectionAssert.AreEquivalent(
                new[] { "Id", "ModifiedBy" },
                document.Keys.ToArray(),
                "The ignored descendant must not be stored. Actual: " + string.Join(", ", document.Keys));

            var result = context.FromDocument<MutableParentWithIgnoredVersionDescendant>(document);

            Assert.AreEqual("bob", result.Audit.ModifiedBy);
            Assert.IsFalse(result.Audit.Version.HasValue, "An ignored descendant is not populated on load.");
        }

        #endregion

#if NET8_0_OR_GREATER
        /// <summary>
        /// Immutable counterpart of <see cref="MutableOrder"/>, populated through its primary constructor. It
        /// declares the same members with the same names and attribute overrides, so it must map to exactly the
        /// same DynamoDB attributes.
        /// </summary>
        public record ImmutableOrder(
            [property: DynamoDBHashKey] string OrderId,
            [property: DynamoDBRangeKey] int LineNumber,
            [property: DynamoDBProperty("cust")] string Customer,
            List<string> Tags,
            Address ShipTo,
            [property: DynamoDBFlatten] Audit Audit);

        /// <summary>
        /// Value-type counterpart, populated by zero-initialization plus member assignment.
        /// </summary>
        public record struct StructOrder
        {
            [DynamoDBHashKey]
            public string OrderId { get; set; }

            [DynamoDBRangeKey]
            public int LineNumber { get; set; }

            [DynamoDBProperty("cust")]
            public string Customer { get; set; }

            public List<string> Tags { get; set; }

            public Address ShipTo { get; set; }

            [DynamoDBFlatten]
            public Audit Audit { get; set; }
        }

        private static ImmutableOrder CreateImmutableOrder()
        {
            return new ImmutableOrder(
                "order-1",
                7,
                "Alice",
                new List<string> { "red", "blue" },
                new Address { City = "Seattle", Zip = "98101" },
                new Audit { ModifiedBy = "bob", Trace = new Trace { TraceId = "t-42" } });
        }

        private static void AssertImmutableOrder(ImmutableOrder order)
        {
            Assert.IsNotNull(order);
            Assert.AreEqual("order-1", order.OrderId);
            Assert.AreEqual(7, order.LineNumber);
            Assert.AreEqual("Alice", order.Customer);
            CollectionAssert.AreEqual(new[] { "red", "blue" }, order.Tags.ToArray());
            Assert.IsNotNull(order.ShipTo);
            Assert.AreEqual("Seattle", order.ShipTo.City);
            Assert.AreEqual("98101", order.ShipTo.Zip);
            Assert.IsNotNull(order.Audit);
            Assert.AreEqual("bob", order.Audit.ModifiedBy);
            Assert.IsNotNull(order.Audit.Trace, "A nested [DynamoDBFlatten] member must be reconstructed on load.");
            Assert.AreEqual("t-42", order.Audit.Trace.TraceId);
        }

        [TestMethod]
        public void ImmutableModel_StoresTheSameAttributesAsTheMutableModel()
        {
            var context = CreateContext();

            var fromImmutable = context.ToDocument(CreateImmutableOrder());

            AssertAttributeNames(fromImmutable);
            AssertStoredValues(fromImmutable);
        }

        [TestMethod]
        public void ValueTypeModel_StoresTheSameAttributesAsTheMutableModel()
        {
            var context = CreateContext();

            var fromStruct = context.ToDocument(new StructOrder
            {
                OrderId = "order-1",
                LineNumber = 7,
                Customer = "Alice",
                Tags = new List<string> { "red", "blue" },
                ShipTo = new Address { City = "Seattle", Zip = "98101" },
                Audit = new Audit { ModifiedBy = "bob", Trace = new Trace { TraceId = "t-42" } }
            });

            AssertAttributeNames(fromStruct);
            AssertStoredValues(fromStruct);
        }

        [TestMethod]
        public void ImmutableModel_ReadsDocumentWrittenByAnOlderSdkBuild()
        {
            // This is the upgrade path that matters: the item was written by a build without constructor
            // binding, and is now read into an immutable type on .NET 8.
            var context = CreateContext();

            var order = context.FromDocument<ImmutableOrder>(CreateStoredDocument());

            AssertImmutableOrder(order);
        }

        [TestMethod]
        public void ValueTypeModel_ReadsDocumentWrittenByAnOlderSdkBuild()
        {
            var context = CreateContext();

            var order = context.FromDocument<StructOrder>(CreateStoredDocument());

            Assert.AreEqual("order-1", order.OrderId);
            Assert.AreEqual(7, order.LineNumber);
            Assert.AreEqual("Alice", order.Customer);
            Assert.AreEqual("Seattle", order.ShipTo.City);
            Assert.AreEqual("bob", order.Audit.ModifiedBy);
            Assert.AreEqual("t-42", order.Audit.Trace.TraceId);
        }

        [TestMethod]
        public void MutableModel_ReadsDocumentWrittenByTheImmutableModel()
        {
            // The reverse direction: an item written by a .NET 8 application using an immutable type must stay
            // readable by code (or another service) still using the mutable model.
            var context = CreateContext();

            var order = context.FromDocument<MutableOrder>(context.ToDocument(CreateImmutableOrder()));

            AssertMutableOrder(order);
        }

        [TestMethod]
        public void ImmutableModel_ReadsDocumentWrittenByTheMutableModel()
        {
            var context = CreateContext();

            var order = context.FromDocument<ImmutableOrder>(context.ToDocument(CreateMutableOrder()));

            AssertImmutableOrder(order);
        }

        [TestMethod]
        public void ImmutableModel_KeyAndProjectionConfigurationMatchesTheMutableModel()
        {
            // Keys, the attributes requested on read, and the projection expression are all derived from the
            // member model, so they must not differ between the two shapes either.
            var context = CreateContext();
            var flatConfig = new DynamoDBFlatConfig(new DynamoDBOperationConfig(), context.Config);

            var mutable = context.StorageConfigCache.GetConfig<MutableOrder>(flatConfig);
            var immutable = context.StorageConfigCache.GetConfig<ImmutableOrder>(flatConfig);

            CollectionAssert.AreEquivalent(mutable.HashKeyPropertyNames.ToArray(), immutable.HashKeyPropertyNames.ToArray());
            CollectionAssert.AreEquivalent(mutable.RangeKeyPropertyNames.ToArray(), immutable.RangeKeyPropertyNames.ToArray());
            CollectionAssert.AreEquivalent(mutable.AttributesToGet.ToArray(), immutable.AttributesToGet.ToArray());
            CollectionAssert.AreEquivalent(
                mutable.ProjectionExpression.ExpressionAttributeNames.Values.ToArray(),
                immutable.ProjectionExpression.ExpressionAttributeNames.Values.ToArray());
        }
#endif
    }
}
