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

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Util;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Globalization;
using Amazon.DynamoDBv2.DataModel;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.Runtime.Internal.UserAgent;

namespace Amazon.DynamoDBv2.DocumentModel
{
    /// <summary>
    /// This represents the table interface when using the Document API. It is used to Get documents from the DynamoDB table
    /// and write documents back to the DynamoDB table.
    /// </summary>
    public partial interface ITable
    {
        #region Public properties

        /// <summary>
        /// Name of the table.
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Keys of the table.
        /// </summary>
        Dictionary<string, KeyDescription> Keys { get; }

        /// <summary>
        /// Global secondary indexes of the table.
        /// </summary>
        Dictionary<string, GlobalSecondaryIndexDescription> GlobalSecondaryIndexes { get; }

        /// <summary>
        /// Local secondary indexes of the table.
        /// </summary>
        Dictionary<string, LocalSecondaryIndexDescription> LocalSecondaryIndexes { get; }

        /// <summary>
        /// Names of the local secondary indexes of the table.
        /// </summary>
        List<string> LocalSecondaryIndexNames { get; }

        /// <summary>
        /// Names of the global secondary indexes of the table.
        /// </summary>
        List<string> GlobalSecondaryIndexNames { get; }

        /// <summary>
        /// List of keys on the table marked HASH
        /// </summary>
        List<string> HashKeys { get; }

        /// <summary>
        /// List of keys on the table marked RANGE
        /// </summary>
        List<string> RangeKeys { get; }

        /// <summary>
        /// List of key attributes on the table.
        /// </summary>
        public List<AttributeDefinition> Attributes { get; set; }

        #endregion

        #region Conversion methods

        /// <summary>
        /// Creates a Document from an attribute map.
        /// </summary>
        /// <param name="data">Map of attribute names to attribute values.</param>
        /// <returns>Document representing the data.</returns>
        Document FromAttributeMap(Dictionary<string, AttributeValue> data);

        /// <summary>
        /// Creates a map of attribute names mapped to AttributeValue objects.
        /// Converts .NET types using the conversion specified in this Table.
        /// </summary>
        /// <returns></returns>
        Dictionary<string, AttributeValue> ToAttributeMap(Document doc);

        /// <summary>
        /// Creates a map of attribute names mapped to ExpectedAttributeValue objects.
        /// </summary>
        /// <returns></returns>
        Dictionary<string, ExpectedAttributeValue> ToExpectedAttributeMap(Document doc);

        /// <summary>
        /// Creates a map of attribute names mapped to AttributeValueUpdate objects.
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="changedAttributesOnly">If true, only attributes that have been changed will be in the map.</param>
        /// <returns></returns>
        Dictionary<string, AttributeValueUpdate> ToAttributeUpdateMap(Document doc, bool changedAttributesOnly);


        #endregion

        #region Scan

        /// <summary>
        /// Initiates a Search object to Scan a DynamoDB table, with the
        /// specified filter.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="filter">Filter to apply to the scan.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Scan(ScanFilter filter);

        /// <summary>
        /// Initiates a Search object to Scan a DynamoDB table, with the
        /// specified expression.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="filterExpression">Expression to apply to the scan.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Scan(Expression filterExpression);


        /// <summary>
        /// Initiates a Search object to Scan a DynamoDB table, with the
        /// specified config.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Scan(ScanOperationConfig config);

        #endregion

        #region Query

        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified hash primary key and filter.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="hashKey">Value of the hash key for the query operation.</param>
        /// <param name="filter">Filter to use.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Query(Primitive hashKey, QueryFilter filter);


        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified hash primary key and expression.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="hashKey">Value of the hash key for the query operation.</param>
        /// <param name="filterExpression">Expression to use.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Query(Primitive hashKey, Expression filterExpression);

        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified filter.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="filter">Filter to use.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Query(QueryFilter filter);

        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified config.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Resultant Search container.</returns>
        ISearch Query(QueryOperationConfig config);

        #endregion

        #region BatchGet

        /// <summary>
        /// Creates a DocumentBatchGet object for the current table, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <returns>Empty DocumentBatchGet object.</returns>
        IDocumentBatchGet CreateBatchGet();

        #endregion

        #region BatchWrite

        /// <summary>
        /// Creates a DocumentBatchWrite object for the current table, allowing
        /// a batch-put/delete operation against DynamoDB.
        /// </summary>
        /// <returns>Empty DocumentBatchWrite object.</returns>
        IDocumentBatchWrite CreateBatchWrite();

        #endregion

        #region TransactGet

        /// <summary>
        /// Creates a DocumentTransactGet object for the current table, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <returns>Empty DocumentTransactGet object.</returns>
        IDocumentTransactGet CreateTransactGet();

        #endregion

        #region TransactWrite

        /// <summary>
        /// Creates a DocumentTransactWrite object for the current table, allowing
        /// a transactional condition-check/put/update/delete operation against DynamoDB.
        /// </summary>
        /// <returns>Empty DocumentTransactWrite object.</returns>
        IDocumentTransactWrite CreateTransactWrite();

        #endregion
    }

    /// <summary>
    /// The Table class is the starting object when using the Document API. It is used to Get documents from the DynamoDB table
    /// and write documents back to the DynamoDB table.
    /// </summary>
    public partial class Table : ITable
    {
        #region Private/internal members

        internal enum DynamoDBConsumer
        {
            DocumentModel, DataModel, SessionStateProvider
        }

        private static string TableInfoCacheIdentifier = typeof(Table).FullName;
        private TableConfig Config;

        internal Table.DynamoDBConsumer TableConsumer { get { return Config.Consumer; } }
        internal DynamoDBEntryConversion Conversion { get { return Config.Conversion; } }
        internal bool IsEmptyStringValueEnabled { get { return Config.IsEmptyStringValueEnabled; } }
        internal IEnumerable<string> StoreAsEpoch { get { return Config.AttributesToStoreAsEpoch; } }
        internal IEnumerable<string> StoreAsEpochLong { get { return Config.AttributesToStoreAsEpochLong; } }
        internal IEnumerable<string> KeyNames { get { return Keys.Keys; } }
        internal IAmazonDynamoDB DDBClient { get; private set; }
        internal TracerProvider TracerProvider { get; private set; }

        #endregion

        #region Public properties

        /// <inheritdoc/>
        public string TableName { get { return Config.TableName; } }

        /// <inheritdoc/>
        public Dictionary<string, KeyDescription> Keys { get; private set; }

        /// <inheritdoc/>
        public Dictionary<string, GlobalSecondaryIndexDescription> GlobalSecondaryIndexes { get; private set; }

