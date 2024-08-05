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
using System.Threading;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif
using Amazon.DynamoDBv2.DocumentModel;

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
        internal IAmazonDynamoDB Client { get; private set; }
        private Dictionary<string, Table> tablesMap;

        private readonly ReaderWriterLockSlim _readerWriterLockSlim = new ReaderWriterLockSlim();

        internal DynamoDBContextConfig Config { get; private set; }
        internal ItemStorageConfigCache StorageConfigCache { get; private set; }

        #endregion

        #region Public properties

        /// <summary>
        /// This cache is a way to store Converters for objects which provides a way to expand Context
        /// </summary>
        public Dictionary<Type, IPropertyConverter> ConverterCache { get; private set; }

        #endregion

        #region Public methods
        /// <inheritdoc/>
        public void RegisterTableDefinition(Table table)
        {
            try
            {
                _readerWriterLockSlim.EnterReadLock();

                if (tablesMap.ContainsKey(table.TableName))
                {
                    return;
                }
            }
            finally
            {
                if (_readerWriterLockSlim.IsReadLockHeld)
                {
                    _readerWriterLockSlim.ExitReadLock();
                }
            }

            try
            {
                _readerWriterLockSlim.EnterWriteLock();

                // Check to see if another thread got the write lock before this thread and filled the cache.
                if (tablesMap.ContainsKey(table.TableName))
                {
                    return;
                }

                tablesMap[table.TableName] = table;
            }
            finally
            {
                if (_readerWriterLockSlim.IsWriteLockHeld)
                {
                    _readerWriterLockSlim.ExitWriteLock();
                }
            }
        }
        #endregion

        #region Constructors

