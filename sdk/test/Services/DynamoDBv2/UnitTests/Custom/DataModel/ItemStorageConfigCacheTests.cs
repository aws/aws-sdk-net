using System;
using System.Collections.Generic;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DynamoDBContextConfig = Amazon.DynamoDBv2.DataModel.DynamoDBContextConfig;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ItemStorageConfigCacheTests
    {
        public class TestEntity
        {
            [DynamoDBHashKey] public int Id { get; set; }
            [DynamoDBRangeKey] public string Name { get; set; }
            public string Description { get; set; }
        }

        public class TestGSIEntity
        {
            [DynamoDBHashKey] public int Id { get; set; }


            [DynamoDBGlobalSecondaryIndexHashKey("GSI1", Order = 2)]
            public string GsiHash2 { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GSI1", Order = 1)]
            public string GsiHash { get; set; }


            [DynamoDBGlobalSecondaryIndexRangeKey("GSI1", Order = 1)]
            public string GsiRange { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GSI1", Order = 2)]
            public string GsiRange2 { get; set; }
        }

        [DynamoDBTable("HashTable")]
        public class OrderIndex
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            [DynamoDBProperty("Company")]
            public string CompanyName { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex")]
            public string CompanyInfo { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Price { get; set; }
        }

        private Mock<IAmazonDynamoDB> mockClient;
        private DynamoDBContext context;

        [TestInitialize]
        public void Initialize()
        {
            mockClient = new Mock<IAmazonDynamoDB>(MockBehavior.Strict);
            mockClient.Setup(m => m.Config).Returns(new AmazonDynamoDBConfig());
            mockClient.Setup(m => m.DescribeTable(It.IsAny<DescribeTableRequest>()))
                .Returns((DescribeTableRequest req) =>
                {
                    if (req.TableName == "CustomGSITable")
                    {
                        return new DescribeTableResponse
                        {
                            Table = new TableDescription
                            {
                                TableName = "CustomGSITable",
                                KeySchema = new List<KeySchemaElement>
                                {
                                    new KeySchemaElement { AttributeName = "CustomId", KeyType = KeyType.HASH }
                                },
                                AttributeDefinitions = new List<AttributeDefinition>
                                {
                                    new AttributeDefinition
                                        { AttributeName = "CustomId", AttributeType = ScalarAttributeType.N },
                                    new AttributeDefinition
                                        { AttributeName = "CustomGsiHash", AttributeType = ScalarAttributeType.S },
                                    new AttributeDefinition
                                        { AttributeName = "CustomGsiHash2", AttributeType = ScalarAttributeType.S },
                                    new AttributeDefinition
                                        { AttributeName = "CustomGsiRange", AttributeType = ScalarAttributeType.S },
                                    new AttributeDefinition
                                        { AttributeName = "CustomGsiRange2", AttributeType = ScalarAttributeType.S }
                                },
                                GlobalSecondaryIndexes = new List<GlobalSecondaryIndexDescription>()
                                {
                                    new GlobalSecondaryIndexDescription
                                    {
                                        IndexName = "GSI1",
                                        KeySchema = new List<KeySchemaElement>
                                        {
                                            new KeySchemaElement { AttributeName = "CustomGsiHash2", KeyType = KeyType.HASH },
                                            new KeySchemaElement { AttributeName = "CustomGsiHash", KeyType = KeyType.HASH },
                                            new KeySchemaElement
                                                { AttributeName = "CustomGsiRange", KeyType = KeyType.RANGE },
                                            new KeySchemaElement
                                                { AttributeName = "CustomGsiRange2", KeyType = KeyType.RANGE }
                                        },
                                        Projection = new Projection { ProjectionType = ProjectionType.ALL },
                                        IndexStatus = IndexStatus.ACTIVE
                                    }
                                }
                            }
                        };
                    }

                    if (req.TableName == "HashTable")
                    {
                        return new DescribeTableResponse
                        {
                            Table = new TableDescription
                            {
                                TableName = "HashTable",
                                KeySchema = new List<KeySchemaElement>
                                {
                                    new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH }
                                },
                                AttributeDefinitions = new List<AttributeDefinition>
                                {
                                    new AttributeDefinition
                                        { AttributeName = "Id", AttributeType = ScalarAttributeType.N },

                                    new AttributeDefinition
                                        { AttributeName = "Company", AttributeType = ScalarAttributeType.S },

                                    new AttributeDefinition
                                        { AttributeName = "Price", AttributeType = ScalarAttributeType.N }
                                },
                                GlobalSecondaryIndexes = new List<GlobalSecondaryIndexDescription>()
                                {
                                    new GlobalSecondaryIndexDescription
                                    {
                                        IndexName = "GlobalIndex",
                                        KeySchema = new List<KeySchemaElement>
                                        {
                                            new KeySchemaElement { AttributeName = "Company", KeyType = KeyType.HASH },
                                            new KeySchemaElement
                                                { AttributeName = "Price", KeyType = KeyType.RANGE }
                                        },
                                        Projection = new Projection { ProjectionType = ProjectionType.ALL },
                                        IndexStatus = IndexStatus.ACTIVE
                                    }
                                }
                            }
                        };
                    }

                    if (req.TableName == "CustomTestTable")
                    {
                        return new DescribeTableResponse
                        {
                            Table = new TableDescription
                            {
                                TableName = "CustomTestTable",
                                KeySchema = new List<KeySchemaElement>
                                {
                                    new KeySchemaElement { AttributeName = "CustomId", KeyType = KeyType.HASH },
                                    new KeySchemaElement { AttributeName = "CustomName", KeyType = KeyType.RANGE }
                                },
                                AttributeDefinitions = new List<AttributeDefinition>
                                {
                                    new AttributeDefinition
                                        { AttributeName = "CustomId", AttributeType = ScalarAttributeType.N },
                                    new AttributeDefinition
                                        { AttributeName = "CustomName", AttributeType = ScalarAttributeType.S }
                                }
                            }
                        };
                    }

                    // Default for TestEntity
                    return new DescribeTableResponse
                    {
                        Table = new TableDescription
                        {
                            TableName = "TestEntity",
                            KeySchema = new List<KeySchemaElement>
                            {
                                new KeySchemaElement { AttributeName = "Id", KeyType = KeyType.HASH },
                                new KeySchemaElement { AttributeName = "Name", KeyType = KeyType.RANGE }
                            },
                            AttributeDefinitions = new List<AttributeDefinition>
                            {
                                new AttributeDefinition { AttributeName = "Id", AttributeType = ScalarAttributeType.N },
                                new AttributeDefinition
                                    { AttributeName = "Name", AttributeType = ScalarAttributeType.S }
                            }
                        }
                    };
                });

            context = new DynamoDBContext(mockClient.Object, new DynamoDBContextConfig());
        }

        [TestMethod]
        public void GetConfig_SetsItemConversion_And_CachesConfig()
        {
            var flatConfig1 = new DynamoDBFlatConfig(null, context.Config);

            // first call: creates config and sets flatConfig.ItemConversion
            var config1 = context.StorageConfigCache.GetConfig(typeof(TestEntity), flatConfig1, conversionOnly: false);
            Assert.IsNotNull(config1);
            Assert.AreEqual(config1.Conversion, flatConfig1.ItemConversion);

            // second call with a different flatConfig should return the cached config instance for the same table
            var flatConfig2 = new DynamoDBFlatConfig(null, context.Config);
            var config2 = context.StorageConfigCache.GetConfig(typeof(TestEntity), flatConfig2, conversionOnly: false);
            Assert.IsNotNull(config2);
            Assert.AreSame(config1, config2);
            Assert.AreEqual(config2.Conversion, flatConfig2.ItemConversion);
        }

        [TestMethod]
        public void GetConfig_ConversionOnly_ReturnsBaseTypeConfig_And_SetsItemConversion()
        {
            var flatConfig = new DynamoDBFlatConfig(null, context.Config);

            // conversionOnly should return the base type config and set ItemConversion on flatConfig
            var baseConfig = context.StorageConfigCache.GetConfig(typeof(TestEntity), flatConfig, conversionOnly: true);
            Assert.IsNotNull(baseConfig);
            Assert.AreEqual(baseConfig.Conversion, flatConfig.ItemConversion);
        }

        [TestMethod]
        public void GetConfig_WhenCached_AndFlatConfigNull_ThrowsArgumentNullException()
        {
            // populate cache first
            var flatConfig = new DynamoDBFlatConfig(null, context.Config);
            var cached = context.StorageConfigCache.GetConfig(typeof(TestEntity), flatConfig, conversionOnly: false);
            Assert.IsNotNull(cached);

            // subsequent call with null flatConfig should throw ArgumentNullException per implementation
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                var _ = context.StorageConfigCache.GetConfig(typeof(TestEntity), null, conversionOnly: false);
            });
        }

        [TestMethod]
        public void GetConfig_ConversionOnly_WhenTableCacheExists_ReturnsBaseTypeConfig()
        {
            var flatConfigForTable = new DynamoDBFlatConfig(null, context.Config);
            var tableConfig =
                context.StorageConfigCache.GetConfig(typeof(TestEntity), flatConfigForTable, conversionOnly: false);
            Assert.IsNotNull(tableConfig);

            var flatConfigForConversion = new DynamoDBFlatConfig(null, context.Config);
            var baseConfig =
                context.StorageConfigCache.GetConfig(typeof(TestEntity), flatConfigForConversion, conversionOnly: true);

            Assert.IsNotNull(baseConfig);
            Assert.AreNotSame(tableConfig, baseConfig,
                "conversionOnly should return the base type config, not the table-specific config.");
            Assert.AreEqual(baseConfig.Conversion, flatConfigForConversion.ItemConversion);
        }

        [TestMethod]
        public void GetConfig_WithTypeMappings_PopulatesConfigFromMappings()
        {
            var typeMapping = new TypeMapping(typeof(ContextInternalTests.TestEntity), "CustomTestTable");
            typeMapping.AddProperty(new PropertyConfig("Id")
            {
                Attribute = "CustomId",
            });
            typeMapping.AddProperty(new PropertyConfig("Name")
            {
                Attribute = "CustomName",
            });
            typeMapping.AddProperty(new PropertyConfig("Description")
            {
                Attribute = "CustomDescription",
            });

            AWSConfigsDynamoDB.Context.AddMapping(typeMapping);

            var flatConfig = new DynamoDBFlatConfig(null, context.Config);

            var config = context.StorageConfigCache.GetConfig(typeof(ContextInternalTests.TestEntity), flatConfig,
                conversionOnly: false);

            Assert.IsNotNull(config);
            Assert.AreEqual("CustomTestTable", config.TableName);

            var idProperty = config.BaseTypeStorageConfig.GetPropertyStorage("Id");
            Assert.AreEqual("CustomId", idProperty.AttributeName);

            var nameProperty = config.BaseTypeStorageConfig.GetPropertyStorage("Name");
            Assert.AreEqual("CustomName", nameProperty.AttributeName);

            var descProperty = config.BaseTypeStorageConfig.GetPropertyStorage("Description");
            Assert.AreEqual("CustomDescription", descProperty.AttributeName);
        }

        [TestMethod]
        public void GetConfig_WhenGlobalSecondaryIndexDescription_OverwritesAttributes()
        {
            var flatConfig = new DynamoDBFlatConfig(null, context.Config);

            var config = context.StorageConfigCache.GetConfig(typeof(OrderIndex), flatConfig, conversionOnly: false);
            Assert.IsNotNull(config);

            var gsi = config.GetGSIConfig("GlobalIndex");
            Assert.IsNotNull(gsi);
            Assert.AreEqual("GlobalIndex", gsi.IndexName);
            Assert.AreEqual(1, gsi.HashKeyPropertyNames.Count);
            Assert.AreEqual(0, gsi.HashKeyPropertyNames["CompanyName"]);
            Assert.AreEqual(0, gsi.RangeKeyPropertyNames["Price"]);

        }


        [TestMethod]
        public void GetConfig_WithTypeMappings_TestGSIEntity_PopulatesConfigFromMappings()
        {
            var typeMapping = new TypeMapping(typeof(TestGSIEntity), "CustomGSITable");
            typeMapping.AddProperty(new PropertyConfig("Id")
            {
                Attribute = "CustomId",
            });
            typeMapping.AddProperty(new PropertyConfig("GsiHash")
            {
                Attribute = "CustomGsiHash",
            });
            typeMapping.AddProperty(new PropertyConfig("GsiHash2")
            {
                Attribute = "CustomGsiHash2",
            });
            typeMapping.AddProperty(new PropertyConfig("GsiRange")
            {
                Attribute = "CustomGsiRange",
            });
            typeMapping.AddProperty(new PropertyConfig("GsiRange2")
            {
                Attribute = "CustomGsiRange2",
            });

            AWSConfigsDynamoDB.Context.AddMapping(typeMapping);

            var flatConfig = new DynamoDBFlatConfig(null, context.Config);

            var config = context.StorageConfigCache.GetConfig(typeof(TestGSIEntity), flatConfig, conversionOnly: false);

            Assert.IsNotNull(config);
            Assert.AreEqual("CustomGSITable", config.TableName);

            var idProperty = config.BaseTypeStorageConfig.GetPropertyStorage("Id");
            Assert.AreEqual("CustomId", idProperty.AttributeName);

            var gsiHashProperty = config.BaseTypeStorageConfig.GetPropertyStorage("GsiHash");
            Assert.AreEqual("CustomGsiHash", gsiHashProperty.AttributeName);

            var gsiHash2Property = config.BaseTypeStorageConfig.GetPropertyStorage("GsiHash2");
            Assert.AreEqual("CustomGsiHash2", gsiHash2Property.AttributeName);

            var gsiRangeProperty = config.BaseTypeStorageConfig.GetPropertyStorage("GsiRange");
            Assert.AreEqual("CustomGsiRange", gsiRangeProperty.AttributeName);

            var gsiRange2Property = config.BaseTypeStorageConfig.GetPropertyStorage("GsiRange2");
            Assert.AreEqual("CustomGsiRange2", gsiRange2Property.AttributeName);

            var gsi=config.GetGSIConfig("GSI1");
            Assert.IsNotNull(gsi);
        }
    }
}