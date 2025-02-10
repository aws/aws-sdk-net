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
using System.Diagnostics.CodeAnalysis;

using Amazon.DynamoDBv2.DocumentModel;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Context interface for using the DataModel mode of DynamoDB.
    /// Used to interact with the service, save/load objects, etc.
    /// </summary>
    public partial interface IDynamoDBContext : IDisposable
    {
        #region Public methods
        /// <summary>
        /// Adds a <see cref="Table"/> to this context's internal cache, which
        /// will avoid the need to fetch table metadata automatically from DynamoDB.
        /// This may be used in conjunction with an <see cref="ITableBuilder"/>.
        /// </summary>
        /// <remarks>
        /// Using this method can avoid latency and thread starvation due to blocking asynchronous 
        /// IAmazonDynamoDB.DescribeTable(string) calls that are used to populate 
        /// the SDK's cache of table metadata. It requires that the table's index schema described accurately, 
        /// otherwise exceptions may be thrown and/or the results of certain DynamoDB operations may change. 
        /// </remarks>
        /// <param name="table">Table to add to the internal cache</param>
        void RegisterTableDefinition(Table table);

        #endregion

        #region Save/serialize

        /// <summary>
        /// Serializes an object to a <see cref="Document"/>.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <returns><see cref="Document"/> with attributes populated from object.</returns>
        Document ToDocument<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value);
        /// <summary>
        /// Serializes an object to a <see cref="Document"/>.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns><see cref="Document"/> with attributes populated from object.</returns>
        [Obsolete("Use the ToDocument overload that takes ToDocumentConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to ToDocument.")]
        Document ToDocument<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Serializes an object to a <see cref="Document"/>.
        /// </summary>
        /// <typeparam name="T">Type to serialize as.</typeparam>
        /// <param name="value">Object to serialize.</param>
        /// <param name="toDocumentConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns><see cref="Document"/> with attributes populated from object.</returns>
        Document ToDocument<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(T value, ToDocumentConfig toDocumentConfig);

        #endregion

        #region Load/deserialize

        /// <summary>
        /// Deserializes a <see cref="Document"/> to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document"><see cref="Document"/> with properties to use.</param>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        T FromDocument<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(Document document);

        /// <summary>
        /// Deserializes a <see cref="Document"/> to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document"><see cref="Document"/> with properties to use.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        [Obsolete("Use the FromDocument overload that takes FromDocumentConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromDocument.")]
        T FromDocument<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(Document document, DynamoDBOperationConfig operationConfig);


        /// <summary>
        /// Deserializes a <see cref="Document"/> to an instance of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="document"><see cref="Document"/> with properties to use.</param>
        /// <param name="fromDocumentConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>
        /// Object of type T, populated with properties from the document.
        /// </returns>
        T FromDocument<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(Document document, FromDocumentConfig fromDocumentConfig);

        /// <summary>
        /// Deserializes a collections of documents to a collection of instances of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="documents">Collection of <see cref="Document"/> objects to deserialize.</param>
        /// <returns>
        /// Collection of items of type T, each populated with properties from a corresponding document.
        /// </returns>
        IEnumerable<T> FromDocuments<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<Document> documents);

        /// <summary>
        /// Deserializes a collections of documents to a collection of instances of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="documents">Collection of <see cref="Document"/> objects to deserialize.</param>
        /// <param name="operationConfig">Config object which can be used to override the table used.</param>
        /// <returns>
        /// Collection of items of type T, each populated with properties from a corresponding document.
        /// </returns>
        [Obsolete("Use the FromDocuments overload that takes FromDocumentConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to FromDocuments.")]
        IEnumerable<T> FromDocuments<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<Document> documents, DynamoDBOperationConfig operationConfig);

        /// <summary>
        /// Deserializes a collections of documents to a collection of instances of type T.
        /// </summary>
        /// <typeparam name="T">Type to populate.</typeparam>
        /// <param name="documents">Collection of <see cref="Document"/> objects to deserialize.</param>
        /// <param name="fromDocumentConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>
        /// Collection of items of type T, each populated with properties from a corresponding document.
        /// </returns>
        IEnumerable<T> FromDocuments<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(IEnumerable<Document> documents, FromDocumentConfig fromDocumentConfig);

        #endregion

        #region BatchGet

        /// <summary>
        /// Creates a strongly-typed BatchGet object, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get</typeparam>
        /// <returns>Empty strongly-typed BatchGet object</returns>
        IBatchGet<T> CreateBatchGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>();

        /// <summary>
        /// Creates a strongly-typed BatchGet object, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>A BatchGet object using this context's configuration, which can be used to prepare and execute a BatchGet request</returns>
        [Obsolete("Use the CreateBatchGet overload that takes BatchGetConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchGet.")]
        IBatchGet<T> CreateBatchGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Creates a strongly-typed BatchGet object, allowing
        /// a batch-get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get</typeparam>
        /// <param name="batchGetConfig">Config object that can be used to override properties on the table's context for this request</param>
        /// <returns>A BatchGet object based on the provided <see cref="BatchGetConfig"/>, which can be used to prepare and execute a BatchGet request</returns>
        IBatchGet<T> CreateBatchGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(BatchGetConfig batchGetConfig);

        /// <summary>
        /// Creates a MultiTableBatchGet object, composed of multiple
        /// individual BatchGet objects.
        /// </summary>
        /// <param name="batches">Individual BatchGet objects</param>
        /// <returns>A MultiTableBatchGet object using this context's configuration, which can be used to prepare and execute a MultiTableBatchGet request</returns>
        IMultiTableBatchGet CreateMultiTableBatchGet(params IBatchGet[] batches);

        #endregion

        #region Batch Write

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        IBatchWrite<T> CreateBatchWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>();

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        [Obsolete("Use the CreateBatchWrite overload that takes BatchWriteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchWrite.")]
        IBatchWrite<T> CreateBatchWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBOperationConfig operationConfig = null);

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
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        IBatchWrite<object> CreateBatchWrite([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valuesType);

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
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        [Obsolete("Use the CreateBatchWrite overload that takes BatchWriteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchWrite.")]
        IBatchWrite<object> CreateBatchWrite([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valuesType, DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Creates a strongly-typed BatchWrite object, allowing
        /// a batch-write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write</typeparam>
        /// <param name="batchWriteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed BatchWrite object</returns>
        IBatchWrite<T> CreateBatchWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(BatchWriteConfig batchWriteConfig);

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
        IBatchWrite<object> CreateBatchWrite([DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type valuesType, BatchWriteConfig batchWriteConfig);

        /// <summary>
        /// Creates a MultiTableBatchWrite object, composed of multiple
        /// individual BatchWrite objects.
        /// </summary>
        /// <param name="batches">Individual BatchWrite objects</param>
        /// <returns>Composite MultiTableBatchWrite object</returns>
        IMultiTableBatchWrite CreateMultiTableBatchWrite(params IBatchWrite[] batches);

        #endregion

        #region Transact Get

        /// <summary>
        /// Creates a strongly-typed TransactGet object, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get.</typeparam>
        /// <returns>Empty strongly-typed TransactGet object.</returns>
        ITransactGet<T> CreateTransactGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>();

        /// <summary>
        /// Creates a strongly-typed TransactGet object, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get.</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed TransactGet object.</returns>
        [Obsolete("Use the CreateTransactGet overload that takes TransactGetConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to BatchGet.")]
        ITransactGet<T> CreateTransactGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Creates a strongly-typed TransactGet object, allowing
        /// a transactional get operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to get.</typeparam>
        /// <param name="transactGetConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed TransactGet object.</returns>
        ITransactGet<T> CreateTransactGet<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(TransactGetConfig transactGetConfig);

        /// <summary>
        /// Creates a MultiTableTransactGet object, composed of multiple
        /// individual TransactGet objects.
        /// </summary>
        /// <param name="transactionParts">Individual TransactGet objects.</param>
        /// <returns>Composite MultiTableTransactGet object.</returns>
        IMultiTableTransactGet CreateMultiTableTransactGet(params ITransactGet[] transactionParts);

        #endregion

        #region Transact Write

        /// <summary>
        /// Creates a strongly-typed TransactWrite object, allowing
        /// a transactional write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write.</typeparam>
        /// <returns>Empty strongly-typed TransactWrite object.</returns>
        ITransactWrite<T> CreateTransactWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>();

        /// <summary>
        /// Creates a strongly-typed TransactWrite object, allowing
        /// a transactional write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write.</typeparam>
        /// <param name="operationConfig">Config object which can be used to override that table used.</param>
        /// <returns>Empty strongly-typed TransactWrite object.</returns>
        [Obsolete("Use the CreateTransactWrite overload that takes TransactWriteConfig instead, since DynamoDBOperationConfig contains properties that are not applicable to CreateTransactWrite.")]
        ITransactWrite<T> CreateTransactWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(DynamoDBOperationConfig operationConfig = null);

        /// <summary>
        /// Creates a strongly-typed TransactWrite object, allowing
        /// a transactional write operation against DynamoDB.
        /// </summary>
        /// <typeparam name="T">Type of objects to write.</typeparam>
        /// <param name="transactWriteConfig">Config object that can be used to override properties on the table's context for this request.</param>
        /// <returns>Empty strongly-typed TransactWrite object.</returns>
        ITransactWrite<T> CreateTransactWrite<[DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] T>(TransactWriteConfig transactWriteConfig);

        /// <summary>
        /// Creates a MultiTableTransactWrite object, composed of multiple
        /// individual TransactWrite objects.
        /// </summary>
        /// <param name="transactionParts">Individual TransactWrite objects.</param>
        /// <returns>Composite MultiTableTransactWrite object.</returns>
        IMultiTableTransactWrite CreateMultiTableTransactWrite(params ITransactWrite[] transactionParts);

        #endregion
    }
}
