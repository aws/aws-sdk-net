using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AWSSDKDocSamples.Util;

using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using System.Collections.Specialized;
using System.Configuration;
using System.Threading.Tasks;
using System.IO;
using Amazon.DynamoDBv2.DocumentModel;

namespace AWSSDKDocSamples.DynamoDBv2
{
    public class LowLevelSamples : ISample
    {
        public async Task DataPlaneSamples()
        {
            {
                #region CreateTable Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define table schema:
                //  Table has a hash-key "Author" and a range-key "Title"
                List<KeySchemaElement> schema = new List<KeySchemaElement>
                {
                    new KeySchemaElement
                    {
                        AttributeName = "Author", KeyType = "HASH"
                    },
                    new KeySchemaElement
                    {
                        AttributeName = "Title", KeyType = "RANGE"
                    }
                };

                // Define key attributes:
                //  The key attributes "Author" and "Title" are string types
                List<AttributeDefinition> definitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition
                    {
                        AttributeName = "Author", AttributeType = "S"
                    },
                    new AttributeDefinition
                    {
                        AttributeName = "Title", AttributeType = "S"
                    }
                };

                // Define table throughput:
                //  Table has capacity of 20 reads and 50 writes
                ProvisionedThroughput throughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 20,
                    WriteCapacityUnits = 50
                };

                // Configure the CreateTable request
                CreateTableRequest request = new CreateTableRequest
                {
                    TableName = "SampleTable",
                    KeySchema = schema,
                    ProvisionedThroughput = throughput,
                    AttributeDefinitions = definitions
                };

                // View new table properties
                TableDescription tableDescription = (await client.CreateTableAsync(request)).TableDescription;
                Console.WriteLine("Table name: {0}", tableDescription.TableName);
                Console.WriteLine("Creation time: {0}", tableDescription.CreationDateTime);
                Console.WriteLine("Item count: {0}", tableDescription.ItemCount);
                Console.WriteLine("Table size (bytes): {0}", tableDescription.TableSizeBytes);
                Console.WriteLine("Table status: {0}", tableDescription.TableStatus);

                // List table key schema
                List<KeySchemaElement> tableSchema = tableDescription.KeySchema;
                for (int i = 0; i < tableSchema.Count; i++)
                {
                    KeySchemaElement element = tableSchema[i];
                    Console.WriteLine("Key: Name = {0}, KeyType = {1}",
                        element.AttributeName, element.KeyType);
                }

                // List attribute definitions
                List<AttributeDefinition> attributeDefinitions = tableDescription.AttributeDefinitions;
                for (int i = 0; i < attributeDefinitions.Count; i++)
                {
                    AttributeDefinition definition = attributeDefinitions[i];
                    Console.WriteLine("Attribute: Name = {0}, Type = {1}",
                        definition.AttributeName, definition.AttributeType);
                }

                Console.WriteLine("Throughput: Reads = {0}, Writes = {1}",
                    tableDescription.ProvisionedThroughput.ReadCapacityUnits,
                    tableDescription.ProvisionedThroughput.WriteCapacityUnits);

                #endregion
            }

            {
                #region DescribeTable Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Create DescribeTable request
                DescribeTableRequest request = new DescribeTableRequest
                {
                    TableName = "SampleTable"
                };

                // Issue DescribeTable request and retrieve the table description
                TableDescription tableDescription = (await client.DescribeTableAsync(request)).Table;

                // View new table properties
                Console.WriteLine("Table name: {0}", tableDescription.TableName);
                Console.WriteLine("Creation time: {0}", tableDescription.CreationDateTime);
                Console.WriteLine("Item count: {0}", tableDescription.ItemCount);
                Console.WriteLine("Table size (bytes): {0}", tableDescription.TableSizeBytes);
                Console.WriteLine("Table status: {0}", tableDescription.TableStatus);
                // List table key schema
                List<KeySchemaElement> tableSchema = tableDescription.KeySchema;
                for (int i = 0; i < tableSchema.Count; i++)
                {
                    KeySchemaElement element = tableSchema[i];
                    Console.WriteLine("Key: Name = {0}, KeyType = {1}",
                        element.AttributeName, element.KeyType);
                }

                // List attribute definitions
                List<AttributeDefinition> attributeDefinitions = tableDescription.AttributeDefinitions;
                for (int i = 0; i < attributeDefinitions.Count; i++)
                {
                    AttributeDefinition definition = attributeDefinitions[i];
                    Console.WriteLine("Attribute: Name = {0}, Type = {1}",
                        definition.AttributeName, definition.AttributeType);
                }
                Console.WriteLine("Throughput: Reads = {0}, Writes = {1}",
                    tableDescription.ProvisionedThroughput.ReadCapacityUnits,
                    tableDescription.ProvisionedThroughput.WriteCapacityUnits);

                #endregion
            }

