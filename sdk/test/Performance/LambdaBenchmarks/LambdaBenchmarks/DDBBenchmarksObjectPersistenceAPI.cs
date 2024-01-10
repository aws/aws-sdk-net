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
using Amazon.Runtime.Internal.Util;

namespace LambdaBenchmarks;


public class DynamoDBInputPayload
{
    public string TableName { get; set; }
    public string AuthorName { get; set; }
}

public class Book
{
    [DynamoDBHashKey]
    public string Author { get; set; }
    [DynamoDBRangeKey]
    public double Price { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public string Setting { get; set; }
    public int Pages { get; set; }
    public string Genre { get; set; }
    public double Rating { get; set; }
    public int ISBN { get; set; }

}

public class DDBBenchmarksContextWithFetchingTableMetadataAPI
{
    protected virtual DynamoDBContext GetDynamoDBContext()
    {
        return new DynamoDBContext(new AmazonDynamoDBClient(), new DynamoDBContextConfig
        {
            DisableFetchingTableMetadata = false
        });
    }

    /// <summary>
    /// Test DynamoDB Get Item, it should return an item with 10 attributes
    /// </summary
    public async Task<Book> GetItemHandler(DynamoDBInputPayload payload)
    {
        var dbContext = GetDynamoDBContext();
        
        var operationConfig = new DynamoDBOperationConfig { OverrideTableName = payload.TableName };
        return await dbContext.LoadAsync<Book>(payload.AuthorName, 123.0, operationConfig);
    }
}

public class DDBBenchmarksContextWithoutFetchingTableMetadataAPI : DDBBenchmarksContextWithFetchingTableMetadataAPI
{
    protected override DynamoDBContext GetDynamoDBContext()
    {
        SdkCache.Clear();
        return new DynamoDBContext(new AmazonDynamoDBClient(), new DynamoDBContextConfig
        {
            DisableFetchingTableMetadata = true
        });
    }
}