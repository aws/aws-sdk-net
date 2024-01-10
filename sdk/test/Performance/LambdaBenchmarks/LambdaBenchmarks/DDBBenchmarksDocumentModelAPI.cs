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
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaBenchmarks;

public class DDBBenchmarksDocumentModelAPI
{
    private AmazonDynamoDBClient _dynamoDBClient = new AmazonDynamoDBClient();
    private Table _booksTable;

    private Table GetBooksTable(string tableName)
    {
        if (_booksTable == null || _booksTable.TableName != tableName)
        {
            _booksTable = Table.LoadTable(_dynamoDBClient, tableName);

            _booksTable = new TableBuilder(_dynamoDBClient, tableName)
                .AddHashKey("Author", DynamoDBEntryType.String)
                .AddRangeKey("Price", DynamoDBEntryType.Numeric)
                    .Build();
        }
        return _booksTable;
    }

    /// <summary>
    /// Test DynamoDB Get Item, it should return an item with 10 attributes
    /// </summary
    public async Task<Document> GetItemHandler(DynamoDBInputPayload payload)
    {
        var table = GetBooksTable(payload.TableName);
        var config = new GetItemOperationConfig
        {
            AttributesToGet = new List<string>
            {
                "Author",
                "Price",
                "Title",
                "Description",
                "Year",
                "Setting",
                "Pages",
                "Genre",
                "Rating",
                "ISBN"
            },
        };

        return await table.GetItemAsync(payload.AuthorName, 123, config);
    }
}