        /// <inheritdoc/>
        public Dictionary<string, LocalSecondaryIndexDescription> LocalSecondaryIndexes { get; private set; }

        /// <inheritdoc/>
        public List<string> LocalSecondaryIndexNames { get; private set; }

        /// <inheritdoc/>
        public List<string> GlobalSecondaryIndexNames { get; private set; }

        /// <inheritdoc/>
        public List<string> HashKeys { get; private set; }

        /// <inheritdoc/>
        public List<string> RangeKeys { get; private set; }

        /// <inheritdoc/>
        public List<AttributeDefinition> Attributes { get; set; }

        #endregion


        #region Private/internal methods

        private static DynamoDBEntryType GetType(string attributeType)
        {
            if (String.Equals(attributeType, "N"))
                return DynamoDBEntryType.Numeric;
            if (String.Equals(attributeType, "S"))
                return DynamoDBEntryType.String;
            if (String.Equals(attributeType, "B"))
                return DynamoDBEntryType.Binary;
            throw new InvalidOperationException("Unknown attribute type");
        }

        private ICache<string, TableDescription> GetTableDescriptionCache()
        {
            if (Config.MetadataCachingMode == MetadataCachingMode.TableNameOnly)
            {
                // Use only the table name as the cache key to enable cache reuse when the consumer is certain
                // different credentials identify the same physical table
                return SdkCache.GetCache<string, TableDescription>(null, TableInfoCacheIdentifier, StringComparer.Ordinal);
            }

            // Assuming CachingMode.Default, use the SdkCache's default credentials, region and service url to form the cache key.
            // Each of these could identify a different physical table
            return SdkCache.GetCache<string, TableDescription>(DDBClient, TableInfoCacheIdentifier, StringComparer.Ordinal);
        }

        private static ScalarAttributeType PrimitiveToScalar(DynamoDBEntryType primitiveEntryType)
        {
            switch (primitiveEntryType)
            {
                case DynamoDBEntryType.String:
                    return ScalarAttributeType.S;
                case DynamoDBEntryType.Numeric:
                    return ScalarAttributeType.N;
                case DynamoDBEntryType.Binary:
                    return ScalarAttributeType.B;
                default:
                    throw new ArgumentOutOfRangeException(nameof(primitiveEntryType), $"{primitiveEntryType} is not a known DynamoDB {nameof(ScalarAttributeType)}");
            }
        }

        private void LoadTableInfo(ICache<string, TableDescription> tableDescriptionCache)
        {
            ClearTableData();

            bool staleCacheData;
            TableDescription table = tableDescriptionCache.GetValue(TableName, this.DescribeTable, out staleCacheData);
            if (staleCacheData)
            {
                var logger = Logger.GetLogger(typeof(Table));
                logger.InfoFormat("Description for table [{0}] loaded from SDK Cache", TableName);
            }

            if (table.KeySchema != null)
            {
                foreach (var key in table.KeySchema)
                {
                    string keyName = key.AttributeName;
                    AttributeDefinition attributeDefinition = table.AttributeDefinitions
                        .FirstOrDefault(a => string.Equals(a.AttributeName, keyName, StringComparison.Ordinal));
                    if (attributeDefinition == null) throw new InvalidOperationException("No attribute definition found for key " + key.AttributeName);
                    KeyDescription keyDescription = new KeyDescription
                    {
                        IsHash = string.Equals(key.KeyType, "HASH", StringComparison.OrdinalIgnoreCase),
                        Type = GetType(attributeDefinition.AttributeType)
                    };
                    if (keyDescription.IsHash)
                        HashKeys.Add(keyName);
                    else
                        RangeKeys.Add(keyName);
                    Keys[keyName] = keyDescription;
                }
            }

            if (table.LocalSecondaryIndexes != null)
            {
                foreach (var index in table.LocalSecondaryIndexes)
                {
                    LocalSecondaryIndexes[index.IndexName] = index;
                    LocalSecondaryIndexNames.Add(index.IndexName);
                }
            }

            if (table.GlobalSecondaryIndexes != null)
            {
                foreach (var index in table.GlobalSecondaryIndexes)
                {
                    GlobalSecondaryIndexes[index.IndexName] = index;
                    GlobalSecondaryIndexNames.Add(index.IndexName);
                }
            }

            if (table.AttributeDefinitions != null)
            {
                foreach (var attribute in table.AttributeDefinitions)
                {
                    Attributes.Add(attribute);
                }
            }
        }

        internal Key MakeKey(IDictionary<string, DynamoDBEntry> doc)
        {
            Key key = new Key();
            foreach (var kvp in Keys)
            {
                string keyName = kvp.Key;
                KeyDescription description = kvp.Value;
                DynamoDBEntry value;
                if (!doc.TryGetValue(keyName, out value))
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Document does not contain value for key {0}", keyName));
                value = value.ToConvertedEntry(Conversion);
                if (StoreAsEpoch.Contains(keyName))
                    value = Document.DateTimeToEpochSeconds(value, keyName);

                if (StoreAsEpochLong.Contains(keyName))
                    value = Document.DateTimeToEpochSecondsLong(value, keyName);

                Primitive primitive = value.AsPrimitive();
                if (primitive == null)
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Key attribute {0} must be a Primitive type", keyName));
                if (primitive.Type != description.Type)
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Key attribute {0} must be of type {1}", keyName, description.Type));

                var attributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(Conversion, IsEmptyStringValueEnabled);
                key[keyName] = primitive.ConvertToAttributeValue(attributeConversionConfig);
            }
            return key;
        }

