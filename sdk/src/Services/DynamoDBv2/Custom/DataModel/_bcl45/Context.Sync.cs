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
using System.Linq;

using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class DynamoDBContext : IDynamoDBContext
    {
        #region Save/serialize

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
        public void Save<T>(T value, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Save)))
            {
                SaveHelper<T>(value, operationConfig);
            }
        }

        #endregion

        #region Load/deserialize

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, null, null);
            }
        }

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key and using the given config.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="operationConfig">Overrides the DynamoDBContextConfig on the context object.
        /// Note that its <c>IndexName</c> <b>does not</b> influence which object is loaded. Rather 
        /// the item's primary key for the table must be specified.
        /// </param>
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, null, operationConfig);
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
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey, object rangeKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, rangeKey, null);
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
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(hashKey, rangeKey, operationConfig);
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
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        public T Load<T>(T keyObject, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Load)))
            {
                return LoadHelper<T>(keyObject, operationConfig);
            }
        }

        #endregion

        #region Delete

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
        public void Delete<T>(T value)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(value, null);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(value, operationConfig);
            }
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
        public void Delete<T>(object hashKey)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, null, null);
            }
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
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        public void Delete<T>(object hashKey, DynamoDBOperationConfig operationConfig)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, null, operationConfig);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, rangeKey, null);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Delete)))
            {
                DeleteHelper<T>(hashKey, rangeKey, operationConfig);
            }
        }

        #endregion

        #region BatchGet
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchGet)))
            {
                MultiTableBatchGet superBatch = new MultiTableBatchGet(batches);
                superBatch.Execute();
            }
        }

        #endregion

        #region Transact Get

        /// <summary>
        /// Issues a transactional get request with multiple TransactGet objects.
        /// Results are stored in the individual TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactGet objects.</param>
        public void ExecuteTransactGet(params TransactGet[] transactionParts)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactGet)))
            {
                MultiTableTransactGet transaction = new MultiTableTransactGet(transactionParts);
                transaction.Execute();
            }
        }

        #endregion

        #region Batch Write

        /// <summary>
        /// Issues a batch-write request with multiple batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchWrite objects
        /// </param>
        public void ExecuteBatchWrite(params BatchWrite[] batches)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteBatchWrite)))
            {
                MultiTableBatchWrite superBatch = new MultiTableBatchWrite(batches);
                superBatch.Execute();
            }
        }

        #endregion

        #region Transact Write

        /// <summary>
        /// Issues a transactional write request with multiple TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactWrite objects.</param>
        public void ExecuteTransactWrite(params TransactWrite[] transactionParts)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(ExecuteTransactWrite)))
            {
                MultiTableTransactWrite transaction = new MultiTableTransactWrite(transactionParts);
                transaction.Execute();
            }
        }

        #endregion

        #region Scan

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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                return Scan<T>(conditions, null);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Scan)))
            {
                var scan = ConvertScan<T>(conditions, operationConfig);
                return FromSearch<T>(scan);
            }
        }

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromScan)))
            {
                if (scanConfig == null) throw new ArgumentNullException(nameof(scanConfig));

                var search = ConvertFromScan<T>(scanConfig, operationConfig);
                return FromSearch<T>(search);
            }
        }

        #endregion

        #region Query

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        public IEnumerable<T> Query<T>(object hashKeyValue)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, null);
                return FromSearch<T>(query);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                var query = ConvertQueryByValue<T>(hashKeyValue, null, operationConfig);
                return FromSearch<T>(query);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                if (values == null || values.Length == 0)
                    throw new ArgumentOutOfRangeException(nameof(values));

                return Query<T>(hashKeyValue, op, values, null);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(Query)))
            {
                if (values == null)
                    throw new ArgumentNullException(nameof(values));

                var query = ConvertQueryByValue<T>(hashKeyValue, op, values, operationConfig);
                return FromSearch<T>(query);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQuery)))
            {
                return FromQuery<T>(queryConfig, null);
            }
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
            using (DynamoDBTelemetry.CreateSpan(this, nameof(FromQuery)))
            {
                if (queryConfig == null) throw new ArgumentNullException(nameof(queryConfig));

                var search = ConvertFromQuery<T>(queryConfig, operationConfig);
                return FromSearch<T>(search);
            }
        }

        #endregion

        #region Table methods

        /// <summary>
        /// Retrieves the target table for the specified type
        /// </summary>
        /// <typeparam name="T">Type to retrieve table for</typeparam>
        /// <returns>Table object</returns>
        public Table GetTargetTable<T>(DynamoDBOperationConfig operationConfig = null)
        {
            using (DynamoDBTelemetry.CreateSpan(this, nameof(GetTargetTable)))
            {
                return GetTargetTableInternal<T>(operationConfig);
            }
        }

        #endregion

    }
}
