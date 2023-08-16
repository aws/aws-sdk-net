/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal.Util;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Text.Json;

namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(methodOrderPolicy: MethodOrderPolicy.Declared)]
    public class DynamoBenchmarks
    {
        private const string SampleDataFolder = "sample_data";
        private string _tableName;

        private static string _workingDirectory = Environment.CurrentDirectory;
        private static string sampleDataDirectory = Path.Combine(_workingDirectory, SampleDataFolder);
        private static string _sampleDataPath = Path.Combine(sampleDataDirectory, "books.json");

        private QueryRequest _queryRequest;
        private IAmazonDynamoDB? _dynamoDbClient;
        private PutItemRequest? _putItemRequest;
        private List<string>? _bookTitleList;
        private GetItemRequest? _getItemRequest;
        private Document _putItemDocument;
        private Table? _table;
        private List<GetItemRequest> _getItemRequests;
        private QueryFilter? _queryFilter;
        private DynamoDBContext _dynamoDbContext;
        private Book? _book;
        private List<ScanCondition>? _scanConditions;
        private DynamoDBOperationConfig _dynamoDbOperationConfig;
        private DynamoDBContextConfig _dynamoDBContextConfig;
        #region LowLevelAPI
        [GlobalSetup(Target = nameof(DDBLowLevelGetItemAsync))]
        public async Task SetupForGetItem()
        {
            await CommonSetup().ConfigureAwait(false);
            // choose a random book title, by selecting a number between 1 and 100

            Random random = new Random();
            int bookTitleIndex = random.Next(0, 100);
            _getItemRequest = new GetItemRequest()
            {
                TableName = _tableName,
                Key = new Dictionary<string, AttributeValue>() { { "author", new AttributeValue() { S = "John Doe" } }, { "title", new AttributeValue() { S = _bookTitleList[bookTitleIndex] } } }
            };
        }

        /// <summary>
        /// Test DynamoDB Get Item with 1 item containing 10 attributes
        /// </summary>
        [Benchmark]
        public async Task DDBLowLevelGetItemAsync()
        {
            await _dynamoDbClient.GetItemAsync(_getItemRequest).ConfigureAwait(false);
        }

        [GlobalSetup(Target = nameof(DDBLowLevelPutAsync))]
        public async Task SetupForDDBLowLevelPutItemAsync()
        {
            _dynamoDbClient = new AmazonDynamoDBClient();
            _tableName = Utils.GenerateName("books");
            await CreateTable(_dynamoDbClient).ConfigureAwait(false);
            _putItemRequest = new PutItemRequest()
            {
                TableName = _tableName,
                Item = new Dictionary<string, AttributeValue>
                {
                    { "author", new AttributeValue("John Doe") } ,
                    { "title", new AttributeValue("Test for PutItem") },
                    { "genre", new AttributeValue("Documentary") },
                    { "isbn", new AttributeValue("1234566-0")},
                    {"price", new AttributeValue("$12.12") },
                    {"rating", new AttributeValue{N = "9" } },
                    { "number_of_pages", new AttributeValue{N = "200"} },
                    {"is_available", new AttributeValue{BOOL = true } },
                    {"address", new AttributeValue("1234 street") },
                    {"address2", new AttributeValue("apt 222") }

                }
            };
        }
        /// <summary>
        /// PutItem using the low level api for an item with 10 attributes
        /// </summary>
        [MinIterationCount(15), MaxIterationCount(50)]
        [Benchmark]
        public async Task DDBLowLevelPutAsync()
        {
            await _dynamoDbClient.PutItemAsync(_putItemRequest);
        }

        [GlobalSetup(Target = nameof(DDBLowLevelQueryAsync))]
        public async Task SetupForQueryAsync()
        {
            await CommonSetup().ConfigureAwait(false);
            _queryRequest = new QueryRequest()
            {
                TableName = _tableName,
                KeyConditionExpression = "author = :author",
                ExpressionAttributeValues = new Dictionary<string, AttributeValue>
                    {
                        {":author", new AttributeValue{S="John Doe" } }
                    }
            };
        }

        /// <summary>
        /// Test DynamoDB Query using the low level api that returns 100 items.
        /// </summary>
        [MinIterationCount(15), MaxIterationCount(50)]
        [Benchmark]
        public async Task DDBLowLevelQueryAsync()
        {
            await _dynamoDbClient.QueryAsync(_queryRequest).ConfigureAwait(false);
        }

        #endregion

        #region DocModel
        [GlobalSetup(Target = nameof(DDBDocModelGetItem))]
        public async Task SetupForDDBDocModelGetItem()
        {
            _dynamoDbClient = new AmazonDynamoDBClient();
            _tableName = Utils.GenerateName("books");
            await CreateTable(_dynamoDbClient).ConfigureAwait(false);
            await FillTable(_tableName).ConfigureAwait(false);
            _table = Table.LoadTable(_dynamoDbClient, _tableName);
        }

        /// <summary>
        /// GetItemAsync using the document model to return an item with 10 attributes
        /// </summary>
        [Benchmark]
        public async Task DDBDocModelGetItem()
        {
            await _table.GetItemAsync("John Doe", "Whispering Shadows").ConfigureAwait(false);
        }

        [GlobalSetup(Target = nameof(DDBDocModelPutItem))]
        public async Task SetupForDDBDocModelTestPutItem()
        {
            await CommonSetup().ConfigureAwait(false);

            _table = Table.LoadTable(_dynamoDbClient, _tableName);
            _putItemDocument = new Document
            {
                ["author"] = "John Doe",
                ["title"] = "Test title for Put Item",
                ["genre"] = "Documentary",
                ["isbn"] = "100206171-9",
                ["price"] = "$12.12",
                ["rating"] = 9,
                ["number_of_pages"] = 200,
                ["is_available"] = true,
                ["address"] = "343 American Ash Circle",
                ["address_2"] = "22"
            };
        }

        /// <summary>
        /// Test DynamoDB Put Item with an item containing 10 attributes
        /// </summary>
        [MinIterationCount(15), MaxIterationCount(50)]
        [Benchmark]
        public async Task DDBDocModelPutItem()
        {
            await _table.PutItemAsync(_putItemDocument).ConfigureAwait(false);
        }

        [GlobalSetup(Target =nameof(DDBDocModelQuery))]
        public async Task SetupForDDBDocModelQuery()
        {
            await CommonSetup().ConfigureAwait(false);

            _table = Table.LoadTable(_dynamoDbClient, _tableName);
            _queryFilter = new QueryFilter("author",QueryOperator.Equal,"John Doe");
        }

        /// <summary>
        /// Test Query using the DDB Document model, which will return 100 items.
        /// </summary>
        [MinIterationCount(15), MaxIterationCount(50)]
        [Benchmark]
        public async Task DDBDocModelQuery()
        {
            await _table.Query(_queryFilter).GetRemainingAsync().ConfigureAwait(false);
        }

        #endregion

        #region DDBContext

        [GlobalSetup(Target = nameof(DDBContextGetItem))]
        public async Task SetupForDDBContextGetItem()
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient);
        }

        /// <summary>
        /// Test DynamoDB GetItem using the object persistence model to return one item with 10 attributes
        /// </summary>
        [Benchmark]
        public async Task DDBContextGetItem()
        {
            await _dynamoDbContext.LoadAsync<Book>("John Doe", "Whispering Shadows",_dynamoDbOperationConfig).ConfigureAwait(false);
        }

        [GlobalSetup(Target =nameof(DDBContextPutItem))]
        public async Task SetupForDDBContextPutItem()
        {
            _dynamoDbClient = new AmazonDynamoDBClient();
            _tableName = Utils.GenerateName("books");
            await CreateTable(_dynamoDbClient).ConfigureAwait(false);
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient);
            _book = new Book
            {
                Author = "John Doe",
                Title = "Whispering Shadows",
                Genre = "Documentary",
                ISBN = "100390234-123",
                Price = "5.13",
                Rating = 3,
                Number_Of_Pages = 104,
                Is_Available = true,
                Address = "343 American Ash Circle",
                Address2 = "Apt 274"
            };
            _dynamoDbOperationConfig = new DynamoDBOperationConfig { OverrideTableName= _tableName };
        }

        /// <summary>
        /// Test DynamoDB PutItem using the object persistence model for an item with 10 attributes
        /// </summary>
        [MinIterationCount(15), MaxIterationCount(50)]
        [Benchmark]
        public async Task DDBContextPutItem()
        {
            await _dynamoDbContext.SaveAsync(_book,_dynamoDbOperationConfig).ConfigureAwait(false);
        }

        [GlobalSetup(Target =nameof(DDBContextQuery))]
        public async Task SetupForDDBContextQuery()
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient);

        }

        /// <summary>
        /// Test querying the table using the object persistence model which will return 100 items.
        /// </summary>
        [MinIterationCount(15), MaxIterationCount(50)]
        [Benchmark]
        public async Task DDBContextQuery()
        {
            await _dynamoDbContext.QueryAsync<Book>("John Doe",_dynamoDbOperationConfig).GetRemainingAsync().ConfigureAwait(false);
        }

        #endregion

        #region ObjectPersistenceColdStart
        [GlobalSetup(Target = nameof(DDBContextColdStartGetItem))]
        public async Task SetupForDDBContextColdStartGetItem()
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDBContextConfig = new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = false
            };
        }

        /// <summary>
        /// Test ColdStart for GetItem using object persistence model and DisableFetchingTableMetadata to false
        /// </summary>
        [Benchmark]
        public async Task DDBContextColdStartGetItem()
        {
            SdkCache.Clear();
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient, _dynamoDBContextConfig);
            await _dynamoDbContext.LoadAsync<Book>("John Doe", "Whispering Shadows", _dynamoDbOperationConfig).ConfigureAwait(false);
        }

        [GlobalSetup(Target =nameof(DDBContextColdStartPutItem))]
        public async Task SetupForDDBContextColdStartPutItem()
        {
            _dynamoDbClient = new AmazonDynamoDBClient();
            _tableName = Utils.GenerateName("books");
            await CreateTable(_dynamoDbClient).ConfigureAwait(false);
            _book = new Book
            {
                Author = "John Doe",
                Title = "Whispering Shadows",
                Genre = "Documentary",
                ISBN = "100390234-123",
                Price = "5.13",
                Rating = 3,
                Number_Of_Pages = 104,
                Is_Available = true,
                Address = "343 American Ash Circle",
                Address2 = "Apt 274"
            };
            _dynamoDbOperationConfig = new DynamoDBOperationConfig { OverrideTableName = _tableName };
        }

        /// <summary>
        /// Test ColdStart for PutItem using object persistence model and DisableFetchingTableMetadata to false
        /// </summary>
        [Benchmark]
        public async Task DDBContextColdStartPutItem()
        {
            SdkCache.Clear();
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient, _dynamoDBContextConfig);
            await _dynamoDbContext.SaveAsync<Book>(_book, _dynamoDbOperationConfig).ConfigureAwait(false);
        }
        [GlobalSetup(Target =nameof(DDBContextColdStartQuery))]
        public async Task SetupForDDBContextColdStartQuery()
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDBContextConfig = new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = false
            };
        }

        /// <summary>
        /// Test ColdStart for Query using object persistence model and DisableFetchingTableMetadata to false
        /// </summary>
        [Benchmark]
        public async Task DDBContextColdStartQuery()
        {
            SdkCache.Clear();
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient, _dynamoDBContextConfig);
            await _dynamoDbContext.QueryAsync<Book>("John Doe", _dynamoDbOperationConfig).GetRemainingAsync().ConfigureAwait(false);
        }

        #endregion

        #region ObjectPersistenceDisableFetchingTableMetadataColdStart
        [GlobalSetup(Target = nameof(DDBContextColdStartDFTMGetItem))] 
        public async Task SetupForDDBContextColdStartDFTMGetItem() 
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDBContextConfig = new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = true
            };
            
        }

        /// <summary>
        /// Cold Start test for GetItem using the object persistence model with the DisableFetchingMetadata to true.
        /// </summary>
        [Benchmark]
        [MinIterationCount(15), MaxIterationCount(50)]
        public async Task DDBContextColdStartDFTMGetItem()
        {
            SdkCache.Clear();
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient, _dynamoDBContextConfig);
            await _dynamoDbContext.LoadAsync<Book>("John Doe", "Whispering Shadows", _dynamoDbOperationConfig).ConfigureAwait(false);
        }

        [GlobalSetup(Target =nameof(DDBContextColdStartDFTMPutItem))]
        public async Task SetupForDDBContextColdStartDFTMPutItem()
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDBContextConfig = new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = true
            };

            _book = new Book
            {
                Author = "John Doe",
                Title = "Whispering Shadows",
                Genre = "Documentary",
                ISBN = "100390234-123",
                Price = "5.13",
                Rating = 3,
                Number_Of_Pages = 104,
                Is_Available = true,
                Address = "343 American Ash Circle",
                Address2 = "Apt 274"
            };
        }

        /// <summary>
        /// Cold Start test for PutItem using the object persistence model with DisableFetchingMetadata to true 
        /// </summary>
        [Benchmark]
        [MinIterationCount(15), MaxIterationCount(50)]
        public async Task DDBContextColdStartDFTMPutItem()
        {
            SdkCache.Clear();
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient, _dynamoDBContextConfig);
            await _dynamoDbContext.SaveAsync<Book>(_book, _dynamoDbOperationConfig).ConfigureAwait(false);
        }

        [GlobalSetup(Target = nameof(DDBColdStartDFTMQuery))]
        public async Task SetupForDDBContextColdStartDFTMQuery()
        {
            await CommonSetup().ConfigureAwait(false);
            _dynamoDBContextConfig = new DynamoDBContextConfig
            {
                DisableFetchingTableMetadata = true
            };
        }
            
        /// <summary>
        /// Query using the object persistence model with DisableFetchingMetadata to true
        /// </summary>
        [Benchmark]
        [MinIterationCount(15), MaxIterationCount(50)]
        public async Task DDBColdStartDFTMQuery()
        {
            SdkCache.Clear();
            _dynamoDbContext = new DynamoDBContext(_dynamoDbClient, _dynamoDBContextConfig);
            await _dynamoDbContext.QueryAsync<Book>("John Doe", _dynamoDbOperationConfig).GetRemainingAsync().ConfigureAwait(false);
        }
        #endregion

        [GlobalCleanup]
        public async Task GlobalCleanup()
        {
            await DeleteTableAndWait();
            Utils.DisposeClient(_dynamoDbClient);
        }

        #region Helpers
        private async Task DeleteTableAndWait()
        {
            try
            {
                await _dynamoDbClient.DeleteTableAsync(_tableName).ConfigureAwait(false);
            }
            catch (ResourceInUseException)
            {
                Thread.Sleep(1000);
            }
        }

        private async Task WaitForTable(IAmazonDynamoDB client, DescribeTableRequest request)
        {
            while (true)
            {
                try
                {
                    var response = await client.DescribeTableAsync(request).ConfigureAwait(false);
                    if (response.Table.TableStatus == TableStatus.ACTIVE)
                    {
                        break;
                    }
                }
                catch (ResourceNotFoundException)
                {
                    await Task.Delay(1000);
                }
            }
        }
        
        private async Task CommonSetup()
        {
            _dynamoDbClient = new AmazonDynamoDBClient();
            _tableName = Utils.GenerateName("books");
            await CreateTable(_dynamoDbClient).ConfigureAwait(false);
            await FillTable(_tableName).ConfigureAwait(false);

            _dynamoDbOperationConfig = new DynamoDBOperationConfig
            {
                OverrideTableName = _tableName,
                ConsistentRead = true,
            };
        }
        private async Task FillTable(string tableName)
        {
            List<Book>? books = new List<Book>();
            _bookTitleList = new List<string>();
            string jsonData = File.ReadAllText(_sampleDataPath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            books = JsonSerializer.Deserialize<List<Book>>(jsonData, options);
            Table booksTable = Table.LoadTable(_dynamoDbClient, tableName);

            foreach (var book in books)
            {
                Document document = new Document
                {
                    ["author"] = book.Author,
                    ["title"] = book.Title,
                    ["genre"] = book.Genre,
                    ["isbn"] = book.ISBN,
                    ["price"] = book.Price,
                    ["rating"] = book.Rating,
                    ["number_of_pages"] = book.Number_Of_Pages,
                    ["is_available"] = book.Is_Available,
                    ["address"] = book.Address,
                    ["address_2"] = book.Address2
                };
                _bookTitleList.Add(book.Title);
                try
                {
                    await booksTable.PutItemAsync(document).ConfigureAwait(false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error adding item{ex.Message}");
                    throw;
                }
            }
        }

        private async Task CreateTable(IAmazonDynamoDB client)
        {

            var createTableRequest = new CreateTableRequest
            {
                TableName = _tableName,
                AttributeDefinitions = new List<AttributeDefinition>()
                {
                    new AttributeDefinition
                    {
                        AttributeName = "author",
                        AttributeType = "S"
                    },
                    new AttributeDefinition
                    {
                        AttributeName = "title",
                        AttributeType = "S"
                    }
                },
                KeySchema = new List<KeySchemaElement>()
                  {
                    new KeySchemaElement
                    {
                      AttributeName = "author",
                      KeyType = KeyType.HASH  //Partition key
                    },
                    new KeySchemaElement
                    {
                        AttributeName = "title",
                        KeyType = KeyType.RANGE //Sort Key
                    }
                  },
                ProvisionedThroughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 10000,
                    WriteCapacityUnits = 10000
                }
            };
            await client.CreateTableAsync(createTableRequest).ConfigureAwait(false);
            var describeTableRequest = new DescribeTableRequest
            {
                TableName = _tableName
            };
            await WaitForTable(client, describeTableRequest).ConfigureAwait(false);
        }
    }
    #endregion
    public class Book
    {
        [DynamoDBHashKey]
        [DynamoDBProperty("author")]
        public string? Author { get; set; }
        [DynamoDBRangeKey]
        [DynamoDBProperty("title")]
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? ISBN { get; set; }
        public string? Price { get; set; }
        public int Rating { get; set; }
        public int Number_Of_Pages { get; set; }
        public bool Is_Available { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
    }
}

