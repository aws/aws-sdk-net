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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TimestreamQuery.Model;

#pragma warning disable CS1570
namespace Amazon.TimestreamQuery
{
    /// <summary>
    /// <para>Interface for accessing TimestreamQuery</para>
    ///
    /// Amazon Timestream Query
    /// </summary>
    public partial interface IAmazonTimestreamQuery : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITimestreamQueryPaginatorFactory Paginators { get; }
#endif
                
        #region  CancelQuery



        /// <summary>
        /// Cancels a query that has been issued. Cancellation is provided only if the query
        /// has not completed running before the cancellation request was issued. Because cancellation
        /// is an idempotent operation, subsequent cancellation requests will return a <c>CancellationMessage</c>,
        /// indicating that the query has already been canceled. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.cancel-query.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/CancelQuery">REST API Reference for CancelQuery Operation</seealso>
        Task<CancelQueryResponse> CancelQueryAsync(CancelQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateScheduledQuery



        /// <summary>
        /// Create a scheduled query that will be run on your behalf at the configured schedule.
        /// Timestream assumes the execution role provided as part of the <c>ScheduledQueryExecutionRoleArn</c>
        /// parameter to run the query. You can use the <c>NotificationConfiguration</c> parameter
        /// to configure notification for your scheduled query operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ConflictException">
        /// Unable to poll results for a cancelled query.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/CreateScheduledQuery">REST API Reference for CreateScheduledQuery Operation</seealso>
        Task<CreateScheduledQueryResponse> CreateScheduledQueryAsync(CreateScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteScheduledQuery



        /// <summary>
        /// Deletes a given scheduled query. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DeleteScheduledQuery">REST API Reference for DeleteScheduledQuery Operation</seealso>
        Task<DeleteScheduledQueryResponse> DeleteScheduledQueryAsync(DeleteScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccountSettings



        /// <summary>
        /// Describes the settings for your account that include the query pricing model and the
        /// configured maximum TCUs the service can use for your query workload.
        /// 
        ///  
        /// <para>
        /// You're charged only for the duration of compute units used for your workloads.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountSettings service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeAccountSettings">REST API Reference for DescribeAccountSettings Operation</seealso>
        Task<DescribeAccountSettingsResponse> DescribeAccountSettingsAsync(DescribeAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeEndpoints



        /// <summary>
        /// DescribeEndpoints returns a list of available endpoints to make Timestream API calls
        /// against. This API is available through both Write and Query.
        /// 
        ///  
        /// <para>
        /// Because the Timestream SDKs are designed to transparently work with the service’s
        /// architecture, including the management and mapping of the service endpoints, <i>it
        /// is not recommended that you use this API unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are using <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/VPCEndpoints">VPC
        /// endpoints (Amazon Web Services PrivateLink) with Timestream </a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how and when to use and implement DescribeEndpoints, see
        /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using.API.html#Using-API.endpoint-discovery">The
        /// Endpoint Discovery Pattern</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScheduledQuery



        /// <summary>
        /// Provides detailed information about a scheduled query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/DescribeScheduledQuery">REST API Reference for DescribeScheduledQuery Operation</seealso>
        Task<DescribeScheduledQueryResponse> DescribeScheduledQueryAsync(DescribeScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ExecuteScheduledQuery



        /// <summary>
        /// You can use this API to run a scheduled query manually. 
        /// 
        ///  
        /// <para>
        /// If you enabled <c>QueryInsights</c>, this API also returns insights and metrics related
        /// to the query that you executed as part of an Amazon SNS notification. <c>QueryInsights</c>
        /// helps with performance tuning of your query. For more information about <c>QueryInsights</c>,
        /// see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/using-query-insights.html">Using
        /// query insights to optimize queries in Amazon Timestream</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ExecuteScheduledQuery">REST API Reference for ExecuteScheduledQuery Operation</seealso>
        Task<ExecuteScheduledQueryResponse> ExecuteScheduledQueryAsync(ExecuteScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListScheduledQueries



        /// <summary>
        /// Gets a list of all scheduled queries in the caller's Amazon account and Region. <c>ListScheduledQueries</c>
        /// is eventually consistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledQueries service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ListScheduledQueries">REST API Reference for ListScheduledQueries Operation</seealso>
        Task<ListScheduledQueriesResponse> ListScheduledQueriesAsync(ListScheduledQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// List all tags on a Timestream query resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PrepareQuery



        /// <summary>
        /// A synchronous operation that allows you to submit a query with parameters to be stored
        /// by Timestream for later running. Timestream only supports using this operation with
        /// <c>ValidateOnly</c> set to <c>true</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PrepareQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PrepareQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/PrepareQuery">REST API Reference for PrepareQuery Operation</seealso>
        Task<PrepareQueryResponse> PrepareQueryAsync(PrepareQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Query



        /// <summary>
        /// <c>Query</c> is a synchronous operation that enables you to run a query against your
        /// Amazon Timestream data.
        /// 
        ///  
        /// <para>
        /// If you enabled <c>QueryInsights</c>, this API also returns insights and metrics related
        /// to the query that you executed. <c>QueryInsights</c> helps with performance tuning
        /// of your query. For more information about <c>QueryInsights</c>, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/using-query-insights.html">Using
        /// query insights to optimize queries in Amazon Timestream</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The maximum number of <c>Query</c> API requests you're allowed to make with <c>QueryInsights</c>
        /// enabled is 1 query per second (QPS). If you exceed this query rate, it might result
        /// in throttling.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>Query</c> will time out after 60 seconds. You must update the default timeout
        /// in the SDK to support a timeout of 60 seconds. See the <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.run-query.html">code
        /// sample</a> for details. 
        /// </para>
        ///  
        /// <para>
        /// Your query request will fail in the following cases:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  If you submit a <c>Query</c> request with the same client token outside of the 5-minute
        /// idempotency window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If you submit a <c>Query</c> request with the same client token, but change other
        /// parameters, within the 5-minute idempotency window. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the size of the row (including the query metadata) exceeds 1 MB, then the query
        /// will fail with the following error message: 
        /// </para>
        ///  
        /// <para>
        ///  <c>Query aborted as max page response size has been exceeded by the output result
        /// row</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  If the IAM principal of the query initiator and the result reader are not the same
        /// and/or the query initiator and the result reader do not have the same query string
        /// in the query requests, the query will fail with an <c>Invalid pagination token</c>
        /// error. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Query service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ConflictException">
        /// Unable to poll results for a cancelled query.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.QueryExecutionException">
        /// Timestream was unable to run the query successfully.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/Query">REST API Reference for Query Operation</seealso>
        Task<QueryResponse> QueryAsync(QueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Associate a set of tags with a Timestream resource. You can then activate these user-defined
        /// tags so that they appear on the Billing and Cost Management console for cost allocation
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ServiceQuotaExceededException">
        /// You have exceeded the service quota.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the association of tags from a Timestream query resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAccountSettings



        /// <summary>
        /// Transitions your account to use TCUs for query pricing and modifies the maximum query
        /// compute units that you've configured. If you reduce the value of <c>MaxQueryTCU</c>
        /// to a desired configuration, the new value can take up to 24 hours to be effective.
        /// 
        ///  <note> 
        /// <para>
        /// After you've transitioned your account to use TCUs for query pricing, you can't transition
        /// to using bytes scanned for query pricing.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateScheduledQuery



        /// <summary>
        /// Update a scheduled query.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledQuery service method, as returned by TimestreamQuery.</returns>
        /// <exception cref="Amazon.TimestreamQuery.Model.AccessDeniedException">
        /// You do not have the necessary permissions to access the account settings.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.InvalidEndpointException">
        /// The requested endpoint is invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ThrottlingException">
        /// The request was throttled due to excessive requests.
        /// </exception>
        /// <exception cref="Amazon.TimestreamQuery.Model.ValidationException">
        /// Invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-query-2018-11-01/UpdateScheduledQuery">REST API Reference for UpdateScheduledQuery Operation</seealso>
        Task<UpdateScheduledQueryResponse> UpdateScheduledQueryAsync(UpdateScheduledQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonTimestreamQueryConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonTimestreamQueryConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonTimestreamQueryConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonTimestreamQueryConfig to create AmazonTimestreamQueryClient");
            }

            return awsCredentials == null ? 
                    new AmazonTimestreamQueryClient(serviceClientConfig) :
                    new AmazonTimestreamQueryClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}