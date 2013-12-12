/*
 * Copyright 2012-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace Amazon.DynamoDBv2.DocumentModel
{
    public partial class Table
    {
        #region Private/internal members

        internal enum DynamoDBConsumer
        {
            DocumentModel, DataModel, SessionStateProvider
        }

        private string[] keyNames;
        internal Table.DynamoDBConsumer TableConsumer { get; private set; }

#if (WIN_RT || WINDOWS_PHONE)
        internal AmazonDynamoDBClient DDBClient { get; private set; }
#else
        internal IAmazonDynamoDB DDBClient { get; private set; }
#endif

        #endregion

        #region Public properties

        /// <summary>
        /// Name of the table.
        /// </summary>
        public string TableName { get; private set; }

        /// <summary>
        /// Keys of the table.
        /// </summary>
        public Dictionary<string, KeyDescription> Keys { get; private set; }

        /// <summary>
        /// Global secondary indexes of the table.
        /// </summary>
        public Dictionary<string, GlobalSecondaryIndexDescription> GlobalSecondaryIndexes { get; private set; }

        /// <summary>
        /// Local secondary indexes of the table.
        /// </summary>
        public Dictionary<string, LocalSecondaryIndexDescription> LocalSecondaryIndexes { get; private set; }

        /// <summary>
        /// Names of the local secondary indexes of the table.
        /// </summary>
        public List<string> LocalSecondaryIndexNames { get; private set; }

        /// <summary>
        /// Names of the global secondary indexes of the table.
        /// </summary>
        public List<string> GlobalSecondaryIndexNames { get; private set; }

        /// <summary>
        /// List of keys on the table marked HASH
        /// </summary>
        public List<string> HashKeys { get; private set; }

        /// <summary>
        /// List of keys on the table marked RANGE
        /// </summary>
        public List<string> RangeKeys { get; private set; }

        /// <summary>
        /// List of key attributes on the table.
        /// </summary>
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

        private void GetTableInfo()
        {
            DescribeTableRequest req = new DescribeTableRequest
            {
                TableName = TableName
            };
            req.BeforeRequestEvent += new RequestEventHandler(this.UserAgentRequestEventHandlerSync);
            DescribeTableResult info = this.DDBClient.DescribeTable(req);

            if (info.Table == null)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Table name {0} does not exist", TableName));
            }

            Keys.Clear();
            HashKeys.Clear();
            RangeKeys.Clear();
            TableDescription table = info.Table;
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

            LocalSecondaryIndexes.Clear();
            LocalSecondaryIndexNames.Clear();
            if (table.LocalSecondaryIndexes != null)
            {
                foreach (var index in table.LocalSecondaryIndexes)
                {
                    LocalSecondaryIndexes[index.IndexName] = index;
                    LocalSecondaryIndexNames.Add(index.IndexName);
                }
            }

            GlobalSecondaryIndexes.Clear();
            GlobalSecondaryIndexNames.Clear();
            if (table.GlobalSecondaryIndexes != null)
            {
                foreach (var index in table.GlobalSecondaryIndexes)
                {
                    GlobalSecondaryIndexes[index.IndexName] = index;
                    GlobalSecondaryIndexNames.Add(index.IndexName);
                }
            }

            Attributes.Clear();
            foreach (var attribute in table.AttributeDefinitions)
            {
                Attributes.Add(attribute);
            }

            keyNames = Keys.Keys.ToArray();
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
                Primitive primitive = value.AsPrimitive();
                if (primitive == null)
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Key attribute {0} must be a Primitive type", keyName));
                if (primitive.Type != description.Type)
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Key attribute {0} must be of type {1}", keyName, description.Type));

                key[keyName] = primitive.ConvertToAttributeValue();
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
            if (hashKeyDescription.Type != hashKey.Type)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, 
                    "Schema for table {0}, hash key {1}, is inconsistent with specified hash key value.", TableName, hashKeyName));

            var hashKeyValue = hashKey.ConvertToAttributeValue();
            newKey[hashKeyName] = hashKeyValue;

            if ((rangeKey == null) != (RangeKeys.Count == 0))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, 
                    "Schema for table {0}, range key {1}, is inconsistent with specified range key value.", TableName, hashKeyName));
            }
            else if (rangeKey != null)
            {
                string rangeKeyName = RangeKeys[0];
                KeyDescription rangeKeyDescription = Keys[rangeKeyName];
                if (rangeKeyDescription.Type != rangeKey.Type)
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, 
                        "Schema for table {0}, range key {1}, is inconsistent with specified range key value.", TableName, hashKeyName));
                var rangeKeyValue = rangeKey.ConvertToAttributeValue();
                newKey[rangeKeyName] = rangeKeyValue;
            }

            return newKey;
        }

        internal void UserAgentRequestEventHandlerSync(object sender, RequestEventArgs args)
        {
            UserAgentRequestEventHandler(sender, args, false);
        }
        internal void UserAgentRequestEventHandlerAsync(object sender, RequestEventArgs args)
        {
            UserAgentRequestEventHandler(sender, args, true);
        }

        private void UserAgentRequestEventHandler(object sender, RequestEventArgs args, bool isAsync)
        {
            WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                string currentUserAgent = wsArgs.Headers[AWSSDKUtils.UserAgentHeader];
                wsArgs.Headers[AWSSDKUtils.UserAgentHeader] =
                    currentUserAgent + " " + this.TableConsumer.ToString() + " " + (isAsync ? "TableAsync" : "TableSync");
            }
        }

        internal Table Copy()
        {
            return this.Copy(this.TableConsumer);
        }
        
        internal Table Copy(Table.DynamoDBConsumer newConsumer)
        {
            return new Table(this.DDBClient, this.TableName, newConsumer)
            {
                keyNames = this.keyNames,
                Keys = this.Keys,
                RangeKeys = this.RangeKeys,
                HashKeys = this.HashKeys,
            };
        }

        #endregion


        #region Constructor/factory

        private Table(IAmazonDynamoDB ddbClient, string tableName, Table.DynamoDBConsumer consumer)
        {
#if (WIN_RT || WINDOWS_PHONE)
            DDBClient = ddbClient as AmazonDynamoDBClient;
#else
            DDBClient = ddbClient;
#endif

            TableConsumer = consumer;
            TableName = tableName;
            Keys = new Dictionary<string, KeyDescription>();
            HashKeys = new List<string>();
            RangeKeys = new List<string>();
            LocalSecondaryIndexes = new Dictionary<string, LocalSecondaryIndexDescription>();
            LocalSecondaryIndexNames = new List<string>();
            GlobalSecondaryIndexes = new Dictionary<string, GlobalSecondaryIndexDescription>();
            GlobalSecondaryIndexNames = new List<string>();
            Attributes = new List<AttributeDefinition>();
        }

        internal static Table LoadTable(IAmazonDynamoDB ddbClient, string tableName, Table.DynamoDBConsumer consumer)
        {
            Table table = new Table(ddbClient, tableName, consumer);
            table.GetTableInfo();
            return table;
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will throw an exception if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <returns>Table object representing the specified table.</returns>
        public static Table LoadTable(IAmazonDynamoDB ddbClient, string tableName)
        {
            return LoadTable(ddbClient, tableName, DynamoDBConsumer.DocumentModel);
        }

        /// <summary>
        /// Creates a Table object with the specified name, using the
        /// passed-in client to load the table definition.
        /// 
        /// This method will return false if the table does not exist.
        /// </summary>
        /// <param name="ddbClient">Client to use to access DynamoDB.</param>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="table">Loaded table.</param>
        /// <returns>
        /// True if table was successfully loaded; otherwise false.
        /// </returns>
        public static bool TryLoadTable(IAmazonDynamoDB ddbClient, string tableName, out Table table)
        {
            try
            {
                table = LoadTable(ddbClient, tableName);
                return true;
            }
            catch
            {
                table = null;
                return false;
            }
        }

        #endregion


        #region PutItem

        internal Document PutItemHelper(Document doc, PutItemOperationConfig config, bool isAsync)
        {
            var currentConfig = config ?? new PutItemOperationConfig();

            PutItemRequest req = new PutItemRequest
            {
                TableName = TableName,
                Item = doc.ToAttributeMap()
            };
            req.BeforeRequestEvent += isAsync ?
                new RequestEventHandler(UserAgentRequestEventHandlerAsync) :
                new RequestEventHandler(UserAgentRequestEventHandlerSync);
            if (currentConfig.Expected != null)
                req.Expected = currentConfig.Expected.ToExpectedAttributeMap();
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                req.ReturnValues = EnumToStringMapper.Convert(currentConfig.ReturnValues);
            }

            var resp = DDBClient.PutItem(req);
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = Document.FromAttributeMap(resp.Attributes);
            }
            return ret;
        }

        #endregion


        #region GetItem

        internal Document GetItemHelper(Key key, GetItemOperationConfig config, bool isAsync)
        {
            var currentConfig = config ?? new GetItemOperationConfig();
            var request = new GetItemRequest
            {
                TableName = TableName,
                Key = key,
                ConsistentRead = currentConfig.ConsistentRead
            };
            request.BeforeRequestEvent += isAsync ?
                new RequestEventHandler(UserAgentRequestEventHandlerAsync) :
                new RequestEventHandler(UserAgentRequestEventHandlerSync);
            if (currentConfig.AttributesToGet != null)
                request.AttributesToGet = currentConfig.AttributesToGet;

            var result = DDBClient.GetItem(request);
            var attributeMap = result.Item;
            if (attributeMap == null || attributeMap.Count == 0)
                return null;
            return Document.FromAttributeMap(attributeMap);
        }

        #endregion


        #region UpdateItem

        internal Document UpdateHelper(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config, bool isAsync)
        {
            Key key = (hashKey != null || rangeKey != null) ? MakeKey(hashKey, rangeKey) : MakeKey(doc);
            return UpdateHelper(doc, key, config, isAsync);
        }
        internal Document UpdateHelper(Document doc, Key key, UpdateItemOperationConfig config, bool isAsync)
        {
            var currentConfig = config ?? new UpdateItemOperationConfig();

            // If the keys have been changed, treat entire document as having changed
            bool haveKeysChanged = HaveKeysChanged(doc);
            bool updateChangedAttributesOnly = !haveKeysChanged;

            var attributeUpdates = doc.ToAttributeUpdateMap(updateChangedAttributesOnly);
            foreach (var keyName in this.keyNames)
            {
                attributeUpdates.Remove(keyName);
            }

            UpdateItemRequest req = new UpdateItemRequest
            {
                TableName = TableName,
                Key = key,
                AttributeUpdates = attributeUpdates.Count == 0 ? null : attributeUpdates, // pass null if keys-only update
                ReturnValues = EnumToStringMapper.Convert(currentConfig.ReturnValues)
            };
            req.BeforeRequestEvent += isAsync ?
                new RequestEventHandler(UserAgentRequestEventHandlerAsync) :
                new RequestEventHandler(UserAgentRequestEventHandlerSync);
            if (currentConfig.Expected != null)
                req.Expected = currentConfig.Expected.ToExpectedAttributeMap();

            var resp = DDBClient.UpdateItem(req);
            var returnedAttributes = resp.Attributes;
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues != ReturnValues.None)
            {
                ret = Document.FromAttributeMap(returnedAttributes);
            }
            return ret;
        }

        // Checks if key attributes have been updated
        private bool HaveKeysChanged(Document doc)
        {
            foreach (var keyName in this.keyNames)
            {
                if (doc.IsAttributeChanged(keyName))
                    return true;
            }
            return false;
        }

        #endregion


        #region DeleteItem

        internal Document DeleteHelper(Key key, DeleteItemOperationConfig config, bool isAsync)
        {
            var currentConfig = config ?? new DeleteItemOperationConfig();

            var req = new DeleteItemRequest
            {
                TableName = TableName,
                Key = key
            };
            req.BeforeRequestEvent += isAsync ?
                new RequestEventHandler(UserAgentRequestEventHandlerAsync) :
                new RequestEventHandler(UserAgentRequestEventHandlerSync);
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                req.ReturnValues = EnumToStringMapper.Convert(currentConfig.ReturnValues);
            }
            if (currentConfig.Expected != null)
            {
                req.Expected = currentConfig.Expected.ToExpectedAttributeMap();
            }

            var attributes = DDBClient.DeleteItem(req).Attributes;

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = Document.FromAttributeMap(attributes);
            }
            return ret;
        }

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
        public Search Scan(ScanFilter filter)
        {
            return Scan(new ScanOperationConfig { Filter = filter });
        }

        /// <summary>
        /// Initiates a Search object to Scan a DynamoDB table, with the
        /// specified config.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Resultant Search container.</returns>
        public Search Scan(ScanOperationConfig config)
        {
            var currentConfig = config ?? new ScanOperationConfig();

            Search ret = new Search(SearchType.Scan)
            {
                SourceTable = this,
                TableName = TableName,
                Limit = currentConfig.Limit,
                Filter = currentConfig.Filter,
                AttributesToGet = currentConfig.AttributesToGet,
                Select = currentConfig.Select,
                CollectResults = currentConfig.CollectResults
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

        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified hash primary key and filter.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="hashKey">Value of the hash key for the query operation.</param>
        /// <param name="filter">Filter to use.</param>
        /// <returns>Resultant Search container.</returns>
        public Search Query(Primitive hashKey, QueryFilter filter)
        {
            string hashKeyName = this.HashKeys[0];
            QueryFilter fullFilter = new QueryFilter(filter);
            fullFilter.AddCondition(hashKeyName, QueryOperator.Equal, hashKey);

            return Query(fullFilter);
        }

        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified filter.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="filter">Filter to use.</param>
        /// <returns>Resultant Search container.</returns>
        public Search Query(QueryFilter filter)
        {
            return Query(new QueryOperationConfig { Filter = filter });
        }

        /// <summary>
        /// Initiates a Search object to Query a DynamoDB table, with the
        /// specified config.
        /// 
        /// No calls are made until the Search object is used.
        /// </summary>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Resultant Search container.</returns>
        public Search Query(QueryOperationConfig config)
        {
            if (config == null)
                throw new ArgumentNullException("config");

            Search ret = new Search(SearchType.Query)
            {
                SourceTable = this,
                TableName = TableName,
                AttributesToGet = config.AttributesToGet,
                Filter = config.Filter,
                Limit = config.Limit,
                IsConsistentRead = config.ConsistentRead,
                IsBackwardSearch = config.BackwardSearch,
                IndexName = config.IndexName,
                Select = config.Select,
                CollectResults = config.CollectResults
            };

            return ret;
        }

        #endregion


        #region BatchGet

        /// <summary>
        /// Creates a DocumentBatchGet object for the current table, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <returns>Empty DocumentBatchGet object.</returns>
        public DocumentBatchGet CreateBatchGet()
        {
            return new DocumentBatchGet(this);
        }

        #endregion


        #region BatchWrite

        /// <summary>
        /// Creates a DocumentBatchWrite object for the current table, allowing
        /// a batch-put/delete operation against DynamoDB.
        /// </summary>
        /// <returns>Empty DocumentBatchWrite object.</returns>
        public DocumentBatchWrite CreateBatchWrite()
        {
            return new DocumentBatchWrite(this);
        }

        #endregion
    }
}