        internal Key MakeKey(Primitive hashKey, Primitive rangeKey)
        {
            Key newKey = new Key();

            if (HashKeys.Count != 1)
                throw new InvalidOperationException("Must have one hash key defined for the table " + TableName);
            string hashKeyName = HashKeys[0];
            KeyDescription hashKeyDescription = Keys[hashKeyName];
            if (this.StoreAsEpoch.Contains(hashKeyName))
                hashKey = KeyDateTimeToEpochSeconds(hashKey, hashKeyName);

            if (this.StoreAsEpochLong.Contains(hashKeyName))
                hashKey = KeyDateTimeToEpochSecondsLong(hashKey, hashKeyName);

            if (hashKeyDescription.Type != hashKey.Type)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Schema for table {0}, hash key {1}, is inconsistent with specified hash key value.", TableName, hashKeyName));

            var hashKeyAttributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(Conversion, IsEmptyStringValueEnabled);
            var hashKeyAttributeValue = hashKey.ConvertToAttributeValue(hashKeyAttributeConversionConfig);
            newKey[hashKeyName] = hashKeyAttributeValue;

            if ((rangeKey == null) != (RangeKeys.Count == 0))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                    "Schema for table {0}, range key {1}, is inconsistent with specified range key value.", TableName, hashKeyName));
            }
            else if (rangeKey != null)
            {
                string rangeKeyName = RangeKeys[0];
                KeyDescription rangeKeyDescription = Keys[rangeKeyName];

                if (this.StoreAsEpoch.Contains(rangeKeyName))
                    rangeKey = KeyDateTimeToEpochSeconds(rangeKey, rangeKeyName);

                if (this.StoreAsEpochLong.Contains(rangeKeyName))
                    rangeKey = KeyDateTimeToEpochSecondsLong(rangeKey, rangeKeyName);

                if (rangeKeyDescription.Type != rangeKey.Type)
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                        "Schema for table {0}, range key {1}, is inconsistent with specified range key value.", TableName, hashKeyName));

                var rangeKeyAttributeConversionConfig = new DynamoDBEntry.AttributeConversionConfig(Conversion, IsEmptyStringValueEnabled);
                var rangeKeyAttributeValue = rangeKey.ConvertToAttributeValue(rangeKeyAttributeConversionConfig);
                newKey[rangeKeyName] = rangeKeyAttributeValue;
            }

            return newKey;
        }
        private static Primitive KeyDateTimeToEpochSeconds(Primitive key, string attributeName)
        {
            DynamoDBEntry entry = Document.DateTimeToEpochSeconds(key, attributeName);
            Primitive converted = entry as Primitive;
            return converted;
        }

        private static Primitive KeyDateTimeToEpochSecondsLong(Primitive key, string attributeName)
        {
            DynamoDBEntry entry = Document.DateTimeToEpochSecondsLong(key, attributeName);
            Primitive converted = entry as Primitive;
            return converted;
        }

        internal void UpdateRequestUserAgentDetails(AmazonDynamoDBRequest request, bool isAsync)
        {
            if (request == null) return;

            var userAgentDetails = ((Runtime.Internal.IAmazonWebServiceRequest)request).UserAgentDetails;

            userAgentDetails.AddUserAgentComponent("ft/ddb-hll");
            userAgentDetails.AddUserAgentComponent($"md/{(isAsync ? "TableAsync" : "TableSync")}");

            if (this.TableConsumer == DynamoDBConsumer.DataModel)
            {
                userAgentDetails.AddFeature(UserAgentFeatureId.DDB_MAPPER);
            }
            else
            {
                userAgentDetails.AddUserAgentComponent($"md/{this.TableConsumer}");
            }
        }

        /// <summary>
        /// Validates that the conditional properties on the config object are correctly set.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException"/>
        /// <param name="config"></param>
        private static void ValidateConditional(IConditionalOperationConfig config)
        {
            if (config == null)
                return;

            int conditionsSet = 0;
            conditionsSet += config.Expected != null ? 1 : 0;
            conditionsSet += config.ExpectedState != null ? 1 : 0;
            conditionsSet += config.ConditionalExpression != null && config.ConditionalExpression.ExpressionStatement != null ? 1 : 0;

            if (conditionsSet > 1)
                throw new InvalidOperationException("Only one of the conditional properties Expected, ExpectedState and ConditionalExpression can be set.");
        }


        private void ValidateConditional(IConditionalOperationConfig config, Expression updateExpression)
        {

            if (config == null)
                return;

            int conditionsSet = 0;
            conditionsSet += config.Expected != null ? 1 : 0;
            conditionsSet += config.ExpectedState != null ? 1 : 0;
            conditionsSet += 
                (config.ConditionalExpression is { ExpressionStatement: not null } || updateExpression is { ExpressionStatement: not null }) ? 1 : 0;

            if (conditionsSet > 1)
                throw new InvalidOperationException("Only one of the conditional properties Expected, ExpectedState and ConditionalExpression or UpdateExpression can be set.");

        }

        internal void ClearTableData()
        {
            Keys = new Dictionary<string, KeyDescription>();
            HashKeys = new List<string>();
            RangeKeys = new List<string>();
            LocalSecondaryIndexes = new Dictionary<string, LocalSecondaryIndexDescription>();
            LocalSecondaryIndexNames = new List<string>();
            GlobalSecondaryIndexes = new Dictionary<string, GlobalSecondaryIndexDescription>();
            GlobalSecondaryIndexNames = new List<string>();
            Attributes = new List<AttributeDefinition>();
        }

        private TableDescription DescribeTable(string tableName)
        {
            DescribeTableRequest req = new DescribeTableRequest
            {
                TableName = TableName
            };
            this.UpdateRequestUserAgentDetails(req, isAsync: false);

#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous LoadTable from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via TableBuilder instead.");
            }
#else
            var client = DDBClient;