#if !NETSTANDARD

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

            this.ConverterCache = new Dictionary<Type, IPropertyConverter>();
            this.ConverterCache.Add(typeof(S3Link), new S3Link.S3LinkConverter(this));
            this.Client = client;
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
                if (disposing && Client != null)
                {
                    if (ownClient)
                    {
                        StorageConfigCache.Dispose();
                        Client.Dispose();
                    }
                    Client = null;
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

        #region BatchGet

        /// <inheritdoc/>
        public IBatchGet<T> CreateBatchGet<T>()
        {
            return CreateBatchGet<T>((BatchGetConfig)null);
        }

        /// <inheritdoc/>
        [Obsolete("Use the CreateBatchGet overload that takes BatchGetConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchGet.")]
        public IBatchGet<T> CreateBatchGet<T>(DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.Config);
            return new BatchGet<T>(this, config);
        }

        /// <inheritdoc/>
        public IBatchGet<T> CreateBatchGet<T>(BatchGetConfig batchGetConfig)
        {
            return new BatchGet<T>(this, new DynamoDBFlatConfig(batchGetConfig?.ToDynamoDBOperationConfig(), Config));
        }

        /// <inheritdoc/>
        public IMultiTableBatchGet CreateMultiTableBatchGet(params IBatchGet[] batches)
        {
            return new MultiTableBatchGet(batches);
        }

        #endregion

        #region BatchWrite

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        public BatchWrite<T> CreateBatchWrite<T>()
        {
            return CreateBatchWrite<T>((BatchWriteConfig)null);
        }

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        [Obsolete("Use the CreateBatchWrite overload that takes BatchWriteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchWrite.")]
        public BatchWrite<T> CreateBatchWrite<T>(DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.Config);
            return new BatchWrite<T>(this, config);
        }

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// 
        /// This is intended for use only when the valuesType is not known at compile-time, for example,
        /// when hooking into EF's ChangeTracker to record audit logs from EF into DynamoDB.
        /// 
        /// In scenarios when the valuesType is known at compile-time, the <see cref="CreateBatchWrite{T}()"/>
        /// method is generally preferred.
        /// </summary>
        /// <param name="valuesType">Type of objects to write</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        public BatchWrite<object> CreateBatchWrite(Type valuesType)
        {
            return CreateBatchWrite(valuesType, (BatchWriteConfig)null);
        }

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// 
        /// This is intended for use only when the valuesType is not known at compile-time, for example,
        /// when hooking into EF's ChangeTracker to record audit logs from EF into DynamoDB.
        /// 
        /// In scenarios when the valuesType is known at compile-time, the 
        /// <see cref="CreateBatchWrite{T}(DynamoDBOperationConfig)"/> method is generally preferred.
        /// </summary>
        /// <param name="valuesType">Type of objects to write</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        [Obsolete("Use the CreateBatchWrite overload that takes BatchWriteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchWrite.")]
        public BatchWrite<object> CreateBatchWrite(Type valuesType, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.Config);
            return new BatchWrite<object>(this, valuesType, config);
        }

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <param name="batchWriteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        public BatchWrite<T> CreateBatchWrite<T>(BatchWriteConfig batchWriteConfig)
        {
            return new BatchWrite<T>(this, new DynamoDBFlatConfig(batchWriteConfig?.ToDynamoDBOperationConfig(), Config));
        }

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// 
        /// This is intended for use only when the valuesType is not known at compile-time, for example,
        /// when hooking into EF's ChangeTracker to record audit logs from EF into DynamoDB.
        /// 
        /// In scenarios when the valuesType is known at compile-time, the 
        /// <see cref="CreateBatchWrite{T}(DynamoDBOperationConfig)"/> method is generally preferred.
        /// </summary>
        /// <param name="valuesType">The type of data which will be persisted in this batch.</param>
        /// <param name="batchWriteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        public BatchWrite<object> CreateBatchWrite(Type valuesType, BatchWriteConfig batchWriteConfig)
        {
            return new BatchWrite<object>(this, valuesType, new DynamoDBFlatConfig(batchWriteConfig.ToDynamoDBOperationConfig(), Config));
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

        #endregion

        #region TransactGet

        /// <summary>
        /// Creates a strongly-typed TransactGet object, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get.</typeparam>
        /// <returns>Empty strongly-typed TransactGet object.</returns>
        public TransactGet<T> CreateTransactGet<T>()
        {
            return CreateTransactGet<T>((TransactGetConfig)null);
        }

        /// <summary>
        /// Creates a strongly-typed TransactGet object, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get.</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed TransactGet object.</returns>
        [Obsolete("Use the CreateTransactGet overload that takes TransactGetConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchGet.")]
        public TransactGet<T> CreateTransactGet<T>(DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.Config);
            return new TransactGet<T>(this, config);
        }

        /// <summary>
        /// Creates a strongly-typed TransactGet object, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get.</typeparam>
        /// <param name="transactGetConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed TransactGet object.</returns>
        public TransactGet<T> CreateTransactGet<T>(TransactGetConfig transactGetConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(transactGetConfig?.ToDynamoDBOperationConfig(), this.Config);
            return new TransactGet<T>(this, config);
        }

        /// <summary>
        /// Creates a MultiTableTransactGet object, composed of multiple
        /// individual TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Individual TransactGet objects.</param>
        /// <returns>Composite MultiTableTransactGet object.</returns>
        public MultiTableTransactGet CreateMultiTableTransactGet(params TransactGet[] transactionParts)
        {
            return new MultiTableTransactGet(transactionParts);
        }

        #endregion

        #region TransactWrite

        /// <summary>
        /// Creates a strongly-typed TransactWrite object, allowing
        /// a transactional write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write.</typeparam>
        /// <returns>Empty strongly-typed TransactWrite object.</returns>
        public TransactWrite<T> CreateTransactWrite<T>()
        {
            return CreateTransactWrite<T>((TransactWriteConfig)null);
        }

        /// <summary>
        /// Creates a strongly-typed TransactWrite object, allowing
        /// a transactional write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write.</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed TransactWrite object.</returns>

        [Obsolete("Use the CreateTransactWrite overload that takes TransactWriteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to CreateTransactWrite.")]
        public TransactWrite<T> CreateTransactWrite<T>(DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(operationConfig, this.Config);
            return new TransactWrite<T>(this, config);
        }

        /// <summary>
        /// Creates a strongly-typed TransactWrite object, allowing
        /// a transactional write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write.</typeparam>
        /// <param name="transactWriteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed TransactWrite object.</returns>
        public TransactWrite<T> CreateTransactWrite<T>(TransactWriteConfig transactWriteConfig)
        {
            DynamoDBFlatConfig config = new DynamoDBFlatConfig(transactWriteConfig?.ToDynamoDBOperationConfig(), this.Config);
            return new TransactWrite<T>(this, config);
        }

        /// <summary>
        /// Creates a MultiTableTransactWrite object, composed of multiple
        /// individual TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Individual TransactWrite objects.</param>
        /// <returns>Composite MultiTableTransactWrite object.</returns>
        public MultiTableTransactWrite CreateMultiTableTransactWrite(params TransactWrite[] transactionParts)
        {
            return new MultiTableTransactWrite(transactionParts);
        }

        #endregion

        #region Save/serialize

        private void SaveHelper<T>(T value, DynamoDBFlatConfig flatConfig)
        {
            if (value == null) return;

            ItemStorage storage = ObjectToItemStorage(value, false, flatConfig);
            if (storage == null) return;

            Table table = GetTargetTable(storage.Config, flatConfig);
            if ((flatConfig.SkipVersionCheck.HasValue && flatConfig.SkipVersionCheck.Value) || !storage.Config.HasVersion)
            {
                table.UpdateHelper(storage.Document, table.MakeKey(storage.Document), null);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                SetNewVersion(storage);
                var updateItemOperationConfig = new UpdateItemOperationConfig
                {
                    Expected = expectedDocument,
                    ReturnValues = ReturnValues.None,
                };
                table.UpdateHelper(storage.Document, table.MakeKey(storage.Document), updateItemOperationConfig);
                PopulateInstance(storage, value, flatConfig);
            }
        }

