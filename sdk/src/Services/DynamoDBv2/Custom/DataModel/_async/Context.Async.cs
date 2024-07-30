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
        public Task SaveAsync<T>(T value, CancellationToken cancellationToken = default(CancellationToken))
        {
            return SaveHelperAsync(value, null, cancellationToken);
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
        public Task SaveAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return SaveHelperAsync(value, operationConfig, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Save operation.
        /// <seealso cref="Amazon.DynamoDBv2.DataModel.DynamoDBContext.Save"/>
        /// </summary>
        /// <param name="valueType">Type of the Object to save.</param>
        /// <param name="value">Object to save.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task SaveAsync(Type valueType, object value, CancellationToken cancellationToken = default(CancellationToken))
        {
            return SaveHelperAsync(valueType, value, null, cancellationToken);
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
        public Task SaveAsync(Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return SaveHelperAsync(valueType, value, operationConfig, cancellationToken);
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
        public Task<T> LoadAsync<T>(object hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return LoadHelperAsync<T>(hashKey, null, null, cancellationToken);
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
        public Task<T> LoadAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return LoadHelperAsync<T>(hashKey, null, operationConfig, cancellationToken);
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
        public Task<T> LoadAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return LoadHelperAsync<T>(hashKey, rangeKey, null, cancellationToken);
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
        public Task<T> LoadAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return LoadHelperAsync<T>(hashKey, rangeKey, operationConfig, cancellationToken);
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
        public Task<T> LoadAsync<T>(T keyObject, CancellationToken cancellationToken = default(CancellationToken))
        {
            return LoadHelperAsync(keyObject, null, cancellationToken);
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
        public Task<T> LoadAsync<T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return LoadHelperAsync(keyObject, operationConfig, cancellationToken);
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
        public Task DeleteAsync<T>(T value, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteHelperAsync(value, null, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task DeleteAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteHelperAsync(value, operationConfig, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task DeleteAsync<T>(object hashKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteHelperAsync<T>(hashKey, null, null, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task DeleteAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteHelperAsync<T>(hashKey, null, operationConfig, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Delete operation.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task DeleteAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteHelperAsync<T>(hashKey, rangeKey, null, cancellationToken);
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
        public Task DeleteAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteHelperAsync<T>(hashKey, rangeKey, operationConfig, cancellationToken);
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
        public Task ExecuteBatchGetAsync(params BatchGet[] batches)
        {
            return ExecuteBatchGetAsync(batches, default(CancellationToken));
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
        public Task ExecuteBatchGetAsync(BatchGet[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
            return superBatch.ExecuteAsync(cancellationToken);
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
        public Task ExecuteBatchWriteAsync(BatchWrite[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
            return superBatch.ExecuteAsync(cancellationToken);
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
        public Task ExecuteTransactGetAsync(TransactGet[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableTransactGet transaction = new MultiTableTransactGet(transactionParts);
            return transaction.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region TransactWrite async

        /// <summary>
        /// Issues a transactional write request with multiple TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactWrite objects.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        public Task ExecuteTransactWriteAsync(TransactWrite[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableTransactWrite transaction = new MultiTableTransactWrite(transactionParts);
            return transaction.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region Scan async

        /// <inheritdoc/>
        public AsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions)
        {
            var scan = ConvertScan<T>(conditions, null);
            return FromSearchAsync<T>(scan);
        }

        /// <inheritdoc/>
        [Obsolete("Use the ScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to ScanAsync.")]
        public AsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig = null)
        {
            var scan = ConvertScan<T>(conditions, operationConfig);
            return FromSearchAsync<T>(scan);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig)
        {
            var scan = ConvertScan<T>(conditions, scanConfig?.ToDynamoDBOperationConfig());
            return FromSearchAsync<T>(scan);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig)
        {
            if (scanConfig == null) throw new ArgumentNullException("scanConfig");

            var search = ConvertFromScan<T>(scanConfig, null);
            return FromSearchAsync<T>(search);
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromScanAsync.")]
        public AsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null)
        {
            if (scanConfig == null) throw new ArgumentNullException("scanConfig");

            var search = ConvertFromScan<T>(scanConfig, operationConfig);
            return FromSearchAsync<T>(search);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig)
        {
            if (scanConfig == null) throw new ArgumentNullException("scanConfig");

            var search = ConvertFromScan<T>(scanConfig, fromScanConfig?.ToDynamoDBOperationConfig());
            return FromSearchAsync<T>(search);
        }

        #endregion

        #region Query async

        /// <inheritdoc/>
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue)
        {
            var query = ConvertQueryByValue<T>(hashKeyValue, null, null);
            return FromSearchAsync<T>(query);
        }

        /// <inheritdoc/>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null)
        {
            var query = ConvertQueryByValue<T>(hashKeyValue, null, operationConfig);
            return FromSearchAsync<T>(query);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryConfig queryConfig)
        {
            var query = ConvertQueryByValue<T>(hashKeyValue, null, queryConfig?.ToDynamoDBOperationConfig());
            return FromSearchAsync<T>(query);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            var query = ConvertQueryByValue<T>(hashKeyValue, op, values, null);
            return FromSearchAsync<T>(query);
        }

        /// <inheritdoc/>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig = null)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            var query = ConvertQueryByValue<T>(hashKeyValue, op, values, operationConfig);
            return FromSearchAsync<T>(query);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig)
        {
            if (values == null)
                throw new ArgumentNullException("values");

            var query = ConvertQueryByValue<T>(hashKeyValue, op, values, queryConfig?.ToDynamoDBOperationConfig());
            return FromSearchAsync<T>(query);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig)
        {
            if (queryConfig == null) throw new ArgumentNullException("queryConfig");

            var search = ConvertFromQuery<T>(queryConfig, null);
            return FromSearchAsync<T>(search);
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromQueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromQueryAsync.")]
        public AsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null)
        {
            if (queryConfig == null) throw new ArgumentNullException("queryConfig");

            var search = ConvertFromQuery<T>(queryConfig, operationConfig);
            return FromSearchAsync<T>(search);
        }

        /// <inheritdoc/>
        public AsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig)
        {
            if (queryConfig == null) throw new ArgumentNullException("queryConfig");

            var search = ConvertFromQuery<T>(queryConfig, fromQueryConfig?.ToDynamoDBOperationConfig());
            return FromSearchAsync<T>(search);
        }

        #endregion
    }
}
