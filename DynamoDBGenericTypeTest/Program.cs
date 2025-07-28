using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace DynamoDBGenericTypeTest
{
    [DynamoDBTable("QuoteResponse")]
    public class QuoteResponse
    {

        [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(DynamoDBGenericTypeTest.CarQuoteResponse))]
        // [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(List<DynamoDBGenericTypeTest.CarQuoteExcess>))]
        [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(DynamoDBGenericTypeTest.CarQuoteExcess))]
        public QuoteResponse()
        {
        }

        /// <summary>
        /// Quote Request Id
        /// </summary>
        [DynamoDBHashKey]
        public required string Id { get; init; }

        /// <summary>
        /// Guid for Quote
        /// </summary>
        [DynamoDBRangeKey]
        public required string Insurer { get; init; }

        /// <summary>
        /// The row is considered "dead" on or after this time (Epoch time)
        ///  - Will be a short time after the expected next heartbeat time
        /// </summary>        
        [DynamoDBProperty("Live")]
        public long LiveTime { get; init; }

        /// <summary>
        /// Vehicle Registration Number
        /// </summary>
        [DynamoDBProperty("CarQuoteResponse")]
        public required CarQuoteResponse CarQuoteResponse { get; init; }
    }

    public class CarQuoteResponse
    {
        public string Insurer { get; set; } = string.Empty;
        public bool Successful { get; set; }
        public long ElapsedMs { get; set; }
        public decimal? TotalAnnual { get; set; }
        public string QuoteRef { get; set; } = string.Empty;
        public string QuoteRefUrl { get; set; } = string.Empty;
        public bool CanEmail { get; set; }
        public bool EmailSent { get; set; }
        public string? AddressText { get; set; }
        public string? VehicleDescription { get; set; }
        public List<CarQuoteExcess> Excesses { get; set; } = new List<CarQuoteExcess>();
        public string FailureReason { get; set; } = string.Empty;
        public bool CanDisplayFailure { get; set; }
    }

    public class CarQuoteExcess
    {
        public string Description { get; set; } = string.Empty;
        public decimal? Excess { get; set; }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("DynamoDB Generic Collection Test");
            Console.WriteLine("==============================");

            // Create DynamoDB client connecting to real AWS service in us-west-2
            var config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var client = new AmazonDynamoDBClient(config);
            var context = new DynamoDBContext(client);

            try
            {
                // Ensure table exists (create if not)
                Console.WriteLine("Checking/creating test table...");
                await CreateTableIfNotExists(client);

                // Create test data
                string testId = "test-" + Guid.NewGuid().ToString().Substring(0, 8);
                
                var testQuote = new QuoteResponse
                {
                    Id = testId,
                    Insurer = "TestInsurer",
                    LiveTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 3600, // 1 hour from now
                    CarQuoteResponse = new CarQuoteResponse
                    {
                        Insurer = "TestInsurer",
                        Successful = true,
                        ElapsedMs = 150,
                        TotalAnnual = 500.00M,
                        QuoteRef = "Q123456",
                        CanEmail = true,
                        EmailSent = false,
                        AddressText = "123 Test Street",
                        VehicleDescription = "2020 Test Vehicle",
                        Excesses = new List<CarQuoteExcess>
                        {
                            new CarQuoteExcess { Description = "Standard", Excess = 250.00M },
                            new CarQuoteExcess { Description = "Windscreen", Excess = 75.00M }
                        },
                        FailureReason = "",
                        CanDisplayFailure = false
                    }
                };

                // Save the test data to DynamoDB
                Console.WriteLine($"Saving test quote with ID: {testId}");
                await context.SaveAsync(testQuote);
                Console.WriteLine("Save successful");

                // Read data back using QueryAsync - this is where the original error occurs
                Console.WriteLine($"Querying for Id: {testId}");
                CancellationTokenSource cts = new CancellationTokenSource(3000); // 3 seconds timeout
                var results = await context.QueryAsync<QuoteResponse>(testId).GetRemainingAsync(cts.Token);

                Console.WriteLine($"Query successful - found {results.Count} items");
                
                if (results.Count > 0)
                {
                    var retrievedQuote = results[0];
                    Console.WriteLine($"Retrieved: Id={retrievedQuote.Id}, Insurer={retrievedQuote.Insurer}");
                    
                    if (retrievedQuote.CarQuoteResponse != null && retrievedQuote.CarQuoteResponse.Excesses != null)
                    {
                        Console.WriteLine($"Excesses count: {retrievedQuote.CarQuoteResponse.Excesses.Count}");
                        foreach (var excess in retrievedQuote.CarQuoteResponse.Excesses)
                        {
                            Console.WriteLine($"  - {excess.Description}: {excess.Excess?.ToString("C")}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No excesses found or CarQuoteResponse is null");
                    }
                }

                Console.WriteLine("\nTest PASSED: Successfully retrieved list of custom type objects!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine(ex.StackTrace);
                
                // Show inner exception details if available
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                    Console.WriteLine(ex.InnerException.StackTrace);
                }
            }

            Console.WriteLine("\nTest complete. Press any key to exit.");
            Console.ReadKey();
        }

        private static async Task CreateTableIfNotExists(IAmazonDynamoDB client)
        {
            try
            {
                // Check if table exists
                try
                {
                    await client.DescribeTableAsync("QuoteResponse");
                    Console.WriteLine("Table QuoteResponse already exists");
                    return;
                }
                catch (ResourceNotFoundException)
                {
                    // Table doesn't exist, we'll create it
                }

                // Create the table
                var request = new CreateTableRequest
                {
                    TableName = "QuoteResponse",
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition { AttributeName = "Id", AttributeType = "S" },
                        new AttributeDefinition { AttributeName = "Insurer", AttributeType = "S" }
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement { AttributeName = "Id", KeyType = "HASH" },
                        new KeySchemaElement { AttributeName = "Insurer", KeyType = "RANGE" }
                    },
                    BillingMode = BillingMode.PAY_PER_REQUEST
                };

                var response = await client.CreateTableAsync(request);
                Console.WriteLine($"Created table QuoteResponse with status: {response.TableDescription.TableStatus}");

                // Wait for the table to be active
                bool isTableActive = false;
                while (!isTableActive)
                {
                    var describeResponse = await client.DescribeTableAsync("QuoteResponse");
                    isTableActive = describeResponse.Table.TableStatus == TableStatus.ACTIVE;
                    if (!isTableActive)
                    {
                        Console.WriteLine("Waiting for table to become active...");
                        await Task.Delay(1000); // Wait 1 second before checking again
                    }
                }
                Console.WriteLine("Table is now active");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating/checking table: {ex.Message}");
                throw;
            }
        }
    }
}
