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

namespace Amazon.DynamoDBv2.DocumentModel
{
    public class Table
    {
        #region Private/internal members

        internal enum DynamoDBConsumer
        {
            DocumentModel, DataModel, SessionStateProvider
        }

        private string[] keyNames;
        internal AmazonDynamoDB DDBClient { get; private set; }
        internal Table.DynamoDBConsumer TableConsumer { get; private set; }

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
        /// Local secondary indexes of the table.
        /// </summary>
        public Dictionary<string, LocalSecondaryIndexDescription> LocalSecondaryIndexes { get; private set; }

        /// <summary>
        /// Names of the local secondary indexes of the table.
        /// </summary>
        public List<string> LocalSecondaryIndexNames { get; private set; }

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

        private DynamoDBEntryType GetType(string attributeType)
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
            DescribeTableResult info = this.DDBClient.DescribeTable(req).DescribeTableResult;

            if (info.Table == null)
            {
                throw new ArgumentException(String.Format("Table name {0} does not exist", TableName));
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
                    throw new InvalidOperationException(string.Format("Document does not contain value for key {0}", keyName));
                Primitive primitive = value.AsPrimitive();
                if (primitive == null)
                    throw new InvalidOperationException(string.Format("Key attribute {0} must be a Primitive type", keyName));
                if (primitive.Type != description.Type)
                    throw new InvalidOperationException(string.Format("Key attribute {0} must be of type {1}", keyName, description.Type));

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
                throw new InvalidOperationException(string.Format(
                    "Schema for table {0}, hash key {1}, is inconsistent with specified hash key value.", TableName, hashKeyName));

            var hashKeyValue = hashKey.ConvertToAttributeValue();
            newKey[hashKeyName] = hashKeyValue;

            if ((rangeKey == null) != (RangeKeys.Count == 0))
            {
                throw new InvalidOperationException(string.Format(
                    "Schema for table {0}, range key {1}, is inconsistent with specified range key value.", TableName, hashKeyName));
            }
            else if (rangeKey != null)
            {
                string rangeKeyName = RangeKeys[0];
                KeyDescription rangeKeyDescription = Keys[rangeKeyName];
                if (rangeKeyDescription.Type != rangeKey.Type)
                    throw new InvalidOperationException(string.Format(
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

        private Table(AmazonDynamoDB ddbClient, string tableName, Table.DynamoDBConsumer consumer)
        {
            DDBClient = ddbClient;
            TableConsumer = consumer;
            TableName = tableName;
            Keys = new Dictionary<string, KeyDescription>();
            HashKeys = new List<string>();
            RangeKeys = new List<string>();
            LocalSecondaryIndexes = new Dictionary<string, LocalSecondaryIndexDescription>();
            LocalSecondaryIndexNames = new List<string>();
            Attributes = new List<AttributeDefinition>();
        }

        internal static Table LoadTable(AmazonDynamoDB ddbClient, string tableName, Table.DynamoDBConsumer consumer)
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
        public static Table LoadTable(AmazonDynamoDB ddbClient, string tableName)
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
        public static bool TryLoadTable(AmazonDynamoDB ddbClient, string tableName, out Table table)
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

        /// <summary>
        /// Puts a document into DynamoDB.
        /// </summary>
        /// <param name="doc">Document to save.</param>
        public void PutItem(Document doc)
        {
            PutItem(doc, null);
        }

        /// <summary>
        /// Puts a document into DynamoDB, using specified configs.
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        public Document PutItem(Document doc, PutItemOperationConfig config)
        {
            return PutItemHelper(doc, config, false);
        }

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
                ret = Document.FromAttributeMap(resp.PutItemResult.Attributes);
            }
            return ret;
        }

        #endregion

        #region PutItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.PutItem"/>
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutItem
        ///         operation.</returns>
        public IAsyncResult BeginPutItem(Document doc, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => PutItemHelper(doc, null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.PutItem"/>
        /// </summary>
        /// <param name="doc">Document to save.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutItem
        ///         operation.</returns>
        public IAsyncResult BeginPutItem(Document doc, PutItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => PutItemHelper(doc, config, true), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.PutItem"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutItem.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        public Document EndPutItem(IAsyncResult asyncResult)
        {
            return DynamoDBAsyncExecutor.EndOperation(asyncResult) as Document;
        }

        #endregion


        #region GetItem

        /// <summary>
        /// Gets a document from DynamoDB by hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <returns>Document from DynamoDB</returns>
        public Document GetItem(Primitive hashKey)
        {
            return GetItemHelper(MakeKey(hashKey, null), null, false);
        }

        /// <summary>
        /// Gets a document from DynamoDB by hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document GetItem(Primitive hashKey, Primitive rangeKey)
        {
            return GetItemHelper(MakeKey(hashKey, rangeKey), null, false);
        }

        /// <summary>
        /// Gets a document from DynamoDB by hash primary key, using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document GetItem(Primitive hashKey, GetItemOperationConfig config)
        {
            return GetItemHelper(MakeKey(hashKey, null), config, false);
        }

        /// <summary>
        /// Gets a document from DynamoDB by hash-and-range primary key,
        /// using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document GetItem(Primitive hashKey, Primitive rangeKey, GetItemOperationConfig config)
        {
            return GetItemHelper(MakeKey(hashKey, rangeKey), config, false);
        }

        /// <summary>
        /// Gets a document from DynamoDB by key.
        /// </summary>
        /// <param name="key">Values that make up the key of the document.</param>
        /// <returns>Document from DynamoDB</returns>
        public Document GetItem(IDictionary<string, DynamoDBEntry> key)
        {
            return GetItemHelper(MakeKey(key), null, false);
        }

        /// <summary>
        /// Gets a document from DynamoDB by key, using specified configs.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document GetItem(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config)
        {
            return GetItemHelper(MakeKey(key), config, false);
        }

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
            var attributeMap = result.GetItemResult.Item;
            if (attributeMap == null)
                return null;
            return Document.FromAttributeMap(attributeMap);
        }

        #endregion

        #region GetItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(Primitive hashKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetItemHelper(MakeKey(hashKey, null), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(Primitive hashKey, Primitive rangeKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetItemHelper(MakeKey(hashKey, rangeKey), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(Primitive hashKey, GetItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetItemHelper(MakeKey(hashKey, null), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(Primitive hashKey, Primitive rangeKey, GetItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetItemHelper(MakeKey(hashKey, rangeKey), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(IDictionary<string, DynamoDBEntry> key, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetItemHelper(MakeKey(key), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="key">Ley of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(IDictionary<string, DynamoDBEntry> key, GetItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => GetItemHelper(MakeKey(key), config, true), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.GetItem"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetItem.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document EndGetItem(IAsyncResult asyncResult)
        {
            return DynamoDBAsyncExecutor.EndOperation(asyncResult) as Document;
        }

        #endregion


        #region UpdateItem

        /// <summary>
        /// Update a document in DynamoDB.
        /// </summary>
        /// <param name="doc">Document to update.</param>
        public void UpdateItem(Document doc)
        {
            UpdateHelper(doc, MakeKey(doc), null, false);
        }
        /// <summary>
        /// Update a document in DynamoDB, with key to identify the document.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        public void UpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key)
        {
            UpdateHelper(doc, MakeKey(key), null, false);
        }
        /// <summary>
        /// Update a document in DynamoDB, with hash primary key to identify the document.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        public void UpdateItem(Document doc, Primitive hashKey)
        {
            UpdateHelper(doc, MakeKey(hashKey, null), null, false);
        }
        /// <summary>
        /// Update a document in DynamoDB, with a hash-and-range primary key
        /// to identify the document.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        public void UpdateItem(Document doc, Primitive hashKey, Primitive rangeKey)
        {
            UpdateHelper(doc, MakeKey(hashKey, rangeKey), null, false);
        }


        /// <summary>
        /// Update a document in DynamoDB, using specified config.
        /// </summary>
        /// <param name="doc">Document to update.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(doc), config, false);
        }
        /// <summary>
        /// Update a document in DynamoDB, with a key to identify the
        /// document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(key), config, false);
        }
        /// <summary>
        /// Update a document in DynamoDB, with a hash primary key to identify the
        /// document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(hashKey, null), config, false);
        }
        /// <summary>
        /// Update a document in DynamoDB, with a hash-and-range primary key to identify
        /// the document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(hashKey, rangeKey), config, false);
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
            var returnedAttributes = resp.UpdateItemResult.Attributes;
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

        #region UpdateItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Document to update.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(doc), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, Primitive hashKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(hashKey, null), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(hashKey, rangeKey), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(key), null, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Document to update.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, UpdateItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(doc), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(hashKey, null), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(hashKey, rangeKey), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(Document doc, IDictionary<string, DynamoDBEntry> key, UpdateItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => UpdateHelper(doc, MakeKey(key), config, true), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.UpdateItem"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateItem.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        public Document EndUpdateItem(IAsyncResult asyncResult)
        {
            return DynamoDBAsyncExecutor.EndOperation(asyncResult) as Document;
        }

        #endregion


        #region DeleteItem

        /// <summary>
        /// Delete a document in DynamoDB.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        public void DeleteItem(Document document)
        {
            DeleteHelper(MakeKey(document), null, false);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        public void DeleteItem(Primitive hashKey)
        {
            DeleteHelper(MakeKey(hashKey, null), null, false);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        public void DeleteItem(Primitive hashKey, Primitive rangeKey)
        {
            DeleteHelper(MakeKey(hashKey, rangeKey), null, false);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a key.
        /// </summary>
        /// <param name="key">Hash key element of the document.</param>
        public void DeleteItem(IDictionary<string, DynamoDBEntry> key)
        {
            DeleteHelper(MakeKey(key), null, false);
        }

        /// <summary>
        /// Delete a document in DynamoDB, using specified configs.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        public Document DeleteItem(Document document, DeleteItemOperationConfig config)
        {
            return DeleteHelper(MakeKey(document), config, false);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a hash primary key,
        /// using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        public Document DeleteItem(Primitive hashKey, DeleteItemOperationConfig config)
        {
            return DeleteHelper(MakeKey(hashKey, null), config, false);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by hash-and-range primary key,
        /// using the specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        public Document DeleteItem(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config)
        {
            return DeleteHelper(MakeKey(hashKey, rangeKey), config, false);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a key, using specified configs.
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        public Document DeleteItem(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config)
        {
            return DeleteHelper(MakeKey(key), config, false);
        }

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

            var attributes = DDBClient.DeleteItem(req).DeleteItemResult.Attributes;

            Document ret = null;
            if (currentConfig.ReturnValues == ReturnValues.AllOldAttributes)
            {
                ret = Document.FromAttributeMap(attributes);
            }
            return ret;
        }

        #endregion

        #region DeleteItemAsync

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(Document document, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper(MakeKey(document), null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(Primitive hashKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper(MakeKey(hashKey, null), null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(Primitive hashKey, Primitive rangeKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper(MakeKey(hashKey, rangeKey), null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(IDictionary<string, DynamoDBEntry> key, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper(MakeKey(key), null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(Document document, DeleteItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => DeleteHelper(MakeKey(document), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(Primitive hashKey, DeleteItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => DeleteHelper(MakeKey(hashKey, null), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(Primitive hashKey, Primitive rangeKey, DeleteItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => DeleteHelper(MakeKey(hashKey, rangeKey), config, true), callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="key">Key of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(IDictionary<string, DynamoDBEntry> key, DeleteItemOperationConfig config, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => DeleteHelper(MakeKey(key), config, true), callback, state);
        }
        
        /// <summary>
        /// Finishes the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.DocumentModel.Table.DeleteItem"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteItem.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        public Document EndDeleteItem(IAsyncResult asyncResult)
        {
            return DynamoDBAsyncExecutor.EndOperation(asyncResult) as Document;
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
