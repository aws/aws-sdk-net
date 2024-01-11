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
using Amazon.DynamoDBv2.Model;

namespace LambdaBenchmarks;

public class DDBBenchmarksLowLevelAPI
{
    private AmazonDynamoDBClient _dynamoDBClient = new AmazonDynamoDBClient();

    /// <summary>
    /// Test DynamoDB Get Item, it should return an item with 10 attributes
    /// </summary
    public async Task<Dictionary<string, AttributeValue>> GetItemHandler(DynamoDBInputPayload payload)
    {
        var key = new Dictionary<string, AttributeValue> 
        {
            { "Author", new AttributeValue { S = payload.AuthorName } },
            { "Price", new AttributeValue { N = "123" } }
        };

        var getItemResponse = await _dynamoDBClient.GetItemAsync(payload.TableName, key);
        return getItemResponse.Item;
    }
}
