﻿using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DataModel;


namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContextWithEmptyStringEnabled()
        {
            // It is a known bug that this test currently fails due to an AOT-compilation
            // issue, on iOS using mono2x.
            foreach (var conversion in new DynamoDBEntryConversion [] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                TableCache.Clear();

                // Cleanup existing data
                CleanupTables();

                // Recreate context
                bool isEmptyStringEnabled = true;
                CreateContext(conversion, isEmptyStringEnabled);

                TestEmptyStringsWithFeatureEnabled();

                TestEnumHashKeyObjects();

                TestEmptyCollections(conversion);

                TestContextConversions();
                TestUnsupportedTypes();
                TestEnums(conversion);

                TestHashObjects();
                TestHashRangeObjects<Employee>();
                TestOtherContextOperations();
                TestBatchOperations();
                TestTransactionOperations();
                TestMultiTableTransactionOperations();

                TestStoreAsEpoch();
            }
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContextWithEmptyStringDisabled()
        {
            // It is a known bug that this test currently fails due to an AOT-compilation
            // issue, on iOS using mono2x.

            TableCache.Clear();

            // Cleanup existing data
            CleanupTables();

            // Recreate context
            bool isEmptyStringEnabled = false;
            CreateContext(DynamoDBEntryConversion.V2, isEmptyStringEnabled);

            TestEmptyStringsWithFeatureDisabled();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info 
        /// supplied only via class attributes.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContext_DisableFetchingTableMetadata_WithFullAttributes()
        {
            TableCache.Clear();
            CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            TestHashRangeObjects<AnnotatedEmployee>();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info 
        /// supplied via a combination of class attributes and the app config.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContext_DisableFetchingTableMetadata_WithPartialAttributes()
        {
            TableCache.Clear();
            CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            TestHashRangeObjects<PartiallyAnnotatedEmployee>();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info 
        /// supplied via attributes on the parent class.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContext_DisableFetchingTableMetadata_WithNonAnnotatedChildClass()
        {
            TableCache.Clear();
            CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            TestHashRangeObjects<EmployeeChild>();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on a Datetime attribute as the hash key that is stored as epoch.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestContext_DisableFetchingTableMetadata_DateTimeAsHashKey()
        {
            TableCache.Clear();
            CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            var employee = new AnnotatedNumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = EpochDate,
                EpochDate2 = EpochDate,
                NonEpochDate1 = EpochDate,
                NonEpochDate2 = EpochDate
            };

            Context.Save(employee);
            var storedEmployee = Context.Load<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            ApproximatelyEqual(EpochDate, storedEmployee.EpochDate2);
            ApproximatelyEqual(EpochDate, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NonEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);
        }


        /// <summary>
        /// Runs the same object-mapper integration tests as <see cref="TestContextWithEmptyStringEnabled"/>,
        /// but using table definitions created by <see cref="TableBuilder"/> instead of the internal <see cref="IAmazonDynamoDB.DescribeTable"/> call
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public void TestWithBuilderTables()
        {
            foreach (var conversion in new DynamoDBEntryConversion[] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                // Cleanup existing data in the tables
                CleanupTables();

                // Clear existing SDK-wide cache
                TableCache.Clear();

                // Redeclare Context, which will start with empty caches
                Context = new DynamoDBContext(Client, new DynamoDBContextConfig
                {
                    IsEmptyStringValueEnabled = true,
                    Conversion = conversion
                });

                Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-HashRangeTable")
                                                    .AddHashKey("Name", DynamoDBEntryType.String)
                                                    .AddRangeKey("Age", DynamoDBEntryType.Numeric)
                                                    .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Score", DynamoDBEntryType.Numeric)
                                                    .AddLocalSecondaryIndex("LocalIndex", "Manager", DynamoDBEntryType.String)
                                                    .Build());

                Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-HashTable")
                                                    .AddHashKey("Id", DynamoDBEntryType.Numeric)
                                                    .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price", DynamoDBEntryType.Numeric)
                                                    .Build());

                Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-NumericHashRangeTable")
                                                    .AddHashKey("CreationTime", DynamoDBEntryType.Numeric)
                                                    .AddRangeKey("Name", DynamoDBEntryType.String)
                                                    .Build());

                TestEmptyStringsWithFeatureEnabled();

                TestEnumHashKeyObjects();

                TestEmptyCollections(conversion);

                TestUnsupportedTypes();
                TestEnums(conversion);

                TestHashObjects();
                TestHashRangeObjects<Employee>();
                TestOtherContextOperations();
                TestBatchOperations();
                TestTransactionOperations();
                TestMultiTableTransactionOperations();

                TestStoreAsEpoch();
            }
        }

        private static void TestEmptyStringsWithFeatureEnabled()
        {
            var product = new Product
            {
                Id = 1,
                Name = string.Empty,
                Map = new Dictionary<string, string> // M
                {
                    {
                        "Position", string.Empty
                    }
                },
                CompanyInfo = new CompanyInfo // L
                {
                    Name = string.Empty,
                    AllProducts = new List<Product>
                    {
                        new Product {Id = 12, Name = string.Empty}
                    },
                },
                Components = new List<string> // SS
                {
                    string.Empty
                }
            };

            Context.Save(product);
            var savedProduct = Context.Load<Product>(1);

            Assert.AreEqual(1, savedProduct.Id);
            Assert.AreEqual(string.Empty, savedProduct.Map["Position"]);
            Assert.AreEqual(string.Empty, savedProduct.Components[0]);
            Assert.AreEqual(string.Empty, savedProduct.CompanyInfo.AllProducts[0].Name);
        }

        private static void TestEmptyStringsWithFeatureDisabled()
        {
            var product1 = new Product
            {
                Id = 1,
                Name = string.Empty, // S
                Components = new List<string> // L
                {
                    string.Empty
                }
            };

            Context.Save(product1);
            var savedProduct1 = Context.Load<Product>(1);

            Assert.AreEqual(1, savedProduct1.Id);
            Assert.AreEqual(0, savedProduct1.Components.Count());
            Assert.AreEqual(null, savedProduct1.Name);


            var product2 = new Product
            {
                Id = 2,
                Components = new List<string> // L
                {
                    string.Empty, "test2"
                }
            };

            Context.Save(product2);
            var savedProduct2 = Context.Load<Product>(2);

            Assert.AreEqual(2, savedProduct2.Id);
            Assert.AreEqual(1, savedProduct2.Components.Count());
            Assert.AreEqual("test2", savedProduct2.Components[0]);


            var product3 = new Product
            {
                Id = 3,
                Components = new List<string> // L
                {
                    string.Empty, "test3", string.Empty
                }
            };

            Context.Save(product3);
            var savedProduct3 = Context.Load<Product>(3);

            Assert.AreEqual(3, savedProduct3.Id);
            Assert.AreEqual(1, savedProduct3.Components.Count());
            Assert.AreEqual("test3", savedProduct3.Components[0]);
        }

        private static void TestUnsupportedTypes()
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee2 = new Employee2
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            AssertExtensions.ExpectException(() => Context.Save(employee2),
                typeof(InvalidOperationException),
                "Type System.TimeSpan is unsupported, it cannot be instantiated");
            var employee3 = new Employee3
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            AssertExtensions.ExpectException(() => Context.Save(employee3),
                typeof(InvalidOperationException),
                "Type AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members");

            // Verify that objects that are invalid result in exceptions
            AssertExtensions.ExpectException(() => Context.Scan<TimeSpan>(),
                typeof(InvalidOperationException),
                "Type System.TimeSpan is unsupported, it cannot be instantiated");
            AssertExtensions.ExpectException(() => Context.Scan<EmptyType>(),
                typeof(InvalidOperationException),
                "Type AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members");
        }

        private void TestContextConversions()
        {
            var conversionV1 = DynamoDBEntryConversion.V1;
            var conversionV2 = DynamoDBEntryConversion.V2;

            Product product = new Product
            {
                Id = 1,
                Name = "CloudSpotter",
                CompanyName = "CloudsAreGrate",
                Price = 1200,
                TagSet = new HashSet<string> { "Prod", "1.0" },
                CurrentStatus = Status.Active,
                FormerStatus = Status.Upcoming,
                Supports = Support.Unix | Support.Windows,
                PreviousSupport = null,
                InternalId = "T1000",
                IsPublic = true,
                AlwaysN = true,
                Rating = 4,
                Components = new List<string> { "Code", "Coffee" },
                KeySizes = new List<byte> { 16, 64, 128 },
                CompanyInfo = new CompanyInfo
                {
                    Name = "MyCloud",
                    Founded = new DateTime(1994, 7, 6),
                    Revenue = 9001
                }
            };

            {
                var docV1 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            {
                using (var contextV1 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                using (var contextV2 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV2 }))
                {
                    var docV1 = contextV1.ToDocument(product);
                    var docV2 = contextV2.ToDocument(product);
                    VerifyConversions(docV1, docV2);
                }
            }

            {
                using (var contextV1 = new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                {
                    contextV1.Save(product);
                    contextV1.Save(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                }
            }

            // Introduce a circular reference and try to serialize
            {
                product.CompanyInfo = new CompanyInfo
                {
                    Name = "MyCloud",
                    Founded = new DateTime(1994, 7, 6),
                    Revenue = 9001,
                    MostPopularProduct = product
                };
                AssertExtensions.ExpectException(() => Context.ToDocument(product), typeof(InvalidOperationException));
                AssertExtensions.ExpectException(() => Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 }), typeof(InvalidOperationException));
                AssertExtensions.ExpectException(() => Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 }), typeof(InvalidOperationException));

                // Remove circular dependence
                product.CompanyInfo.MostPopularProduct = new Product
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };

                var docV1 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            // Introduce circular reference in a Document and try to deserialize
            {
                // Normal serialization
                var docV1 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);

                // Add circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV2;
                AssertExtensions.ExpectException(() => Context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                AssertExtensions.ExpectException(() => Context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 }));

                // Remove circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = null;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;                
                var prod1 = Context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var prod2 = Context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 });
            }
        }

        private void TestEnums(DynamoDBEntryConversion conversion)
        {
            Product product = new Product
            {
                Id = 1,
                Name = "CloudSpotter",
                CompanyName = "CloudsAreGrate",
                Price = 1200,
                TagSet = new HashSet<string> { "Prod", "1.0" },
                CurrentStatus = Status.Active,
                FormerStatus = Status.Upcoming,
                Supports = Support.Unix | Support.Windows,
                PreviousSupport = null,
            };

            // try round-tripping the enums
            var doc1 = Context.ToDocument(product);
            var product2 = Context.FromDocument<Product>(doc1);
            Assert.AreEqual(product.CurrentStatus, product2.CurrentStatus);
            Assert.AreEqual(product.FormerStatus, product2.FormerStatus);
            Assert.AreEqual(product.Supports, product2.Supports);

            // try changing underlying enum data to strings
            var doc2 = Context.ToDocument(product);
            doc2["CurrentStatus"] = product.CurrentStatus.ToString();
            doc2["FormerStatus"] = product.FormerStatus.ToString();
            doc2["Supports"] = product.Supports.ToString();
            doc2 = doc2.ForceConversion(conversion);
            var product3 = Context.FromDocument<Product>(doc2);
            Assert.AreEqual(product.CurrentStatus, product3.CurrentStatus);
            Assert.AreEqual(product.FormerStatus, product3.FormerStatus);
            Assert.AreEqual(product.Supports, product3.Supports);
        }

        private static void VerifyConversions(Document docV1, Document docV2)
        {
            Assert.AreEqual(1, docV1["Id"].AsInt());
            Assert.AreEqual("CloudSpotter", docV1["Product"].AsString());
            Assert.IsNotNull(docV1["Components"].AsPrimitiveList());
            Assert.IsNotNull(docV1["IsPublic"].AsPrimitive());
            Assert.IsNotNull(docV1["Tags"].AsPrimitiveList());
            Assert.IsNotNull(docV1["CompanyInfo"] as Document);
            Assert.IsNotNull(docV1["KeySizes"].AsPrimitiveList());

            Assert.AreEqual(1, docV2["Id"].AsInt());
            Assert.AreEqual("CloudSpotter", docV2["Product"].AsString());
            Assert.IsNull(docV2["Components"].AsPrimitiveList());
            Assert.IsNotNull(docV2["Components"].AsDynamoDBList());
            Assert.IsNull(docV2["IsPublic"].AsPrimitive());
            Assert.IsNotNull(docV2["IsPublic"].AsDynamoDBBool());
            Assert.IsNotNull(docV2["Tags"].AsPrimitiveList());
            Assert.IsNotNull(docV2["CompanyInfo"] as Document);
            Assert.IsNotNull(docV2["KeySizes"].AsPrimitiveList());
        }

        private void TestEmptyCollections(DynamoDBEntryConversion conversion)
        {
            // Check if the conversion being used is V1
            // In V1 conversion, lists are stored as sets, which cannot
            // be empty, so for V1 we are not testing empty lists
            var isV1 = (conversion == DynamoDBEntryConversion.V1);

            // Create and save item
            Product product = new Product
            {
                Id = 1,
                Map = new Dictionary<string, string>()
            };
            if (!isV1)
                product.Components = new List<string>();

            Context.Save(product);

            // Load and test the item
            var retrieved = Context.Load(product);
            if (!isV1)
            {
                Assert.IsNotNull(retrieved.Components);
                Assert.AreEqual(0, retrieved.Components.Count);
            }
            Assert.IsNotNull(retrieved.Map);
            Assert.AreEqual(0, retrieved.Map.Count);
        }
        private void TestEnumHashKeyObjects()
        {
            // Create and save item
            EnumProduct1 product1 = new EnumProduct1
            {
                Id = Status.Upcoming,
                Name = "CloudSpotter"
            };
            Context.Save(product1);

            EnumProduct2 product2 = new EnumProduct2
            {
                Id = Status.Removed,
                Name = "CloudSpotter"
            };
            Context.Save(product2);

            var rt1 = Context.Load(product1);
            Assert.AreEqual(product1.Id, rt1.Id);
            Assert.AreEqual(product1.IdAsInt, rt1.IdAsInt);

            var rt2 = Context.Load(product2);
            Assert.AreEqual(product2.Id, rt2.Id);

            Context.Delete(product1);
            Context.Delete(product2);
        }
        private void TestHashObjects()
        {
            string bucketName = "aws-sdk-net-s3link-" + DateTime.Now.Ticks;
            var s3Client = new Amazon.S3.AmazonS3Client(Amazon.RegionEndpoint.USEast1);
            s3Client.PutBucket(bucketName);
            try
            {
                // Create and save item
                Product product = new Product
                {
                    Id = 1,
                    Name = "CloudSpotter",
                    CompanyName = "CloudsAreGrate",
                    Price = 1200,
                    TagSet = new HashSet<string> { "Prod", "1.0" },
                    CurrentStatus = Status.Active,
                    FormerStatus = Status.Upcoming,
                    Supports = Support.Windows | Support.Abacus,
                    PreviousSupport = null,
                    InternalId = "T1000",
                    IsPublic = true,
                    AlwaysN = true,
                    Rating = 4,
                    Components = new List<string> { "Code", "Coffee" },
                    KeySizes = new List<byte> { 16, 64, 128 },
                    CompanyInfo = new CompanyInfo
                    {
                        Name = "MyCloud",
                        Founded = new DateTime(1994, 7, 6),
                        Revenue = 9001,
                        AllProducts = new List<Product>
                        {
                            new Product { Id = 12, Name = "CloudDebugger" },
                            new Product { Id = 13, Name = "CloudDebuggerTester" }
                        },
                        FeaturedProducts = new Product[]
                        {
                            new Product { Id = 14, Name = "CloudDebugger" },
                            new Product { Id = 15, Name = "CloudDebuggerTester" }
                        },
                        FeaturedBrands = new string[]{ "Cloud", "Debugger" },
                        CompetitorProducts = new Dictionary<string, List<Product>>
                        {
                            {
                                "CloudsAreOK",
                                new List<Product>
                                {
                                    new Product { Id = 90, Name = "CloudSpotter RipOff" },
                                    new Product { Id = 100, Name = "CloudDebugger RipOff" },
                                }
                            },
                            {
                                "CloudsAreBetter",
                                new List<Product>
                                {
                                    new Product { Id = 92, Name = "CloudSpotter RipOff 2" },
                                    new Product { Id = 102, Name = "CloudDebugger RipOff 3" },
                                }
                            },
                        }
                    },
                    Map = new Dictionary<string, string>
                    {
                        { "a", "1" },
                        { "b", "2" }
                    }
                };

                product.FullProductDescription = S3Link.Create(Context, bucketName, "my-product", Amazon.RegionEndpoint.USEast1);
                product.FullProductDescription.UploadStream(new MemoryStream(UTF8Encoding.UTF8.GetBytes("Lots of data")));

                Context.Save(product);

                // Test conversion
                var doc = Context.ToDocument(product);
                Assert.IsNotNull(doc["Tags"].AsPrimitiveList());
                //if (DynamoDBEntryConversion.Schema == DynamoDBEntryConversion.ConversionSchema.V1)
                //    Assert.IsNotNull(doc["Components"].AsPrimitiveList());
                //else
                //    Assert.IsNotNull(doc["Components"].AsDynamoDBList());
                Assert.IsTrue(
                    doc["Components"].AsPrimitiveList() != null ||
                    doc["Components"].AsDynamoDBList() != null);
                Assert.IsNotNull(doc["CompanyInfo"].AsDocument());
                Assert.IsNotNull(doc["Supports"]);

                // Load item
                Product retrieved = Context.Load<Product>(1);
                Assert.AreEqual(product.Id, retrieved.Id);
                Assert.AreEqual(product.TagSet.Count, retrieved.TagSet.Count);
                Assert.AreEqual(product.Components.Count, retrieved.Components.Count);
                Assert.IsNull(retrieved.InternalId);
                Assert.AreEqual(product.CurrentStatus, retrieved.CurrentStatus);
                Assert.AreEqual(product.FormerStatus, retrieved.FormerStatus);
                Assert.AreEqual(product.Supports, retrieved.Supports);
                Assert.AreEqual(product.PreviousSupport, retrieved.PreviousSupport);
                Assert.AreEqual(product.IsPublic, retrieved.IsPublic);
                Assert.AreEqual(product.Rating, retrieved.Rating);
                Assert.AreEqual(product.KeySizes.Count, retrieved.KeySizes.Count);
                Assert.IsNotNull(retrieved.CompanyInfo);
                Assert.AreEqual(product.CompanyInfo.Name, retrieved.CompanyInfo.Name);
                Assert.AreEqual(product.CompanyInfo.Founded, retrieved.CompanyInfo.Founded);
                Assert.AreNotEqual(product.CompanyInfo.Revenue, retrieved.CompanyInfo.Revenue);
                Assert.AreEqual(product.CompanyInfo.AllProducts.Count, retrieved.CompanyInfo.AllProducts.Count);
                Assert.AreEqual(product.CompanyInfo.AllProducts[0].Id, retrieved.CompanyInfo.AllProducts[0].Id);
                Assert.AreEqual(product.CompanyInfo.AllProducts[1].Id, retrieved.CompanyInfo.AllProducts[1].Id);
                Assert.AreEqual(product.CompanyInfo.FeaturedProducts.Length, retrieved.CompanyInfo.FeaturedProducts.Length);
                Assert.AreEqual(product.CompanyInfo.FeaturedProducts[0].Id, retrieved.CompanyInfo.FeaturedProducts[0].Id);
                Assert.AreEqual(product.CompanyInfo.FeaturedProducts[1].Id, retrieved.CompanyInfo.FeaturedProducts[1].Id);
                Assert.AreEqual(product.CompanyInfo.FeaturedBrands.Length, retrieved.CompanyInfo.FeaturedBrands.Length);
                Assert.AreEqual(product.CompanyInfo.FeaturedBrands[0], retrieved.CompanyInfo.FeaturedBrands[0]);
                Assert.AreEqual(product.CompanyInfo.FeaturedBrands[1], retrieved.CompanyInfo.FeaturedBrands[1]);
                Assert.AreEqual(product.Map.Count, retrieved.Map.Count);
                Assert.AreEqual(product.CompanyInfo.CompetitorProducts.Count, retrieved.CompanyInfo.CompetitorProducts.Count);
                
                var productCloudsAreOkay = product.CompanyInfo.CompetitorProducts["CloudsAreOK"];
                var retrievedCloudsAreOkay = retrieved.CompanyInfo.CompetitorProducts["CloudsAreOK"];
                Assert.IsNotNull(productCloudsAreOkay);
                Assert.IsNotNull(retrievedCloudsAreOkay);
                Assert.AreEqual(productCloudsAreOkay.Count, retrievedCloudsAreOkay.Count);

                var productCloudsAreBetter = product.CompanyInfo.CompetitorProducts["CloudsAreBetter"];
                var retrievedCloudsAreBetter = product.CompanyInfo.CompetitorProducts["CloudsAreBetter"];
                Assert.IsNotNull(productCloudsAreBetter);
                Assert.IsNotNull(retrievedCloudsAreBetter);
                Assert.AreEqual(productCloudsAreBetter.Count, retrievedCloudsAreBetter.Count);

                Assert.IsNotNull(retrieved.FullProductDescription);
                using(var stream = retrieved.FullProductDescription.OpenStream())
                using(var reader = new StreamReader(stream))
                {
                    Assert.AreEqual("Lots of data", reader.ReadToEnd());
                }


                // Try saving circularly-referencing object
                product.CompanyInfo.AllProducts.Add(product);
                AssertExtensions.ExpectException(() => Context.Save(product));
                product.CompanyInfo.AllProducts.RemoveAt(2);

                // Create and save new item
                product.Id++;
                product.Price = 94;
                product.TagSet = null;
                product.Components = null;
                product.CurrentStatus = Status.Upcoming;
                product.IsPublic = false;
                product.AlwaysN = false;
                product.Rating = null;
                product.KeySizes = null;
                Context.Save(product);

                // Load new item
                retrieved = Context.Load<Product>(product);
                Assert.AreEqual(product.Id, retrieved.Id);
                Assert.IsNull(retrieved.TagSet);
                Assert.IsNull(retrieved.Components);
                Assert.IsNull(retrieved.InternalId);
                Assert.AreEqual(product.CurrentStatus, retrieved.CurrentStatus);
                Assert.AreEqual(product.IsPublic, retrieved.IsPublic);
                Assert.AreEqual(product.AlwaysN, retrieved.AlwaysN);
                Assert.AreEqual(product.Rating, retrieved.Rating);
                Assert.IsNull(retrieved.KeySizes);
            
                // Enumerate all products and save their Ids
                List<int> productIds = new List<int>();
                IEnumerable<Product> products = Context.Scan<Product>();
                foreach(var p in products)
                {
                    productIds.Add(p.Id);
                }
                Assert.AreEqual(2, productIds.Count);

                // Load first product
                var firstId = productIds[0];
                product = Context.Load<Product>(firstId);
                Assert.IsNotNull(product);
                Assert.AreEqual(firstId, product.Id);

                // Query GlobalIndex
                products = Context.Query<Product>(
                    product.CompanyName,            // Hash-key for the index is Company
                    QueryOperator.GreaterThan,      // Range-key for the index is Price, so the
                    new object[] { 90 },            // condition is against a numerical value
                    new DynamoDBOperationConfig     // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                    });
                Assert.AreEqual(2, products.Count());

                // Query GlobalIndex with an additional non-key condition
                products = Context.Query<Product>(
                    product.CompanyName,            // Hash-key for the index is Company
                    QueryOperator.GreaterThan,      // Range-key for the index is Price, so the
                    new object[] { 90 },            // condition is against a numerical value
                    new DynamoDBOperationConfig     // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                        QueryFilter = new List<ScanCondition> 
                        {
                            new ScanCondition("TagSet", ScanOperator.Contains, "1.0")
                        }
                    });
                Assert.AreEqual(1, products.Count());

                // Delete first product
                Context.Delete<Product>(firstId);
                product = Context.Load<Product>(product.Id);
                Assert.IsNull(product);

                // Scan the table
                products = Context.Scan<Product>();
                Assert.AreEqual(1, products.Count());

                // Scan the table with consistent read
                products = Context.Scan<Product>(
                    new ScanCondition[] { },
                    new DynamoDBOperationConfig { ConsistentRead = true });
                Assert.AreEqual(1, products.Count());

                // Test a versioned product
                VersionedProduct vp = new VersionedProduct
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };
                Context.Save(vp);

                // Update and save
                vp.Price++;
                Context.Save(vp);

                // Alter the version and try to save
                vp.Version = 0;
                AssertExtensions.ExpectException(() => Context.Save(vp));

                // Load and save
                vp = Context.Load(vp);
                Context.Save(vp);
            }
            finally
            {
                Amazon.S3.Util.AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
            }
        }

        private void TestHashRangeObjects<T>() where T : Employee, new()
        {
            // Create and save item
            T employee = new T
            {
                Name = "Alan",
                Age = 31,
                CompanyName = "Big River",
                CurrentStatus = Status.Active,
                Score = 120,
                ManagerName = "Barbara",
                InternalId = "Alan@BigRiver",
                Aliases = new List<string> { "Al", "Steve" },
                Data = Encoding.UTF8.GetBytes("Some binary data"),
            };
            Context.Save(employee);

            // Load item
            T retrieved = Context.Load(employee);
            Assert.AreEqual(employee.Name, retrieved.Name);
            Assert.AreEqual(employee.Age, retrieved.Age);
            Assert.AreEqual(employee.CompanyName, retrieved.CompanyName);
            Assert.AreEqual(employee.CurrentStatus, retrieved.CurrentStatus);

            // Create and save new item
            employee.Name = "Chuck";
            employee.Age = 30;
            employee.CurrentStatus = Status.Inactive;
            employee.Aliases = new List<string> { "Charles" };
            employee.Data = Encoding.UTF8.GetBytes("Binary data");
            employee.Score = 94;
            Context.Save(employee);

            // Load item
            retrieved = Context.Load(employee);
            Assert.AreEqual(employee.Name, retrieved.Name);
            Assert.AreEqual(employee.Age, retrieved.Age);
            Assert.AreEqual(employee.CompanyName, retrieved.CompanyName);
            Assert.AreEqual(employee.CurrentStatus, retrieved.CurrentStatus);
            Assert.AreEqual(employee.Data.Length, retrieved.Data.Length);

            // Create more items
            T employee2 = new T
            {
                Name = "Diane",
                Age = 40,
                CompanyName = "Madeira",
                Score = 140,
                ManagerName = "Eva",
                Data = new byte[] { 1, 2, 3 },
                CurrentStatus = Status.Upcoming,
                InternalId = "Diane@Madeira",
            };
            Context.Save(employee2);
            employee2.Age = 24;
            employee2.Score = 101;
            Context.Save(employee2);

            retrieved = Context.Load<T>("Alan", 31);
            Assert.AreEqual(retrieved.Name, "Alan");
            retrieved = Context.Load(employee);
            Assert.AreEqual(retrieved.Name, "Chuck");
            retrieved = Context.Load(employee2, new DynamoDBOperationConfig { ConsistentRead = true });
            Assert.AreEqual(retrieved.Name, "Diane");
            Assert.AreEqual(retrieved.Age, 24);

            // Scan for all items
            var employees = Context.Scan<T>().ToList();
            Assert.AreEqual(4, employees.Count);

            // Query for items with Hash-Key = "Diane"
            employees = Context.Query<T>("Diane").ToList();
            Assert.AreEqual(2, employees.Count);

            // Query for items with Hash-Key = "Diane" and Range-Key > 30
            employees = Context.Query<T>("Diane", QueryOperator.GreaterThan, 30).ToList();
            Assert.AreEqual(1, employees.Count);

            
            // Index Query

            // Query local index for items with Hash-Key = "Diane"
            employees = Context.Query<T>("Diane", new DynamoDBOperationConfig { IndexName = "LocalIndex" }).ToList();
            Assert.AreEqual(2, employees.Count);

            // Query local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = Context.Query<T>("Diane", QueryOperator.Equal, new object[] { "Eva" },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).ToList();
            Assert.AreEqual(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River"
            employees = Context.Query<T>("Big River", new DynamoDBOperationConfig { IndexName = "GlobalIndex" }).ToList();
            Assert.AreEqual(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = Context.Query<T>("Big River",
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                    }
                }).ToList();
            Assert.AreEqual(1, employees.Count);


            // Index Scan

            // Scan local index for items with Hash-Key = "Diane"
            employees = Context.Scan<T>(
                new List<ScanCondition> { new ScanCondition("Name", ScanOperator.Equal, "Diane") },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).ToList();
            Assert.AreEqual(2, employees.Count);

            // Scan local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = Context.Scan<T>(
                new List<ScanCondition>
                {
                    new ScanCondition("Name", ScanOperator.Equal, "Diane"),
                    new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
                },                
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).ToList();
            Assert.AreEqual(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River"
            employees = Context.Scan<T>(
                new List<ScanCondition> { new ScanCondition("CompanyName", ScanOperator.Equal, "Big River") },
                new DynamoDBOperationConfig { IndexName = "GlobalIndex" }).ToList();
            Assert.AreEqual(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = Context.Scan<T>(
                new List<ScanCondition>
                {
                    new ScanCondition("CompanyName", ScanOperator.Equal, "Big River"),
                    new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                },
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex"
                }).ToList();
            Assert.AreEqual(1, employees.Count);

        }

        private void TestBatchOperations()
        {
            int itemCount = 10;
            string employeePrefix = "Employee-";
            int employeeAgeStart = 20;
            int productIdStart = 90;
            string productPrefix = "Product-";

            var allEmployees = new List<Employee>();
            var batchWrite1 = Context.CreateBatchWrite<Employee>();
            var batchWrite2 = Context.CreateBatchWrite<Product>();
            for (int i = 0; i < itemCount; i++)
            {
                var employee = new Employee
                {
                    Name = employeePrefix + i,
                    Age = employeeAgeStart + i,
                    CompanyName = "Big River",
                    CurrentStatus = i % 2 == 0 ? Status.Active : Status.Inactive,
                    Score = 90 + i,
                    ManagerName = "Barbara",
                    InternalId = i + "@BigRiver",
                    Data = Encoding.UTF8.GetBytes(new string('@', i + 5))
                };
                allEmployees.Add(employee);
                batchWrite2.AddPutItem(new Product
                {
                    Id = productIdStart + i,
                    Name = productPrefix + i
                });
            }
            batchWrite1.AddPutItems(allEmployees);
            
            // Write both batches at once
            var multiTableWrite = Context.CreateMultiTableBatchWrite(batchWrite1, batchWrite2);
            multiTableWrite.Execute();

            // Create BatchGets
            var batchGet1 = Context.CreateBatchGet<Product>();
            var batchGet2 = Context.CreateBatchGet<Employee>();
            for (int i = 0; i < itemCount;i++ )
                batchGet1.AddKey(productIdStart + i, productPrefix + i);
            foreach (var employee in allEmployees)
                batchGet2.AddKey(employee);

            // Execute BatchGets together
            Context.ExecuteBatchGet(batchGet1, batchGet2);

            // Verify items are loaded
            Assert.AreEqual(itemCount, batchGet1.Results.Count);
            Assert.AreEqual(itemCount, batchGet2.Results.Count);
        }

        private void TestTransactionOperations()
        {
            var employee1 = new VersionedEmployee
            {
                Name = "Mark",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };
            var employee2 = new VersionedEmployee
            {
                Name = "Helena",
                Age = 25,
                Score = 140
            };
            var employee3 = new VersionedEmployee
            {
                Name = "Irving",
                Age = 55,
                Score = 100
            };

            {
                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddSaveItems(new List<VersionedEmployee> { employee1, employee2 });
                transactWrite.AddSaveItem(employee3);
                transactWrite.Execute();

                Assert.IsNotNull(employee1.Version);
                Assert.IsNotNull(employee2.Version);
                Assert.IsNotNull(employee3.Version);
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                transactGet.Execute();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.AreEqual(employee1.Name, transactGet.Results[0].Name);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Name, transactGet.Results[1].Name);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);
                Assert.AreEqual(employee3.Name, transactGet.Results[2].Name);
                Assert.AreEqual(employee3.Version, transactGet.Results[2].Version);
            }

            {
                var originalVersion = employee1.Version.Value;
                employee1.Version = null;
                employee1.Score++;

                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckKey(employee2.Name, employee2.Age, employee2.Version);
                transactWrite.AddDeleteItem(employee3);
                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual("None", ex.CancellationReasons[2].Code);

                employee1.Version = originalVersion;
                employee1.Score--;
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKey(employee1);
                transactGet.AddKeys(new List<VersionedEmployee> { employee2, employee3 });
                transactGet.Execute();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.AreEqual(employee1.Score, transactGet.Results[0].Score);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);
                Assert.AreEqual(employee3.Version, transactGet.Results[2].Version);
            }

            {
                employee1.Score++;
                employee2.Version++;

                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckItem(employee2);
                transactWrite.AddDeleteItem(employee3);
                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[1].Code);
                Assert.AreEqual("None", ex.CancellationReasons[2].Code);

                employee1.Score--;
                employee2.Version--;
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                transactGet.Execute();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.AreEqual(employee1.Score, transactGet.Results[0].Score);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);
                Assert.AreEqual(employee3.Version, transactGet.Results[2].Version);
            }

            {
                employee1.Score++;
                employee3.Version--;

                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckKey(employee2.Name, employee2.Age, employee2.Version);
                transactWrite.AddDeleteItem(employee3);
                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => transactWrite.Execute());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[2].Code);

                employee1.Score--;
                employee3.Version++;
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKey(employee1);
                transactGet.AddKeys(new List<VersionedEmployee> { employee2, employee3 });
                transactGet.Execute();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(3, transactGet.Results.Count);
                Assert.AreEqual(employee1.Score, transactGet.Results[0].Score);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);
                Assert.AreEqual(employee3.Version, transactGet.Results[2].Version);
            }

            {
                var originalVersion1 = employee1.Version.Value;
                var originalVersion2 = employee2.Version.Value;
                var originalVersion3 = employee3.Version.Value;
                employee1.Score++;
                employee1.ManagerName = null;

                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckItem(employee2);
                transactWrite.AddDeleteItem(employee3);
                transactWrite.Execute();

                Assert.AreEqual(originalVersion1 + 1, employee1.Version);
                Assert.AreEqual(originalVersion2, employee2.Version);
                Assert.AreEqual(originalVersion3, employee3.Version);
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                transactGet.Execute();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(2, transactGet.Results.Count);
                Assert.AreEqual(employee1.Name, transactGet.Results[0].Name);
                Assert.AreEqual(employee1.Score, transactGet.Results[0].Score);
                Assert.IsNull(transactGet.Results[0].ManagerName);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Name, transactGet.Results[1].Name);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);
            }

            {
                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddDeleteItem(employee1);
                transactWrite.AddDeleteKey(employee2.Name, employee2.Age);
                transactWrite.Execute();
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2, employee3 });
                transactGet.Execute();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(0, transactGet.Results.Count);
            }
        }

        private void TestMultiTableTransactionOperations()
        {
            var employee1 = new VersionedEmployee
            {
                Name = "Alan",
                Age = 31,
                Score = 120,
                ManagerName = "Barbara"
            };
            var employee2 = new VersionedEmployee
            {
                Name = "Diane",
                Age = 40,
                Score = 140
            };
            var product = new VersionedProduct
            {
                Id = 1001,
                Name = "CloudSpotter",
                Price = 1200
            };

            {
                var employeeTran = Context.CreateTransactWrite<VersionedEmployee>();
                employeeTran.AddSaveItems(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddSaveItem(product);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                tran.Execute();

                Assert.IsNotNull(employee1.Version);
                Assert.IsNotNull(employee2.Version);
                Assert.IsNotNull(product.Version);
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product.Id);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                tran.Execute();

                Assert.IsNotNull(employeeTran.Results);
                Assert.AreEqual(2, employeeTran.Results.Count);
                Assert.AreEqual(employee1.Name, employeeTran.Results[0].Name);
                Assert.AreEqual(employee1.Version, employeeTran.Results[0].Version);
                Assert.AreEqual(employee2.Name, employeeTran.Results[1].Name);
                Assert.AreEqual(employee2.Version, employeeTran.Results[1].Version);
                Assert.IsNotNull(productTran.Results);
                Assert.AreEqual(1, productTran.Results.Count);
                Assert.AreEqual(product.Id, productTran.Results[0].Id);
                Assert.AreEqual(product.Version, productTran.Results[0].Version);
            }

            {
                employee1.Score++;

                var employeeTran = Context.CreateTransactWrite<VersionedEmployee>();
                employeeTran.AddSaveItem(employee1);
                employeeTran.AddDeleteItem(employee2);
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddVersionCheckKey(product.Id, product.Version.Value + 1);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                var ex = AssertExtensions.ExpectException<TransactionCanceledException>(() => tran.Execute());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[2].Code);

                employee1.Score--;
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                tran.Execute();

                Assert.IsNotNull(employeeTran.Results);
                Assert.AreEqual(2, employeeTran.Results.Count);
                Assert.AreEqual(employee1.Score, employeeTran.Results[0].Score);
                Assert.AreEqual(employee1.Version, employeeTran.Results[0].Version);
                Assert.AreEqual(employee2.Version, employeeTran.Results[1].Version);
                Assert.IsNotNull(productTran.Results);
                Assert.AreEqual(1, productTran.Results.Count);
                Assert.AreEqual(product.Version, productTran.Results[0].Version);
            }

            {
                var originalEmployeeVersion1 = employee1.Version.Value;
                var originalEmployeeVersion2 = employee2.Version.Value;
                var originalProductVersion = product.Version.Value;
                employee1.Score++;
                employee1.ManagerName = null;

                var employeeTran = Context.CreateTransactWrite<VersionedEmployee>();
                employeeTran.AddSaveItem(employee1);
                employeeTran.AddDeleteItem(employee2);
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddVersionCheckItem(product);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                tran.Execute();

                Assert.AreEqual(originalEmployeeVersion1 + 1, employee1.Version);
                Assert.AreEqual(originalEmployeeVersion2, employee2.Version);
                Assert.AreEqual(originalProductVersion, product.Version);
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product.Id);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                tran.Execute();

                Assert.IsNotNull(employeeTran.Results);
                Assert.AreEqual(1, employeeTran.Results.Count);
                Assert.AreEqual(employee1.Name, employeeTran.Results[0].Name);
                Assert.AreEqual(employee1.Score, employeeTran.Results[0].Score);
                Assert.IsNull(employeeTran.Results[0].ManagerName);
                Assert.AreEqual(employee1.Version, employeeTran.Results[0].Version);
                Assert.IsNotNull(productTran.Results);
                Assert.AreEqual(1, productTran.Results.Count);
                Assert.AreEqual(product.Id, productTran.Results[0].Id);
                Assert.AreEqual(product.Version, productTran.Results[0].Version);
            }

            {
                var employeeTran = Context.CreateTransactWrite<VersionedEmployee>();
                employeeTran.AddDeleteItem(employee1);
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddDeleteKey(product.Id);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                tran.Execute();
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                tran.Execute();

                Assert.IsNotNull(employeeTran.Results);
                Assert.AreEqual(0, employeeTran.Results.Count);
                Assert.IsNotNull(productTran.Results);
                Assert.AreEqual(0, productTran.Results.Count);
            }
        }

        private void TestOtherContextOperations()
        {
            Employee employee1 = new Employee
            {
                Name = "Alan",
                Age = 31,
                CompanyName = "Big River",
                CurrentStatus = Status.Active,
                Score = 120,
                ManagerName = "Barbara",
                InternalId = "Alan@BigRiver",
                Aliases = new List<string> { "Al", "Steve" },
                Data = Encoding.UTF8.GetBytes("Some binary data")
            };

            Document doc = Context.ToDocument(employee1);
            Assert.AreEqual(employee1.Name, doc["Name"].AsString());
            Assert.AreEqual(employee1.Data.Length, doc["Data"].AsByteArray().Length);
            // Ignored properties are not propagated to the Document
            Assert.IsFalse(doc.ContainsKey("InternalId"));

            Employee roundtrip = Context.FromDocument<Employee>(doc);
            Assert.AreEqual(employee1.Name, roundtrip.Name);
            Assert.AreEqual(employee1.Data.Length, roundtrip.Data.Length);
            Assert.IsNull(roundtrip.InternalId);

            // Recreate the record
            Context.Delete(employee1);
            Context.Save(employee1);

            // Get record using Table instead of Context
            var table = Context.GetTargetTable<Employee>();
            Document retrieved = table.GetItem(doc);
            Assert.AreEqual(employee1.Name, doc["Name"].AsString());
            Assert.AreEqual(employee1.Data.Length, doc["Data"].AsByteArray().Length);
        }


        #region OPM definitions

        public enum Status : long
        {
            Active =    256,
            Inactive =  1024,
            Upcoming =  9999,
            Obsolete =  -10,
            Removed =   42
        }

        [Flags]
        public enum Support
        {
            Windows =   1 << 0,
            iOS =       1 << 1,
            Unix =      1 << 2,
            Abacus =    1 << 3,
        }

        public class StatusConverter : IPropertyConverter
        {
            public DynamoDBEntry ToEntry(object value)
            {
                Status status = (Status)value;
                return new Primitive(status.ToString());
            }

            public object FromEntry(DynamoDBEntry entry)
            {
                Primitive primitive = entry.AsPrimitive();
                string text = primitive.AsString();
                Status status = (Status)Enum.Parse(typeof(Status), text);
                return status;
            }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class Product
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            [DynamoDBProperty("Product")]
            public string Name { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            public CompanyInfo CompanyInfo { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Price { get; set; }

            [DynamoDBProperty("Tags")]
            public HashSet<string> TagSet { get; set; }

            public MemoryStream Data { get; set; }

            [DynamoDBProperty(Converter = typeof(StatusConverter))]
            public Status CurrentStatus { get; set; }

            public Status FormerStatus { get; set; }

            public Support Supports { get; set; }

            public Support? PreviousSupport { get; set; }

            [DynamoDBIgnore]
            public string InternalId { get; set; }

            public bool IsPublic { get; set; }

            //[DynamoDBProperty(Converter = typeof(BoolAsNConverter))]
            public bool AlwaysN { get; set; }

            public int? Rating { get; set; }

            public List<string> Components { get; set; }

            //[DynamoDBProperty(Converter = typeof(SetPropertyConverter<List<byte>,byte>))]
            [DynamoDBProperty(Converter = typeof(ListToSetPropertyConverter<byte>))]
            public List<byte> KeySizes { get; set; }

            public Dictionary<string, string> Map { get; set; }

            public S3Link FullProductDescription { get; set; }
        }

        public class CompanyInfo
        {
            public string Name { get; set; }
            public DateTime Founded { get; set; }
            public Product MostPopularProduct { get; set; }
            public List<Product> AllProducts { get; set; }
            public Product[] FeaturedProducts { get; set; }
            public string[] FeaturedBrands { get; set; }
            public Dictionary<string, List<Product>> CompetitorProducts { get; set; }

            [DynamoDBIgnore]
            public decimal Revenue { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedProduct : Product
        {
            [DynamoDBVersion]
            public int? Version { get; set; }
        }


        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable,
        /// with the Id field being an Enum, with hidden int conversion
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class EnumProduct1
        {
            [DynamoDBIgnore]
            public Status Id { get; set; }

            [DynamoDBHashKey("Id")]
            public int IdAsInt
            {
                get { return (int)Id; }
                set { Id = (Status)value; }
            }

            [DynamoDBProperty("Product")]
            public string Name { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable,
        /// with the Id field being an Enum
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class EnumProduct2
        {
            public Status Id { get; set; }

            [DynamoDBProperty("Product")]
            public string Name { get; set; }
        }


        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashRangeTable
        /// 
        /// No DynamoDB attributes are defined on the type:
        /// -some attributes are inferred from the table
        /// -some attributes are defined in app.config
        /// </summary>
        public class Employee
        {
            // Hash key
            public virtual string Name { get; set; }
            public string MiddleName { get; set; }
            // Range key
            public virtual int Age { get; set; }

            public virtual string CompanyName { get; set; }
            public virtual int Score { get; set; }
            public virtual string ManagerName { get; set; }
            public byte[] Data { get; set; }
            public Status CurrentStatus { get; set; }
            public List<string> Aliases { get; set; }

            public string InternalId { get; set; }
        }

        /// <summary>
        /// Same structure as <see cref="Employee"/>, but the indices are fully annotated
        /// </summary>
        [DynamoDBTable("HashRangeTable")]
        public class AnnotatedEmployee : Employee
        {
            // Hash key
            [DynamoDBHashKey]
            public override string Name { get; set; }

            // Range key
            [DynamoDBRangeKey]
            public override int Age { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public override string CompanyName { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public override int Score { get; set; }

            [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex", AttributeName = "Manager")]
            public override string ManagerName { get; set; }
        }

        /// <summary>
        /// Same structure as <see cref="AnnotatedEmployee"/>, but it does not have the <see cref="DynamoDBTableAttribute"/> and attribute names overrides.
        /// </summary>
        public class PartiallyAnnotatedEmployee : Employee
        {
            // Hash key
            [DynamoDBHashKey]
            public override string Name { get; set; }

            // Range key
            [DynamoDBRangeKey]
            public override int Age { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex")]
            public override string CompanyName { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public override int Score { get; set; }

            [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex")]
            public override string ManagerName { get; set; }
        }

        /// <summary>
        /// Child class of <see cref="AnnotatedEmployee"/> without any attributes.
        /// </summary>
        public class EmployeeChild : AnnotatedEmployee
        {
        }

        /// <summary>
        /// Class with a property of a type that has no valid constructor
        /// </summary>
        public class Employee2 : Employee
        {
            public TimeSpan TimeWithCompany { get; set; }
        }

        /// <summary>
        /// Class with a property of an empty type
        /// </summary>
        public class Employee3 : Employee
        {
            public EmptyType EmptyProperty { get; set; }
        }

        /// <summary>
        /// Empty type
        /// </summary>
        public class EmptyType
        { }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedEmployee : Employee
        {
            public int? Version { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// Two fields are being stored as epoch seconds, two are not.
        /// </summary>
        public class EpochEmployee : Employee
        {
            [DynamoDBProperty(StoreAsEpoch = true)]
            public virtual DateTime CreationTime { get; set; }

            public DateTime EpochDate2 { get; set; }

            [DynamoDBProperty(StoreAsEpoch = false)]
            public DateTime NonEpochDate1 { get; set; }

            public DateTime NonEpochDate2 { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]NumericHashRangeTable.
        /// </summary>
        [DynamoDBTable("NumericHashRangeTable")]
        public class NumericEpochEmployee : EpochEmployee
        {

        }

        /// <summary>
        /// Same structure as <see cref="NumericEpochEmployee"/>, but the Hash key is annotated
        /// </summary>
        [DynamoDBTable("NumericHashRangeTable")]
        public class AnnotatedNumericEpochEmployee : EpochEmployee
        {
            [DynamoDBHashKey(StoreAsEpoch = true)]
            public override DateTime CreationTime { get; set; }

            [DynamoDBRangeKey]
            public override string Name { get; set; }
        }

        #endregion
    }
}
