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

namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// The higher-level programming models found in the DocumentModel and DataModel namespaces 
    /// rely on an internal cache of the DynamoDB table's metadata to construct and validate requests.
    /// This controls how the cache key is derived, which influences 
    /// when the SDK will call IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.
    /// </summary>
    public enum MetadataCachingMode
    {
        /// <summary>
        /// The cache key will be a combination of the table name, credentials, region and service URL.
        /// This ensures applications using tables with the same name but different definitions have their own metadata cached in the application. 
        /// This will require additional IAmazonDynamoDB.DescribeTable(string) API calls as credentials are refreshed.
        /// </summary>
        Default,

        /// <summary>
        /// The cache key will only consist of the table name. This reduces cache misses in contexts
        /// where you are accessing tables with identical structure but using different credentials or endpoints
        /// (such as a multi-tenant application).
        /// </summary>
        TableNameOnly
    }
}
