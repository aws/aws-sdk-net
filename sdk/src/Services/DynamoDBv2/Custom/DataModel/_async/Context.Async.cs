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
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Context object for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Save async

        /// <inheritdoc/>
        public Task SaveAsync<T>(T value, CancellationToken cancellationToken = default)
        {
            return SaveHelperAsync(value, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the SaveAsync overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to SaveAsync.")]
        public Task SaveAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return SaveHelperAsync(value, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task SaveAsync<T>(T value, SaveConfig saveConfig, CancellationToken cancellationToken = default)
        {
            return SaveHelperAsync(value, new DynamoDBFlatConfig(saveConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task SaveAsync(Type valueType, object value, CancellationToken cancellationToken = default)
        {
            return SaveHelperAsync(valueType, value, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the SaveAsync overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to SaveAsync.")]
        public Task SaveAsync(Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return SaveHelperAsync(valueType, value, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task SaveAsync(Type valueType, object value, SaveConfig saveConfig, CancellationToken cancellationToken = default)
        {
            return SaveHelperAsync(valueType, value, new DynamoDBFlatConfig(saveConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        #endregion

        #region Load async

        /// <inheritdoc/>
        public Task<T> LoadAsync<T>(object hashKey, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        public Task<T> LoadAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<T> LoadAsync<T>(object hashKey, LoadConfig loadConfig, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<T> LoadAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        public Task<T> LoadAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<T> LoadAsync<T>(object hashKey, object rangeKey, LoadConfig loadConfig, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<T> LoadAsync<T>(T keyObject, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync(keyObject, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        public Task<T> LoadAsync<T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync(keyObject, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task<T> LoadAsync<T>(T keyObject, LoadConfig loadConfig, CancellationToken cancellationToken = default)
        {
            return LoadHelperAsync(keyObject, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        #endregion

        #region Delete async

        /// <inheritdoc/>
        public Task DeleteAsync<T>(T value, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync(value, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        public Task DeleteAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync(value, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteAsync<T>(T value, DeleteConfig deleteConfig, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync(value, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteAsync<T>(object hashKey, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        public Task DeleteAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteAsync<T>(object hashKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(null, Config), cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        public Task DeleteAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeleteAsync<T>(object hashKey, object rangeKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default)
        {
            return DeleteHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken);
        }

        #endregion

        #region BatchGet async

        /// <inheritdoc/>
        public Task ExecuteBatchGetAsync(params IBatchGet[] batches)
        {
            return ExecuteBatchGetAsync(batches, default(CancellationToken));
        }

        /// <inheritdoc/>
        public Task ExecuteBatchGetAsync(IBatchGet[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
            return superBatch.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region BatchWrite async

        /// <inheritdoc/>
        public Task ExecuteBatchWriteAsync(IBatchWrite[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
            return superBatch.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region TransactGet async

        /// <inheritdoc/>
        public Task ExecuteTransactGetAsync(ITransactGet[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            MultiTableTransactGet transaction = new MultiTableTransactGet(transactionParts);
            return transaction.ExecuteAsync(cancellationToken);
        }

        #endregion

        #region TransactWrite async

        /// <inheritdoc/>
        public Task ExecuteTransactWriteAsync(ITransactWrite[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
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
