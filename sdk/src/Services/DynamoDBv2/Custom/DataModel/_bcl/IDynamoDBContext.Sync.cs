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
    /// <summary>
    /// Context interface for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    partial interface IDynamoDBContext
    {
        #region Save/serialize

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        void Save<T>(T value);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Config object that can be used to override properties on the table's context for this request.</param>
        [Obsolete("Use the Save overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Save.")]
        void Save<T>(T value, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="saveConfig">Config object that can be used to override properties on the table's context for this request</param>
        void Save<T>(T value, SaveConfig saveConfig);


        #endregion

        #region Load/deserialize

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
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
        T Load<T>(object hashKey);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
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
        [Obsolete("Use the Load overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Load.")]
        T Load<T>(object hashKey, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="loadConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        T Load<T>(object hashKey, LoadConfig loadConfig);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        T Load<T>(object hashKey, object rangeKey);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
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
        [Obsolete("Use the Load overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Load.")]
        T Load<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="loadConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        T Load<T>(object hashKey, object rangeKey, LoadConfig loadConfig);

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
        /// want to load.
        /// </param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        T Load<T>(T keyObject);

        /// <summary>
        /// Loads an object from DynamoDB for the given key.
        /// The keyObject is a partially-specified instance, where the
        /// hash/range properties are equal to the key of the item you
        /// want to load.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="keyObject">Key object defining the the target item.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <returns>
        /// Object of type T, populated with the properties of the item loaded from DynamoDB.
        /// </returns>
        [Obsolete("Use the Load overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Load.")]
        T Load<T>(T keyObject, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Loads an object from DynamoDB for the given key.
        /// The keyObject is a partially-specified instance, where the
        /// hash/range properties are equal to the key of the item you
        /// want to load.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="keyObject">Key object defining the the target item.</param>
        /// <param name="loadConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>
        /// Object of type T, populated with properties of item loaded from DynamoDB.
        /// </returns>
        T Load<T>(T keyObject, LoadConfig loadConfig);

        #endregion

        #region Delete

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given object.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        void Delete<T>(T value);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given object.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        [Obsolete("Use the Delete overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Delete.")]
        void Delete<T>(T value, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given object.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="value">Object to delete.</param>
        /// <param name="deleteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        void Delete<T>(T value, DeleteConfig deleteConfig);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given hash key
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        void Delete<T>(object hashKey);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given hash key
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        [Obsolete("Use the Delete overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Delete.")]
        void Delete<T>(object hashKey, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given hash key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="deleteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        void Delete<T>(object hashKey, DeleteConfig deleteConfig);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        void Delete<T>(object hashKey, object rangeKey);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        [Obsolete("Use the Delete overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Delete.")]
        void Delete<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKey">Hash key element of the object to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="deleteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        void Delete<T>(object hashKey, object rangeKey, DeleteConfig deleteConfig);

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
        void ExecuteBatchGet(params IBatchGet[] batches);

        #endregion

        #region Batch Write

        /// <summary>
        /// Issues a batch-write request with multiple batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchWrite objects
        /// </param>
        void ExecuteBatchWrite(params IBatchWrite[] batches);

        #endregion

        #region Transact Get

        /// <summary>
        /// Issues a transactional get request with multiple TransactGet objects.
        /// Results are stored in the individual TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactGet objects.</param>
        void ExecuteTransactGet(params ITransactGet[] transactionParts);

        #endregion

        #region Transact Write

        /// <summary>
        /// Issues a transactional write request with multiple TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactWrite objects.</param>
        void ExecuteTransactWrite(params ITransactWrite[] transactionParts);

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
        IEnumerable<T> Scan<T>(params ScanCondition[] conditions);

        /// <summary>
        /// Executes a Scan operation against DynamoDB,
        /// returning items that match the specified filter expression.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="filterExpression">
        /// A <see cref="ContextExpression"/> representing a LINQ expression tree used to filter the results.
        /// The expression is translated to a DynamoDB filter expression and applied server-side.
        /// </param>
        /// <returns>
        /// A lazy-loaded collection of results of type <typeparamref name="T"/> that match the filter expression.
        /// </returns>
        IEnumerable<T> Scan<T>(ContextExpression filterExpression);

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
        /// 
        [Obsolete("Use the Scan overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Scan.")]
        IEnumerable<T> Scan<T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <param name="scanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> Scan<T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig);

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified filter expression.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="filterExpression">
        /// A <see cref="ContextExpression"/> representing a LINQ expression tree used to filter the results.
        /// The expression is translated to a DynamoDB filter expression and applied server-side.
        /// </param>
        /// <param name="scanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> Scan<T>(ContextExpression filterExpression, ScanConfig scanConfig);

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <returns>Lazy-loaded collection of results.</returns>

        IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig);

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        [Obsolete("Use the FromScan overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromScan.")]
        IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Executes a Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="fromScanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> FromScan<T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig);

        #endregion

        #region Query

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> Query<T>(object hashKeyValue);

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        [Obsolete("Use the Query overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Query.")]
        IEnumerable<T> Query<T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="queryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> Query<T>(object hashKeyValue, QueryConfig queryConfig);

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
        IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, params object[] values);

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
        [Obsolete("Use the Query overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to Query.")]

        IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig);

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
        /// <param name="queryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> Query<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig);

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Query request object.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig);

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Query request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        [Obsolete("Use the FromQuery overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromQuery.")]

        IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Executes a Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Query request object.</param>
        /// <param name="fromQueryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Lazy-loaded collection of results.</returns>
        IEnumerable<T> FromQuery<T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig);

        #endregion

        #region Table methods

        /// <summary>
        /// Retrieves the target table for the specified type
        /// </summary>
        /// <typeparam name="T">Type to retrieve table for</typeparam>
        /// <returns>Table object</returns>
        ITable GetTargetTable<T>();

        /// <summary>
        /// Retrieves the target table for the specified type
        /// </summary>
        /// <typeparam name="T">Type to retrieve table for</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Table object</returns>
        [Obsolete("Use the GetTargetTable overload that takes GetTargetTableConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to GetTargetTable.")]
        ITable GetTargetTable<T>(DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Retrieves the target table for the specified type
        /// </summary>
        /// <typeparam name="T">Type to retrieve table for</typeparam>
        /// <param name="getTargetTableConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Table object</returns>
        ITable GetTargetTable<T>(GetTargetTableConfig getTargetTableConfig);

        #endregion
    }
}
