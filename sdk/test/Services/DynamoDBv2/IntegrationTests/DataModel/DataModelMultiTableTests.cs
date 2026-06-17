using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using static AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DataModelContextTestHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DataModelMultiTableTests : IClassFixture<DataModelTablesFixture>, IAsyncLifetime
    {
        private readonly DataModelTablesFixture _fixture;
        private DynamoDBContext _context;
        public DataModelMultiTableTests(DataModelTablesFixture fixture)
        {
            _fixture = fixture;
        }

        public async ValueTask InitializeAsync()
        {
            _context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V1;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = true;
                    x.DisableFetchingTableMetadata = false;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build();
            await _fixture.CleanupTables();
        }

        public ValueTask DisposeAsync()
        {
            _context?.Dispose();
            return default;
        }

        [Fact]
        public async Task TestContext_AtomicCounterAnnotation()
        {
            // Initial save
            CounterAnnotatedEmployee employee = new CounterAnnotatedEmployee
            {
                Name = "Mark",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };

            await _context.SaveAsync(employee);
            var storedEmployee = await _context.LoadAsync<CounterAnnotatedEmployee>(employee.Name, 31);
            Assert.NotNull(storedEmployee);
            Assert.Equal(employee.Name, storedEmployee.Name);
            Assert.Equal(0, storedEmployee.CountDefault);
            Assert.Equal(10, storedEmployee.CountAtomic);

            // Simulate external update: increment counters by saving again
            storedEmployee.CountDefault = null; // Let the context increment
            storedEmployee.CountAtomic = null;
            await _context.SaveAsync(storedEmployee);

            var externallyUpdated = await _context.LoadAsync<CounterAnnotatedEmployee>(employee.Name, 31);
            Assert.Equal(1, externallyUpdated.CountDefault);
            Assert.Equal(12, externallyUpdated.CountAtomic);

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
            await _context.SaveAsync(stalePoco);

            // After save, the POCO should be updated to the latest value
            Assert.Equal(2, stalePoco.CountDefault);
            Assert.Equal(14, stalePoco.CountAtomic);

            // Confirm with a fresh load
            var latest = await _context.LoadAsync<CounterAnnotatedEmployee>(employee.Name, 31);
            Assert.Equal(2, latest.CountDefault);
            Assert.Equal(14, latest.CountAtomic);

            VersionedAnnotatedEmployee versionedAnnotatedEmployee = new VersionedAnnotatedEmployee
            {
                Name = "MarkV1",
                Age = 31,
                Score = 120,
                ManagerName = "Harmony"
            };

            await _context.SaveAsync(versionedAnnotatedEmployee);
            var storedVersionEmployee = await _context.LoadAsync<VersionedAnnotatedEmployee>(versionedAnnotatedEmployee.Name, 31);
            Assert.NotNull(storedVersionEmployee);
            Assert.Equal(0, storedVersionEmployee.Version);
            Assert.Equal(0, storedVersionEmployee.CountDefault);
            Assert.Equal(10, storedVersionEmployee.CountAtomic);

            // Update the employee
            versionedAnnotatedEmployee.ManagerName = "Helena";
            await _context.SaveAsync(versionedAnnotatedEmployee);
            var storedUpdatedEmployee = await _context.LoadAsync<VersionedAnnotatedEmployee>(versionedAnnotatedEmployee.Name, 31);
            Assert.NotNull(storedUpdatedEmployee);
            Assert.Equal(1, storedUpdatedEmployee.Version);
            Assert.Equal(1, storedUpdatedEmployee.CountDefault);
            Assert.Equal(12, storedUpdatedEmployee.CountAtomic);

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

            await _context.SaveAsync(product);
            var loadedProduct = await _context.LoadAsync<ProductFlatWithAtomicCounter>(product.Id);
            Assert.NotNull(loadedProduct);
            Assert.NotNull(loadedProduct.Details);
            Assert.Equal(0, loadedProduct.Details.CountDefault);
            Assert.Equal(10, loadedProduct.Details.CountAtomic);
            Assert.Equal(0, loadedProduct.Details.Version);

            // Increment counters via null assignment
            loadedProduct.Details.CountDefault = null;
            loadedProduct.Details.CountAtomic = null;
            await _context.SaveAsync(loadedProduct);

            var loadedProductAfterIncrement = await _context.LoadAsync<ProductFlatWithAtomicCounter>(product.Id);
            Assert.Equal(1, loadedProductAfterIncrement.Details.CountDefault);
            Assert.Equal(12, loadedProductAfterIncrement.Details.CountAtomic);
            Assert.Equal(1, loadedProductAfterIncrement.Details.Version);

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
            await _context.SaveAsync(staleFlat);

            Assert.Equal(2, staleFlat.Details.CountDefault);
            Assert.Equal(14, staleFlat.Details.CountAtomic);
            Assert.Equal(2, staleFlat.Details.Version);

            var loadedFlatLatest = await _context.LoadAsync<ProductFlatWithAtomicCounter>(product.Id);
            Assert.Equal(2, loadedFlatLatest.Details.CountDefault);
            Assert.Equal(14, loadedFlatLatest.Details.CountAtomic);
            Assert.Equal(2, loadedFlatLatest.Details.Version);
        }

        [Fact]
        public async Task Test_AutoGeneratedTimestampAttribute_With_Annotations()
        {
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

            await _context.SaveAsync(product);
            var savedProduct = await _context.LoadAsync<ProductFlatWithTimestamp>(product.Id);
            Assert.NotNull(savedProduct);
            Assert.NotNull(savedProduct.Details);
            Assert.True(savedProduct.Details.CreatedAt > DateTime.MinValue);
            Assert.Equal(0, savedProduct.Details.Version);

            // 2. Test: AutoGeneratedTimestamp combined with AtomicCounter and GSI
            var employee = new EmployeeWithTimestampAndCounter
            {
                Name = "Alice",
                Age = 25,
                CompanyName = "TestCompany",
                Score = 10,
                ManagerName = "Bob"
            };
            await _context.SaveAsync(employee);
            var loadedEmployee = await _context.LoadAsync<EmployeeWithTimestampAndCounter>(employee.Name, employee.Age);
            Assert.NotNull(loadedEmployee);
            Assert.True(loadedEmployee.LastUpdated > DateTime.MinValue);
            Assert.Equal(0, loadedEmployee.CountDefault);

            // 3. Test: AutoGeneratedTimestamp with TimestampMode.Create
            var productCreateOnly = new ProductWithCreateTimestamp
            {
                Id = 200,
                Name = "CreateOnly"
            };
            await _context.SaveAsync(productCreateOnly);
            var loadedCreateOnly = await _context.LoadAsync<ProductWithCreateTimestamp>(productCreateOnly.Id);
            Assert.NotNull(loadedCreateOnly);
            var createdAt = loadedCreateOnly.CreatedAt;
            Assert.True(createdAt > DateTime.MinValue);

            // Update and verify CreatedAt does not change
            await Task.Delay(1000);
            loadedCreateOnly.Name = "UpdatedName";
            await _context.SaveAsync(loadedCreateOnly);
            var loadedAfterUpdate = await _context.LoadAsync<ProductWithCreateTimestamp>(productCreateOnly.Id);
            ApproximatelyEqual(createdAt.Value, loadedAfterUpdate.CreatedAt.Value);
        }

        private DynamoDBContext CreateBuilderTablesContext(DynamoDBEntryConversion conversion)
        {
            var context = new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig
            {
                IsEmptyStringValueEnabled = true,
                Conversion = conversion,
                TableNamePrefix = _fixture.TableNamePrefix
            });
            context.RegisterTableDefinition(new TableBuilder(_fixture.Client, _fixture.HashRangeTableName)
                .AddHashKey("Name", DynamoDBEntryType.String)
                .AddRangeKey("Age", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Score",
                    DynamoDBEntryType.Numeric)
                .AddLocalSecondaryIndex("LocalIndex", "Manager", DynamoDBEntryType.String)
                .Build());

            context.RegisterTableDefinition(new TableBuilder(_fixture.Client, _fixture.HashTableName)
                .AddHashKey("Id", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price",
                    DynamoDBEntryType.Numeric)
                .Build());

            context.RegisterTableDefinition(new TableBuilder(_fixture.Client, _fixture.NumericHashRangeTableName)
                .AddHashKey("CreationTime", DynamoDBEntryType.Numeric)
                .AddRangeKey("Name", DynamoDBEntryType.String)
                .Build());

            context.RegisterTableDefinition(new TableBuilder(_fixture.Client, _fixture.CompositeHashRangeTableName)
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

            return context;
        }

        private DynamoDBContext CreateBuilderContext(DynamoDBEntryConversion conversion, bool disableFetchingTableMetadata = true)
        {
            return new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.IsEmptyStringValueEnabled = true;
                    x.Conversion = conversion;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                    x.DisableFetchingTableMetadata = disableFetchingTableMetadata;
                })
                .Build();
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_EmptyStrings(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestEmptyStringsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_EnumHashKeyObjects(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestEnumHashKeyObjectsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_EmptyCollections(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestEmptyCollectionsHelper(conversion, context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_UnsupportedTypes(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                // Verify that saving objects with invalid properties result in exceptions
                var employee2 = new Employee2
                {
                    Name = "Alan",
                    Age = 31,
                    TimeWithCompany = TimeSpan.FromDays(300)
                };
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.SaveAsync(employee2));

                var employee3 = new Employee3
                {
                    Name = "Alan",
                    Age = 31,
                    EmptyProperty = new EmptyType()
                };
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.SaveAsync(employee3));
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public void TestWithBuilderTables_Enums(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                TestEnumsHelper(conversion, context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_HashObjects(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestHashObjectsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_HashRangeObjects(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestHashRangeObjectsHelper<Employee>(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_OtherContextOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestOtherContextOperationsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_BatchOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestBatchOperationsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_TransactionOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestTransactionOperationsHelper<VersionedEmployee>(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderTables_MultiTableTransactions(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderTablesContext(conversion))
            {
                await TestMultiTableTransactionsHelper<VersionedEmployee>(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestPlainContext_BatchOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion, disableFetchingTableMetadata: false))
            {
                await TestBatchOperationsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestPlainContext_MultiTableTransactions(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion, disableFetchingTableMetadata: false))
            {
                await TestMultiTableTransactionsHelper<VersionedEmployee>(context);
            }
        }

        /// <summary>
        /// Runs the same object-mapper integration tests as <see cref="TestContextWithEmptyStringEnabled"/>,
        /// but using a DynamoDBContext created by <see cref="DynamoDBContextBuilder"/>
        /// </summary>
        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_EmptyStrings(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestEmptyStringsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_EnumHashKeyObjects(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestEnumHashKeyObjectsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_EmptyCollections(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestEmptyCollectionsHelper(conversion, context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_UnsupportedTypes(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                // Verify that saving objects with invalid properties result in exceptions
                var employee4 = new Employee4
                {
                    Name = "Alan",
                    Age = 31,
                    TimeWithCompany = TimeSpan.FromDays(300)
                };
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.SaveAsync(employee4));

                var employee5 = new Employee5
                {
                    Name = "Alan",
                    Age = 31,
                    EmptyProperty = new EmptyType()
                };
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.SaveAsync(employee5));

                // Verify that objects that are invalid result in exceptions
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.ScanAsync<TimeSpan>(new List<ScanCondition>()).GetNextSetAsync());
                await Assert.ThrowsAsync<InvalidOperationException>(() => context.ScanAsync<EmptyType>(new List<ScanCondition>()).GetNextSetAsync());
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public void TestWithBuilderContext_Enums(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                TestEnumsHelper(conversion, context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_HashObjects(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestHashObjectsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_HashRangeObjects(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestHashRangeObjectsHelper<AnnotatedEmployee>(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_OtherContextOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion, disableFetchingTableMetadata: false))
            {
                await TestOtherContextOperationsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_BatchOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion, disableFetchingTableMetadata: false))
            {
                await TestBatchOperationsHelper(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_TransactionOperations(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestTransactionOperationsHelper<VersionedAnnotatedEmployee>(context);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestWithBuilderContext_MultiTableTransactions(DynamoDBEntryConversion conversion)
        {
            using (var context = CreateBuilderContext(conversion))
            {
                await TestMultiTableTransactionsHelper<VersionedAnnotatedEmployee>(context);
            }
        }
    }
}
