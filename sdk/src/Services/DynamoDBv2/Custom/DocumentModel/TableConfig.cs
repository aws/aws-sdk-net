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

using System;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Configuration for the Table.PutItem operation
    /// </summary>
    public class TableConfig
    {
        /// <summary>
        /// Name of the table.
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// The document API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.
        /// </summary>
        /// <remarks>
        /// For <see cref="MetadataCachingMode.Default"/> the cache key will be a combination of the table name, credentials, region and service URL. 
        /// For <see cref="MetadataCachingMode.TableNameOnly"/> the cache key will only consist of the table name. This reduces cache misses in contexts
        /// where you are accessing tables with identical structure but using different credentials or endpoints (such as a multi-tenant application).
        /// </remarks>
        public MetadataCachingMode? MetadataCachingMode { get; set; }

        /// <summary>
        /// Conversion to use for converting .NET values to DynamoDB values.
        /// Default is AWSConfigs.DynamoDBConfig.ConversionSchema.
        /// </summary>
        public DynamoDBEntryConversion Conversion { get; set; }

        /// <summary>
        /// List of DateTime attributes that should be converted to epoch seconds
        /// before they are stored in DynamoDB.
        /// </summary>
        public List<string> AttributesToStoreAsEpoch { get; set; }

        /// <summary>
        /// List of DateTime attributes that should be converted to epoch seconds
        /// before they are stored in DynamoDB.
        /// </summary>
        /// <remarks>
        /// These attributes will be (de)serialized as long values, which means that they support dates AFTER 2038, as opposed to <see cref="AttributesToStoreAsEpoch"/>
        /// </remarks>
        public List<string> AttributesToStoreAsEpochLong { get; set; }

        internal Table.DynamoDBConsumer Consumer { get; set; }
        internal bool IsEmptyStringValueEnabled { get; set; }


        /// <summary>
        /// Constructs TableConfig for a given table.
        /// Uses conversions schema AWSConfigs.DynamoDBConfig.ConversionSchema.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        public TableConfig(string tableName)
            : this(tableName, DynamoDBEntryConversion.CurrentConversion, Table.DynamoDBConsumer.DocumentModel, null, null,
                false, metadataCachingMode: DynamoDBv2.MetadataCachingMode.Default)
        {
        }

        internal TableConfig(string tableName, DynamoDBEntryConversion conversion, Table.DynamoDBConsumer consumer,
            IEnumerable<string> storeAsEpoch, IEnumerable<string> storeAsEpochLong, bool isEmptyStringValueEnabled, MetadataCachingMode? metadataCachingMode)
        {
            if (string.IsNullOrEmpty(tableName)) throw new ArgumentNullException("tableName");

            TableName = tableName;
            MetadataCachingMode = metadataCachingMode;
            Conversion = conversion;
            Consumer = consumer;
            IsEmptyStringValueEnabled = isEmptyStringValueEnabled;
            AttributesToStoreAsEpoch = new List<string>();
            if (storeAsEpoch != null)
            {
                AttributesToStoreAsEpoch.AddRange(storeAsEpoch);
            }
            AttributesToStoreAsEpochLong = new List<string>();
            if (storeAsEpochLong != null)
            {
                AttributesToStoreAsEpochLong.AddRange(storeAsEpochLong);
            }
        }
    }
}