#endif

            var info = client.DescribeTable(req);

            if (info.Table == null)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Table name {0} does not exist", TableName));
            }

            return info.Table;
        }

        internal Table Copy()
        {
            return this.Copy(Config);
        }
        internal Table Copy(TableConfig newConfig)
        {
            return new Table(this.DDBClient, newConfig)
            {
                Keys = this.Keys,
                RangeKeys = this.RangeKeys,
                HashKeys = this.HashKeys,
                Attributes = this.Attributes,
                GlobalSecondaryIndexes = this.GlobalSecondaryIndexes,
                GlobalSecondaryIndexNames = this.GlobalSecondaryIndexNames,
                LocalSecondaryIndexes = this.LocalSecondaryIndexes,
                LocalSecondaryIndexNames = this.LocalSecondaryIndexNames
            };
        }

        internal Dictionary<string, AttributeValue> ToAttributeMap(Document doc, DynamoDBEntryConversion conversion)
        {
            return doc.ToAttributeMap(conversion, this.StoreAsEpoch, this.StoreAsEpochLong, Config.IsEmptyStringValueEnabled);
        }

        #endregion


        #region Constructor/factory

        internal Table(IAmazonDynamoDB ddbClient, TableConfig config)
        {
            if (config == null)
                throw new ArgumentNullException("config");

            if (ddbClient == null)
                throw new ArgumentNullException("ddbClient");

            DDBClient = ddbClient;
            Config = config;
            TracerProvider = DDBClient?.Config?.TelemetryProvider?.TracerProvider
                ?? AWSConfigs.TelemetryProvider.TracerProvider;
        }


        /// <summary>
        /// Clears current table cache. Next time a Table is created, its information
        /// will be loaded from DynamoDB.
        /// </summary>
        public static void ClearTableCache()
        {
            SdkCache.Clear(TableInfoCacheIdentifier);
        }

        /// <summary>
        /// Creates a Table object with the specified configuration, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="config">Configuration to use for the table.</param>
        /// <returns>Table object representing the specified table.</returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static ITable LoadTable(IAmazonDynamoDB ddbClient, TableConfig config)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(LoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                Table table = new Table(ddbClient, config);
                var tableDescriptionCache = table.GetTableDescriptionCache();
                table.LoadTableInfo(tableDescriptionCache);
                return table;
            }
        }

        /// <summary>
        /// Attempts to determine the primitive data type for a given .NET property that is mapped to a DynamoDB attribute
        /// </summary>
        /// <param name="property">.NET Property that is to be stored in DynamoDB</param>
        /// <param name="flatConfig">Normalized, internal high-level DynamoDB configuration</param>
        /// <returns><see cref="DynamoDBEntryType"/> if it can be determined for the given property, otherwise an exception will be thrown</returns>
        private static DynamoDBEntryType GetPrimitiveEntryTypeForProperty(PropertyStorage property, DynamoDBFlatConfig flatConfig)
        {
            if (property.StoreAsEpoch || property.StoreAsEpochLong)
            {
                return DynamoDBEntryType.Numeric;
            }

            // Converters can only convert an actual value, we can't just look up the resulting type 
            // so create a default value and attempt to convert it
            object hypotheticalValue;
            if (property.MemberType == typeof(string))
            {
                hypotheticalValue = string.Empty; // Activator.CreateInstance throws for string due to no default constructor
            }
            else
            {
                hypotheticalValue = Activator.CreateInstance(property.MemberType);
            }

            DynamoDBEntry convertedEntry;
            try
            {
                if (property.Converter != null)
                {
                    // If the property has a property converter, use it to convert the hypothetical value
                    convertedEntry = property.Converter.ToEntry(hypotheticalValue);

                    // If the converter's output was cast to an UnconvertedDynamoDBEntry, 
                    // try converting it again so we can determine the corresponding primitive type
                    if (convertedEntry is UnconvertedDynamoDBEntry unconvertedEntry)
                    {
                        convertedEntry = unconvertedEntry.Convert(flatConfig.Conversion);
                    }
                }
                else
                {
                    // This will throw an exception if the conversion fails, or if the resulting entry isn't a primitive
                    convertedEntry = flatConfig.Conversion.ConvertToEntry(property.MemberType, hypotheticalValue);
                }

                return convertedEntry.ToPrimitive().Type;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Failed to determine the DynamoDB primitive type for property {property.PropertyName} " +
                    $"of type {property.MemberType}. If using {nameof(DataModel.DynamoDBContextConfig.DisableFetchingTableMetadata)} and a converter " +
                    $"on a primary key, ensure that the converted entry can be cast to a {nameof(Primitive)}.", e);
            }
        }

        /// <summary>
        /// Creates a document model <see cref="Table"/> object from an object persistence model's <see cref="ItemStorageConfig"/>
        /// This contains the index information for a given table which is used to construct and validate the data plane operations.
        /// </summary>
        /// <param name="client">DynamoDB client that the resulting table will use for operations</param>
        /// <param name="config">Table configuration</param>
        /// <param name="itemStorageConfig">The object persistence configuration for a .NET class that is mapped to the given table</param>
        /// <param name="flatConfig">Normalized, internal high-level DynamoDB configuration</param>
        internal static Table CreateTableFromItemStorageConfig(IAmazonDynamoDB client, TableConfig config, ItemStorageConfig itemStorageConfig, DynamoDBFlatConfig flatConfig)
        {
            Table table = new Table(client, config);
            table.ClearTableData(); // initializes collections

            //
            // Add Hash Key in the Table metadata
            // 
            foreach (var hashKeyPropertyName in itemStorageConfig.HashKeyPropertyNames)
            {
                var property = itemStorageConfig.BaseTypeStorageConfig.GetPropertyStorage(hashKeyPropertyName);
                var primitiveType = GetPrimitiveEntryTypeForProperty(property, flatConfig);

                table.HashKeys.Add(property.AttributeName);

                table.Keys.Add(property.AttributeName, new KeyDescription
                {
                    IsHash = true,
                    Type = primitiveType
                });

                table.Attributes.Add(new AttributeDefinition { AttributeName = property.AttributeName, AttributeType = PrimitiveToScalar(primitiveType) });
            }

            //
            // Add Range Key in the table metadata
            //
            foreach (var rangeKeyPropertyName in itemStorageConfig.RangeKeyPropertyNames)
            {
                var property = itemStorageConfig.BaseTypeStorageConfig.GetPropertyStorage(rangeKeyPropertyName);
                var primitiveType = GetPrimitiveEntryTypeForProperty(property, flatConfig);

                table.RangeKeys.Add(property.AttributeName);

                table.Keys.Add(property.AttributeName, new KeyDescription
                {
                    IsHash = false,
                    Type = primitiveType
                });

                table.Attributes.Add(new AttributeDefinition { AttributeName = property.AttributeName, AttributeType = PrimitiveToScalar(primitiveType) });
            }

            //
            // Add Local Secondary Indices in the table metadata
            //
            foreach (var lsiIndexName in itemStorageConfig.IndexNameToLSIRangePropertiesMapping.Keys)
            {
                table.LocalSecondaryIndexNames.Add(lsiIndexName);

                var indexDescription = new LocalSecondaryIndexDescription()
                {
                    IndexName = lsiIndexName,
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement
                        {
                            AttributeName = table.HashKeys[0], // A LSI always reuses the main hash key
                            KeyType = KeyType.HASH
                        }
                    }
                };

                foreach (var lsiRangePropertyName in itemStorageConfig.IndexNameToLSIRangePropertiesMapping[lsiIndexName])
                {
                    var lsiRangeProperty = itemStorageConfig.BaseTypeStorageConfig.GetPropertyStorage(lsiRangePropertyName);
                    var primitiveType = GetPrimitiveEntryTypeForProperty(lsiRangeProperty, flatConfig);

                    indexDescription.KeySchema.Add(new KeySchemaElement
                    {
                        AttributeName = lsiRangeProperty.AttributeName,
                        KeyType = KeyType.RANGE
                    });

                    table.Attributes.Add(new AttributeDefinition { AttributeName = lsiRangeProperty.AttributeName, AttributeType = PrimitiveToScalar(primitiveType) });
                }

                table.LocalSecondaryIndexes[lsiIndexName] = indexDescription;
            }

            //
            // Add Global Secondary Indices in the table metadata
            //
            foreach (var gsiIndexName in itemStorageConfig.IndexNameToGSIMapping.Keys)
            {
                table.GlobalSecondaryIndexNames.Add(gsiIndexName);

                var gsi = itemStorageConfig.GetGSIConfig(gsiIndexName);

                var indexDescription = new GlobalSecondaryIndexDescription()
                {
                    IndexName = gsiIndexName
                };

                if (indexDescription.KeySchema == null)
                {
                    indexDescription.KeySchema = new List<KeySchemaElement>();
                }

                var hashKeyProperty = itemStorageConfig.BaseTypeStorageConfig.GetPropertyStorage(gsi.HashKeyPropertyName);
                indexDescription.KeySchema.Add(new KeySchemaElement()
                {
                    AttributeName = hashKeyProperty.AttributeName,
                    KeyType = KeyType.HASH
                });

                if (!string.IsNullOrEmpty(gsi.RangeKeyPropertyName))
                {
                    var rangeKeyProperty = itemStorageConfig.BaseTypeStorageConfig.GetPropertyStorage(gsi.RangeKeyPropertyName);
                    indexDescription.KeySchema.Add(new KeySchemaElement()
                    {
                        AttributeName = rangeKeyProperty.AttributeName,
                        KeyType = KeyType.RANGE
                    });
                }

                table.GlobalSecondaryIndexes[gsiIndexName] = indexDescription;
            }

            return table;
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// The returned table will use the conversion specified by
        /// AWSConfigs.DynamoDBConfig.ConversionSchema
        /// 
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <returns>Table object representing the specified table.</returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static ITable LoadTable(IAmazonDynamoDB ddbClient, string tableName)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(LoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return LoadTable(ddbClient, tableName, DynamoDBEntryConversion.CurrentConversion, false);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        ///
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <returns>Table object representing the specified table.</returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static ITable LoadTable(IAmazonDynamoDB ddbClient, string tableName, DynamoDBEntryConversion conversion)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(LoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return LoadTable(ddbClient, tableName, conversion, false);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <returns>Table object representing the specified table.</returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static ITable LoadTable(IAmazonDynamoDB ddbClient, string tableName, bool isEmptyStringValueEnabled)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(LoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return LoadTable(ddbClient, tableName, DynamoDBEntryConversion.CurrentConversion, isEmptyStringValueEnabled);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <returns>Table object representing the specified table.</returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static ITable LoadTable(IAmazonDynamoDB ddbClient, string tableName, DynamoDBEntryConversion conversion, bool isEmptyStringValueEnabled)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(LoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                var config = new TableConfig(tableName, conversion, DynamoDBConsumer.DocumentModel, storeAsEpoch: null, storeAsEpochLong: null, isEmptyStringValueEnabled: isEmptyStringValueEnabled, metadataCachingMode: MetadataCachingMode.Default);

                return LoadTable(ddbClient, config);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <param name="metadataCachingMode">The document API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.</param>
        /// <returns>Table object representing the specified table.</returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static ITable LoadTable(IAmazonDynamoDB ddbClient, string tableName, DynamoDBEntryConversion conversion, bool isEmptyStringValueEnabled, MetadataCachingMode metadataCachingMode)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(LoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                var config = new TableConfig(tableName, conversion, DynamoDBConsumer.DocumentModel, storeAsEpoch: null, storeAsEpochLong: null, isEmptyStringValueEnabled: isEmptyStringValueEnabled, metadataCachingMode: metadataCachingMode);

                return LoadTable(ddbClient, config);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// The returned table will use the conversion specified by
        /// AWSConfigs.DynamoDBConfig.ConversionSchema
        ///
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient, string tableName, out ITable table)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryLoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return TryLoadTable(ddbClient, tableName, DynamoDBEntryConversion.CurrentConversion, false, out table);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        ///
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient, string tableName, DynamoDBEntryConversion conversion, out ITable table)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryLoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return TryLoadTable(ddbClient, tableName, conversion, false, out table);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient, string tableName, bool isEmptyStringValueEnabled, out ITable table)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryLoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return TryLoadTable(ddbClient, tableName, DynamoDBEntryConversion.CurrentConversion, isEmptyStringValueEnabled, out table);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient, string tableName, DynamoDBEntryConversion conversion, bool isEmptyStringValueEnabled, out ITable table)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryLoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                return TryLoadTable(ddbClient, tableName, conversion, isEmptyStringValueEnabled, MetadataCachingMode.Default, out table);
            }

        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="conversion">Conversion to use for converting .NET values to DynamoDB values.</param>
        /// <param name="isEmptyStringValueEnabled">If the property is false, empty string values will be interpreted as null values.</param>
        /// <param name="metadataCachingMode">The document API relies on an internal cache of the DynamoDB table's metadata to construct and validate 
        /// requests. This controls how the cache key is derived, which influences when the SDK will call 
        /// IAmazonDynamoDB.DescribeTable(string) internally to populate the cache.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient,
                                        string tableName,
                                        DynamoDBEntryConversion conversion,
                                        bool isEmptyStringValueEnabled,
                                        MetadataCachingMode? metadataCachingMode,
                                        out ITable table)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryLoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                var config = new TableConfig(tableName,
                                         conversion,
                                         DynamoDBConsumer.DocumentModel,
                                         storeAsEpoch: null,
                                         storeAsEpochLong: null,
                                         isEmptyStringValueEnabled: isEmptyStringValueEnabled,
                                         metadataCachingMode: metadataCachingMode);

                return TryLoadTable(ddbClient, config, out table);
            }
        }

        /// <summary>
        /// Creates a Table object with the specified configuration, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="config">Configuration to use for the table.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        [Obsolete("Use the TableBuilder to construct a Table with the recommended configuration.")]
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient, TableConfig config, out ITable table)
        {
            var operationName = DynamoDBTelemetry.ExtractOperationName(nameof(Table), nameof(TryLoadTable));
            var tracerProvider = ddbClient.Config.TelemetryProvider.TracerProvider;
            using (DynamoDBTelemetry.CreateSpan(tracerProvider, operationName, spanKind: SpanKind.CLIENT))
            {
                if (config == null)
                    throw new ArgumentNullException(nameof(config));

#pragma warning disable CA1031 // Do not catch general exception types
                try
                {
                    table = LoadTable(ddbClient, config);
                    return true;
                }
                catch
                {
                    table = null;
                    return false;
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }
        }
        #endregion

        #region Conversion methods

        /// <inheritdoc/>
        public Document FromAttributeMap(Dictionary<string, AttributeValue> data)
        {
            return Document.FromAttributeMap(data, this.StoreAsEpoch, this.StoreAsEpochLong);
        }

        /// <inheritdoc/>
        public Dictionary<string, AttributeValue> ToAttributeMap(Document doc)
        {
            return doc.ToAttributeMap(this.Conversion, this.StoreAsEpoch, this.StoreAsEpochLong, this.IsEmptyStringValueEnabled);
        }

        /// <inheritdoc/>
        public Dictionary<string, ExpectedAttributeValue> ToExpectedAttributeMap(Document doc)
        {
            return doc.ToExpectedAttributeMap(this.Conversion, this.StoreAsEpoch, this.StoreAsEpochLong, this.IsEmptyStringValueEnabled);
        }

        /// <inheritdoc/>
        public Dictionary<string, AttributeValueUpdate> ToAttributeUpdateMap(Document doc, bool changedAttributesOnly)
        {
            return doc.ToAttributeUpdateMap(this.Conversion, changedAttributesOnly, this.StoreAsEpoch, this.StoreAsEpochLong, this.IsEmptyStringValueEnabled);
        }


        #endregion

        #region PutItem

        internal Document PutItemHelper(Document doc, PutItemOperationConfig config)
        {
            var currentConfig = config ?? new PutItemOperationConfig();

            PutItemRequest req = new PutItemRequest
            {
                TableName = TableName,
                Item = this.ToAttributeMap(doc)
            };
            this.UpdateRequestUserAgentDetails(req, isAsync: false);

            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
                req.ReturnValues = EnumMapper.Convert(currentConfig.ReturnValues);

            ValidateConditional(currentConfig);


            if (currentConfig.Expected != null)
            {
                req.Expected = this.ToExpectedAttributeMap(currentConfig.Expected);
            }
            else if (currentConfig.ExpectedState != null &&
                currentConfig.ExpectedState.ExpectedValues != null &&
                currentConfig.ExpectedState.ExpectedValues.Count > 0)
            {
                req.Expected = currentConfig.ExpectedState.ToExpectedAttributeMap(this);
                if (req.Expected.Count > 1)
                    req.ConditionalOperator = EnumMapper.Convert(currentConfig.ExpectedState.ConditionalOperator);
            }
            else if (currentConfig.ConditionalExpression != null && currentConfig.ConditionalExpression.IsSet)
            {
                currentConfig.ConditionalExpression.ApplyExpression(req, this);
            }

#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous PutItem from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via PutItemAsync instead.");
            }
#else
            var client = DDBClient;
#endif

            var resp = client.PutItem(req);
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = this.FromAttributeMap(resp.Attributes);
            }
            return ret;
        }

        internal async Task<Document> PutItemHelperAsync(Document doc, PutItemOperationConfig config, CancellationToken cancellationToken)
        {
            var currentConfig = config ?? new PutItemOperationConfig();

            PutItemRequest req = new PutItemRequest
            {
                TableName = TableName,
                Item = this.ToAttributeMap(doc)
            };
            this.UpdateRequestUserAgentDetails(req, isAsync: true);

            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
                req.ReturnValues = EnumMapper.Convert(currentConfig.ReturnValues);

            ValidateConditional(currentConfig);


            if (currentConfig.Expected != null)
            {
                req.Expected = this.ToExpectedAttributeMap(currentConfig.Expected);
            }
            else if (currentConfig.ExpectedState != null &&
                currentConfig.ExpectedState.ExpectedValues != null &&
                currentConfig.ExpectedState.ExpectedValues.Count > 0)
            {
                req.Expected = currentConfig.ExpectedState.ToExpectedAttributeMap(this);
                if (req.Expected.Count > 1)
                    req.ConditionalOperator = EnumMapper.Convert(currentConfig.ExpectedState.ConditionalOperator);
            }
            else if (currentConfig.ConditionalExpression != null && currentConfig.ConditionalExpression.IsSet)
            {
                currentConfig.ConditionalExpression.ApplyExpression(req, this);
            }

            var resp = await DDBClient.PutItemAsync(req, cancellationToken).ConfigureAwait(false);
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = this.FromAttributeMap(resp.Attributes);
            }
            return ret;
        }

        #endregion


        #region GetItem

        internal Document GetItemHelper(Key key, GetItemOperationConfig config)
        {
            var currentConfig = config ?? new GetItemOperationConfig();
            var request = new GetItemRequest
            {
                TableName = TableName,
                Key = key,
                ConsistentRead = currentConfig.ConsistentRead
            };

            this.UpdateRequestUserAgentDetails(request, isAsync: false);

#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous GetItem from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via GetItemAsync instead.");
            }
