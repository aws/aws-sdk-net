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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Athena.Model;

namespace Amazon.Athena
{
    /// <summary>
    /// Interface for accessing Athena
    ///
    /// Amazon Athena is an interactive query service that lets you use standard SQL to analyze
    /// data directly in Amazon S3. You can point Athena at your data in Amazon S3 and run
    /// ad-hoc queries and get results in seconds. Athena is serverless, so there is no infrastructure
    /// to set up or manage. You pay only for the queries you run. Athena scales automatically—executing
    /// queries in parallel—so results are fast, even with large datasets and complex queries.
    /// For more information, see <a href="http://docs.aws.amazon.com/athena/latest/ug/what-is.html">What
    /// is Amazon Athena</a> in the <i>Amazon Athena User Guide</i>.
    /// 
    ///  
    /// <para>
    /// If you connect to Athena using the JDBC driver, use version 1.1.0 of the driver or
    /// later with the Amazon Athena API. Earlier version drivers do not support the API.
    /// For more information and to download the driver, see <a href="https://docs.aws.amazon.com/athena/latest/ug/connect-with-jdbc.html">Accessing
    /// Amazon Athena with JDBC</a>.
    /// </para>
    ///  
    /// <para>
    /// For code samples using the Amazon Web Services SDK for Java, see <a href="https://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
    /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonAthena : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAthenaPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetNamedQuery



