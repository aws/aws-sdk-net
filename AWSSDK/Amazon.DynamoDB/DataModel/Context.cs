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

        /// <summary>
        /// Property that directs DynamoDBContext to ignore null values
        /// on attributes during a Save operation.
        /// If the property is false (or not set), null values will be
        /// interpreted as directives to delete the specific attribute.
        /// </summary>
        public bool? IgnoreNullValues { get; set; }
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

        /// <summary>
        /// Property that indicates a query should traverse the index backward.
        /// If the property is false (or not set), traversal shall be forward.
        /// </summary>
        public bool? BackwardQuery { get; set; }
    }

    /// <summary>
    /// Context object for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Private members

        private bool ownClient;
        private AmazonDynamoDB client;
        private Dictionary<string, Table> tablesMap;
        private DynamoDBContextConfig config;
        private readonly object tablesMapLock = new object();

        #endregion


        #region Constructors

        /// <summary>
        /// Constructs a DynamoDBContext object with a default AmazonDynamoDBClient
        /// client and a default DynamoDBContextConfig object for configuration.
        /// </summary>
        public DynamoDBContext()
            : this(RegionEndpoint.USEast1) { }

        /// <summary>
        /// Constructs a DynamoDBContext object with a default AmazonDynamoDBClient
        /// client and a default DynamoDBContextConfig object for configuration.
        /// </summary>
        /// <param name="region">The region to configure the AmazonDynamoDBClient to use.</param>
        public DynamoDBContext(RegionEndpoint region)
            : this(new AmazonDynamoDBClient(region), true, new DynamoDBContextConfig()) { }

        /// <summary>
        /// Constructs a DynamoDBContext object with the specified configuration.
        /// Uses a default AmazonDynamoDBClient as the client.
        /// </summary>
        /// <param name="config"></param>
        public DynamoDBContext(DynamoDBContextConfig config)
            : this(RegionEndpoint.USEast1, config) { }

        /// <summary>
        /// Constructs a DynamoDBContext object with the specified configuration.
        /// Uses a default AmazonDynamoDBClient as the client.
        /// </summary>
        /// <param name="region">The region to configure the AmazonDynamoDBClient to use.</param>
        /// <param name="config"></param>
        public DynamoDBContext(RegionEndpoint region, DynamoDBContextConfig config)
            : this(new AmazonDynamoDBClient(region), true, config) { }

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
            SaveHelper<T>(value, operationConfig, false);
        }

        private void SaveHelper<T>(T value, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            if (value == null) return;

            DynamoDBFlatConfig currentConfig = new DynamoDBFlatConfig(operationConfig, this.config);
            ItemStorage storage = ObjectToItemStorage<T>(value, false, currentConfig.IgnoreNullValues.Value);
            if (storage == null) return;

            Table table = GetTargetTable(storage.Config, currentConfig);
            if (
                (currentConfig.SkipVersionCheck.HasValue && currentConfig.SkipVersionCheck.Value)
                || !storage.Config.HasVersion)
            {
                table.UpdateHelper(storage.Document, table.MakeKey(storage.Document), null, isAsync);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                SetNewVersion(storage);
                table.UpdateHelper(
                    storage.Document,
                    table.MakeKey(storage.Document),
                    new UpdateItemOperationConfig { Expected = expectedDocument, ReturnValues = ReturnValues.None },
                    true);
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

            ItemStorage storage = ObjectToItemStorage<T>(value, false, false);
            if (storage == null) return null;

            return storage.Document;
        }

        #endregion

        #region Save async

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSave
        ///         operation.</returns>
        public IAsyncResult BeginSave<T>(T value, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { SaveHelper<T>(value, null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSave
        ///         operation.</returns>
        public IAsyncResult BeginSave<T>(T value, DynamoDBOperationConfig operationConfig, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { SaveHelper<T>(value, operationConfig, true); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSave.</param>
        public void EndSave(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
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
            return LoadHelper<T>(hashKey, rangeKey, operationConfig, false);
        }

        private T LoadHelper<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, bool isAsync)
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

            storage.Document = table.GetItemHelper(key, getConfig, isAsync);

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

        #region Load async

        /// <summary>
        /// Initiates the asynchronous execution of the Load operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Load"/>
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLoad
        ///         operation.</returns>
        public IAsyncResult BeginLoad<T>(object hashKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => LoadHelper<T>(hashKey, null, null, true), callback, state);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the Load operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Load"/>
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLoad
        ///         operation.</returns>
        public IAsyncResult BeginLoad<T>(object hashKey, object rangeKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => LoadHelper<T>(hashKey, rangeKey, null, true), callback, state);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the Load operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Load"/>
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLoad
        ///         operation.</returns>
        public IAsyncResult BeginLoad<T>(object hashKey, DynamoDBOperationConfig operationConfig, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => LoadHelper<T>(hashKey, null, operationConfig, true), callback, state);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the Load operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Load"/>
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLoad
        ///         operation.</returns>
        public IAsyncResult BeginLoad<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => LoadHelper<T>(hashKey, rangeKey, operationConfig, true), callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Load operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Load"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLoad.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        public T EndLoad<T>(IAsyncResult asyncResult)
        {
            return (T)DynamoDBAsyncExecutor.EndOperation(asyncResult);
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
            DeleteHelper<T>(value, operationConfig, false);
        }
        
        private void DeleteHelper<T>(T value, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            if (value == null) throw new ArgumentNullException("value");

            ItemStorage storage = ObjectToItemStorage<T>(value, true, true);
            if (storage == null) return;

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.config);
            Table table = GetTargetTable(storage.Config, flatConfig);
            if (flatConfig.SkipVersionCheck.Value || !storage.Config.HasVersion)
            {
                table.DeleteHelper(table.MakeKey(storage.Document), null, isAsync);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                table.DeleteHelper(
                    table.MakeKey(storage.Document),
                    new DeleteItemOperationConfig { Expected = expectedDocument },
                    isAsync);
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
            DeleteHelper<T>(hashKey, rangeKey, operationConfig, false);
        }

        private void DeleteHelper<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            if (hashKey == null) throw new ArgumentNullException("hashKey");

            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.config);
            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            Table table = GetTargetTable(storageConfig, config);
            Key key = MakeKey(hashKey, rangeKey, storageConfig);

            table.DeleteHelper(key, null, false);
        }

        #endregion

        #region Delete async

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDelete
        ///         operation.</returns>
        public IAsyncResult BeginDelete<T>(T value, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper<T>(value, null, true); return null; }, callback, state);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDelete
        ///         operation.</returns>
        public IAsyncResult BeginDelete<T>(T value, DynamoDBOperationConfig operationConfig, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper<T>(value, operationConfig, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDelete
        ///         operation.</returns>
        public IAsyncResult BeginDelete<T>(object hashKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper<T>(hashKey, null, null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDelete
        ///         operation.</returns>
        public IAsyncResult BeginDelete<T>(object hashKey, DynamoDBOperationConfig operationConfig, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper<T>(hashKey, null, operationConfig, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDelete
        ///         operation.</returns>
        public IAsyncResult BeginDelete<T>(object hashKey, object rangeKey, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper<T>(hashKey, rangeKey, null, true); return null; }, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDelete
        ///         operation.</returns>
        public IAsyncResult BeginDelete<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, AsyncCallback callback, object state)
        {
            return DynamoDBAsyncExecutor.BeginOperation(() => { DeleteHelper<T>(hashKey, rangeKey, operationConfig, true); return null; }, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Delete operation.
        /// <seealso cref="Amazon.DynamoDB.DataModel.DynamoDBContext.Delete"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDelete.</param>
        public void EndDelete(IAsyncResult asyncResult)
        {
            DynamoDBAsyncExecutor.EndOperation(asyncResult);
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
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Query<T>(object hashKeyValue)
        {
            return QueryHelper<T>(hashKeyValue, QueryOperator.Equal, null, null);
        }

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Query<T>(object hashKeyValue, DynamoDBOperationConfig operationConfig)
        {
            return QueryHelper<T>(hashKeyValue, QueryOperator.Equal, null, operationConfig);
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

            return QueryHelper<T>(hashKeyValue, op, values, null);
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

            return QueryHelper<T>(hashKeyValue, op, values, operationConfig);
        }

        private IEnumerable<T> QueryHelper<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig)
        {
            ItemStorageConfig storageConfig = ItemStorageConfigCache.GetConfig<T>();
            RangeFilter filter = ComposeRangeFilter(op, values, storageConfig);

            Primitive hashKeyEntry = ValueToDynamoDBEntry(storageConfig.HashKeyPropertyName, hashKeyValue, storageConfig) as Primitive;
            if (hashKeyEntry == null) throw new InvalidCastException("Unable to convert hash key value for property " + storageConfig.HashKeyPropertyName);

            DynamoDBFlatConfig currentConfig = new DynamoDBFlatConfig(operationConfig, this.config);
            Table table = GetTargetTable(storageConfig, currentConfig);
            Search query = table.Query(new QueryOperationConfig { HashKey = hashKeyEntry, Filter = filter, ConsistentRead = currentConfig.ConsistentRead.Value, BackwardSearch = currentConfig.BackwardQuery.Value });
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
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
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


        #region Batch Write

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        public BatchWrite<T> CreateBatchWrite<T>()
        {
            return CreateBatchWrite<T>(null);
        }

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        public BatchWrite<T> CreateBatchWrite<T>(DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.config);
            return new BatchWrite<T>(this, config);
        }

        /// <summary>
        /// Creates a MultiTableBatchWrite object, composed of multiple
        /// individual BatchWrite objects.
        /// </summary>
        /// <param name="batches">Individual BatchWrite objects</param>
        /// <returns>Composite MultiTableBatchWrite object</returns>
        public MultiTableBatchWrite CreateMultiTableBatchWrite(params BatchWrite[] batches)
        {
            return new MultiTableBatchWrite(batches);
        }

        /// <summary>
        /// Issues a batch-write request with multiple batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchWrite objects
        /// </param>
        public void ExecuteBatchWrite(params BatchWrite[] batches)
        {
            MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
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