#if AWS_ASYNC_API 
        private async Task SaveHelperAsync<T>(T value, DynamoDBFlatConfig flatConfig, CancellationToken cancellationToken)
        {
            await SaveHelperAsync(typeof(T), value, flatConfig, cancellationToken).ConfigureAwait(false);
        }

        private async Task SaveHelperAsync(Type valueType, object value, DynamoDBFlatConfig flatConfig, CancellationToken cancellationToken)
        {
            if (value == null) return;

            ItemStorage storage = ObjectToItemStorage(value, valueType, false, flatConfig);
            if (storage == null) return;

            Table table = GetTargetTable(storage.Config, flatConfig);
            if (
                (flatConfig.SkipVersionCheck.HasValue && flatConfig.SkipVersionCheck.Value)
                || !storage.Config.HasVersion)
            {
                await table.UpdateHelperAsync(storage.Document, table.MakeKey(storage.Document), null, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                SetNewVersion(storage);
                await table.UpdateHelperAsync(
                    storage.Document,
                    table.MakeKey(storage.Document),
                    new UpdateItemOperationConfig { Expected = expectedDocument, ReturnValues = ReturnValues.None },
                    cancellationToken).ConfigureAwait(false);
                PopulateInstance(storage, value, flatConfig);
            }
        }
#endif

        /// <inheritdoc/>
        public Document ToDocument<T>(T value)
        {
            return ToDocument<T>(value, (ToDocumentConfig)null);
        }

        /// <inheritdoc/>
        [Obsolete("Use the ToDocument overload that takes ToDocumentConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to ToDocument.")]
        public Document ToDocument<T>(T value, DynamoDBOperationConfig operationConfig)
        {
            if (value == null) return null;

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            ItemStorage storage = ObjectToItemStorage<T>(value, false, flatConfig);
            if (storage == null) return null;

            return storage.Document;
        }

        /// <inheritdoc/>
        public Document ToDocument<T>(T value, ToDocumentConfig toDocumentConfig)
        {
            if (value == null) return null;

            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(toDocumentConfig?.ToDynamoDBOperationConfig(), Config);
            ItemStorage storage = ObjectToItemStorage<T>(value, false, flatConfig);
            if (storage == null) return null;

            return storage.Document;
        }

        #endregion

        #region Load/deserialize

        private T LoadHelper<T>(object hashKey, object rangeKey, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey(hashKey, rangeKey, storageConfig, flatConfig);
            return LoadHelper<T>(key, flatConfig, storageConfig);
        }

#if AWS_ASYNC_API 
        private Task<T> LoadHelperAsync<T>(object hashKey, object rangeKey, DynamoDBFlatConfig flatConfig, CancellationToken cancellationToken)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey(hashKey, rangeKey, storageConfig, flatConfig);
            return LoadHelperAsync<T>(key, flatConfig, storageConfig, cancellationToken);
        }
#endif

        private T LoadHelper<T>(T keyObject, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey<T>(keyObject, storageConfig, flatConfig);
            return LoadHelper<T>(key, flatConfig, storageConfig);
        }

#if AWS_ASYNC_API 
        private Task<T> LoadHelperAsync<T>(T keyObject, DynamoDBFlatConfig flatConfig, CancellationToken cancellationToken)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey<T>(keyObject, storageConfig, flatConfig);
            return LoadHelperAsync<T>(key, flatConfig, storageConfig, cancellationToken);
        }
#endif

        private T LoadHelper<T>(Key key, DynamoDBFlatConfig flatConfig, ItemStorageConfig storageConfig)
        {
            GetItemOperationConfig getConfig = new GetItemOperationConfig
            {
                ConsistentRead = flatConfig.ConsistentRead.Value,
                AttributesToGet = storageConfig.AttributesToGet
            };

            Table table = GetTargetTable(storageConfig, flatConfig);
            ItemStorage storage = new ItemStorage(storageConfig);
            storage.Document = table.GetItemHelper(key, getConfig);

            T instance = DocumentToObject<T>(storage, flatConfig);
            return instance;
        }

