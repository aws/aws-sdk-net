using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;
using System.Linq.Expressions;

using DynamoDBContextConfig = Amazon.DynamoDBv2.DataModel.DynamoDBContextConfig;


namespace AWSSDK_DotNet.UnitTests
{
    /// <summary>
    /// Tests for the <see cref="CaseMode"/> / <see cref="DynamoDBTableAttribute.AttributeCasing"/>
    /// feature and its interaction with the obsolete <see cref="DynamoDBTableAttribute.LowerCamelCaseProperties"/>
    /// flag, including casing inheritance into nested objects (issue #1162).
    ///
    /// These tests use a mocked client with <see cref="DynamoDBContextConfig.DisableFetchingTableMetadata"/>
    /// set to true so no AWS calls are made.
    /// </summary>
    [TestClass]
    public class AttributeCasingTests
    {
        // ----- Test entities -----

        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
        }

        // A nested type that declares its own casing; must never be overridden by an enclosing type.
        [DynamoDBTable("AddressPascal", AttributeCasing = CaseMode.PascalCase)]
        public class AddressPascal
        {
            public string Street { get; set; }
            public string City { get; set; }
        }

        // A nested type that declares a distinguishable (non-default) casing.
        [DynamoDBTable("AddressCamel", AttributeCasing = CaseMode.CamelCase)]
        public class AddressCamel
        {
            public string Street { get; set; }
            public string City { get; set; }
        }

        [DynamoDBTable("Orders", AttributeCasing = CaseMode.CamelCase)]
        public class OrderCamelCase
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public string CustomerName { get; set; }
            public Address ShippingAddress { get; set; }
        }

        // Uses the positional CaseMode constructor rather than the named property.
        [DynamoDBTable("Orders", CaseMode.CamelCase)]
        public class OrderCamelCasePositionalCtor
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public string CustomerName { get; set; }
            public Address ShippingAddress { get; set; }
        }

        [DynamoDBTable("Orders", AttributeCasing = CaseMode.PascalCase)]
        public class OrderPascalCase
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public string CustomerName { get; set; }
            public Address ShippingAddress { get; set; }
        }

#pragma warning disable CS0618 // Intentionally exercising the obsolete flag / mode.
        [DynamoDBTable("Orders", LowerCamelCaseProperties = true)]
        public class OrderLegacyBool
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public string CustomerName { get; set; }
            public Address ShippingAddress { get; set; }
        }

        [DynamoDBTable("Orders", AttributeCasing = CaseMode.LegacyCamelCase)]
        public class OrderLegacyMode
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public string CustomerName { get; set; }
            public Address ShippingAddress { get; set; }
        }
#pragma warning restore CS0618

        [DynamoDBTable("Orders", AttributeCasing = CaseMode.CamelCase)]
        public class OrderCamelWithDeclaredNested
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public AddressPascal ShippingAddress { get; set; }
        }

        [DynamoDBTable("Orders", AttributeCasing = CaseMode.PascalCase)]
        public class OrderPascalWithCamelNested
        {
            [DynamoDBHashKey]
            public string Id { get; set; }
            public AddressCamel ShippingAddress { get; set; }
        }

        // A CamelCase root with a [DynamoDBFlatten] member, to verify flatten round-trips symmetrically.
        [DynamoDBTable("Orders", AttributeCasing = CaseMode.CamelCase)]
        public class OrderCamelWithFlatten
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public Address ShippingAddress { get; set; }
        }

        // A CamelCase root with an explicitly PascalCase flattened child: save (via the child's own config)
        // and load (via the parent's FlattenProperties) must agree on the child's attribute casing.
        [DynamoDBTable("Orders", AttributeCasing = CaseMode.CamelCase)]
        public class OrderCamelWithPascalFlatten
        {
            [DynamoDBHashKey]
            public string Id { get; set; }

            [DynamoDBFlatten]
            public AddressPascal ShippingAddress { get; set; }
        }

