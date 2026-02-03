using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient>
    {
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContextWithEmptyStringEnabled()
        {
            // It is a known bug that this test currently fails due to an AOT-compilation
            // issue, on iOS using mono2x.
            foreach (var conversion in new DynamoDBEntryConversion[]
                         { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                TableCache.Clear();

                // Cleanup existing data
                await CleanupTables();

                await TestCompositeHashRangeTable();
                
                // Recreate context
                bool isEmptyStringEnabled = true;
                CreateContext(conversion, isEmptyStringEnabled);

                await TestEmptyStringsWithFeatureEnabled();

                await TestEnumHashKeyObjects();

                await TestEmptyCollections(conversion);

                await TestContextConversions();
                await TestUnsupportedTypes();
                TestEnums(conversion);

                await TestHashObjects();
                await TestHashRangeObjects<Employee>();
                await TestOtherContextOperations();
                await TestBatchOperations();
                await TestTransactionOperations();
                await TestMultiTableTransactionOperations();

                await TestStoreAsEpoch();
            }
        }

        private async Task TestCompositeHashRangeTable()
        {
            var entity1 = new CompositeHashRangeEntity
            {
                Id = 1,
                Status = "active",
                UserName = "alice",
                Timestamp = 1000,
                OrderId = "order-1",
                Region = "us-west-2",
                Category = "electronics",
                Amount = 100,
                Priority = 4
            };
            var entity11 = new CompositeHashRangeEntity
            {
                Id = 1,
                Status = "pending",
                UserName = "alice",
                Timestamp = 1001,
                OrderId = "order-1",
                Region = "us-west-2",
                Category = "electronics",
                Amount = 100,
                Priority = 1
            };
            var entity21 = new CompositeHashRangeEntity
            {
                Id = 21,
                Status = "active",
                UserName = "alice",
                Timestamp = 1002,
                OrderId = "order-1",
                Region = "us-west-1",
                Category = "electronics",
                Amount = 100,
                Priority = 2
            };
            var entity22 = new CompositeHashRangeEntity
            {
                Id = 21,
                Status = "pending",
                UserName = "alice",
                Timestamp = 1003,
                OrderId = "order-1",
                Region = "us-west-2",
                Category = "electronics",
                Amount = 100,
                Priority = 3
            };
            var entity31 = new CompositeHashRangeEntity
            {
                Id = 31,
                Status = "shipped",
                UserName = "bob",
                Timestamp = 1004,
                OrderId = "order-2",
                Region = "us-east-1",
                Category = "books",
                Amount = 150,
                Priority = 1
            };
            var entity32 = new CompositeHashRangeEntity
            {
                Id = 31,
                Status = "delivered",
                UserName = "bob",
                Timestamp = 1005,
                OrderId = "order-2",
                Region = "us-east-1",
                Category = "books",
                Amount = 150,
                Priority = 2
            };
            var entity41 = new CompositeHashRangeEntity
            {
                Id = 41,
                Status = "active",
                UserName = "charlie",
                Timestamp = 1006,
                OrderId = "order-3",
                Region = "us-central",
                Category = "clothing",
                Amount = 75,
                Priority = 3
            };
            var entity42 = new CompositeHashRangeEntity
            {
                Id = 41,
                Status = "completed",
                UserName = "charlie",
                Timestamp = 1007,
                OrderId = "order-3",
                Region = "us-central",
                Category = "clothing",
                Amount = 75,
                Priority = 4
            };

            await Context.SaveAsync(entity1);
            await Context.SaveAsync(entity11);
            await Context.SaveAsync(entity21);
            await Context.SaveAsync(entity22);
            await Context.SaveAsync(entity31);
            await Context.SaveAsync(entity32);
            await Context.SaveAsync(entity41);
            await Context.SaveAsync(entity42);

            // Query GSI1 with single hash key
            var queryConditional1 = QueryConditional.HashKeyEqualTo("UserName", "bob");
            var results1 = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional1, new QueryConfig
            {
                IndexName = "GSI1",
                QueryFilter = new List<ScanCondition>
                {
                    new ScanCondition("OrderId", ScanOperator.Equal, "order-2")
                }
            }).GetNextSetAsync();
            Assert.AreEqual(2, results1.Count);
            Assert.IsTrue(results1.All(r => r.UserName == "bob"));

            // Query GSI1: composite-range behavior — Timestamp > 1000 (should return 1001,1002,1003)
            var queryGsi1Range = QueryConditional.HashKeyEqualTo("UserName", "alice")
                .AndRangeKeyGreaterThan("Timestamp", 1000);
            var gsi1RangeResults = await Context.QueryAsync<CompositeHashRangeEntity>(queryGsi1Range, new QueryConfig { IndexName = "GSI1" }).GetNextSetAsync();
            Assert.AreEqual(3, gsi1RangeResults.Count);
            CollectionAssert.AreEqual(new[] { 1001, 1002, 1003 }, gsi1RangeResults.Select(r => r.Timestamp).ToArray());

            // Query GSI1 with descending order
            var gsi1DescResults = await Context.QueryAsync<CompositeHashRangeEntity>(queryGsi1Range, new QueryConfig { IndexName = "GSI1", BackwardQuery = true }).GetNextSetAsync();
            Assert.AreEqual(3, gsi1DescResults.Count);
            Assert.AreEqual(1003, gsi1DescResults.First().Timestamp);

            // Query GSI2 with all hash keys (UserName + OrderId)
            var queryConditional2 = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("OrderId", "order-2");
            var results2 = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional2,
                new QueryConfig
                {
                    IndexName = "GSI2"
                })
                .GetNextSetAsync();
            Assert.AreEqual(2, results2.Count);
            Assert.IsTrue(results2.All(r => r.UserName == "bob" && r.OrderId == "order-2"));

            // Query GSI2 with all hash keys (UserName + OrderId) and QueryFilter
            var results21 = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional2,
                new QueryConfig
                {
                    IndexName = "GSI2",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("Timestamp", ScanOperator.GreaterThan, 1004)
                    }
                }).GetNextSetAsync();
            Assert.AreEqual(1, results21.Count);
            Assert.IsTrue(results21.All(r => r.UserName == "bob" && r.OrderId == "order-2"));

            // Query GSI2 with all hash keys and first range key
            var queryConditional2Range = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("OrderId", "order-2").AndRangeKeyGreaterThan("Timestamp", 1004);
            var results2Range = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional2Range, new QueryConfig { IndexName = "GSI2" }).GetNextSetAsync();
            Assert.AreEqual(1, results2Range.Count);
            Assert.IsTrue(results2Range.All(r => r.UserName == "bob" && r.OrderId == "order-2" && r.Timestamp > 1004));

            // Query GSI2 with hash keys and Timestamp < 1003 (for alice/order-1 -> should return 1000,1001,1002)
            var queryGsi2Alice = QueryConditional.HashKeyEqualTo("UserName", "alice").AndHashKeyEqualTo("OrderId", "order-1").AndRangeKeyLessThan("Timestamp", 1003);
            var gsi2AliceResults = await Context.QueryAsync<CompositeHashRangeEntity>(queryGsi2Alice, new QueryConfig { IndexName = "GSI2" }).GetNextSetAsync();
            Assert.AreEqual(3, gsi2AliceResults.Count);
            CollectionAssert.AreEqual(new[] { 1000, 1001, 1002 }, gsi2AliceResults.Select(r => r.Timestamp).ToArray());

            // Query GSI3 with all hash keys
            var queryConditional3 = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("Region", "us-east-1");
            var results3 = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional3, new QueryConfig { IndexName = "GSI3" }).GetNextSetAsync();
            Assert.AreEqual(2, results3.Count);
            Assert.IsTrue(results3.All(r => r.UserName == "bob" && r.Region == "us-east-1"));

            // Query GSI3 with all hash keys and first range key (Status equal)
            var queryConditional3Range = QueryConditional.HashKeyEqualTo("UserName", "bob").AndHashKeyEqualTo("Region", "us-east-1").AndRangeKeyEqualTo("Status", "shipped");
            var results3Range = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional3Range, new QueryConfig { IndexName = "GSI3" }).GetNextSetAsync();
            Assert.AreEqual(1, results3Range.Count);
            Assert.IsTrue(results3Range.All(r => r.UserName == "bob" && r.Region == "us-east-1" && r.Status == "shipped"));

            // Query GSI4 with all hash keys
            var queryConditional4 = QueryConditional.HashKeyEqualTo("Id", 41).AndHashKeyEqualTo("UserName", "charlie").AndHashKeyEqualTo("OrderId", "order-3").AndHashKeyEqualTo("Region", "us-central");
            var results4 = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional4, new QueryConfig { IndexName = "GSI4" }).GetNextSetAsync();
            Assert.AreEqual(2, results4.Count);
            Assert.IsTrue(results4.All(r => r.Id == 41 && r.UserName == "charlie" && r.OrderId == "order-3" && r.Region == "us-central"));

            // Query GSI4 with all hash keys and first range key (Status equal)
            var queryConditional4Range = QueryConditional.HashKeyEqualTo("Id", 41).AndHashKeyEqualTo("UserName", "charlie").AndHashKeyEqualTo("OrderId", "order-3")
                .AndHashKeyEqualTo("Region", "us-central").AndRangeKeyEqualTo("Status", "active");
            var results4Range = await Context.QueryAsync<CompositeHashRangeEntity>(queryConditional4Range, new QueryConfig { IndexName = "GSI4" }).GetNextSetAsync();
            Assert.AreEqual(1, results4Range.Count);
            Assert.IsTrue(results4Range.All(r => r.Id == 41 && r.UserName == "charlie" && r.OrderId == "order-3" && r.Region == "us-central" && r.Status == "active"));

            // Additional composite-range check on GSI4: Priority > 2 should return both items for Id=41/charlie/order-3/region
            var queryGsi4Priority = QueryConditional.HashKeyEqualTo("Id", 41)
                .AndHashKeyEqualTo("UserName", "charlie")
                .AndHashKeyEqualTo("OrderId", "order-3")
                .AndHashKeyEqualTo("Region", "us-central")
                .AndRangeKeyEqualTo("Status", "active")
                .AndRangeKeyEqualTo("Category", "clothing")
                .AndRangeKeyGreaterThan("Amount", 200);
            var gsi4PriorityResults = await Context.QueryAsync<CompositeHashRangeEntity>(queryGsi4Priority, new QueryConfig { IndexName = "GSI4" }).GetNextSetAsync();
            Assert.AreEqual(0, gsi4PriorityResults.Count);
        }

        /// <summary>
        /// Tests regression reported in https://github.com/aws/aws-sdk-net/issues/4243 is resolved.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestTransactWrite_SkipVersionCheck()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            var vp = new VersionedProduct
            {
                Id = 1000,
                Name = "TestProduct",
                Price = 100
            };
            await Context.SaveAsync(vp);

            // Load to get initial version
            vp = await Context.LoadAsync<VersionedProduct>(vp.Id);
            Assert.AreEqual(0, vp.Version);

            // Set wrong version - normally would fail with a ConditionalCheck error
            vp.Version = 9999;
            vp.Price = 200;

            // With SkipVersionCheck = true, should succeed
            var transactWrite = Context.CreateTransactWrite<VersionedProduct>(new TransactWriteConfig 
            { 
                SkipVersionCheck = true 
            });
            transactWrite.AddSaveItem(vp);
            await transactWrite.ExecuteAsync();

            // Verify update succeeded
            var updated = await Context.LoadAsync<VersionedProduct>(vp.Id);
            Assert.AreEqual(200, updated.Price);
            Assert.AreEqual(9999, updated.Version);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContextWithEmptyStringDisabled()
        {
            TableCache.Clear();

            // Cleanup existing data
            await CleanupTables();

            // Recreate context
            bool isEmptyStringEnabled = false;
            CreateContext(DynamoDBEntryConversion.V2, isEmptyStringEnabled);

            await TestEmptyStringsWithFeatureDisabled();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info 
        /// supplied only via class attributes.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_DisableFetchingTableMetadata_WithFullAttributes()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            await TestHashRangeObjects<AnnotatedEmployee>();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info 
        /// supplied via a combination of class attributes and the app config.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_DisableFetchingTableMetadata_WithPartialAttributes()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            await TestHashRangeObjects<PartiallyAnnotatedEmployee>();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info 
        /// supplied via attributes on the parent class.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_DisableFetchingTableMetadata_WithNonAnnotatedChildClass()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            await TestHashRangeObjects<EmployeeChild>();
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on a Datetime attribute as the hash key that is stored as epoch.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_DisableFetchingTableMetadata_DateTimeAsHashKey()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            var employee = new AnnotatedNumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = EpochDate,
                EpochDate2 = EpochDate,
                NonEpochDate1 = EpochDate,
                NonEpochDate2 = EpochDate,
                NullableEpochDate1 = null,
                NullableEpochDate2 = EpochDate,
                LongEpochDate1 = LongEpochDate,
                LongEpochDate2 = LongEpochDate.AddDays(12),
                NullableLongEpochDate1 = null,
                NullableLongEpochDate2 = LongEpochDate.AddDays(50)
            };

            await Context.SaveAsync(employee);
            var storedEmployee = await Context.LoadAsync<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            ApproximatelyEqual(EpochDate, storedEmployee.EpochDate2);
            ApproximatelyEqual(EpochDate, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddDays(12), storedEmployee.LongEpochDate2);
            Assert.IsNull(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddDays(50), storedEmployee.NullableLongEpochDate2.Value);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);
        }

        /// <summary>
        /// Tests that disabling fetching table metadata works with a key that has a property converter.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_DisableFetchingTableMetadata_KeyWithPropertyConverter()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            var employee = new PropertyConverterEmployee
            {
                Name = Status.Active,
                CreationTime = EpochDate,
            };

            await Context.SaveAsync(employee);
            var storedEmployee = await Context.LoadAsync<PropertyConverterEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
        }


        /// <summary>
        /// Tests that disabling fetching table metadata works with a key that has a property converter.
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestTransactWrite_AddSaveItem_DocumentTransaction()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            CreateContext(DynamoDBEntryConversion.V2, true, true);

            {
                var hashRangeOnly = new AnnotatedRangeTable
                {
                    Name = "Bob",
                    Age = 10
                };

                var transactWrite = Context.CreateTransactWrite<AnnotatedRangeTable>();
                transactWrite.AddSaveItem(hashRangeOnly);
                await transactWrite.ExecuteAsync();

                var storedHashOnly = await Context.LoadAsync<AnnotatedRangeTable>(hashRangeOnly.Name, hashRangeOnly.Age);
                Assert.IsNotNull(storedHashOnly);
                Assert.AreEqual(hashRangeOnly.Name, storedHashOnly.Name);
            }

            {
                var hashRangeOnly = new IgnoreAnnotatedRangeTable
                {
                    Name = "Bob",
                    Age = 10,
                    IgnoreAttribute = 100
                };

                var transactWrite = Context.CreateTransactWrite<IgnoreAnnotatedRangeTable>();
                transactWrite.AddSaveItem(hashRangeOnly);
                await transactWrite.ExecuteAsync();

                var storedHashOnly = await Context.LoadAsync<IgnoreAnnotatedRangeTable>(hashRangeOnly.Name, hashRangeOnly.Age);
                Assert.IsNotNull(storedHashOnly);
                Assert.AreEqual(hashRangeOnly.Name, storedHashOnly.Name);
                Assert.AreEqual(hashRangeOnly.Age, storedHashOnly.Age);
            }

            {
                var hashRangeOnly = new AnnotatedRangeTable2
                {
                    Name = "Bob",
                    Age = 10,
                    NotAnnotatedAttribute = 100
                };

                var transactWrite = Context.CreateTransactWrite<AnnotatedRangeTable2>();
                transactWrite.AddSaveItem(hashRangeOnly);
                await transactWrite.ExecuteAsync();

                var storedHashOnly = await Context.LoadAsync<AnnotatedRangeTable2>(hashRangeOnly.Name, hashRangeOnly.Age);
                Assert.IsNotNull(storedHashOnly);
                Assert.AreEqual(hashRangeOnly.Name, storedHashOnly.Name);
                Assert.AreEqual(hashRangeOnly.Age, storedHashOnly.Age);
                Assert.AreEqual(hashRangeOnly.NotAnnotatedAttribute, storedHashOnly.NotAnnotatedAttribute);
            }

        }

        /// <summary>
        /// Tests that the DynamoDB operations can retrieve <see cref="DateTime"/> attributes in UTC and local timezone.
        /// </summary>  
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        [DataRow(true)]
        [DataRow(false)]
        public async Task TestContext_RetrieveDateTimeInUtc(bool retrieveDateTimeInUtc)
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
                RetrieveDateTimeInUtc = retrieveDateTimeInUtc
            };
            Context = new DynamoDBContext(Client, config);
            var currTime = DateTime.UtcNow;
            var longEpochTime = new DateTime(2039, 2, 5, 17, 49, 55, DateTimeKind.Utc);
            var longEpochTimeBefore1970 = new DateTime(1969, 12, 30, 23, 59, 59, DateTimeKind.Utc);

            var employee = new AnnotatedNumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = currTime,
                EpochDate2 = currTime,
                NonEpochDate1 = currTime,
                NonEpochDate2 = currTime,
                NullableEpochDate1 = null,
                NullableEpochDate2 = currTime,
                LongEpochDate1 = longEpochTime,
                LongEpochDate2 = longEpochTimeBefore1970,
                NullableLongEpochDate1 = longEpochTime,
                NullableLongEpochDate2 = null
            };

            await Context.SaveAsync(employee);

            //This is a valid use of .ToLocalTime
            var expectedCurrTime = retrieveDateTimeInUtc ? currTime.ToUniversalTime() : currTime.ToLocalTime();
            var expectedLongEpochTime =
                retrieveDateTimeInUtc ? longEpochTime.ToUniversalTime() : longEpochTime.ToLocalTime();
            var expectedLongEpochTimeBefore1970 = retrieveDateTimeInUtc
                ? longEpochTimeBefore1970.ToUniversalTime()
                : longEpochTimeBefore1970.ToLocalTime();

            // Load 
            var storedEmployee = Context.Load<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
            Assert.IsNull(storedEmployee.NullableLongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);

            // Query
            QueryFilter filter = new QueryFilter();
            filter.AddCondition("CreationTime", QueryOperator.Equal, currTime);
            storedEmployee = (await Context.FromQueryAsync<AnnotatedNumericEpochEmployee>(
                new QueryOperationConfig { Filter = filter }
            ).GetNextSetAsync()).First();
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
            Assert.IsNull(storedEmployee.NullableLongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);

            // Scan
            storedEmployee = (await Context.ScanAsync<AnnotatedNumericEpochEmployee>(new List<ScanCondition>()).GetRemainingAsync()).First();
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
            Assert.IsNull(storedEmployee.NullableLongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);
        }

        /// <summary>
        /// Tests that if a custom <see cref="DateTime"/> converter is used, then the <see cref="DynamoDBContextConfig.RetrieveDateTimeInUtc"/> is ignored.
        /// </summary>
        /// <param name="retrieveDateTimeInUtc"></param>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        [DataRow(true)]
        [DataRow(false)]
        public async Task TestContext_CustomDateTimeConverter(bool retrieveDateTimeInUtc)
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
                RetrieveDateTimeInUtc = retrieveDateTimeInUtc
            };
            Context = new DynamoDBContext(Client, config);

            // Add a custom DateTime converter
            Context.ConverterCache.Add(typeof(DateTime), new DateTimeUtcConverter());
            Context.ConverterCache.Add(typeof(DateTime?), new DateTimeUtcConverter());

            var currTime = DateTime.UtcNow;
            var longEpochTime = new DateTime(2039, 2, 5, 17, 49, 55, DateTimeKind.Utc);
            var longEpochTimeBefore1970 = new DateTime(1950, 12, 30, 19, 43, 30, DateTimeKind.Utc);

            var employee = new AnnotatedNumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = currTime,
                EpochDate2 = currTime,
                NonEpochDate1 = currTime,
                NonEpochDate2 = currTime,
                NullableEpochDate1 = null,
                NullableEpochDate2 = currTime,
                LongEpochDate1 = longEpochTime,
                LongEpochDate2 = longEpochTimeBefore1970,
                NullableLongEpochDate1 = longEpochTime,
            };

            await Context.SaveAsync(employee);

            // Since we are adding a custom DateTimeUtcConverter, the expected time will always be in the UTC time zone.
            // regardless of RetrieveDateTimeInUtc value.
            var expectedCurrTime = currTime.ToUniversalTime();
            var expectedLongEpochTime = longEpochTime.ToUniversalTime();
            var expectedLongEpochTimeBefore1970 = longEpochTimeBefore1970.ToUniversalTime();

            // Load 
            var storedEmployee = Context.Load<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
            Assert.IsNull(storedEmployee.NullableLongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);

            // Query
            QueryFilter filter = new QueryFilter();
            filter.AddCondition("CreationTime", QueryOperator.Equal, currTime);
            storedEmployee = (await Context.FromQueryAsync<AnnotatedNumericEpochEmployee>(
                new QueryOperationConfig { Filter = filter }
            ).GetNextSetAsync()).First();
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
            Assert.IsNull(storedEmployee.NullableLongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);

            // Scan
            storedEmployee = (await Context.ScanAsync<AnnotatedNumericEpochEmployee>(new List<ScanCondition>()).GetRemainingAsync()).First();
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            Assert.IsNull(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
            Assert.IsNull(storedEmployee.NullableLongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);
        }

        /// <summary>
        /// Tests that the DynamoDB operations can retrieve <see cref="DateTime"/> attributes in UTC and local timezone using the <see cref="DynamoDBOperationConfig"/>
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        [DataRow(true)]
        [DataRow(false)]
        public async Task TestContext_RetrieveDateTimeInUtc_OperationConfig(bool retrieveDateTimeInUtc)
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();
            Context = new DynamoDBContext(Client,
                new DynamoDBContextConfig { Conversion = DynamoDBEntryConversion.V2 });
            var operationConfig = new DynamoDBOperationConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc };

            var currTime = DateTime.UtcNow;
            var longEpochTime = new DateTime(2039, 7, 23, 2, 3, 4, DateTimeKind.Utc);
            var longEpochTimeBefore1970 = new DateTime(1955, 12, 30, 23, 59, 59, DateTimeKind.Utc);

            var employee = new AnnotatedNumericEpochEmployee
            {
                Name = "Bob",
                Age = 45,
                CreationTime = currTime,
                EpochDate2 = currTime,
                NonEpochDate1 = currTime,
                NonEpochDate2 = currTime,
                LongEpochDate1 = longEpochTime,
                LongEpochDate2 = longEpochTimeBefore1970
            };

            await Context.SaveAsync(employee);

            //This is a valid use of .ToLocalTime
            var expectedCurrTime = retrieveDateTimeInUtc ? currTime.ToUniversalTime() : currTime.ToLocalTime();
            var expectedLongEpochTime =
                retrieveDateTimeInUtc ? longEpochTime.ToUniversalTime() : longEpochTime.ToLocalTime();
            var expectedLongEpochTimeBefore1970 = retrieveDateTimeInUtc
                ? longEpochTimeBefore1970.ToUniversalTime()
                : longEpochTimeBefore1970.ToLocalTime();

            // Load 
            var storedEmployee = Context.Load<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name,
                new LoadConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc });
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);

            // Query
            QueryFilter filter = new QueryFilter();
            filter.AddCondition("CreationTime", QueryOperator.Equal, currTime);
            storedEmployee = (await Context.FromQueryAsync<AnnotatedNumericEpochEmployee>(
                new QueryOperationConfig { Filter = filter },
                new FromQueryConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc }
                )
                .GetNextSetAsync())
                .First();
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);

            // Scan
            storedEmployee = (await Context.ScanAsync<AnnotatedNumericEpochEmployee>(
                new List<ScanCondition>(),
                new ScanConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc })
                .GetRemainingAsync())
                .First();
            Assert.IsNotNull(storedEmployee);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
            ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(employee.Age, storedEmployee.Age);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_ScanWithExpression_NestedPaths()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var product1 = new Product
            {
                Id = 1,
                Name = "Widget",
                CompanyInfo = new CompanyInfo
                {
                    Name = "Acme",
                    Founded = new DateTime(2000, 1, 1),
                    AllProducts = new List<Product>
                    {
                        new Product { Id = 2, Name = "Gadget" }
                    },
                    FeaturedBrands = new[] { "Acme", "Contoso" }
                },
                Price = 100
            };

            var product2 = new Product
            {
                Id = 3,
                Name = "Thing",
                CompanyInfo = new CompanyInfo
                {
                    Name = "Contoso",
                    Founded = new DateTime(2010, 5, 5),
                    AllProducts = new List<Product>
                    {
                        new Product { Id = 4, Name = "Device" }
                    },
                    FeaturedBrands = new[] { "Contoso" }
                },
                Price = 200
            };

            var product3 = new Product
            {
                Id = 5,
                Name = "CloudSpotter",
                CompanyInfo = new CompanyInfo
                {
                    Name = "Contoso",
                    Founded = new DateTime(2010, 5, 5),
                    AllProducts = new List<Product>
                    {
                        new Product
                        {
                            Id = 6, Name = "Service", Components = new List<string>
                            {
                                "Code",
                                "Storage",
                                "Network"
                            }
                        }
                    },
                    CompetitorProducts = new Dictionary<string, List<Product>>()
                    {
                        {
                            "CloudsAreOK", new List<Product>()
                            {
                                new Product()
                                {
                                    Id = 8, Name = "CloudSpotter RipOff"
                                }
                            }
                        }
                    },
                    FeaturedBrands = new[] { "Contoso" }
                },
                Price = 200
            };

            await Context.SaveAsync(product1);
            await Context.SaveAsync(product2);
            await Context.SaveAsync(product3);

            // 1. Filter on a nested property (CompanyInfo.Name)
            var expr1 = new ContextExpression();
            expr1.SetFilter<Product>(p => p.CompanyInfo.Name == "Acme");
            var byCompanyName = await Context.ScanAsync<Product>(expr1).GetRemainingAsync();
            Assert.AreEqual(1, byCompanyName.Count);
            Assert.AreEqual("Widget", byCompanyName[0].Name);

            // 2. Filter on a nested array property (FeaturedBrands contains "Acme")
            var expr2 = new ContextExpression();
            expr2.SetFilter<Product>(p => p.CompanyInfo.FeaturedBrands.Contains("Acme"));
            var byFeaturedBrand = await Context.ScanAsync<Product>(expr2).GetRemainingAsync();
            Assert.AreEqual(1, byFeaturedBrand.Count);
            Assert.AreEqual("Widget", byFeaturedBrand[0].Name);

            // 3. Filter on a double-nested property 
            var expr3 = new ContextExpression();
            expr3.SetFilter<Product>(p => p.CompanyInfo.AllProducts.First().Name == "Device");
            var byDoubleNested = await Context.ScanAsync<Product>(expr3).GetRemainingAsync();
            Assert.AreEqual(1, byDoubleNested.Count);
            Assert.AreEqual("Thing", byDoubleNested[0].Name);

            var expr4 = new ContextExpression();
            expr4.SetFilter<Product>(p => p.CompanyInfo.AllProducts[0].Name == "Device");
            var byDoubleNested1 = await Context.ScanAsync<Product>(expr4).GetRemainingAsync();
            Assert.AreEqual(1, byDoubleNested1.Count);
            Assert.AreEqual("Thing", byDoubleNested1[0].Name);

            // 4. Filter on a value inside a dictionary of lists
            var expr5 = new ContextExpression();
            expr5.SetFilter<Product>(p => p.CompanyInfo.CompetitorProducts["CloudsAreOK"][0].Name == "CloudSpotter RipOff");
            var byDictionaryNested = await Context.ScanAsync<Product>(expr5).GetRemainingAsync();
            Assert.AreEqual(1, byDictionaryNested.Count);
            Assert.AreEqual("CloudSpotter", byDictionaryNested[0].Name);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_ScanConfigFilter()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var employee = new Employee()
            {
                Name = "Bob",
                Age = 45,
                CurrentStatus = Status.Active,
                CompanyName = "test",
            };

            var employee3 = new Employee
            {
                Name = "Cob",
                Age = 45,
                CurrentStatus = Status.Inactive,
                CompanyName = "test1",
            };

            await Context.SaveAsync(employee);
            await Context.SaveAsync(employee3);

            var ageEqResultScan = await Context.ScanAsync<Employee>(new List<ScanCondition>(), new ScanConfig()
            {
                QueryFilter = new List<ScanCondition>()
                {
                    new ScanCondition("Age", ScanOperator.GreaterThan,50)
                },
                ConditionalOperator = ConditionalOperatorValues.And
            }).GetRemainingAsync();
            Assert.AreEqual(0, ageEqResultScan.Count);

            var ageAndCompanyResultScan = await Context.ScanAsync<Employee>(
                new List<ScanCondition>()
                {
                    new ScanCondition("Age", ScanOperator.Equal,45)
                }, 
                new ScanConfig()
                {
                    QueryFilter = new List<ScanCondition>()
                    {
                        new ScanCondition("CompanyName", ScanOperator.Equal, "test")
                    },
                    ConditionalOperator = ConditionalOperatorValues.And
                })
            .GetRemainingAsync();
            Assert.AreEqual(1, ageAndCompanyResultScan.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_Scan_WithExpressionFilter()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var employee = new Employee()
            {
                Name = "Bob",
                Age = 45,
                CurrentStatus = Status.Active,
                CompanyName = "test",
            };

            var employee3 = new Employee
            {
                Name = "Cob",
                Age = 45,
                CurrentStatus = Status.Inactive,
                CompanyName = "test1",
            };

            var employee2 = new Employee
            {
                Name = "Rob",
                Age = 35,
                CurrentStatus = Status.Active,
                CompanyName = "test",
            };

            var employee4 = new Employee
            {
                Name = "Sam",
                Age = 20,
                CurrentStatus = Status.Upcoming,
                CompanyName = "test2",
            };

            await Context.SaveAsync(employee);
            await Context.SaveAsync(employee2);
            await Context.SaveAsync(employee3);
            await Context.SaveAsync(employee4);

            // Numeric equality
            int age = 45;
            var exprAgeEq = new ContextExpression();
            exprAgeEq.SetFilter<Employee>(e => e.Age == age);
            var ageEqResult = await Context.ScanAsync<Employee>(exprAgeEq).GetRemainingAsync();
            Assert.AreEqual(2, ageEqResult.Count);

            var exprAgeEqM = new ContextExpression();
            exprAgeEqM.SetFilter<Employee>(e => Equals(e.Age, 45));
            var ageEqMResult = await Context.ScanAsync<Employee>(exprAgeEqM).GetRemainingAsync();
            Assert.AreEqual(2, ageEqMResult.Count);

            // AND expression with BinaryComparisons 
            var exprAnd = new ContextExpression();
            exprAnd.SetFilter<Employee>(e => e.Age > 40 && e.CompanyName == "test");
            var andResults = await Context.ScanAsync<Employee>(exprAnd).GetRemainingAsync();

            var s1 = await Context.ScanAsync<Employee>(new List<ScanCondition>()
            {
                new ScanCondition("Age", ScanOperator.GreaterThan, 40),
                new ScanCondition("CompanyName", ScanOperator.Equal, "test")
            }, new ScanConfig { RetrieveDateTimeInUtc = true }).GetRemainingAsync();

            Assert.IsNotNull(s1);
            Assert.AreEqual(s1.Count, 1);
            Assert.AreEqual(s1.FirstOrDefault().Name, "Bob");

            Assert.IsNotNull(andResults);
            Assert.AreEqual(andResults.Count, 1);
            Assert.AreEqual(andResults.FirstOrDefault().Name, "Bob");

            // NOT expression
            var exprNot = new ContextExpression();
            exprNot.SetFilter<Employee>(e => !(e.CompanyName == "test1"));
            var notResult = await Context.ScanAsync<Employee>(exprNot).GetRemainingAsync();
            Assert.AreEqual(3, notResult.Count);
            Assert.IsTrue(notResult.All(e => e.CompanyName != "test1"));

            // OR expression
            var exprOr = new ContextExpression();
            exprOr.SetFilter<Employee>(e => e.Name == "Bob" || e.Name == "Rob");
            var orResult = await Context.ScanAsync<Employee>(exprOr).GetRemainingAsync();
            Assert.AreEqual(2, orResult.Count);
            Assert.IsTrue(orResult.Any(e => e.Name == "Bob"));
            Assert.IsTrue(orResult.Any(e => e.Name == "Rob"));

            // Contains on list property (Aliases)
            var empWithAliases = new Employee
            {
                Name = "Ali",
                Age = 50,
                CurrentStatus = Status.Active,
                MiddleName = "MiddleName",
                CompanyName = "test",
                Aliases = new List<string> { "Al", "A", "B" }
            };
            await Context.SaveAsync(empWithAliases);

            var exprContains = new ContextExpression();
            exprContains.SetFilter<Employee>(e => e.Aliases.Contains("Al"));
            var containsResult = await Context.ScanAsync<Employee>(exprContains).GetRemainingAsync();
            Assert.IsTrue(containsResult.Any(e => e.Name == "Ali"));

            var exprContainsEnumerable = new ContextExpression();
            exprContainsEnumerable.SetFilter<Employee>(e => Enumerable.Contains(e.Aliases, "Al"));
            var containsEnumerableResult = await Context.ScanAsync<Employee>(exprContainsEnumerable).GetRemainingAsync();
            Assert.IsTrue(containsEnumerableResult.Any(e => e.Name == "Ali"));

            // String.StartsWith
            var exprStartsWith = new ContextExpression();
            exprStartsWith.SetFilter<Employee>(e => e.Name.StartsWith("B"));
            var startsWithResult = await Context.ScanAsync<Employee>(exprStartsWith).GetRemainingAsync();
            Assert.IsTrue(startsWithResult.Any(e => e.Name == "Bob"));

            // Between
            var exprBetween = new ContextExpression();
            exprBetween.SetFilter<Employee>(e => ContextExpression.Between(e.Age, 40, 50));
            var betweenResult = await Context.ScanAsync<Employee>(exprBetween).GetRemainingAsync();
            Assert.AreEqual(3, betweenResult.Count);
            Assert.IsTrue(betweenResult.All(e => e.Age >= 40 && e.Age <= 50));

            // String.Contains
            var exprStringContains = new ContextExpression();
            exprStringContains.SetFilter<Employee>(e => e.Name.Contains("o"));
            var stringContainsResult = await Context.ScanAsync<Employee>(exprStringContains).GetRemainingAsync();
            Assert.IsTrue(stringContainsResult.Any(e => e.Name == "Bob" || e.Name == "Rob" || e.Name == "Cob"));

            var exprNullCheck = new ContextExpression();
            exprNullCheck.SetFilter<Employee>(e => ContextExpression.AttributeExists(e.MiddleName));
            var nullCheckResult = await Context.ScanAsync<Employee>(exprNullCheck).GetRemainingAsync();
            Assert.IsTrue(nullCheckResult.Count == 1);

            var exprNull = new ContextExpression();
            exprNull.SetFilter<Employee>(e => ContextExpression.AttributeNotExists(e.MiddleName));
            var nullResult = await Context.ScanAsync<Employee>(exprNull).GetRemainingAsync();
            Assert.IsTrue(nullResult.Count == 4);

            //AttributeType scenario: filter for employees where MiddleName is a DynamoDB String
            var empWithStringMiddleName = new Employee
            {
                Name = "TypeTest",
                Age = 55,
                CurrentStatus = Status.Inactive,
                MiddleName = "StringType",
                CompanyName = "test"
            };
            await Context.SaveAsync(empWithStringMiddleName);

            var attributeType = DynamoDBAttributeType.S.Value;
            var exprAttributeType = new ContextExpression();
            exprAttributeType.SetFilter<Employee>(e => ContextExpression.AttributeType(e.MiddleName, attributeType));
            var attributeTypeResult = await Context.ScanAsync<Employee>(exprAttributeType).GetRemainingAsync();
            Assert.IsTrue(attributeTypeResult.Any(e => e.Name == "TypeTest"));

            // --- Enum scenario ---
            // Scan for employees with CurrentStatus == Status.Active
            var exprActiveEnum = new ContextExpression();
            exprActiveEnum.SetFilter<Employee>(e => e.CurrentStatus == Status.Active);
            var activeEnumResult = await Context.ScanAsync<Employee>(exprActiveEnum).GetRemainingAsync();
            Assert.AreEqual(3, activeEnumResult.Count);
            Assert.IsTrue(activeEnumResult.All(e => e.CurrentStatus == Status.Active));

            // Scan for employees with CurrentStatus == Status.Upcoming
            var exprUpcomingEnum = new ContextExpression();
            exprUpcomingEnum.SetFilter<Employee>(e => e.CurrentStatus == Status.Upcoming);
            var upcomingEnumResult = await Context.ScanAsync<Employee>(exprUpcomingEnum).GetRemainingAsync();
            Assert.AreEqual(1, upcomingEnumResult.Count);
            Assert.AreEqual("Sam", upcomingEnumResult[0].Name);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_SaveItem_WithTTL()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            // Create context and table if needed
            CreateContext(DynamoDBEntryConversion.V2, true);

            // Define TTL to be 2 minutes in the future
            var ttlEpoch = DateTimeOffset.UtcNow.AddMinutes(2).ToUnixTimeSeconds();

            var item = new TtlTestItem  
            {
                Id = 1,
                Data = "Test with TTL",
                Ttl = ttlEpoch
            };

            Context.Save(item);

            // Load immediately, should exist
            var loaded = Context.Load<TtlTestItem>(item.Id);
            Assert.IsNotNull(loaded);
            Assert.AreEqual(item.Id, loaded.Id);
            Assert.AreEqual(item.Data, loaded.Data);
            Assert.AreEqual(item.Ttl, loaded.Ttl);

            item.Ttl = DateTimeOffset.UtcNow.AddMinutes(3).ToUnixTimeSeconds();
            Context.Save(item);
            var loaded2 = Context.Load<TtlTestItem>(item.Id);
            Assert.IsNotNull(loaded2);
            Assert.AreEqual(item.Id, loaded2.Id);
            Assert.AreEqual(item.Data, loaded2.Data);
            Assert.AreEqual(item.Ttl, loaded2.Ttl);
        }

        // Example model for TTL
        [DynamoDBTable("HashTable")]
        public class TtlTestItem
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            public string Data { get; set; }

            [DynamoDBProperty("TTL")]
            public long Ttl { get; set; }
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_Query_WithExpressionFilter()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
            };
            Context = new DynamoDBContext(Client, config);

            // Seed data
            var employee1 = new Employee
            {
                Name = "Alice",
                Age = 30,
                CompanyName = "Contoso",
                CurrentStatus = Status.Active
            };
            var employee11 = new Employee
            {
                Name = "Alice",
                Age = 35,
                CompanyName = "ContosoTest",
                CurrentStatus = Status.Active
            };
            var employee2 = new Employee
            {
                Name = "Bob",
                Age = 40,
                CompanyName = "Acme",
                CurrentStatus = Status.Inactive
            };
            var employee3 = new Employee
            {
                Name = "Charlie",
                Age = 35,
                CompanyName = "Contoso",
                CurrentStatus = Status.Active
            };

            await Context.SaveAsync(employee1);
            await Context.SaveAsync(employee2);
            await Context.SaveAsync(employee3);

            var contextExpression = new ContextExpression();
            contextExpression.SetFilter<Employee>(e => e.CompanyName == "Contoso");
            var queryConfig = new QueryConfig
            {
                Expression = contextExpression
            };

            var employees = await Context.QueryAsync<Employee>("Alice", queryConfig).GetNextSetAsync();
            Assert.AreEqual(1, employees.Count);
            Assert.AreEqual("Alice", employees[0].Name);

            employees = await Context.QueryAsync<Employee>("Charlie", queryConfig).GetNextSetAsync();
            Assert.AreEqual(1, employees.Count);
            Assert.AreEqual("Charlie", employees[0].Name);

            employees = await Context.QueryAsync<Employee>("Bob", queryConfig).GetNextSetAsync();
            Assert.AreEqual(0, employees.Count);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_Query_QueryFilter_vs_ExpressionFilter()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
            };
            Context = new DynamoDBContext(Client, config);

            // Seed data
            var employee1 = new Employee
            {
                Name = "Diane",
                Age = 40,
                CompanyName = "Big River",
                CurrentStatus = Status.Active,
                Score = 140,
                ManagerName = "Eva"
            };
            var employee2 = new Employee
            {
                Name = "Diane",
                Age = 24,
                CompanyName = "Big River",
                CurrentStatus = Status.Inactive,
                Score = 101,
                ManagerName = "Eva"
            };
            var employee3 = new Employee
            {
                Name = "Diane",
                Age = 31,
                CompanyName = "Small River",
                CurrentStatus = Status.Active,
                Score = 120,
                ManagerName = "Barbara"
            };
            await Context.SaveAsync(employee1);
            await Context.SaveAsync(employee2);
            await Context.SaveAsync(employee3);

            // 1. QueryFilter only: filter by ManagerName == "Eva"
            var queryFilter = new List<ScanCondition>
            {
                new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
            };
            var resultQueryFilter = await Context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                QueryFilter = queryFilter
            }).GetNextSetAsync();

            // 2. ExpressionFilter only: filter by ManagerName == "Eva"
            var contextExpression = new ContextExpression();
            contextExpression.SetFilter<Employee>(e => e.ManagerName == "Eva");
            var resultExpressionFilter = await Context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                Expression = contextExpression
            }).GetNextSetAsync();

            // Assert both results are equivalent
            Assert.AreEqual(resultQueryFilter.Count, resultExpressionFilter.Count, "Result counts should match between QueryFilter and ExpressionFilter.");
            CollectionAssert.AreEquivalent(
                resultQueryFilter.Select(e => e.Age).ToList(),
                resultExpressionFilter.Select(e => e.Age).ToList(),
                "Result items should match between QueryFilter and ExpressionFilter."
            );

            // 3. Simulate combined filter: CurrentStatus == Inactive AND ManagerName == "Barbara"
            var inactiveFilter = new List<ScanCondition>
            {
                new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active),
                new ScanCondition("ManagerName", ScanOperator.Equal, "Barbara")
            };
            var contextExpressionBarbara = new ContextExpression();
            contextExpressionBarbara.SetFilter<Employee>(e => e.ManagerName == "Barbara" && e.CurrentStatus == Status.Active);

            // Run each filter separately and take intersection
            var resultActive = await Context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                QueryFilter = inactiveFilter,
                ConditionalOperator = ConditionalOperatorValues.And
            }).GetNextSetAsync();

            var resultBarbara = await Context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                Expression = contextExpressionBarbara
            }).GetNextSetAsync();

            Assert.AreEqual(resultActive.Count, resultBarbara.Count, "Result counts should match between QueryFilter and ExpressionFilter.");
            CollectionAssert.AreEquivalent(
                resultActive.Select(e => e.Age).ToList(),
                resultBarbara.Select(e => e.Age).ToList(),
                "Result items should match between QueryFilter and ExpressionFilter."
            );
            // 4. QueryFilter with ConditionalOperator.Or (CurrentStatus == Active OR Score == 101)
            var orFilter = new List<ScanCondition>
            {
                new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active),
                new ScanCondition("Score", ScanOperator.Equal, 101)
            };
            var resultOrQueryFilter = await Context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                QueryFilter = orFilter,
                ConditionalOperator = ConditionalOperatorValues.Or
            }).GetNextSetAsync();

            var contextExpressionOr = new ContextExpression();
            contextExpressionOr.SetFilter<Employee>(e => e.CurrentStatus == Status.Active || e.Score == 101);

            var resultOrExpressionFilter = await Context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                Expression = contextExpressionOr
            }).GetNextSetAsync();

            // Assert both results are equivalent
            Assert.AreEqual(resultOrQueryFilter.Count, resultOrExpressionFilter.Count, "Result counts should match between QueryFilter (OR) and ExpressionFilter (OR).");
            CollectionAssert.AreEquivalent(
                resultOrQueryFilter.Select(e => e.Age).ToList(),
                resultOrExpressionFilter.Select(e => e.Age).ToList(),
                "Result items should match between QueryFilter (OR) and ExpressionFilter (OR)."
            );

            // 5. ExpressionFilter with index
            var resultIndex = await Context.QueryAsync<Employee>("Big River", new QueryConfig
            {
                IndexName = "GlobalIndex",
                Expression = contextExpression
            }).GetNextSetAsync();
            Assert.AreEqual(2, resultIndex.Count);
            Assert.IsTrue(resultIndex.All(e => e.ManagerName == "Eva"));
        }

        /// <summary>
        /// Tests that the DynamoDB operations can read and write polymorphic items.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_SaveAndLoad_WithDerivedTypeItems()
        {
            await CleanupTables();
            TableCache.Clear();

            var model = CreateNestedTypeItem(out var id);

            await Context.SaveAsync(model);

            var storedModel = await Context.LoadAsync<ModelA>(id);
            Assert.AreEqual(model.Id, storedModel.Id);
            Assert.AreEqual(model.GetType(), storedModel.GetType());
            Assert.IsNotNull(storedModel.FlatAddress);

            var myType = model as ModelA1;
            var myStoredModel = storedModel as ModelA1;

            Assert.AreEqual(myType.MyType.GetType(), myStoredModel.MyType.GetType());
            Assert.AreEqual(myType.MyType.MyPropA, myStoredModel.MyType.MyPropA);
            Assert.AreEqual(myType.MyType.Name, myStoredModel.MyType.Name);
            Assert.AreEqual(((B)myType.MyType).MyPropB, ((B)myStoredModel.MyType).MyPropB);

            Assert.AreEqual(myType.MyInterface.GetType(), myStoredModel.MyInterface.GetType());

            var myInterface = myType.MyInterface as InterfaceA;
            var storedInterface = myStoredModel.MyInterface as InterfaceA;

            Assert.AreEqual(myInterface.S3, storedInterface.S3);

            Assert.AreEqual(myType.MyClasses.Count, myStoredModel.MyClasses.Count);
            Assert.AreEqual(myType.MyClasses[0].GetType(), myStoredModel.MyClasses[0].GetType());
            Assert.AreEqual(myType.MyClasses[1].GetType(), myStoredModel.MyClasses[1].GetType());
        }

        /// <summary>
        /// Tests that the DynamoDB operations can read and write polymorphic items.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_TransactWriteAndLoad_WithDerivedTypeItems()
        {
            await CleanupTables();
            TableCache.Clear();

            var model1 = CreateNestedTypeItem(out var id);
            var model2 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "A1", MyPropA = 1 },
                MyInterface = new InterfaceB()
                {
                    S2 = 2,
                    S1 = "s1",
                    S4 = "s4"
                },
                DictionaryClasses = new Dictionary<string, A>()
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "A1", MyPropA = 1, MyPropB = 2 } }
                }
            };

            var transactWrite = Context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var storedModel1 = await Context.LoadAsync<ModelA>(id);
            var storedModel2 = await Context.LoadAsync<ModelA>(model2.Id);
            Assert.AreEqual(model1.Id, storedModel1.Id);
            Assert.AreEqual(model1.GetType(), storedModel1.GetType());
            Assert.AreEqual(model2.Id, storedModel2.Id);
            Assert.AreEqual(model2.GetType(), storedModel2.GetType());

            var myInterface = model2.MyInterface as InterfaceB;
            var storedInterface = model2.MyInterface as InterfaceB;

            Assert.AreEqual(myInterface.S4, storedInterface.S4);

        }

        /// <summary>
        /// Tests that the DynamoDB operations can read and write items.
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_AtomicCounterAnnotation()
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            // Initial save
            CounterAnnotatedEmployee employee = new CounterAnnotatedEmployee
            {
                Name = "Mark",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };

            await Context.SaveAsync(employee);
            var storedEmployee = await Context.LoadAsync<CounterAnnotatedEmployee>(employee.Name, 31);
            Assert.IsNotNull(storedEmployee);
            Assert.AreEqual(employee.Name, storedEmployee.Name);
            Assert.AreEqual(0, storedEmployee.CountDefault);
            Assert.AreEqual(10, storedEmployee.CountAtomic);

            // Simulate external update: increment counters by saving again
            storedEmployee.CountDefault = null; // Let the context increment
            storedEmployee.CountAtomic = null;
            await Context.SaveAsync(storedEmployee);

            var externallyUpdated = await Context.LoadAsync<CounterAnnotatedEmployee>(employee.Name, 31);
            Assert.AreEqual(1, externallyUpdated.CountDefault);
            Assert.AreEqual(12, externallyUpdated.CountAtomic);

            // Simulate a stale POCO (behind the table value)
            var stalePoco = new CounterAnnotatedEmployee
            {
                Name = "Mark",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony",
                CountDefault = 0, // behind
                CountAtomic = 10  // behind
            };

            // Save the stale POCO, should increment from the current table value
            await Context.SaveAsync(stalePoco);

            // After save, the POCO should be updated to the latest value
            Assert.AreEqual(2, stalePoco.CountDefault);
            Assert.AreEqual(14, stalePoco.CountAtomic);

            // Confirm with a fresh load
            var latest = await Context.LoadAsync<CounterAnnotatedEmployee>(employee.Name, 31);
            Assert.AreEqual(2, latest.CountDefault);
            Assert.AreEqual(14, latest.CountAtomic);

            VersionedAnnotatedEmployee versionedAnnotatedEmployee = new VersionedAnnotatedEmployee
            {
                Name = "MarkV1",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };

            await Context.SaveAsync(versionedAnnotatedEmployee);
            var storedVersionEmployee = await Context.LoadAsync<VersionedAnnotatedEmployee>(versionedAnnotatedEmployee.Name, 31);
            Assert.IsNotNull(storedVersionEmployee);
            Assert.AreEqual(0, storedVersionEmployee.Version);
            Assert.AreEqual(0, storedVersionEmployee.CountDefault);
            Assert.AreEqual(10, storedVersionEmployee.CountAtomic);

            // Update the employee
            versionedAnnotatedEmployee.ManagerName = "Helena";
            await Context.SaveAsync(versionedAnnotatedEmployee);
            var storedUpdatedEmployee = await Context.LoadAsync<VersionedAnnotatedEmployee>(versionedAnnotatedEmployee.Name, 31);
            Assert.IsNotNull(storedUpdatedEmployee);
            Assert.AreEqual(1, storedUpdatedEmployee.Version);
            Assert.AreEqual(1, storedUpdatedEmployee.CountDefault);
            Assert.AreEqual(12, storedUpdatedEmployee.CountAtomic);

            // --- Flatten scenario with atomic counter and version ---
            var product = new ProductFlatWithAtomicCounter
            {
                Id = 500,
                Name = "FlatAtomic",
                Details = new ProductDetailsWithAtomicCounter
                {
                    Description = "Flat details",
                    Name = "FlatName"
                }
            };

            await Context.SaveAsync(product);
            var loadedProduct = await Context.LoadAsync<ProductFlatWithAtomicCounter>(product.Id);
            Assert.IsNotNull(loadedProduct);
            Assert.IsNotNull(loadedProduct.Details);
            Assert.AreEqual(0, loadedProduct.Details.CountDefault);
            Assert.AreEqual(10, loadedProduct.Details.CountAtomic);
            Assert.AreEqual(0, loadedProduct.Details.Version);

            // Increment counters via null assignment
            loadedProduct.Details.CountDefault = null;
            loadedProduct.Details.CountAtomic = null;
            await Context.SaveAsync(loadedProduct);

            var loadedProductAfterIncrement = await Context.LoadAsync<ProductFlatWithAtomicCounter>(product.Id);
            Assert.AreEqual(1, loadedProductAfterIncrement.Details.CountDefault);
            Assert.AreEqual(12, loadedProductAfterIncrement.Details.CountAtomic);
            Assert.AreEqual(1, loadedProductAfterIncrement.Details.Version);

            // Simulate a stale POCO for flattened details
            var staleFlat = new ProductFlatWithAtomicCounter
            {
                Id = 500,
                Name = "FlatAtomic",
                Details = new ProductDetailsWithAtomicCounter
                {
                    Description = "Flat details",
                    Name = "FlatName",
                    CountDefault = 0,
                    CountAtomic = 10,
                    Version = 1
                }
            };
            await Context.SaveAsync(staleFlat);

            Assert.AreEqual(2, staleFlat.Details.CountDefault);
            Assert.AreEqual(14, staleFlat.Details.CountAtomic);
            Assert.AreEqual(2, staleFlat.Details.Version);

            var loadedFlatLatest = await Context.LoadAsync<ProductFlatWithAtomicCounter>(product.Id);
            Assert.AreEqual(2, loadedFlatLatest.Details.CountDefault);
            Assert.AreEqual(14, loadedFlatLatest.Details.CountAtomic);
            Assert.AreEqual(2, loadedFlatLatest.Details.Version);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_TransactWriteAndLoad_WithLocalSecondaryIndexRangeKey()
        {
            await CleanupTables();
            TableCache.Clear();

            var model = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "AType", MyPropA = 5 },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "B1", MyPropA = 2, MyPropB = 3 } }
                },
                ManagerName = "TestManager"
            };

            var transactWrite = Context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model });
            await transactWrite.ExecuteAsync();

            var storedModel = await Context.LoadAsync<ModelA>(model.Id);
            Assert.AreEqual(model.Id, storedModel.Id);
            Assert.AreEqual(model.GetType(), storedModel.GetType());
            var myStoredModel = storedModel as ModelA2;
            Assert.AreEqual(model.MyType.GetType(), myStoredModel.MyType.GetType());
            Assert.AreEqual(model.DictionaryClasses.Count, myStoredModel.DictionaryClasses.Count);
            Assert.AreEqual(model.DictionaryClasses["A"].GetType(), myStoredModel.DictionaryClasses["A"].GetType());
            Assert.AreEqual(model.DictionaryClasses["B"].GetType(), myStoredModel.DictionaryClasses["B"].GetType());
            Assert.AreEqual(((B)model.DictionaryClasses["B"]).MyPropB,
                ((B)myStoredModel.DictionaryClasses["B"]).MyPropB);
            Assert.AreEqual(model.ManagerName, myStoredModel.ManagerName);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_SaveAndScan_WithGlobalSecondaryIndexRangeKey()
        {
            await CleanupTables();
            TableCache.Clear();

            var model1 = new ModelA1
            {
                Id = Guid.NewGuid(),
                MyType = new B { Name = "BType1", MyPropA = 5, MyPropB = 10 },
                MyClasses = new List<A>
                {
                    new A { Name = "A1", MyPropA = 1 },
                    new B { Name = "B1", MyPropA = 2, MyPropB = 3 }
                },
                CompanyName = "TestCompany",
                Price = 100
            };

            var model2 = new ModelA1
            {
                Id = Guid.NewGuid(),
                MyType = new B { Name = "BType2", MyPropA = 6, MyPropB = 12 },
                MyClasses = new List<A>
                {
                    new A { Name = "A2", MyPropA = 2 },
                    new B { Name = "B2", MyPropA = 3, MyPropB = 4 }
                },
                CompanyName = "TestCompany",
                Price = 200
            };

            var transactWrite = Context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var scanConditions = new[]
            {
                new ScanCondition("CompanyName", ScanOperator.Equal, "TestCompany")
            };

            var results = await Context.ScanAsync<ModelA>(scanConditions).GetRemainingAsync();
            Assert.AreEqual(2, results.Count);

            var storedModel1 = results.FirstOrDefault(m => m.Id == model1.Id) as ModelA1;
            var storedModel2 = results.FirstOrDefault(m => m.Id == model2.Id) as ModelA1;

            Assert.IsNotNull(storedModel1);
            Assert.IsNotNull(storedModel2);

            Assert.AreEqual(model1.Id, storedModel1.Id);
            Assert.AreEqual(model1.MyType.GetType(), storedModel1.MyType.GetType());
            Assert.AreEqual(((B)model1.MyType).MyPropB, ((B)storedModel1.MyType).MyPropB);
            Assert.AreEqual(model1.MyClasses.Count, storedModel1.MyClasses.Count);
            Assert.AreEqual(model1.CompanyName, storedModel1.CompanyName);
            Assert.AreEqual(model1.Price, storedModel1.Price);

            Assert.AreEqual(model2.Id, storedModel2.Id);
            Assert.AreEqual(model2.MyType.GetType(), storedModel2.MyType.GetType());
            Assert.AreEqual(((B)model2.MyType).MyPropB, ((B)storedModel2.MyType).MyPropB);
            Assert.AreEqual(model2.MyClasses.Count, storedModel2.MyClasses.Count);
            Assert.AreEqual(model2.CompanyName, storedModel2.CompanyName);
            Assert.AreEqual(model2.Price, storedModel2.Price);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestContext_SaveAndScan_WithLocalSecondaryIndexRangeKey()
        {
            await CleanupTables();
            TableCache.Clear();

            var model1 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new C { Name = "AType1", MyPropA = 5, MyPropC = "test" },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A1", MyPropA = 1 } },
                    { "B", new B { Name = "B1", MyPropA = 2, MyPropB = 3 } }
                },
                ManagerName = "Manager1"
            };

            var model2 = new ModelA2
            {
                Id = Guid.NewGuid(),
                MyType = new A { Name = "AType2", MyPropA = 6 },
                DictionaryClasses = new Dictionary<string, A>
                {
                    { "A", new A { Name = "A2", MyPropA = 2 } },
                    { "B", new B { Name = "B2", MyPropA = 3, MyPropB = 4 } }
                },
                ManagerName = "Manager2"
            };

            var transactWrite = Context.CreateTransactWrite<ModelA>();
            transactWrite.AddSaveItems(new[] { model1, model2 });
            await transactWrite.ExecuteAsync();

            var scanConditions = new[]
            {
                new ScanCondition("ManagerName", ScanOperator.Equal, "Manager1")
            };

            var results = await Context.ScanAsync<ModelA>(scanConditions).GetRemainingAsync();
            Assert.AreEqual(1, results.Count);

            var storedModel = results.FirstOrDefault(m => m.Id == model1.Id) as ModelA2;

            Assert.IsNotNull(storedModel);
            Assert.AreEqual(model1.Id, storedModel.Id);
            Assert.AreEqual(model1.MyType.GetType(), storedModel.MyType.GetType());
            Assert.AreEqual(model1.DictionaryClasses.Count, storedModel.DictionaryClasses.Count);
            Assert.AreEqual(model1.DictionaryClasses["A"].GetType(), storedModel.DictionaryClasses["A"].GetType());
            Assert.AreEqual(model1.DictionaryClasses["B"].GetType(), storedModel.DictionaryClasses["B"].GetType());
            Assert.AreEqual(((B)model1.DictionaryClasses["B"]).MyPropB,
                ((B)storedModel.DictionaryClasses["B"]).MyPropB);
            Assert.AreEqual(model1.ManagerName, storedModel.ManagerName);
        }

        /// <summary>
        /// Runs the same object-mapper integration tests as <see cref="TestContextWithEmptyStringEnabled"/>,
        /// but using table definitions created by <see cref="TableBuilder"/> instead of the internal <see cref="IAmazonDynamoDB.DescribeTable"/> call
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestWithBuilderTables()
        {
            foreach (var conversion in new DynamoDBEntryConversion[]
                         { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                // Cleanup existing data in the tables
                await CleanupTables();

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
                    .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Score",
                        DynamoDBEntryType.Numeric)
                    .AddLocalSecondaryIndex("LocalIndex", "Manager", DynamoDBEntryType.String)
                    .Build());

                Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-HashTable")
                    .AddHashKey("Id", DynamoDBEntryType.Numeric)
                    .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price",
                        DynamoDBEntryType.Numeric)
                    .Build());

                Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-NumericHashRangeTable")
                    .AddHashKey("CreationTime", DynamoDBEntryType.Numeric)
                    .AddRangeKey("Name", DynamoDBEntryType.String)
                    .Build());

                Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-CompositeHashRangeTable")
                    .AddHashKey("Id", DynamoDBEntryType.Numeric)
                    .AddRangeKey("Status", DynamoDBEntryType.String)
                    .AddGlobalSecondaryIndex("GSI1", "UserName", DynamoDBEntryType.String, "Timestamp", DynamoDBEntryType.Numeric)
                    .AddGlobalSecondaryIndex("GSI2",
                        new List<KeyValuePair<string, DynamoDBEntryType>> {
                            new KeyValuePair<string, DynamoDBEntryType>("UserName", DynamoDBEntryType.String),
                            new KeyValuePair<string, DynamoDBEntryType>( "OrderId", DynamoDBEntryType.String ) },
                        new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Timestamp", DynamoDBEntryType.Numeric) })
                    .AddGlobalSecondaryIndex("GSI3",
                        new List<KeyValuePair<string, DynamoDBEntryType>> {
                            new KeyValuePair<string, DynamoDBEntryType>( "UserName", DynamoDBEntryType.String ),
                            new KeyValuePair<string, DynamoDBEntryType>( "Region", DynamoDBEntryType.String ) },
                        new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>("Status", DynamoDBEntryType.String),
                            new KeyValuePair<string, DynamoDBEntryType>( "Category", DynamoDBEntryType.String ) })
                    .AddGlobalSecondaryIndex("GSI4",
                        new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType> ("Id", DynamoDBEntryType.Numeric ),
                            new KeyValuePair<string, DynamoDBEntryType>( "UserName", DynamoDBEntryType.String ),
                            new KeyValuePair<string, DynamoDBEntryType>("OrderId", DynamoDBEntryType.String),
                            new KeyValuePair<string, DynamoDBEntryType>("Region", DynamoDBEntryType.String ) },
                        new List<KeyValuePair<string, DynamoDBEntryType>> { new KeyValuePair<string, DynamoDBEntryType>( "Status", DynamoDBEntryType.String ),
                            new KeyValuePair<string, DynamoDBEntryType>( "Category", DynamoDBEntryType.String ),
                            new KeyValuePair<string, DynamoDBEntryType>(  "Amount", DynamoDBEntryType.Numeric ),
                            new KeyValuePair<string, DynamoDBEntryType>(  "Priority", DynamoDBEntryType.Numeric )})
                    .Build());

                await TestEmptyStringsWithFeatureEnabled();

                await TestEnumHashKeyObjects();

                await TestEmptyCollections(conversion);

                await TestUnsupportedTypes();
                TestEnums(conversion);

                await TestHashObjects();
                await TestHashRangeObjects<Employee>();
                await TestOtherContextOperations();
                await TestBatchOperations();
                await TestTransactionOperations();
                await TestMultiTableTransactionOperations();

                await TestStoreAsEpoch();
            }
        }

        /// <summary>
        /// Runs the same object-mapper integration tests as <see cref="TestContextWithEmptyStringEnabled"/>,
        /// but using a DynamoDBContext created by <see cref="DynamoDBContextBuilder"/>
        /// </summary>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task TestWithBuilderContext()
        {
            foreach (var conversion in new DynamoDBEntryConversion[]
                         { DynamoDBEntryConversion.V1, DynamoDBEntryConversion.V2 })
            {
                // Cleanup existing data in the tables
                await CleanupTables();

                // Clear existing SDK-wide cache
                TableCache.Clear();
                
                Context = new DynamoDBContextBuilder()
                    .ConfigureContext(x =>
                    {
                        x.IsEmptyStringValueEnabled = true;
                        x.Conversion = conversion;
                    })
                    .Build();

                await TestEmptyStringsWithFeatureEnabled();

                await TestEnumHashKeyObjects();

                await TestEmptyCollections(conversion);

                await TestAnnotatedUnsupportedTypes();
                TestEnums(conversion);

                await TestHashObjects();
                await TestHashRangeObjects<AnnotatedEmployee>();
                await TestOtherContextOperations();
                await TestBatchOperations();
                await TestAnnotatedTransactionOperations();
                await TestAnnotatedMultiTableTransactionOperations();

                await TestStoreAsAnnotatedEpoch();
            }
        }
        
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_IndexOrder()
        {
            Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-HashTable")
                .AddHashKey("Id", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price",
                    DynamoDBEntryType.Numeric)
                .Build());
            var order = new OrderIndex()
            {
                Id = 6,
                CompanyName = "TestCompany",
                Price = 1000
            };

            await Context.SaveAsync(order);
            
            var savedOrders = await Context.QueryAsync<OrderIndex>(
                order.CompanyName,
                QueryOperator.Equal,
                new object[] { 1000 },
                new QueryConfig 
                {
                    IndexName = "GlobalIndex",
                })
                .GetNextSetAsync();
            Assert.IsNotNull(savedOrders);

            var savedOrder = savedOrders.FirstOrDefault();
            Assert.IsNotNull(savedOrder);
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

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_IndexStructure()
        {
            await CleanupTables();
            TableCache.Clear();

            Context.RegisterTableDefinition(new TableBuilder(Client, "DotNetTests-HashTable")
                .AddHashKey("Id", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "CompanyInfo", DynamoDBEntryType.String, "Price",
                    DynamoDBEntryType.Numeric)
                .Build());

            var order = new Order()
            {
                Id = 6,
                Payment = new PaymentInfo()
                {
                    CompanyName = "TestCompany",
                    Price = 1000
                }
            };

            await Context.SaveAsync(order);
            var savedOrders = await Context.QueryAsync<Order>(
                order.Payment.CompanyName, // Hash-key for the index is Company
                QueryOperator.Equal, // Range-key for the index is Price, so the
                new object[] { 1000 }, // condition is against a numerical value
                new QueryConfig // Configure the index to use
                {
                    IndexName = "GlobalIndex",
                })
                .GetNextSetAsync();
            Assert.IsNotNull(savedOrders);
            var savedOrder = savedOrders.FirstOrDefault();
            Assert.IsNotNull(savedOrder);
            Assert.AreEqual(order.Id, savedOrder.Id);
            Assert.IsNotNull(savedOrder.Payment);
            Assert.AreEqual(order.Payment.Price, savedOrder.Payment.Price);
            Assert.AreEqual(order.Payment.CompanyName, savedOrder.Payment.CompanyName);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_FlattenAttribute_With_Annotations()
        {
            await CleanupTables();
            TableCache.Clear();

            // flatten with version
            var product = new ProductFlat
            {
                Id = 1,
                Name = "TestProduct",
                Details = new ProductDetails()
                {
                    Description = "Test",
                    Name = "TestProductDetails",
                }
            };

            await Context.SaveAsync(product);
            var savedProductFlat = await Context.LoadAsync<ProductFlat>(product.Id);
            Assert.IsNotNull(savedProductFlat);
            Assert.AreEqual(product.Id, savedProductFlat.Id);
            Assert.IsNotNull(savedProductFlat.Details);
            Assert.AreEqual(product.Details.Description, savedProductFlat.Details.Description);
            Assert.AreEqual(0, savedProductFlat.Details.Version);
            Assert.AreEqual("TestProduct", savedProductFlat.Name);
            Assert.AreEqual("TestProductDetails", savedProductFlat.Details.Name);

            // flattened property, which itself contains another flattened property.
            var flatEmployee = new EmployeeNonFlat()
            {
                EmployeeId = 2,
                Contact = new ContactInfo()
                {
                    Email = "test@email.com",
                    Address = new Address()
                    {
                        City = "Seattle",
                        Street = "N/A",
                    }
                }
            };
            await Context.SaveAsync(flatEmployee);
            var savedFlatEmployee = await Context.LoadAsync<EmployeeFlatten>(flatEmployee.EmployeeId);
            Assert.IsNotNull(savedFlatEmployee);
            Assert.AreEqual(flatEmployee.EmployeeId, savedFlatEmployee.EmployeeId);
            Assert.AreEqual(flatEmployee.Contact.Address.City, savedFlatEmployee.City);
            Assert.AreEqual(flatEmployee.Contact.Address.Street, savedFlatEmployee.Street);
            Assert.AreEqual(flatEmployee.Contact.Email, savedFlatEmployee.Email);

            //flattened property contains a property with a custom converter.
            var eventToSave = new Event()
            {
                Id = 5,
                Details = new EventDetails()
                {
                    EventDate = DateTime.Today
                }
            };
            await Context.SaveAsync(eventToSave);
            var savedEvent = await Context.LoadAsync<Event>(eventToSave.Id);
            Assert.IsNotNull(savedEvent);
            Assert.AreEqual(eventToSave.Id, savedEvent.Id);
            Assert.IsNotNull(savedEvent.Details);
            Assert.AreEqual(eventToSave.Details.EventDate.ToUniversalTime(), savedEvent.Details.EventDate);

            // Flattened Property with Global Secondary Index
            var order = new Order()
            {
                Id = 6,
                Payment = new PaymentInfo()
                {
                    CompanyName = "TestCompany",
                    Price = 1000
                }
            };

            await Context.SaveAsync(order);
            var savedOrders = await Context.QueryAsync<Order>(
                order.Payment.CompanyName, // Hash-key for the index is Company
                QueryOperator.Equal, // Range-key for the index is Price, so the
                new object[] { 1000 }, // condition is against a numerical value
                new QueryConfig // Configure the index to use
                {
                    IndexName = "GlobalIndex",
                })
                .GetNextSetAsync();
            Assert.IsNotNull(savedOrders);
            var savedOrder = savedOrders.FirstOrDefault();
            Assert.IsNotNull(savedOrder);
            Assert.AreEqual(order.Id, savedOrder.Id);
            Assert.IsNotNull(savedOrder.Payment);
            Assert.AreEqual(order.Payment.Price, savedOrder.Payment.Price);
            Assert.AreEqual(order.Payment.CompanyName, savedOrder.Payment.CompanyName);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_AutoGeneratedTimestampAttribute_CreateMode_Simple()
        {
            await CleanupTables();
            TableCache.Clear();

            var product = new ProductWithCreateTimestamp
            {
                Id = 999,
                Name = "SimpleCreate"
            };

            await Context.SaveAsync(product);
            var loaded = await Context.LoadAsync<ProductWithCreateTimestamp>(product.Id);

            Assert.IsNotNull(loaded);
            Assert.AreEqual(product.Id, loaded.Id);
            Assert.AreEqual("SimpleCreate", loaded.Name);
            Assert.IsNotNull(loaded.CreatedAt);
            Assert.IsTrue(loaded.CreatedAt > DateTime.MinValue);
            Assert.AreEqual(product.CreatedAt, loaded.CreatedAt);

            // Save again and verify CreatedAt does not change
            var createdAt = loaded.CreatedAt;
            await Task.Delay(1000);
            loaded.Name = "UpdatedName";
            await Context.SaveAsync(loaded);
            var loadedAfterUpdate = await Context.LoadAsync<ProductWithCreateTimestamp>(product.Id);
            ApproximatelyEqual(createdAt.Value, loadedAfterUpdate.CreatedAt.Value);

            // Test: StoreAsEpoch with AutoGeneratedTimestamp
            var now = DateTime.UtcNow;
            var epochEntity = new AutoGenTimestampEpochEntity
            {
                Id = 1,
                Name = "EpochTest"
            };

            await Context.SaveAsync(epochEntity);
            var loadedEpochEntity = await Context.LoadAsync<AutoGenTimestampEpochEntity>(epochEntity.Id);

            Assert.IsNotNull(loadedEpochEntity);
            Assert.IsTrue(loadedEpochEntity.CreatedAt > DateTime.MinValue);
            ApproximatelyEqual(epochEntity.CreatedAt.Value, loadedEpochEntity.CreatedAt.Value);

            // Test: StoreAsEpochLong with AutoGeneratedTimestamp
            var longEpochEntity = new AutoGenTimestampEpochLongEntity
            {
                Id = 2,
                Name = "LongEpochTest",
            };

            await Context.SaveAsync(longEpochEntity);
            var loadedLongEpochEntity = await Context.LoadAsync<AutoGenTimestampEpochLongEntity>(longEpochEntity.Id);

            Assert.IsNotNull(loadedLongEpochEntity);
            Assert.IsTrue(loadedLongEpochEntity.CreatedAt > DateTime.MinValue);
            ApproximatelyEqual(longEpochEntity.CreatedAt.Value, loadedLongEpochEntity.CreatedAt.Value);


            // Test: StoreAsEpoch with AutoGeneratedTimestamp (Create)
            var epochCreateEntity = new AutoGenTimestampEpochEntity
            {
                Id = 3,
                Name = "EpochCreateTest"
            };

            await Context.SaveAsync(epochCreateEntity);
            var loadedEpochCreateEntity = await Context.LoadAsync<AutoGenTimestampEpochEntity>(epochCreateEntity.Id);

            Assert.IsNotNull(loadedEpochCreateEntity);
            Assert.IsTrue(loadedEpochCreateEntity.CreatedAt > DateTime.MinValue);
            ApproximatelyEqual(epochCreateEntity.CreatedAt.Value, loadedEpochCreateEntity.CreatedAt.Value);

        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_AutoGeneratedTimestampAttribute_TransactWrite_Simple()
        {
            await CleanupTables();
            TableCache.Clear();

            var product = new ProductWithCreateTimestamp
            {
                Id = 1001,
                Name = "TransactCreate"
            };

            // Save using TransactWrite
            var transactWrite = Context.CreateTransactWrite<ProductWithCreateTimestamp>();
            transactWrite.AddSaveItem(product);
            await transactWrite.ExecuteAsync();

            var loaded = await Context.LoadAsync<ProductWithCreateTimestamp>(product.Id);

            Assert.IsNotNull(loaded);
            Assert.AreEqual(product.Id, loaded.Id);
            Assert.AreEqual("TransactCreate", loaded.Name);
            Assert.IsNotNull(loaded.CreatedAt);
            Assert.IsTrue(loaded.CreatedAt > DateTime.MinValue);
            Assert.AreEqual(product.CreatedAt, loaded.CreatedAt);

            // Save again using TransactWrite and verify CreatedAt does not change
            var createdAt = loaded.CreatedAt;
            await Task.Delay(1000);
            loaded.Name = "TransactUpdated";
            var transactWrite2 = Context.CreateTransactWrite<ProductWithCreateTimestamp>();
            transactWrite2.AddSaveItem(loaded);
            await transactWrite2.ExecuteAsync();
            var loadedAfterUpdate = await Context.LoadAsync<ProductWithCreateTimestamp>(product.Id);
            ApproximatelyEqual(createdAt.Value, loadedAfterUpdate.CreatedAt.Value);

            // Test: StoreAsEpoch with AutoGeneratedTimestamp (Always) using TransactWrite
            var epochEntity = new AutoGenTimestampEpochEntity
            {
                Id = 1002,
                Name = "TransactEpoch"
            };

            var transactWrite3 = Context.CreateTransactWrite<AutoGenTimestampEpochEntity>();
            transactWrite3.AddSaveItem(epochEntity);
            await transactWrite3.ExecuteAsync();
            var loadedEpochEntity = await Context.LoadAsync<AutoGenTimestampEpochEntity>(epochEntity.Id);

            Assert.IsNotNull(loadedEpochEntity);
            Assert.IsTrue(loadedEpochEntity.CreatedAt > DateTime.MinValue);
            ApproximatelyEqual(epochEntity.CreatedAt.Value, loadedEpochEntity.CreatedAt.Value);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_AutoGeneratedTimestampAttribute_With_Annotations()
        {
            await CleanupTables();
            TableCache.Clear();

            // 1. Test: AutoGeneratedTimestamp combined with Version and Flatten
            var now = DateTime.UtcNow;
            var product = new ProductFlatWithTimestamp
            {
                Id = 100,
                Name = "TimestampedProduct",
                Details = new ProductDetailsWithTimestamp
                {
                    Description = "Timestamped details",
                    Name = "DetailsName",
                }
            };

            await Context.SaveAsync(product);
            var savedProduct = await Context.LoadAsync<ProductFlatWithTimestamp>(product.Id);
            Assert.IsNotNull(savedProduct);
            Assert.IsNotNull(savedProduct.Details);
            Assert.IsTrue(savedProduct.Details.CreatedAt > DateTime.MinValue);
            Assert.AreEqual(0, savedProduct.Details.Version);

            // 2. Test: AutoGeneratedTimestamp combined with AtomicCounter and GSI
            var employee = new EmployeeWithTimestampAndCounter
            {
                Name = "Alice",
                Age = 25,
                CompanyName = "TestCompany",
                Score = 10,
                ManagerName = "Bob"
            };
            await Context.SaveAsync(employee);
            var loadedEmployee = await Context.LoadAsync<EmployeeWithTimestampAndCounter>(employee.Name, employee.Age);
            Assert.IsNotNull(loadedEmployee);
            Assert.IsTrue(loadedEmployee.LastUpdated > DateTime.MinValue);
            Assert.AreEqual(0, loadedEmployee.CountDefault);

            // 3. Test: AutoGeneratedTimestamp with TimestampMode.Create
            var productCreateOnly = new ProductWithCreateTimestamp
            {
                Id = 200,
                Name = "CreateOnly"
            };
            await Context.SaveAsync(productCreateOnly);
            var loadedCreateOnly = await Context.LoadAsync<ProductWithCreateTimestamp>(productCreateOnly.Id);
            Assert.IsNotNull(loadedCreateOnly);
            var createdAt = loadedCreateOnly.CreatedAt;
            Assert.IsTrue(createdAt > DateTime.MinValue);

            // Update and verify CreatedAt does not change
            await Task.Delay(1000);
            loadedCreateOnly.Name = "UpdatedName";
            await Context.SaveAsync(loadedCreateOnly);
            var loadedAfterUpdate = await Context.LoadAsync<ProductWithCreateTimestamp>(productCreateOnly.Id);
            ApproximatelyEqual(createdAt.Value, loadedAfterUpdate.CreatedAt.Value);
        }

        [TestMethod]
        [TestCategory("DynamoDBv2")]
        public async Task Test_AutoGeneratedTimestampAttribute_With_Annotations_BatchWrite()
        {
            await CleanupTables();
            TableCache.Clear();

            var entity = new EmployeeWithTimestampAndCounter
            {
                Name = "Alice",
                Age = 25,
                CompanyName = "TestCompany",
                Score = 10,
                ManagerName = "Bob"
            };

            var batch = Context.CreateBatchWrite<EmployeeWithTimestampAndCounter>();
            batch.AddPutItem(entity);
            await batch.ExecuteAsync();

            var loaded = await Context.LoadAsync<EmployeeWithTimestampAndCounter>(entity.Name, entity.Age);

            Assert.IsNotNull(loaded.LastUpdated, "LastUpdated should be set by AutoGeneratedTimestampAttribute");
            Assert.IsTrue((DateTime.UtcNow - loaded.LastUpdated.Value).TotalMinutes < 1, "LastUpdated should be recent");
        }

        /// <summary>
        /// Tests that if a custom property converter is used over the global converter on that specific property.
        /// </summary>
        /// <param name="retrieveDateTimeInUtc"></param>
        [TestMethod]
        [TestCategory("DynamoDBv2")]
        [DataRow("SmItH")]
        [DataRow("sMIth")]
        [DataRow("SMITH")]
        [DataRow("smith")]
        public async Task TestContext_GlobalConverter_And_PropertyConvector(string middleName)
        {
            TableCache.Clear();
            await CleanupTables();
            TableCache.Clear();

            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
            };
            Context = new DynamoDBContext(Client, config);

            // Add a global converter
            Context.ConverterCache.Add(typeof(string), new StringToUpperConverter());

            var employee = new PropertyConvertorTable
            {
                Id = 1,
                PropertyWithGlobalConvertor = "Bob",
                PropertyWithPropertyConvertor = middleName,
                
            };
            await Context.SaveAsync(employee);

            // Load 
            var storedEmployee = Context.Load<PropertyConvertorTable>(employee.Id);
            Assert.IsNotNull(storedEmployee);
            Assert.AreEqual(storedEmployee.Id, employee.Id);
            Assert.AreEqual(storedEmployee.PropertyWithGlobalConvertor, "BOB");
            Assert.AreEqual(storedEmployee.PropertyWithPropertyConvertor, "smith");
        }

        private static async Task TestEmptyStringsWithFeatureEnabled()
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

            await Context.SaveAsync(product);
            var savedProduct = await Context.LoadAsync<Product>(1);

            Assert.AreEqual(1, savedProduct.Id);
            Assert.AreEqual(string.Empty, savedProduct.Map["Position"]);
            Assert.AreEqual(string.Empty, savedProduct.Components[0]);
            Assert.AreEqual(string.Empty, savedProduct.CompanyInfo.AllProducts[0].Name);
        }

        private static async Task TestEmptyStringsWithFeatureDisabled()
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

            await Context.SaveAsync(product1);
            var savedProduct1 = await Context.LoadAsync<Product>(1);
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

            await Context.SaveAsync(product2);
            var savedProduct2 = await Context.LoadAsync<Product>(2);
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

            await Context.SaveAsync(product3);
            var savedProduct3 = await Context.LoadAsync<Product>(3);

            Assert.AreEqual(3, savedProduct3.Id);
            Assert.AreEqual(1, savedProduct3.Components.Count());
            Assert.AreEqual("test3", savedProduct3.Components[0]);
        }

        private async Task TestUnsupportedTypes()
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee2 = new Employee2
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            await Assert.ThrowsExceptionAsync<InvalidOperationException>(() =>
                Context.SaveAsync(employee2),
                "Type System.TimeSpan is unsupported, it cannot be instantiated"
            );

            var employee3 = new Employee3
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            await Assert.ThrowsExceptionAsync<InvalidOperationException>(() =>
                Context.SaveAsync(employee3),
                "Type AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members"
            );
        }

        private static async Task TestAnnotatedUnsupportedTypes()
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee4 = new Employee4
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => 
                Context.SaveAsync(employee4),
                "Type System.TimeSpan is unsupported, it cannot be instantiated"
            );

            var employee5 = new Employee5
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            await Assert.ThrowsExceptionAsync<InvalidOperationException>(() =>
                Context.SaveAsync(employee5),
                "Type AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members"
            );

            // Verify that objects that are invalid result in exceptions
            await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => 
                Context.ScanAsync<TimeSpan>(new List<ScanCondition>()).GetNextSetAsync(),
                "Type System.TimeSpan is unsupported, it cannot be instantiated"
            );

            await Assert.ThrowsExceptionAsync<InvalidOperationException>(() =>
                Context.ScanAsync<EmptyType>(new List<ScanCondition>()).GetNextSetAsync(),
                "Type AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DynamoDBTests+EmptyType is unsupported, it has no supported members"
            );
        }

        private async Task TestContextConversions()
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
                var docV1 = Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            {
                using (var contextV1 =
                       new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                using (var contextV2 =
                       new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV2 }))
                {
                    var docV1 = contextV1.ToDocument(product);
                    var docV2 = contextV2.ToDocument(product);
                    VerifyConversions(docV1, docV2);
                }
            }

            {
                using (var contextV1 =
                       new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                {
                    await contextV1.SaveAsync(product);
                    await contextV1.SaveAsync(product, new SaveConfig { Conversion = conversionV2 });
                }
            }

            {
                ProductV2 productV2 = new ProductV2
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

                using (var contextV1 =
                       new DynamoDBContext(Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
                {
                    var docV1 = contextV1.ToDocument(productV2, new ToDocumentConfig { Conversion = conversionV1 });
                    var docV2 = contextV1.ToDocument(productV2, new ToDocumentConfig { });
                    VerifyConversions(docV1, docV2);
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
                AssertExtensions.ExpectException(
                    () => Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 }),
                    typeof(InvalidOperationException));
                AssertExtensions.ExpectException(
                    () => Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 }),
                    typeof(InvalidOperationException));

                // Remove circular dependence
                product.CompanyInfo.MostPopularProduct = new Product
                {
                    Id = 3,
                    Name = "CloudDebugger",
                    CompanyName = "CloudsAreGrate",
                    Price = 9000,
                    TagSet = new HashSet<string> { "Test" },
                };

                var docV1 = Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            // Introduce circular reference in a Document and try to deserialize
            {
                // Normal serialization
                var docV1 = Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 });
                var docV2 = Context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);

                // Add circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV2;
                AssertExtensions.ExpectException(() =>
                    Context.FromDocument<Product>(docV1, new FromDocumentConfig { Conversion = conversionV1 }));
                AssertExtensions.ExpectException(() =>
                    Context.FromDocument<Product>(docV2, new FromDocumentConfig { Conversion = conversionV2 }));

                // Remove circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = null;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                var prod1 = Context.FromDocument<Product>(docV1, new FromDocumentConfig { Conversion = conversionV1 });
                var prod2 = Context.FromDocument<Product>(docV2, new FromDocumentConfig { Conversion = conversionV2 });
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

            await Context.SaveAsync(product);

            // Load and test the item
            var retrieved = await Context.LoadAsync(product);
            if (!isV1)
            {
                Assert.IsNotNull(retrieved.Components);
                Assert.AreEqual(0, retrieved.Components.Count);
            }

            Assert.IsNotNull(retrieved.Map);
            Assert.AreEqual(0, retrieved.Map.Count);
        }

        private async Task TestEnumHashKeyObjects()
        {
            // Create and save item
            EnumProduct1 product1 = new EnumProduct1
            {
                Id = Status.Upcoming,
                Name = "CloudSpotter"
            };
            await Context.SaveAsync(product1);

            EnumProduct2 product2 = new EnumProduct2
            {
                Id = Status.Removed,
                Name = "CloudSpotter"
            };
            await Context.SaveAsync(product2);

            var rt1 = await Context.LoadAsync(product1);
            Assert.AreEqual(product1.Id, rt1.Id);
            Assert.AreEqual(product1.IdAsInt, rt1.IdAsInt);

            var rt2 = await Context.LoadAsync(product2);
            Assert.AreEqual(product2.Id, rt2.Id);

            await Context.DeleteAsync(product1);
            await Context.DeleteAsync(product2);
        }

        private async Task TestHashObjects()
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

                product.FullProductDescription =
                    S3Link.Create(Context, bucketName, "my-product", Amazon.RegionEndpoint.USEast1);
                product.FullProductDescription.UploadStream(
                    new MemoryStream(UTF8Encoding.UTF8.GetBytes("Lots of data")));

                await Context.SaveAsync(product);

                // Test conversion
                var doc = Context.ToDocument(product);
                Assert.IsNotNull(doc["Tags"].AsPrimitiveList());
                Assert.IsTrue(
                    doc["Components"].AsPrimitiveList() != null ||
                    doc["Components"].AsDynamoDBList() != null);
                Assert.IsNotNull(doc["CompanyInfo"].AsDocument());
                Assert.IsNotNull(doc["Supports"]);

                // Load item
                Product retrieved = await Context.LoadAsync<Product>(1);
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
                Assert.AreEqual(product.CompanyInfo.Founded.ToUniversalTime(), retrieved.CompanyInfo.Founded);
                Assert.AreNotEqual(product.CompanyInfo.Revenue, retrieved.CompanyInfo.Revenue);
                Assert.AreEqual(product.CompanyInfo.AllProducts.Count, retrieved.CompanyInfo.AllProducts.Count);
                Assert.AreEqual(product.CompanyInfo.AllProducts[0].Id, retrieved.CompanyInfo.AllProducts[0].Id);
                Assert.AreEqual(product.CompanyInfo.AllProducts[1].Id, retrieved.CompanyInfo.AllProducts[1].Id);
                Assert.AreEqual(product.CompanyInfo.FeaturedProducts.Length,
                    retrieved.CompanyInfo.FeaturedProducts.Length);
                Assert.AreEqual(product.CompanyInfo.FeaturedProducts[0].Id,
                    retrieved.CompanyInfo.FeaturedProducts[0].Id);
                Assert.AreEqual(product.CompanyInfo.FeaturedProducts[1].Id,
                    retrieved.CompanyInfo.FeaturedProducts[1].Id);
                Assert.AreEqual(product.CompanyInfo.FeaturedBrands.Length, retrieved.CompanyInfo.FeaturedBrands.Length);
                Assert.AreEqual(product.CompanyInfo.FeaturedBrands[0], retrieved.CompanyInfo.FeaturedBrands[0]);
                Assert.AreEqual(product.CompanyInfo.FeaturedBrands[1], retrieved.CompanyInfo.FeaturedBrands[1]);
                Assert.AreEqual(product.Map.Count, retrieved.Map.Count);
                Assert.AreEqual(product.CompanyInfo.CompetitorProducts.Count,
                    retrieved.CompanyInfo.CompetitorProducts.Count);

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
                using (var stream = retrieved.FullProductDescription.OpenStream())
                using (var reader = new StreamReader(stream))
                {
                    Assert.AreEqual("Lots of data", reader.ReadToEnd());
                }

                // Try saving circularly-referencing object
                product.CompanyInfo.AllProducts.Add(product);
                await Assert.ThrowsExceptionAsync<InvalidOperationException>(() => Context.SaveAsync(product));
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
                await Context.SaveAsync(product);

                // Load new item
                retrieved = await Context.LoadAsync(product);
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
                IEnumerable<Product> products = await Context.ScanAsync<Product>(new List<ScanCondition>()).GetRemainingAsync();
                foreach (var p in products)
                {
                    productIds.Add(p.Id);
                }
                Assert.AreEqual(2, productIds.Count);

                // Load first product
                var firstId = productIds[0];
                product = await Context.LoadAsync<Product>(firstId);
                Assert.IsNotNull(product);
                Assert.AreEqual(firstId, product.Id);

                // Query GlobalIndex
                products = await Context.QueryAsync<Product>(
                    product.CompanyName, // Hash-key for the index is Company
                    QueryOperator.GreaterThan, // Range-key for the index is Price, so the
                    new object[] { 90 }, // condition is against a numerical value
                    new QueryConfig // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                    })
                    .GetNextSetAsync();
                Assert.AreEqual(2, products.Count());

                // Query GlobalIndex with an additional non-key condition
                products = await Context.QueryAsync<Product>(
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
                Assert.AreEqual(1, products.Count());

                // Delete first product
                await Context.DeleteAsync<Product>(firstId);
                product = await Context.LoadAsync<Product>(product.Id);
                Assert.IsNull(product);

                // Scan the table
                products = await Context.ScanAsync<Product>(new List<ScanCondition>()).GetRemainingAsync();
                Assert.AreEqual(1, products.Count());

                // Scan the table with consistent read
                products = await Context.ScanAsync<Product>(
                    new ScanCondition[] { },
                    new ScanConfig { ConsistentRead = true }
                ).GetRemainingAsync();
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
                await Context.SaveAsync(vp);

                // Update and save
                vp.Price++;
                await Context.SaveAsync(vp);

                // Alter the version and try to save
                vp.Version = 0;
                await Assert.ThrowsExceptionAsync<ConditionalCheckFailedException>(() => Context.SaveAsync(vp));

                // Load and save
                vp = await Context.LoadAsync(vp);
                await Context.SaveAsync(vp);
            }
            finally
            {
                await Amazon.S3.Util.AmazonS3Util.DeleteS3BucketWithObjectsAsync(s3Client, bucketName);
            }
        }

        private async Task TestHashRangeObjects<T>() where T : Employee, new()
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
            await Context.SaveAsync(employee);

            // Load item
            T retrieved = await Context.LoadAsync(employee);
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
            await Context.SaveAsync(employee);

            // Load item
            retrieved = await Context.LoadAsync(employee);
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
            await Context.SaveAsync(employee2);
            employee2.Age = 24;
            employee2.Score = 101;
            await Context.SaveAsync(employee2);

            retrieved = await Context.LoadAsync<T>("Alan", 31);
            Assert.AreEqual(retrieved.Name, "Alan");
            retrieved = await Context.LoadAsync(employee);
            Assert.AreEqual(retrieved.Name, "Chuck");
            retrieved = await Context.LoadAsync(employee2, new LoadConfig { ConsistentRead = true });
            Assert.AreEqual(retrieved.Name, "Diane");
            Assert.AreEqual(retrieved.Age, 24);

            // Scan for all items
            var employees = await Context.ScanAsync<T>(new List<ScanCondition>()).GetRemainingAsync();
            Assert.AreEqual(4, employees.Count);

            // Query for items with Hash-Key = "Diane"
            employees = await Context.QueryAsync<T>("Diane").GetNextSetAsync();
            Assert.AreEqual(2, employees.Count);

            // Query for items with Hash-Key = "Diane" and Range-Key > 30
            employees = await Context.QueryAsync<T>("Diane", QueryOperator.GreaterThan, new object[] { 30 }).GetNextSetAsync();
            Assert.AreEqual(1, employees.Count);

            // Index Query
            // Query local index for items with Hash-Key = "Diane"
            employees = await Context.QueryAsync<T>("Diane", new QueryConfig { IndexName = "LocalIndex" }).GetNextSetAsync();
            Assert.AreEqual(2, employees.Count);

            // Query local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await Context.QueryAsync<T>(
                "Diane",
                QueryOperator.Equal,
                new object[] { "Eva" },
                new QueryConfig { IndexName = "LocalIndex" }
            ).GetNextSetAsync();
            Assert.AreEqual(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River"
            employees = await Context.QueryAsync<T>("Big River", new QueryConfig { IndexName = "GlobalIndex" }).GetNextSetAsync();
            Assert.AreEqual(2, employees.Count);

            // Query global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await Context.QueryAsync<T>("Big River",
                new QueryConfig
                {
                    IndexName = "GlobalIndex",
                    QueryFilter = new List<ScanCondition>
                    {
                        new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                    }
                }).GetNextSetAsync();
            Assert.AreEqual(1, employees.Count);

            // Index Scan
            // Scan local index for items with Hash-Key = "Diane"
            employees = await Context.ScanAsync<T>(
                new List<ScanCondition> { new ScanCondition("Name", ScanOperator.Equal, "Diane") },
                new ScanConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.AreEqual(2, employees.Count);

            // Scan local index for items with Hash-Key = "Diane" and Range-Key = "Eva"
            employees = await Context.ScanAsync<T>(
                new List<ScanCondition>
                {
                    new ScanCondition("Name", ScanOperator.Equal, "Diane"),
                    new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
                },
                new ScanConfig { IndexName = "LocalIndex" }).GetRemainingAsync();
            Assert.AreEqual(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River"
            employees = await Context.ScanAsync<T>(
                new List<ScanCondition> { new ScanCondition("CompanyName", ScanOperator.Equal, "Big River") },
                new ScanConfig { IndexName = "GlobalIndex" }).GetRemainingAsync();
            Assert.AreEqual(2, employees.Count);

            // Scan global index for item with Hash-Key (Company) = "Big River", with QueryFilter for CurrentStatus = Status.Active
            employees = await Context.ScanAsync<T>(
                new List<ScanCondition>
                {
                    new ScanCondition("CompanyName", ScanOperator.Equal, "Big River"),
                    new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active)
                },
                new ScanConfig
                {
                    IndexName = "GlobalIndex"
                }).GetRemainingAsync();
            Assert.AreEqual(1, employees.Count);
        }

        private async Task TestBatchOperations()
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
            await multiTableWrite.ExecuteAsync();

            // Create BatchGets
            var batchGet1 = Context.CreateBatchGet<Product>();
            var batchGet2 = Context.CreateBatchGet<Employee>();
            for (int i = 0; i < itemCount; i++)
                batchGet1.AddKey(productIdStart + i, productPrefix + i);
            foreach (var employee in allEmployees)
                batchGet2.AddKey(employee);

            // Execute BatchGets together
            await Context.ExecuteBatchGetAsync(batchGet1, batchGet2);

            // Verify items are loaded
            Assert.AreEqual(itemCount, batchGet1.Results.Count);
            Assert.AreEqual(itemCount, batchGet2.Results.Count);
        }

        private async Task TestTransactionOperations()
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
                await transactGet.ExecuteAsync();

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
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

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
                await transactGet.ExecuteAsync();

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
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

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
                await transactGet.ExecuteAsync();

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
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
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
                await transactGet.ExecuteAsync();

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
                await transactWrite.ExecuteAsync();

                Assert.AreEqual(originalVersion1 + 1, employee1.Version);
                Assert.AreEqual(originalVersion2, employee2.Version);
                Assert.AreEqual(originalVersion3, employee3.Version);
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

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

                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());
                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(2, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[1].Code);
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2 });
                await transactGet.ExecuteAsync();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(2, transactGet.Results.Count);
                Assert.AreEqual(employee1.Name, transactGet.Results[0].Name);
                Assert.AreEqual(employee1.Score, transactGet.Results[0].Score);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Name, transactGet.Results[1].Name);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);
            }

            {
                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
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
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2 });
                await transactGet.ExecuteAsync();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(2, transactGet.Results.Count);
                Assert.AreEqual(employee1.Name, transactGet.Results[0].Name);
                Assert.AreEqual(employee1.Score + 1, transactGet.Results[0].Score);
                Assert.AreEqual(employee1.Version, transactGet.Results[0].Version);
                Assert.AreEqual(employee2.Name, transactGet.Results[1].Name);
                Assert.AreEqual(employee2.Score + 2, transactGet.Results[1].Score);
                Assert.AreEqual(employee2.Version, transactGet.Results[1].Version);

                employee1.Score++;
                employee2.Score += 2;
            }

            {
                var transactWrite = Context.CreateTransactWrite<VersionedEmployee>();
                transactWrite.AddDeleteItem(employee1);
                transactWrite.AddDeleteKey(employee2.Name, employee2.Age);
                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedEmployee>();
                transactGet.AddKeys(new List<VersionedEmployee> { employee1, employee2, employee3 });
                await transactGet.ExecuteAsync();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(0, transactGet.Results.Count);
            }
        }

        private async Task TestAnnotatedTransactionOperations()
        {
            var employee1 = new VersionedAnnotatedEmployee
            {
                Name = "Mark",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };
            var employee2 = new VersionedAnnotatedEmployee
            {
                Name = "Helena",
                Age = 25,
                Score = 140
            };
            var employee3 = new VersionedAnnotatedEmployee
            {
                Name = "Irving",
                Age = 55,
                Score = 100
            };

            {
                var transactWrite = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                transactWrite.AddSaveItems(new List<VersionedAnnotatedEmployee> { employee1, employee2 });
                transactWrite.AddSaveItem(employee3);
                await transactWrite.ExecuteAsync();

                Assert.IsNotNull(employee1.Version);
                Assert.IsNotNull(employee2.Version);
                Assert.IsNotNull(employee3.Version);
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                transactGet.AddKeys(new List<VersionedAnnotatedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

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

                var transactWrite = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckKey(employee2.Name, employee2.Age, employee2.Version);
                transactWrite.AddDeleteItem(employee3);
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual("None", ex.CancellationReasons[2].Code);

                employee1.Version = originalVersion;
                employee1.Score--;
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                transactGet.AddKey(employee1);
                transactGet.AddKeys(new List<VersionedAnnotatedEmployee> { employee2, employee3 });
                await transactGet.ExecuteAsync();

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

                var transactWrite = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckItem(employee2);
                transactWrite.AddDeleteItem(employee3);
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[1].Code);
                Assert.AreEqual("None", ex.CancellationReasons[2].Code);

                employee1.Score--;
                employee2.Version--;
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                transactGet.AddKeys(new List<VersionedAnnotatedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

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

                var transactWrite = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckKey(employee2.Name, employee2.Age, employee2.Version);
                transactWrite.AddDeleteItem(employee3);
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => transactWrite.ExecuteAsync());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[2].Code);

                employee1.Score--;
                employee3.Version++;
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                transactGet.AddKey(employee1);
                transactGet.AddKeys(new List<VersionedAnnotatedEmployee> { employee2, employee3 });
                await transactGet.ExecuteAsync();

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

                var transactWrite = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                transactWrite.AddSaveItem(employee1);
                transactWrite.AddVersionCheckItem(employee2);
                transactWrite.AddDeleteItem(employee3);
                await transactWrite.ExecuteAsync();

                Assert.AreEqual(originalVersion1 + 1, employee1.Version);
                Assert.AreEqual(originalVersion2, employee2.Version);
                Assert.AreEqual(originalVersion3, employee3.Version);
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                transactGet.AddKeys(new List<VersionedAnnotatedEmployee> { employee1, employee2 });
                transactGet.AddKey(employee3.Name, employee3.Age);
                await transactGet.ExecuteAsync();

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
                var transactWrite = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                transactWrite.AddDeleteItem(employee1);
                transactWrite.AddDeleteKey(employee2.Name, employee2.Age);
                await transactWrite.ExecuteAsync();
            }

            {
                var transactGet = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                transactGet.AddKeys(new List<VersionedAnnotatedEmployee> { employee1, employee2, employee3 });
                await transactGet.ExecuteAsync();

                Assert.IsNotNull(transactGet.Results);
                Assert.AreEqual(0, transactGet.Results.Count);
            }
        }

        private async Task TestMultiTableTransactionOperations()
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
                await tran.ExecuteAsync();

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
                await tran.ExecuteAsync();

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
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => tran.ExecuteAsync());

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
                await tran.ExecuteAsync();

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
                await tran.ExecuteAsync();

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
                await tran.ExecuteAsync();

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
                await tran.ExecuteAsync();
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.IsNotNull(employeeTran.Results);
                Assert.AreEqual(0, employeeTran.Results.Count);
                Assert.IsNotNull(productTran.Results);
                Assert.AreEqual(0, productTran.Results.Count);
            }
        }

        private async Task TestAnnotatedMultiTableTransactionOperations()
        {
            var employee1 = new VersionedAnnotatedEmployee
            {
                Name = "Alan",
                Age = 31,
                Score = 120,
                ManagerName = "Barbara"
            };
            var employee2 = new VersionedAnnotatedEmployee
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
                var employeeTran = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                employeeTran.AddSaveItems(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddSaveItem(product);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.IsNotNull(employee1.Version);
                Assert.IsNotNull(employee2.Version);
                Assert.IsNotNull(product.Version);
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product.Id);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

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

                var employeeTran = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                employeeTran.AddSaveItem(employee1);
                employeeTran.AddDeleteItem(employee2);
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddVersionCheckKey(product.Id, product.Version.Value + 1);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                var ex = await Assert.ThrowsExceptionAsync<TransactionCanceledException>(() => tran.ExecuteAsync());

                Assert.IsNotNull(ex.CancellationReasons);
                Assert.AreEqual(3, ex.CancellationReasons.Count);
                Assert.AreEqual("None", ex.CancellationReasons[0].Code);
                Assert.AreEqual("None", ex.CancellationReasons[1].Code);
                Assert.AreEqual("ConditionalCheckFailed", ex.CancellationReasons[2].Code);

                employee1.Score--;
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

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

                var employeeTran = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                employeeTran.AddSaveItem(employee1);
                employeeTran.AddDeleteItem(employee2);
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddVersionCheckItem(product);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.AreEqual(originalEmployeeVersion1 + 1, employee1.Version);
                Assert.AreEqual(originalEmployeeVersion2, employee2.Version);
                Assert.AreEqual(originalProductVersion, product.Version);
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product.Id);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

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
                var employeeTran = Context.CreateTransactWrite<VersionedAnnotatedEmployee>();
                employeeTran.AddDeleteItem(employee1);
                var productTran = Context.CreateTransactWrite<VersionedProduct>();
                productTran.AddDeleteKey(product.Id);
                var tran = Context.CreateMultiTableTransactWrite(employeeTran, productTran);
                await tran.ExecuteAsync();
            }

            {
                var employeeTran = Context.CreateTransactGet<VersionedAnnotatedEmployee>();
                employeeTran.AddKeys(new[] { employee1, employee2 });
                var productTran = Context.CreateTransactGet<VersionedProduct>();
                productTran.AddKey(product);
                var tran = Context.CreateMultiTableTransactGet(employeeTran, productTran);
                await tran.ExecuteAsync();

                Assert.IsNotNull(employeeTran.Results);
                Assert.AreEqual(0, employeeTran.Results.Count);
                Assert.IsNotNull(productTran.Results);
                Assert.AreEqual(0, productTran.Results.Count);
            }
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
            await Context.DeleteAsync(employee1);
            await Context.SaveAsync(employee1);

            // Get record using Table instead of Context
            var table = Context.GetTargetTable<Employee>();
            Document retrieved = await table.GetItemAsync(doc);
            Assert.AreEqual(employee1.Name, doc["Name"].AsString());
            Assert.AreEqual(employee1.Data.Length, doc["Data"].AsByteArray().Length);
        }

        private ModelA CreateNestedTypeItem(out Guid id)
        {
            var a1 = new A { Name = "A1", MyPropA = 1 };
            var b1 = new B { Name = "B1", MyPropA = 2, MyPropB = 3 };

            id = Guid.NewGuid();

            var model = new ModelA1
            {
                Id = id,
                MyType = b1,
                MyInterface = new InterfaceA()
                {
                    S1 = "s1",
                    S2 = 2,
                    S3 = 3
                },
                MyClasses = new List<A> { a1, b1 },
                FlatAddress = new Address()
                {
                    City = "Seattle",
                    Street = "Street"
                }
            };
            return model;
        }

        #region OPM definitions

        // Helper classes for the integration test

        [DynamoDBTable("HashTable")]
        public class ProductFlatWithTimestamp
        {
            [DynamoDBHashKey] public int Id { get; set; }
            [DynamoDBFlatten] public ProductDetailsWithTimestamp Details { get; set; }
            public string Name { get; set; }
        }

        public class ProductDetailsWithTimestamp
        {
            [DynamoDBVersion] public int? Version { get; set; }
            [DynamoDBAutoGeneratedTimestamp] public DateTime? CreatedAt { get; set; }
            public string Description { get; set; }
            [DynamoDBProperty("DetailsName")] public string Name { get; set; }
        }

        [DynamoDBTable("HashRangeTable")]
        public class EmployeeWithTimestampAndCounter : AnnotatedEmployee
        {
            [DynamoDBAutoGeneratedTimestamp] public DateTime? LastUpdated { get; set; }
            [DynamoDBAtomicCounter] public int? CountDefault { get; set; }
        }

        [DynamoDBTable("HashTable")]
        public class ProductWithCreateTimestamp
        {
            [DynamoDBHashKey] public int Id { get; set; }
            public string Name { get; set; }
            [DynamoDBAutoGeneratedTimestamp]
            public DateTime? CreatedAt { get; set; }
        }

        [DynamoDBTable("HashTable")]
        public class AutoGenTimestampEpochEntity
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            public string Name { get; set; }

            [DynamoDBAutoGeneratedTimestamp]
            [DynamoDBProperty(StoreAsEpoch = true)]
            public DateTime? CreatedAt { get; set; }
        }

        [DynamoDBTable("HashTable")]
        public class AutoGenTimestampEpochLongEntity
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            public string Name { get; set; }

            [DynamoDBAutoGeneratedTimestamp]
            [DynamoDBProperty(StoreAsEpochLong = true)]
            public DateTime? CreatedAt { get; set; }
        }

        public enum Status : long
        {
            Active = 256,
            Inactive = 1024,
            Upcoming = 9999,
            Obsolete = -10,
            Removed = 42
        }

        [Flags]
        public enum Support
        {
            Windows = 1 << 0,
            iOS = 1 << 1,
            Unix = 1 << 2,
            Abacus = 1 << 3,
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

        [DynamoDBTable("HashTable", false, ConversionSchema.V2)]
        public class ProductV2 : Product
        {
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class Product
        {
            [DynamoDBHashKey] public int Id { get; set; }

            [DynamoDBProperty("Product")] public string Name { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            public CompanyInfo CompanyInfo { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Price { get; set; }

            [DynamoDBProperty("Tags")] public HashSet<string> TagSet { get; set; }

            public MemoryStream Data { get; set; }

            [DynamoDBProperty(Converter = typeof(StatusConverter))]
            public Status CurrentStatus { get; set; }

            public Status FormerStatus { get; set; }

            public Support Supports { get; set; }

            public Support? PreviousSupport { get; set; }

            [DynamoDBIgnore] public string InternalId { get; set; }

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

            [DynamoDBIgnore] public decimal Revenue { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedProduct : Product
        {
            [DynamoDBVersion] public int? Version { get; set; }
        }

        // Flattened scenario classes
        [DynamoDBTable("HashTable")]
        public class ProductFlatWithAtomicCounter
        {
            [DynamoDBHashKey] public int Id { get; set; }
            [DynamoDBFlatten] public ProductDetailsWithAtomicCounter Details { get; set; }
            public string Name { get; set; }
        }

        public class ProductDetailsWithAtomicCounter
        {
            [DynamoDBVersion]
            public int? Version { get; set; }
            [DynamoDBAtomicCounter]
            public int? CountDefault { get; set; }
            [DynamoDBAtomicCounter(delta: 2, startValue: 10)] 
            public int? CountAtomic { get; set; }
            public string Description { get; set; }
            [DynamoDBProperty("DetailsName")] 
            public string Name { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable,
        /// with the Id field being an Enum, with hidden int conversion
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class EnumProduct1
        {
            [DynamoDBIgnore] public Status Id { get; set; }

            [DynamoDBHashKey("Id")]
            public int IdAsInt
            {
                get { return (int)Id; }
                set { Id = (Status)value; }
            }

            [DynamoDBProperty("Product")] public string Name { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable,
        /// with the Id field being an Enum
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class EnumProduct2
        {
            public Status Id { get; set; }

            [DynamoDBProperty("Product")] public string Name { get; set; }
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
            internal virtual int Age { get; set; }

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
            [DynamoDBHashKey] public override string Name { get; set; }

            // Range key
            [DynamoDBRangeKey] internal override int Age { get; set; }

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
            [DynamoDBHashKey] public override string Name { get; set; }

            // Range key
            [DynamoDBRangeKey] internal override int Age { get; set; }

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
        /// Annotated class with a property of a type that has no valid constructor
        /// </summary>
        public class Employee4 : AnnotatedEmployee
        {
            public TimeSpan TimeWithCompany { get; set; }
        }

        /// <summary>
        /// Annotated class with a property of an empty type
        /// </summary>
        public class Employee5 : AnnotatedEmployee
        {
            public EmptyType EmptyProperty { get; set; }
        }

        /// <summary>
        /// Empty type
        /// </summary>
        public class EmptyType
        {
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedEmployee : Employee
        {
            public int? Version { get; set; }
        }

        public class CounterAnnotatedEmployee : AnnotatedEmployee
        {
            [DynamoDBAtomicCounter] 
            public int? CountDefault { get; set; }

            [DynamoDBAtomicCounter(delta:2, startValue:10)] 
            public int? CountAtomic { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// This class uses optimistic locking via the Version field
        /// </summary>
        public class VersionedAnnotatedEmployee : CounterAnnotatedEmployee
        {
            [DynamoDBVersion] public int? Version { get; set; }
        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]HashTable
        /// Two fields are being stored as epoch seconds, two are not.
        /// </summary>
        public class EpochEmployee : Employee
        {
            [DynamoDBProperty(StoreAsEpoch = true)]
            public virtual DateTime CreationTime { get; set; }

            [DynamoDBProperty(StoreAsEpoch = true)]
            public DateTime EpochDate2 { get; set; }

            [DynamoDBProperty(StoreAsEpoch = false)]
            public DateTime NonEpochDate1 { get; set; }

            public DateTime NonEpochDate2 { get; set; }

            [DynamoDBProperty(StoreAsEpoch = true)]
            public DateTime? NullableEpochDate1 { get; set; }

            [DynamoDBProperty(StoreAsEpoch = true)]
            public DateTime? NullableEpochDate2 { get; set; }

            [DynamoDBProperty(StoreAsEpochLong = true)]
            public DateTime LongEpochDate1 { get; set; }

            [DynamoDBProperty(StoreAsEpochLong = true)]
            public DateTime LongEpochDate2 { get; set; }

            [DynamoDBProperty(StoreAsEpochLong = true)]
            public DateTime? NullableLongEpochDate1 { get; set; }

            [DynamoDBProperty(StoreAsEpochLong = true)]
            public DateTime? NullableLongEpochDate2 { get; set; }
        }

        /// <summary>
        /// Annotated class representing items in the table [TableNamePrefix]HashTable
        /// Two fields are being stored as epoch seconds, two are not.
        /// </summary>
        [DynamoDBTable("NumericHashRangeTable")]
        public class AnnotatedEpochEmployee
        {
            [DynamoDBRangeKey] public string Name { get; set; }

            public int Age { get; set; }

            // Hash key
            [DynamoDBHashKey(StoreAsEpoch = true)] public virtual DateTime CreationTime { get; set; }

            [DynamoDBProperty(StoreAsEpoch = true)]
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
        /// Class representing items in the table [TableNamePrefix]NumericHashRangeTable.
        /// </summary>
        [DynamoDBTable("NumericHashRangeTable")]
        public class AnnotatedNumEpochEmployee : AnnotatedEpochEmployee
        {

        }

        /// <summary>
        /// Class representing items in the table [TableNamePrefix]NumericHashRangeTable.
        /// </summary>
        [DynamoDBTable("BadEmployeeHashRangeTable")]
        public class BadNumericEpochEmployee : NumericEpochEmployee
        {
            [DynamoDBProperty(StoreAsEpoch = true, StoreAsEpochLong = true)]
            public DateTime BadLongEpochDate { get; set; }
        }

        /// <summary>
        /// Same structure as <see cref="NumericEpochEmployee"/>, but the Hash key is annotated
        /// </summary>
        [DynamoDBTable("NumericHashRangeTable")]
        public class AnnotatedNumericEpochEmployee : EpochEmployee
        {
            [DynamoDBHashKey(StoreAsEpoch = true)] public override DateTime CreationTime { get; set; }

            [DynamoDBRangeKey] public override string Name { get; set; }
        }

        /// <summary>
        /// Table with a property converter on range key.
        /// </summary>
        [DynamoDBTable("NumericHashRangeTable")]
        public class PropertyConverterEmployee
        {
            [DynamoDBHashKey(StoreAsEpoch = true)] public DateTime CreationTime { get; set; }

            [DynamoDBRangeKey]
            [DynamoDBProperty(Converter = typeof(EnumAsStringConverter<Status>))]
            public Status Name { get; set; }
        }

        [DynamoDBTable("HashRangeTable")]
        public class AnnotatedRangeTable
        {
            // Hash key
            [DynamoDBHashKey] public string Name { get; set; }

            // Range key
            [DynamoDBRangeKey] internal int Age { get; set; }
        }

        [DynamoDBTable("HashRangeTable")]
        public class IgnoreAnnotatedRangeTable : AnnotatedRangeTable
        {
            [DynamoDBIgnore] internal int IgnoreAttribute { get; set; }
        }


        [DynamoDBTable("HashRangeTable")]
        public class AnnotatedRangeTable2 : AnnotatedRangeTable
        {
            internal int NotAnnotatedAttribute { get; set; }
        }

        /// <summary>
        /// Table with a property converter.
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class PropertyConvertorTable
        {
            [DynamoDBHashKey] 
            public int Id { get; set; }

            public string PropertyWithGlobalConvertor { get; set; }

            [DynamoDBProperty(Converter = typeof(StringToLowerConverter))]
            public string PropertyWithPropertyConvertor { get; set; }
        }

        public class DateTimeUtcConverter : IPropertyConverter
        {
            public DynamoDBEntry ToEntry(object value) => (DateTime)value;

            public object FromEntry(DynamoDBEntry entry)
            {
                var dateTime = entry.AsDateTime();
                return dateTime.ToUniversalTime();
            }
        }

        public class EnumAsStringConverter<T> : IPropertyConverter where T : struct
        {
            public DynamoDBEntry ToEntry(object value)
            {
                return new Primitive(value.ToString());
            }

            public object FromEntry(DynamoDBEntry entry)
            {
                return Enum.Parse(typeof(T), entry.AsString());
            }
        }

        public class StringToLowerConverter : IPropertyConverter
        {
            public DynamoDBEntry ToEntry(object value)
            {
                return new Primitive(value.ToString().ToLower());
            }

            public object FromEntry(DynamoDBEntry entry)
            {
                Primitive primitive = entry.AsPrimitive();
                string text = primitive.AsString();
                return text.ToLower();
            }
        }

        public class StringToUpperConverter : IPropertyConverter
        {
            public DynamoDBEntry ToEntry(object value)
            {
                return new Primitive(value.ToString().ToUpper());
            }

            public object FromEntry(DynamoDBEntry entry)
            {
                Primitive primitive = entry.AsPrimitive();
                string text = primitive.AsString();
                return text.ToUpper();
            }
        }

        #region Flatten

        /// <summary>
        /// A class has a flattened property, and the version attribute is on the flattened child.
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class ProductFlat
        {
            [DynamoDBHashKey] public int Id { get; set; }

            [DynamoDBFlatten]
            public ProductDetails Details { get; set; }

            public string Name { get; set; }
        }

        public class ProductDetails
        {
            [DynamoDBVersion]
            public int? Version { get; set; }

            public string Description { get; set; }

            [DynamoDBProperty("DetailsName")]
            public string Name { get; set; }
        }

        /// <summary>
        /// A class has a flattened property, which itself contains another flattened property.
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class EmployeeNonFlat
        {
            [DynamoDBHashKey("Id")]
            public int EmployeeId { get; set; }

            [DynamoDBFlatten]
            public ContactInfo Contact { get; set; }
        }

        public class ContactInfo
        {
            public string Email { get; set; }

            [DynamoDBFlatten]
            public Address Address { get; set; }
        }

        /// <summary>
        /// A class has a flattened structure
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class EmployeeFlatten
        {
            [DynamoDBHashKey("Id")]
            public int EmployeeId { get; set; }

            public string Email { get; set; }

            public string Street { get; set; }

            public string City { get; set; }
        }

        [DynamoDBTable("HashTable")]
        public class Order
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            [DynamoDBFlatten]
            public PaymentInfo Payment { get; set; }

            public string CompanyInfo { get; set; }
        }

        public class PaymentInfo
        {
            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Price { get; set; }
        }

        /// <summary>
        /// A flattened property contains a property with a custom converter.
        /// </summary>
        [DynamoDBTable("HashTable")]
        public class Event
        {
            [DynamoDBHashKey]
            public int Id { get; set; }

            [DynamoDBFlatten]
            public EventDetails Details { get; set; }
        }

        public class EventDetails
        {
            [DynamoDBProperty(typeof(DateTimeUtcConverter))]
            public DateTime EventDate { get; set; }
        }


        #endregion

        #region PolymorphicType

        [DynamoDBPolymorphicType("B1", typeof(B))]
        [DynamoDBPolymorphicType("C", typeof(C))]
        public class A
        {
            public string Name { get; set; }

            public int MyPropA { get; set; }
        }

        public interface IInterface
        {
            string S1 { get; set; }
            int S2 { get; set; }
        }

        public class InterfaceA : IInterface
        {
            public string S1 { get; set; }
            public int S2 { get; set; }

            public int S3 { get; set; }
        }

        public class InterfaceB : IInterface
        {
            public string S1 { get; set; }
            public int S2 { get; set; }
            public string S4 { get; set; }
        }

        public class B : A
        {
            public int MyPropB { get; set; }
        }

        public class C : A
        {
            public string MyPropC { get; set; }
        }

        [DynamoDBTable("NestedTable")]
        [DynamoDBPolymorphicType("A1", typeof(ModelA1))]
        [DynamoDBPolymorphicType("A2", typeof(ModelA2))]
        public class ModelA
        {
            [DynamoDBHashKey] public Guid Id { get; set; }

            public A MyType { get; set; }

            [DynamoDBPolymorphicType("I1", typeof(InterfaceA))]
            [DynamoDBPolymorphicType("I2", typeof(InterfaceB))]
            public IInterface MyInterface { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
            public string CompanyName { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
            public int Price { get; set; }

            [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex", AttributeName = "Manager")]
            public string ManagerName { get; set; }

            [DynamoDBFlatten] public Address FlatAddress { get; set; }
        }

        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
        }

        public class ModelA1 : ModelA
        {
            [DynamoDBPolymorphicType("B", typeof(B))]
            public new A MyType { get; set; }

            [DynamoDBPolymorphicType("B", typeof(B))]
            [DynamoDBProperty("test")]
            public List<A> MyClasses { get; set; }
        }

        public class ModelA2 : ModelA
        {
            [DynamoDBPolymorphicType("B", typeof(B))]
            public Dictionary<string, A> DictionaryClasses { get; set; }
        }

        #endregion

        [DynamoDBTable("CompositeHashRangeTable")]
        public class CompositeHashRangeEntity
        {
            [DynamoDBHashKey]
            [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 1)]
            public int Id { get; set; }

            [DynamoDBRangeKey]
            [DynamoDBGlobalSecondaryIndexRangeKey("GSI3", Order = 1)]
            [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 1)]
            public string Status { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GSI1")]
            [DynamoDBGlobalSecondaryIndexHashKey("GSI3", Order = 1)]
            [DynamoDBGlobalSecondaryIndexHashKey("GSI2", Order = 2)]
            [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 2)]
            public string UserName { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GSI1")]
            [DynamoDBGlobalSecondaryIndexRangeKey("GSI2")]
            public int Timestamp { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GSI2", Order = 1)]
            [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 3)]
            public string OrderId { get; set; }

            [DynamoDBGlobalSecondaryIndexHashKey("GSI3", Order = 2)]
            [DynamoDBGlobalSecondaryIndexHashKey("GSI4", Order = 4)]
            public string Region { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GSI3", Order = 2)]
            [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 2)]
            public string Category { get; set; }


            [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 3)]
            public int Amount { get; set; }

            [DynamoDBGlobalSecondaryIndexRangeKey("GSI4", Order = 4)]
            public int Priority { get; set; }
        }

        #endregion
    }
}
