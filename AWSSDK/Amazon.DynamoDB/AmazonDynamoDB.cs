/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDB;
using Amazon.DynamoDB.Model;

namespace Amazon.DynamoDB
{
    /// <summary>
    /// Interface for accessing AmazonDynamoDB.
    ///  
    ///  <para>Amazon DynamoDB is a fast, highly scalable, highly available, cost-effective non-relational database service.</para> <para>Amazon
    /// DynamoDB removes traditional scalability limitations on data storage while maintaining low latency and predictable performance.</para>
    /// </summary>
    public interface AmazonDynamoDB : IDisposable
    {
        

        #region Scan

        /// <summary>
        /// <para>Retrieves one or more items and its attributes by performing a full scan of a table.</para> <para>Provide a <c>ScanFilter</c> to get
        /// more specific results.</para>
        /// </summary>
        /// 
        /// <param name="scanRequest">Container for the necessary parameters to execute the Scan service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        ScanResponse Scan(ScanRequest scanRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the Scan operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.Scan"/>
        /// </summary>
        /// 
        /// <param name="scanRequest">Container for the necessary parameters to execute the Scan operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScan
        ///         operation.</returns>
        IAsyncResult BeginScan(ScanRequest scanRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the Scan operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.Scan"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScan.</param>
        /// 
        /// <returns>Returns a ScanResult from AmazonDynamoDB.</returns>
        ScanResponse EndScan(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateTable

        /// <summary>
        /// <para>Adds a new table to your account.</para> <para>The table name must be unique among those associated with the AWS Account issuing the
        /// request, and the AWS Region that receives the request (e.g. <c>us-east-1</c> ).</para> <para>The <c>CreateTable</c> operation triggers an
        /// asynchronous workflow to begin creating the table. Amazon DynamoDB immediately returns the state of the table ( <c>CREATING</c> ) until the
        /// table is in the <c>ACTIVE</c> state. Once the table is in the <c>ACTIVE</c> state, you can perform data plane operations.</para>
        /// </summary>
        /// 
        /// <param name="createTableRequest">Container for the necessary parameters to execute the CreateTable service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        CreateTableResponse CreateTable(CreateTableRequest createTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.CreateTable"/>
        /// </summary>
        /// 
        /// <param name="createTableRequest">Container for the necessary parameters to execute the CreateTable operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        IAsyncResult BeginCreateTable(CreateTableRequest createTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.CreateTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a CreateTableResult from AmazonDynamoDB.</returns>
        CreateTableResponse EndCreateTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListTables

        /// <summary>
        /// <para>Retrieves a paginated list of table names created by the AWS Account of the caller in the AWS Region (e.g. <c>us-east-1</c> ).</para>
        /// </summary>
        /// 
        /// <param name="listTablesRequest">Container for the necessary parameters to execute the ListTables service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        ListTablesResponse ListTables(ListTablesRequest listTablesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.ListTables"/>
        /// </summary>
        /// 
        /// <param name="listTablesRequest">Container for the necessary parameters to execute the ListTables operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        IAsyncResult BeginListTables(ListTablesRequest listTablesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListTables operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.ListTables"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a ListTablesResult from AmazonDynamoDB.</returns>
        ListTablesResponse EndListTables(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Retrieves a paginated list of table names created by the AWS Account of the caller in the AWS Region (e.g. <c>us-east-1</c> ).</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        ListTablesResponse ListTables();
        
        #endregion
        
    

        #region Query

        /// <summary>
        /// <para>Gets the values of one or more items and its attributes by primary key (composite primary key, only).</para> <para>Narrow the scope of
        /// the query using comparison operators on the <c>RangeKeyValue</c> of the composite key. Use the <c>ScanIndexForward</c> parameter to get
        /// results in forward or reverse order by range key.</para>
        /// </summary>
        /// 
        /// <param name="queryRequest">Container for the necessary parameters to execute the Query service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        QueryResponse Query(QueryRequest queryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the Query operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.Query"/>
        /// </summary>
        /// 
        /// <param name="queryRequest">Container for the necessary parameters to execute the Query operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQuery
        ///         operation.</returns>
        IAsyncResult BeginQuery(QueryRequest queryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the Query operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.Query"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQuery.</param>
        /// 
        /// <returns>Returns a QueryResult from AmazonDynamoDB.</returns>
        QueryResponse EndQuery(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region BatchWriteItem

        /// <summary>
        /// <para>Allows to execute a batch of Put and/or Delete Requests for many tables in a single call. A total of 25 requests are allowed.</para>
        /// <para>There are no transaction guarantees provided by this API. It does not allow conditional puts nor does it support return values.</para>
        /// </summary>
        /// 
        /// <param name="batchWriteItemRequest">Container for the necessary parameters to execute the BatchWriteItem service method on
        ///          AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        BatchWriteItemResponse BatchWriteItem(BatchWriteItemRequest batchWriteItemRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchWriteItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.BatchWriteItem"/>
        /// </summary>
        /// 
        /// <param name="batchWriteItemRequest">Container for the necessary parameters to execute the BatchWriteItem operation on
        ///          AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchWriteItem
        ///         operation.</returns>
        IAsyncResult BeginBatchWriteItem(BatchWriteItemRequest batchWriteItemRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the BatchWriteItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.BatchWriteItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchWriteItem.</param>
        /// 
        /// <returns>Returns a BatchWriteItemResult from AmazonDynamoDB.</returns>
        BatchWriteItemResponse EndBatchWriteItem(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateItem

        /// <summary>
        /// <para>Edits an existing item's attributes.</para> <para>You can perform a conditional update (insert a new attribute name-value pair if it
        /// doesn't exist, or replace an existing name-value pair if it has certain expected attribute values).</para>
        /// </summary>
        /// 
        /// <param name="updateItemRequest">Container for the necessary parameters to execute the UpdateItem service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="ConditionalCheckFailedException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        UpdateItemResponse UpdateItem(UpdateItemRequest updateItemRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.UpdateItem"/>
        /// </summary>
        /// 
        /// <param name="updateItemRequest">Container for the necessary parameters to execute the UpdateItem operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        IAsyncResult BeginUpdateItem(UpdateItemRequest updateItemRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.UpdateItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateItem.</param>
        /// 
        /// <returns>Returns a UpdateItemResult from AmazonDynamoDB.</returns>
        UpdateItemResponse EndUpdateItem(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UpdateTable

        /// <summary>
        /// <para>Updates the provisioned throughput for the given table.</para> <para>Setting the throughput for a table helps you manage performance
        /// and is part of the Provisioned Throughput feature of Amazon DynamoDB.</para>
        /// </summary>
        /// 
        /// <param name="updateTableRequest">Container for the necessary parameters to execute the UpdateTable service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        UpdateTableResponse UpdateTable(UpdateTableRequest updateTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.UpdateTable"/>
        /// </summary>
        /// 
        /// <param name="updateTableRequest">Container for the necessary parameters to execute the UpdateTable operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTable
        ///         operation.</returns>
        IAsyncResult BeginUpdateTable(UpdateTableRequest updateTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.UpdateTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTable.</param>
        /// 
        /// <returns>Returns a UpdateTableResult from AmazonDynamoDB.</returns>
        UpdateTableResponse EndUpdateTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutItem

        /// <summary>
        /// <para>Creates a new item, or replaces an old item with a new item (including all the attributes).</para> <para>If an item already exists in
        /// the specified table with the same primary key, the new item completely replaces the existing item. You can perform a conditional put (insert
        /// a new item if one with the specified primary key doesn't exist), or replace an existing item if it has certain attribute values.</para>
        /// </summary>
        /// 
        /// <param name="putItemRequest">Container for the necessary parameters to execute the PutItem service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="ConditionalCheckFailedException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        PutItemResponse PutItem(PutItemRequest putItemRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.PutItem"/>
        /// </summary>
        /// 
        /// <param name="putItemRequest">Container for the necessary parameters to execute the PutItem operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutItem
        ///         operation.</returns>
        IAsyncResult BeginPutItem(PutItemRequest putItemRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.PutItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutItem.</param>
        /// 
        /// <returns>Returns a PutItemResult from AmazonDynamoDB.</returns>
        PutItemResponse EndPutItem(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteTable

        /// <summary>
        /// <para>Deletes a table and all of its items.</para> <para>If the table is in the <c>ACTIVE</c> state, you can delete it. If a table is in
        /// <c>CREATING</c> or <c>UPDATING</c> states then Amazon DynamoDB returns a <c>ResourceInUseException</c> . If the specified table does not
        /// exist, Amazon DynamoDB returns a <c>ResourceNotFoundException</c> .</para>
        /// </summary>
        /// 
        /// <param name="deleteTableRequest">Container for the necessary parameters to execute the DeleteTable service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        DeleteTableResponse DeleteTable(DeleteTableRequest deleteTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DeleteTable"/>
        /// </summary>
        /// 
        /// <param name="deleteTableRequest">Container for the necessary parameters to execute the DeleteTable operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        IAsyncResult BeginDeleteTable(DeleteTableRequest deleteTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DeleteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a DeleteTableResult from AmazonDynamoDB.</returns>
        DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteItem

        /// <summary>
        /// <para>Deletes a single item in a table by primary key.</para> <para>You can perform a conditional delete operation that deletes the item if
        /// it exists, or if it has an expected attribute value.</para>
        /// </summary>
        /// 
        /// <param name="deleteItemRequest">Container for the necessary parameters to execute the DeleteItem service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="ConditionalCheckFailedException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        DeleteItemResponse DeleteItem(DeleteItemRequest deleteItemRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DeleteItem"/>
        /// </summary>
        /// 
        /// <param name="deleteItemRequest">Container for the necessary parameters to execute the DeleteItem operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        IAsyncResult BeginDeleteItem(DeleteItemRequest deleteItemRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DeleteItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteItem.</param>
        /// 
        /// <returns>Returns a DeleteItemResult from AmazonDynamoDB.</returns>
        DeleteItemResponse EndDeleteItem(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeTable

        /// <summary>
        /// <para>Retrieves information about the table, including the current status of the table, the primary key schema and when the table was
        /// created.</para> <para>If the table does not exist, Amazon DynamoDB returns a <c>ResourceNotFoundException</c> .</para>
        /// </summary>
        /// 
        /// <param name="describeTableRequest">Container for the necessary parameters to execute the DescribeTable service method on
        ///          AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        DescribeTableResponse DescribeTable(DescribeTableRequest describeTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DescribeTable"/>
        /// </summary>
        /// 
        /// <param name="describeTableRequest">Container for the necessary parameters to execute the DescribeTable operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTable
        ///         operation.</returns>
        IAsyncResult BeginDescribeTable(DescribeTableRequest describeTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTable operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.DescribeTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTable.</param>
        /// 
        /// <returns>Returns a DescribeTableResult from AmazonDynamoDB.</returns>
        DescribeTableResponse EndDescribeTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetItem

        /// <summary>
        /// <para>Retrieves a set of Attributes for an item that matches the primary key.</para> <para>The <c>GetItem</c> operation provides an
        /// eventually-consistent read by default. If eventually-consistent reads are not acceptable for your application, use <c>ConsistentRead</c> .
        /// Although this operation might take longer than a standard read, it always returns the last updated value.</para>
        /// </summary>
        /// 
        /// <param name="getItemRequest">Container for the necessary parameters to execute the GetItem service method on AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        GetItemResponse GetItem(GetItemRequest getItemRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.GetItem"/>
        /// </summary>
        /// 
        /// <param name="getItemRequest">Container for the necessary parameters to execute the GetItem operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        IAsyncResult BeginGetItem(GetItemRequest getItemRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.GetItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetItem.</param>
        /// 
        /// <returns>Returns a GetItemResult from AmazonDynamoDB.</returns>
        GetItemResponse EndGetItem(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region BatchGetItem

        /// <summary>
        /// <para>Retrieves the attributes for multiple items from multiple tables using their primary keys.</para> <para>The maximum number of item
        /// attributes that can be retrieved for a single operation is 100. Also, the number of items retrieved is constrained by a 1 MB the size limit.
        /// If the response size limit is exceeded or a partial result is returned due to an internal processing failure, Amazon DynamoDB returns an
        /// <c>UnprocessedKeys</c> value so you can retry the operation starting with the next item to get.</para> <para>Amazon DynamoDB automatically
        /// adjusts the number of items returned per page to enforce this limit. For example, even if you ask to retrieve 100 items, but each individual
        /// item is 50k in size, the system returns 20 items and an appropriate <c>UnprocessedKeys</c> value so you can get the next page of results. If
        /// necessary, your application needs its own logic to assemble the pages of results into one set.</para>
        /// </summary>
        /// 
        /// <param name="batchGetItemRequest">Container for the necessary parameters to execute the BatchGetItem service method on
        ///          AmazonDynamoDB.</param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by AmazonDynamoDB.</returns>
        /// 
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        /// <exception cref="ResourceNotFoundException"/>
        BatchGetItemResponse BatchGetItem(BatchGetItemRequest batchGetItemRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.BatchGetItem"/>
        /// </summary>
        /// 
        /// <param name="batchGetItemRequest">Container for the necessary parameters to execute the BatchGetItem operation on AmazonDynamoDB.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetItem
        ///         operation.</returns>
        IAsyncResult BeginBatchGetItem(BatchGetItemRequest batchGetItemRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the BatchGetItem operation.
        /// <seealso cref="Amazon.DynamoDB.AmazonDynamoDB.BatchGetItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetItem.</param>
        /// 
        /// <returns>Returns a BatchGetItemResult from AmazonDynamoDB.</returns>
        BatchGetItemResponse EndBatchGetItem(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
