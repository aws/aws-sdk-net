/*
 * Copyright 2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDB.Model;
using Amazon.Runtime;
using Amazon.Util;

namespace Amazon.DynamoDB.DocumentModel
{
    public class Table
    {
        #region Private/internal members

        internal enum DynamoDBConsumer
        {
            DocumentModel, DataModel
        }

        internal AmazonDynamoDB DDBClient;
        private string[] keyNames;
        internal Table.DynamoDBConsumer TableConsumer = Table.DynamoDBConsumer.DocumentModel;

        #endregion

        #region Private/internal methods

        private void GetKeyInfo()
        {
            DescribeTableRequest req = new DescribeTableRequest
            {
                TableName = TableName
            };
            req.BeforeRequestEvent += new RequestEventHandler(this.UserAgentRequestEventHandler);
            DescribeTableResult info = this.DDBClient.DescribeTable(req).DescribeTableResult;

            if (info.Table == null)
            {
                throw new ArgumentException(String.Format("Table name {0} does not exist", TableName));
            }

            HashKeyIsNumeric = String.Equals(info.Table.KeySchema.HashKeyElement.AttributeType, "N");
            HashKeyName = info.Table.KeySchema.HashKeyElement.AttributeName;

            if (info.Table.KeySchema.RangeKeyElement != null)
            {
                RangeKeyIsDefined = true;
                RangeKeyIsNumeric = String.Equals(info.Table.KeySchema.RangeKeyElement.AttributeType, "N");
                RangeKeyName = info.Table.KeySchema.RangeKeyElement.AttributeName;
                keyNames = new string[] { HashKeyName, RangeKeyName };
            }
            else
            {
                keyNames = new string[] { HashKeyName };
            }
        }

        internal Key MakeKey(Primitive hashKey, Primitive rangeKey)
        {
            Key newKey = new Key();

            newKey.HashKeyElement = hashKey.ConvertToAttributeValue();
            if (HashKeyIsNumeric != hashKey.SaveAsNumeric)
                throw new InvalidOperationException("Table schema hash key inconsistent with specified hash key value");

            if ((rangeKey == null) == RangeKeyIsDefined)
            {
                throw new ArgumentException("Range Key does not match schema");
            }
            else
            {
                if (RangeKeyIsDefined)
                {
                    newKey.RangeKeyElement = rangeKey.ConvertToAttributeValue();
                    if (RangeKeyIsNumeric != rangeKey.SaveAsNumeric)
                        throw new InvalidOperationException("Table schema range key inconsistent with specified range key value");
                }
            }

            return newKey;
        }

        internal Key MakeKey(Document doc)
        {
            DynamoDBEntry entry;
            Primitive hashKey;
            if (doc.TryGetValue(HashKeyName, out entry) && (entry is Primitive))
            {
                hashKey = (entry as Primitive);
            }
            else
            {
                throw new InvalidOperationException("Document does not contain valid hash key attribute");
            }

            Primitive rangeKey;
            if (!string.IsNullOrEmpty(RangeKeyName))
            {
                if (doc.TryGetValue(RangeKeyName, out entry) && (entry is Primitive))
                    rangeKey = (entry as Primitive);
                else
                    throw new InvalidOperationException("Document does not contain valid range key attribute");
            }
            else
            {
                rangeKey = null;
            }

            return MakeKey(hashKey, rangeKey);
        }

        internal void UserAgentRequestEventHandler(object sender, RequestEventArgs args)
        {
            WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
            if (wsArgs != null)
            {
                string currentUserAgent = wsArgs.Headers[AWSSDKUtils.UserAgentHeader];
                wsArgs.Headers[AWSSDKUtils.UserAgentHeader] = currentUserAgent + " " + this.TableConsumer.ToString();
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
                HashKeyIsNumeric = this.HashKeyIsNumeric,
                HashKeyName = this.HashKeyName,
                keyNames = this.keyNames,
                RangeKeyIsDefined = this.RangeKeyIsDefined,
                RangeKeyIsNumeric = this.RangeKeyIsNumeric,
                RangeKeyName = this.RangeKeyName,
                TableConsumer = this.TableConsumer
            };
        }

        #endregion


        #region Constructor/factory

        private Table(AmazonDynamoDB ddbClient, string tableName, Table.DynamoDBConsumer consumer)
        {
            DDBClient = ddbClient;
            TableConsumer = consumer;
            TableName = tableName;
            HashKeyIsNumeric = RangeKeyIsDefined = RangeKeyIsNumeric = false;
        }

        internal static Table LoadTable(AmazonDynamoDB ddbClient, string tableName, Table.DynamoDBConsumer consumer)
        {
            Table table = new Table(ddbClient, tableName, consumer);
            table.GetKeyInfo();
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
            Table table = new Table(ddbClient, tableName, Table.DynamoDBConsumer.DocumentModel);
            table.GetKeyInfo();
            return table;
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


        #region Public properties

        /// <summary>
        /// Name of the table.
        /// </summary>
        public string TableName { get; private set; }

        /// <summary>
        /// Name of the hash key element for the table.
        /// </summary>
        public string HashKeyName { get; private set; }

        /// <summary>
        /// Name of the range key element for the table.
        /// </summary>
        public string RangeKeyName { get; private set; }

        /// <summary>
        /// Flag that signals if the hash key element is a numeric.
        /// </summary>
        public bool HashKeyIsNumeric { get; private set; }

        /// <summary>
        /// Flag that signals if the range key element is a numeric.
        /// </summary>
        public bool RangeKeyIsNumeric { get; private set; }

        /// <summary>
        /// Flag that signals if the range key element is present on the table.
        /// </summary>
        public bool RangeKeyIsDefined { get; private set; }

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
            var currentConfig = config ?? new PutItemOperationConfig();

            PutItemRequest req = new PutItemRequest
            {
                TableName = TableName,
                Item = doc.ToAttributeMap()
            };
            req.BeforeRequestEvent += new RequestEventHandler(this.UserAgentRequestEventHandler);
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

        #region GetItem

        /// <summary>
        /// Gets a document from DynamoDB by hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <returns>Document from DynamoDB</returns>
        public Document GetItem(Primitive hashKey)
        {
            return GetHelper(MakeKey(hashKey, null), null);
        }

        /// <summary>
        /// Gets a document from DynamoDB by hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document GetItem(Primitive hashKey, Primitive rangeKey)
        {
            return GetHelper(MakeKey(hashKey, rangeKey), null);
        }

        /// <summary>
        /// Gets a document from DynamoDB by hash primary key, using specified configs.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Document from DynamoDB.</returns>
        public Document GetItem(Primitive hashKey, GetItemOperationConfig config)
        {
            return GetHelper(MakeKey(hashKey, null), config);
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
            return GetHelper(MakeKey(hashKey, rangeKey), config);
        }

        internal Document GetHelper(Key key, GetItemOperationConfig config)
        {
            var currentConfig = config ?? new GetItemOperationConfig();
            var request = new GetItemRequest
            {
                TableName = TableName,
                Key = key,
                ConsistentRead = currentConfig.ConsistentRead
            };
            request.BeforeRequestEvent += new RequestEventHandler(this.UserAgentRequestEventHandler);
            if (currentConfig.AttributesToGet != null)
                request.WithAttributesToGet(currentConfig.AttributesToGet);

            var result = DDBClient.GetItem(request);
            var attributeMap = result.GetItemResult.Item;
            if (attributeMap == null)
                return null;
            return Document.FromAttributeMap(attributeMap);
        }

        #endregion

        #region UpdateItem

        /// <summary>
        /// Update a document in DynamoDB.
        /// </summary>
        /// <param name="doc">Document to update.</param>
        public void UpdateItem(Document doc)
        {
            UpdateHelper(doc, MakeKey(doc), null);
        }
        /// <summary>
        /// Update a document in DynamoDB, with hash primary key to identify the document.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        public void UpdateItem(Document doc, Primitive hashKey)
        {
            UpdateHelper(doc, MakeKey(hashKey,null), null);
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
            UpdateHelper(doc, MakeKey(hashKey, rangeKey), null);
        }

        /// <summary>
        /// Update a document in DynamoDB, using specified config.
        /// </summary>
        /// <param name="doc">Document to update.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(doc), config);
        }
        /// <summary>
        /// Update a document in DynamoDB, with a hash primary key to identify the
        /// document, and using the specified config.
        /// </summary>
        /// <param name="doc">Attributes to update.</param>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or updated attributes, depending on config.</returns>
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, Primitive hashKey, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(hashKey, null), config);
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
        /// <seealso cref="Amazon.DynamoDB.DocumentModel.UpdateItemOperationConfig"/>
        public Document UpdateItem(Document doc, Primitive hashKey, Primitive rangeKey, UpdateItemOperationConfig config)
        {
            return UpdateHelper(doc, MakeKey(hashKey, rangeKey), config);
        }

        private Document UpdateHelper(Document doc, Key key, UpdateItemOperationConfig config)
        {
            var currentConfig = config ?? new UpdateItemOperationConfig();

            var attributeUpdates = doc.ToAttributeUpdateMap(true);
            foreach (var keyName in this.keyNames)
            {
                if (keyName != null)
                {
                    attributeUpdates.Remove(keyName);
                }
            }

            UpdateItemRequest req = new UpdateItemRequest
            {
                TableName = TableName,
                Key = key,
                AttributeUpdates = attributeUpdates,
                ReturnValues = EnumToStringMapper.Convert(currentConfig.ReturnValues)
            };
            req.BeforeRequestEvent += new RequestEventHandler(this.UserAgentRequestEventHandler);
            if (currentConfig.Expected != null)
                req.Expected = currentConfig.Expected.ToExpectedAttributeMap();

            var resp = DDBClient.UpdateItem(req);
            doc.CommitChanges();

            Document ret = null;
            if (currentConfig.ReturnValues != ReturnValues.None)
            {
                ret = Document.FromAttributeMap(resp.UpdateItemResult.Attributes);
            }
            return ret;
        }

        #endregion

        #region DeleteItem

        /// <summary>
        /// Delete a document in DynamoDB.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        public void DeleteItem(Document document)
        {
            DeleteHelper(MakeKey(document), null);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a hash primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        public void DeleteItem(Primitive hashKey)
        {
            DeleteHelper(MakeKey(hashKey, null), null);
        }
        /// <summary>
        /// Delete a document in DynamoDB, identified by a hash-and-range primary key.
        /// </summary>
        /// <param name="hashKey">Hash key element of the document.</param>
        /// <param name="rangeKey">Range key element of the document.</param>
        public void DeleteItem(Primitive hashKey, Primitive rangeKey)
        {
            DeleteHelper(MakeKey(hashKey, rangeKey), null);
        }

        /// <summary>
        /// Delete a document in DynamoDB, using specified configs.
        /// </summary>
        /// <param name="document">Document to delete.</param>
        /// <param name="config">Configuration to use.</param>
        /// <returns>Null or old attributes, depending on config.</returns>
        public Document DeleteItem(Document document, DeleteItemOperationConfig config)
        {
            return DeleteHelper(MakeKey(document), config);
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
            return DeleteHelper(MakeKey(hashKey, null), config);
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
            return DeleteHelper(MakeKey(hashKey, rangeKey), config);
        }

        internal Document DeleteHelper(Key key, DeleteItemOperationConfig config)
        {
            var currentConfig = config ?? new DeleteItemOperationConfig();

            var req = new DeleteItemRequest
            {
                TableName = TableName,
                Key = key
            };
            req.BeforeRequestEvent += new RequestEventHandler(this.UserAgentRequestEventHandler);
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

            Search ret = new Search(SearchType.Scan);

            ret.SourceTable = this;
            ret.TableName = TableName;
            ret.Limit = currentConfig.Limit;
            ret.Filter = currentConfig.Filter;
            ret.AttributesToGet = currentConfig.AttributesToGet;

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
        /// <param name="hashKey">Hash key element parameter of the query.</param>
        /// <param name="filter">Filter to use.</param>
        /// <returns>Resultant Search container.</returns>
        public Search Query(Primitive hashKey, RangeFilter filter)
        {
            return Query(new QueryOperationConfig { HashKey = hashKey, Filter = filter });
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
            if (string.IsNullOrEmpty(config.HashKey))
                throw new ArgumentNullException("config.HashKey");

            Search ret = new Search(SearchType.Query);

            ret.SourceTable = this;
            ret.TableName = TableName;
            ret.HashKey = config.HashKey.ConvertToAttributeValue();
            ret.AttributesToGet = config.AttributesToGet;
            ret.Filter = config.Filter;
            ret.Limit = config.Limit;
            ret.IsConsistentRead = config.ConsistentRead;
            ret.IsBackwardSearch = config.BackwardSearch;

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
    }
}
