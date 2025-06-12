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
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Context interface for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    partial interface IDynamoDBContext
    {
        #region Save async

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task SaveAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the SaveAsync overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to SaveAsync.")]
        Task SaveAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to save as.</typeparam>
        /// <param name="value">Object to save.</param>
        /// <param name="saveConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task SaveAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, SaveConfig saveConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <param name="valueType">Type of the Object to save.</param>
        /// <param name="value">Object to save.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task SaveAsync([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valueType, object value, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <param name="valueType">Type of the Object to save.</param>
        /// <param name="value">Object to save.</param>
        /// <param name="operationConfig">Overriding configuration.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the SaveAsync overload that takes SaveConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to SaveAsync.")]
        Task SaveAsync([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves an object to DynamoDB.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <param name="valueType">Type of the Object to save.</param>
        /// <param name="value">Object to save.</param>
        /// <param name="saveConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task SaveAsync([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valueType, object value, SaveConfig saveConfig, CancellationToken cancellationToken = default);

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
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
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
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash key.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="loadConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, LoadConfig loadConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default);

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
        /// <param name="operationConfig">Overrides the DynamoDBContextConfig on the context object.
        /// Note that its <c>IndexName</c> <b>does not</b> influence which object is loaded. Rather 
        /// the item's primary key for the table must be specified.
        /// </param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads an object from DynamoDB for the given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="hashKey">Hash key element of the target item.</param>
        /// <param name="rangeKey">Range key element of the target item.</param>
        /// <param name="loadConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, LoadConfig loadConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads an object from DynamoDB for the given key.
        /// The keyObject is a partially-specified instance, where the
        /// hash/range properties are equal to the key of the item you
        /// want to load.
        /// </summary>
        /// <remarks>
        /// This invokes DynamoDB's GetItem operation, which returns an item with the given primary key.
        /// </remarks>
        /// <typeparam name="T">Type to populate. It must be marked up with DynamoDBTableAttribute and at least
        /// one public field/property with DynamoDBHashKeyAttribute.</typeparam>
        /// <param name="keyObject">Key of the target item.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>Object of type T, populated with the properties of the item loaded from DynamoDB.</returns>
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T keyObject, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads an object from DynamoDB for the given key.
        /// The keyObject is a partially-specified instance, where the
        /// hash/range properties are equal to the key of the item you
        /// want to load.
        /// 
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
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
        [Obsolete("Use the LoadAsync overload that takes LoadConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to LoadAsync.")]
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

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
        /// <param name="keyObject">Key of the target item.</param>
        /// <param name="loadConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task<T> LoadAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T keyObject, LoadConfig loadConfig, CancellationToken cancellationToken = default);

        #endregion

        #region Delete async

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, CancellationToken cancellationToken = default);

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to the given hash key.
        /// </summary>
        /// <typeparam name="T">
        /// The type representing the item stored in DynamoDB. It must be resolvable via table metadata, 
        /// either from attributes or via configuration.
        /// </typeparam>
        /// <param name="hashKey">The value of the hash (partition) key identifying the item to delete.</param>
        /// <param name="cancellationToken">Token that can be used to cancel the operation.</param>
        /// <returns>A <see cref="Task"/> that can be awaited for operation completion.</returns>
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given hash key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">
        /// The type representing the item stored in DynamoDB. It must be resolvable via table metadata, 
        /// either from attributes or via configuration.
        /// </typeparam>
        /// <param name="hashKey">The value of the hash (partition) key identifying the item to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to given hash key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">
        /// The type representing the item stored in DynamoDB. It must be resolvable via table metadata, 
        /// either from attributes or via configuration.
        /// </typeparam>
        /// <param name="hashKey">The value of the hash (partition) key identifying the item to delete.</param>
        /// <param name="deleteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">
        /// The type representing the item stored in DynamoDB. It must be resolvable via table metadata, 
        /// either from attributes or via configuration.
        /// </typeparam>
        /// <param name="hashKey">The value of the hash (partition) key identifying the item to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">
        /// The type representing the item stored in DynamoDB. It must be resolvable via table metadata, 
        /// either from attributes or via configuration.
        /// </typeparam>
        /// <param name="hashKey">The value of the hash (partition) key identifying the item to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an item in DynamoDB corresponding to a given hash-and-range primary key.
        /// </summary>
        /// <remarks>
        /// If SkipVersionCheck if false, it will check the version of object before deleting.
        /// The type must be marked up with <see cref="DynamoDBTableAttribute" /> and at least
        /// one public field/property with <see cref="DynamoDBHashKeyAttribute" />.
        /// </remarks>
        /// <typeparam name="T">
        /// The type representing the item stored in DynamoDB. It must be resolvable via table metadata, 
        /// either from attributes or via configuration.
        /// </typeparam>
        /// <param name="hashKey">The value of the hash (partition) key identifying the item to delete.</param>
        /// <param name="rangeKey">Range key element of the object to delete.</param>
        /// <param name="deleteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task DeleteAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKey, object rangeKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);

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
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteBatchGetAsync(params IBatchGet[] batches);

        /// <summary>
        /// Issues a batch-get request with multiple batches.
        /// 
        /// Results are stored in the individual batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchGet objects
        /// </param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteBatchGetAsync(IBatchGet[] batches, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region BatchWrite async

        /// <summary>
        /// Issues a batch-write request with multiple batches.
        /// </summary>
        /// <param name="batches">
        /// Configured BatchWrite objects
        /// </param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteBatchWriteAsync(IBatchWrite[] batches, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region TransactGet async

        /// <summary>
        /// Issues a transactional get request with multiple TransactGet objects.
        /// Results are stored in the individual TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactGet objects.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteTransactGetAsync(ITransactGet[] transactionParts, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region TransactWrite async

        /// <summary>
        /// Issues a transactional write request with multiple TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Configured TransactWrite objects.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        Task ExecuteTransactWriteAsync(ITransactWrite[] transactionParts, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region Scan async

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions);

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified filter expression.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="filterExpression">
        /// A <see cref="ContextExpression"/> representing a LINQ expression tree used to filter the results.
        /// The expression is translated to a DynamoDB filter expression and applied server-side.
        /// </param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextExpression filterExpression);

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>

        [Obsolete("Use the ScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to ScanAsync.")]
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="conditions">
        /// Conditions that the results should meet.
        /// </param>
        /// <param name="scanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig);

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="filterExpression">
        /// A <see cref="ContextExpression"/> representing a LINQ expression tree used to filter the results.
        /// The expression is translated to a DynamoDB filter expression and applied server-side.
        /// </param>
        /// <param name="scanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ContextExpression filterExpression, ScanConfig scanConfig);


        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig);

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the FromScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromScanAsync.")]
        IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        ///  Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="fromScanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig);

        #endregion

        #region Query async

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue);

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="queryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryConfig queryConfig);

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
        /// For QueryOperator.Betwee, values should be two values.
        /// </param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values);

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
        /// For QueryOperator.Betwee, values should be two values.
        /// </param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig = null);

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
        /// <param name="queryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig);

        /// <summary>
        /// Configures an async Query operation against DynamoDB using a mid-level document model 
        /// query configuration, finding items that match the specified conditions. 
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Mid-level, document model query request object.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig);

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Mid-level, document model query request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the FromQueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromQueryAsync.")]
        IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Configures an async Query operation against DynamoDB using a mid-level document model 
        /// query configration, finding items that match the specified conditions. 
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Mid-level, document model query request object.</param>
        /// <param name="fromQueryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig);

        #endregion
    }
}
