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
using System.Collections.Generic;

using Amazon.DynamoDB.DocumentModel;
using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB.DataModel
{
    /// <summary>
    /// Interface for converting arbitrary objects to DynamoDB-supported
    /// object types.
    /// 
    /// Implementing type must be public, instantiable, and should have
    /// a zero-parameter constructor.
    /// </summary>
    public interface IPropertyConverter
    {
        /// <summary>
        /// Convert object to DynamoDBEntry
        /// </summary>
        /// <param name="value">Object to be deserialized</param>
        /// <returns>Object deserialized as DynamoDBEntry</returns>
        DynamoDBEntry ToEntry(object value);

        /// <summary>
        /// Convert DynamoDBEntry to the specified object
        /// </summary>
        /// <param name="entry">DynamoDBEntry to be serialized</param>
        /// <returns>Serialized object</returns>
        object FromEntry(DynamoDBEntry entry);
    }

    /// <summary>
    /// Configuration object for setting options on the DynamoDBContext.
    /// and individual operations.
    /// </summary>
    public class DynamoDBContextConfig
    {
        /// <summary>
        /// Property that directs DynamoDBContext to use consistent reads.
        /// If property is not set, behavior defaults to non-consistent reads.
        /// </summary>
        public bool? ConsistentRead { get; set; }

        /// <summary>
        /// Property that directs DynamoDBContext to skip version checks
        /// when saving or deleting an object with a version attribute.
        /// If property is not set, version checks are performed.
        /// </summary>
        public bool? SkipVersionCheck { get; set; }


        /// <summary>
        /// Property that directs DynamoDBContext to prefix all table names
        /// with a specific string.
        /// If property is null or empty, no prefix is used and default
        /// table names are used.
        /// </summary>
        public string TableNamePrefix { get; set; }
    }

    /// <summary>
    /// Configuration object for setting options for individual operations.
    /// This will override any settings specified by the DynamoDBContext's DynamoDBContextConfig object.
    /// </summary>
    public class DynamoDBOperationConfig : DynamoDBContextConfig
    {
        /// <summary>
        /// Property that indicates the table to save an object to overriding the DynamoDBTable attribute 
        /// declared for the type.
        /// </summary>
        public string OverrideTableName { get; set; }
    }

    /// <summary>
    /// Context object for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    public partial class DynamoDBContext
    {
        #region Private members

        private bool ownClient;
        private AmazonDynamoDB client;
        private Dictionary<string, Table> tablesMap;
        private DynamoDBContextConfig config;

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs a DynamoDBContext object with a default AmazonDynamoDBClient
        /// client and a default DynamoDBContextConfig object for configuration.
        /// </summary>
        public DynamoDBContext()
            : this(new AmazonDynamoDBClient(), true, new DynamoDBContextConfig()) { }

        /// <summary>
        /// Constructs a DynamoDBContext object with the specified configuration.
        /// Uses a default AmazonDynamoDBClient as the client.
        /// </summary>
        /// <param name="config"></param>
        public DynamoDBContext(DynamoDBContextConfig config)
            : this(new AmazonDynamoDBClient(), true, config) { }

        /// <summary>
        /// Constructs a DynamoDBContext object with the specified DynamoDB client.
        /// Uses default DynamoDBContextConfig object for configuration.
        /// </summary>
        /// <param name="client">Client to use for making calls</param>
        public DynamoDBContext(AmazonDynamoDB client)
            : this(client, false, new DynamoDBContextConfig()) { }
        
        /// <summary>
        /// Constructs a DynamoDBContext object with the specified DynamoDB client
        /// and configuration.
        /// </summary>
        /// <param name="client">Client to use for making calls</param>
        /// <param name="config">Configuration to use</param>
        public DynamoDBContext(AmazonDynamoDB client, DynamoDBContextConfig config)
            : this(client, false, config) { }


        private DynamoDBContext(AmazonDynamoDB client, bool ownClient, DynamoDBContextConfig config)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.client = client;
            this.tablesMap = new Dictionary<string, Table>();
            this.ownClient = ownClient;
            this.config = config ?? new DynamoDBContextConfig();
        }

        #endregion


        #region Save/serialize

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// Uses DynamoDBContextConfig configured on the context.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        public void Save<T>(T value)
        {
            Save(value, null);
        }

        /// <summary>
        /// Saves an object to DynamoDB using passed-in configs.
        /// 
        /// Passed-in config overrides DynamoDBContextConfig on the context.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        public void Save<T>(T value, DynamoDBOperationConfig operationConfig)
        {
            if (value == null) return;

            ItemStorage storage = ObjectToItemStorage<T>(value);
            if (storage == null) return;

            DynamoDBFlatConfig currentConfig = new DynamoDBFlatConfig(operationConfig, this.config);
            Table table = GetTargetTable(storage.Config, currentConfig);
            if ((currentConfig.SkipVersionCheck.HasValue && currentConfig.SkipVersionCheck.Value) || !storage.Config.HasVersion)
            {
                table.UpdateItem(storage.Document);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                SetNewVersion(storage);
                table.UpdateItem(storage.Document, new UpdateItemOperationConfig { Expected = expectedDocument, ReturnValues = ReturnValues.None });
                PopulateInstance(storage, value);
            }
        }

        /// <summary>
        /// Serializes an object to a Document.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <returns>Document with attributes populated from object.</returns>
        public Document ToDocument<T>(T value)
        {
            if (value == null) return null;

            ItemStorage storage = ObjectToItemStorage<T>(value);
            if (storage == null) return null;

            return storage.Document;
        }

        #endregion


        #region Load/deserialize

        /// <summary>
        /// Loads an object from DynamoDB for the given hash primary key.
        /// 
        /// Uses DynamoDBContextConfig configured on the context.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey)
        {
            return Load<T>(hashKey, null, null);
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash primary key and using the given config.
        /// 
        /// Passed-in config overrides DynamoDBContextConfig on the context.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey, DynamoDBOperationConfig operationConfig)
        {
            return Load<T>(hashKey, null, operationConfig);
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// 
        /// Uses DynamoDBContextConfig configured on the context.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey, object rangeKey)
        {
            return Load<T>(hashKey, rangeKey, null);
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key and using the given config.
        /// 
        /// Passed-in config overrides DynamoDBContextConfig on the context.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig currentConfig = new DynamoDBFlatConfig(operationConfig, this.config);

            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            ItemStorage storage = new ItemStorage(storageConfig);
            Table table = GetTargetTable(storageConfig, currentConfig);
            Key key = MakeKey(hashKey, rangeKey, storageConfig);
            GetItemOperationConfig getConfig = new GetItemOperationConfig
            {
                ConsistentRead = currentConfig.ConsistentRead.Value,
                AttributesToGet = storageConfig.AttributesToGet
            };

            storage.Document = table.GetHelper(key, getConfig);

            T instance = DocumentToObject<T>(storage);
            return instance;
        }

        /// <summary>
        /// Deserializes a document to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document">Document with properties to use.</param>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        public T FromDocument<T>(Document document)
        {
            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            ItemStorage storage = new ItemStorage(storageConfig);
            storage.Document = document;
            T instance = DocumentToObject<T>(storage);
            return instance;
        }

        #endregion


        #region Delete

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given object.
        /// 
        /// Uses DynamoDBContextConfig configured on the context.
        /// If SkipVersionCheck=false, will check version of object before deleting.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        public void Delete<T>(T value)
        {
            Delete<T>(value, null);
        }

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given object.
        /// 
        /// Passed-in config overrides DynamoDBContextConfig on the context.
        /// If SkipVersionCheck=false, will check version of object before deleting.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        public void Delete<T>(T value, DynamoDBOperationConfig operationConfig)
        {
            if (value == null) throw new ArgumentNullException("value");

            ItemStorage storage = ObjectToItemStorage<T>(value, true);
            if (storage == null) return;

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.config);
            Table table = GetTargetTable(storage.Config, flatConfig);
            if (flatConfig.SkipVersionCheck.Value || !storage.Config.HasVersion)
            {
                table.DeleteItem(storage.Document);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                table.DeleteItem(storage.Document, new DeleteItemOperationConfig { Expected = expectedDocument });
            }
        }

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash primary key.
        /// 
        /// No version check is done prior to delete.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        public void Delete<T>(object hashKey)
        {
            Delete<T>(hashKey, null);
        }

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash primary key.
        /// 
        /// No version check is done prior to delete.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        public void Delete<T>(object hashKey, DynamoDBOperationConfig operationConfig)
        {
            Delete<T>(hashKey, null, operationConfig);
        }

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// 
        /// No version check is done prior to delete.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        public void Delete<T>(object hashKey, object rangeKey)
        {
            Delete<T>(hashKey, rangeKey, null);
        }

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// 
        /// No version check is done prior to delete.
        /// Type must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        public void Delete<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig)
        {
            if (hashKey == null) throw new ArgumentNullException("hashKey");

            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.config);
            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            Table table = GetTargetTable(storageConfig, config);
            Key key = MakeKey(hashKey, rangeKey, storageConfig);

            table.DeleteHelper(key, null);
        }

        #endregion


        #region Scan/query

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Scan<T>(params ScanCondition[] conditions)
        {
            if (conditions == null)
                throw new ArgumentNullException("conditions");

            return Scan<T>(conditions, null);
        }

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Scan<T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig)
        {
            if (conditions == null)
                throw new ArgumentNullException("conditions");

            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            ScanFilter filter = ComposeScanFilter(conditions, storageConfig);

            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.config);
            Table table = GetTargetTable(storageConfig, config);
            Search scan = table.Scan(filter);
            scan.AttributesToGet = storageConfig.AttributesToGet;

            return FromSearch<T>(scan);
        }

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified range element condition for a hash-and-range primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="op">Operation of the condition.</param>
        /// <param name="values">
        /// Value(s) of the condition.
        /// For all operations except QueryOperator.Between, values should be one value.
        /// For QueryOperator.Betwee, values should be two values.
        /// </param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, params object[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentOutOfRangeException("values");

            return Query<T>(hashKeyValue, op, values, null);
        }

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified range element condition for a hash-and-range primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="op">Operation of the condition.</param>
        /// <param name="values">
        /// Value(s) of the condition.
        /// For all operations except QueryOperator.Between, values should be one value.
        /// For QueryOperator.Betwee, values should be two values.
        /// </param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            RangeFilter filter = ComposeRangeFilter(op, values, storageConfig);

            Primitive hashKeyEntry = ValueToDynamoDBEntry(storageConfig.HashKeyPropertyName, hashKeyValue, storageConfig) as Primitive;
            if (hashKeyEntry == null) throw new InvalidCastException("Unable to convert hash key value for property " + storageConfig.HashKeyPropertyName);

            DynamoDBFlatConfig currentConfig = new DynamoDBFlatConfig(operationConfig, this.config);
            Table table = GetTargetTable(storageConfig, currentConfig);
            Search query = table.Query(new QueryOperationConfig { HashKey = hashKeyEntry.Value, Filter = filter, ConsistentRead = currentConfig.ConsistentRead.Value });
            query.AttributesToGet = storageConfig.AttributesToGet;

            return FromSearch<T>(query);
        }

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig)
        {
            return FromScan<T>(scanConfig, null);
        }

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig)
        {
            if (scanConfig == null) throw new ArgumentNullException("scanConfig");

            Table table;
            table = GetTargetTable<T>(operationConfig);
            Search search = table.Scan(scanConfig);
            return FromSearch<T>(search);
        }
        
        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Query request object.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig)
        {
            return FromQuery<T>(queryConfig, null);
        }

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Query request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig)
        {
            if (queryConfig == null) throw new ArgumentNullException("queryConfig");

            Table table;
            table = GetTargetTable<T>(operationConfig);
            Search search = table.Query(queryConfig);
            return FromSearch<T>(search);
        }

        #endregion


        #region BatchGet

        /// <summary>
        /// Creates a strongly-typed BatchGet object, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get</typeparam>
        /// <returns>Empty strongly-typed BatchGet object</returns>
        public BatchGet<T> CreateBatchGet<T>()
        {
            return CreateBatchGet<T>(null);
        }

        /// <summary>
        /// Creates a strongly-typed BatchGet object, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get</typeparam>
        /// <returns>Empty strongly-typed BatchGet object</returns>
        public BatchGet<T> CreateBatchGet<T>(DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.config);
            return new BatchGet<T>(this, config);
        }

        /// <summary>
        /// Creates a MultiTableBatchGet object, composed of multiple
        /// individual BatchGet objects.
        /// </summary>
        /// <param name="batches">Individual BatchGet objects</param>
        /// <returns>Composite MultiTableBatchGet object</returns>
        public MultiTableBatchGet CreateMultiTableBatchGet(params BatchGet[] batches)
        {
            return new MultiTableBatchGet(batches);
        }

        /// <summary>
        /// Issues a batch-get request with multiple batches.
        /// 
        /// Results are stored in the individual batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchGet objects
        /// </param>
        public void ExecuteBatchGet(params BatchGet[] batches)
        {
            MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
            superBatch.Execute();
        }
        
        #endregion


        #region Table methods

        /// <summary>
        /// Retrieves the target table for the specified type
        /// </summary>
        /// <typeparam name="T">Type to retrieve table for</typeparam>
        /// <returns>Table object</returns>
        public Table GetTargetTable<T>()
        {
            return GetTargetTable<T>(null);
        }

        /// <summary>
        /// Retrieves the target table for the specified type
        /// </summary>
        /// <typeparam name="T">Type to retrieve table for</typeparam>
        /// <returns>Table object</returns>
        public Table GetTargetTable<T>(DynamoDBOperationConfig operationConfig)
        {
            Type type = typeof(T);
            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig(type);
            Table table = GetTargetTable(storageConfig, new DynamoDBFlatConfig(operationConfig, this.config));
            Table copy = table.Copy(Table.DynamoDBConsumer.DocumentModel);
            return table;
        }

        #endregion
    }

    /// <summary>
    /// Class describing a single scan condition
    /// </summary>
    public class ScanCondition
    {
        #region Public properties

        /// <summary>
        /// Name of the property being tested
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Comparison operator
        /// </summary>
        public ScanOperator Operator { get; set; }

        /// <summary>
        /// Values being tested against.
        /// 
        /// The values should be of the same type as the property.
        /// In the cases where the property is a collection, the values
        /// should be of the same type as the items in the collection.
        /// </summary>
        public object[] Values { get; set; }

        #endregion


        #region Constructor

        /// <summary>
        /// Initializes a ScanCondition with the target property, the
        /// comparison operator and values being tested against.
        /// </summary>
        /// <param name="propertyName">Name of the property</param>
        /// <param name="op">Comparison operator</param>
        /// <param name="values">
        /// Value(s) being tested against.
        /// 
        /// The values should be of the same type as the property.
        /// In the cases where the property is a collection, the values
        /// should be of the same type as the items in the collection.
        /// </param>
        public ScanCondition(string propertyName, ScanOperator op, params object[] values)
        {
            PropertyName = propertyName;
            Operator = op;
            Values = values;
        }

        #endregion
    }
}