        /// <summary>
        /// Returns the details of a single named query or a list of up to 50 queries, which you
        /// provide as an array of query ID strings. Requires you to have access to the workgroup
        /// in which the queries were saved. Use <a>ListNamedQueriesInput</a> to get the list
        /// of named query IDs in the specified workgroup. If information could not be retrieved
        /// for a submitted query ID, information about the query ID submitted is listed under
        /// <a>UnprocessedNamedQueryId</a>. Named queries differ from executed queries. Use <a>BatchGetQueryExecutionInput</a>
        /// to get details about each unique query execution, and <a>ListQueryExecutionsInput</a>
        /// to get a list of query execution IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetNamedQuery">REST API Reference for BatchGetNamedQuery Operation</seealso>
        Task<BatchGetNamedQueryResponse> BatchGetNamedQueryAsync(BatchGetNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetPreparedStatement



        /// <summary>
        /// Returns the details of a single prepared statement or a list of up to 256 prepared
        /// statements for the array of prepared statement names that you provide. Requires you
        /// to have access to the workgroup to which the prepared statements belong. If a prepared
        /// statement cannot be retrieved for the name specified, the statement is listed in <code>UnprocessedPreparedStatementNames</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetPreparedStatement">REST API Reference for BatchGetPreparedStatement Operation</seealso>
        Task<BatchGetPreparedStatementResponse> BatchGetPreparedStatementAsync(BatchGetPreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetQueryExecution



        /// <summary>
        /// Returns the details of a single query execution or a list of up to 50 query executions,
        /// which you provide as an array of query execution ID strings. Requires you to have
        /// access to the workgroup in which the queries ran. To get a list of query execution
        /// IDs, use <a>ListQueryExecutionsInput$WorkGroup</a>. Query executions differ from named
        /// (saved) queries. Use <a>BatchGetNamedQueryInput</a> to get details about named queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/BatchGetQueryExecution">REST API Reference for BatchGetQueryExecution Operation</seealso>
        Task<BatchGetQueryExecutionResponse> BatchGetQueryExecutionAsync(BatchGetQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDataCatalog



        /// <summary>
        /// Creates (registers) a data catalog with the specified name and properties. Catalogs
        /// created are visible to all users of the same Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateDataCatalog">REST API Reference for CreateDataCatalog Operation</seealso>
        Task<CreateDataCatalogResponse> CreateDataCatalogAsync(CreateDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNamedQuery



        /// <summary>
        /// Creates a named query in the specified workgroup. Requires that you have access to
        /// the workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNamedQuery">REST API Reference for CreateNamedQuery Operation</seealso>
        Task<CreateNamedQueryResponse> CreateNamedQueryAsync(CreateNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateNotebook



        /// <summary>
        /// Creates an empty <code>ipynb</code> file in the specified Apache Spark enabled workgroup.
        /// Throws an error if a file in the workgroup with the same name already exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateNotebook">REST API Reference for CreateNotebook Operation</seealso>
        Task<CreateNotebookResponse> CreateNotebookAsync(CreateNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePreparedStatement



        /// <summary>
        /// Creates a prepared statement for use with SQL queries in Athena.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePreparedStatement">REST API Reference for CreatePreparedStatement Operation</seealso>
        Task<CreatePreparedStatementResponse> CreatePreparedStatementAsync(CreatePreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePresignedNotebookUrl



        /// <summary>
        /// Gets an authentication token and the URL at which the notebook can be accessed. During
        /// programmatic access, <code>CreatePresignedNotebookUrl</code> must be called every
        /// 10 minutes to refresh the authentication token. For information about granting programmatic
        /// access, see <a href="https://docs.aws.amazon.com/athena/latest/ug/setting-up.html#setting-up-grant-programmatic-access">Grant
        /// programmatic access</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookUrl service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreatePresignedNotebookUrl">REST API Reference for CreatePresignedNotebookUrl Operation</seealso>
        Task<CreatePresignedNotebookUrlResponse> CreatePresignedNotebookUrlAsync(CreatePresignedNotebookUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkGroup



        /// <summary>
        /// Creates a workgroup with the specified name. A workgroup can be an Apache Spark enabled
        /// workgroup or an Athena SQL workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/CreateWorkGroup">REST API Reference for CreateWorkGroup Operation</seealso>
        Task<CreateWorkGroupResponse> CreateWorkGroupAsync(CreateWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataCatalog



        /// <summary>
        /// Deletes a data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteDataCatalog">REST API Reference for DeleteDataCatalog Operation</seealso>
        Task<DeleteDataCatalogResponse> DeleteDataCatalogAsync(DeleteDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNamedQuery



        /// <summary>
        /// Deletes the named query if you have access to the workgroup in which the query was
        /// saved.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNamedQuery">REST API Reference for DeleteNamedQuery Operation</seealso>
        Task<DeleteNamedQueryResponse> DeleteNamedQueryAsync(DeleteNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteNotebook



        /// <summary>
        /// Deletes the specified notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteNotebook">REST API Reference for DeleteNotebook Operation</seealso>
        Task<DeleteNotebookResponse> DeleteNotebookAsync(DeleteNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePreparedStatement



        /// <summary>
        /// Deletes the prepared statement with the specified name from the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeletePreparedStatement">REST API Reference for DeletePreparedStatement Operation</seealso>
        Task<DeletePreparedStatementResponse> DeletePreparedStatementAsync(DeletePreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkGroup



        /// <summary>
        /// Deletes the workgroup with the specified name. The primary workgroup cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/DeleteWorkGroup">REST API Reference for DeleteWorkGroup Operation</seealso>
        Task<DeleteWorkGroupResponse> DeleteWorkGroupAsync(DeleteWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExportNotebook



        /// <summary>
        /// Exports the specified notebook and its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ExportNotebook">REST API Reference for ExportNotebook Operation</seealso>
        Task<ExportNotebookResponse> ExportNotebookAsync(ExportNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCalculationExecution



        /// <summary>
        /// Describes a previously submitted calculation execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecution">REST API Reference for GetCalculationExecution Operation</seealso>
        Task<GetCalculationExecutionResponse> GetCalculationExecutionAsync(GetCalculationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCalculationExecutionCode



        /// <summary>
        /// Retrieves the unencrypted code that was executed for the calculation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculationExecutionCode service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionCode">REST API Reference for GetCalculationExecutionCode Operation</seealso>
        Task<GetCalculationExecutionCodeResponse> GetCalculationExecutionCodeAsync(GetCalculationExecutionCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCalculationExecutionStatus



        /// <summary>
        /// Gets the status of a current calculation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCalculationExecutionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCalculationExecutionStatus service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetCalculationExecutionStatus">REST API Reference for GetCalculationExecutionStatus Operation</seealso>
        Task<GetCalculationExecutionStatusResponse> GetCalculationExecutionStatusAsync(GetCalculationExecutionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDatabase



        /// <summary>
        /// Returns a database object for the specified database and data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDatabase service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDatabase service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDatabase">REST API Reference for GetDatabase Operation</seealso>
        Task<GetDatabaseResponse> GetDatabaseAsync(GetDatabaseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataCatalog



        /// <summary>
        /// Returns the specified data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetDataCatalog">REST API Reference for GetDataCatalog Operation</seealso>
        Task<GetDataCatalogResponse> GetDataCatalogAsync(GetDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNamedQuery



        /// <summary>
        /// Returns information about a single query. Requires that you have access to the workgroup
        /// in which the query was saved.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNamedQuery">REST API Reference for GetNamedQuery Operation</seealso>
        Task<GetNamedQueryResponse> GetNamedQueryAsync(GetNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetNotebookMetadata



        /// <summary>
        /// Retrieves notebook metadata for the specified notebook ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotebookMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetNotebookMetadata">REST API Reference for GetNotebookMetadata Operation</seealso>
        Task<GetNotebookMetadataResponse> GetNotebookMetadataAsync(GetNotebookMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPreparedStatement



        /// <summary>
        /// Retrieves the prepared statement with the specified name from the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetPreparedStatement">REST API Reference for GetPreparedStatement Operation</seealso>
        Task<GetPreparedStatementResponse> GetPreparedStatementAsync(GetPreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueryExecution



        /// <summary>
        /// Returns information about a single execution of a query if you have access to the
        /// workgroup in which the query ran. Each time a query executes, information about the
        /// query execution is saved with a unique ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryExecution">REST API Reference for GetQueryExecution Operation</seealso>
        Task<GetQueryExecutionResponse> GetQueryExecutionAsync(GetQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueryResults



        /// <summary>
        /// Streams the results of a single query execution specified by <code>QueryExecutionId</code>
        /// from the Athena query results location in Amazon S3. For more information, see <a
        /// href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Working with query
        /// results, recent queries, and output files</a> in the <i>Amazon Athena User Guide</i>.
        /// This request does not execute the query but returns results. Use <a>StartQueryExecution</a>
        /// to run a query.
        /// 
        ///  
        /// <para>
        /// To stream query results successfully, the IAM principal with permission to call <code>GetQueryResults</code>
        /// also must have permissions to the Amazon S3 <code>GetObject</code> action for the
        /// Athena query results location.
        /// </para>
        ///  <important> 
        /// <para>
        /// IAM principals with permission to the Amazon S3 <code>GetObject</code> action for
        /// the query results location are able to retrieve query results from Amazon S3 even
        /// if permission to the <code>GetQueryResults</code> action is denied. To restrict user
        /// or role access, ensure that Amazon S3 permissions to the Athena query location are
        /// denied.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueryRuntimeStatistics



        /// <summary>
        /// Returns query execution runtime statistics related to a single execution of a query
        /// if you have access to the workgroup in which the query ran. Query execution runtime
        /// statistics are returned only when <a>QueryExecutionStatus$State</a> is in a SUCCEEDED
        /// or FAILED state. Stage-level input and output row count and data size statistics are
        /// not shown when a query has row-level filters defined in Lake Formation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryRuntimeStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryRuntimeStatistics service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryRuntimeStatistics">REST API Reference for GetQueryRuntimeStatistics Operation</seealso>
        Task<GetQueryRuntimeStatisticsResponse> GetQueryRuntimeStatisticsAsync(GetQueryRuntimeStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSession



        /// <summary>
        /// Gets the full details of a previously created session, including the session status
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSession">REST API Reference for GetSession Operation</seealso>
        Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSessionStatus



        /// <summary>
        /// Gets the current status of a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSessionStatus service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetSessionStatus">REST API Reference for GetSessionStatus Operation</seealso>
        Task<GetSessionStatusResponse> GetSessionStatusAsync(GetSessionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTableMetadata



        /// <summary>
        /// Returns table metadata for the specified catalog, database, and table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTableMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetTableMetadata">REST API Reference for GetTableMetadata Operation</seealso>
        Task<GetTableMetadataResponse> GetTableMetadataAsync(GetTableMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetWorkGroup



        /// <summary>
        /// Returns information about the workgroup with the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetWorkGroup">REST API Reference for GetWorkGroup Operation</seealso>
        Task<GetWorkGroupResponse> GetWorkGroupAsync(GetWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportNotebook



        /// <summary>
        /// Imports a single <code>ipynb</code> file to a Spark enabled workgroup. The maximum
        /// file size that can be imported is 10 megabytes. If an <code>ipynb</code> file with
        /// the same name already exists in the workgroup, throws an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ImportNotebook">REST API Reference for ImportNotebook Operation</seealso>
        Task<ImportNotebookResponse> ImportNotebookAsync(ImportNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplicationDPUSizes



        /// <summary>
        /// Returns the supported DPU sizes for the supported application runtimes (for example,
        /// <code>Athena notebook version 1</code>).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplicationDPUSizes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplicationDPUSizes service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListApplicationDPUSizes">REST API Reference for ListApplicationDPUSizes Operation</seealso>
        Task<ListApplicationDPUSizesResponse> ListApplicationDPUSizesAsync(ListApplicationDPUSizesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCalculationExecutions



        /// <summary>
        /// Lists the calculations that have been submitted to a session in descending order.
        /// Newer calculations are listed first; older calculations are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCalculationExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCalculationExecutions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListCalculationExecutions">REST API Reference for ListCalculationExecutions Operation</seealso>
        Task<ListCalculationExecutionsResponse> ListCalculationExecutionsAsync(ListCalculationExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDatabases



        /// <summary>
        /// Lists the databases in the specified data catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        Task<ListDatabasesResponse> ListDatabasesAsync(ListDatabasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataCatalogs



        /// <summary>
        /// Lists the data catalogs in the current Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// In the Athena console, data catalogs are listed as "data sources" on the <b>Data sources</b>
        /// page under the <b>Data source name</b> column.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataCatalogs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataCatalogs service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListDataCatalogs">REST API Reference for ListDataCatalogs Operation</seealso>
        Task<ListDataCatalogsResponse> ListDataCatalogsAsync(ListDataCatalogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEngineVersions



        /// <summary>
        /// Returns a list of engine versions that are available to choose from, including the
        /// Auto option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEngineVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEngineVersions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListEngineVersions">REST API Reference for ListEngineVersions Operation</seealso>
        Task<ListEngineVersionsResponse> ListEngineVersionsAsync(ListEngineVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListExecutors



        /// <summary>
        /// Lists, in descending order, the executors that joined a session. Newer executors are
        /// listed first; older executors are listed later. The result can be optionally filtered
        /// by state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutors service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListExecutors">REST API Reference for ListExecutors Operation</seealso>
        Task<ListExecutorsResponse> ListExecutorsAsync(ListExecutorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNamedQueries



        /// <summary>
        /// Provides a list of available query IDs only for queries saved in the specified workgroup.
        /// Requires that you have access to the specified workgroup. If a workgroup is not specified,
        /// lists the saved queries for the primary workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamedQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamedQueries service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNamedQueries">REST API Reference for ListNamedQueries Operation</seealso>
        Task<ListNamedQueriesResponse> ListNamedQueriesAsync(ListNamedQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotebookMetadata



        /// <summary>
        /// Displays the notebook files for the specified workgroup in paginated format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookMetadata">REST API Reference for ListNotebookMetadata Operation</seealso>
        Task<ListNotebookMetadataResponse> ListNotebookMetadataAsync(ListNotebookMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListNotebookSessions



        /// <summary>
        /// Lists, in descending order, the sessions that have been created in a notebook that
        /// are in an active state like <code>CREATING</code>, <code>CREATED</code>, <code>IDLE</code>
        /// or <code>BUSY</code>. Newer sessions are listed first; older sessions are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookSessions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListNotebookSessions">REST API Reference for ListNotebookSessions Operation</seealso>
        Task<ListNotebookSessionsResponse> ListNotebookSessionsAsync(ListNotebookSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPreparedStatements



        /// <summary>
        /// Lists the prepared statements in the specified workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPreparedStatements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPreparedStatements service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListPreparedStatements">REST API Reference for ListPreparedStatements Operation</seealso>
        Task<ListPreparedStatementsResponse> ListPreparedStatementsAsync(ListPreparedStatementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueryExecutions



        /// <summary>
        /// Provides a list of available query execution IDs for the queries in the specified
        /// workgroup. If a workgroup is not specified, returns a list of query execution IDs
        /// for the primary workgroup. Requires you to have access to the workgroup in which the
        /// queries ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueryExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueryExecutions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListQueryExecutions">REST API Reference for ListQueryExecutions Operation</seealso>
        Task<ListQueryExecutionsResponse> ListQueryExecutionsAsync(ListQueryExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSessions



        /// <summary>
        /// Lists the sessions in a workgroup that are in an active state like <code>CREATING</code>,
        /// <code>CREATED</code>, <code>IDLE</code>, or <code>BUSY</code>. Newer sessions are
        /// listed first; older sessions are listed later.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListSessions">REST API Reference for ListSessions Operation</seealso>
        Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTableMetadata



        /// <summary>
        /// Lists the metadata for the tables in the specified data catalog database.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTableMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTableMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.MetadataException">
        /// An exception that Athena received when it called a custom metastore. Occurs if the
        /// error is not caused by user input (<code>InvalidRequestException</code>) or from the
        /// Athena platform (<code>InternalServerException</code>). For example, if a user-created
        /// Lambda function is missing permissions, the Lambda <code>4XX</code> exception is returned
        /// in a <code>MetadataException</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTableMetadata">REST API Reference for ListTableMetadata Operation</seealso>
        Task<ListTableMetadataResponse> ListTableMetadataAsync(ListTableMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags associated with an Athena workgroup or data catalog resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkGroups



        /// <summary>
        /// Lists available workgroups for the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkGroups service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/ListWorkGroups">REST API Reference for ListWorkGroups Operation</seealso>
        Task<ListWorkGroupsResponse> ListWorkGroupsAsync(ListWorkGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCalculationExecution



        /// <summary>
        /// Submits calculations for execution within a session. You can supply the code to run
        /// as an inline code block within the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCalculationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartCalculationExecution">REST API Reference for StartCalculationExecution Operation</seealso>
        Task<StartCalculationExecutionResponse> StartCalculationExecutionAsync(StartCalculationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartQueryExecution



        /// <summary>
        /// Runs the SQL query statements contained in the <code>Query</code>. Requires you to
        /// have access to the workgroup in which the query ran. Running queries against an external
        /// catalog requires <a>GetDataCatalog</a> permission to the catalog. For code samples
        /// using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartQueryExecution">REST API Reference for StartQueryExecution Operation</seealso>
        Task<StartQueryExecutionResponse> StartQueryExecutionAsync(StartQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartSession



        /// <summary>
        /// Creates a session for running calculations within a workgroup. The session is ready
        /// when it reaches an <code>IDLE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.SessionAlreadyExistsException">
        /// The specified session already exists.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StartSession">REST API Reference for StartSession Operation</seealso>
        Task<StartSessionResponse> StartSessionAsync(StartSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCalculationExecution



        /// <summary>
        /// Requests the cancellation of a calculation. A <code>StopCalculationExecution</code>
        /// call on a calculation that is already in a terminal state (for example, <code>STOPPED</code>,
        /// <code>FAILED</code>, or <code>COMPLETED</code>) succeeds but has no effect.
        /// 
        ///  <note> 
        /// <para>
        /// Cancelling a calculation is done on a best effort basis. If a calculation cannot be
        /// cancelled, you can be charged for its completion. If you are concerned about being
        /// charged for a calculation that cannot be cancelled, consider terminating the session
        /// in which the calculation is running.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCalculationExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCalculationExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopCalculationExecution">REST API Reference for StopCalculationExecution Operation</seealso>
        Task<StopCalculationExecutionResponse> StopCalculationExecutionAsync(StopCalculationExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopQueryExecution



        /// <summary>
        /// Stops a query execution. Requires you to have access to the workgroup in which the
        /// query ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the Amazon Web Services SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
        /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQueryExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopQueryExecution service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/StopQueryExecution">REST API Reference for StopQueryExecution Operation</seealso>
        Task<StopQueryExecutionResponse> StopQueryExecutionAsync(StopQueryExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags to an Athena resource. A tag is a label that you assign to a
        /// resource. In Athena, a resource can be a workgroup or data catalog. Each tag consists
        /// of a key and an optional value, both of which you define. For example, you can use
        /// tags to categorize Athena workgroups or data catalogs by purpose, owner, or environment.
        /// Use a consistent set of tag keys to make it easier to search and filter workgroups
        /// or data catalogs in your account. For best practices, see <a href="https://docs.aws.amazon.com/whitepapers/latest/tagging-best-practices/tagging-best-practices.html">Tagging
        /// Best Practices</a>. Tag keys can be from 1 to 128 UTF-8 Unicode characters, and tag
        /// values can be from 0 to 256 UTF-8 Unicode characters. Tags can use letters and numbers
        /// representable in UTF-8, and the following characters: + - = . _ : / @. Tag keys and
        /// values are case-sensitive. Tag keys must be unique per resource. If you specify more
        /// than one tag, separate them by commas.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TerminateSession



        /// <summary>
        /// Terminates an active session. A <code>TerminateSession</code> call on a session that
        /// is already inactive (for example, in a <code>FAILED</code>, <code>TERMINATED</code>
        /// or <code>TERMINATING</code> state) succeeds but has no effect. Calculations running
        /// in the session when <code>TerminateSession</code> is called are forcefully stopped,
        /// but may display as <code>FAILED</code> instead of <code>STOPPED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateSession service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/TerminateSession">REST API Reference for TerminateSession Operation</seealso>
        Task<TerminateSessionResponse> TerminateSessionAsync(TerminateSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from a data catalog or workgroup resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataCatalog



        /// <summary>
        /// Updates the data catalog that has the specified name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataCatalog service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataCatalog service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateDataCatalog">REST API Reference for UpdateDataCatalog Operation</seealso>
        Task<UpdateDataCatalogResponse> UpdateDataCatalogAsync(UpdateDataCatalogRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNamedQuery



        /// <summary>
        /// Updates a <a>NamedQuery</a> object. The database or workgroup cannot be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamedQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNamedQuery service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNamedQuery">REST API Reference for UpdateNamedQuery Operation</seealso>
        Task<UpdateNamedQueryResponse> UpdateNamedQueryAsync(UpdateNamedQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotebook



        /// <summary>
        /// Updates the contents of a Spark notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebook service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebook service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebook">REST API Reference for UpdateNotebook Operation</seealso>
        Task<UpdateNotebookResponse> UpdateNotebookAsync(UpdateNotebookRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateNotebookMetadata



        /// <summary>
        /// Updates the metadata for a notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotebookMetadata service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.TooManyRequestsException">
        /// Indicates that the request was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateNotebookMetadata">REST API Reference for UpdateNotebookMetadata Operation</seealso>
        Task<UpdateNotebookMetadataResponse> UpdateNotebookMetadataAsync(UpdateNotebookMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePreparedStatement



        /// <summary>
        /// Updates a prepared statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePreparedStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePreparedStatement service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.ResourceNotFoundException">
        /// A resource, such as a workgroup, was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdatePreparedStatement">REST API Reference for UpdatePreparedStatement Operation</seealso>
        Task<UpdatePreparedStatementResponse> UpdatePreparedStatementAsync(UpdatePreparedStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkGroup



        /// <summary>
        /// Updates the workgroup with the specified name. The workgroup's name cannot be changed.
        /// Only <code>ConfigurationUpdates</code> can be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkGroup service method, as returned by Athena.</returns>
        /// <exception cref="Amazon.Athena.Model.InternalServerException">
        /// Indicates a platform issue, which may be due to a transient condition or outage.
        /// </exception>
        /// <exception cref="Amazon.Athena.Model.InvalidRequestException">
        /// Indicates that something is wrong with the input to the request. For example, a required
        /// parameter may be missing or out of range.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/UpdateWorkGroup">REST API Reference for UpdateWorkGroup Operation</seealso>
        Task<UpdateWorkGroupResponse> UpdateWorkGroupAsync(UpdateWorkGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}