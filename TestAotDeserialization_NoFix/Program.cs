using System.Diagnostics.CodeAnalysis;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.Model;
using System.Net;

namespace TestAotDeserialization_NoFix;

// This version intentionally does NOT include DynamicDependency attributes
// It should fail when deserializing List<CarQuoteExcess> in Native AOT
[DynamoDBTable("TestQuotes")]
public class QuoteResponse
{
    // No DynamicDependency attributes here - this is what we're testing!

    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(CarQuoteResponse))]
    [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(List<CarQuoteExcess>))]
    // [DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(CarQuoteExcess))]
    public QuoteResponse()
    {
    }

    [DynamoDBHashKey]
    public string Id { get; init; } = string.Empty;

    [DynamoDBRangeKey]
    public string Insurer { get; init; } = string.Empty;

    [DynamoDBProperty("Live")]
    public long LiveTime { get; init; }

    [DynamoDBProperty("CarQuoteResponse")]
    public CarQuoteResponse CarQuoteResponse { get; init; } = new();
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
    private static readonly RegionEndpoint region = RegionEndpoint.USWest2;
    private const string TableName = "TestQuotes";

    static async Task Main(string[] args)
    {
        try
        {
            Console.WriteLine("Starting DynamoDB Native AOT Test WITHOUT DynamicDependency Fix");
            Console.WriteLine("======================================================");

            // Initialize DynamoDB client
            var config = new AmazonDynamoDBConfig
            {
                RegionEndpoint = region
            };

            var client = new AmazonDynamoDBClient(config);
            var context = new DynamoDBContext(client);

            // Step 1: Create table if it doesn't exist
            await EnsureTableExists(client, TableName);

            // Step 2: Insert test data
            string id = "test-id-" + DateTime.UtcNow.Ticks;
            await InsertTestData(context, id);

            // Step 3: Query data and attempt to deserialize
            Console.WriteLine("\nAttempting to query and deserialize data:");
            try
            {
                await QueryData(context, id);
                Console.WriteLine("SUCCESS: No exception was thrown! The issue may have been fixed in the SDK.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FAILURE: Exception occurred: {ex.Message}");
                Console.WriteLine($"Exception type: {ex.GetType().FullName}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                Console.WriteLine("\nThis confirms the issue exists without DynamicDependency attributes.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.WriteLine($"Stack trace: {ex.StackTrace}");
        }

        Console.WriteLine("\nTest completed. Press any key to exit.");
        Console.ReadKey();
    }

    static async Task EnsureTableExists(IAmazonDynamoDB client, string tableName)
    {
        Console.WriteLine($"Checking if table '{tableName}' exists...");

        try
        {
            var tableDescription = await client.DescribeTableAsync(tableName);
            Console.WriteLine($"Table '{tableName}' already exists");
        }
        catch (ResourceNotFoundException)
        {
            Console.WriteLine($"Table '{tableName}' does not exist, creating...");

            var request = new CreateTableRequest
            {
                TableName = tableName,
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
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 5,
                    WriteCapacityUnits = 5
                }
            };

            var response = await client.CreateTableAsync(request);
            Console.WriteLine($"Table '{tableName}' created successfully, waiting for it to be active...");

            bool isTableActive = false;
            while (!isTableActive)
            {
                var tableStatus = await client.DescribeTableAsync(tableName);
                isTableActive = tableStatus.Table.TableStatus == TableStatus.ACTIVE;
                if (!isTableActive)
                {
                    Console.WriteLine("Table is being created, waiting 5 seconds...");
                    await Task.Delay(5000);
                }
            }

            Console.WriteLine($"Table '{tableName}' is now active");
        }
    }

    static async Task InsertTestData(DynamoDBContext context, string id)
    {
        Console.WriteLine($"Inserting test data...");

        var excesses = new List<CarQuoteExcess>
        {
            new CarQuoteExcess { Description = "Standard Excess", Excess = 250.00m },
            new CarQuoteExcess { Description = "Voluntary Excess", Excess = 100.00m },
            new CarQuoteExcess { Description = "Young Driver Excess", Excess = 300.00m }
        };

        var carQuoteResponse = new CarQuoteResponse
        {
            Insurer = "TestInsurer",
            Successful = true,
            ElapsedMs = 1500,
            TotalAnnual = 450.75m,
            QuoteRef = "Q12345",
            QuoteRefUrl = "https://example.com/quote/Q12345",
            CanEmail = true,
            EmailSent = false,
            AddressText = "123 Test Street, Test City",
            VehicleDescription = "2022 Test Car Model",
            Excesses = excesses,
            FailureReason = string.Empty,
            CanDisplayFailure = false
        };

        var quoteResponse = new QuoteResponse
        {
            Id = id,
            Insurer = "TestInsurer",
            LiveTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() + 86400, // 24 hours from now
            CarQuoteResponse = carQuoteResponse
        };

        // Override the table name
        var config = new DynamoDBOperationConfig { OverrideTableName = TableName };
        await context.SaveAsync(quoteResponse, config);

        Console.WriteLine("Test data inserted successfully");
    }

    static async Task QueryData(DynamoDBContext context, string id)
    {
        Console.WriteLine($"Querying data with Id '{id}'...");

        var config = new DynamoDBOperationConfig
        {
            OverrideTableName = TableName,
            ConsistentRead = true
        };

        try
        {
            var results = await context.QueryAsync<QuoteResponse>(id, config).GetRemainingAsync();
            
            Console.WriteLine($"Successfully retrieved {results.Count} items");
            
            if (results.Count > 0)
            {
                Console.WriteLine("Data successfully deserialized!");
                Console.WriteLine("Accessing the nested List<CarQuoteExcess>...");
                
                // Access the nested list - this is where we expect failure without DynamicDependency
                var excesses = results[0].CarQuoteResponse.Excesses;
                Console.WriteLine($"Excesses list contains {excesses.Count} items");
                
                // Print each excess to prove it's working
                foreach (var excess in excesses)
                {
                    Console.WriteLine($"  * {excess.Description}: {excess.Excess:C}");
                }
            }
            else
            {
                Console.WriteLine("No items found with the given ID.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to deserialize the List<CarQuoteExcess> property");
            throw; // Re-throw to be caught by the outer try/catch
        }
    }
}
