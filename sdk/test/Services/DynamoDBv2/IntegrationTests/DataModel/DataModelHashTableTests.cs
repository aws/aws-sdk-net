using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using static AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DataModelContextTestHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DataModelHashTableTests : IClassFixture<HashTableFixture>, IAsyncLifetime
    {
        private readonly HashTableFixture _fixture;
        private DynamoDBContext _context;
        public DataModelHashTableTests(HashTableFixture fixture)
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
        public async Task TestTransactWrite_SkipVersionCheck()
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = true;
                    x.DisableFetchingTableMetadata = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                var vp = new VersionedProduct
                {
                    Id = 1000,
                    Name = "TestProduct",
                    Price = 100
                };
                await context.SaveAsync(vp);

                // Load to get initial version
                vp = await context.LoadAsync<VersionedProduct>(vp.Id);
                Assert.Equal(0, vp.Version);

                // Set wrong version - normally would fail with a ConditionalCheck error
                vp.Version = 9999;
                vp.Price = 200;

                // With SkipVersionCheck = true, should succeed
                var transactWrite = context.CreateTransactWrite<VersionedProduct>(new TransactWriteConfig
                {
                    SkipVersionCheck = true
                });
                transactWrite.AddSaveItem(vp);
                await transactWrite.ExecuteAsync();

                // Verify update succeeded
                var updated = await context.LoadAsync<VersionedProduct>(vp.Id);
                Assert.Equal(200, updated.Price);
                Assert.Equal(9999, updated.Version);
            }
        }

        [Fact]
        public async Task TestContext_ScanWithExpression_NestedPaths()
        {
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

            await _context.SaveAsync(product1);
            await _context.SaveAsync(product2);
            await _context.SaveAsync(product3);

            var scanConfig = new ScanConfig { ConsistentRead = true };

            // 1. Filter on a nested property (CompanyInfo.Name)
            var expr1 = new ContextExpression();
            expr1.SetFilter<Product>(p => p.CompanyInfo.Name == "Acme");
            var byCompanyName = await _context.ScanAsync<Product>(expr1, scanConfig).GetRemainingAsync();
            Assert.Equal(1, byCompanyName.Count);
            Assert.Equal("Widget", byCompanyName[0].Name);

            // 2. Filter on a nested array property (FeaturedBrands contains "Acme")
            var expr2 = new ContextExpression();
            expr2.SetFilter<Product>(p => p.CompanyInfo.FeaturedBrands.Contains("Acme"));
            var byFeaturedBrand = await _context.ScanAsync<Product>(expr2, scanConfig).GetRemainingAsync();
            Assert.Equal(1, byFeaturedBrand.Count);
            Assert.Equal("Widget", byFeaturedBrand[0].Name);

            // 3. Filter on a double-nested property
            var expr3 = new ContextExpression();
            expr3.SetFilter<Product>(p => p.CompanyInfo.AllProducts.First().Name == "Device");
            var byDoubleNested = await _context.ScanAsync<Product>(expr3, scanConfig).GetRemainingAsync();
            Assert.Equal(1, byDoubleNested.Count);
            Assert.Equal("Thing", byDoubleNested[0].Name);

            var expr4 = new ContextExpression();
            expr4.SetFilter<Product>(p => p.CompanyInfo.AllProducts[0].Name == "Device");
            var byDoubleNested1 = await _context.ScanAsync<Product>(expr4, scanConfig).GetRemainingAsync();
            Assert.Equal(1, byDoubleNested1.Count);
            Assert.Equal("Thing", byDoubleNested1[0].Name);

            // 4. Filter on a value inside a dictionary of lists
            var expr5 = new ContextExpression();
            expr5.SetFilter<Product>(p => p.CompanyInfo.CompetitorProducts["CloudsAreOK"][0].Name == "CloudSpotter RipOff");
            var byDictionaryNested = await _context.ScanAsync<Product>(expr5, scanConfig).GetRemainingAsync();
            Assert.Equal(1, byDictionaryNested.Count);
            Assert.Equal("CloudSpotter", byDictionaryNested[0].Name);
        }

        [Fact]
        public async Task TestContext_SaveItem_WithTTL()
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                // Define TTL to be 2 minutes in the future
                var ttlEpoch = DateTimeOffset.UtcNow.AddMinutes(2).ToUnixTimeSeconds();

                var item = new TtlTestItem
                {
                    Id = 1,
                    Data = "Test with TTL",
                    Ttl = ttlEpoch
                };

                await context.SaveAsync(item);

                // Load immediately, should exist
                var loaded = await context.LoadAsync<TtlTestItem>(item.Id);
                Assert.NotNull(loaded);
                Assert.Equal(item.Id, loaded.Id);
                Assert.Equal(item.Data, loaded.Data);
                Assert.Equal(item.Ttl, loaded.Ttl);

                item.Ttl = DateTimeOffset.UtcNow.AddMinutes(3).ToUnixTimeSeconds();
                await context.SaveAsync(item);
                var loaded2 = await context.LoadAsync<TtlTestItem>(item.Id);
                Assert.NotNull(loaded2);
                Assert.Equal(item.Id, loaded2.Id);
                Assert.Equal(item.Data, loaded2.Data);
                Assert.Equal(item.Ttl, loaded2.Ttl);
            }
        }

        [Fact]
        public async Task Test_IndexOrder()
        {
            _context.RegisterTableDefinition(new TableBuilder(_fixture.Client, _fixture.HashTableName)
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

            await _context.SaveAsync(order);

            // GSI updates are eventually consistent, retry until the index reflects the write.
            List<OrderIndex> savedOrders = null;
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                savedOrders = await _context.QueryAsync<OrderIndex>(
                    order.CompanyName,
                    QueryOperator.Equal,
                    new object[] { 1000 },
                    new QueryConfig
                    {
                        IndexName = "GlobalIndex",
                    })
                    .GetNextSetAsync();
                return savedOrders.Any();
            }, sleepSeconds: 1, maxWaitSeconds: 5);
            Assert.NotNull(savedOrders);

            var savedOrder = savedOrders.FirstOrDefault();
            Assert.NotNull(savedOrder);
        }

        [Fact]
        public async Task Test_IndexStructure()
        {
            _context.RegisterTableDefinition(new TableBuilder(_fixture.Client, _fixture.HashTableName)
                .AddHashKey("Id", DynamoDBEntryType.Numeric)
                .AddGlobalSecondaryIndex("GlobalIndex", "Company", DynamoDBEntryType.String, "Price",
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

            await _context.SaveAsync(order);

            // GSI updates are eventually consistent, retry until the index reflects the write.
            List<Order> savedOrders = null;
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                savedOrders = await _context.QueryAsync<Order>(
                    order.Payment.CompanyName, // Hash-key for the index is Company
                    QueryOperator.Equal, // Range-key for the index is Price, so the
                    new object[] { 1000 }, // condition is against a numerical value
                    new QueryConfig // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                    })
                    .GetNextSetAsync();
                return savedOrders.Any();
            }, sleepSeconds: 1, maxWaitSeconds: 5);
            Assert.NotNull(savedOrders);

            var savedOrder = savedOrders.FirstOrDefault();
            Assert.NotNull(savedOrder);
            Assert.Equal(order.Id, savedOrder.Id);
            Assert.NotNull(savedOrder.Payment);
            Assert.Equal(order.Payment.Price, savedOrder.Payment.Price);
            Assert.Equal(order.Payment.CompanyName, savedOrder.Payment.CompanyName);
        }

        [Fact]
        public async Task Test_FlattenAttribute_With_Annotations()
        {
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

            await _context.SaveAsync(product);
            var savedProductFlat = await _context.LoadAsync<ProductFlat>(product.Id, new LoadConfig { ConsistentRead = true });
            Assert.NotNull(savedProductFlat);
            Assert.Equal(product.Id, savedProductFlat.Id);
            Assert.NotNull(savedProductFlat.Details);
            Assert.Equal(product.Details.Description, savedProductFlat.Details.Description);
            Assert.Equal(0, savedProductFlat.Details.Version);
            Assert.Equal("TestProduct", savedProductFlat.Name);
            Assert.Equal("TestProductDetails", savedProductFlat.Details.Name);

            //update the product and verify the flattened property is updated
            product.Name = "UpdatedProductName";
            await _context.SaveAsync(product);
            Assert.Equal(1, product.Details.Version);

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
            await _context.SaveAsync(flatEmployee);
            var savedFlatEmployee = await _context.LoadAsync<EmployeeFlatten>(flatEmployee.EmployeeId, new LoadConfig { ConsistentRead = true });
            Assert.NotNull(savedFlatEmployee);
            Assert.Equal(flatEmployee.EmployeeId, savedFlatEmployee.EmployeeId);
            Assert.Equal(flatEmployee.Contact.Address.City, savedFlatEmployee.City);
            Assert.Equal(flatEmployee.Contact.Address.Street, savedFlatEmployee.Street);
            Assert.Equal(flatEmployee.Contact.Email, savedFlatEmployee.Email);

            //flattened property contains a property with a custom converter.
            var eventToSave = new Event()
            {
                Id = 5,
                Details = new EventDetails()
                {
                    EventDate = DateTime.Today
                }
            };
            await _context.SaveAsync(eventToSave);
            var savedEvent = await _context.LoadAsync<Event>(eventToSave.Id, new LoadConfig { ConsistentRead = true });
            Assert.NotNull(savedEvent);
            Assert.Equal(eventToSave.Id, savedEvent.Id);
            Assert.NotNull(savedEvent.Details);
            Assert.Equal(eventToSave.Details.EventDate.ToUniversalTime(), savedEvent.Details.EventDate);

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

            await _context.SaveAsync(order);

            // GSI updates are eventually consistent, retry until the index reflects the write.
            List<Order> savedOrders = null;
            await UtilityMethods.WaitUntilAsync(async () =>
            {
                savedOrders = await _context.QueryAsync<Order>(
                    order.Payment.CompanyName, // Hash-key for the index is Company
                    QueryOperator.Equal, // Range-key for the index is Price, so the
                    new object[] { 1000 }, // condition is against a numerical value
                    new QueryConfig // Configure the index to use
                    {
                        IndexName = "GlobalIndex",
                    })
                    .GetNextSetAsync();
                return savedOrders.Any();
            }, sleepSeconds: 1, maxWaitSeconds: 5);
            Assert.NotNull(savedOrders);

            var savedOrder = savedOrders.FirstOrDefault();
            Assert.NotNull(savedOrder);
            Assert.Equal(order.Id, savedOrder.Id);
            Assert.NotNull(savedOrder.Payment);
            Assert.Equal(order.Payment.Price, savedOrder.Payment.Price);
            Assert.Equal(order.Payment.CompanyName, savedOrder.Payment.CompanyName);
        }

        [Fact]
        public async Task Test_AutoGeneratedTimestampAttribute_CreateMode_Simple()
        {
            var product = new ProductWithCreateTimestamp
            {
                Id = 999,
                Name = "SimpleCreate"
            };

            await _context.SaveAsync(product);
            var loaded = await _context.LoadAsync<ProductWithCreateTimestamp>(product.Id, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loaded);
            Assert.Equal(product.Id, loaded.Id);
            Assert.Equal("SimpleCreate", loaded.Name);
            Assert.NotNull(loaded.CreatedAt);
            Assert.True(loaded.CreatedAt > DateTime.MinValue);
            Assert.Equal(product.CreatedAt, loaded.CreatedAt);

            // Save again and verify CreatedAt does not change
            var createdAt = loaded.CreatedAt;
            await Task.Delay(1000);
            loaded.Name = "UpdatedName";
            await _context.SaveAsync(loaded);
            var loadedAfterUpdate = await _context.LoadAsync<ProductWithCreateTimestamp>(product.Id, new LoadConfig { ConsistentRead = true });
            ApproximatelyEqual(createdAt.Value, loadedAfterUpdate.CreatedAt.Value);

            // Test: StoreAsEpoch with AutoGeneratedTimestamp (Always)
            var now = DateTime.UtcNow;
            var epochEntity = new AutoGenTimestampEpochEntity
            {
                Id = 1,
                Name = "EpochTest"
            };

            await _context.SaveAsync(epochEntity);
            var loadedEpochEntity = await _context.LoadAsync<AutoGenTimestampEpochEntity>(epochEntity.Id, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loadedEpochEntity);
            Assert.True(loadedEpochEntity.CreatedAt > DateTime.MinValue);
            Assert.True(loadedEpochEntity.UpdatedAt > DateTime.MinValue);
            ApproximatelyEqual(epochEntity.CreatedAt.Value, loadedEpochEntity.CreatedAt.Value);
            ApproximatelyEqual(epochEntity.UpdatedAt.Value, loadedEpochEntity.UpdatedAt.Value);

            // Save again and verify CreatedAt does not change, UpdatedAt does
            var createdAtEpochEntity = loadedEpochEntity.CreatedAt;
            var updatedAt = loadedEpochEntity.UpdatedAt;
            await Task.Delay(1000);
            loadedEpochEntity.Name = "UpdatedName";
            loadedEpochEntity.UpdatedAt = null;
            loadedEpochEntity.CreatedAt = null;
            await _context.SaveAsync(loadedEpochEntity);
            var loadedAfterUpdateEpochEntity = await _context.LoadAsync<AutoGenTimestampEpochEntity>(epochEntity.Id, new LoadConfig { ConsistentRead = true });
            Assert.Equal(createdAtEpochEntity, loadedAfterUpdateEpochEntity.CreatedAt);
            Assert.True(loadedAfterUpdateEpochEntity.UpdatedAt > updatedAt);

            // Test: StoreAsEpochLong with AutoGeneratedTimestamp (Always)
            var longEpochEntity = new AutoGenTimestampEpochLongEntity
            {
                Id = 2,
                Name = "LongEpochTest",
                CreatedAt1 = DateTime.Today
            };

            await _context.SaveAsync(longEpochEntity);
            var loadedLongEpochEntity = await _context.LoadAsync<AutoGenTimestampEpochLongEntity>(longEpochEntity.Id, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loadedLongEpochEntity);
            Assert.True(loadedLongEpochEntity.CreatedAt > DateTime.MinValue);
            Assert.True(loadedLongEpochEntity.UpdatedAt > DateTime.MinValue);
            ApproximatelyEqual(longEpochEntity.CreatedAt.Value, loadedLongEpochEntity.CreatedAt.Value);
            ApproximatelyEqual(longEpochEntity.UpdatedAt.Value, loadedLongEpochEntity.UpdatedAt.Value);

            // Save again and verify CreatedAt does not change, UpdatedAt does
            var createdAtLong = loadedLongEpochEntity.CreatedAt;
            var updatedAtLong = loadedLongEpochEntity.UpdatedAt;
            await Task.Delay(1000);
            loadedLongEpochEntity.Name = "UpdatedName2";
            loadedLongEpochEntity.UpdatedAt = null;
            loadedLongEpochEntity.CreatedAt = null;
            await _context.SaveAsync(loadedLongEpochEntity);
            var loadedAfterUpdateLong = await _context.LoadAsync<AutoGenTimestampEpochLongEntity>(longEpochEntity.Id, new LoadConfig { ConsistentRead = true });
            ApproximatelyEqual(createdAtLong.Value, loadedAfterUpdateLong.CreatedAt.Value);
            Assert.True(loadedAfterUpdateLong.UpdatedAt > updatedAtLong);

            // Test: StoreAsEpoch with AutoGeneratedTimestamp (Create)
            var epochCreateEntity = new AutoGenTimestampEpochEntity
            {
                Id = 3,
                Name = "EpochCreateTest"
            };

            await _context.SaveAsync(epochCreateEntity);
            var loadedEpochCreateEntity = await _context.LoadAsync<AutoGenTimestampEpochEntity>(epochCreateEntity.Id, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loadedEpochCreateEntity);
            Assert.True(loadedEpochCreateEntity.CreatedAt > DateTime.MinValue);

            var createdAtCreate = loadedEpochCreateEntity.CreatedAt;
            await Task.Delay(1000);
            loadedEpochCreateEntity.Name = "UpdatedName3";
            await _context.SaveAsync(loadedEpochCreateEntity);
            var loadedAfterUpdateCreate = await _context.LoadAsync<AutoGenTimestampEpochEntity>(epochCreateEntity.Id, new LoadConfig { ConsistentRead = true });
            ApproximatelyEqual(createdAtCreate.Value, loadedAfterUpdateCreate.CreatedAt.Value);
        }

        [Fact]
        public async Task Test_AutoGeneratedTimestampAttribute_TransactWrite_Simple()
        {
            var product = new ProductWithCreateTimestamp
            {
                Id = 1001,
                Name = "TransactCreate"
            };

            // Save using TransactWrite
            var transactWrite = _context.CreateTransactWrite<ProductWithCreateTimestamp>();
            transactWrite.AddSaveItem(product);
            await transactWrite.ExecuteAsync();

            var loaded = await _context.LoadAsync<ProductWithCreateTimestamp>(product.Id, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loaded);
            Assert.Equal(product.Id, loaded.Id);
            Assert.Equal("TransactCreate", loaded.Name);
            Assert.NotNull(loaded.CreatedAt);
            Assert.True(loaded.CreatedAt > DateTime.MinValue);
            Assert.Equal(product.CreatedAt, loaded.CreatedAt);

            // Save again using TransactWrite and verify CreatedAt does not change
            var createdAt = loaded.CreatedAt;
            await Task.Delay(1000);
            loaded.Name = "TransactUpdated";
            var transactWrite2 = _context.CreateTransactWrite<ProductWithCreateTimestamp>();
            transactWrite2.AddSaveItem(loaded);
            await transactWrite2.ExecuteAsync();
            var loadedAfterUpdate = await _context.LoadAsync<ProductWithCreateTimestamp>(product.Id, new LoadConfig { ConsistentRead = true });
            ApproximatelyEqual(createdAt.Value, loadedAfterUpdate.CreatedAt.Value);

            // Test: StoreAsEpoch with AutoGeneratedTimestamp (Always) using TransactWrite
            var epochEntity = new AutoGenTimestampEpochEntity
            {
                Id = 1002,
                Name = "TransactEpoch"
            };

            var transactWrite3 = _context.CreateTransactWrite<AutoGenTimestampEpochEntity>();
            transactWrite3.AddSaveItem(epochEntity);
            await transactWrite3.ExecuteAsync();
            var loadedEpochEntity = await _context.LoadAsync<AutoGenTimestampEpochEntity>(epochEntity.Id, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loadedEpochEntity);
            Assert.True(loadedEpochEntity.CreatedAt > DateTime.MinValue);
            ApproximatelyEqual(epochEntity.CreatedAt.Value, loadedEpochEntity.CreatedAt.Value);
            Assert.True(loadedEpochEntity.UpdatedAt > DateTime.MinValue);

            // Save again and verify CreatedAt does not change, UpdatedAt does
            var createdAtEpochEntity = loadedEpochEntity.CreatedAt;
            var updatedAt = loadedEpochEntity.UpdatedAt;
            await Task.Delay(1000);
            loadedEpochEntity.Name = "TransactEpochUpdated";
            loadedEpochEntity.UpdatedAt = null;
            loadedEpochEntity.CreatedAt = null;
            var transactWrite4 = _context.CreateTransactWrite<AutoGenTimestampEpochEntity>();
            transactWrite4.AddSaveItem(loadedEpochEntity);
            await transactWrite4.ExecuteAsync();
            var loadedAfterUpdateEpochEntity = await _context.LoadAsync<AutoGenTimestampEpochEntity>(epochEntity.Id, new LoadConfig { ConsistentRead = true });
            ApproximatelyEqual(createdAtEpochEntity.Value, loadedAfterUpdateEpochEntity.CreatedAt.Value);
            Assert.True(loadedAfterUpdateEpochEntity.UpdatedAt > updatedAt);
        }

        /// <summary>
        /// Tests that if a custom property converter is used over the global converter on that specific property.
        /// </summary>
        [Fact]
        public async Task TestContext_GlobalConverter_And_PropertyConvector()
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V1;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = false;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                // Add a global converter
                context.ConverterCache.Add(typeof(NameType), new NameTypeUpperCaseConverter<NameType>());

                var nameType = new NameType
                {
                    FirstName = "John",
                    MiddleName = "Bob",
                    LastName = "Smith"
                };
                var employee = new PropertyConverterTable
                {
                    Id = 1,
                    PropertyWithGlobalConverter = nameType,
                    PropertyWithPropertyConvertor = nameType,
                };
                await context.SaveAsync(employee);

                // Load
                var storedEmployee = await context.LoadAsync<PropertyConverterTable>(employee.Id);
                Assert.NotNull(storedEmployee);
                Assert.Equal(storedEmployee.Id, employee.Id);
                Assert.Equal(storedEmployee.PropertyWithGlobalConverter.FirstName, "JOHN");
                Assert.Equal(storedEmployee.PropertyWithGlobalConverter.MiddleName, "BOB");
                Assert.Equal(storedEmployee.PropertyWithGlobalConverter.LastName, "SMITH");
                Assert.Equal(storedEmployee.PropertyWithPropertyConvertor.FirstName, "john");
                Assert.Equal(storedEmployee.PropertyWithPropertyConvertor.MiddleName, "bob");
                Assert.Equal(storedEmployee.PropertyWithPropertyConvertor.LastName, "smith");
            }
        }

        [Fact]
        public async Task TestContextConversions()
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
                var docV1 = _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 });
                var docV2 = _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            {
                using (var contextV1 = new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig { Conversion = conversionV1, TableNamePrefix = _fixture.TableNamePrefix }))
                using (var contextV2 = new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig { Conversion = conversionV2, TableNamePrefix = _fixture.TableNamePrefix }))
                {
                    var docV1 = contextV1.ToDocument(product);
                    var docV2 = contextV2.ToDocument(product);
                    VerifyConversions(docV1, docV2);
                }
            }

            {
                using (var contextV1 = new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig { Conversion = conversionV1, TableNamePrefix = _fixture.TableNamePrefix }))
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
                       new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig { Conversion = conversionV1 }))
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
                AssertExtensions.ExpectException(() => _context.ToDocument(product), typeof(InvalidOperationException));
                AssertExtensions.ExpectException(
                    () => _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 }),
                    typeof(InvalidOperationException));
                AssertExtensions.ExpectException(
                    () => _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 }),
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

                var docV1 = _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 });
                var docV2 = _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);
            }

            // Introduce circular reference in a Document and try to deserialize
            {
                // Normal serialization
                var docV1 = _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV1 });
                var docV2 = _context.ToDocument(product, new ToDocumentConfig { Conversion = conversionV2 });
                VerifyConversions(docV1, docV2);

                // Add circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV2;
                AssertExtensions.ExpectException(() =>
                    _context.FromDocument<Product>(docV1, new FromDocumentConfig { Conversion = conversionV1 }));
                AssertExtensions.ExpectException(() =>
                    _context.FromDocument<Product>(docV2, new FromDocumentConfig { Conversion = conversionV2 }));

                // Remove circular references
                docV1["CompanyInfo"].AsDocument()["MostPopularProduct"] = null;
                docV2["CompanyInfo"].AsDocument()["MostPopularProduct"] = docV1;
                var prod1 = _context.FromDocument<Product>(docV1, new FromDocumentConfig { Conversion = conversionV1 });
                var prod2 = _context.FromDocument<Product>(docV2, new FromDocumentConfig { Conversion = conversionV2 });
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public void TestEnums(DynamoDBEntryConversion conversion)
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
            var doc1 = _context.ToDocument(product);
            var product2 = _context.FromDocument<Product>(doc1);
            Assert.Equal(product.CurrentStatus, product2.CurrentStatus);
            Assert.Equal(product.FormerStatus, product2.FormerStatus);
            Assert.Equal(product.Supports, product2.Supports);

            // try changing underlying enum data to strings
            var doc2 = _context.ToDocument(product);
            doc2["CurrentStatus"] = product.CurrentStatus.ToString();
            doc2["FormerStatus"] = product.FormerStatus.ToString();
            doc2["Supports"] = product.Supports.ToString();
            doc2 = doc2.ForceConversion(conversion);
            var product3 = _context.FromDocument<Product>(doc2);
            Assert.Equal(product.CurrentStatus, product3.CurrentStatus);
            Assert.Equal(product.FormerStatus, product3.FormerStatus);
            Assert.Equal(product.Supports, product3.Supports);
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestEmptyCollections(DynamoDBEntryConversion conversion)
        {
            // Check if the conversion being used is V1
            // In V1 conversion, lists are stored as sets, which cannot
            // be empty, so for V1 we are not testing empty lists
            var isV1 = (conversion == DynamoDBEntryConversion.V1);

            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = conversion;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
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
        }

        [Fact]
        public async Task TestEnumHashKeyObjects() => await TestEnumHashKeyObjectsHelper(_context);

        [Fact]
        public async Task TestHashObjects() => await TestHashObjectsHelper(_context);

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
    }
}
