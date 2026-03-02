using System;
using System.Collections.Generic;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ItemStorageConfigTests
    {
        private class TestClass
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime EventTime { get; set; }
            public DateTime EventTimeLong { get; set; }
            public string GsiHash { get; set; }
            public string LsiRange { get; set; }
            public int? Version { get; set; }
            public FlattenType Flatten { get; set; }
            // Polymorphic property for tests
            public TestClass Poly { get; set; }
        }

        private class DerivedType : TestClass
        {
            public string Extra { get; set; }
        }

        private class FlattenType
        {
            public string FlattenedProp { get; set; }
        }

        private class DummyContext : DynamoDBContext
        {
            public DummyContext(IAmazonDynamoDB client) : base(client, false, null) { }
        }

        private ItemStorageConfig CreatePopulatedConfig(Mock<IAmazonDynamoDB> mockClient)
        {
            var config = new ItemStorageConfig(typeof(TestClass));

            // Id - hash key
            var idProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.Id)))
            {
                AttributeName = "Id",
                IsHashKey = true
            };
            idProp.IndexNames ??= new List<string>();
            idProp.FlattenProperties ??= new List<PropertyStorage>();

            // Name - range key
            var nameProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.Name)))
            {
                AttributeName = "Name",
                IsRangeKey = true
            };
            nameProp.IndexNames ??= new List<string>();
            nameProp.FlattenProperties ??= new List<PropertyStorage>();

            // EventTime - store as epoch (int)
            var epochProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.EventTime)))
            {
                AttributeName = "EventTime",
                StoreAsEpoch = true
            };
            epochProp.IndexNames ??= new List<string>();
            epochProp.FlattenProperties ??= new List<PropertyStorage>();

            // EventTimeLong - store as epoch long
            var epochLongProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.EventTimeLong)))
            {
                AttributeName = "EventTimeLong",
                StoreAsEpochLong = true
            };
            epochLongProp.IndexNames ??= new List<string>();
            epochLongProp.FlattenProperties ??= new List<PropertyStorage>();

            // GSI hash key
            var gsiHashProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.GsiHash)))
            {
                AttributeName = "GsiHash",
                IsGSIHashKey = true
            };
            // Add GSI index info (IsHashKey true inside GSI index)
            gsiHashProp.IndexNames ??= new List<string>();
            gsiHashProp.FlattenProperties ??= new List<PropertyStorage>();
            gsiHashProp.AddGsiIndex(true, "GsiHash", 0, "GSI_A");

            // LSI range key
            var lsiRangeProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.LsiRange)))
            {
                AttributeName = "LsiRange",
                IsLSIRangeKey = true
            };
            lsiRangeProp.IndexNames ??= new List<string>();
            lsiRangeProp.FlattenProperties ??= new List<PropertyStorage>();
            lsiRangeProp.AddLsiIndex("LsiRange", "LSI_A");

            // Add all properties to base storage config
            config.BaseTypeStorageConfig.Properties.Add(idProp);
            config.BaseTypeStorageConfig.Properties.Add(nameProp);
            config.BaseTypeStorageConfig.Properties.Add(epochProp);
            config.BaseTypeStorageConfig.Properties.Add(epochLongProp);
            config.BaseTypeStorageConfig.Properties.Add(gsiHashProp);
            config.BaseTypeStorageConfig.Properties.Add(lsiRangeProp);

            return config;
        }

        [TestMethod]
        public void Denormalize_PopulatesKeys_AttributesAndIndexMappings()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var config = CreatePopulatedConfig(mockClient);

            // denormalize should populate attribute lists, key property names and index mappings
            config.Denormalize(context, derivedTypeAttributeName: "dtype");

            CollectionAssert.IsSubsetOf(new List<string> { "Id", "Name", "EventTime", "EventTimeLong", "GsiHash", "LsiRange" }, config.AttributesToGet);

            CollectionAssert.Contains(config.HashKeyPropertyNames, nameof(TestClass.Id));
            CollectionAssert.Contains(config.RangeKeyPropertyNames, nameof(TestClass.Name));

            Assert.IsTrue(config.AttributesToStoreAsEpoch.Contains("EventTime"));
            Assert.IsTrue(config.AttributesToStoreAsEpochLong.Contains("EventTimeLong"));

            Assert.IsTrue(config.AttributeToIndexesNameMapping.ContainsKey("GsiHash"));
            CollectionAssert.Contains(config.AttributeToIndexesNameMapping["GsiHash"], "GSI_A");

            Assert.IsTrue(config.AttributeToIndexesNameMapping.ContainsKey("LsiRange"));
            CollectionAssert.Contains(config.AttributeToIndexesNameMapping["LsiRange"], "LSI_A");

            Assert.IsTrue(config.IndexNameToGSIMapping.ContainsKey("GSI_A"));
            var gsi = config.IndexNameToGSIMapping["GSI_A"];
            Assert.IsTrue(gsi.HashKeyPropertyNames.ContainsKey(nameof(TestClass.GsiHash)));

            Assert.IsTrue(config.IndexNameToLSIRangePropertiesMapping.ContainsKey("LSI_A"));
            CollectionAssert.Contains(config.IndexNameToLSIRangePropertiesMapping["LSI_A"], nameof(TestClass.LsiRange));

            Assert.IsFalse(config.AttributesToGet.Contains("dtype"));
        }

        [TestMethod]
        public void AddPolymorphicPropertyStorageConfiguration_RegistersMappings()
        {
            var config = new ItemStorageConfig(typeof(TestClass));
            var polyStorage = new StorageConfig(typeof(DerivedType));

            config.AddPolymorphicPropertyStorageConfiguration("DT1", typeof(DerivedType), polyStorage);

            Assert.IsTrue(config.PolymorphicTypesStorageConfig.ContainsKey("DT1"));
            Assert.AreSame(polyStorage, config.PolymorphicTypesStorageConfig["DT1"]);
            Assert.IsTrue(config.PolymorphicConfig.ContainsKey(typeof(DerivedType)));
            Assert.AreEqual("DT1", config.PolymorphicConfig[typeof(DerivedType)]);
        }

        [TestMethod]
        public void GetRangeKeyByIndex_ReturnsLsiThenGsiOverrides()
        {
            var config = new ItemStorageConfig(typeof(TestClass));

            config.IndexNameToLSIRangePropertiesMapping["LSI_A"] = new List<string> { "LsiRange" };

            var gsiConfig = new GSIConfig("GSI_A");
            gsiConfig.RangeKeyPropertyNames["GsiRange"] = 0;
            config.IndexNameToGSIMapping["GSI_A"] = gsiConfig;

            var lsiRange = config.GetRangeKeyByIndex("LSI_A");
            CollectionAssert.AreEqual(new List<string> { "LsiRange" }, lsiRange);

            var gsiRange = config.GetRangeKeyByIndex("GSI_A");
            CollectionAssert.AreEqual(new List<string> { "GsiRange" }, gsiRange);
        }

        [TestMethod]
        public void GetCorrectHashKeyProperty_UsesGsiWhenIndexOperation()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var ctx = new DummyContext(mockClient.Object);

            var config = new ItemStorageConfig(typeof(TestClass));

            var gsi = new GSIConfig("GSI_A");
            gsi.HashKeyPropertyNames["GsiHash"] = 0;
            config.IndexNameToGSIMapping["GSI_A"] = gsi;

            var flatConfig = new DynamoDBFlatConfig(new DynamoDBOperationConfig(), new DynamoDBContextConfig())
            {
                IndexName = "GSI_A"
            };

            var original = new List<string> { nameof(TestClass.Id) };
            var corrected = config.GetCorrectHashKeyProperty(flatConfig, original);

            CollectionAssert.AreEqual(new List<string> { "GsiHash" }, corrected);
        }


        [TestMethod]
        public void Denormalize_IncludesDerivedTypeAttributeAndPolymorphicProperties()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var config = CreatePopulatedConfig(mockClient);

            // create polymorphic storage config for DerivedType with one property
            var polyStorage = new StorageConfig(typeof(DerivedType));
            var extraProp = new PropertyStorage(typeof(DerivedType).GetProperty(nameof(DerivedType.Extra)))
            {
                AttributeName = "Extra"
            };
            extraProp.IndexNames ??= new List<string>();
            extraProp.FlattenProperties ??= new List<PropertyStorage>();
            polyStorage.Properties.Add(extraProp);

            // register polymorphic mapping and mark the base property as polymorphic
            config.AddPolymorphicPropertyStorageConfiguration("DT1", typeof(DerivedType), polyStorage);

            // Add a polymorphic property on the base type so that it's processed during Denormalize
            var polyPropOnBase = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.Poly)))
            {
                AttributeName = "Poly",
                PolymorphicProperty = true
            };
            polyPropOnBase.IndexNames ??= new List<string>();
            polyPropOnBase.FlattenProperties ??= new List<PropertyStorage>();
            config.BaseTypeStorageConfig.Properties.Add(polyPropOnBase);

            // call Denormalize and request derived type attribute name "dtype"
            config.Denormalize(context, derivedTypeAttributeName: "dtype");

            Assert.IsTrue(config.AttributesToGet.Contains("dtype"));

            Assert.IsTrue(config.AttributesToGet.Contains("Extra"));

            Assert.IsTrue(config.PolymorphicTypesStorageConfig.ContainsKey("DT1"));
            Assert.AreSame(polyStorage, config.PolymorphicTypesStorageConfig["DT1"]);

            Assert.IsTrue(config.PolymorphicConfig.ContainsKey(typeof(DerivedType)));
            Assert.AreEqual("DT1", config.PolymorphicConfig[typeof(DerivedType)]);
        }

        [TestMethod]
        public void Denormalize_FlattensChildProperties_ProcessesFlattenProperties()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var config = CreatePopulatedConfig(mockClient);

            // Parent property that should be flattened
            var parentProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.Flatten)))
            {
                AttributeName = "Flatten",
                ShouldFlattenChildProperties = true
            };
            parentProp.IndexNames ??= new List<string>();
            parentProp.FlattenProperties ??= new List<PropertyStorage>();

            // Child property which will be processed via flattening (make it a GSI to validate index mappings)
            var childProp = new PropertyStorage(typeof(FlattenType).GetProperty(nameof(FlattenType.FlattenedProp)))
            {
                AttributeName = "FlattenedGsi",
                IsGSIHashKey = true
            };
            childProp.IndexNames ??= new List<string>();
            childProp.FlattenProperties ??= new List<PropertyStorage>();
            childProp.AddGsiIndex(true, "FlattenedGsi", 0, "GSI_FLAT");

            parentProp.FlattenProperties.Add(childProp);
            config.BaseTypeStorageConfig.Properties.Add(parentProp);

            config.Denormalize(context, derivedTypeAttributeName: "dtype");

            // The flattened child should be treated like a normal property by Denormalize
            Assert.IsTrue(config.AttributesToGet.Contains("FlattenedGsi"));

            Assert.IsTrue(config.AttributeToIndexesNameMapping.ContainsKey("FlattenedGsi"));
            CollectionAssert.Contains(config.AttributeToIndexesNameMapping["FlattenedGsi"], "GSI_FLAT");

            Assert.IsTrue(config.IndexNameToGSIMapping.ContainsKey("GSI_FLAT"));
            var gsi = config.IndexNameToGSIMapping["GSI_FLAT"];
            Assert.IsTrue(gsi.HashKeyPropertyNames.ContainsKey("FlattenedProp"));
        }

        [TestMethod]
        public void GetGSIConfig_ReturnsNullWhenMissing()
        {
            var config = new ItemStorageConfig(typeof(TestClass));

            var result = config.GetGSIConfig("NON_EXISTENT_INDEX");

            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetGSIConfig_ReturnsGSIConfigWithKeys()
        {
            var config = new ItemStorageConfig(typeof(TestClass));

            var gsi = new GSIConfig("GSI_A")
            {
                HashKeyPropertyNames =
                {
                    ["KeyA"] = 0
                },
                RangeKeyPropertyNames =
                {
                    ["RangeA"] = 1
                }
            };

            config.IndexNameToGSIMapping["GSI_A"] = gsi;

            var result = config.GetGSIConfig("GSI_A");

            Assert.IsNotNull(result);
            Assert.AreSame(gsi, result);
            Assert.IsTrue(result.HashKeyPropertyNames.ContainsKey("KeyA"));
            Assert.IsTrue(result.RangeKeyPropertyNames.ContainsKey("RangeA"));
        }

        [TestMethod]
        public void GetGSIConfig_IsCaseSensitive()
        {
            var config = new ItemStorageConfig(typeof(TestClass));

            var gsi = new GSIConfig("GSI_A");
            config.IndexNameToGSIMapping["GSI_A"] = gsi;

            // mapping uses StringComparer.Ordinal, so different case should not match
            var result = config.GetGSIConfig("gsi_a");
            Assert.IsNull(result);
        }


        [TestMethod]
        public void VersionPropertyStorage_ThrowsWhenNoVersionDefined()
        {
            var config = new ItemStorageConfig(typeof(TestClass));

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                var _ = config.VersionPropertyStorage;
            });
        }

        [TestMethod]
        public void VersionPropertyStorage_ReturnsPropertyStorage_WhenVersionDefined()
        {
            var mockClient = new Mock<IAmazonDynamoDB>();
            var context = new DummyContext(mockClient.Object);

            var config = new ItemStorageConfig(typeof(TestClass));

            var versionProp = new PropertyStorage(typeof(TestClass).GetProperty(nameof(TestClass.Version)))
            {
                AttributeName = "Version",
                IsVersion = true
            };
            versionProp.IndexNames ??= new List<string>();
            versionProp.FlattenProperties ??= new List<PropertyStorage>();

            config.BaseTypeStorageConfig.Properties.Add(versionProp);
            config.Denormalize(context, derivedTypeAttributeName: "dtype");
            var result = config.VersionPropertyStorage;
            Assert.IsNotNull(result);
            Assert.AreSame(versionProp, result);
            Assert.AreEqual(nameof(TestClass.Version), config.VersionPropertyName);
        }
    }
}