#else
            var client = DDBClient;
#endif

            if (currentConfig.AttributesToGet != null)
                request.AttributesToGet = currentConfig.AttributesToGet;

            var result = client.GetItem(request);
            var attributeMap = result.Item;
            if (attributeMap == null || attributeMap.Count == 0)
                return null;
            return this.FromAttributeMap(attributeMap);
        }

        internal async Task<Document> GetItemHelperAsync(Key key, GetItemOperationConfig config, CancellationToken cancellationToken)
        {
            var currentConfig = config ?? new GetItemOperationConfig();
            var request = new GetItemRequest
            {
                TableName = TableName,
                Key = key,
                ConsistentRead = currentConfig.ConsistentRead
            };

            this.UpdateRequestUserAgentDetails(request, isAsync: true);

            if (currentConfig.AttributesToGet != null)
                request.AttributesToGet = currentConfig.AttributesToGet;

            var result = await DDBClient.GetItemAsync(request, cancellationToken).ConfigureAwait(false);
            var attributeMap = result.Item;
            if (attributeMap == null || attributeMap.Count == 0)
                return null;
            return this.FromAttributeMap(attributeMap);
        }

        #endregion


        #region UpdateItem

        internal Document UpdateHelper(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config)
        {
            Key key = (hashKey != null || rangeKey != null) ? MakeKey(hashKey, rangeKey) : MakeKey(doc);
            return UpdateHelper(doc, key, config,null);
        }

        internal Task<Document> UpdateHelperAsync(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config, Expression expression, CancellationToken cancellationToken)
        {
            Key key = (hashKey != null || rangeKey != null) ? MakeKey(hashKey, rangeKey) : MakeKey(doc);
            return UpdateHelperAsync(doc, key, config, expression, cancellationToken);
        }

        internal Document UpdateHelper(Document doc, Key key, UpdateItemOperationConfig config, Expression updateExpression)
        {
            var currentConfig = config ?? new UpdateItemOperationConfig();

            // If the keys have been changed, treat entire document as having changed
            bool haveKeysChanged = HaveKeysChanged(doc);
            bool updateChangedAttributesOnly = !haveKeysChanged;

            var attributeUpdates = this.ToAttributeUpdateMap(doc, updateChangedAttributesOnly);
            foreach (var keyName in this.KeyNames)
            {
                attributeUpdates.Remove(keyName);
            }

            UpdateItemRequest req = new UpdateItemRequest
            {
                TableName = TableName,
                Key = key,
                AttributeUpdates = attributeUpdates.Count == 0 ? null : attributeUpdates, // pass null if keys-only update
                ReturnValues = EnumMapper.Convert(currentConfig.ReturnValues)
            };

            this.UpdateRequestUserAgentDetails(req, isAsync: false);

            ValidateConditional(currentConfig, updateExpression);

            if (currentConfig.Expected != null)
            {
                req.Expected = this.ToExpectedAttributeMap(currentConfig.Expected);
            }
            else if (currentConfig.ExpectedState != null &&
                currentConfig.ExpectedState.ExpectedValues != null &&
                currentConfig.ExpectedState.ExpectedValues.Count > 0)
            {
                req.Expected = currentConfig.ExpectedState.ToExpectedAttributeMap(this);
                if (req.Expected.Count > 1)
                    req.ConditionalOperator = EnumMapper.Convert(currentConfig.ExpectedState.ConditionalOperator);
            }
            else if (currentConfig.ConditionalExpression is { IsSet: true } || updateExpression is { IsSet: true })
            {
                currentConfig.ConditionalExpression.ApplyExpression(req, this);

                string statement;
                Dictionary<string, AttributeValue> expressionAttributeValues;
                Dictionary<string, string> expressionAttributeNames;

                Common.ConvertAttributeUpdatesToUpdateExpression(attributeUpdates, updateExpression, this, out statement, out expressionAttributeValues, out expressionAttributeNames);

                req.AttributeUpdates = null;
                req.UpdateExpression = statement;

                if (req.ExpressionAttributeValues == null)
                    req.ExpressionAttributeValues = expressionAttributeValues;
                else
                {
                    foreach (var kvp in expressionAttributeValues)
                        req.ExpressionAttributeValues.Add(kvp.Key, kvp.Value);
                }

                if (req.ExpressionAttributeNames == null)
                    req.ExpressionAttributeNames = expressionAttributeNames;
                else
                {
                    foreach (var kvp in expressionAttributeNames)
                        req.ExpressionAttributeNames.Add(kvp.Key, kvp.Value);
                }
            }
#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous UpdateItem from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when creating a Table via UpdateItemAsync instead.");
            }
