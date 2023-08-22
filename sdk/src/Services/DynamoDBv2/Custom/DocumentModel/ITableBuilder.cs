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

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Interface for a builder that constructs a <see cref="Table"/>
    /// </summary>
    public interface ITableBuilder
    {
        /// <summary>
        /// Call at the end to retrieve the new <see cref="Table"/>
        /// </summary>
        /// <returns>Built table</returns>
        Table Build();

        /// <summary>
        /// Adds the primary key definition to the table
        /// </summary>
        /// <param name="hashKeyAttribute">Name of the attribute used as the partition key</param>
        /// <param name="type">Type of that attribute</param>
        ITableBuilder AddHashKey(string hashKeyAttribute, DynamoDBEntryType type);

        /// <summary>
        /// Adds a sort key definition to the table
        /// </summary>
        /// <param name="rangeKeyAttribute">Name of the attribute used as the sort key</param>
        /// <param name="type">Type of that attribute </param>
        ITableBuilder AddRangeKey(string rangeKeyAttribute, DynamoDBEntryType type);

        /// <summary>
        /// Adds a local secondary index definition to the table
        /// </summary>
        /// <param name="indexName">Name of the local secondary index</param>
        /// <param name="rangeKeyAttribute">Name of the attribute used as the sort key in the local secondary index</param>
        /// <param name="type">Type of that attribute</param>
        ITableBuilder AddLocalSecondaryIndex(string indexName, string rangeKeyAttribute, DynamoDBEntryType type);

        /// <summary>
        /// Adds a global secondary index definition to the table
        /// </summary>
        /// <param name="indexName">Name of the global secondary index</param>
        /// <param name="hashkeyAttribute">Name of the attribute used as the partition key in the GSI</param>
        /// <param name="hashKeyType">Type of the hash key attribute</param>
        ITableBuilder AddGlobalSecondaryIndex(string indexName, string hashkeyAttribute, DynamoDBEntryType hashKeyType);

        /// <summary>
        /// Adds a global secondary index definition to the table
        /// </summary>
        /// <param name="indexName">Name of the global secondary index</param>
        /// <param name="hashkeyAttribute">Name of the attribute used as the partition key in the GSI</param>
        /// <param name="hashKeyType">Type of the hash key attribute</param>
        /// <param name="rangeKeyAttribute">Name of the attribute used as the sort key in the GSI</param>
        /// <param name="rangeKeyType">Type of the sort key attribute</param>
        ITableBuilder AddGlobalSecondaryIndex(string indexName, string hashkeyAttribute, DynamoDBEntryType hashKeyType, string rangeKeyAttribute, DynamoDBEntryType rangeKeyType);
    }
}
