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

using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace LambdaBenchmarksRunner
{
    public class DynamoDBBenchmarksRunner : LambdaBenchmarkBase
    {
        [Params("LowLevel", "DocumentModel", "ContextWithMetadata", "ContextNoMetadata")]
        public string DynamoDBModelType { get; set; }

        private AmazonDynamoDBClient _dynamoDbClient;
        private string _tableName;
        private string _payload;
        private string _uniqueId;

        private const string authorName = "Mark Twain";
        private const string GetItemFunctionName = "GetItemHandler";
        private const string DynamoDBFunctionsPath = "LambdaBenchmarks::LambdaBenchmarks";

        private Dictionary<string, string> modelTypeToHandlerTypeDictionary = new Dictionary<string, string>()
        {
            {"LowLevel", "DDBBenchmarksLowLevelAPI" },
            {"DocumentModel", "DDBBenchmarksDocumentModelAPI" },
            {"ContextWithMetadata", "DDBBenchmarksContextWithFetchingTableMetadataAPI" },
            {"ContextNoMetadata", "DDBBenchmarksContextWithoutFetchingTableMetadataAPI" },
        };

        public async Task GlobalSetup()
        {
            _dynamoDbClient = new AmazonDynamoDBClient();

            _uniqueId = new Random().Next().ToString("x");
            _tableName = "aws-net-sdk-lambda-benchmarks-table-" + _uniqueId;

            var createTableRequest = new CreateTableRequest
            {
                TableName = _tableName,
                KeySchema = new List<KeySchemaElement>
                {
                    new KeySchemaElement { KeyType = KeyType.HASH, AttributeName = "Author" },
                    new KeySchemaElement { KeyType = KeyType.RANGE, AttributeName = "Price" },
                },
                AttributeDefinitions = new List<AttributeDefinition>
                {
                    new AttributeDefinition { AttributeName = "Author", AttributeType = ScalarAttributeType.S },
                    new AttributeDefinition { AttributeName = "Price", AttributeType = ScalarAttributeType.N },
                },
                BillingMode = BillingMode.PAY_PER_REQUEST
            };
            await _dynamoDbClient.CreateTableAsync(createTableRequest);

            _payload = JsonSerializer.Serialize(new
            {
                tableName = _tableName,
                authorName,
            });
        }

        #region GetItem

        [GlobalSetup(Target = nameof(DynamoDB_GetItem))]
        public async Task SetupForGetItem()
        {
            await GlobalSetup();

            await InitializeLambdaFunction($"{GetItemFunctionName}{DynamoDBModelType}-{_uniqueId}", $"{DynamoDBFunctionsPath}.{modelTypeToHandlerTypeDictionary[DynamoDBModelType]}::{GetItemFunctionName}");
            await AddNewItem(authorName, 123);
            await AddNewItem(authorName, 23);
        }

        [Benchmark]
        public async Task DynamoDB_GetItem()
        {
            await LambdaUtilities.ExecuteFunction(lambdaClient, CurrentFunctionName, _payload);
        }

        [GlobalCleanup(Target = nameof(DynamoDB_GetItem))]
        public async Task CleanupForGetItem()
        {
            await DeleteCurrentLambdaFunction();
            await GlobalCleanup();
        }

        #endregion

        public async Task GlobalCleanup()
        {
            await _dynamoDbClient.DeleteTableAsync(_tableName);
        }

        private async Task AddNewItem(string author, int price)
        {
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["Author"] = new AttributeValue { S = author };
            attributes["Price"] = new AttributeValue { N = price.ToString() };
            attributes["Title"] = new AttributeValue { S = "The Adventures of Tom Sawyer" };
            attributes["Description"] = new AttributeValue { S = "The tales of Tom Sawyer" };
            attributes["Year"] = new AttributeValue { N = "1876" };
            attributes["Setting"] = new AttributeValue { S = "Missouri" };
            attributes["Pages"] = new AttributeValue { N = "275" };
            attributes["Genre"] = new AttributeValue { S = "Children's Novel" };
            attributes["Rating"] = new AttributeValue { N = "4.5" };
            attributes["ISBN"] = new AttributeValue { N = "123123123" };

            await _dynamoDbClient.PutItemAsync(new PutItemRequest
            {
                TableName = _tableName,
                Item = attributes
            });
        }

    }
}
