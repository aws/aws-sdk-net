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

/*
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Honeycode.Model;

namespace Amazon.Honeycode
{
    /// <summary>
    /// Interface for accessing Honeycode
    ///
    /// Amazon Honeycode is a fully managed service that allows you to quickly build mobile
    /// and web apps for teams—without programming. Build Honeycode apps for managing almost
    /// anything, like projects, customers, operations, approvals, resources, and even your
    /// team.
    /// </summary>
    public partial interface IAmazonHoneycode : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IHoneycodePaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateTableRows


        /// <summary>
        /// The BatchCreateTableRows API allows you to create one or more rows at the end of
        /// a table in a workbook. The API allows you to specify the values to set in some or
        /// all of the columns in the new rows. 
        /// 
        ///  
        /// <para>
        ///  If a column is not explicitly set in a specific row, then the column level formula
        /// specified in the table will be applied to the new row. If there is no column level
        /// formula but the last row of the table has a formula, then that formula will be copied
        /// down to the new row. If there is no column level formula and no formula in the last
        /// row of the table, then that column will be left blank for the new rows. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchCreateTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceQuotaExceededException">
        /// The request caused service quota to be breached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchCreateTableRows">REST API Reference for BatchCreateTableRows Operation</seealso>
        BatchCreateTableRowsResponse BatchCreateTableRows(BatchCreateTableRowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchCreateTableRows">REST API Reference for BatchCreateTableRows Operation</seealso>
        IAsyncResult BeginBatchCreateTableRows(BatchCreateTableRowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateTableRows.</param>
        /// 
        /// <returns>Returns a  BatchCreateTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchCreateTableRows">REST API Reference for BatchCreateTableRows Operation</seealso>
        BatchCreateTableRowsResponse EndBatchCreateTableRows(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteTableRows


        /// <summary>
        /// The BatchDeleteTableRows API allows you to delete one or more rows from a table in
        /// a workbook. You need to specify the ids of the rows that you want to delete from the
        /// table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchDeleteTableRows">REST API Reference for BatchDeleteTableRows Operation</seealso>
        BatchDeleteTableRowsResponse BatchDeleteTableRows(BatchDeleteTableRowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchDeleteTableRows">REST API Reference for BatchDeleteTableRows Operation</seealso>
        IAsyncResult BeginBatchDeleteTableRows(BatchDeleteTableRowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteTableRows.</param>
        /// 
        /// <returns>Returns a  BatchDeleteTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchDeleteTableRows">REST API Reference for BatchDeleteTableRows Operation</seealso>
        BatchDeleteTableRowsResponse EndBatchDeleteTableRows(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateTableRows


        /// <summary>
        /// The BatchUpdateTableRows API allows you to update one or more rows in a table in
        /// a workbook. 
        /// 
        ///  
        /// <para>
        ///  You can specify the values to set in some or all of the columns in the table for
        /// the specified rows. If a column is not explicitly specified in a particular row, then
        /// that column will not be updated for that row. To clear out the data in a specific
        /// cell, you need to set the value as an empty string (""). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpdateTableRows">REST API Reference for BatchUpdateTableRows Operation</seealso>
        BatchUpdateTableRowsResponse BatchUpdateTableRows(BatchUpdateTableRowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpdateTableRows">REST API Reference for BatchUpdateTableRows Operation</seealso>
        IAsyncResult BeginBatchUpdateTableRows(BatchUpdateTableRowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateTableRows.</param>
        /// 
        /// <returns>Returns a  BatchUpdateTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpdateTableRows">REST API Reference for BatchUpdateTableRows Operation</seealso>
        BatchUpdateTableRowsResponse EndBatchUpdateTableRows(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpsertTableRows


        /// <summary>
        /// The BatchUpsertTableRows API allows you to upsert one or more rows in a table. The
        /// upsert operation takes a filter expression as input and evaluates it to find matching
        /// rows on the destination table. If matching rows are found, it will update the cells
        /// in the matching rows to new values specified in the request. If no matching rows are
        /// found, a new row is added at the end of the table and the cells in that row are set
        /// to the new values specified in the request. 
        /// 
        ///  
        /// <para>
        ///  You can specify the values to set in some or all of the columns in the table for
        /// the matching or newly appended rows. If a column is not explicitly specified for a
        /// particular row, then that column will not be updated for that row. To clear out the
        /// data in a specific cell, you need to set the value as an empty string (""). 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpsertTableRows service method.</param>
        /// 
        /// <returns>The response from the BatchUpsertTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceQuotaExceededException">
        /// The request caused service quota to be breached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpsertTableRows">REST API Reference for BatchUpsertTableRows Operation</seealso>
        BatchUpsertTableRowsResponse BatchUpsertTableRows(BatchUpsertTableRowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpsertTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpsertTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpsertTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpsertTableRows">REST API Reference for BatchUpsertTableRows Operation</seealso>
        IAsyncResult BeginBatchUpsertTableRows(BatchUpsertTableRowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpsertTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpsertTableRows.</param>
        /// 
        /// <returns>Returns a  BatchUpsertTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/BatchUpsertTableRows">REST API Reference for BatchUpsertTableRows Operation</seealso>
        BatchUpsertTableRowsResponse EndBatchUpsertTableRows(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTableDataImportJob


        /// <summary>
        /// The DescribeTableDataImportJob API allows you to retrieve the status and details
        /// of a table data import job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableDataImportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTableDataImportJob service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/DescribeTableDataImportJob">REST API Reference for DescribeTableDataImportJob Operation</seealso>
        DescribeTableDataImportJobResponse DescribeTableDataImportJob(DescribeTableDataImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableDataImportJob operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTableDataImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/DescribeTableDataImportJob">REST API Reference for DescribeTableDataImportJob Operation</seealso>
        IAsyncResult BeginDescribeTableDataImportJob(DescribeTableDataImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTableDataImportJob.</param>
        /// 
        /// <returns>Returns a  DescribeTableDataImportJobResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/DescribeTableDataImportJob">REST API Reference for DescribeTableDataImportJob Operation</seealso>
        DescribeTableDataImportJobResponse EndDescribeTableDataImportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetScreenData


        /// <summary>
        /// The GetScreenData API allows retrieval of data from a screen in a Honeycode app.
        /// The API allows setting local variables in the screen to filter, sort or otherwise
        /// affect what will be displayed on the screen.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScreenData service method.</param>
        /// 
        /// <returns>The response from the GetScreenData service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        GetScreenDataResponse GetScreenData(GetScreenDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetScreenData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScreenData operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScreenData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        IAsyncResult BeginGetScreenData(GetScreenDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetScreenData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScreenData.</param>
        /// 
        /// <returns>Returns a  GetScreenDataResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/GetScreenData">REST API Reference for GetScreenData Operation</seealso>
        GetScreenDataResponse EndGetScreenData(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeScreenAutomation


        /// <summary>
        /// The InvokeScreenAutomation API allows invoking an action defined in a screen in a
        /// Honeycode app. The API allows setting local variables, which can then be used in the
        /// automation being invoked. This allows automating the Honeycode app interactions to
        /// write, update or delete data in the workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeScreenAutomation service method.</param>
        /// 
        /// <returns>The response from the InvokeScreenAutomation service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.AutomationExecutionException">
        /// The automation execution did not end successfully.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.AutomationExecutionTimeoutException">
        /// The automation execution timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        InvokeScreenAutomationResponse InvokeScreenAutomation(InvokeScreenAutomationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeScreenAutomation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeScreenAutomation operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeScreenAutomation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        IAsyncResult BeginInvokeScreenAutomation(InvokeScreenAutomationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeScreenAutomation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeScreenAutomation.</param>
        /// 
        /// <returns>Returns a  InvokeScreenAutomationResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/InvokeScreenAutomation">REST API Reference for InvokeScreenAutomation Operation</seealso>
        InvokeScreenAutomationResponse EndInvokeScreenAutomation(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTableColumns


        /// <summary>
        /// The ListTableColumns API allows you to retrieve a list of all the columns in a table
        /// in a workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableColumns service method.</param>
        /// 
        /// <returns>The response from the ListTableColumns service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableColumns">REST API Reference for ListTableColumns Operation</seealso>
        ListTableColumnsResponse ListTableColumns(ListTableColumnsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableColumns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableColumns operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableColumns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableColumns">REST API Reference for ListTableColumns Operation</seealso>
        IAsyncResult BeginListTableColumns(ListTableColumnsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableColumns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableColumns.</param>
        /// 
        /// <returns>Returns a  ListTableColumnsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableColumns">REST API Reference for ListTableColumns Operation</seealso>
        ListTableColumnsResponse EndListTableColumns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTableRows


        /// <summary>
        /// The ListTableRows API allows you to retrieve a list of all the rows in a table in
        /// a workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableRows service method.</param>
        /// 
        /// <returns>The response from the ListTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableRows">REST API Reference for ListTableRows Operation</seealso>
        ListTableRowsResponse ListTableRows(ListTableRowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableRows">REST API Reference for ListTableRows Operation</seealso>
        IAsyncResult BeginListTableRows(ListTableRowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTableRows.</param>
        /// 
        /// <returns>Returns a  ListTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTableRows">REST API Reference for ListTableRows Operation</seealso>
        ListTableRowsResponse EndListTableRows(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTables


        /// <summary>
        /// The ListTables API allows you to retrieve a list of all the tables in a workbook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTables">REST API Reference for ListTables Operation</seealso>
        IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse EndListTables(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryTableRows


        /// <summary>
        /// The QueryTableRows API allows you to use a filter formula to query for specific rows
        /// in a table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTableRows service method.</param>
        /// 
        /// <returns>The response from the QueryTableRows service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.RequestTimeoutException">
        /// The request timed out.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/QueryTableRows">REST API Reference for QueryTableRows Operation</seealso>
        QueryTableRowsResponse QueryTableRows(QueryTableRowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryTableRows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryTableRows operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryTableRows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/QueryTableRows">REST API Reference for QueryTableRows Operation</seealso>
        IAsyncResult BeginQueryTableRows(QueryTableRowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryTableRows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryTableRows.</param>
        /// 
        /// <returns>Returns a  QueryTableRowsResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/QueryTableRows">REST API Reference for QueryTableRows Operation</seealso>
        QueryTableRowsResponse EndQueryTableRows(IAsyncResult asyncResult);

        #endregion
        
        #region  StartTableDataImportJob


        /// <summary>
        /// The StartTableDataImportJob API allows you to start an import job on a table. This
        /// API will only return the id of the job that was started. To find out the status of
        /// the import request, you need to call the DescribeTableDataImportJob API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTableDataImportJob service method.</param>
        /// 
        /// <returns>The response from the StartTableDataImportJob service method, as returned by Honeycode.</returns>
        /// <exception cref="Amazon.Honeycode.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check that the workbook
        /// is owned by you and your IAM policy allows access to the resource in the request.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.InternalServerException">
        /// There were unexpected errors from the server.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ResourceNotFoundException">
        /// A Workbook, Table, App, Screen or Screen Automation was not found with the given ID.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ServiceUnavailableException">
        /// Remote service is unreachable.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ThrottlingException">
        /// Tps(transactions per second) rate reached.
        /// </exception>
        /// <exception cref="Amazon.Honeycode.Model.ValidationException">
        /// Request is invalid. The message in the response contains details on why the request
        /// is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/StartTableDataImportJob">REST API Reference for StartTableDataImportJob Operation</seealso>
        StartTableDataImportJobResponse StartTableDataImportJob(StartTableDataImportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartTableDataImportJob operation on AmazonHoneycodeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartTableDataImportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/StartTableDataImportJob">REST API Reference for StartTableDataImportJob Operation</seealso>
        IAsyncResult BeginStartTableDataImportJob(StartTableDataImportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartTableDataImportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartTableDataImportJob.</param>
        /// 
        /// <returns>Returns a  StartTableDataImportJobResult from Honeycode.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/honeycode-2020-03-01/StartTableDataImportJob">REST API Reference for StartTableDataImportJob Operation</seealso>
        StartTableDataImportJobResponse EndStartTableDataImportJob(IAsyncResult asyncResult);

        #endregion
        
    }
}