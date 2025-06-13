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
using System.Diagnostics.CodeAnalysis;
using ThirdParty.RuntimeBackports;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using System.Linq.Expressions;

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
        public async Task SaveAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(value, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the SaveAsync overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to SaveAsync.")]
        public async Task SaveAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(value, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task SaveAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, SaveConfig saveConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(value, new DynamoDBFlatConfig(saveConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task SaveAsync([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valueType, object value, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(valueType, value, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the SaveAsync overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to SaveAsync.")]
        public async Task SaveAsync([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(valueType, value, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task SaveAsync([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valueType, object value, SaveConfig saveConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(SaveAsync)))
            {
                await SaveHelperAsync(valueType, value, new DynamoDBFlatConfig(saveConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region Load async

        /// <inheritdoc/>
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, LoadConfig loadConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, LoadConfig loadConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T keyObject, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync(keyObject, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync(keyObject, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T keyObject, LoadConfig loadConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(LoadAsync)))
            {
                return await LoadHelperAsync(keyObject, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region Delete async

        /// <inheritdoc/>
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync(value, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync(value, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DeleteConfig deleteConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync(value, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, null, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(null, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(operationConfig, Config), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(DeleteAsync)))
            {
                await DeleteHelperAsync<T>(hashKey, rangeKey, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config), cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region BatchGet async

        /// <inheritdoc/>
        public async Task ExecuteBatchGetAsync(params IBatchGet[] batches)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchGetAsync)))
            {
                await ExecuteBatchGetAsync(batches, default(CancellationToken)).ConfigureAwait(false);
            }
        }

        /// <inheritdoc/>
        public async Task ExecuteBatchGetAsync(IBatchGet[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchGetAsync)))
            {
                MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
                await superBatch.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region BatchWrite async

        /// <inheritdoc/>
        public async Task ExecuteBatchWriteAsync(IBatchWrite[] batches, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchWriteAsync)))
            {
                MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
                await superBatch.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region TransactGet async

        /// <inheritdoc/>
        public async Task ExecuteTransactGetAsync(ITransactGet[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactGetAsync)))
            {
                MultiTableTransactGet transaction = new MultiTableTransactGet(transactionParts);
                await transaction.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region TransactWrite async

        /// <inheritdoc/>
        public async Task ExecuteTransactWriteAsync(ITransactWrite[] transactionParts, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactWriteAsync)))
            {
                MultiTableTransactWrite transaction = new MultiTableTransactWrite(transactionParts);
                await transaction.ExecuteAsync(cancellationToken).ConfigureAwait(false);
            }
        }

        #endregion

        #region Scan async

        /// <inheritdoc/>
        public IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ScanAsync)))
            {
                var scan = ConvertScan<T>(conditions, null);
                return FromSearchAsync<T>(scan);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextExpression filterExpression)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ScanAsync)))
            {
                var scan = ConvertScan<T>(filterExpression, null);
                return FromSearchAsync<T>(scan);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the ScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to ScanAsync.")]
        public IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ScanAsync)))
            {
                var scan = ConvertScan<T>(conditions, operationConfig);
                return FromSearchAsync<T>(scan);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ScanAsync)))
            {
                var scan = ConvertScan<T>(conditions, scanConfig?.ToDynamoDBOperationConfig());
                return FromSearchAsync<T>(scan);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextExpression filterExpression, ScanConfig scanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ScanAsync)))
            {
                var scan = ConvertScan<T>(filterExpression, scanConfig?.ToDynamoDBOperationConfig());
                return FromSearchAsync<T>(scan);
            }
        }


        /// <inheritdoc/>
        public IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScanAsync)))
            {
                if (scanConfig == null) throw new ArgumentNullException("scanConfig");

                var search = ConvertFromScan<T>(scanConfig, null);
                return FromSearchAsync<T>(search);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromScanAsync.")]
        public IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScanAsync)))
            {
                if (scanConfig == null) throw new ArgumentNullException("scanConfig");

                var search = ConvertFromScan<T>(scanConfig, operationConfig);
                return FromSearchAsync<T>(search);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScanAsync)))
            {
                if (scanConfig == null) throw new ArgumentNullException("scanConfig");

                var search = ConvertFromScan<T>(scanConfig, fromScanConfig?.ToDynamoDBOperationConfig());
                return FromSearchAsync<T>(search);
            }
        }

        #endregion

        #region Query async

        /// <inheritdoc/>
        public IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, null);
                return FromSearchAsync<T>(query);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
        public IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, operationConfig);
                return FromSearchAsync<T>(query);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryConfig queryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, queryConfig?.ToDynamoDBOperationConfig());
                return FromSearchAsync<T>(query);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                if (values == null)
                    throw new ArgumentNullException("values");

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, null);
                return FromSearchAsync<T>(query);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
        public IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                if (values == null)
                    throw new ArgumentNullException("values");

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, operationConfig);
                return FromSearchAsync<T>(query);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(QueryAsync)))
            {
                if (values == null)
                    throw new ArgumentNullException("values");

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, queryConfig?.ToDynamoDBOperationConfig());
                return FromSearchAsync<T>(query);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQueryAsync)))
            {
                if (queryConfig == null) throw new ArgumentNullException("queryConfig");

                var search = ConvertFromQuery<T>(queryConfig, null);
                return FromSearchAsync<T>(search);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromQueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromQueryAsync.")]
        public IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQueryAsync)))
            {
                if (queryConfig == null) throw new ArgumentNullException("queryConfig");

                var search = ConvertFromQuery<T>(queryConfig, operationConfig);
                return FromSearchAsync<T>(search);
            }
        }

        /// <inheritdoc/>
        public IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQueryAsync)))
            {
                if (queryConfig == null) throw new ArgumentNullException("queryConfig");

                var search = ConvertFromQuery<T>(queryConfig, fromQueryConfig?.ToDynamoDBOperationConfig());
                return FromSearchAsync<T>(search);
            }
        }

        #endregion
    }
}