#if AWS_ASYNC_API 
        private async Task<T> LoadHelperAsync<T>(Key key, DynamoDBFlatConfig flatConfig, ItemStorageConfig storageConfig, CancellationToken cancellationToken)
        {
            GetItemOperationConfig getConfig = new GetItemOperationConfig
            {
                ConsistentRead = flatConfig.ConsistentRead.Value,
                AttributesToGet = storageConfig.AttributesToGet
            };

            Table table = GetTargetTable(storageConfig, flatConfig);
            ItemStorage storage = new ItemStorage(storageConfig);
            storage.Document = await table.GetItemHelperAsync(key, getConfig, cancellationToken).ConfigureAwait(false);

            T instance = DocumentToObject<T>(storage, flatConfig);
            return instance;
        }
#endif

        /// <inheritdoc/>
        public T FromDocument<T>(Document document)
        {
            return FromDocument<T>(document, (FromDocumentConfig)null);
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromDocument overload that takes FromDocumentConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromDocument.")]
        public T FromDocument<T>(Document document, DynamoDBOperationConfig operationConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(operationConfig, Config);
            return FromDocumentHelper<T>(document, flatConfig);
        }

        /// <inheritdoc/>
        public T FromDocument<T>(Document document, FromDocumentConfig fromDocumentConfig)
        {
            DynamoDBFlatConfig flatConfig = new DynamoDBFlatConfig(fromDocumentConfig?.ToDynamoDBOperationConfig(), Config);
            return FromDocumentHelper<T>(document, flatConfig);
        }

        internal T FromDocumentHelper<T>(Document document, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            ItemStorage storage = new ItemStorage(storageConfig);
            storage.Document = document;
            T instance = DocumentToObject<T>(storage, flatConfig);
            return instance;
        }

        /// <inheritdoc/>
        public IEnumerable<T> FromDocuments<T>(IEnumerable<Document> documents)
        {
            return FromDocuments<T>(documents, (FromDocumentConfig)null);
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromDocuments overload that takes FromDocumentConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromDocuments.")]
        public IEnumerable<T> FromDocuments<T>(IEnumerable<Document> documents, DynamoDBOperationConfig operationConfig)
        {
            foreach (var document in documents)
            {
                T item = FromDocument<T>(document, operationConfig);
                yield return item;
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> FromDocuments<T>(IEnumerable<Document> documents, FromDocumentConfig fromDocumentConfig)
        {
            foreach (var document in documents)
            {
                T item = FromDocument<T>(document, fromDocumentConfig);
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

        private void DeleteHelper<T>(object hashKey, object rangeKey, DynamoDBFlatConfig flatConfig)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey(hashKey, rangeKey, storageConfig, flatConfig);

            Table table = GetTargetTable(storageConfig, flatConfig);
            table.DeleteHelper(key, null);
        }

#if AWS_ASYNC_API 
        private Task DeleteHelperAsync<T>(object hashKey, object rangeKey, DynamoDBFlatConfig flatConfig, CancellationToken cancellationToken)
        {
            ItemStorageConfig storageConfig = StorageConfigCache.GetConfig<T>(flatConfig);
            Key key = MakeKey(hashKey, rangeKey, storageConfig, flatConfig);

            Table table = GetTargetTable(storageConfig, flatConfig);
            return table.DeleteHelperAsync(key, null, cancellationToken);
        }
#endif

        private void DeleteHelper<T>(T value, DynamoDBFlatConfig flatConfig)
        {
            if (value == null) throw new ArgumentNullException("value");

            flatConfig.IgnoreNullValues = true;
            ItemStorage storage = ObjectToItemStorage<T>(value, true, flatConfig);
            if (storage == null) return;

            Table table = GetTargetTable(storage.Config, flatConfig);
            if (flatConfig.SkipVersionCheck.Value || !storage.Config.HasVersion)
            {
                table.DeleteHelper(table.MakeKey(storage.Document), null);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                table.DeleteHelper(
                    table.MakeKey(storage.Document),
                    new DeleteItemOperationConfig { Expected = expectedDocument });
            }
        }

#if AWS_ASYNC_API

        private static readonly Task CompletedTask = Task.FromResult<object>(null);

        private Task DeleteHelperAsync<T>(T value, DynamoDBFlatConfig flatConfig, CancellationToken cancellationToken)
        {
            if (value == null) throw new ArgumentNullException("value");

            flatConfig.IgnoreNullValues = true;
            ItemStorage storage = ObjectToItemStorage(value, true, flatConfig);
            if (storage == null) return CompletedTask;

            Table table = GetTargetTable(storage.Config, flatConfig);
            if (flatConfig.SkipVersionCheck.Value || !storage.Config.HasVersion)
            {
                return table.DeleteHelperAsync(table.MakeKey(storage.Document), null, cancellationToken);
            }
            else
            {
                Document expectedDocument = CreateExpectedDocumentForVersion(storage);
                return table.DeleteHelperAsync(
                    table.MakeKey(storage.Document),
                    new DeleteItemOperationConfig { Expected = expectedDocument },
                    cancellationToken);
            }
        }
#endif

        #endregion
    }
}
