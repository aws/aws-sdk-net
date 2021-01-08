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
    /// For code samples using the AWS SDK for Java, see <a href="https://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
    /// and Code Samples</a> in the <i>Amazon Athena User Guide</i>.
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
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
        /// created are visible to all users of the same AWS account.
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
        /// For code samples using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
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
                
        #region  CreateWorkGroup



        /// <summary>
        /// Creates a workgroup with the specified name.
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
        /// For code samples using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
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
                
        #region  GetDatabase



        /// <summary>
        /// Returns a database object for the specfied database and data catalog.
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
        /// href="https://docs.aws.amazon.com/athena/latest/ug/querying.html">Query Results</a>
        /// in the <i>Amazon Athena User Guide</i>. This request does not execute the query but
        /// returns results. Use <a>StartQueryExecution</a> to run a query.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/athena-2017-05-18/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the data catalogs in the current AWS account.
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
                
        #region  ListNamedQueries



        /// <summary>
        /// Provides a list of available query IDs only for queries saved in the specified workgroup.
        /// Requires that you have access to the specified workgroup. If a workgroup is not specified,
        /// lists the saved queries for the primary workgroup.
        /// 
        ///  
        /// <para>
        /// For code samples using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
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
                
        #region  ListQueryExecutions



        /// <summary>
        /// Provides a list of available query execution IDs for the queries in the specified
        /// workgroup. If a workgroup is not specified, returns a list of query execution IDs
        /// for the primary workgroup. Requires you to have access to the workgroup in which the
        /// queries ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
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
                
        #region  StartQueryExecution



        /// <summary>
        /// Runs the SQL query statements contained in the <code>Query</code>. Requires you to
        /// have access to the workgroup in which the query ran. Running queries against an external
        /// catalog requires <a>GetDataCatalog</a> permission to the catalog. For code samples
        /// using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
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
                
        #region  StopQueryExecution



        /// <summary>
        /// Stops a query execution. Requires you to have access to the workgroup in which the
        /// query ran.
        /// 
        ///  
        /// <para>
        /// For code samples using the AWS SDK for Java, see <a href="http://docs.aws.amazon.com/athena/latest/ug/code-samples.html">Examples
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
        /// or data catalogs in your account. For best practices, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">Tagging
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
                
        #region  UpdateWorkGroup



        /// <summary>
        /// Updates the workgroup with the specified name. The workgroup's name cannot be changed.
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