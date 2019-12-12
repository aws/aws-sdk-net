/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RDSDataService.Model;

namespace Amazon.RDSDataService
{
    /// <summary>
    /// Interface for accessing RDSDataService
    ///
    /// Amazon RDS Data Service 
    /// <para>
    /// Amazon RDS provides an HTTP endpoint to run SQL statements on an Amazon Aurora Serverless
    /// DB cluster. To run these statements, you work with the Data Service API.
    /// 
    ///  
    /// <para>
    /// For more information about the Data Service API, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
    /// the Data API for Aurora Serverless</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you have questions or comments related to the Data API, send email to <a href="mailto:Rds-data-api-feedback@amazon.com">Rds-data-api-feedback@amazon.com</a>.
    /// </para>
    ///  </note>
    /// </para>
    /// </summary>
    public partial interface IAmazonRDSDataService : IAmazonService, IDisposable
    {

        
        #region  BatchExecuteStatement


        /// <summary>
        /// Runs a batch SQL statement over an array of data.
        /// 
        ///  
        /// <para>
        /// You can run bulk update and insert operations for multiple records using a DML statement
        /// with different parameter sets. Bulk operations can provide a significant performance
        /// improvement over individual insert and update operations.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a call isn't part of a transaction because it doesn't include the <code>transactionID</code>
        /// parameter, changes that result from the call are committed automatically.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        BatchExecuteStatementResponse BatchExecuteStatement(BatchExecuteStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchExecuteStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        IAsyncResult BeginBatchExecuteStatement(BatchExecuteStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchExecuteStatement.</param>
        /// 
        /// <returns>Returns a  BatchExecuteStatementResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        BatchExecuteStatementResponse EndBatchExecuteStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  BeginTransaction


        /// <summary>
        /// Starts a SQL transaction.
        /// 
        ///  <pre><code> &lt;important&gt; &lt;p&gt;A transaction can run for a maximum of 24
        /// hours. A transaction is terminated and rolled back automatically after 24 hours.&lt;/p&gt;
        /// &lt;p&gt;A transaction times out if no calls use its transaction ID in three minutes.
        /// If a transaction times out before it's committed, it's rolled back automatically.&lt;/p&gt;
        /// &lt;p&gt;DDL statements inside a transaction cause an implicit commit. We recommend
        /// that you run each DDL statement in a separate &lt;code&gt;ExecuteStatement&lt;/code&gt;
        /// call with &lt;code&gt;continueAfterTimeout&lt;/code&gt; enabled.&lt;/p&gt; &lt;/important&gt;
        /// </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BeginTransaction service method.</param>
        /// 
        /// <returns>The response from the BeginTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BeginTransaction">REST API Reference for BeginTransaction Operation</seealso>
        BeginTransactionResponse BeginTransaction(BeginTransactionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BeginTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BeginTransaction operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBeginTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BeginTransaction">REST API Reference for BeginTransaction Operation</seealso>
        IAsyncResult BeginBeginTransaction(BeginTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BeginTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBeginTransaction.</param>
        /// 
        /// <returns>Returns a  BeginTransactionResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/BeginTransaction">REST API Reference for BeginTransaction Operation</seealso>
        BeginTransactionResponse EndBeginTransaction(IAsyncResult asyncResult);

        #endregion
        
        #region  CommitTransaction


        /// <summary>
        /// Ends a SQL transaction started with the <code>BeginTransaction</code> operation and
        /// commits the changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction service method.</param>
        /// 
        /// <returns>The response from the CommitTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.NotFoundException">
        /// The <code>resourceArn</code>, <code>secretArn</code>, or <code>transactionId</code>
        /// value can't be found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        CommitTransactionResponse CommitTransaction(CommitTransactionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CommitTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCommitTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        IAsyncResult BeginCommitTransaction(CommitTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CommitTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCommitTransaction.</param>
        /// 
        /// <returns>Returns a  CommitTransactionResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/CommitTransaction">REST API Reference for CommitTransaction Operation</seealso>
        CommitTransactionResponse EndCommitTransaction(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteSql


        /// <summary>
        /// Runs one or more SQL statements.
        /// 
        ///  <important> 
        /// <para>
        /// This operation is deprecated. Use the <code>BatchExecuteStatement</code> or <code>ExecuteStatement</code>
        /// operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql service method.</param>
        /// 
        /// <returns>The response from the ExecuteSql service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        [Obsolete("ExecuteSql has been deprecated.  Please use ExecuteStatement or BatchExecuteStatement instead.")]
        ExecuteSqlResponse ExecuteSql(ExecuteSqlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteSql
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        [Obsolete("ExecuteSql has been deprecated.  Please use ExecuteStatement or BatchExecuteStatement instead.")]
        IAsyncResult BeginExecuteSql(ExecuteSqlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteSql operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteSql.</param>
        /// 
        /// <returns>Returns a  ExecuteSqlResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteSql">REST API Reference for ExecuteSql Operation</seealso>
        [Obsolete("ExecuteSql has been deprecated.  Please use ExecuteStatement or BatchExecuteStatement instead.")]
        ExecuteSqlResponse EndExecuteSql(IAsyncResult asyncResult);

        #endregion
        
        #region  ExecuteStatement


        /// <summary>
        /// Runs a SQL statement against a database.
        /// 
        ///  <important> 
        /// <para>
        /// If a call isn't part of a transaction because it doesn't include the <code>transactionID</code>
        /// parameter, changes that result from the call are committed automatically.
        /// </para>
        ///  </important> 
        /// <para>
        /// The response size limit is 1 MB or 1,000 records. If the call returns more than 1
        /// MB of response data or over 1,000 records, the call is terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        IAsyncResult BeginExecuteStatement(ExecuteStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteStatement.</param>
        /// 
        /// <returns>Returns a  ExecuteStatementResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        ExecuteStatementResponse EndExecuteStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  RollbackTransaction


        /// <summary>
        /// Performs a rollback of a transaction. Rolling back a transaction cancels its changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RollbackTransaction service method.</param>
        /// 
        /// <returns>The response from the RollbackTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.NotFoundException">
        /// The <code>resourceArn</code>, <code>secretArn</code>, or <code>transactionId</code>
        /// value can't be found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <code>resourceArn</code> parameter is not available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/RollbackTransaction">REST API Reference for RollbackTransaction Operation</seealso>
        RollbackTransactionResponse RollbackTransaction(RollbackTransactionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RollbackTransaction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RollbackTransaction operation on AmazonRDSDataServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRollbackTransaction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/RollbackTransaction">REST API Reference for RollbackTransaction Operation</seealso>
        IAsyncResult BeginRollbackTransaction(RollbackTransactionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RollbackTransaction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRollbackTransaction.</param>
        /// 
        /// <returns>Returns a  RollbackTransactionResult from RDSDataService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rds-data-2018-08-01/RollbackTransaction">REST API Reference for RollbackTransaction Operation</seealso>
        RollbackTransactionResponse EndRollbackTransaction(IAsyncResult asyncResult);

        #endregion
        
    }
}