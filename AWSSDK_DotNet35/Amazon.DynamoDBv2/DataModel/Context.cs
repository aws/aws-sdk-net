﻿/*
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
using System.Linq;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Context object for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Private members

        private bool disposed;
        private bool ownClient;
        private IAmazonDynamoDB client;
        private Dictionary<string, Table> tablesMap;
        private readonly object tablesMapLock = new object();
        internal DynamoDBContextConfig Config { get; private set; }
        internal ItemStorageConfigCache StorageConfigCache { get; private set; }

        #endregion


        #region Constructors

#if !(WIN_RT || WINDOWS_PHONE)
        /// <summary>
        /// Constructs a DynamoDBContext object with a default AmazonDynamoDBClient
        /// client and a default DynamoDBContextConfig object for configuration.
        /// </summary>
        public DynamoDBContext()
            : this(new AmazonDynamoDBClient()) { }

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
            : this(new AmazonDynamoDBClient(), config) { }

        /// <summary>
        /// Constructs a DynamoDBContext object with the specified configuration.
        /// Uses a default AmazonDynamoDBClient as the client.
        /// </summary>
        /// <param name="region">The region to configure the AmazonDynamoDBClient to use.</param>
        /// <param name="config"></param>
        public DynamoDBContext(RegionEndpoint region, DynamoDBContextConfig config)
            : this(new AmazonDynamoDBClient(region), true, config) { }
#endif
        /// <summary>
        /// Constructs a DynamoDBContext object with the specified DynamoDB client.
        /// Uses default DynamoDBContextConfig object for configuration.
        /// </summary>
        /// <param name="client">Client to use for making calls</param>
        public DynamoDBContext(IAmazonDynamoDB client)
            : this(client, false, new DynamoDBContextConfig()) { }
        
        /// <summary>
        /// Constructs a DynamoDBContext object with the specified DynamoDB client
        /// and configuration.
        /// </summary>
        /// <param name="client">Client to use for making calls</param>
        /// <param name="config">Configuration to use</param>
        public DynamoDBContext(IAmazonDynamoDB client, DynamoDBContextConfig config)
            : this(client, false, config) { }


        private DynamoDBContext(IAmazonDynamoDB client, bool ownClient, DynamoDBContextConfig config)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.client = client;
            this.tablesMap = new Dictionary<string, Table>();
            this.ownClient = ownClient;
            this.Config = config ?? new DynamoDBContextConfig();
            this.StorageConfigCache = new ItemStorageConfigCache(this);
        }

        #endregion

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing && client != null)
                {
                    if (ownClient)
                    {
                        client.Dispose();
                    }
                    client = null;
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~DynamoDBContext()
        {
            this.Dispose(false);
        }

        #endregion


        #region Save/serialize

        private void SaveHelper<T>(T value, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            if (value == null) return;

            DynamoDBFlatConfig currentConfig = new DynamoDBFlatConfig(operationConfig, this.Config);
            ItemStorage storage = ObjectToItemStorage<T>(value, false, currentConfig);
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
            return ToDocument<T>(value, null);
        }

        /// <summary>
        /// Serializes an object to a Document.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Document with attributes populated from object.</returns>
        public Document ToDocument<T>(T value, DynamoDBOperationConfig operationConfig)
        {
            if (value == null) return null;

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            ItemStorage storage = ObjectToItemStorage<T>(value, false, flatConfig);
            if (storage == null) return null;

            return storage.Document;
        }

        #endregion

        #region Load/deserialize

        private T LoadHelper<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey(hashKey, rangeKey, storageConfig);
            return LoadHelper<T>(key, flatConfig, storageConfig, isAsync);
        }
        private T LoadHelper<T>(T keyObject, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey<T>(keyObject, storageConfig);
            return LoadHelper<T>(key, flatConfig, storageConfig, isAsync);
        }
        private T LoadHelper<T>(Key key, DynamoDBFlatConfig flatConfig, ItemStorageConfig storageConfig, bool isAsync)
        {
            GetItemOperationConfig getConfig = new GetItemOperationConfig
            {
                ConsistentRead = flatConfig.ConsistentRead.Value,
                AttributesToGet = storageConfig.AttributesToGet
            };

            Table table = GetTargetTable(storageConfig, flatConfig);
            ItemStorage storage = new ItemStorage(storageConfig);
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
            return FromDocument<T>(document, null);
        }

        /// <summary>
        /// Deserializes a document to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document">Document with properties to use.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        public T FromDocument<T>(Document document, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            return FromDocumentHelper<T>(document, flatConfig);
        }

        internal T FromDocumentHelper<T>(Document document, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            ItemStorage storage = new ItemStorage(storageConfig);
            storage.Document = document;
            T instance = DocumentToObject<T>(storage);
            return instance;
        }


        /// <summary>
        /// Deserializes a collections of documents to a collection of instances of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="documents">Documents to deserialize.</param>
        /// <returns>
        /// Collection of items of type T, each populated with properties from a corresponding document.
        /// </returns>
        public IEnumerable<T> FromDocuments<T>(IEnumerable<Document> documents)
        {
            return FromDocuments<T>(documents, null);
        }

        /// <summary>
        /// Deserializes a collections of documents to a collection of instances of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="documents">Documents to deserialize.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>
        /// Collection of items of type T, each populated with properties from a corresponding document.
        /// </returns>
        public IEnumerable<T> FromDocuments<T>(IEnumerable<Document> documents, DynamoDBOperationConfig operationConfig)
        {
            foreach (var document in documents)
            {
                T item = FromDocument<T>(document, operationConfig);
                yield return item;
            }
        }

        internal IEnumerable<T> FromDocumentsHelper<T>(IEnumerable<Document> documents, DynamoDBFlatConfig flatConfig)
        {
            foreach (var document in documents)
            {
                T item = FromDocumentHelper<T>(document, flatConfig);
                yield return item;
            }
        }

        #endregion

        #region Delete

        private void DeleteHelper<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.Config);
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(config);
            Key key = MakeKey(hashKey, rangeKey, storageConfig);

            Table table = GetTargetTable(storageConfig, config);
            table.DeleteHelper(key, null, isAsync);
        }

        private void DeleteHelper<T>(T value, DynamoDBOperationConfig operationConfig, bool isAsync)
        {
            if (value == null) throw new ArgumentNullException("value");

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, this.Config);
            flatConfig.IgnoreNullValues = true;
            ItemStorage storage = ObjectToItemStorage<T>(value, true, flatConfig);
            if (storage == null) return;

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

        #endregion

    }
}
