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
using System.Linq.Expressions;
using Amazon.DynamoDBv2.DocumentModel;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Save/serialize

        /// <inheritdoc/>
        public void Save<T>(T value)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Save)))
            {
                SaveHelper<T>(value, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Save overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Save.")]
        public void Save<T>(T value, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Save)))
            {
                SaveHelper<T>(value, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public void Save<T>(T value, SaveConfig saveConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Save)))
            {
                SaveHelper<T>(value, new DynamoDBFlatConfig(saveConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        #endregion

        #region Load/deserialize

        /// <inheritdoc/>
        public T Load<T>(object hashKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, null, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Load overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Load.")]
        public T Load<T>(object hashKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, null, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public T Load<T>(object hashKey, LoadConfig loadConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, null, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        /// <inheritdoc/>
        public T Load<T>(object hashKey, object rangeKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, rangeKey, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Load overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Load.")]
        public T Load<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, rangeKey, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public T Load<T>(object hashKey, object rangeKey, LoadConfig loadConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, rangeKey, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        /// <inheritdoc/>
        public T Load<T>(T keyObject)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(keyObject, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Load overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Load.")]
        public T Load<T>(T keyObject, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(keyObject, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public T Load<T>(T keyObject, LoadConfig loadConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(keyObject, new DynamoDBFlatConfig(loadConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        #endregion

        #region Delete

        /// <inheritdoc/>
        public void Delete<T>(T value)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(value, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Delete overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Delete.")]
        public void Delete<T>(T value, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(value, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public void Delete<T>(T value, DeleteConfig deleteConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(value, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        /// <inheritdoc/>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        public void Delete<T>(object hashKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, null, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Delete overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Delete.")]
        public void Delete<T>(object hashKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, null, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public void Delete<T>(object hashKey, DeleteConfig deleteConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, null, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        /// <inheritdoc/>
        public void Delete<T>(object hashKey, object rangeKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, rangeKey, new DynamoDBFlatConfig(null, Config));
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Delete overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Delete.")]
        public void Delete<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, rangeKey, new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public void Delete<T>(object hashKey, object rangeKey, DeleteConfig deleteConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, rangeKey, new DynamoDBFlatConfig(deleteConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        #endregion

        #region BatchGet
        /// <inheritdoc/>
        public void ExecuteBatchGet(params IBatchGet[] batches)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchGet)))
            {
                MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
                superBatch.Execute();
            }
        }

        #endregion

        #region Transact Get

        /// <inheritdoc/>
        public void ExecuteTransactGet(params ITransactGet[] transactionParts)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactGet)))
            {
                MultiTableTransactGet transaction = new MultiTableTransactGet(transactionParts);
                transaction.Execute();
            }
        }

        #endregion

        #region Batch Write

        /// <inheritdoc/>
        public void ExecuteBatchWrite(params IBatchWrite[] batches)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchWrite)))
            {
                MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
                superBatch.Execute();
            }
        }

        #endregion

        #region Transact Write

        /// <inheritdoc/>
        public void ExecuteTransactWrite(params ITransactWrite[] transactionParts)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactWrite)))
            {
                MultiTableTransactWrite transaction = new MultiTableTransactWrite(transactionParts);
                transaction.Execute();
            }
        }

        #endregion

        #region Scan

        /// <inheritdoc/>
        public IEnumerable<T> Scan<T>(params ScanCondition[] conditions)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                return Scan<T>(conditions, (ScanConfig)null);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> Scan<T>(ContextExpression filterExpression)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                var scan = ConvertScan<T>(filterExpression, null);
                return FromSearch<T>(scan);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Scan overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Scan.")]
        public IEnumerable<T> Scan<T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                var scan = ConvertScan<T>(conditions, operationConfig);
                return FromSearch<T>(scan);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> Scan<T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                var scan = ConvertScan<T>(conditions, scanConfig?.ToDynamoDBOperationConfig());
                return FromSearch<T>(scan);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> Scan<T>(ContextExpression filterExpression, ScanConfig scanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                var scan = ConvertScan<T>(filterExpression, scanConfig?.ToDynamoDBOperationConfig());
                return FromSearch<T>(scan);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScan)))
            {
                if (scanConfig == null) throw new ArgumentNullException(nameof(scanConfig));

                var search = ConvertFromScan<T>(scanConfig, null);
                return FromSearch<T>(search);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromScan overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromScan.")]
        public IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScan)))
            {
                if (scanConfig == null) throw new ArgumentNullException(nameof(scanConfig));

                var search = ConvertFromScan<T>(scanConfig, operationConfig);
                return FromSearch<T>(search);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScan)))
            {
                if (scanConfig == null) throw new ArgumentNullException(nameof(scanConfig));

                var search = ConvertFromScan<T>(scanConfig, fromScanConfig?.ToDynamoDBOperationConfig());
                return FromSearch<T>(search);
            }
        }

        #endregion

        #region Query

        /// <inheritdoc/>
        public IEnumerable<T> Query<T>(object hashKeyValue)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, null);
                return FromSearch<T>(query);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Query overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Query.")]
        public IEnumerable<T> Query<T>(object hashKeyValue, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, operationConfig);
                return FromSearch<T>(query);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> Query<T>(object hashKeyValue, QueryConfig queryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, queryConfig?.ToDynamoDBOperationConfig());
                return FromSearch<T>(query);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, params object[] values)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                if (values == null || values.Length == 0)
                    throw new ArgumentOutOfRangeException(nameof(values));

                return Query<T>(hashKeyValue, op, values, (QueryConfig)null);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the Query overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Query.")]
        public IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                if (values == null)
                    throw new ArgumentNullException(nameof(values));

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, operationConfig);
                return FromSearch<T>(query);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                if (values == null)
                    throw new ArgumentNullException(nameof(values));

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, queryConfig?.ToDynamoDBOperationConfig());
                return FromSearch<T>(query);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQuery)))
            {
                return FromQuery<T>(queryConfig, (FromQueryConfig)null);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the FromQuery overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromQuery.")]
        public IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQuery)))
            {
                if (queryConfig == null) throw new ArgumentNullException(nameof(queryConfig));

                var search = ConvertFromQuery<T>(queryConfig, operationConfig);
                return FromSearch<T>(search);
            }
        }

        /// <inheritdoc/>
        public IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQuery)))
            {
                if (queryConfig == null) throw new ArgumentNullException(nameof(queryConfig));

                var search = ConvertFromQuery<T>(queryConfig, fromQueryConfig?.ToDynamoDBOperationConfig());
                return FromSearch<T>(search);
            }
        }

        #endregion

        #region Table methods

        /// <inheritdoc/>
        public ITable GetTargetTable<T>()
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(GetTargetTable)))
            {
                return GetTargetTable<T>((GetTargetTableConfig)null);
            }
        }

        /// <inheritdoc/>
        [Obsolete("Use the GetTargetTable overload that takes GetTargetTableConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to GetTargetTable.")]
        public ITable GetTargetTable<T>(DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(GetTargetTable)))
            {
                return GetTargetTableInternal<T>(new DynamoDBFlatConfig(operationConfig, Config));
            }
        }

        /// <inheritdoc/>
        public ITable GetTargetTable<T>(GetTargetTableConfig getTargetTableConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(GetTargetTable)))
            {
                return GetTargetTableInternal<T>(new DynamoDBFlatConfig(getTargetTableConfig?.ToDynamoDBOperationConfig(), Config));
            }
        }

        #endregion

    }
}