            {
                #region ListTables Paging Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                string startTableName = null;
                do
                {
                    // Configure ListTables request with the marker value
                    ListTablesRequest request = new ListTablesRequest
                    {
                        ExclusiveStartTableName = startTableName,
                    };

                    // Issue call
                    ListTablesResponse response = await client.ListTablesAsync(request);

                    if (response.TableNames != null)
                    {
                        // List retrieved tables
                        List<string> tables = response.TableNames;
                        Console.WriteLine("Retrieved tables: {0}",
                            string.Join(", ", tables));
                    }

                    // Update marker value from the result
                    startTableName = response.LastEvaluatedTableName;

                } while (!string.IsNullOrEmpty(startTableName)); // Test marker value

                #endregion
            }

            {
                #region ListTables NonPaging Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Issue call
                ListTablesResponse response = await client.ListTablesAsync();

                if (response.TableNames != null)
                {
                    // List retrieved tables
                    List<string> tables = response.TableNames;
                    Console.WriteLine("Retrieved tables: {0}",
                        string.Join(", ", tables));
                }

                #endregion
            }

            TableUtils.WaitUntilTableActive("SampleTable", TestClient);

            {
                #region UpdateTable Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define new table throughput:
                //  Table will now have capacity of 40 reads and 50 writes
                ProvisionedThroughput throughput = new ProvisionedThroughput
                {
                    ReadCapacityUnits = 40,
                    WriteCapacityUnits = 50
                };

                // Compose the UpdateTable request
                UpdateTableRequest request = new UpdateTableRequest
                {
                    TableName = "SampleTable",
                    ProvisionedThroughput = throughput
                };

                // View new table properties
                TableDescription tableDescription = (await client.UpdateTableAsync(request)).TableDescription;
                Console.WriteLine("Table name: {0}", tableDescription.TableName);
                Console.WriteLine("Throughput: Reads = {0}, Writes = {1}",
                    tableDescription.ProvisionedThroughput.ReadCapacityUnits,
                    tableDescription.ProvisionedThroughput.WriteCapacityUnits);

                #endregion
            }

            TableUtils.WaitUntilTableActive("SampleTable", TestClient);

