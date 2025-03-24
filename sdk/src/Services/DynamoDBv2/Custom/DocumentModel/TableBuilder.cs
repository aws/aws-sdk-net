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
using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// Builder that constructs a <see cref="Table"/>
    /// </summary>
    public class TableBuilder : ITableBuilder
    {
        /// <summary>
        /// The <see cref="Table"/> object that is built and then returned from <see cref="Build"/>
        /// </summary>
        private Table _table;

        /// <summary>
        /// Keeps track internally of attributes that have already been saved in <see cref="Table.Attributes"/>,
        /// since they can be shared by different indices.
        /// </summary>
        private HashSet<string> _attributesAlreadyProcessed; 

        /// <summary>
        /// Creates a builder object to construct a <see cref="Table"/>
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Table name</param>
        public TableBuilder(IAmazonDynamoDB ddbClient, string tableName) :
             this(ddbClient, tableName, DynamoDBEntryConversion.CurrentConversion, false, null)
        {
        }

        /// <summary>
        /// Creates a builder object to construct a <see cref="Table"/>
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Table name</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <param name="metadataCachingMode">The document API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.</param>
        public TableBuilder(IAmazonDynamoDB ddbClient, string tableName, DynamoDBEntryConversion conversion, bool isEmptyStringValueEnabled, MetadataCachingMode? metadataCachingMode)
            : this(ddbClient, new TableConfig(tableName, conversion, Table.DynamoDBConsumer.DocumentModel, null, null, isEmptyStringValueEnabled, metadataCachingMode))
        {
        }

        /// <summary>
        /// Creates a builder object to construct a <see cref="Table"/>
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="config">Configuration to use for the table.</param>
        public TableBuilder(IAmazonDynamoDB ddbClient, TableConfig config)
        {
            _table = new Table(ddbClient, config);
            _table.ClearTableData(); // initializes internal collections
            _attributesAlreadyProcessed = new HashSet<string>();
        }

        /// <inheritdoc/>
        public Table Build()
        {
            if (_table.HashKeys.Count == 0)
            {
                throw new ArgumentOutOfRangeException("A hash key definition is required, call AddHashKey before Build.");
            }

            return _table;
        }

        /// <inheritdoc/>
        public ITableBuilder AddHashKey(string hashKeyAttribute, DynamoDBEntryType type)
        {
            if (string.IsNullOrEmpty(hashKeyAttribute))
            {
                throw new ArgumentNullException(nameof(hashKeyAttribute), "The name of the hash key attribute is required.");
            }
            
            if (_table.HashKeys.Count != 0)
            {
                throw new ArgumentOutOfRangeException("Only a single hash key is supported, and one has already been added.");
            }

            _table.HashKeys.Add(hashKeyAttribute);

            _table.Keys.Add(hashKeyAttribute, new KeyDescription
            {
                IsHash = true,
                Type = type
            });

            if (!_attributesAlreadyProcessed.Contains(hashKeyAttribute))
            {
                _table.Attributes.Add(new AttributeDefinition(hashKeyAttribute, dynamoDBEntryTypeToScalarAttributeType(type)));
                _attributesAlreadyProcessed.Add(hashKeyAttribute);
            }

            return this;
        }

        /// <inheritdoc/>
        public ITableBuilder AddRangeKey(string rangeKeyAttribute, DynamoDBEntryType type)
        {
            if (string.IsNullOrEmpty(rangeKeyAttribute))
            {
                throw new ArgumentNullException(nameof(rangeKeyAttribute), "The name of the range key attribute is required.");
            }

            if (_table.RangeKeys.Count != 0)
            {
                throw new ArgumentOutOfRangeException("Only a single range key is supported, and one has already been added.");
            }

            _table.RangeKeys.Add(rangeKeyAttribute);

            _table.Keys.Add(rangeKeyAttribute, new KeyDescription
            {
                IsHash = false,
                Type = type
            });

            if (!_attributesAlreadyProcessed.Contains(rangeKeyAttribute))
            {
                _table.Attributes.Add(new AttributeDefinition(rangeKeyAttribute, dynamoDBEntryTypeToScalarAttributeType(type)));
                _attributesAlreadyProcessed.Add(rangeKeyAttribute);
            }

            return this;
        }

        /// <inheritdoc/>
        public ITableBuilder AddLocalSecondaryIndex(string indexName, string rangeKeyAttribute, DynamoDBEntryType type)
        {
            if (string.IsNullOrEmpty(indexName))
            {
                throw new ArgumentNullException(nameof(indexName), "The name of the local secondary index is required");
            }

            if (_table.LocalSecondaryIndexes.ContainsKey(indexName))
            {
                throw new ArgumentException($"An local secondary index with name {indexName} has already been defined.");
            }

            if (string.IsNullOrEmpty(rangeKeyAttribute))
            {
                throw new ArgumentNullException(nameof(rangeKeyAttribute), "The attribute name of the range key within the local secondary index is required.");
            }

            if (_table.HashKeys.Count == 0)
            {
                throw new ArgumentException("A local secondary index uses the table's hash key, which was not provided. Call AddHashKey prior to AddLocalSecondaryIndex.");

            }            

            _table.LocalSecondaryIndexNames.Add(indexName);

            _table.LocalSecondaryIndexes.Add(indexName, new LocalSecondaryIndexDescription
            {
                IndexName = indexName,
                KeySchema = new List<KeySchemaElement>()
                {
                    new KeySchemaElement { AttributeName = _table.HashKeys[0], KeyType = KeyType.HASH },
                    new KeySchemaElement { AttributeName = rangeKeyAttribute, KeyType = KeyType.RANGE }
                }
            });

            if (!_attributesAlreadyProcessed.Contains(rangeKeyAttribute))
            {
                _table.Attributes.Add(new AttributeDefinition(rangeKeyAttribute, dynamoDBEntryTypeToScalarAttributeType(type)));
                _attributesAlreadyProcessed.Add(rangeKeyAttribute);
            }

            return this;
        }

        /// <inheritdoc/>
        public ITableBuilder AddGlobalSecondaryIndex(string indexName, string hashkeyAttribute, DynamoDBEntryType hashKeyType)
        {
            if (string.IsNullOrEmpty(indexName))
            {
                throw new ArgumentNullException(nameof(indexName), "The name of the global secondary index is required");
            }

            if (_table.GlobalSecondaryIndexes.ContainsKey(indexName))
            {
                throw new ArgumentException($"An global secondary index with name {indexName} has already been defined.");
            }

            if (string.IsNullOrEmpty(hashkeyAttribute))
            {
                throw new ArgumentNullException(nameof(hashkeyAttribute), "The attribute name of the hash key within the global secondary index is required.");
            }

            _table.GlobalSecondaryIndexNames.Add(indexName);

            _table.GlobalSecondaryIndexes.Add(indexName, new GlobalSecondaryIndexDescription
            {
                IndexName = indexName,
                KeySchema = new List<KeySchemaElement>()
                {
                    new KeySchemaElement { AttributeName = hashkeyAttribute, KeyType = KeyType.HASH }
                }
            });

            if (!_attributesAlreadyProcessed.Contains(hashkeyAttribute))
            {
                _table.Attributes.Add(new AttributeDefinition(hashkeyAttribute, dynamoDBEntryTypeToScalarAttributeType(hashKeyType)));
                _attributesAlreadyProcessed.Add(hashkeyAttribute);
            }

            return this;
        }

        /// <inheritdoc/>
        public ITableBuilder AddGlobalSecondaryIndex(string indexName, string hashkeyAttribute, DynamoDBEntryType hashKeyType, string rangeKeyAttribute, DynamoDBEntryType rangeKeyType)
        {
            if (string.IsNullOrEmpty(indexName))
            {
                throw new ArgumentNullException(nameof(indexName), "The name of the global secondary index is required");
            }

            if (_table.GlobalSecondaryIndexes.ContainsKey(indexName))
            {
                throw new ArgumentException($"An global secondary index with name {indexName} has already been defined.");
            }

            if (string.IsNullOrEmpty(hashkeyAttribute))
            {
                throw new ArgumentNullException(nameof(hashkeyAttribute), "The attribute name of the hash key within the global secondary index is required.");
            }

            if (string.IsNullOrEmpty(rangeKeyAttribute))
            {
                throw new ArgumentNullException(nameof(rangeKeyAttribute), "The attribute name of the range key within the global secondary index is required.");
            }

            _table.GlobalSecondaryIndexNames.Add(indexName);

            _table.GlobalSecondaryIndexes.Add(indexName, new GlobalSecondaryIndexDescription
            {
                IndexName = indexName,
                KeySchema = new List<KeySchemaElement>()
                {
                    new KeySchemaElement { AttributeName = hashkeyAttribute, KeyType = KeyType.HASH },
                    new KeySchemaElement { AttributeName = rangeKeyAttribute, KeyType = KeyType.RANGE }
                }
            });

            if (!_attributesAlreadyProcessed.Contains(hashkeyAttribute))
            {
                _table.Attributes.Add(new AttributeDefinition(hashkeyAttribute, dynamoDBEntryTypeToScalarAttributeType(hashKeyType)));
                _attributesAlreadyProcessed.Add(hashkeyAttribute);
            }

            if (!_attributesAlreadyProcessed.Contains(rangeKeyAttribute))
            {
                _table.Attributes.Add(new AttributeDefinition(rangeKeyAttribute, dynamoDBEntryTypeToScalarAttributeType(rangeKeyType)));
                _attributesAlreadyProcessed.Add(rangeKeyAttribute);
            }

            return this;
        }

        /// <summary>
        /// Maps the document model's <see cref="DynamoDBEntryType"/> to the corresponding, low-level <see cref="ScalarAttributeType"/>
        /// </summary>
        /// <param name="entryType">Document model attribute type</param>
        /// <returns>Corresponding low-level attribute type</returns>
        private static ScalarAttributeType dynamoDBEntryTypeToScalarAttributeType(DynamoDBEntryType entryType)
        {
            switch (entryType)
            {
                case DynamoDBEntryType.String:
                    return ScalarAttributeType.S;
                case DynamoDBEntryType.Numeric:
                    return ScalarAttributeType.N;
                case DynamoDBEntryType.Binary:
                    return ScalarAttributeType.B;
                default:
                    throw new ArgumentOutOfRangeException(nameof(entryType), "Not a valid ScalarAttributeType");
            }
        }
    }
}
