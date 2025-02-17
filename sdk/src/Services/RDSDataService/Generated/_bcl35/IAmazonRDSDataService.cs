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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RDSDataService.Model;

#pragma warning disable CS1570
namespace Amazon.RDSDataService
{
    /// <summary>
    /// <para>Interface for accessing RDSDataService</para>
    ///
    /// RDS Data API 
    /// <para>
    /// Amazon RDS provides an HTTP endpoint to run SQL statements on an Amazon Aurora DB
    /// cluster. To run these statements, you use the RDS Data API (Data API).
    /// 
    ///  
    /// <para>
    /// Data API is available with the following types of Aurora databases:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Aurora PostgreSQL - Serverless v2, provisioned, and Serverless v1
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Aurora MySQL - Serverless v2, provisioned, and Serverless v1
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about the Data API, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
    /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    /// 
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
        ///  <note> 
        /// <para>
        /// If a call isn't part of a transaction because it doesn't include the <c>transactionID</c>
        /// parameter, changes that result from the call are committed automatically.
        /// </para>
        ///  
        /// <para>
        /// There isn't a fixed upper limit on the number of parameter sets. However, the maximum
        /// size of the HTTP request submitted through the Data API is 4 MiB. If the request exceeds
        /// this limit, the Data API returns an error and doesn't process the request. This 4-MiB
        /// limit includes the size of the HTTP headers and the JSON notation in the request.
        /// Thus, the number of parameter sets that you can include depends on a combination of
        /// factors, such as the size of the SQL statement and the size of each parameter set.
        /// </para>
        ///  
        /// <para>
        /// The response size limit is 1 MiB. If the call returns more than 1 MiB of response
        /// data, the call is terminated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement. (This error only appears in calls
        /// from Aurora Serverless v1 databases.)
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseErrorException">
        /// There was an error in processing the SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseNotFoundException">
        /// The DB cluster doesn't have a DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseResumingException">
        /// A request was cancelled because the Aurora Serverless v2 DB instance was paused. The
        /// Data API request automatically resumes the DB instance. Wait a few seconds and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseUnavailableException">
        /// The writer instance in the DB cluster isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.HttpEndpointNotEnabledException">
        /// The HTTP endpoint for using RDS Data API isn't enabled for the DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidSecretException">
        /// The Secrets Manager secret used with the request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.SecretsErrorException">
        /// There was a problem with the Secrets Manager secret used with the request, caused
        /// by one of the following conditions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// RDS Data API timed out retrieving the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret provided wasn't found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret couldn't be decrypted.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <c>resourceArn</c> parameter isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.TransactionNotFoundException">
        /// The transaction ID wasn't found.
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
        ///  <note> 
        /// <para>
        /// A transaction can run for a maximum of 24 hours. A transaction is terminated and rolled
        /// back automatically after 24 hours.
        /// </para>
        ///  
        /// <para>
        /// A transaction times out if no calls use its transaction ID in three minutes. If a
        /// transaction times out before it's committed, it's rolled back automatically.
        /// </para>
        ///  
        /// <para>
        /// For Aurora MySQL, DDL statements inside a transaction cause an implicit commit. We
        /// recommend that you run each MySQL DDL statement in a separate <c>ExecuteStatement</c>
        /// call with <c>continueAfterTimeout</c> enabled.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BeginTransaction service method.</param>
        /// 
        /// <returns>The response from the BeginTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement. (This error only appears in calls
        /// from Aurora Serverless v1 databases.)
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseErrorException">
        /// There was an error in processing the SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseNotFoundException">
        /// The DB cluster doesn't have a DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseResumingException">
        /// A request was cancelled because the Aurora Serverless v2 DB instance was paused. The
        /// Data API request automatically resumes the DB instance. Wait a few seconds and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseUnavailableException">
        /// The writer instance in the DB cluster isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.HttpEndpointNotEnabledException">
        /// The HTTP endpoint for using RDS Data API isn't enabled for the DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidSecretException">
        /// The Secrets Manager secret used with the request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.SecretsErrorException">
        /// There was a problem with the Secrets Manager secret used with the request, caused
        /// by one of the following conditions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// RDS Data API timed out retrieving the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret provided wasn't found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret couldn't be decrypted.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <c>resourceArn</c> parameter isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.TransactionNotFoundException">
        /// The transaction ID wasn't found.
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
        /// Ends a SQL transaction started with the <c>BeginTransaction</c> operation and commits
        /// the changes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CommitTransaction service method.</param>
        /// 
        /// <returns>The response from the CommitTransaction service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement. (This error only appears in calls
        /// from Aurora Serverless v1 databases.)
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseErrorException">
        /// There was an error in processing the SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseNotFoundException">
        /// The DB cluster doesn't have a DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseUnavailableException">
        /// The writer instance in the DB cluster isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.HttpEndpointNotEnabledException">
        /// The HTTP endpoint for using RDS Data API isn't enabled for the DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidSecretException">
        /// The Secrets Manager secret used with the request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.NotFoundException">
        /// The <c>resourceArn</c>, <c>secretArn</c>, or <c>transactionId</c> value can't be found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.SecretsErrorException">
        /// There was a problem with the Secrets Manager secret used with the request, caused
        /// by one of the following conditions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// RDS Data API timed out retrieving the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret provided wasn't found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret couldn't be decrypted.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <c>resourceArn</c> parameter isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.TransactionNotFoundException">
        /// The transaction ID wasn't found.
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
        ///  <note> 
        /// <para>
        /// This operation isn't supported for Aurora Serverless v2 and provisioned DB clusters.
        /// For Aurora Serverless v1 DB clusters, the operation is deprecated. Use the <c>BatchExecuteStatement</c>
        /// or <c>ExecuteStatement</c> operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteSql service method.</param>
        /// 
        /// <returns>The response from the ExecuteSql service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement. (This error only appears in calls
        /// from Aurora Serverless v1 databases.)
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <c>resourceArn</c> parameter isn't available.
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
        ///  <note> 
        /// <para>
        /// If a call isn't part of a transaction because it doesn't include the <c>transactionID</c>
        /// parameter, changes that result from the call are committed automatically.
        /// </para>
        ///  
        /// <para>
        /// If the binary response data from the database is more than 1 MB, the call is terminated.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by RDSDataService.</returns>
        /// <exception cref="Amazon.RDSDataService.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement. (This error only appears in calls
        /// from Aurora Serverless v1 databases.)
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseErrorException">
        /// There was an error in processing the SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseNotFoundException">
        /// The DB cluster doesn't have a DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseResumingException">
        /// A request was cancelled because the Aurora Serverless v2 DB instance was paused. The
        /// Data API request automatically resumes the DB instance. Wait a few seconds and try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseUnavailableException">
        /// The writer instance in the DB cluster isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.HttpEndpointNotEnabledException">
        /// The HTTP endpoint for using RDS Data API isn't enabled for the DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidSecretException">
        /// The Secrets Manager secret used with the request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.SecretsErrorException">
        /// There was a problem with the Secrets Manager secret used with the request, caused
        /// by one of the following conditions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// RDS Data API timed out retrieving the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret provided wasn't found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret couldn't be decrypted.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <c>resourceArn</c> parameter isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.TransactionNotFoundException">
        /// The transaction ID wasn't found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.UnsupportedResultException">
        /// There was a problem with the result because of one of the following conditions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// It contained an unsupported data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It contained a multidimensional array.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The size was too large.
        /// </para>
        ///  </li> </ul>
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
        /// <exception cref="Amazon.RDSDataService.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.BadRequestException">
        /// There is an error in the call or in a SQL statement. (This error only appears in calls
        /// from Aurora Serverless v1 databases.)
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseErrorException">
        /// There was an error in processing the SQL statement.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseNotFoundException">
        /// The DB cluster doesn't have a DB instance.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.DatabaseUnavailableException">
        /// The writer instance in the DB cluster isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ForbiddenException">
        /// There are insufficient privileges to make the call.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.HttpEndpointNotEnabledException">
        /// The HTTP endpoint for using RDS Data API isn't enabled for the DB cluster.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InternalServerErrorException">
        /// An internal error occurred.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidResourceStateException">
        /// The resource is in an invalid state.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.InvalidSecretException">
        /// The Secrets Manager secret used with the request isn't valid.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.NotFoundException">
        /// The <c>resourceArn</c>, <c>secretArn</c>, or <c>transactionId</c> value can't be found.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.SecretsErrorException">
        /// There was a problem with the Secrets Manager secret used with the request, caused
        /// by one of the following conditions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// RDS Data API timed out retrieving the secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret provided wasn't found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The secret couldn't be decrypted.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.ServiceUnavailableErrorException">
        /// The service specified by the <c>resourceArn</c> parameter isn't available.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.StatementTimeoutException">
        /// The execution of the SQL statement timed out.
        /// </exception>
        /// <exception cref="Amazon.RDSDataService.Model.TransactionNotFoundException">
        /// The transaction ID wasn't found.
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
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}