            {
                #region DeleteTable Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Configure the DeleteTable request
                DeleteTableRequest request = new DeleteTableRequest
                {
                    TableName = "SampleTable"
                };

                // Issue DeleteTable request and retrieve the table description
                TableDescription tableDescription = (await client.DeleteTableAsync(request)).TableDescription;
                Console.WriteLine("Table name: {0}", tableDescription.TableName);
                Console.WriteLine("Table status: {0}", tableDescription.TableStatus);

                #endregion
            }

        }

        private async Task CreateLSITable()
        {
            #region CreateTable LSI Sample

            // Create a client
            AmazonDynamoDBClient client = new AmazonDynamoDBClient();

            // Define table schema:
            //  Table has a hash-key "Author" and a range-key "Title"
            List<KeySchemaElement> schema = new List<KeySchemaElement>
            {
                new KeySchemaElement
                {
                    AttributeName = "Author", KeyType = "HASH"
                },
                new KeySchemaElement
                {
                    AttributeName = "Title", KeyType = "RANGE"
                }
            };

            // Define local secondary indexes:
            //  Table has two indexes, one on "Year" and the other on "Setting"
            List<LocalSecondaryIndex> indexes = new List<LocalSecondaryIndex>
            {
                new LocalSecondaryIndex
                {
                    IndexName = "YearsIndex",
                    KeySchema = new List<KeySchemaElement>
                    {
                        // Hash key must match table hash key
                        new KeySchemaElement { AttributeName = "Author", KeyType = "HASH" },
                        // Secondary index on "Year" attribute
                        new KeySchemaElement { AttributeName = "Year", KeyType = "RANGE" }
                    },
                    // Projection type is set to ALL, all attributes returned for this index
                    Projection = new Projection
                    {
                        ProjectionType = "ALL"
                    }
                },
                new LocalSecondaryIndex
                {
                    IndexName = "SettingsIndex",
                    KeySchema = new List<KeySchemaElement>
                    {
                        // Hash key must match table hash key
                        new KeySchemaElement { AttributeName = "Author", KeyType = "HASH" },
                        // Secondary index on "Setting" attribute
                        new KeySchemaElement { AttributeName = "Setting", KeyType = "RANGE" }
                    },
                    // Projection type is set to INCLUDE, the specified attributes + keys are returned
                    Projection = new Projection
                    {
                        ProjectionType = "INCLUDE",
                        NonKeyAttributes = new List<string>
                        {
                            "Pages", "Genres"
                        }
                    }
                }
            };

            // Define key attributes:
            //  The key attributes "Author" and "Title" are string types.
            //  The local secondary index attributes are "Year" (numerical) and "Setting" (string).
            List<AttributeDefinition> definitions = new List<AttributeDefinition>
            {
                new AttributeDefinition
                {
                    AttributeName = "Author", AttributeType = "S"
                },
                new AttributeDefinition
                {
                    AttributeName = "Title", AttributeType = "S"
                },
                new AttributeDefinition
                {
                    AttributeName = "Year", AttributeType = "N"
                },
                new AttributeDefinition
                {
                    AttributeName = "Setting", AttributeType = "S"
                }
            };

            // Define table throughput:
            //  Table has capacity of 20 reads and 50 writes
            ProvisionedThroughput throughput = new ProvisionedThroughput
            {
                ReadCapacityUnits = 20,
                WriteCapacityUnits = 50
            };

            // Configure the CreateTable request
            CreateTableRequest request = new CreateTableRequest
            {
                TableName = "SampleTable",
                KeySchema = schema,
                ProvisionedThroughput = throughput,
                AttributeDefinitions = definitions,
                LocalSecondaryIndexes = indexes
            };

            // View new table properties
            TableDescription tableDescription = (await client.CreateTableAsync(request)).TableDescription;
            Console.WriteLine("Table name: {0}", tableDescription.TableName);
            Console.WriteLine("Creation time: {0}", tableDescription.CreationDateTime);
            Console.WriteLine("Item count: {0}", tableDescription.ItemCount);
            Console.WriteLine("Table size (bytes): {0}", tableDescription.TableSizeBytes);
            Console.WriteLine("Table status: {0}", tableDescription.TableStatus);

            // List table key schema
            List<KeySchemaElement> tableSchema = tableDescription.KeySchema;
            for (int i = 0; i < tableSchema.Count; i++)
            {
                KeySchemaElement element = tableSchema[i];
                Console.WriteLine("Key: Name = {0}, KeyType = {1}",
                    element.AttributeName, element.KeyType);
            }

            // List attribute definitions
            List<AttributeDefinition> attributeDefinitions = tableDescription.AttributeDefinitions;
            for (int i = 0; i < attributeDefinitions.Count; i++)
            {
                AttributeDefinition definition = attributeDefinitions[i];
                Console.WriteLine("Attribute: Name = {0}, Type = {1}",
                    definition.AttributeName, definition.AttributeType);
            }

            Console.WriteLine("Throughput: Reads = {0}, Writes = {1}",
                tableDescription.ProvisionedThroughput.ReadCapacityUnits,
                tableDescription.ProvisionedThroughput.WriteCapacityUnits);

            #endregion
        }

        private async Task PutSample()
        {
            {
                #region PutItem Sample 1

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define item attributes
                Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
                // Author is hash-key
                attributes["Author"] = new AttributeValue { S = "Mark Twain" };
                // Title is range-key
                attributes["Title"] = new AttributeValue { S = "The Adventures of Tom Sawyer" };
                // Other attributes
                attributes["Year"] = new AttributeValue { N = "1876" };
                attributes["Setting"] = new AttributeValue { S = "Missouri" };
                attributes["Pages"] = new AttributeValue { N = "275" };
                attributes["Genres"] = new AttributeValue
                {
                    SS = new List<string> { "Satire", "Folk", "Children's Novel" }
                };

                // Create PutItem request
                PutItemRequest request = new PutItemRequest
                {
                    TableName = "SampleTable",
                    Item = attributes
                };

                // Issue PutItem request
                await client.PutItemAsync(request);

                #endregion
            }
        }
        public async Task CRUDSamples()
        {
            await EnsureTables();

            await PutSample();

            {
                #region GetItem Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define item key
                //  Hash-key of the target item is string value "Mark Twain"
                //  Range-key of the target item is string value "The Adventures of Tom Sawyer"
                Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
                {
                    { "Author", new AttributeValue { S = "Mark Twain" } },
                    { "Title", new AttributeValue { S = "The Adventures of Tom Sawyer" } }
                };

                // Create GetItem request
                GetItemRequest request = new GetItemRequest
                {
                    TableName = "SampleTable",
                    Key = key,
                };

                // Issue request
                var result = await client.GetItemAsync(request);

                // View response
                Console.WriteLine("Item:");
                Dictionary<string, AttributeValue> item = result.Item;
                foreach (var keyValuePair in item)
                {
                    Console.WriteLine("{0} : S={1}, N={2}, SS=[{3}], NS=[{4}]",
                        keyValuePair.Key,
                        keyValuePair.Value.S,
                        keyValuePair.Value.N,
                        string.Join(", ", keyValuePair.Value.SS ?? new List<string>()),
                        string.Join(", ", keyValuePair.Value.NS ?? new List<string>()));
                }

                #endregion
            }

            {
                #region UpdateItem Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define item key
                //  Hash-key of the target item is string value "Mark Twain"
                //  Range-key of the target item is string value "The Adventures of Tom Sawyer"
                Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
                {
                    { "Author", new AttributeValue { S = "Mark Twain" } },
                    { "Title", new AttributeValue { S = "The Adventures of Tom Sawyer" } }
                };

                // Define expression attribute names
                Dictionary<string, string> expressionAttributeNames = new Dictionary<string, string>
                {
                    { "#S", "Setting" },
                    { "#B", "Bibliography" },
                    { "#G", "Genres" }
                };

                // Define expression attribute values
                Dictionary<string, AttributeValue> expressionAttributeValues = new Dictionary<string, AttributeValue>
                {
                    { ":newSetting", new AttributeValue { S = "St. Petersburg, Missouri" } },
                    { ":newGenre", new AttributeValue { SS = new List<string> { "Bildungsroman" } } }
                };

                // Define expression, which:
                //  1) Updates the setting to a different location
                //  2) Adds a new genre
                //  3) Removes the bibliography attribute
                string updateExpression = "SET #S = :newSetting ADD #G :newGenre REMOVE #B";

                // Create UpdateItem request
                UpdateItemRequest request = new UpdateItemRequest
                {
                    TableName = "SampleTable",
                    Key = key,
                    ExpressionAttributeNames = expressionAttributeNames,
                    ExpressionAttributeValues = expressionAttributeValues,
                    UpdateExpression = updateExpression
                };

                // Issue request
                await client.UpdateItemAsync(request);

                #endregion
            }

            {
                #region DeleteItem Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define item key
                //  Hash-key of the target item is string value "Mark Twain"
                //  Range-key of the target item is string value "The Adventures of Tom Sawyer"
                Dictionary<string, AttributeValue> key = new Dictionary<string, AttributeValue>
                {
                    { "Author", new AttributeValue { S = "Mark Twain" } },
                    { "Title", new AttributeValue { S = "The Adventures of Tom Sawyer" } }
                };

                // Create DeleteItem request
                DeleteItemRequest request = new DeleteItemRequest
                {
                    TableName = "SampleTable",
                    Key = key
                };

                // Issue request
                await client.DeleteItemAsync(request);

                #endregion
            }
        }

        public async Task SearchSamples()
        {
            await RemoveTables();
            await CreateLSITable();
            TableUtils.WaitUntilTableActive("SampleTable", TestClient);

            {
                // Create items to put into first table
                Dictionary<string, AttributeValue> item1 = new Dictionary<string, AttributeValue>();
                item1["Author"] = new AttributeValue { S = "Mark Twain" };
                item1["Title"] = new AttributeValue { S = "A Connecticut Yankee in King Arthur's Court" };
                item1["Pages"] = new AttributeValue { N = "575" };
                Dictionary<string, AttributeValue> item2 = new Dictionary<string, AttributeValue>();
                item2["Author"] = new AttributeValue { S = "Booker Taliaferro Washington" };
                item2["Title"] = new AttributeValue { S = "My Larger Education" };
                item2["Pages"] = new AttributeValue { N = "313" };
                item2["Year"] = new AttributeValue { N = "1911" };

                // Construct write-request for first table
                List<WriteRequest> sampleTableItems = new List<WriteRequest>();
                sampleTableItems.Add(new WriteRequest
                {
                    PutRequest = new PutRequest { Item = item1 }
                });
                sampleTableItems.Add(new WriteRequest
                {
                    PutRequest = new PutRequest { Item = item2 }
                });
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();
                await client.BatchWriteItemAsync(new BatchWriteItemRequest
                {
                    RequestItems = new Dictionary<string, List<WriteRequest>>
                    {
                        { "SampleTable", sampleTableItems }
                    }
                });

                await PutSample();
            }


            {
                #region Query Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define item hash-key to be string value "Mark Twain"
                AttributeValue hashKey = new AttributeValue { S = "Mark Twain" };

                // Define query condition to search for range-keys that begin with the string "The Adventures"
                Condition condition = new Condition
                {
                    ComparisonOperator = "BEGINS_WITH",
                    AttributeValueList = new List<AttributeValue>
                    {
                        new AttributeValue { S = "The Adventures" }
                    }
                };

                // Create the key conditions from hashKey and condition
                Dictionary<string, Condition> keyConditions = new Dictionary<string, Condition>
                {
                    // Hash key condition. ComparisonOperator must be "EQ".
                    { 
                        "Author",
                        new Condition
                        {
                            ComparisonOperator = "EQ",
                            AttributeValueList = new List<AttributeValue> { hashKey }
                        }
                    },
                    // Range key condition
                    {
                        "Title",
                        condition
                    }
                };

                // Define marker variable
                Dictionary<string, AttributeValue> startKey = null;

                do
                {
                    // Create Query request
                    QueryRequest request = new QueryRequest
                    {
                        TableName = "SampleTable",
                        ExclusiveStartKey = startKey,
                        KeyConditions = keyConditions
                    };

                    // Issue request
                    var result = await client.QueryAsync(request);

                    // View all returned items
                    List<Dictionary<string, AttributeValue>> items = result.Items;
                    foreach (Dictionary<string, AttributeValue> item in items)
                    {
                        Console.WriteLine("Item:");
                        foreach (var keyValuePair in item)
                        {
                            Console.WriteLine("{0} : S={1}, N={2}, SS=[{3}], NS=[{4}]",
                                keyValuePair.Key,
                                keyValuePair.Value.S,
                                keyValuePair.Value.N,
                                string.Join(", ", keyValuePair.Value.SS ?? new List<string>()),
                                string.Join(", ", keyValuePair.Value.NS ?? new List<string>()));
                        }
                    }

                    // Set marker variable
                    startKey = result.LastEvaluatedKey;
                } while (startKey != null && startKey.Count > 0);

                #endregion
            }

            {
                #region Query Local Secondary Index Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define item hash-key to be string value "Mark Twain"
                AttributeValue hashKey = new AttributeValue { S = "Mark Twain" };

                // Define query condition to search for range-keys ("Year", in "YearsIndex") that are less than 1900
                Condition condition = new Condition
                {
                    ComparisonOperator = "LT",
                    AttributeValueList = new List<AttributeValue>
                    {
                        new AttributeValue { N = "1900" }
                    }
                };

                // Create the key conditions from hashKey and condition
                Dictionary<string, Condition> keyConditions = new Dictionary<string, Condition>
                {
                    // Hash key condition. ComparisonOperator must be "EQ".
                    { 
                        "Author",
                        new Condition
                        {
                            ComparisonOperator = "EQ",
                            AttributeValueList = new List<AttributeValue> { hashKey }
                        }
                    },
                    // Range key condition
                    {
                        "Year", // Reference the correct range key when using indexes
                        condition
                    }
                };

                // Define marker variable
                Dictionary<string, AttributeValue> startKey = null;

                do
                {
                    // Create Query request
                    QueryRequest request = new QueryRequest
                    {
                        TableName = "SampleTable",
                        ExclusiveStartKey = startKey,
                        KeyConditions = keyConditions,
                        IndexName = "YearsIndex" // Specify the index to query against
                    };

                    // Issue request
                    QueryResponse response = await client.QueryAsync(request);

                    if (response.Items != null)
                    {
                        // View all returned items
                        List<Dictionary<string, AttributeValue>> items = response.Items;
                        foreach (Dictionary<string, AttributeValue> item in items)
                        {
                            Console.WriteLine("Item:");
                            foreach (var keyValuePair in item)
                            {
                                Console.WriteLine("{0} : S={1}, N={2}, SS=[{3}], NS=[{4}]",
                                    keyValuePair.Key,
                                    keyValuePair.Value.S,
                                    keyValuePair.Value.N,
                                    string.Join(", ", keyValuePair.Value.SS ?? new List<string>()),
                                    string.Join(", ", keyValuePair.Value.NS ?? new List<string>()));
                            }
                        }
                    }

                    // Set marker variable
                    startKey = response.LastEvaluatedKey;
                } while (startKey != null && startKey.Count > 0);

                #endregion
            }

            {
                #region Scan Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define scan conditions
                Dictionary<string, Condition> conditions = new Dictionary<string, Condition>();

                // Title attribute should contain the string "Adventures"
                Condition titleCondition = new Condition();
                titleCondition.ComparisonOperator = ComparisonOperator.CONTAINS;
                titleCondition.AttributeValueList.Add(new AttributeValue { S = "Adventures" });
                conditions["Title"] = titleCondition;

                // Pages attributes must be greater-than the numeric value "200"
                Condition pagesCondition = new Condition();
                pagesCondition.ComparisonOperator = ComparisonOperator.GT;
                pagesCondition.AttributeValueList.Add(new AttributeValue { N = "200" });
                conditions["Pages"] = pagesCondition;


                // Define marker variable
                Dictionary<string, AttributeValue> startKey = null;

                do
                {
                    // Create Scan request
                    ScanRequest request = new ScanRequest
                    {
                        TableName = "SampleTable",
                        ExclusiveStartKey = startKey,
                        ScanFilter = conditions
                    };

                    // Issue request
                    ScanResponse response = await client.ScanAsync(request);

                    if (response.Items != null)
                    {
                        // View all returned items
                        List<Dictionary<string, AttributeValue>> items = response.Items;
                        foreach (Dictionary<string, AttributeValue> item in items)
                        {
                            Console.WriteLine("Item:");
                            foreach (var keyValuePair in item)
                            {
                                Console.WriteLine("{0} : S={1}, N={2}, SS=[{3}], NS=[{4}]",
                                    keyValuePair.Key,
                                    keyValuePair.Value.S,
                                    keyValuePair.Value.N,
                                    string.Join(", ", keyValuePair.Value.SS ?? new List<string>()),
                                    string.Join(", ", keyValuePair.Value.NS ?? new List<string>()));
                            }
                        }
                    }

                    // Set marker variable
                    startKey = response.LastEvaluatedKey;
                } while (startKey != null && startKey.Count > 0);

                #endregion
            }

            {
                // Create lots of items to put into first table
                var table = new TableBuilder(TestClient, "SampleTable")
                                    .AddHashKey("Author", DynamoDBEntryType.String)
                                    .AddRangeKey("Title", DynamoDBEntryType.String)
                                    .AddLocalSecondaryIndex("YearsIndex", "Year", DynamoDBEntryType.Numeric)
                                    .AddLocalSecondaryIndex("SettingsIndex", "Setting", DynamoDBEntryType.String)
                                    .Build();

                var batchWrite = table.CreateBatchWrite();
                for (int i = 0; i < 100; i++)
                {
                    var document = new Amazon.DynamoDBv2.DocumentModel.Document();
                    document["Author"] = "FakeAuthor" + i;
                    document["Title"] = "Book" + i;
                    document["Pages"] = (180 + i);
                    document["Year"] = 1900 + i;
                    batchWrite.AddDocumentToPut(document);
                }
                await batchWrite.ExecuteAsync();
            }


            {
                #region Parallel Scan Sample

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Define scan conditions
                Dictionary<string, Condition> conditions = new Dictionary<string, Condition>();

                // Pages attributes must be greater-than the numeric value "200"
                Condition pagesCondition = new Condition();
                pagesCondition.ComparisonOperator = ComparisonOperator.GT;
                pagesCondition.AttributeValueList.Add(new AttributeValue { N = "200" });
                conditions["Pages"] = pagesCondition;

                // Setup 10 simultaneous threads, each thread calling Scan operation
                // with its own segment value.
                int totalSegments = 10;
                await Parallel.ForAsync(0, totalSegments, async (segment, token) =>
                {
                    // Define marker variable
                    Dictionary<string, AttributeValue> startKey = null;

                    do
                    {
                        // Create Scan request
                        ScanRequest request = new ScanRequest
                        {
                            TableName = "SampleTable",
                            ExclusiveStartKey = startKey,
                            ScanFilter = conditions,
                            // Total segments to split the table into
                            TotalSegments = totalSegments,
                            // Current segment to scan
                            Segment = segment
                        };

                        // Issue request
                        ScanResponse response = await client.ScanAsync(request);

                        // Write returned items to file
                        string path = string.Format("ParallelScan-{0}-of-{1}.txt", totalSegments, segment);
                        using (Stream stream = File.OpenWrite(path))
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            if (response.Items != null)
                            {
                                foreach (Dictionary<string, AttributeValue> item in response.Items)
                                {
                                    writer.WriteLine("Item:");
                                    foreach (var keyValuePair in item)
                                    {
                                        writer.WriteLine("{0} : S={1}, N={2}, SS=[{3}], NS=[{4}]",
                                            keyValuePair.Key,
                                            keyValuePair.Value.S,
                                            keyValuePair.Value.N,
                                            string.Join(", ", keyValuePair.Value.SS ?? new List<string>()),
                                            string.Join(", ", keyValuePair.Value.NS ?? new List<string>()));
                                    }
                                }
                            }
                        }

                        // Set marker variable
                        startKey = response.LastEvaluatedKey;
                    } while (startKey != null && startKey.Count > 0);
                });

                #endregion
            }

        }

        public async Task BatchSamples()
        {
            await EnsureTables();

            {
                #region BatchGet Sample 1

                // Define attributes to get and keys to retrieve
                List<string> attributesToGet = new List<string> { "Author", "Title", "Year" };
                List<Dictionary<string, AttributeValue>> sampleTableKeys = new List<Dictionary<string, AttributeValue>>
                {
                    new Dictionary<string, AttributeValue>
                    {
                        { "Author", new AttributeValue { S = "Mark Twain" } },
                        { "Title", new AttributeValue { S = "The Adventures of Tom Sawyer" } }
                    },
                    new Dictionary<string, AttributeValue>
                    {
                        { "Author", new AttributeValue { S = "Mark Twain" } },
                        { "Title", new AttributeValue { S = "Adventures of Huckleberry Finn" } }
                    }
                };

                // Construct get-request for first table
                KeysAndAttributes sampleTableItems = new KeysAndAttributes
                {
                    AttributesToGet = attributesToGet,
                    Keys = sampleTableKeys
                };

                #endregion

                #region BatchGet Sample 2

                // Define keys to retrieve
                List<Dictionary<string, AttributeValue>> authorsTableKeys = new List<Dictionary<string, AttributeValue>>
                {
                    new Dictionary<string, AttributeValue>
                    {
                        { "Author", new AttributeValue { S = "Mark Twain" } },
                    },
                    new Dictionary<string, AttributeValue>
                    {
                        { "Author", new AttributeValue { S = "Booker Taliaferro Washington" } },
                    }
                };

                // Construct get-request for second table
                //  Skip setting AttributesToGet property to retrieve all attributes
                KeysAndAttributes authorsTableItems = new KeysAndAttributes
                {
                    Keys = authorsTableKeys,
                };

                #endregion

                #region BatchGet Sample 3

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Construct table-keys mapping
                Dictionary<string, KeysAndAttributes> requestItems = new Dictionary<string, KeysAndAttributes>();
                requestItems["SampleTable"] = sampleTableItems;
                requestItems["AuthorsTable"] = authorsTableItems;

                // Construct request
                BatchGetItemRequest request = new BatchGetItemRequest
                {
                    RequestItems = requestItems
                };

                BatchGetItemResponse response;
                do
                {
                    // Issue request and retrieve items
                    response = await client.BatchGetItemAsync(request);

                    // Iterate through responses
                    if (response.Responses != null)
                    {
                        foreach (string tableName in response.Responses.Keys)
                        {
                            // Get items for each table
                            List<Dictionary<string, AttributeValue>> tableItems = response.Responses[tableName];

                            // View items
                            foreach (Dictionary<string, AttributeValue> item in tableItems)
                            {
                                Console.WriteLine("Item:");
                                foreach (var keyValuePair in item)
                                {
                                    Console.WriteLine("{0} : S={1}, N={2}, SS=[{3}], NS=[{4}]",
                                        keyValuePair.Key,
                                        keyValuePair.Value.S,
                                        keyValuePair.Value.N,
                                        string.Join(", ", keyValuePair.Value.SS ?? new List<string>()),
                                        string.Join(", ", keyValuePair.Value.NS ?? new List<string>()));
                                }
                            }
                        }

                    }

                    // Some items may not have been retrieved!
                    //  Set RequestItems to the result's UnprocessedKeys and reissue request
                    request.RequestItems = response.UnprocessedKeys;

                } while (response.UnprocessedKeys?.Count > 0);

                #endregion
            }


            {
                #region BatchWrite Sample 1

                // Create items to put into first table
                Dictionary<string, AttributeValue> item1 = new Dictionary<string, AttributeValue>();
                item1["Author"] = new AttributeValue { S = "Mark Twain" };
                item1["Title"] = new AttributeValue { S = "A Connecticut Yankee in King Arthur's Court" };
                item1["Pages"] = new AttributeValue { N = "575" };
                Dictionary<string, AttributeValue> item2 = new Dictionary<string, AttributeValue>();
                item2["Author"] = new AttributeValue { S = "Booker Taliaferro Washington" };
                item2["Title"] = new AttributeValue { S = "My Larger Education" };
                item2["Pages"] = new AttributeValue { N = "313" };
                item2["Year"] = new AttributeValue { N = "1911" };

                // Create key for item to delete from first table
                //  Hash-key of the target item is string value "Mark Twain"
                //  Range-key of the target item is string value "Tom Sawyer, Detective"
                Dictionary<string, AttributeValue> keyToDelete1 = new Dictionary<string, AttributeValue>
                {
                    { "Author", new AttributeValue { S = "Mark Twain" } },
                    { "Title", new AttributeValue { S = "Tom Sawyer, Detective" } }
                };

                // Construct write-request for first table
                List<WriteRequest> sampleTableItems = new List<WriteRequest>();
                sampleTableItems.Add(new WriteRequest
                {
                    PutRequest = new PutRequest { Item = item1 }
                });
                sampleTableItems.Add(new WriteRequest
                {
                    PutRequest = new PutRequest { Item = item2 }
                });
                sampleTableItems.Add(new WriteRequest
                {
                    DeleteRequest = new DeleteRequest { Key = keyToDelete1 }
                });

                #endregion

                #region BatchWrite Sample 2

                // Create key for item to delete from second table
                //  Hash-key of the target item is string value "Francis Scott Key Fitzgerald"
                Dictionary<string, AttributeValue> keyToDelete2 = new Dictionary<string, AttributeValue>
                {
                    { "Author", new AttributeValue { S = "Francis Scott Key Fitzgerald" } },
                };

                // Construct write-request for first table
                List<WriteRequest> authorsTableItems = new List<WriteRequest>();
                authorsTableItems.Add(new WriteRequest
                {
                    DeleteRequest = new DeleteRequest { Key = keyToDelete2 }
                });

                #endregion

                #region BatchWrite Sample 3

                // Create a client
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                // Construct table-keys mapping
                Dictionary<string, List<WriteRequest>> requestItems = new Dictionary<string, List<WriteRequest>>();
                requestItems["SampleTable"] = sampleTableItems;
                requestItems["AuthorsTable"] = authorsTableItems;

                BatchWriteItemRequest request = new BatchWriteItemRequest { RequestItems = requestItems };
                BatchWriteItemResponse response;
                do
                {
                    // Issue request and retrieve items
                    response = await client.BatchWriteItemAsync(request);

                    // Some items may not have been processed!
                    //  Set RequestItems to the result's UnprocessedItems and reissue request
                    request.RequestItems = response.UnprocessedItems;

                } while (response.UnprocessedItems?.Count > 0);

                #endregion
            }
        }

        private static async Task EnsureTables()
        {
            List<KeySchemaElement> schema = new List<KeySchemaElement>
            {
                new KeySchemaElement
                {
                    AttributeName = "Author", KeyType = "HASH"
                },
                new KeySchemaElement
                {
                    AttributeName = "Title", KeyType = "RANGE"
                }
            };
            List<AttributeDefinition> definitions = new List<AttributeDefinition>
            {
                new AttributeDefinition
                {
                    AttributeName = "Author", AttributeType = "S"
                },
                new AttributeDefinition
                {
                    AttributeName = "Title", AttributeType = "S"
                }
            };
            await TableUtils.ConfirmTableExistence("SampleTable", TestClient, schema, definitions, 5, 5);

            schema.RemoveAt(1);
            definitions.RemoveAt(1);
            await TableUtils.ConfirmTableExistence("AuthorsTable", TestClient, schema, definitions, 5, 5);
        }
        private static async Task RemoveTables()
        {
            await TableUtils.DeleteTables(TestClient, "SampleTable", "AuthorsTable");
        }

        private static IAmazonDynamoDB TestClient;

        #region ISample Members

        public async Task Run()
        {
            using (TestClient = new AmazonDynamoDBClient())
            {
                await RemoveTables();

                await DataPlaneSamples();
                await CRUDSamples();
                await SearchSamples();
                await BatchSamples();

                await RemoveTables();
            }
        }

        #endregion
    }
}
