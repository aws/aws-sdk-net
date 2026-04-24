using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using static AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DataModelContextTestHelpers;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DataModelHashRangeTests : IClassFixture<HashTablesFixture>, IAsyncLifetime
    {
        private readonly HashTablesFixture _fixture;
        private DynamoDBContext _context;

        public DataModelHashRangeTests(HashTablesFixture fixture)
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
        public async Task TestContextWithEmptyStringDisabled()
        {
            // Recreate context
            bool isEmptyStringEnabled = false;
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = isEmptyStringEnabled;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
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

                await context.SaveAsync(product1);
                var savedProduct1 = await context.LoadAsync<Product>(1);
                Assert.Equal(1, savedProduct1.Id);
                Assert.Equal(0, savedProduct1.Components.Count());
                Assert.Equal(null, savedProduct1.Name);

                var product2 = new Product
                {
                    Id = 2,
                    Components = new List<string> // L
                    {
                        string.Empty, "test2"
                    }
                };

                await context.SaveAsync(product2);
                var savedProduct2 = await context.LoadAsync<Product>(2);
                Assert.Equal(2, savedProduct2.Id);
                Assert.Equal(1, savedProduct2.Components.Count());
                Assert.Equal("test2", savedProduct2.Components[0]);

                var product3 = new Product
                {
                    Id = 3,
                    Components = new List<string> // L
                    {
                        string.Empty, "test3", string.Empty
                    }
                };

                await context.SaveAsync(product3);
                var savedProduct3 = await context.LoadAsync<Product>(3);

                Assert.Equal(3, savedProduct3.Id);
                Assert.Equal(1, savedProduct3.Components.Count());
                Assert.Equal("test3", savedProduct3.Components[0]);
            }
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info
        /// supplied only via class attributes.
        /// </summary>
        [Fact]
        public async Task TestContext_DisableFetchingTableMetadata_WithFullAttributes()
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.IsEmptyStringValueEnabled = true;
                    x.DisableFetchingTableMetadata = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                await TestHashRangeObjectsHelper<AnnotatedEmployee>(context);
            }
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info
        /// supplied via a combination of class attributes and the app config.
        /// </summary>
        [Fact]
        public async Task TestContext_DisableFetchingTableMetadata_WithPartialAttributes()
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.IsEmptyStringValueEnabled = true;
                    x.DisableFetchingTableMetadata = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                await TestHashRangeObjectsHelper<PartiallyAnnotatedEmployee>(context);
            }
        }

        /// <summary>
        /// Tests that the DynamoDB operations can be invoked successfully based on the table info
        /// supplied via attributes on the parent class.
        /// </summary>
        [Fact]
        public async Task TestContext_DisableFetchingTableMetadata_WithNonAnnotatedChildClass()
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.IsEmptyStringValueEnabled = true;
                    x.DisableFetchingTableMetadata = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                await TestHashRangeObjectsHelper<EmployeeChild>(context);
            }
        }

        /// <summary>
        /// Tests that disabling fetching table metadata works with a key that has a property converter.
        /// </summary>
        [Fact]
        public async Task TestTransactWrite_AddSaveItem_DocumentTransaction()
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
                {
                    var hashRangeOnly = new AnnotatedRangeTable
                    {
                        Name = "Bob",
                        Age = 10
                    };

                    var transactWrite = context.CreateTransactWrite<AnnotatedRangeTable>();
                    transactWrite.AddSaveItem(hashRangeOnly);
                    await transactWrite.ExecuteAsync();

                    var storedHashOnly = await context.LoadAsync<AnnotatedRangeTable>(hashRangeOnly.Name, hashRangeOnly.Age);
                    Assert.NotNull(storedHashOnly);
                    Assert.Equal(hashRangeOnly.Name, storedHashOnly.Name);
                }

                {
                    var hashRangeOnly = new IgnoreAnnotatedRangeTable
                    {
                        Name = "Bob",
                        Age = 10,
                        IgnoreAttribute = 100
                    };

                    var transactWrite = context.CreateTransactWrite<IgnoreAnnotatedRangeTable>();
                    transactWrite.AddSaveItem(hashRangeOnly);
                    await transactWrite.ExecuteAsync();

                    var storedHashOnly = await context.LoadAsync<IgnoreAnnotatedRangeTable>(hashRangeOnly.Name, hashRangeOnly.Age);
                    Assert.NotNull(storedHashOnly);
                    Assert.Equal(hashRangeOnly.Name, storedHashOnly.Name);
                    Assert.Equal(hashRangeOnly.Age, storedHashOnly.Age);
                }

                {
                    var hashRangeOnly = new AnnotatedRangeTable2
                    {
                        Name = "Bob",
                        Age = 10,
                        NotAnnotatedAttribute = 100
                    };

                    var transactWrite = context.CreateTransactWrite<AnnotatedRangeTable2>();
                    transactWrite.AddSaveItem(hashRangeOnly);
                    await transactWrite.ExecuteAsync();

                    var storedHashOnly = await context.LoadAsync<AnnotatedRangeTable2>(hashRangeOnly.Name, hashRangeOnly.Age);
                    Assert.NotNull(storedHashOnly);
                    Assert.Equal(hashRangeOnly.Name, storedHashOnly.Name);
                    Assert.Equal(hashRangeOnly.Age, storedHashOnly.Age);
                    Assert.Equal(hashRangeOnly.NotAnnotatedAttribute, storedHashOnly.NotAnnotatedAttribute);
                }
            }
        }

        [Fact]
        public async Task TestContext_ScanConfigFilter()
        {
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

            await _context.SaveAsync(employee);
            await _context.SaveAsync(employee3);

            var ageEqResultScan = await _context.ScanAsync<Employee>(new List<ScanCondition>(), new ScanConfig()
            {
                ConsistentRead = true,
                QueryFilter = new List<ScanCondition>()
                {
                    new ScanCondition("Age", ScanOperator.GreaterThan,50)
                },
                ConditionalOperator = ConditionalOperatorValues.And
            }).GetRemainingAsync();
            Assert.Equal(0, ageEqResultScan.Count);

            var ageAndCompanyResultScan = await _context.ScanAsync<Employee>(
                new List<ScanCondition>()
                {
                    new ScanCondition("Age", ScanOperator.Equal,45)
                },
                new ScanConfig()
                {
                    ConsistentRead = true,
                    QueryFilter = new List<ScanCondition>()
                    {
                        new ScanCondition("CompanyName", ScanOperator.Equal, "test")
                    },
                    ConditionalOperator = ConditionalOperatorValues.And
                })
            .GetRemainingAsync();
            Assert.Equal(1, ageAndCompanyResultScan.Count);
        }

        [Fact]
        public async Task TestContext_Scan_WithExpressionFilter()
        {
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

            await _context.SaveAsync(employee);
            await _context.SaveAsync(employee2);
            await _context.SaveAsync(employee3);
            await _context.SaveAsync(employee4);

            var scanConfig = new ScanConfig { ConsistentRead = true };

            // Numeric equality
            int age = 45;
            var exprAgeEq = new ContextExpression();
            exprAgeEq.SetFilter<Employee>(e => e.Age == age);
            var ageEqResult = await _context.ScanAsync<Employee>(exprAgeEq, scanConfig).GetRemainingAsync();
            Assert.Equal(2, ageEqResult.Count);

            var exprAgeEqM = new ContextExpression();
            exprAgeEqM.SetFilter<Employee>(e => Equals(e.Age, 45));
            var ageEqMResult = await _context.ScanAsync<Employee>(exprAgeEqM, scanConfig).GetRemainingAsync();
            Assert.Equal(2, ageEqMResult.Count);

            // AND expression with BinaryComparisons
            var exprAnd = new ContextExpression();
            exprAnd.SetFilter<Employee>(e => e.Age > 40 && e.CompanyName == "test");
            var andResults = await _context.ScanAsync<Employee>(exprAnd, scanConfig).GetRemainingAsync();

            var s1 = await _context.ScanAsync<Employee>(new List<ScanCondition>()
            {
                new ScanCondition("Age", ScanOperator.GreaterThan, 40),
                new ScanCondition("CompanyName", ScanOperator.Equal, "test")
            }, new ScanConfig { ConsistentRead = true, RetrieveDateTimeInUtc = true }).GetRemainingAsync();

            Assert.NotNull(s1);
            Assert.Equal(s1.Count, 1);
            Assert.Equal(s1.FirstOrDefault().Name, "Bob");

            Assert.NotNull(andResults);
            Assert.Equal(andResults.Count, 1);
            Assert.Equal(andResults.FirstOrDefault().Name, "Bob");

            // NOT expression
            var exprNot = new ContextExpression();
            exprNot.SetFilter<Employee>(e => !(e.CompanyName == "test1"));
            var notResult = await _context.ScanAsync<Employee>(exprNot, scanConfig).GetRemainingAsync();
            Assert.Equal(3, notResult.Count);
            Assert.True(notResult.All(e => e.CompanyName != "test1"));

            // OR expression
            var exprOr = new ContextExpression();
            exprOr.SetFilter<Employee>(e => e.Name == "Bob" || e.Name == "Rob");
            var orResult = await _context.ScanAsync<Employee>(exprOr, scanConfig).GetRemainingAsync();
            Assert.Equal(2, orResult.Count);
            Assert.True(orResult.Any(e => e.Name == "Bob"));
            Assert.True(orResult.Any(e => e.Name == "Rob"));

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
            await _context.SaveAsync(empWithAliases);

            var exprContains = new ContextExpression();
            exprContains.SetFilter<Employee>(e => e.Aliases.Contains("Al"));
            var containsResult = await _context.ScanAsync<Employee>(exprContains, scanConfig).GetRemainingAsync();
            Assert.True(containsResult.Any(e => e.Name == "Ali"));

            var exprContainsEnumerable = new ContextExpression();
            exprContainsEnumerable.SetFilter<Employee>(e => Enumerable.Contains(e.Aliases, "Al"));
            var containsEnumerableResult = await _context.ScanAsync<Employee>(exprContainsEnumerable, scanConfig).GetRemainingAsync();
            Assert.True(containsEnumerableResult.Any(e => e.Name == "Ali"));

            // String.StartsWith
            var exprStartsWith = new ContextExpression();
            exprStartsWith.SetFilter<Employee>(e => e.Name.StartsWith("B"));
            var startsWithResult = await _context.ScanAsync<Employee>(exprStartsWith, scanConfig).GetRemainingAsync();
            Assert.True(startsWithResult.Any(e => e.Name == "Bob"));

            // Between
            var exprBetween = new ContextExpression();
            exprBetween.SetFilter<Employee>(e => ContextExpression.Between(e.Age, 40, 50));
            var betweenResult = await _context.ScanAsync<Employee>(exprBetween, scanConfig).GetRemainingAsync();
            Assert.Equal(3, betweenResult.Count);
            Assert.True(betweenResult.All(e => e.Age >= 40 && e.Age <= 50));

            // String.Contains
            var exprStringContains = new ContextExpression();
            exprStringContains.SetFilter<Employee>(e => e.Name.Contains("o"));
            var stringContainsResult = await _context.ScanAsync<Employee>(exprStringContains, scanConfig).GetRemainingAsync();
            Assert.True(stringContainsResult.Any(e => e.Name == "Bob" || e.Name == "Rob" || e.Name == "Cob"));

            var exprNullCheck = new ContextExpression();
            exprNullCheck.SetFilter<Employee>(e => ContextExpression.AttributeExists(e.MiddleName));
            var nullCheckResult = await _context.ScanAsync<Employee>(exprNullCheck, scanConfig).GetRemainingAsync();
            Assert.True(nullCheckResult.Count == 1);

            var exprNull = new ContextExpression();
            exprNull.SetFilter<Employee>(e => ContextExpression.AttributeNotExists(e.MiddleName));
            var nullResult = await _context.ScanAsync<Employee>(exprNull, scanConfig).GetRemainingAsync();
            Assert.True(nullResult.Count == 4);

            //AttributeType scenario: filter for employees where MiddleName is a DynamoDB String
            var empWithStringMiddleName = new Employee
            {
                Name = "TypeTest",
                Age = 55,
                CurrentStatus = Status.Inactive,
                MiddleName = "StringType",
                CompanyName = "test"
            };
            await _context.SaveAsync(empWithStringMiddleName);

            var exprAttributeType = new ContextExpression();
            exprAttributeType.SetFilter<Employee>(e => ContextExpression.AttributeType(e.MiddleName, DynamoDBAttributeType.S.Value));
            var attributeTypeResult = await _context.ScanAsync<Employee>(exprAttributeType, scanConfig).GetRemainingAsync();
            Assert.True(attributeTypeResult.Any(e => e.Name == "TypeTest"));

            // --- Enum scenario ---
            // Scan for employees with CurrentStatus == Status.Active
            var exprActiveEnum = new ContextExpression();
            exprActiveEnum.SetFilter<Employee>(e => e.CurrentStatus == Status.Active);
            var activeEnumResult = await _context.ScanAsync<Employee>(exprActiveEnum, scanConfig).GetRemainingAsync();
            Assert.Equal(3, activeEnumResult.Count);
            Assert.True(activeEnumResult.All(e => e.CurrentStatus == Status.Active));

            // Scan for employees with CurrentStatus == Status.Upcoming
            var exprUpcomingEnum = new ContextExpression();
            exprUpcomingEnum.SetFilter<Employee>(e => e.CurrentStatus == Status.Upcoming);
            var upcomingEnumResult = await _context.ScanAsync<Employee>(exprUpcomingEnum, scanConfig).GetRemainingAsync();
            Assert.Equal(1, upcomingEnumResult.Count);
            Assert.Equal("Sam", upcomingEnumResult[0].Name);
        }

        [Fact]
        public async Task TestContext_Query_WithExpressionFilter()
        {
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

            await _context.SaveAsync(employee1);
            await _context.SaveAsync(employee11);
            await _context.SaveAsync(employee2);
            await _context.SaveAsync(employee3);

            var contextExpression = new ContextExpression();
            contextExpression.SetFilter<Employee>(e => e.CompanyName == "Contoso");
            var queryConfig = new QueryConfig
            {
                Expression = contextExpression
            };

            var employees = await _context.QueryAsync<Employee>("Alice", queryConfig).GetNextSetAsync();
            Assert.Equal(1, employees.Count);
            Assert.Equal("Alice", employees[0].Name);

            employees = await _context.QueryAsync<Employee>("Charlie", queryConfig).GetNextSetAsync();
            Assert.Equal(1, employees.Count);
            Assert.Equal("Charlie", employees[0].Name);

            employees = await _context.QueryAsync<Employee>("Bob", queryConfig).GetNextSetAsync();
            Assert.Equal(0, employees.Count);
        }

        [Fact]
        public async Task TestContext_Query_QueryFilter_vs_ExpressionFilter()
        {
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
            await _context.SaveAsync(employee1);
            await _context.SaveAsync(employee2);
            await _context.SaveAsync(employee3);

            // 1. QueryFilter only: filter by ManagerName == "Eva"
            var queryFilter = new List<ScanCondition>
            {
                new ScanCondition("ManagerName", ScanOperator.Equal, "Eva")
            };
            var resultQueryFilter = await _context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                QueryFilter = queryFilter
            }).GetNextSetAsync();

            // 2. ExpressionFilter only: filter by ManagerName == "Eva"
            var contextExpression = new ContextExpression();
            contextExpression.SetFilter<Employee>(e => e.ManagerName == "Eva");
            var resultExpressionFilter = await _context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                Expression = contextExpression
            }).GetNextSetAsync();

            // Assert both results are equivalent
            Assert.Equal(resultQueryFilter.Count, resultExpressionFilter.Count);
            Assert.Equal(
                resultQueryFilter.Select(e => e.Age).OrderBy(x => x).ToList(),
                resultExpressionFilter.Select(e => e.Age).OrderBy(x => x).ToList()
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
            var resultActive = await _context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                QueryFilter = inactiveFilter,
                ConditionalOperator = ConditionalOperatorValues.And
            }).GetNextSetAsync();

            var resultBarbara = await _context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                Expression = contextExpressionBarbara
            }).GetNextSetAsync();

            Assert.Equal(resultActive.Count, resultBarbara.Count);
            Assert.Equal(
                resultActive.Select(e => e.Age).OrderBy(x => x).ToList(),
                resultBarbara.Select(e => e.Age).OrderBy(x => x).ToList()
            );
            // 4. QueryFilter with ConditionalOperator.Or (CurrentStatus == Active OR Score == 101)
            var orFilter = new List<ScanCondition>
            {
                new ScanCondition("CurrentStatus", ScanOperator.Equal, Status.Active),
                new ScanCondition("Score", ScanOperator.Equal, 101)
            };
            var resultOrQueryFilter = await _context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                QueryFilter = orFilter,
                ConditionalOperator = ConditionalOperatorValues.Or
            }).GetNextSetAsync();

            var contextExpressionOr = new ContextExpression();
            contextExpressionOr.SetFilter<Employee>(e => e.CurrentStatus == Status.Active || e.Score == 101);

            var resultOrExpressionFilter = await _context.QueryAsync<Employee>("Diane", new QueryConfig
            {
                Expression = contextExpressionOr
            }).GetNextSetAsync();

            // Assert both results are equivalent
            Assert.Equal(resultOrQueryFilter.Count, resultOrExpressionFilter.Count);
            Assert.Equal(
                resultOrQueryFilter.Select(e => e.Age).OrderBy(x => x).ToList(),
                resultOrExpressionFilter.Select(e => e.Age).OrderBy(x => x).ToList()
            );

            // 5. ExpressionFilter with index
            var resultIndex = await _context.QueryAsync<Employee>("Big River", new QueryConfig
            {
                IndexName = "GlobalIndex",
                Expression = contextExpression
            }).GetNextSetAsync();
            Assert.Equal(2, resultIndex.Count);
            Assert.True(resultIndex.All(e => e.ManagerName == "Eva"));
        }

        [Fact]
        public async Task Test_AutoGeneratedTimestampAttribute_With_Annotations_BatchWrite()
        {
            var entity = new EmployeeWithTimestampAndCounter
            {
                Name = "Alice",
                Age = 25,
                CompanyName = "TestCompany",
                Score = 10,
                ManagerName = "Bob"
            };

            var batch = _context.CreateBatchWrite<EmployeeWithTimestampAndCounter>();
            batch.AddPutItem(entity);
            await batch.ExecuteAsync();

            var loaded = await _context.LoadAsync<EmployeeWithTimestampAndCounter>(entity.Name, entity.Age, new LoadConfig { ConsistentRead = true });

            Assert.NotNull(loaded.LastUpdated);
            Assert.True((DateTime.UtcNow - loaded.LastUpdated.Value).TotalMinutes < 1, "LastUpdated should be recent");
        }

        [Fact]
        public async Task TestHashRangeObjects() => await TestHashRangeObjectsHelper<Employee>(_context);

        [Fact]
        public async Task TestOtherContextOperations() => await TestOtherContextOperationsHelper(_context);

        [Fact]
        public async Task TestTransactionOperations() => await TestTransactionOperationsHelper<VersionedEmployee>(_context);

        [Fact]
        public async Task TestAnnotatedTransactionOperations() => await TestTransactionOperationsHelper<VersionedAnnotatedEmployee>(_context);

        [Fact]
        public async Task TestEmptyStrings() => await TestEmptyStringsHelper(_context);

        [Fact]
        public async Task TestUnsupportedTypes()
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee2 = new Employee2
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            await Assert.ThrowsAsync<InvalidOperationException>(() => _context.SaveAsync(employee2));

            var employee3 = new Employee3
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            await Assert.ThrowsAsync<InvalidOperationException>(() => _context.SaveAsync(employee3));
        }

        [Fact]
        public async Task TestAnnotatedUnsupportedTypes()
        {
            // Verify that saving objects with invalid properties result in exceptions
            var employee4 = new Employee4
            {
                Name = "Alan",
                Age = 31,
                TimeWithCompany = TimeSpan.FromDays(300)
            };
            await Assert.ThrowsAsync<InvalidOperationException>(() => _context.SaveAsync(employee4));

            var employee5 = new Employee5
            {
                Name = "Alan",
                Age = 31,
                EmptyProperty = new EmptyType()
            };
            await Assert.ThrowsAsync<InvalidOperationException>(() => _context.SaveAsync(employee5));

            // Verify that objects that are invalid result in exceptions
            await Assert.ThrowsAsync<InvalidOperationException>(() => _context.ScanAsync<TimeSpan>(new List<ScanCondition>()).GetNextSetAsync());
            await Assert.ThrowsAsync<InvalidOperationException>(() => _context.ScanAsync<EmptyType>(new List<ScanCondition>()).GetNextSetAsync());
        }

        [Fact]
        public async Task Test_LoadAsync_WithProjectionExpression_AndReservedWords()
        {
            var productReview1 = new ProductReviews()
            {
                Id = 1,
                Comment = "Comment",
                Date = DateTime.Now,
            };
            var productReview2 = new ProductReviews()
            {
                Id = 2,
                Comment = "Review",
                Date = DateTime.Now,
            };
            var productReview3 = new ProductReviews()
            {
                Id = 3,
                Comment = "Date",
                Date = DateTime.Now,
            };

            await _context.SaveAsync(productReview1);
            await _context.SaveAsync(productReview2);
            await _context.SaveAsync(productReview3);

            var savedProduct1 = await _context.LoadAsync<ProductReviews>(1);
            var savedProduct2 = await _context.LoadAsync<ProductReviews>(2);
            var savedProduct3 = await _context.LoadAsync<ProductReviews>(3);

            Assert.Equal(productReview1.Comment, savedProduct1.Comment);
            Assert.Equal(productReview2.Comment, savedProduct2.Comment);
            Assert.Equal(productReview3.Comment, savedProduct3.Comment);
            ApproximatelyEqual(productReview1.Date.ToUniversalTime(), savedProduct1.Date);
            ApproximatelyEqual(productReview2.Date.ToUniversalTime(), savedProduct2.Date);
            ApproximatelyEqual(productReview3.Date.ToUniversalTime(), savedProduct3.Date);
        }

        [Fact]
        public async Task Test_LoadAsync_WithProjectionExpression()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Product name",
                CompanyName = "Company name",
                Price = 123,
                Map = new Dictionary<string, string> // M
                {
                    {
                        "Position", "Position map"
                    }
                },
                CompanyInfo = new CompanyInfo // L
                {
                    Name = "Company info name",
                    AllProducts = new List<Product>
                    {
                        new Product { Id = 12, Name = "product name 2", IsPublic = true }
                    },
                },
                Components = new List<string> // SS
                {
                    string.Empty
                }
            };

            await _context.SaveAsync(product);

            var savedProduct = await _context.LoadAsync<Product>(1);
            Assert.Equal(product.CompanyName, savedProduct.CompanyName);
            Assert.Equal(product.Name, savedProduct.Name);
            Assert.Equal(product.Price, savedProduct.Price);
            Assert.Equal(product.Map.Count, savedProduct.Map.Count);
            Assert.Equal(product.Map["Position"], savedProduct.Map["Position"]);
            Assert.Equal(product.CompanyInfo.Name, savedProduct.CompanyInfo.Name);
            Assert.Equal(product.CompanyInfo.AllProducts.Count, savedProduct.CompanyInfo.AllProducts.Count);
            Assert.Equal(product.CompanyInfo.AllProducts[0].Name, savedProduct.CompanyInfo.AllProducts[0].Name);
            Assert.Equal(product.CompanyInfo.AllProducts[0].IsPublic, savedProduct.CompanyInfo.AllProducts[0].IsPublic);
            Assert.Equal(product.CompanyInfo.AllProducts[0].Id, savedProduct.CompanyInfo.AllProducts[0].Id);
            Assert.Equal(product.Components.Count, savedProduct.Components.Count);
            Assert.Equal(product.Components[0], savedProduct.Components[0]);
        }


        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestDerivedPropertyOverrides(DynamoDBEntryConversion conversion)
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = conversion;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = false;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                var d = new Derived { Name = "Norm", Age = 1000, Data = "Man of the woods" };
                await context.SaveAsync(d);

                var loaded = await context.LoadAsync<Derived>(d.Name, d.Age);
                Assert.Equal(d.Name, loaded.Name);
                Assert.Equal(d.Age, loaded.Age);
                Assert.Equal(d.Data, loaded.Data);

                await context.DeleteAsync(loaded);
            }
        }

        [Theory]
        [MemberData(nameof(DynamoDBFixture.Conversions), MemberType = typeof(DynamoDBFixture))]
        public async Task TestDerivedProperties_MaskedUsingNew(DynamoDBEntryConversion conversion)
        {
            using (var context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = conversion;
                    x.ConsistentRead = true;
                    x.IsEmptyStringValueEnabled = false;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                })
                .Build())
            {
                var d = new DerivedClassExample { Name = "Name", Age = 200, Data = "Test data" };
                await context.SaveAsync(d);

                var loaded = await context.LoadAsync<DerivedClassExample>(d.Name, d.Age);
                Assert.Equal(d.Name, loaded.Name);
                Assert.Equal(d.Age, loaded.Age);
                Assert.Equal(d.Data, loaded.Data);

                await context.DeleteAsync(loaded);
            }
        }
    }
}
