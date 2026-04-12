using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.Fixtures;
using static AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB.DataModelContextTestHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDB
{
    [Trait("Category", "DynamoDBv2")]
    public class DataModelNumericHashRangeTests : IClassFixture<NumericHashRangeTableFixture>, IAsyncLifetime
    {
        private readonly NumericHashRangeTableFixture _fixture;
        private DynamoDBContext _context;

        private static readonly DateTime EpochDate = DateTime.UtcNow.AddDays(7);
        private static readonly DateTime LongEpochDate = new DateTime(2039, 1, 1, 2, 13, 23, DateTimeKind.Utc);

        public DataModelNumericHashRangeTests(NumericHashRangeTableFixture fixture)
        {
            _fixture = fixture;
        }

        public async ValueTask InitializeAsync()
        {
            _context = new DynamoDBContextBuilder()
                .WithDynamoDBClient(() => _fixture.Client)
                .ConfigureContext(x =>
                {
                    x.Conversion = DynamoDBEntryConversion.V2;
                    x.IsEmptyStringValueEnabled = true;
                    x.DisableFetchingTableMetadata = true;
                    x.TableNamePrefix = _fixture.TableNamePrefix;
                    x.ConsistentRead = true;
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
        public async Task TestContext_DisableFetchingTableMetadata_DateTimeAsHashKey()
        {
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

            await _context.SaveAsync(employee);
            var storedEmployee = await _context.LoadAsync<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
            Assert.NotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            ApproximatelyEqual(EpochDate, storedEmployee.EpochDate2);
            ApproximatelyEqual(EpochDate, storedEmployee.NonEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NonEpochDate2);
            Assert.Null(storedEmployee.NullableEpochDate1);
            ApproximatelyEqual(EpochDate, storedEmployee.NullableEpochDate2.Value);
            ApproximatelyEqual(LongEpochDate, storedEmployee.LongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddDays(12), storedEmployee.LongEpochDate2);
            Assert.Null(storedEmployee.NullableLongEpochDate1);
            ApproximatelyEqual(LongEpochDate.AddDays(50), storedEmployee.NullableLongEpochDate2.Value);
            Assert.Equal(employee.Name, storedEmployee.Name);
            Assert.Equal(employee.Age, storedEmployee.Age);
        }

        /// <summary>
        /// Tests that disabling fetching table metadata works with a key that has a property converter.
        /// </summary>
        [Fact]
        public async Task TestContext_DisableFetchingTableMetadata_KeyWithPropertyConverter()
        {
            var employee = new PropertyConverterEmployee
            {
                Name = Status.Active,
                CreationTime = EpochDate,
            };

            await _context.SaveAsync(employee);
            var storedEmployee = await _context.LoadAsync<PropertyConverterEmployee>(employee.CreationTime, employee.Name);
            Assert.NotNull(storedEmployee);
            ApproximatelyEqual(EpochDate, storedEmployee.CreationTime);
            Assert.Equal(employee.Name, storedEmployee.Name);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task TestContext_RetrieveDateTimeInUtc(bool retrieveDateTimeInUtc)
        {
            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
                RetrieveDateTimeInUtc = retrieveDateTimeInUtc,
                TableNamePrefix = _fixture.TableNamePrefix,
                ConsistentRead = true
            };
            using (var context = new DynamoDBContext(_fixture.Client, config))
            {
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

                await context.SaveAsync(employee);

                //This is a valid use of .ToLocalTime
                var expectedCurrTime = retrieveDateTimeInUtc ? currTime.ToUniversalTime() : currTime.ToLocalTime();
                var expectedLongEpochTime =
                    retrieveDateTimeInUtc ? longEpochTime.ToUniversalTime() : longEpochTime.ToLocalTime();
                var expectedLongEpochTimeBefore1970 = retrieveDateTimeInUtc
                    ? longEpochTimeBefore1970.ToUniversalTime()
                    : longEpochTimeBefore1970.ToLocalTime();

                // Load
                var storedEmployee = await context.LoadAsync<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                Assert.Null(storedEmployee.NullableEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
                Assert.Null(storedEmployee.NullableLongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);

                // Query
                QueryFilter filter = new QueryFilter();
                filter.AddCondition("CreationTime", QueryOperator.Equal, currTime);
                storedEmployee = (await context.FromQueryAsync<AnnotatedNumericEpochEmployee>(
                    new QueryOperationConfig { Filter = filter, ConsistentRead = true }
                ).GetNextSetAsync()).First();
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                Assert.Null(storedEmployee.NullableEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
                Assert.Null(storedEmployee.NullableLongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);

                // Scan
                storedEmployee = (await context.ScanAsync<AnnotatedNumericEpochEmployee>(new List<ScanCondition>()).GetRemainingAsync()).First();
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                Assert.Null(storedEmployee.NullableEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NullableEpochDate2.Value);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
                Assert.Null(storedEmployee.NullableLongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);
            }
        }

        /// <summary>
        /// Tests that if a custom <see cref="DateTime"/> converter is used, then the <see cref="DynamoDBContextConfig.RetrieveDateTimeInUtc"/> is ignored.
        /// </summary>
        /// <param name="retrieveDateTimeInUtc"></param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task TestContext_CustomDateTimeConverter(bool retrieveDateTimeInUtc)
        {
            var config = new DynamoDBContextConfig
            {
                Conversion = DynamoDBEntryConversion.V2,
                RetrieveDateTimeInUtc = retrieveDateTimeInUtc,
                TableNamePrefix = _fixture.TableNamePrefix,
                ConsistentRead = true
            };
            using (var context = new DynamoDBContext(_fixture.Client, config))
            {
                // Add a custom DateTime converter
                context.ConverterCache.Add(typeof(DateTime), new DateTimeUtcConverter());
                context.ConverterCache.Add(typeof(DateTime?), new DateTimeUtcConverter());

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

                await context.SaveAsync(employee);

                // Since we are adding a custom DateTimeUtcConverter, the expected time will be in the UTC time zone regardless of RetrieveDateTimeInUtc value.
                // for the properties that does not have property specific attributes like [DynamoDBProperty(StoreAsEpochLong = true)].

                var expectedCurrTime = currTime.ToUniversalTime();
                var expectedCurrTimeStoreAsEpoch = retrieveDateTimeInUtc ? currTime.ToUniversalTime() : currTime.ToLocalTime();
                var expectedLongEpochTime = retrieveDateTimeInUtc ? longEpochTime.ToUniversalTime() : longEpochTime.ToLocalTime();
                var expectedLongEpochTimeBefore1970 = retrieveDateTimeInUtc ? longEpochTimeBefore1970.ToUniversalTime() : longEpochTimeBefore1970.ToLocalTime();

                // Load
                var storedEmployee = await context.LoadAsync<AnnotatedNumericEpochEmployee>(employee.CreationTime, employee.Name);
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                Assert.Null(storedEmployee.NullableEpochDate1);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.NullableEpochDate2.Value);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
                Assert.Null(storedEmployee.NullableLongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);

                // Query
                QueryFilter filter = new QueryFilter();
                filter.AddCondition("CreationTime", QueryOperator.Equal, currTime);
                storedEmployee = (await context.FromQueryAsync<AnnotatedNumericEpochEmployee>(
                    new QueryOperationConfig { Filter = filter, ConsistentRead = true }
                ).GetNextSetAsync()).First();
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                Assert.Null(storedEmployee.NullableEpochDate1);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.NullableEpochDate2.Value);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
                Assert.Null(storedEmployee.NullableLongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);

                // Scan
                storedEmployee = (await context.ScanAsync<AnnotatedNumericEpochEmployee>(new List<ScanCondition>()).GetRemainingAsync()).First();
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                Assert.Null(storedEmployee.NullableEpochDate1);
                ApproximatelyEqual(expectedCurrTimeStoreAsEpoch, storedEmployee.NullableEpochDate2.Value);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.NullableLongEpochDate1.Value);
                Assert.Null(storedEmployee.NullableLongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);
            }
        }

        /// <summary>
        /// Tests that the DynamoDB operations can retrieve <see cref="DateTime"/> attributes in UTC and local timezone using the <see cref="DynamoDBOperationConfig"/>
        /// </summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task TestContext_RetrieveDateTimeInUtc_OperationConfig(bool retrieveDateTimeInUtc)
        {
            using (var context = new DynamoDBContext(_fixture.Client, new DynamoDBContextConfig { Conversion = DynamoDBEntryConversion.V2, ConsistentRead = true, TableNamePrefix = _fixture.TableNamePrefix }))
            {
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

                await context.SaveAsync(employee);

                //This is a valid use of .ToLocalTime
                var expectedCurrTime = retrieveDateTimeInUtc ? currTime.ToUniversalTime() : currTime.ToLocalTime();
                var expectedLongEpochTime =
                    retrieveDateTimeInUtc ? longEpochTime.ToUniversalTime() : longEpochTime.ToLocalTime();
                var expectedLongEpochTimeBefore1970 = retrieveDateTimeInUtc
                    ? longEpochTimeBefore1970.ToUniversalTime()
                    : longEpochTimeBefore1970.ToLocalTime();

                // Load
                var storedEmployee = await context.LoadAsync<AnnotatedNumericEpochEmployee>(
                    employee.CreationTime,
                    employee.Name,
                    new LoadConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc }
                );
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);

                // Query
                QueryFilter filter = new QueryFilter();
                filter.AddCondition("CreationTime", QueryOperator.Equal, currTime);
                storedEmployee = (await context.FromQueryAsync<AnnotatedNumericEpochEmployee>(
                    new QueryOperationConfig { Filter = filter, ConsistentRead = true },
                    new FromQueryConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc }
                    )
                    .GetNextSetAsync())
                    .First();
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);

                // Scan
                storedEmployee = (await context.ScanAsync<AnnotatedNumericEpochEmployee>(
                    new List<ScanCondition>(),
                    new ScanConfig { RetrieveDateTimeInUtc = retrieveDateTimeInUtc })
                    .GetRemainingAsync())
                    .First();
                Assert.NotNull(storedEmployee);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.CreationTime);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.EpochDate2);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate1);
                ApproximatelyEqual(expectedCurrTime, storedEmployee.NonEpochDate2);
                ApproximatelyEqual(expectedLongEpochTime, storedEmployee.LongEpochDate1);
                ApproximatelyEqual(expectedLongEpochTimeBefore1970, storedEmployee.LongEpochDate2);
                Assert.Equal(employee.Name, storedEmployee.Name);
                Assert.Equal(employee.Age, storedEmployee.Age);
            }
        }
    }
}