#else
            var client = DDBClient;
#endif

            var resp = client.UpdateItem(req);
            var returnedAttributes = resp.Attributes;
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues != ReturnValues.None)
            {
                ret = this.FromAttributeMap(returnedAttributes);
            }
            return ret;
        }

        internal async Task<Document> UpdateHelperAsync(Document doc, Key key, UpdateItemOperationConfig config, Expression updateExpression, CancellationToken cancellationToken)
        {
            var currentConfig = config ?? new UpdateItemOperationConfig();

            // If the keys have been changed, treat entire document as having changed
            bool haveKeysChanged = HaveKeysChanged(doc);
            bool updateChangedAttributesOnly = !haveKeysChanged;

            var attributeUpdates = this.ToAttributeUpdateMap(doc, updateChangedAttributesOnly);
            foreach (var keyName in this.KeyNames)
            {
                attributeUpdates.Remove(keyName);
            }

            UpdateItemRequest req = new UpdateItemRequest
            {
                TableName = TableName,
                Key = key,
                AttributeUpdates = attributeUpdates.Count == 0 ? null : attributeUpdates, // pass null if keys-only update
                ReturnValues = EnumMapper.Convert(currentConfig.ReturnValues)
            };

            this.UpdateRequestUserAgentDetails(req, isAsync: true);

            ValidateConditional(currentConfig, updateExpression);

            if (currentConfig.Expected != null)
            {
                req.Expected = this.ToExpectedAttributeMap(currentConfig.Expected);
            }
            else if (currentConfig.ExpectedState != null &&
                currentConfig.ExpectedState.ExpectedValues != null &&
                currentConfig.ExpectedState.ExpectedValues.Count > 0)
            {
                req.Expected = currentConfig.ExpectedState.ToExpectedAttributeMap(this);
                if (req.Expected.Count > 1)
                    req.ConditionalOperator = EnumMapper.Convert(currentConfig.ExpectedState.ConditionalOperator);
            }
            else if (currentConfig.ConditionalExpression is { IsSet: true } || updateExpression is { IsSet: true })
            {
                currentConfig.ConditionalExpression?.ApplyExpression(req, this);

                string statement;
                Dictionary<string, AttributeValue> expressionAttributeValues;
                Dictionary<string, string> expressionAttributeNames;

                Common.ConvertAttributeUpdatesToUpdateExpression(attributeUpdates, updateExpression,this, out statement, out expressionAttributeValues, out expressionAttributeNames);

                req.AttributeUpdates = null;
                req.UpdateExpression = statement;

                if (req.ExpressionAttributeValues == null)
                    req.ExpressionAttributeValues = expressionAttributeValues;
                else
                {
                    foreach (var kvp in expressionAttributeValues)
                        req.ExpressionAttributeValues.Add(kvp.Key, kvp.Value);
                }

                if (req.ExpressionAttributeNames == null)
                    req.ExpressionAttributeNames = expressionAttributeNames;
                else
                {
                    foreach (var kvp in expressionAttributeNames)
                        req.ExpressionAttributeNames.Add(kvp.Key, kvp.Value);
                }
            }

            var resp = await DDBClient.UpdateItemAsync(req, cancellationToken).ConfigureAwait(false);
            var returnedAttributes = resp.Attributes;
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues != ReturnValues.None)
            {
                ret = this.FromAttributeMap(returnedAttributes);
            }
            return ret;
        }

        // Checks if key attributes have been updated
        internal bool HaveKeysChanged(Document doc)
        {
            foreach (var keyName in this.KeyNames)
            {
                if (doc.IsAttributeChanged(keyName))
                    return true;
            }
            return false;
        }

        #endregion


        #region DeleteItem

        internal Document DeleteHelper(Key key, DeleteItemOperationConfig config)
        {
            var currentConfig = config ?? new DeleteItemOperationConfig();

            var req = new DeleteItemRequest
            {
                TableName = TableName,
                Key = key
            };
            this.UpdateRequestUserAgentDetails(req, isAsync: false);

            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
                req.ReturnValues = EnumMapper.Convert(currentConfig.ReturnValues);

            ValidateConditional(currentConfig);

            if (currentConfig.Expected != null)
            {
                req.Expected = this.ToExpectedAttributeMap(currentConfig.Expected);
            }
            else if (currentConfig.ExpectedState != null &&
                currentConfig.ExpectedState.ExpectedValues != null &&
                currentConfig.ExpectedState.ExpectedValues.Count > 0)
            {
                req.Expected = currentConfig.ExpectedState.ToExpectedAttributeMap(this);
                if (req.Expected.Count > 1)
                    req.ConditionalOperator = EnumMapper.Convert(currentConfig.ExpectedState.ConditionalOperator);
            }
            else if (currentConfig.ConditionalExpression != null && currentConfig.ConditionalExpression.IsSet)
            {
                currentConfig.ConditionalExpression.ApplyExpression(req, this);
            }

#if NETSTANDARD
            // Cast the IAmazonDynamoDB to the concrete client instead, so we can access the internal sync-over-async methods
            var client = DDBClient as AmazonDynamoDBClient;
            if (client == null)
            {
                throw new InvalidOperationException("Calling the synchronous DeleteItem from .NET or .NET Core requires initializing the Table " +
                   "with an actual AmazonDynamoDBClient. You can use a mocked or substitute IAmazonDynamoDB when calling DeleteItemAsync instead.");
            }
#else
            var client = DDBClient;
#endif

            var attributes = client.DeleteItem(req).Attributes;

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = this.FromAttributeMap(attributes);
            }
            return ret;
        }

        internal async Task<Document> DeleteHelperAsync(Key key, DeleteItemOperationConfig config, CancellationToken cancellationToken)
        {
            var currentConfig = config ?? new DeleteItemOperationConfig();

            var req = new DeleteItemRequest
            {
                TableName = TableName,
                Key = key
            };
            this.UpdateRequestUserAgentDetails(req, isAsync: true);

            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
                req.ReturnValues = EnumMapper.Convert(currentConfig.ReturnValues);

            ValidateConditional(currentConfig);

            if (currentConfig.Expected != null)
            {
                req.Expected = this.ToExpectedAttributeMap(currentConfig.Expected);
            }
            else if (currentConfig.ExpectedState != null &&
                currentConfig.ExpectedState.ExpectedValues != null &&
                currentConfig.ExpectedState.ExpectedValues.Count > 0)
            {
                req.Expected = currentConfig.ExpectedState.ToExpectedAttributeMap(this);
                if (req.Expected.Count > 1)
                    req.ConditionalOperator = EnumMapper.Convert(currentConfig.ExpectedState.ConditionalOperator);
            }
            else if (currentConfig.ConditionalExpression != null && currentConfig.ConditionalExpression.IsSet)
            {
                currentConfig.ConditionalExpression.ApplyExpression(req, this);
            }

            var attributes = (await DDBClient.DeleteItemAsync(req, cancellationToken).ConfigureAwait(false)).Attributes;

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = this.FromAttributeMap(attributes);
            }
            return ret;
        }

        #endregion


        #region Scan

        /// <inheritdoc/>
        public ISearch Scan(ScanFilter filter)
        {
            return Scan(new ScanOperationConfig { Filter = filter });
        }

        /// <inheritdoc/>
        public ISearch Scan(Expression filterExpression)
        {
            ScanOperationConfig config = new ScanOperationConfig
            {
                FilterExpression = filterExpression
            };

            return Scan(config);
        }


        /// <inheritdoc/>
        public ISearch Scan(ScanOperationConfig config)
        {
            var currentConfig = config ?? new ScanOperationConfig();

            Search ret = new Search(SearchType.Scan)
            {
                SourceTable = this,
                TableName = TableName,
                Limit = currentConfig.Limit,
                Filter = currentConfig.Filter,
                FilterExpression = currentConfig.FilterExpression,
                ConditionalOperator = currentConfig.ConditionalOperator,
                AttributesToGet = currentConfig.AttributesToGet,
                Select = currentConfig.Select,
                CollectResults = currentConfig.CollectResults,
                IndexName = currentConfig.IndexName,
                IsConsistentRead = currentConfig.ConsistentRead,
                PaginationToken = currentConfig.PaginationToken
            };

            if (currentConfig.TotalSegments != 0)
            {
                ret.TotalSegments = currentConfig.TotalSegments;
                ret.Segment = currentConfig.Segment;
            }

            return ret;
        }

        #endregion


        #region Query

        /// <inheritdoc/>
        public ISearch Query(Primitive hashKey, QueryFilter filter)
        {
            string hashKeyName = this.HashKeys[0];
            QueryFilter fullFilter = new QueryFilter(filter);
            fullFilter.AddCondition(hashKeyName, QueryOperator.Equal, hashKey);

            return Query(fullFilter);
        }


        /// <inheritdoc/>
        public ISearch Query(Primitive hashKey, Expression filterExpression)
        {
            string hashKeyName = this.HashKeys[0];

            QueryFilter hashKeyFilter = new QueryFilter();
            hashKeyFilter.AddCondition(hashKeyName, QueryOperator.Equal, hashKey);

            QueryOperationConfig config = new QueryOperationConfig
            {
                Filter = hashKeyFilter,
                FilterExpression = filterExpression
            };

            return Query(config);
        }

        /// <inheritdoc/>
        public ISearch Query(QueryFilter filter)
        {
            return Query(new QueryOperationConfig { Filter = filter });
        }

        /// <inheritdoc/>
        public ISearch Query(QueryOperationConfig config)
        {
            if (config == null)
                throw new ArgumentNullException("config");

            Search ret = new Search(SearchType.Query)
            {
                SourceTable = this,
                TableName = TableName,
                AttributesToGet = config.AttributesToGet,
                Filter = config.Filter,
                KeyExpression = config.KeyExpression,
                FilterExpression = config.FilterExpression,
                ConditionalOperator = config.ConditionalOperator,
                Limit = config.Limit,
                IsConsistentRead = config.ConsistentRead,
                IsBackwardSearch = config.BackwardSearch,
                IndexName = config.IndexName,
                Select = config.Select,
                CollectResults = config.CollectResults,
                PaginationToken = config.PaginationToken
            };

            return ret;
        }

        #endregion


        #region BatchGet

        /// <inheritdoc/>
        public IDocumentBatchGet CreateBatchGet()
        {
            return new DocumentBatchGet(this);
        }

        #endregion


        #region BatchWrite

        /// <inheritdoc/>
        public IDocumentBatchWrite CreateBatchWrite()
        {
            return new DocumentBatchWrite(this);
        }

        #endregion


        #region TransactGet

        /// <inheritdoc/>
        public IDocumentTransactGet CreateTransactGet()
        {
            return new DocumentTransactGet(this);
        }

        #endregion


        #region TransactWrite

        /// <inheritdoc/>
        public IDocumentTransactWrite CreateTransactWrite()
        {
            return new DocumentTransactWrite(this);
        }

        #endregion
    }
}
