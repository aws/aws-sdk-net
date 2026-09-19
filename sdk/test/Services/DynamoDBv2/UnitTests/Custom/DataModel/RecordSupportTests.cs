#if NET8_0_OR_GREATER
using System;
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
    /// Unit tests for constructor-based population of immutable types (records, record structs, and
    /// immutable POCOs) in the DynamoDB DataModel. This feature is only available on the .NET 8+ target.
    /// </summary>
    [TestClass]
    public class RecordSupportTests
    {
        // Positional record: generated properties are get/init, populated through the primary constructor.
        public record PositionalRecord(
            [property: DynamoDBHashKey] string Id,
            string Name,
            int Age,
            int? Score = 42);

        // Record with an explicit init-only property.
        public record InitRecord
        {
            [DynamoDBHashKey]
            public string Id { get; init; }
            public string Name { get; init; }
        }

        // Value-type positional record.
        public readonly record struct RecordStruct(
            [property: DynamoDBHashKey] string Id,
            int Count);

        // Immutable POCO with get-only properties supplied through a single parameterized constructor.
        public class ImmutablePoco
        {
            public ImmutablePoco(string id, string name)
            {
                Id = id;
                Name = name;
            }

            [DynamoDBHashKey]
            public string Id { get; }
            public string Name { get; }
        }

        // Ambiguous: two eligible parameterized constructors and no [DynamoDBConstructor] marker.
        public class AmbiguousCtors
        {
            public AmbiguousCtors(string id) { Id = id; }
            public AmbiguousCtors(string id, string name) { Id = id; Name = name; }

            [DynamoDBHashKey]
            public string Id { get; }
            public string Name { get; }
        }

        // Disambiguated with [DynamoDBConstructor].
        public class MarkedCtor
        {
            public MarkedCtor(string id) { Id = id; }

            [DynamoDBConstructor]
            public MarkedCtor(string id, string name) { Id = id; Name = name; }

            [DynamoDBHashKey]
            public string Id { get; }
            public string Name { get; }
        }

        // Mutable type with a parameterless constructor is unaffected by the binding-constructor path.
        public class MutablePoco
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public string Name { get; set; }
        }

        // Positional record with a flattened member supplied through the constructor.
        public record FlattenedRecord(
            [property: DynamoDBHashKey] string Id,
            [property: DynamoDBFlatten] FlattenedChild Child);

        // The flattened member type is a mutable class (its children are stored at the top level).
        public class FlattenedChild
        {
            public string ChildName { get; set; }
            public int ChildValue { get; set; }
        }

        // record struct that also declares an explicit public parameterless constructor. The primary
        // constructor must still be selected for binding because value types cannot use the
        // parameterless instantiation path.
        public readonly record struct StructWithParameterless(
            [property: DynamoDBHashKey] string Id,
            int Count)
        {
            public StructWithParameterless() : this(string.Empty, 0) { }
        }

        // Type with a parameterless constructor where [DynamoDBConstructor] forces constructor binding.
        public class ForcedBindingType
        {
            public ForcedBindingType() { }

            [DynamoDBConstructor]
            public ForcedBindingType(string id, string name)
            {
                Id = id;
                Name = name;
            }

            [DynamoDBHashKey]
            public string Id { get; set; }
            public string Name { get; set; }
        }

        private DynamoDBContext CreateContext()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            return new DynamoDBContext(mockClient.Object,
                new DynamoDBContextConfig { DisableFetchingTableMetadata = true });
        }

        [TestMethod]
        public void PositionalRecord_RoundTrips()
        {
            var context = CreateContext();
            var original = new PositionalRecord("id-1", "Alice", 30, 99);

            var document = context.ToDocument(original);
            var result = context.FromDocument<PositionalRecord>(document);

            Assert.AreEqual(original, result);
            Assert.AreEqual("id-1", result.Id);
            Assert.AreEqual("Alice", result.Name);
            Assert.AreEqual(30, result.Age);
            Assert.AreEqual(99, result.Score);
        }

        [TestMethod]
        public void PositionalRecord_MissingAttribute_UsesConstructorDefault()
        {
            var context = CreateContext();

            // Serialize a full record, then drop the optional 'Score' attribute to simulate an item
            // stored before that property existed.
            var document = context.ToDocument(new PositionalRecord("id-2", "Bob", 25, 999));
            document.Remove("Score");

            var result = context.FromDocument<PositionalRecord>(document);

            Assert.AreEqual("id-2", result.Id);
            Assert.AreEqual("Bob", result.Name);
            Assert.AreEqual(25, result.Age);
            Assert.AreEqual(42, result.Score, "Missing attribute should fall back to the constructor default value.");
        }

        [TestMethod]
        public void InitRecord_RoundTrips()
        {
            var context = CreateContext();
            var original = new InitRecord { Id = "id-3", Name = "Carol" };

            var document = context.ToDocument(original);
            var result = context.FromDocument<InitRecord>(document);

            Assert.AreEqual(original, result);
        }

        [TestMethod]
        public void RecordStruct_RoundTrips()
        {
            var context = CreateContext();
            var original = new RecordStruct("id-4", 7);

            var document = context.ToDocument(original);
            var result = context.FromDocument<RecordStruct>(document);

            Assert.AreEqual(original, result);
            Assert.AreEqual("id-4", result.Id);
            Assert.AreEqual(7, result.Count);
        }

        [TestMethod]
        public void ImmutablePoco_WithGetOnlyProperties_RoundTrips()
        {
            var context = CreateContext();
            var original = new ImmutablePoco("id-5", "Dave");

            var document = context.ToDocument(original);
            var result = context.FromDocument<ImmutablePoco>(document);

            Assert.AreEqual("id-5", result.Id);
            Assert.AreEqual("Dave", result.Name);
        }

        [TestMethod]
        public void MarkedConstructor_IsUsed()
        {
            var context = CreateContext();
            var document = context.ToDocument(new MarkedCtor("id-6", "Eve"));

            var result = context.FromDocument<MarkedCtor>(document);

            Assert.AreEqual("id-6", result.Id);
            Assert.AreEqual("Eve", result.Name);
        }

        [TestMethod]
        public void AmbiguousConstructors_Throws()
        {
            var context = CreateContext();
            var document = new Document { ["Id"] = "id-7" };

            var ex = Assert.ThrowsExactly<InvalidOperationException>(() =>
                context.FromDocument<AmbiguousCtors>(document));

            StringAssert.Contains(ex.Message, "[DynamoDBConstructor]");
        }

        [TestMethod]
        public void MutableType_DoesNotUseBindingConstructor()
        {
            var context = CreateContext();
            var config = new ItemStorageConfig(typeof(MutablePoco));

            Assert.IsNull(config.BaseTypeStorageConfig.BindingConstructor,
                "A type with a public parameterless constructor must keep the existing instantiation path.");
        }

        [TestMethod]
        public void TryGetBindingConstructor_SelectsPrimaryConstructorForRecord()
        {
            var selected = Amazon.DynamoDBv2.DataModel.Utils.TryGetBindingConstructor(typeof(PositionalRecord), out var ctor);

            Assert.IsTrue(selected);
            Assert.IsNotNull(ctor);
            Assert.AreEqual(4, ctor.GetParameters().Length);
        }

        [TestMethod]
        public void TryGetBindingConstructor_ReturnsFalseForMutableType()
        {
            var selected = Amazon.DynamoDBv2.DataModel.Utils.TryGetBindingConstructor(typeof(MutablePoco), out var ctor);

            Assert.IsFalse(selected);
            Assert.IsNull(ctor);
        }

        [TestMethod]
        public void FlattenedMember_AsConstructorArgument_RoundTrips()
        {
            var context = CreateContext();
            var original = new FlattenedRecord("id-8", new FlattenedChild { ChildName = "Frank", ChildValue = 11 });

            var document = context.ToDocument(original);

            // The flattened child's properties are stored as top-level attributes, not under "Child".
            Assert.IsTrue(document.ContainsKey("ChildName"));
            Assert.IsFalse(document.ContainsKey("Child"));

            var result = context.FromDocument<FlattenedRecord>(document);

            Assert.AreEqual("id-8", result.Id);
            Assert.IsNotNull(result.Child, "Flattened member bound through the constructor must be materialized.");
            Assert.AreEqual("Frank", result.Child.ChildName);
            Assert.AreEqual(11, result.Child.ChildValue);
        }

        [TestMethod]
        public void RecordStruct_WithExplicitParameterlessConstructor_RoundTrips()
        {
            var context = CreateContext();
            var original = new StructWithParameterless("id-9", 5);

            var document = context.ToDocument(original);
            var result = context.FromDocument<StructWithParameterless>(document);

            Assert.AreEqual("id-9", result.Id);
            Assert.AreEqual(5, result.Count);
        }

        [TestMethod]
        public void TryGetBindingConstructor_SelectsPrimaryConstructorForRecordStructWithParameterless()
        {
            var selected = Amazon.DynamoDBv2.DataModel.Utils.TryGetBindingConstructor(
                typeof(StructWithParameterless), out var ctor);

            Assert.IsTrue(selected);
            Assert.IsNotNull(ctor);
            Assert.AreEqual(2, ctor.GetParameters().Length);
        }

        [TestMethod]
        public void MarkedConstructor_ForcesBinding_EvenWithParameterlessConstructor()
        {
            var context = CreateContext();
            var original = new ForcedBindingType("id-10", "Grace");

            var document = context.ToDocument(original);
            var result = context.FromDocument<ForcedBindingType>(document);

            Assert.AreEqual("id-10", result.Id);
            Assert.AreEqual("Grace", result.Name);
        }

        [TestMethod]
        public void StorageConfig_FlagsConstructorArguments()
        {
            var context = CreateContext();
            var flatConfig = new DynamoDBFlatConfig(new DynamoDBOperationConfig(), context.Config);
            var config = context.StorageConfigCache.GetConfig<PositionalRecord>(flatConfig);
            var storageConfig = config.BaseTypeStorageConfig;

            Assert.IsNotNull(storageConfig.BindingConstructor);
            Assert.AreEqual(4, storageConfig.ConstructorArguments.Length);
            Assert.IsTrue(storageConfig.Properties
                .Where(p => new[] { "Id", "Name", "Age", "Score" }.Contains(p.PropertyName))
                .All(p => p.IsConstructorArgument));
        }
    }
}
#endif