#if NET8_0_OR_GREATER
        // An immutable (constructor-bound) CamelCase root with an undecorated nested constructor argument.
        // On net8+ the root is populated via constructor binding before PopulateInstance runs, so the
        // nested member's casing must be seeded during constructor-argument binding.
        [DynamoDBTable("Orders", AttributeCasing = CaseMode.CamelCase)]
        public class ImmutableOrderCamelCase
        {
            [DynamoDBHashKey]
            public string Id { get; }
            public string CustomerName { get; }
            public Address ShippingAddress { get; }

            public ImmutableOrderCamelCase(string id, string customerName, Address shippingAddress)
            {
                Id = id;
                CustomerName = customerName;
                ShippingAddress = shippingAddress;
            }
        }
#endif

        private DynamoDBContext CreateContext()
        {
            var mockClient = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);
            mockClient.Setup(m => m.Config).Returns(new AmazonDynamoDBConfig());
            return new DynamoDBContext(mockClient.Object,
                new DynamoDBContextConfig { DisableFetchingTableMetadata = true });
        }

        private static Document BuildOrderDoc<T>(DynamoDBContext context, string id, string name, string street, string city)
        {
            dynamic order = System.Activator.CreateInstance(typeof(T));
            order.Id = id;
            order.CustomerName = name;
            var addr = new Address { Street = street, City = city };
            ((dynamic)order).ShippingAddress = addr;
            return context.ToDocument((T)order);
        }

        // ----- PascalCase (default) -----

        [TestMethod]
        public void PascalCase_RootAndNested_StayPascalCase()
        {
            var context = CreateContext();
            var doc = BuildOrderDoc<OrderPascalCase>(context, "1", "Alice", "Main", "Seattle");

            Assert.IsTrue(doc.ContainsKey("CustomerName"));
            Assert.IsTrue(doc.ContainsKey("ShippingAddress"));
            var nested = doc["ShippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("Street"));
            Assert.IsTrue(nested.ContainsKey("City"));
        }

        // ----- CamelCase: the #1162 fix (root AND nested) -----

        [TestMethod]
        public void CamelCase_RootAndNested_AreCamelCased()
        {
            var context = CreateContext();
            var doc = BuildOrderDoc<OrderCamelCase>(context, "1", "Alice", "Main", "Seattle");

            // Root is camelCased.
            Assert.IsTrue(doc.ContainsKey("customerName"));
            Assert.IsTrue(doc.ContainsKey("shippingAddress"));

            // Nested Map keys are ALSO camelCased (this is the fix).
            var nested = doc["shippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("street"), "Nested Street should be camelCased under CamelCase");
            Assert.IsTrue(nested.ContainsKey("city"), "Nested City should be camelCased under CamelCase");
            Assert.IsFalse(nested.ContainsKey("Street"));
        }

        [TestMethod]
        public void CamelCase_RoundTrip_ReadsBackNestedValues()
        {
            var context = CreateContext();
            var doc = BuildOrderDoc<OrderCamelCase>(context, "1", "Alice", "Main", "Seattle");

            var restored = context.FromDocument<OrderCamelCase>(doc);
            Assert.AreEqual("Alice", restored.CustomerName);
            Assert.IsNotNull(restored.ShippingAddress);
            Assert.AreEqual("Main", restored.ShippingAddress.Street);
            Assert.AreEqual("Seattle", restored.ShippingAddress.City);
        }

        [TestMethod]
        public void CamelCase_NestedExplicitlyDeclaringPascalCase_IsNotOverridden()
        {
            // AddressPascal declares AttributeCasing = CaseMode.PascalCase explicitly. Because the
            // attribute defaults to CaseMode.Unset (not PascalCase), an explicit PascalCase is
            // distinguishable from "not specified" (Unset), so it is honored and BLOCKS inheritance of
            // the enclosing CamelCase. This is the fix
            // for the previous design limitation.
            var context = CreateContext();
            var order = new OrderCamelWithDeclaredNested
            {
                Id = "1",
                ShippingAddress = new AddressPascal { Street = "Main", City = "Seattle" }
            };
            var doc = context.ToDocument(order);

            // Root camelCased...
            Assert.IsTrue(doc.ContainsKey("shippingAddress"));
            // ...but the nested type explicitly declared PascalCase, so it stays PascalCase.
            var nested = doc["shippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("Street"), "Explicit PascalCase on nested type must block inheritance");
            Assert.IsTrue(nested.ContainsKey("City"));
            Assert.IsFalse(nested.ContainsKey("street"));
        }

        [TestMethod]
        public void CamelCase_NestedWithNoCasing_InheritsCamelCase()
        {
            // Address declares no [DynamoDBTable] at all (AttributeCasing is Unset), so it inherits
            // the enclosing CamelCase. This is the round-trip default for the #1162 fix.
            var context = CreateContext();
            var doc = BuildOrderDoc<OrderCamelCase>(context, "1", "Alice", "Main", "Seattle");

            var nested = doc["shippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("street"));
            Assert.IsTrue(nested.ContainsKey("city"));
        }

        [TestMethod]
        public void PascalCaseRoot_NestedDeclaringCamelCase_IsHonored()
        {
            // The distinguishable case: a nested type declaring a NON-default casing (CamelCase) is
            // always honored regardless of the (PascalCase) root, since CamelCase != the unset sentinel.
            var context = CreateContext();
            var order = new OrderPascalWithCamelNested
            {
                Id = "1",
                ShippingAddress = new AddressCamel { Street = "Main", City = "Seattle" }
            };
            var doc = context.ToDocument(order);

            // Root stays PascalCase.
            Assert.IsTrue(doc.ContainsKey("ShippingAddress"));
            // Nested explicitly declared CamelCase, so it is camelCased even though the root is not.
            var nested = doc["ShippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("street"));
            Assert.IsTrue(nested.ContainsKey("city"));
        }

        // ----- LegacyCamelCase: reproduces LowerCamelCaseProperties = true (root only) -----

        [TestMethod]
        public void LegacyCamelCase_CamelCasesRootButNotNested()
        {
            var context = CreateContext();
            var doc = BuildOrderDoc<OrderLegacyMode>(context, "1", "Alice", "Main", "Seattle");

            // Root camelCased.
            Assert.IsTrue(doc.ContainsKey("customerName"));
            Assert.IsTrue(doc.ContainsKey("shippingAddress"));

            // Nested stays PascalCase (the legacy asymmetric behavior).
            var nested = doc["shippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("Street"));
            Assert.IsTrue(nested.ContainsKey("City"));
            Assert.IsFalse(nested.ContainsKey("street"));
        }

        [TestMethod]
        public void ObsoleteBool_MatchesLegacyCamelCaseMode()
        {
            var context = CreateContext();
            var legacyBoolDoc = BuildOrderDoc<OrderLegacyBool>(context, "1", "Alice", "Main", "Seattle");
            var legacyModeDoc = BuildOrderDoc<OrderLegacyMode>(context, "1", "Alice", "Main", "Seattle");

            // Root
            Assert.AreEqual(legacyModeDoc.ContainsKey("customerName"), legacyBoolDoc.ContainsKey("customerName"));
            Assert.IsTrue(legacyBoolDoc.ContainsKey("shippingAddress"));

            // Nested identical (both PascalCase inside)
            var boolNested = legacyBoolDoc["shippingAddress"].AsDocument();
            var modeNested = legacyModeDoc["shippingAddress"].AsDocument();
            Assert.IsTrue(boolNested.ContainsKey("Street"));
            Assert.IsTrue(modeNested.ContainsKey("Street"));
        }

        [TestMethod]
        public void PositionalCaseModeConstructor_AppliesCasing()
        {
            // The [DynamoDBTable("Orders", CaseMode.CamelCase)] positional constructor should behave
            // identically to setting AttributeCasing = CaseMode.CamelCase via the named property.
            var context = CreateContext();
            var order = new OrderCamelCasePositionalCtor
            {
                Id = "1",
                CustomerName = "Alice",
                ShippingAddress = new Address { Street = "Main", City = "Seattle" }
            };
            var doc = context.ToDocument(order);

            Assert.IsTrue(doc.ContainsKey("customerName"));
            Assert.IsTrue(doc.ContainsKey("shippingAddress"));
            var nested = doc["shippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("street"));
            Assert.IsTrue(nested.ContainsKey("city"));
        }

        [TestMethod]
        public void CaseModeConstructors_SetAttributeCasing()
        {
            // Direct construction: the CaseMode constructors set AttributeCasing and default correctly.
            Assert.AreEqual(CaseMode.Unset, new DynamoDBTableAttribute("T").AttributeCasing);
            Assert.AreEqual(CaseMode.CamelCase, new DynamoDBTableAttribute("T", CaseMode.CamelCase).AttributeCasing);

            var withConversion = new DynamoDBTableAttribute("T", CaseMode.PascalCase, ConversionSchema.V2);
            Assert.AreEqual(CaseMode.PascalCase, withConversion.AttributeCasing);
            Assert.AreEqual(ConversionSchema.V2, withConversion.Conversion);
        }

        [TestMethod]
        public void CamelCase_FilterExpressionOnNestedProperty_UsesInheritedCasing()
        {
            // Regression for a filter/update expression referencing a nested property under a CamelCase
            // root: the nested attribute name must resolve to the inherited (camelCased) name that is
            // actually stored, not the nested type's PascalCase base config. Previously this path did not
            // seed InheritedAttributeCasing while descending, so it emitted "City" instead of "city".
            var context = CreateContext();

            Expression<Func<OrderCamelCase, bool>> expr = e => e.ShippingAddress.City == "Seattle";
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var result = context.ConvertScan<OrderCamelCase>(filterExpr, null);
            var names = result.Search.FilterExpression.ExpressionAttributeNames;

            // The path expands to two name placeholders (shippingAddress.city); both must be camelCased.
            CollectionAssert.Contains(names.Values, "shippingAddress");
            CollectionAssert.Contains(names.Values, "city");
            CollectionAssert.DoesNotContain(names.Values, "City");
            CollectionAssert.DoesNotContain(names.Values, "ShippingAddress");
        }

        [TestMethod]
        public void CamelCase_FlattenedMember_RoundTripsSymmetrically()
        {
            // Flattened members follow the enclosing type's casing on BOTH save and load (they share the
            // parent's FlattenProperties metadata), so a CamelCase root writes and reads camelCased
            // flattened attribute names with no round-trip loss.
            var context = CreateContext();
            var order = new OrderCamelWithFlatten
            {
                Id = "1",
                ShippingAddress = new Address { Street = "Main", City = "Seattle" }
            };
            var doc = context.ToDocument(order);

            // Flattened attributes are top-level and camelCased.
            Assert.IsTrue(doc.ContainsKey("street"));
            Assert.IsTrue(doc.ContainsKey("city"));
            Assert.IsFalse(doc.ContainsKey("Street"));

            var restored = context.FromDocument<OrderCamelWithFlatten>(doc);
            Assert.IsNotNull(restored.ShippingAddress);
            Assert.AreEqual("Main", restored.ShippingAddress.Street);
            Assert.AreEqual("Seattle", restored.ShippingAddress.City);
        }

        [TestMethod]
        public void CamelCaseParent_ExplicitPascalCaseFlattenedChild_RoundTripsSymmetrically()
        {
            // A CamelCase parent with an explicitly PascalCase flattened child: save serializes the child
            // via its own (PascalCase) config, so load must read the same PascalCase names. The
            // FlattenProperties metadata is baked with the child's effective casing to keep save and load
            // consistent — otherwise the values would be lost on round-trip.
            var context = CreateContext();
            var order = new OrderCamelWithPascalFlatten
            {
                Id = "1",
                ShippingAddress = new AddressPascal { Street = "Main", City = "Seattle" }
            };
            var doc = context.ToDocument(order);

            // The explicitly PascalCase child writes PascalCase top-level flattened attributes.
            Assert.IsTrue(doc.ContainsKey("Street"));
            Assert.IsTrue(doc.ContainsKey("City"));
            Assert.IsFalse(doc.ContainsKey("street"));

            var restored = context.FromDocument<OrderCamelWithPascalFlatten>(doc);
            Assert.IsNotNull(restored.ShippingAddress);
            Assert.AreEqual("Main", restored.ShippingAddress.Street);
            Assert.AreEqual("Seattle", restored.ShippingAddress.City);
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        public void CamelCase_ImmutableRoot_NestedConstructorArg_UsesInheritedCasing()
        {
            // Regression: on net8+ an immutable root is populated via constructor binding before
            // PopulateInstance runs. The nested constructor argument must be deserialized with the root's
            // inherited casing, otherwise it looks for PascalCase names ("Street"/"City") that aren't in
            // the stored camelCased document and the constructor-bound member can't be repaired afterward.
            var context = CreateContext();

            // Produce a correctly-shaped, camelCased document via the mutable equivalent (same table/casing),
            // then deserialize it into the immutable (constructor-bound) type.
            var doc = BuildOrderDoc<OrderCamelCase>(context, "1", "Alice", "Main", "Seattle");

            // Sanity: the stored nested Map keys are camelCased.
            Assert.IsTrue(doc["shippingAddress"].AsDocument().ContainsKey("street"));

            var restored = context.FromDocument<ImmutableOrderCamelCase>(doc);

            Assert.AreEqual("Alice", restored.CustomerName);
            Assert.IsNotNull(restored.ShippingAddress);
            Assert.AreEqual("Main", restored.ShippingAddress.Street);
            Assert.AreEqual("Seattle", restored.ShippingAddress.City);
        }
#endif

        [TestMethod]
        public void CamelCase_FilterExpressionNestedObjectValue_SerializesWithInheritedCasing()
        {
            // Regression: the comparison VALUE of a nested-object filter (e.ShippingAddress == new Address{..})
            // is serialized after the name path is resolved. It must serialize with the casing inherited from
            // the property's enclosing type, otherwise the value's Map is written with PascalCase keys
            // (Street/City) and never matches the stored camelCased item.
            var context = CreateContext();

            var target = new Address { Street = "Main", City = "Seattle" };
            Expression<Func<OrderCamelCase, bool>> expr = e => e.ShippingAddress == target;
            var filterExpr = new ContextExpression();
            filterExpr.SetFilter(expr);

            var result = context.ConvertScan<OrderCamelCase>(filterExpr, null);
            var values = result.Search.FilterExpression.ExpressionAttributeValues;

            // The single value is the nested Address serialized as a Map; its keys must be camelCased.
            var addressMap = values.Values.Single().AsDocument();
            Assert.IsTrue(addressMap.ContainsKey("street"), "nested value Map key should be camelCased");
            Assert.IsTrue(addressMap.ContainsKey("city"));
            Assert.IsFalse(addressMap.ContainsKey("Street"));
        }
        [TestMethod]
        public void CamelCase_NestedTypeUsedAsRootFirst_StillInheritsWhenNested()
        {
            // Cache-ordering regression: if the nested type is first converted as a root, its table config
            // is cached. A later nested use under a CamelCase parent must still resolve the inherited
            // (camelCased) variant, not the cached base PascalCase config.
            var context = CreateContext();

            // 1) Convert Address as a root first, populating its table-cache entry with PascalCase names.
            var rootDoc = context.ToDocument(new Address { Street = "Main", City = "Seattle" });
            Assert.IsTrue(rootDoc.ContainsKey("Street"));

            // 2) Now convert an order whose CamelCase root nests the same Address type.
            var doc = BuildOrderDoc<OrderCamelCase>(context, "1", "Alice", "Main", "Seattle");
            var nested = doc["shippingAddress"].AsDocument();
            Assert.IsTrue(nested.ContainsKey("street"), "nested Address must inherit CamelCase even after being cached as a root");
            Assert.IsTrue(nested.ContainsKey("city"));
            Assert.IsFalse(nested.ContainsKey("Street"));
        }
    }
}

