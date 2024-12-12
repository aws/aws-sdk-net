using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.DocumentModel;
using System.IO;
using Amazon.DynamoDBv2.DataModel;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : IClassFixture<DynamoDBTestsFixture>
    {
        [Fact]
        [Trait(CategoryAttribute, "DynamoDB")]
        public async Task TestContext()
        {
            // It is a known bug that this test currently fails due to an AOT-compilation
            // issue, on iOS using mono2x.
            foreach (var conversion in new DynamoDBEntryConversion [] { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                SharedTestFixture.TableCache.Clear();

                // Cleanup existing data
                await SharedTestFixture.CleanupTables();
                // Recreate context
                SharedTestFixture.CreateContext(conversion);

                await TestEnumHashKeyObjects();

                await TestEmptyCollections(conversion);

                TestContextConversions();
                await TestUnsupportedTypes();
                TestEnums(conversion);

                await TestHashObjects();
                await TestHashRangeObjects();
                await TestOtherContextOperations();
                await TestBatchOperations();
            }
        }

        private async Task TestUnsupportedTypes()
        {
            InvalidOperationException exception;
            // Verify that saving objects with invalid properties result in exceptions
            var employee2 = new Employee2
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            exception = await Assert.ThrowsAsync<InvalidOperationException>(() => SharedTestFixture.Context.SaveAsync(employee2));
            Assert.Equal("Type System.TimeSpan is unsupported, it cannot be instantiated", exception.Message);
            var employee3 = new Employee3
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            exception = await Assert.ThrowsAsync<InvalidOperationException>(() => SharedTestFixture.Context.SaveAsync(employee3));
            Assert.Equal("Type Amazon.DNXCore.IntegrationTests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members", exception.Message);

            // Verify that objects that are invalid result in exceptions
            exception = await Assert.ThrowsAsync<InvalidOperationException>(() => SharedTestFixture.Context.ScanAsync<TimeSpan>(new List<ScanCondition>()).GetNextSetAsync());
            Assert.Equal("Type System.TimeSpan is unsupported, it cannot be instantiated", exception.Message);

            exception = await Assert.ThrowsAsync<InvalidOperationException>(() => SharedTestFixture.Context.ScanAsync<EmptyType>(new List<ScanCondition>()).GetNextSetAsync());
            Assert.Equal("Type Amazon.DNXCore.IntegrationTests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members", exception.Message);
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
                var docV1 = SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
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
                    contextV1.SaveAsync(product);
                    contextV1.SaveAsync(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
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
                Assert.Throws<InvalidOperationException>(() => SharedTestFixture.Context.ToDocument(product));
                Assert.Throws<InvalidOperationException>(() => SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                Assert.Throws<InvalidOperationException>(() => SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 }));
                
                // Remove circular dependence
                product.CompanyInfo.MostPopularProduct = new Product
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };

                var docV1 = SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            // Introduce circular reference in a Document and try to deserialize
            {
                // Normal serialization
                var docV1 = SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var docV2 = SharedTestFixture.Context.ToDocument(product, new DynamoDBOperationConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);

                // Add circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV2;
                Assert.Throws<InvalidOperationException>(() => SharedTestFixture.Context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 }));
                Assert.Throws<InvalidOperationException>(() => SharedTestFixture.Context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 }));

                // Remove circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = null;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;                
                var prod1 = SharedTestFixture.Context.FromDocument<Product>(docV1, new DynamoDBOperationConfig { Conversion = conversionV1 });
                var prod2 = SharedTestFixture.Context.FromDocument<Product>(docV2, new DynamoDBOperationConfig { Conversion = conversionV2 });
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
            var doc1 = SharedTestFixture.Context.ToDocument(product);
            var product2 = SharedTestFixture.Context.FromDocument<Product>(doc1);
            Assert.Equal(product.CurrentStatus, product2.CurrentStatus);
            Assert.Equal(product.FormerStatus, product2.FormerStatus);
            Assert.Equal(product.Supports, product2.Supports);

            // try changing underlying enum data to strings
            var doc2 = SharedTestFixture.Context.ToDocument(product);
            doc2["CurrentStatus"] = product.CurrentStatus.ToString();
            doc2["FormerStatus"] = product.FormerStatus.ToString();
            doc2["Supports"] = product.Supports.ToString();
            doc2 = doc2.ForceConversion(conversion);
            var product3 = SharedTestFixture.Context.FromDocument<Product>(doc2);
            Assert.Equal(product.CurrentStatus, product3.CurrentStatus);
            Assert.Equal(product.FormerStatus, product3.FormerStatus);
            Assert.Equal(product.Supports, product3.Supports);
        }

        private static void VerifyConversions(Document docV1, Document docV2)
        {
            Assert.Equal(1, docV1["Id"].AsInt());
            Assert.Equal("CloudSpotter", docV1["Product"].AsString());
            Assert.NotNull(docV1["Components"].AsPrimitiveList());
            Assert.NotNull(docV1["IsPublic"].AsPrimitive());
            Assert.NotNull(docV1["Tags"].AsPrimitiveList());
            Assert.NotNull(docV1["CompanyInfo"] as Document);
            Assert.NotNull(docV1["KeySizes"].AsPrimitiveList());

            Assert.Equal(1, docV2["Id"].AsInt());
            Assert.Equal("CloudSpotter", docV2["Product"].AsString());
            Assert.Null(docV2["Components"].AsPrimitiveList());
            Assert.NotNull(docV2["Components"].AsDynamoDBList());
            Assert.Null(docV2["IsPublic"].AsPrimitive());
            Assert.NotNull(docV2["IsPublic"].AsDynamoDBBool());
            Assert.NotNull(docV2["Tags"].AsPrimitiveList());
            Assert.NotNull(docV2["CompanyInfo"] as Document);
            Assert.NotNull(docV2["KeySizes"].AsPrimitiveList());
        }

        private async Task TestEmptyCollections(DynamoDBEntryConversion conversion)
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

            await SharedTestFixture.Context.SaveAsync(product);

            // Load and test the item
            var retrieved = await SharedTestFixture.Context.LoadAsync(product);
            if (!isV1)
            {
                Assert.NotNull(retrieved.Components);
                Assert.Empty(retrieved.Components);
            }
            Assert.NotNull(retrieved.Map);
            Assert.Empty(retrieved.Map);
        }
        private async Task TestEnumHashKeyObjects()
        {
            // Create and save item
            EnumProduct1 product1 = new EnumProduct1
            {
                Id = Status.Upcoming,
                Name = "CloudSpotter"
            };
            await SharedTestFixture.Context.SaveAsync(product1);

            EnumProduct2 product2 = new EnumProduct2
            {
                Id = Status.Removed,
                Name = "CloudSpotter"
            };
            await SharedTestFixture.Context.SaveAsync(product2);

            var rt1 = await SharedTestFixture.Context.LoadAsync(product1);
            Assert.Equal(product1.Id, rt1.Id);
            Assert.Equal(product1.IdAsInt, rt1.IdAsInt);

            var rt2 = await SharedTestFixture.Context.LoadAsync(product2);
            Assert.Equal(product2.Id, rt2.Id);

            await SharedTestFixture.Context.DeleteAsync(product1);
            await SharedTestFixture.Context.DeleteAsync(product2);
        }
        private async Task TestHashObjects()
        {
            string bucketName = "aws-sdk-net-s3link-" + DateTime.UtcNow.Ticks;
            var s3Client = new Amazon.S3.AmazonS3Client(Amazon.RegionEndpoint.USEast1);
            await s3Client.PutBucketAsync(bucketName);
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

                product.FullProductDescription = S3Link.Create(SharedTestFixture.Context, bucketName, "my-product", Amazon.RegionEndpoint.USEast1);
                await product.FullProductDescription.UploadStreamAsync(new MemoryStream(UTF8Encoding.UTF8.GetBytes("Lots of data")));
                
                await SharedTestFixture.Context.SaveAsync(product);

                // Test conversion
                var doc = SharedTestFixture.Context.ToDocument(product);
                Assert.NotNull(doc["Tags"].AsPrimitiveList());
                //if (DynamoDBEntryConversion.Schema == DynamoDBEntryConversion.ConversionSchema.V1)
                //    Assert.NotNull(doc["Components"].AsPrimitiveList());
                //else
                //    Assert.NotNull(doc["Components"].AsDynamoDBList());
                Assert.True(
                    doc["Components"].AsPrimitiveList() != null ||
                    doc["Components"].AsDynamoDBList() != null);
                Assert.NotNull(doc["CompanyInfo"].AsDocument());
                Assert.NotNull(doc["Supports"]);

                // Load item
                Product retrieved = await SharedTestFixture.Context.LoadAsync<Product>(1);
                Assert.Equal(product.Id, retrieved.Id);
                Assert.Equal(product.TagSet.Count, retrieved.TagSet.Count);
                Assert.Equal(product.Components.Count, retrieved.Components.Count);
                Assert.Null(retrieved.InternalId);
                Assert.Equal(product.CurrentStatus, retrieved.CurrentStatus);
                Assert.Equal(product.FormerStatus, retrieved.FormerStatus);
                Assert.Equal(product.Supports, retrieved.Supports);
                Assert.Equal(product.PreviousSupport, retrieved.PreviousSupport);
                Assert.Equal(product.IsPublic, retrieved.IsPublic);
                Assert.Equal(product.Rating, retrieved.Rating);
                Assert.Equal(product.KeySizes.Count, retrieved.KeySizes.Count);
                Assert.NotNull(retrieved.CompanyInfo);
                Assert.Equal(product.CompanyInfo.Name, retrieved.CompanyInfo.Name);
                Assert.Equal(product.CompanyInfo.Founded.ToUniversalTime(), retrieved.CompanyInfo.Founded);
                Assert.NotEqual(product.CompanyInfo.Revenue, retrieved.CompanyInfo.Revenue);
                Assert.Equal(product.CompanyInfo.AllProducts.Count, retrieved.CompanyInfo.AllProducts.Count);
                Assert.Equal(product.CompanyInfo.AllProducts[0].Id, retrieved.CompanyInfo.AllProducts[0].Id);
                Assert.Equal(product.CompanyInfo.AllProducts[1].Id, retrieved.CompanyInfo.AllProducts[1].Id);
                Assert.Equal(product.Map.Count, retrieved.Map.Count);
                Assert.Equal(product.CompanyInfo.CompetitorProducts.Count, retrieved.CompanyInfo.CompetitorProducts.Count);

                var productCloudsAreOkay = product.CompanyInfo.CompetitorProducts["CloudsAreOK"];
                var retrievedCloudsAreOkay = retrieved.CompanyInfo.CompetitorProducts["CloudsAreOK"];
                Assert.NotNull(productCloudsAreOkay);
                Assert.NotNull(retrievedCloudsAreOkay);
                Assert.Equal(productCloudsAreOkay.Count, retrievedCloudsAreOkay.Count);

                var productCloudsAreBetter = product.CompanyInfo.CompetitorProducts["CloudsAreBetter"];
                var retrievedCloudsAreBetter = product.CompanyInfo.CompetitorProducts["CloudsAreBetter"];
                Assert.NotNull(productCloudsAreBetter);
                Assert.NotNull(retrievedCloudsAreBetter);
                Assert.Equal(productCloudsAreBetter.Count, retrievedCloudsAreBetter.Count);

                Assert.NotNull(retrieved.FullProductDescription);
                /*using(var stream = retrieved.FullProductDescription.OpenStream())
                using(var reader = new StreamReader(stream))
                {
                    Assert.Equal("Lots of data", reader.ReadToEnd());
                }*/


                // Try saving circularly-referencing object
                product.CompanyInfo.AllProducts.Add(product);
                await Assert.ThrowsAsync<InvalidOperationException>(() => SharedTestFixture.Context.SaveAsync(product));
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
                await SharedTestFixture.Context.SaveAsync(product);

                // Load new item
                retrieved = await SharedTestFixture.Context.LoadAsync<Product>(product);
                Assert.Equal(product.Id, retrieved.Id);
                Assert.Null(retrieved.TagSet);
                Assert.Null(retrieved.Components);
                Assert.Null(retrieved.InternalId);
                Assert.Equal(product.CurrentStatus, retrieved.CurrentStatus);
                Assert.Equal(product.IsPublic, retrieved.IsPublic);
                Assert.Equal(product.AlwaysN, retrieved.AlwaysN);
                Assert.Equal(product.Rating, retrieved.Rating);
                Assert.Null(retrieved.KeySizes);
            
                // Enumerate all products and save their Ids
                List<int> productIds = new List<int>();
                IEnumerable<Product> products = await SharedTestFixture.Context.ScanAsync<Product>(new List<ScanCondition>()).GetNextSetAsync();
                foreach(var p in products)
                {
                    productIds.Add(p.Id);
                }
                Assert.Equal(2, productIds.Count);

                // Load first product
                var firstId = productIds[0];
                product = await SharedTestFixture.Context.LoadAsync<Product>(firstId);
                Assert.NotNull(product);
                Assert.Equal(firstId, product.Id);

                // Query GlobalIndex
                products = await SharedTestFixture.Context.QueryAsync<Product>(
                    product.CompanyName,            // Hash-key for the index is Company
                    QueryOperator.GreaterThan,      // Range-key for the index is Price, so the
                    new object[] { 90 },            // condition is against a numerical value
                    new DynamoDBOperationConfig     // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                    }).GetNextSetAsync();
                Assert.Equal(2, products.Count());

                // Query GlobalIndex with an additional non-key condition
                products = await SharedTestFixture.Context.QueryAsync<Product>(
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
                    }).GetNextSetAsync();
                Assert.Single(products);

                // Delete first product
                await SharedTestFixture.Context.DeleteAsync<Product>(firstId);
                product = await SharedTestFixture.Context.LoadAsync<Product>(product.Id);
                Assert.Null(product);

                // Scan the table
                products = await SharedTestFixture.Context.ScanAsync<Product>(new List<ScanCondition>()).GetNextSetAsync();
                Assert.Single(products);

                // Scan the table with consistent read
                products = await SharedTestFixture.Context.ScanAsync<Product>(
                    new ScanCondition[] { },
                    new DynamoDBOperationConfig { ConsistentRead = true }).GetNextSetAsync();
                Assert.Single(products);

                // Test a versioned product
                VersionedProduct vp = new VersionedProduct
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };
                await SharedTestFixture.Context.SaveAsync(vp);

                // Update and save
                vp.Price++;
                await SharedTestFixture.Context.SaveAsync(vp);

                // Alter the version and try to save
                vp.Version = 0;
                await Assert.ThrowsAsync<ConditionalCheckFailedException>(() => SharedTestFixture.Context.SaveAsync(vp));

                // Load and save
                vp = await SharedTestFixture.Context.LoadAsync(vp);
                await SharedTestFixture.Context.SaveAsync(vp);
            }
            finally
            {
                await UtilityMethods.DeleteBucketWithObjectsAsync(s3Client, bucketName);
            }
        }

        private async Task TestHashRangeObjects()
        {
            // Create and save item
            Employee employee = new Employee
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
            await SharedTestFixture.Context.SaveAsync(employee);

            // Load item
            Employee retrieved = await SharedTestFixture.Context.LoadAsync(employee);
            Assert.Equal(employee.Name, retrieved.Name);
            Assert.Equal(employee.Age, retrieved.Age);
            Assert.Equal(employee.CompanyName, retrieved.CompanyName);
            Assert.Equal(employee.CurrentStatus, retrieved.CurrentStatus);

            // Create and save new item
            employee.Name = "Chuck";
            employee.Age = 30;
            employee.CurrentStatus = Status.Inactive;
            employee.Aliases = new List<string> { "Charles" };
            employee.Data = Encoding.UTF8.GetBytes("Binary data");
            employee.Score = 94;
            await SharedTestFixture.Context.SaveAsync(employee);

            // Load item
            retrieved = await SharedTestFixture.Context.LoadAsync(employee);
            Assert.Equal(employee.Name, retrieved.Name);
            Assert.Equal(employee.Age, retrieved.Age);
            Assert.Equal(employee.CompanyName, retrieved.CompanyName);
            Assert.Equal(employee.CurrentStatus, retrieved.CurrentStatus);
            Assert.Equal(employee.Data.Length, retrieved.Data.Length);

            // Create more items
            Employee employee2 = new Employee
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
            await SharedTestFixture.Context.SaveAsync(employee2);
            employee2.Age = 24;
            employee2.Score = 101;
            await SharedTestFixture.Context.SaveAsync(employee2);

            retrieved = await SharedTestFixture.Context.LoadAsync<Employee>("Alan", 31);
            Assert.Equal("Alan", retrieved.Name);
            retrieved = await SharedTestFixture.Context.LoadAsync(employee);
            Assert.Equal("Chuck", retrieved.Name);
            retrieved = await SharedTestFixture.Context.LoadAsync(employee2, new DynamoDBOperationConfig { ConsistentRead = true });
            Assert.Equal("Diane", retrieved.Name);
            Assert.Equal(24, retrieved.Age);
            

            // Scan for all items
            var employees = await (SharedTestFixture.Context.ScanAsync<Employee>(new List<ScanCondition>())).GetNextSetAsync();
            Assert.Equal(4, employees.Count);

            // Query for items with Hash-Key = "Diane"
            employees = await SharedTestFixture.Context.QueryAsync<Employee>("Diane").GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query for items with Hash-Key = "Diane" and Range-Key > 30
            employees = await SharedTestFixture.Context.QueryAsync<Employee>("Diane", QueryOperator.GreaterThan, new object[]{30}).GetNextSetAsync();
            Assert.Single(employees);

            // Index Query

            // Query local index for items with Hash-Key = "Diane"
            employees = await SharedTestFixture.Context.QueryAsync<Employee>("Diane", new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await SharedTestFixture.Context.QueryAsync<Employee>("Diane", QueryOperator.Equal, new object[] { "Eva" },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River"
            employees = await SharedTestFixture.Context.QueryAsync<Employee>("Big River", new DynamoDBOperationConfig { IndexName = "GlobalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await SharedTestFixture.Context.QueryAsync<Employee>("Big River",
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                    }
                }).GetNextSetAsync();
            Assert.Single(employees);


            // Index Scan

            // Scan local index for items with Hash-Key = "Diane"
            employees = await SharedTestFixture.Context.ScanAsync<Employee>(
                new List<ScanCondition> { new ScanCondition("Name", ScanOperator.Equal, "Diane") },
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Scan local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await SharedTestFixture.Context.ScanAsync<Employee>(
                new List<ScanCondition>
                {
                    new ScanCondition("Name", ScanOperator.Equal, "Diane"),
                    new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
                },                
                new DynamoDBOperationConfig { IndexName = "LocalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River"
            employees = await SharedTestFixture.Context.ScanAsync<Employee>(
                new List<ScanCondition> { new ScanCondition("CompanyName", ScanOperator.Equal, "Big River") },
                new DynamoDBOperationConfig { IndexName = "GlobalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await SharedTestFixture.Context.ScanAsync<Employee>(
                new List<ScanCondition>
                {
                    new ScanCondition("CompanyName", ScanOperator.Equal, "Big River"),
                    new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                },
                new DynamoDBOperationConfig
                {
                    IndexName = "GlobalIndex"
                }).GetNextSetAsync();
            Assert.Single(employees);
        }

        private async Task TestBatchOperations()
        {
            int itemCount = 10;
            string employeePrefix = "Employee-";
            int employeeAgeStart = 20;
            int productIdStart = 90;
            string productPrefix = "Product-";

            var allEmployees = new List<Employee>();
            var batchWrite1 = SharedTestFixture.Context.CreateBatchWrite<Employee>();
            var batchWrite2 = SharedTestFixture.Context.CreateBatchWrite<Product>();
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
            var multiTableWrite = SharedTestFixture.Context.CreateMultiTableBatchWrite(batchWrite1, batchWrite2);
            await multiTableWrite.ExecuteAsync();

            // Create BatchGets
            var batchGet1 = SharedTestFixture.Context.CreateBatchGet<Product>();
            var batchGet2 = SharedTestFixture.Context.CreateBatchGet<Employee>();
            for (int i = 0; i < itemCount;i++ )
                batchGet1.AddKey(productIdStart + i, productPrefix + i);
            foreach (var employee in allEmployees)
                batchGet2.AddKey(employee);

            // Execute BatchGets together
            await SharedTestFixture.Context.ExecuteBatchGetAsync(batchGet1, batchGet2);

            // Verify items are loaded
            Assert.Equal(itemCount, batchGet1.Results.Count);
            Assert.Equal(itemCount, batchGet2.Results.Count);
        }

        private async Task TestOtherContextOperations()
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

            Document doc = SharedTestFixture.Context.ToDocument(employee1);
            Assert.Equal(employee1.Name, doc["Name"].AsString());
            Assert.Equal(employee1.Data.Length, doc["Data"].AsByteArray().Length);
            // Ignored properties are not propagated to the Document
            Assert.False(doc.ContainsKey("InternalId"));

            Employee roundtrip = SharedTestFixture.Context.FromDocument<Employee>(doc);
            Assert.Equal(employee1.Name, roundtrip.Name);
            Assert.Equal(employee1.Data.Length, roundtrip.Data.Length);
            Assert.Null(roundtrip.InternalId);

            // Recreate the record
            await SharedTestFixture.Context.DeleteAsync(employee1);
            await SharedTestFixture.Context.SaveAsync(employee1);

            // Get record using Table instead of Context
            var table = SharedTestFixture.Context.GetTargetTable<Employee>();
            Document retrieved = await table.GetItemAsync(doc);
            Assert.Equal(employee1.Name, doc["Name"].AsString());
            Assert.Equal(employee1.Data.Length, doc["Data"].AsByteArray().Length);
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
            public string Name { get; set; }
            // Range key
            public int Age { get; set; }

            public string CompanyName { get; set; }
            public int Score { get; set; }
            public string ManagerName { get; set; }
            public byte[] Data { get; set; }
            public Status CurrentStatus { get; set; }
            public List<string> Aliases { get; set; }

            public string InternalId { get; set; }
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

        #endregion
    }
}
