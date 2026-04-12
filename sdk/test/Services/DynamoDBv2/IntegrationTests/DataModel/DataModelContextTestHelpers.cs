using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    internal static class DataModelContextTestHelpers
    {
        internal static readonly TimeSpan Epsilon = TimeSpan.FromSeconds(1);

        internal static void ApproximatelyEqual(DateTime expected, DateTime actual)
        {
            var diff = actual - expected;
            var absDiff = diff.GetAbsolute();
            Assert.True(absDiff < Epsilon, string.Format("Verifying that {0} ~= {1}", expected, actual));
        }

        internal static async Task TestHashRangeObjectsHelper<T>(DynamoDBContext context) where T : Employee, new()
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
            await context.SaveAsync(employee);

            // Load item
            T retrieved = await context.LoadAsync(employee);
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
            await context.SaveAsync(employee);

            // Load item
            retrieved = await context.LoadAsync(employee);
            Assert.Equal(employee.Name, retrieved.Name);
            Assert.Equal(employee.Age, retrieved.Age);
            Assert.Equal(employee.CompanyName, retrieved.CompanyName);
            Assert.Equal(employee.CurrentStatus, retrieved.CurrentStatus);
            Assert.Equal(employee.Data.Length, retrieved.Data.Length);

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
            await context.SaveAsync(employee2);
            employee2.Age = 24;
            employee2.Score = 101;
            await context.SaveAsync(employee2);

            retrieved = await context.LoadAsync<T>("Alan", 31);
            Assert.Equal(retrieved.Name, "Alan");
            retrieved = await context.LoadAsync(employee);
            Assert.Equal(retrieved.Name, "Chuck");
            retrieved = await context.LoadAsync(employee2, new LoadConfig { ConsistentRead = true });
            Assert.Equal(retrieved.Name, "Diane");
            Assert.Equal(retrieved.Age, 24);

            // Scan for all items
            var employees = await context.ScanAsync<T>(new List<ScanCondition>()).GetRemainingAsync();
            Assert.Equal(4, employees.Count);

            // Query for items with Hash-Key = "Diane"
            employees = await context.QueryAsync<T>("Diane").GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query for items with Hash-Key = "Diane" and Range-Key > 30
            employees = await context.QueryAsync<T>("Diane", QueryOperator.GreaterThan, new object[] { 30 }).GetNextSetAsync();
            Assert.Equal(1, employees.Count);

            // Index Query
            // Query local index for items with Hash-Key = "Diane"
            employees = await context.QueryAsync<T>("Diane", new QueryConfig { IndexName = "LocalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await context.QueryAsync<T>(
                "Diane",
                QueryOperator.Equal,
                new object[] { "Eva" },
                new QueryConfig { IndexName = "LocalIndex" }
            ).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // GSI updates are eventually consistent; wait until all 4 employees are indexed before querying.
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                var indexed = await context.ScanAsync<T>(new List<ScanCondition>(), new ScanConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
                return indexed.Count >= 4;
            }, sleepSeconds: 1, maxWaitSeconds: 30);

            // Query global index for item with Hash-Key (Company) = "Big River"
            employees = await context.QueryAsync<T>("Big River", new QueryConfig { IndexName = "GlobalIndex" }).GetNextSetAsync();
            Assert.Equal(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await context.QueryAsync<T>("Big River",
                new QueryConfig
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                    }
                }).GetNextSetAsync();
            Assert.Equal(1, employees.Count);

            // Index Scan
            // Scan local index for items with Hash-Key = "Diane"
            employees = await context.ScanAsync<T>(
                new List<ScanCondition> { new ScanCondition("Name", ScanOperator.Equal, "Diane") },
                new ScanConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Scan local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await context.ScanAsync<T>(
                new List<ScanCondition>
                {
                    new ScanCondition("Name", ScanOperator.Equal, "Diane"),
                    new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
                },
                new ScanConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River"
            employees = await context.ScanAsync<T>(
                new List<ScanCondition> { new ScanCondition("CompanyName", ScanOperator.Equal, "Big River") },
                new ScanConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
            Assert.Equal(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await context.ScanAsync<T>(
                new List<ScanCondition>
                {
                    new ScanCondition("CompanyName", ScanOperator.Equal, "Big River"),
                    new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                },
                new ScanConfig
                {
                    IndexName = "GlobalIndex"
                }).GetRemainingAsync();
            Assert.Equal(1, employees.Count);
        }

        internal static async Task TestEmptyStringsHelper(DynamoDBContext context)
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
                        new Product { Id = 12, Name = string.Empty }
                    },
                },
                Components = new List<string> // SS
                {
                    string.Empty
                }
            };

            await context.SaveAsync(product);
            var savedProduct = await context.LoadAsync<Product>(1);

            Assert.Equal(1, savedProduct.Id);
            Assert.Equal(string.Empty, savedProduct.Map["Position"]);
            Assert.Equal(string.Empty, savedProduct.Components[0]);
            Assert.Equal(string.Empty, savedProduct.CompanyInfo.AllProducts[0].Name);
        }

        internal static async Task TestEnumHashKeyObjectsHelper(DynamoDBContext context)
        {
            // Create and save item
            EnumProduct1 product1 = new EnumProduct1
            {
                Id = Status.Upcoming,
                Name = "CloudSpotter"
            };
            await context.SaveAsync(product1);

            EnumProduct2 product2 = new EnumProduct2
            {
                Id = Status.Removed,
                Name = "CloudSpotter"
            };
            await context.SaveAsync(product2);

            var rt1 = await context.LoadAsync(product1);
            Assert.Equal(product1.Id, rt1.Id);
            Assert.Equal(product1.IdAsInt, rt1.IdAsInt);

            var rt2 = await context.LoadAsync(product2);
            Assert.Equal(product2.Id, rt2.Id);

            await context.DeleteAsync(product1);
            await context.DeleteAsync(product2);
        }

        internal static async Task TestEmptyCollectionsHelper(DynamoDBEntryConversion conversion, DynamoDBContext context)
        {
            // Check if the conversion being used is V1
            // In V1 conversion, lists are stored as sets, which cannot
            // be empty, so for V1 we are not testing empty lists
            var isV1 = conversion == DynamoDBEntryConversion.V1;

            // Create and save item
            Product product = new Product
            {
                Id = 1,
                Map = new Dictionary<string, string>()
            };
            if (!isV1)
                product.Components = new List<string>();

            await context.SaveAsync(product);

            // Load and test the item
            var retrieved = await context.LoadAsync(product);
            if (!isV1)
            {
                Assert.NotNull(retrieved.Components);
                Assert.Equal(0, retrieved.Components.Count);
            }

            Assert.NotNull(retrieved.Map);
            Assert.Equal(0, retrieved.Map.Count);
        }

        internal static void TestEnumsHelper(DynamoDBEntryConversion conversion, DynamoDBContext context)
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
            var doc1 = context.ToDocument(product);
            var product2 = context.FromDocument<Product>(doc1);
            Assert.Equal(product.CurrentStatus, product2.CurrentStatus);
            Assert.Equal(product.FormerStatus, product2.FormerStatus);
            Assert.Equal(product.Supports, product2.Supports);

            // try changing underlying enum data to strings
            var doc2 = context.ToDocument(product);
            doc2["CurrentStatus"] = product.CurrentStatus.ToString();
            doc2["FormerStatus"] = product.FormerStatus.ToString();
            doc2["Supports"] = product.Supports.ToString();
            doc2 = doc2.ForceConversion(conversion);
            var product3 = context.FromDocument<Product>(doc2);
            Assert.Equal(product.CurrentStatus, product3.CurrentStatus);
            Assert.Equal(product.FormerStatus, product3.FormerStatus);
            Assert.Equal(product.Supports, product3.Supports);
        }

        internal static async Task TestHashObjectsHelper(DynamoDBContext context)
        {
            string bucketName = "aws-sdk-net-s3link-" + DateTime.UtcNow.Ticks;
            var s3Client = new Amazon.S3.AmazonS3Client();
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
                        FeaturedProducts = new Product[]
                        {
                            new Product { Id = 14, Name = "CloudDebugger" },
                            new Product { Id = 15, Name = "CloudDebuggerTester" }
                        },
                        FeaturedBrands = new string[] { "Cloud", "Debugger" },
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

                product.FullProductDescription = S3Link.Create(context, bucketName, "my-product", RegionEndpoint.USEast1);
                await product.FullProductDescription.UploadStreamAsync(new MemoryStream(Encoding.UTF8.GetBytes("Lots of data")));
                await context.SaveAsync(product);

                // Test conversion
                var doc = context.ToDocument(product);
                Assert.NotNull(doc["Tags"].AsPrimitiveList());
                Assert.True(doc["Components"].AsPrimitiveList() != null || doc["Components"].AsDynamoDBList() != null);
                Assert.NotNull(doc["CompanyInfo"].AsDocument());
                Assert.NotNull(doc["Supports"]);

                // Load item
                Product retrieved = await context.LoadAsync<Product>(1);
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
                Assert.Equal(product.CompanyInfo.FeaturedProducts.Length, retrieved.CompanyInfo.FeaturedProducts.Length);
                Assert.Equal(product.CompanyInfo.FeaturedProducts[0].Id, retrieved.CompanyInfo.FeaturedProducts[0].Id);
                Assert.Equal(product.CompanyInfo.FeaturedProducts[1].Id, retrieved.CompanyInfo.FeaturedProducts[1].Id);
                Assert.Equal(product.CompanyInfo.FeaturedBrands.Length, retrieved.CompanyInfo.FeaturedBrands.Length);
                Assert.Equal(product.CompanyInfo.FeaturedBrands[0], retrieved.CompanyInfo.FeaturedBrands[0]);
                Assert.Equal(product.CompanyInfo.FeaturedBrands[1], retrieved.CompanyInfo.FeaturedBrands[1]);
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
                using (var stream = await retrieved.FullProductDescription.OpenStreamAsync())
                using (var reader = new StreamReader(stream))
                {
                    Assert.Equal("Lots of data", reader.ReadToEnd());
                }

                // Try saving circularly-referencing object
                product.CompanyInfo.AllProducts.Add(product);
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.SaveAsync(product));
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
                await context.SaveAsync(product);

                // Load new item
                retrieved = await context.LoadAsync(product);
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
                IEnumerable<Product> products = await context.ScanAsync<Product>(new List<ScanCondition>()).GetRemainingAsync();
                foreach (var p in products)
                {
                    productIds.Add(p.Id);
                }
                Assert.Equal(2, productIds.Count);

                // Load first product
                var firstId = productIds[0];
                product = await context.LoadAsync<Product>(firstId);
                Assert.NotNull(product);
                Assert.Equal(firstId, product.Id);

                // GSI updates are eventually consistent; wait until all 2 products are indexed before querying.
                await UtilityMethods.WaitUntilAsync(async () =>
                {
                    var indexed = await context.ScanAsync<Product>(new List<ScanCondition>(), new ScanConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
                    return indexed.Count >= 2;
                }, sleepSeconds: 1, maxWaitSeconds: 30);

                // Query GlobalIndex
                products = await context.QueryAsync<Product>(
                    product.CompanyName, // Hash-key for the index is Company
                    QueryOperator.GreaterThan, // Range-key for the index is Price, so the
                    new object[] { 90 }, // condition is against a numerical value
                    new QueryConfig // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                    })
                    .GetNextSetAsync();
                Assert.Equal(2, products.Count());

                // Query GlobalIndex with an additional non-key condition
                products = await context.QueryAsync<Product>(
                    product.CompanyName, // Hash-key for the index is Company
                    QueryOperator.GreaterThan, // Range-key for the index is Price, so the
                    new object[] { 90 }, // condition is against a numerical value
                    new QueryConfig // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                        QueryFilter = new List<ScanCondition>
                        {
                            new ScanCondition("TagSet", ScanOperator.Contains, "1.0")
                        }
                    })
                    .GetNextSetAsync();
                Assert.Equal(1, products.Count());

                // Delete first product
                await context.DeleteAsync<Product>(firstId);
                product = await context.LoadAsync<Product>(product.Id, new LoadConfig { ConsistentRead = true });
                Assert.Null(product);

                // Scan the table
                products = await context.ScanAsync<Product>(new List<ScanCondition>()).GetRemainingAsync();
                Assert.Equal(1, products.Count());

                // Scan the table with consistent read
                products = await context.ScanAsync<Product>(
                    new ScanCondition[] { },
                    new ScanConfig { ConsistentRead = true }
                ).GetRemainingAsync();
                Assert.Equal(1, products.Count());

                // Test a versioned product
                VersionedProduct vp = new VersionedProduct
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };
                await context.SaveAsync(vp);

                // Update and save
                vp.Price++;
                await context.SaveAsync(vp);

                // Alter the version and try to save
                vp.Version = 0;
                await Assert.ThrowsAsync<ConditionalCheckFailedException>(() => context.SaveAsync(vp));

                // Load and save
                vp = await context.LoadAsync(vp);
                await context.SaveAsync(vp);
            }
            finally
            {
                await Amazon.S3.Util.AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, bucketName);
            }
        }

        internal static async Task TestOtherContextOperationsHelper(DynamoDBContext context)
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

            Document doc = context.ToDocument(employee1);
            Assert.Equal(employee1.Name, doc["Name"].AsString());
            Assert.Equal(employee1.Data.Length, doc["Data"].AsByteArray().Length);
            // Ignored properties are not propagated to the Document
            Assert.False(doc.ContainsKey("InternalId"));

            Employee roundtrip = context.FromDocument<Employee>(doc);
            Assert.Equal(employee1.Name, roundtrip.Name);
            Assert.Equal(employee1.Data.Length, roundtrip.Data.Length);
            Assert.Null(roundtrip.InternalId);

            // Recreate the record
            await context.DeleteAsync(employee1);
            await context.SaveAsync(employee1);

            // Get record using Table instead of context
            var table = context.GetTargetTable<Employee>();
            Document retrieved = await table.GetItemAsync(doc, new GetItemOperationConfig { ConsistentRead = true });
            Assert.Equal(employee1.Name, doc["Name"].AsString());
            Assert.Equal(employee1.Data.Length, doc["Data"].AsByteArray().Length);
        }

        internal static async Task TestBatchOperationsHelper(DynamoDBContext context)
        {
            int itemCount = 10;
            string employeePrefix = UtilityMethods.GenerateName("Employee-");
            int employeeAgeStart = 20;
            int productIdStart = 90;
            string productPrefix = "Product-";

            var allEmployees = new List<Employee>();
            var batchWrite1 = context.CreateBatchWrite<Employee>();
            var batchWrite2 = context.CreateBatchWrite<Product>();
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
            var multiTableWrite = context.CreateMultiTableBatchWrite(batchWrite1, batchWrite2);
            await multiTableWrite.ExecuteAsync();

            // Create BatchGets
            var batchGet1 = context.CreateBatchGet<Product>(new BatchGetConfig { ConsistentRead = true });
            var batchGet2 = context.CreateBatchGet<Employee>(new BatchGetConfig { ConsistentRead = true });
            for (int i = 0; i < itemCount; i++)
                batchGet1.AddKey(productIdStart + i, productPrefix + i);
            foreach (var employee in allEmployees)
                batchGet2.AddKey(employee);

            // Execute BatchGets together
            await context.ExecuteBatchGetAsync(batchGet1, batchGet2);

            // Verify items are loaded
            Assert.Equal(itemCount, batchGet1.Results.Count);
            Assert.Equal(itemCount, batchGet2.Results.Count);
        }

        internal static async Task TestTransactionOperationsHelper<T>(DynamoDBContext context)
            where T : Employee, IVersioned, new()
        {
            // Use unique names so sequential calls (VersionedEmployee then VersionedAnnotatedEmployee)
            // operate on different DynamoDB items and don't conflict within the transaction window.
            var employee1 = new T
            {
                Name = UtilityMethods.GenerateName("Mark-"),
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };
            var employee2 = new T
            {
                Name = UtilityMethods.GenerateName("Helena-"),
                Age = 25,
                Score = 140
            };
            var employee3 = new T
            {
                Name = UtilityMethods.GenerateName("Irving-"),
                Age = 55,
                Score = 100
            };

            {
                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItems(new List<T> { employee1, employee2 });
                transactWrite.AddSaveItem(employee3);
                await transactWrite.ExecuteAsync();

                Assert.NotNull(employee1.Version);
                Assert.NotNull(employee2.Version);
                Assert.NotNull(employee3.Version);
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKeys(new List<T> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(3, transactGet.Results.Count);
                Assert.Equal(employee1.Name, transactGet.Results[0].Name);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Name, transactGet.Results[1].Name);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);
                Assert.Equal(employee3.Name, transactGet.Results[2].Name);
                Assert.Equal(employee3.Version, transactGet.Results[2].Version);
            }

            {
                var originalVersion = employee1.Version.Value;
                employee1.Version = null;
                employee1.Score++;

                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckKey(employee2.Name, employee2.Age, employee2.Version);
                transactWrite.AddDeleteItem(employee3);
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

                Assert.NotNull(ex.CancellationReasons);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal("ConditionalCheckFailed", ex.CancellationReasons[0].Code);
                Assert.Equal("None", ex.CancellationReasons[1].Code);
                Assert.Equal("None", ex.CancellationReasons[2].Code);

                employee1.Version = originalVersion;
                employee1.Score--;
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKey(employee1);
                transactGet.AddKeys(new List<T> { employee2, employee3 });
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(3, transactGet.Results.Count);
                Assert.Equal(employee1.Score, transactGet.Results[0].Score);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);
                Assert.Equal(employee3.Version, transactGet.Results[2].Version);
            }

            {
                employee1.Score++;
                employee2.Version++;

                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckItem(employee2);
                transactWrite.AddDeleteItem(employee3);
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

                Assert.NotNull(ex.CancellationReasons);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal("None", ex.CancellationReasons[0].Code);
                Assert.Equal("ConditionalCheckFailed", ex.CancellationReasons[1].Code);
                Assert.Equal("None", ex.CancellationReasons[2].Code);

                employee1.Score--;
                employee2.Version--;
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKeys(new List<T> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(3, transactGet.Results.Count);
                Assert.Equal(employee1.Score, transactGet.Results[0].Score);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);
                Assert.Equal(employee3.Version, transactGet.Results[2].Version);
            }

            {
                employee1.Score++;
                employee3.Version--;

                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckKey(employee2.Name, employee2.Age, employee2.Version);
                transactWrite.AddDeleteItem(employee3);
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.NotNull(ex.CancellationReasons);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal("None", ex.CancellationReasons[0].Code);
                Assert.Equal("None", ex.CancellationReasons[1].Code);
                Assert.Equal("ConditionalCheckFailed", ex.CancellationReasons[2].Code);

                employee1.Score--;
                employee3.Version++;
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKey(employee1);
                transactGet.AddKeys(new List<T> { employee2, employee3 });
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(3, transactGet.Results.Count);
                Assert.Equal(employee1.Score, transactGet.Results[0].Score);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);
                Assert.Equal(employee3.Version, transactGet.Results[2].Version);
            }

            {
                var originalVersion1 = employee1.Version.Value;
                var originalVersion2 = employee2.Version.Value;
                var originalVersion3 = employee3.Version.Value;
                employee1.Score++;
                employee1.ManagerName = null;

                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckItem(employee2);
                transactWrite.AddDeleteItem(employee3);
                await transactWrite.ExecuteAsync();

                Assert.Equal(originalVersion1 + 1, employee1.Version);
                Assert.Equal(originalVersion2, employee2.Version);
                Assert.Equal(originalVersion3, employee3.Version);
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKeys(new List<T> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(2, transactGet.Results.Count);
                Assert.Equal(employee1.Name, transactGet.Results[0].Name);
                Assert.Equal(employee1.Score, transactGet.Results[0].Score);
                Assert.Null(transactGet.Results[0].ManagerName);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Name, transactGet.Results[1].Name);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);
            }

            {
                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItem(employee1.Name, employee1.Age,
                    new Expression
                    {
                        ExpressionStatement = "SET #score = #score + :score",
                        ExpressionAttributeNames = { ["#score"] = "Score" },
                        ExpressionAttributeValues = { [":score"] = 1 }
                    },
                    new Expression
                    {
                        ExpressionStatement = "#version = :version",
                        ExpressionAttributeNames = { ["#version"] = "Version" },
                        ExpressionAttributeValues = { [":version"] = employee1.Version }
                    });
                transactWrite.AddDeleteKey(employee2.Name, employee2.Age,
                    new Expression
                    {
                        ExpressionStatement = "#version = :version",
                        ExpressionAttributeNames = { ["#version"] = "Version" },
                        ExpressionAttributeValues = { [":version"] = employee2.Version - 1 }
                    });

                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.NotNull(ex.CancellationReasons);
                Assert.Equal(2, ex.CancellationReasons.Count);
                Assert.Equal("None", ex.CancellationReasons[0].Code);
                Assert.Equal("ConditionalCheckFailed", ex.CancellationReasons[1].Code);
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKeys(new List<T> { employee1, employee2 });
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(2, transactGet.Results.Count);
                Assert.Equal(employee1.Name, transactGet.Results[0].Name);
                Assert.Equal(employee1.Score, transactGet.Results[0].Score);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Name, transactGet.Results[1].Name);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);
            }

            {
                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddSaveItem(employee1.Name, employee1.Age,
                    new Expression
                    {
                        ExpressionStatement = "SET #score = #score + :score",
                        ExpressionAttributeNames = { ["#score"] = "Score" },
                        ExpressionAttributeValues = { [":score"] = 1 }
                    },
                    new Expression
                    {
                        ExpressionStatement = "#version = :version",
                        ExpressionAttributeNames = { ["#version"] = "Version" },
                        ExpressionAttributeValues = { [":version"] = employee1.Version }
                    });
                transactWrite.AddSaveItem(employee2.Name, employee2.Age,
                    new Expression
                    {
                        ExpressionStatement = "SET #score = #score + :score",
                        ExpressionAttributeNames = { ["#score"] = "Score" },
                        ExpressionAttributeValues = { [":score"] = 2 }
                    },
                    new Expression
                    {
                        ExpressionStatement = "#version = :version",
                        ExpressionAttributeNames = { ["#version"] = "Version" },
                        ExpressionAttributeValues = { [":version"] = employee2.Version }
                    });

                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKeys(new List<T> { employee1, employee2 });
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(2, transactGet.Results.Count);
                Assert.Equal(employee1.Name, transactGet.Results[0].Name);
                Assert.Equal(employee1.Score + 1, transactGet.Results[0].Score);
                Assert.Equal(employee1.Version, transactGet.Results[0].Version);
                Assert.Equal(employee2.Name, transactGet.Results[1].Name);
                Assert.Equal(employee2.Score + 2, transactGet.Results[1].Score);
                Assert.Equal(employee2.Version, transactGet.Results[1].Version);

                employee1.Score++;
                employee2.Score += 2;
            }

            {
                var transactWrite = context.CreateTransactWrite<T>();
                transactWrite.AddDeleteItem(employee1);
                transactWrite.AddDeleteKey(employee2.Name, employee2.Age);
                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = context.CreateTransactGet<T>();
                transactGet.AddKeys(new List<T> { employee1, employee2, employee3 });
                await transactGet.ExecuteAsync();

                Assert.NotNull(transactGet.Results);
                Assert.Equal(0, transactGet.Results.Count);
            }
        }

        internal static async Task TestMultiTableTransactionsHelper<T>(DynamoDBContext context)
            where T : Employee, IVersioned, new()
        {
            var employee1 = new T
            {
                Name = "Alan",
                Age = 31,
                Score = 120,
                ManagerName = "Barbara"
            };
            var employee2 = new T
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
                var employeeTran = context.CreateTransactWrite<T>();
                employeeTran.AddSaveItems(new[] { employee1, employee2 });
                var productTran = context.CreateTransactWrite<VersionedProduct>();
                productTran.AddSaveItem(product);
                var tran = context.CreateMultiTableTransactWrite(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.NotNull(employee1.Version);
                Assert.NotNull(employee2.Version);
                Assert.NotNull(product.Version);
            }

            {
                var employeeTran = context.CreateTransactGet<T>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product.Id);
                var tran = context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.NotNull(employeeTran.Results);
                Assert.Equal(2, employeeTran.Results.Count);
                Assert.Equal(employee1.Name, employeeTran.Results[0].Name);
                Assert.Equal(employee1.Version, employeeTran.Results[0].Version);
                Assert.Equal(employee2.Name, employeeTran.Results[1].Name);
                Assert.Equal(employee2.Version, employeeTran.Results[1].Version);
                Assert.NotNull(productTran.Results);
                Assert.Equal(1, productTran.Results.Count);
                Assert.Equal(product.Id, productTran.Results[0].Id);
                Assert.Equal(product.Version, productTran.Results[0].Version);
            }

            {
                employee1.Score++;

                var employeeTran = context.CreateTransactWrite<T>();
                employeeTran.AddSaveItem(employee1);
                employeeTran.AddDeleteItem(employee2);
                var productTran = context.CreateTransactWrite<VersionedProduct>();
                productTran.AddVersionCheckKey(product.Id, product.Version.Value + 1);
                var tran = context.CreateMultiTableTransactWrite(employeeTran, productTran);
                var ex = await Assert.ThrowsAsync<TransactionCanceledException>(() => tran.ExecuteAsync());

                Assert.NotNull(ex.CancellationReasons);
                Assert.Equal(3, ex.CancellationReasons.Count);
                Assert.Equal("None", ex.CancellationReasons[0].Code);
                Assert.Equal("None", ex.CancellationReasons[1].Code);
                Assert.Equal("ConditionalCheckFailed", ex.CancellationReasons[2].Code);

                employee1.Score--;
            }

            {
                var employeeTran = context.CreateTransactGet<T>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.NotNull(employeeTran.Results);
                Assert.Equal(2, employeeTran.Results.Count);
                Assert.Equal(employee1.Score, employeeTran.Results[0].Score);
                Assert.Equal(employee1.Version, employeeTran.Results[0].Version);
                Assert.Equal(employee2.Version, employeeTran.Results[1].Version);
                Assert.NotNull(productTran.Results);
                Assert.Equal(1, productTran.Results.Count);
                Assert.Equal(product.Version, productTran.Results[0].Version);
            }

            {
                var originalEmployeeVersion1 = employee1.Version.Value;
                var originalEmployeeVersion2 = employee2.Version.Value;
                var originalProductVersion = product.Version.Value;
                employee1.Score++;
                employee1.ManagerName = null;

                var employeeTran = context.CreateTransactWrite<T>();
                employeeTran.AddSaveItem(employee1);
                employeeTran.AddDeleteItem(employee2);
                var productTran = context.CreateTransactWrite<VersionedProduct>();
                productTran.AddVersionCheckItem(product);
                var tran = context.CreateMultiTableTransactWrite(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.Equal(originalEmployeeVersion1 + 1, employee1.Version);
                Assert.Equal(originalEmployeeVersion2, employee2.Version);
                Assert.Equal(originalProductVersion, product.Version);
            }

            {
                var employeeTran = context.CreateTransactGet<T>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product.Id);
                var tran = context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.NotNull(employeeTran.Results);
                Assert.Equal(1, employeeTran.Results.Count);
                Assert.Equal(employee1.Name, employeeTran.Results[0].Name);
                Assert.Equal(employee1.Score, employeeTran.Results[0].Score);
                Assert.Null(employeeTran.Results[0].ManagerName);
                Assert.Equal(employee1.Version, employeeTran.Results[0].Version);
                Assert.NotNull(productTran.Results);
                Assert.Equal(1, productTran.Results.Count);
                Assert.Equal(product.Id, productTran.Results[0].Id);
                Assert.Equal(product.Version, productTran.Results[0].Version);
            }

            {
                var employeeTran = context.CreateTransactWrite<T>();
                employeeTran.AddDeleteItem(employee1);
                var productTran = context.CreateTransactWrite<VersionedProduct>();
                productTran.AddDeleteKey(product.Id);
                var tran = context.CreateMultiTableTransactWrite(employeeTran, productTran);
                await tran.ExecuteAsync();
            }

            {
                var employeeTran = context.CreateTransactGet<T>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.NotNull(employeeTran.Results);
                Assert.Equal(0, employeeTran.Results.Count);
                Assert.NotNull(productTran.Results);
                Assert.Equal(0, productTran.Results.Count);
            }
        }
    }
}
