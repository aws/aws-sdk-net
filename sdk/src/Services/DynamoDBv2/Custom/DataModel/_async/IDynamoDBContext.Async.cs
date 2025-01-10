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
using System.Threading;
using System.Threading.Tasks;
using Amazon.DynamoDBv2.DocumentModel;

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
#if NET8_0_OR_GREATER
        Task SaveAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T value, CancellationToken cancellationToken = default);
#else
        Task SaveAsync<T>(T value, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task SaveAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task SaveAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task SaveAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T value, SaveConfig saveConfig, CancellationToken cancellationToken = default);
#else
        Task SaveAsync<T>(T value, SaveConfig saveConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task SaveAsync([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type valueType, object value, CancellationToken cancellationToken = default);
#else
        Task SaveAsync(Type valueType, object value, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task SaveAsync([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task SaveAsync(Type valueType, object value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task SaveAsync([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] Type valueType, object value, SaveConfig saveConfig, CancellationToken cancellationToken = default);
#else
        Task SaveAsync(Type valueType, object value, SaveConfig saveConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(object hashKey, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, LoadConfig loadConfig, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(object hashKey, LoadConfig loadConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, object rangeKey, LoadConfig loadConfig, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(object hashKey, object rangeKey, LoadConfig loadConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T keyObject, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(T keyObject, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(T keyObject, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task<T> LoadAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T keyObject, LoadConfig loadConfig, CancellationToken cancellationToken = default);
#else
        Task<T> LoadAsync<T>(T keyObject, LoadConfig loadConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T value, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(T value, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(T value, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(T value, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(T value, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);
#endif

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(object hashKey, CancellationToken cancellationToken = default);
#endif

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
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(object hashKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(object hashKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);
#endif

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(object hashKey, object rangeKey, CancellationToken cancellationToken = default);
#endif

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
        [Obsolete("Use the DeleteAsync overload that takes DeleteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to DeleteAsync.")]
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(object hashKey, object rangeKey, DynamoDBOperationConfig operationConfig, CancellationToken cancellationToken = default);
#endif

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
        /// <param name="cancellationToken">Token which can be used to cancel the task.</param>
        /// <returns>A Task that can be used to poll or wait for results, or both.</returns>
#if NET8_0_OR_GREATER
        Task DeleteAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKey, object rangeKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);
#else
        Task DeleteAsync<T>(object hashKey, object rangeKey, DeleteConfig deleteConfig, CancellationToken cancellationToken = default);
#endif

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
#if NET8_0_OR_GREATER
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(IEnumerable<ScanCondition> conditions);
#else
        IAsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions);
#endif

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
#if NET8_0_OR_GREATER
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig = null);
#else
        IAsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions, DynamoDBOperationConfig operationConfig = null);
#endif

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
#if NET8_0_OR_GREATER
        IAsyncSearch<T> ScanAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig);
#else
        IAsyncSearch<T> ScanAsync<T>(IEnumerable<ScanCondition> conditions, ScanConfig scanConfig);
#endif

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(ScanOperationConfig scanConfig);
#else
        IAsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig);
#endif

        /// <summary>
        /// Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the FromScanAsync overload that takes ScanConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromScanAsync.")]
#if NET8_0_OR_GREATER
        IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null);
#else
        IAsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig, DynamoDBOperationConfig operationConfig = null);
#endif

        /// <summary>
        ///  Configures an async Scan operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="scanConfig">Scan request object.</param>
        /// <param name="fromScanConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> FromScanAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig);
#else
        IAsyncSearch<T> FromScanAsync<T>(ScanOperationConfig scanConfig, FromScanConfig fromScanConfig);
#endif

        #endregion

        #region Query async

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKeyValue);
#else
        IAsyncSearch<T> QueryAsync<T>(object hashKeyValue);
#endif

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the QueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to QueryAsync.")]
#if NET8_0_OR_GREATER
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null);
#else
        IAsyncSearch<T> QueryAsync<T>(object hashKeyValue, DynamoDBOperationConfig operationConfig = null);
#endif

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified hash primary key.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="hashKeyValue">Hash key of the items to query.</param>
        /// <param name="queryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKeyValue, QueryConfig queryConfig);
#else
        IAsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryConfig queryConfig);
#endif

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
#if NET8_0_OR_GREATER
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values);
#else
        IAsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values);
#endif

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
#if NET8_0_OR_GREATER
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig = null);
#else
        IAsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, DynamoDBOperationConfig operationConfig = null);
#endif

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
        /// <param name="queryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> QueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig);
#else
        IAsyncSearch<T> QueryAsync<T>(object hashKeyValue, QueryOperator op, IEnumerable<object> values, QueryConfig queryConfig);
#endif

        /// <summary>
        /// Configures an async Query operation against DynamoDB using a mid-level document model 
        /// query configration, finding items that match the specified conditions. 
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Mid-level, document model query request object.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(QueryOperationConfig queryConfig);
#else
        IAsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig);
#endif

        /// <summary>
        /// Configures an async Query operation against DynamoDB, finding items
        /// that match the specified conditions.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Mid-level, document model query request object.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
        [Obsolete("Use the FromQueryAsync overload that takes QueryConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromQueryAsync.")]
#if NET8_0_OR_GREATER
        IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null);
#else
        IAsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig, DynamoDBOperationConfig operationConfig = null);
#endif

        /// <summary>
        /// Configures an async Query operation against DynamoDB using a mid-level document model 
        /// query configration, finding items that match the specified conditions. 
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="queryConfig">Mid-level, document model query request object.</param>
        /// <param name="fromQueryConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>AsyncSearch which can be used to retrieve DynamoDB data.</returns>
#if NET8_0_OR_GREATER
        IAsyncSearch<T> FromQueryAsync<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)] T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig);
#else
        IAsyncSearch<T> FromQueryAsync<T>(QueryOperationConfig queryConfig, FromQueryConfig fromQueryConfig);
#endif

        #endregion
    }
}
