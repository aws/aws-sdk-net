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
#pragma warning disable 1574

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Context object for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Save async

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task SaveAsync<T>(T value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(value, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task SaveAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(value, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <param name="valueType">Type of the Object to save.</param>
        /// <param name="value">Object to save.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task SaveAsync(Type valueType, object value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(valueType, value, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <param name="valueType">Type of the Object to save.</param>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task SaveAsync(Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(valueType, value, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region Load async

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        public async Task<T> LoadAsync<T>(object hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, null, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key and using the given config.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="operationConfig">Overrides the DynamoDBContextConfig on the context object.
        /// Note that its <c>IndexName</c> <b>does not</b> influence which object is loaded. Rather 
        /// the item's primary key for the table must be specified.
        /// </param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        public async Task<T> LoadAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, null, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        public async Task<T> LoadAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, rangeKey, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key and using the given config.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="operationConfig">Overrides the DynamoDBContextConfig on the context object.
        /// Note that its <c>IndexName</c> <b>does not</b> influence which object is loaded. Rather 
        /// the item's primary key for the table must be specified.
        /// </param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        public async Task<T> LoadAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, rangeKey, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given key.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="keyObject">A partially-specified instance, where the
        /// hash/range properties are equal to the key of the item you
        /// want to load.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        public async Task<T> LoadAsync<T>(T keyObject, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync(keyObject, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given key and using the given config.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="keyObject">A partially-specified instance, where the
        /// hash/range properties are equal to the key of the item you
        /// want to load.</param>
        /// <param name="operationConfig">Overrides the DynamoDBContextConfig on the context object.
        /// Note that its <c>IndexName</c> <b>does not</b> influence which object is loaded. Rather 
        /// the item's primary key for the table must be specified.
        /// </param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        public async Task<T> LoadAsync<T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync(keyObject, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region Delete async

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task DeleteAsync<T>(T value, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync(value, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task DeleteAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync(value, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task DeleteAsync<T>(object hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, null, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task DeleteAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, null, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task DeleteAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, rangeKey, null, cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task DeleteAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, rangeKey, operationConfig, cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region BatchGet async

        /// <summary>
        /// Issues a batch-get request with multiple batches.
        /// 
        /// Results are stored in the individual batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchGet objects
        /// </param>
        public async Task ExecuteBatchGetAsync(params BatchGet[] batches)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchGetAsync)))
            {
                await ExecuteBatchGetAsync(batches, default(CancellationToken)).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a batch-get request with multiple batches.
        /// 
        /// Results are stored in the individual batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchGet objects
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        public async Task ExecuteBatchGetAsync(BatchGet[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchGetAsync)))
            {
                MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
                await superBatch.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region BatchWrite async

        /// <summary>
        /// Issues a batch-write request with multiple batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchWrite objects
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        public async Task ExecuteBatchWriteAsync(BatchWrite[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchWriteAsync)))
            {
                MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
                await superBatch.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region TransactGet async

        /// <summary>
        /// Issues a transactional get request with multiple TransactGet objects.
        /// Results are stored in the individual TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactGet objects.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task ExecuteTransactGetAsync(TransactGet[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactGetAsync)))
            {
                MultiTableTransactGet transaction = new MultiTableTransactGet(transactionParts);
                await transaction.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region TransactWrite async

        /// <summary>
        /// Issues a transactional write request with multiple TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactWrite objects.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public async Task ExecuteTransactWriteAsync(TransactWrite[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactWriteAsync)))
            {
                MultiTableTransactWrite transaction = new MultiTableTransactWrite(transactionParts);
                await transaction.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region Scan async

        /// <summary>
        ///  Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        public AsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ScanAsync)))
            {
                var scan = ConvertScan<T>(conditions, operationConfig);
                return FromSearchAsync<T>(scan);
            }
        }

        /// <summary>
        ///  Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        public AsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScanAsync)))
            {
                if (scanConfig == null) throw new ArgumentNullException(nameof(scanConfig));

                var search = ConvertFromScan<T>(scanConfig, operationConfig);
                return FromSearchAsync<T>(search);
            }
        }

        #endregion

        #region Query async

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, operationConfig);
                return FromSearchAsync<T>(query);
            }
        }

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified range element condition for a hash-and-range primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="op">Operation of the condition.</param>
        /// <param name="values">
        /// Value(s) of the condition.
        /// For all operations except QueryOperator.Between, values should be one value.
        /// For QueryOperator.Between, values should be two values.
        /// </param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                if (values == null)
                    throw new ArgumentNullException(nameof(values));

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, operationConfig);
                return FromSearchAsync<T>(query);
            }
        }

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Query request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        public AsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQueryAsync)))
            {
                if (queryConfig == null) throw new ArgumentNullException(nameof(queryConfig));

                var search = ConvertFromQuery<T>(queryConfig, operationConfig);
                return FromSearchAsync<T>(search);
            }
        }

        #endregion
    }
}
