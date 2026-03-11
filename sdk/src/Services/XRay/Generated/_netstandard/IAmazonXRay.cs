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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.XRay.Model;

#pragma warning disable CS1570
namespace Amazon.XRay
{
    /// <summary>
    /// <para>Interface for accessing XRay</para>
    ///
    /// Amazon Web Services X-Ray provides APIs for managing debug traces and retrieving service
    /// maps and other data created by processing those traces.
    /// </summary>
    public partial interface IAmazonXRay : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IXRayPaginatorFactory Paginators { get; }
#endif
                
        #region  BatchGetTraces



        /// <summary>
        /// <note> 
        /// <para>
        /// You cannot find traces through this API if Transaction Search is enabled since trace
        /// is not indexed in X-Ray.
        /// </para>
        ///  </note> 
        /// <para>
        /// Retrieves a list of traces specified by ID. Each trace is a collection of segment
        /// documents that originates from a single request. Use <c>GetTraceSummaries</c> to get
        /// a list of trace IDs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTraces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/BatchGetTraces">REST API Reference for BatchGetTraces Operation</seealso>
        Task<BatchGetTracesResponse> BatchGetTracesAsync(BatchGetTracesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelTraceRetrieval



        /// <summary>
        /// Cancels an ongoing trace retrieval job initiated by <c>StartTraceRetrieval</c> using
        /// the provided <c>RetrievalToken</c>. A successful cancellation will return an HTTP
        /// 200 response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTraceRetrieval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelTraceRetrieval service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CancelTraceRetrieval">REST API Reference for CancelTraceRetrieval Operation</seealso>
        Task<CancelTraceRetrievalResponse> CancelTraceRetrievalAsync(CancelTraceRetrievalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGroup



        /// <summary>
        /// Creates a group resource with a name and a filter expression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSamplingRule



        /// <summary>
        /// Creates a rule to control sampling behavior for instrumented applications. Services
        /// retrieve rules with <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingRules.html">GetSamplingRules</a>,
        /// and evaluate each rule in ascending order of <i>priority</i> for each request. If
        /// a rule matches, the service records a trace, borrowing it from the reservoir size.
        /// After 10 seconds, the service reports back to X-Ray with <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetSamplingTargets.html">GetSamplingTargets</a>
        /// to get updated versions of each in-use rule. The updated rule contains a trace quota
        /// that the service can use instead of borrowing from the reservoir.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.RuleLimitExceededException">
        /// You have reached the maximum number of sampling rules.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/CreateSamplingRule">REST API Reference for CreateSamplingRule Operation</seealso>
        Task<CreateSamplingRuleResponse> CreateSamplingRuleAsync(CreateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteGroup



        /// <summary>
        /// Deletes a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteResourcePolicy



        /// <summary>
        /// Deletes a resource policy from the target Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidPolicyRevisionIdException">
        /// A policy revision id was provided which does not match the latest policy revision.
        /// This exception is also if a policy revision id of 0 is provided via <c>PutResourcePolicy</c>
        /// and a policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSamplingRule



        /// <summary>
        /// Deletes a sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/DeleteSamplingRule">REST API Reference for DeleteSamplingRule Operation</seealso>
        Task<DeleteSamplingRuleResponse> DeleteSamplingRuleAsync(DeleteSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEncryptionConfig



        /// <summary>
        /// Retrieves the current encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetEncryptionConfig">REST API Reference for GetEncryptionConfig Operation</seealso>
        Task<GetEncryptionConfigResponse> GetEncryptionConfigAsync(GetEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroup



        /// <summary>
        /// Retrieves group resource details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroup">REST API Reference for GetGroup Operation</seealso>
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetGroups



        /// <summary>
        /// Retrieves all active group details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGroups service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetGroups">REST API Reference for GetGroups Operation</seealso>
        Task<GetGroupsResponse> GetGroupsAsync(GetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIndexingRules



        /// <summary>
        /// Retrieves all indexing rules.
        /// 
        ///  
        /// <para>
        /// Indexing rules are used to determine the server-side sampling rate for spans ingested
        /// through the CloudWatchLogs destination and indexed by X-Ray. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIndexingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetIndexingRules">REST API Reference for GetIndexingRules Operation</seealso>
        Task<GetIndexingRulesResponse> GetIndexingRulesAsync(GetIndexingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInsight



        /// <summary>
        /// Retrieves the summary information of an insight. This includes impact to clients and
        /// root cause services, the top anomalous services, the category, the state of the insight,
        /// and the start and end time of the insight.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsight service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsight service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsight">REST API Reference for GetInsight Operation</seealso>
        Task<GetInsightResponse> GetInsightAsync(GetInsightRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInsightEvents



        /// <summary>
        /// X-Ray reevaluates insights periodically until they're resolved, and records each intermediate
        /// state as an event. You can review an insight's events in the Impact Timeline on the
        /// Inspect page in the X-Ray console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightEvents service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightEvents">REST API Reference for GetInsightEvents Operation</seealso>
        Task<GetInsightEventsResponse> GetInsightEventsAsync(GetInsightEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInsightImpactGraph



        /// <summary>
        /// Retrieves a service graph structure filtered by the specified insight. The service
        /// graph is limited to only structural information. For a complete service graph, use
        /// this API with the GetServiceGraph API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightImpactGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightImpactGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightImpactGraph">REST API Reference for GetInsightImpactGraph Operation</seealso>
        Task<GetInsightImpactGraphResponse> GetInsightImpactGraphAsync(GetInsightImpactGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetInsightSummaries



        /// <summary>
        /// Retrieves the summaries of all insights in the specified group matching the provided
        /// filter values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetInsightSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetInsightSummaries">REST API Reference for GetInsightSummaries Operation</seealso>
        Task<GetInsightSummariesResponse> GetInsightSummariesAsync(GetInsightSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRetrievedTracesGraph



        /// <summary>
        /// Retrieves a service graph for traces based on the specified <c>RetrievalToken</c>
        /// from the CloudWatch log group generated by Transaction Search. This API does not initiate
        /// a retrieval job. You must first execute <c>StartTraceRetrieval</c> to obtain the required
        /// <c>RetrievalToken</c>. 
        /// 
        ///  
        /// <para>
        /// The trace graph describes services that process incoming requests and any downstream
        /// services they call, which may include Amazon Web Services resources, external APIs,
        /// or databases.
        /// </para>
        ///  
        /// <para>
        /// The response is empty until the <c>RetrievalStatus</c> is <i>COMPLETE</i>. Retry the
        /// request after the status changes from <i>RUNNING</i> or <i>SCHEDULED</i> to <i>COMPLETE</i>
        /// to access the full service graph.
        /// </para>
        ///  
        /// <para>
        ///  When CloudWatch log is the destination, this API can support cross-account observability
        /// and service graph retrieval across linked accounts.
        /// </para>
        ///  
        /// <para>
        /// For retrieving graphs from X-Ray directly as opposed to the Transaction-Search Log
        /// group, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_GetTraceGraph.html">GetTraceGraph</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetrievedTracesGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRetrievedTracesGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetRetrievedTracesGraph">REST API Reference for GetRetrievedTracesGraph Operation</seealso>
        Task<GetRetrievedTracesGraphResponse> GetRetrievedTracesGraphAsync(GetRetrievedTracesGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSamplingRules



        /// <summary>
        /// Retrieves all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingRules service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingRules">REST API Reference for GetSamplingRules Operation</seealso>
        Task<GetSamplingRulesResponse> GetSamplingRulesAsync(GetSamplingRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSamplingStatisticSummaries



        /// <summary>
        /// Retrieves information about recent sampling results for all sampling rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingStatisticSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingStatisticSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingStatisticSummaries">REST API Reference for GetSamplingStatisticSummaries Operation</seealso>
        Task<GetSamplingStatisticSummariesResponse> GetSamplingStatisticSummariesAsync(GetSamplingStatisticSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSamplingTargets



        /// <summary>
        /// Requests a sampling quota for rules that the service is using to sample requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSamplingTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSamplingTargets service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetSamplingTargets">REST API Reference for GetSamplingTargets Operation</seealso>
        Task<GetSamplingTargetsResponse> GetSamplingTargetsAsync(GetSamplingTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetServiceGraph



        /// <summary>
        /// Retrieves a document that describes services that process incoming requests, and downstream
        /// services that they call as a result. Root services process incoming requests and make
        /// calls to downstream services. Root services are applications that use the <a href="https://docs.aws.amazon.com/xray/index.html">Amazon
        /// Web Services X-Ray SDK</a>. Downstream services can be other applications, Amazon
        /// Web Services resources, HTTP web APIs, or SQL databases.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetServiceGraph">REST API Reference for GetServiceGraph Operation</seealso>
        Task<GetServiceGraphResponse> GetServiceGraphAsync(GetServiceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTimeSeriesServiceStatistics



        /// <summary>
        /// Get an aggregation of service statistics defined by a specific time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTimeSeriesServiceStatistics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTimeSeriesServiceStatistics service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTimeSeriesServiceStatistics">REST API Reference for GetTimeSeriesServiceStatistics Operation</seealso>
        Task<GetTimeSeriesServiceStatisticsResponse> GetTimeSeriesServiceStatisticsAsync(GetTimeSeriesServiceStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTraceGraph



        /// <summary>
        /// Retrieves a service graph for one or more specific trace IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceGraph service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceGraph service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceGraph">REST API Reference for GetTraceGraph Operation</seealso>
        Task<GetTraceGraphResponse> GetTraceGraphAsync(GetTraceGraphRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTraceSegmentDestination



        /// <summary>
        /// Retrieves the current destination of data sent to <c>PutTraceSegments</c> and <i>OpenTelemetry
        /// protocol (OTLP)</i> endpoint. The Transaction Search feature requires a CloudWatchLogs
        /// destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a> and <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-OpenTelemetry-Sections.html">OpenTelemetry</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSegmentDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceSegmentDestination service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSegmentDestination">REST API Reference for GetTraceSegmentDestination Operation</seealso>
        Task<GetTraceSegmentDestinationResponse> GetTraceSegmentDestinationAsync(GetTraceSegmentDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTraceSummaries



        /// <summary>
        /// Retrieves IDs and annotations for traces available for a specified time frame using
        /// an optional filter. To get the full traces, pass the trace IDs to <c>BatchGetTraces</c>.
        /// 
        ///  
        /// <para>
        /// A filter expression can target traced requests that hit specific service nodes or
        /// edges, have errors, or come from a known user. For example, the following filter expression
        /// targets traces that pass through <c>api.example.com</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>service("api.example.com")</c> 
        /// </para>
        ///  
        /// <para>
        /// This filter expression finds traces that have an annotation named <c>account</c> with
        /// the value <c>12345</c>:
        /// </para>
        ///  
        /// <para>
        ///  <c>annotation.account = "12345"</c> 
        /// </para>
        ///  
        /// <para>
        /// For a full list of indexed fields and keywords that you can use in filter expressions,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-console.html#xray-console-filters">Use
        /// filter expressions</a> in the <i>Amazon Web Services X-Ray Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTraceSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTraceSummaries service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/GetTraceSummaries">REST API Reference for GetTraceSummaries Operation</seealso>
        Task<GetTraceSummariesResponse> GetTraceSummariesAsync(GetTraceSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourcePolicies



        /// <summary>
        /// Returns the list of resource policies in the target Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcePolicies service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        Task<ListResourcePoliciesResponse> ListResourcePoliciesAsync(ListResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRetrievedTraces



        /// <summary>
        /// Retrieves a list of traces for a given <c>RetrievalToken</c> from the CloudWatch
        /// log group generated by Transaction Search. For information on what each trace returns,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// This API does not initiate a retrieval process. To start a trace retrieval, use <c>StartTraceRetrieval</c>,
        /// which generates the required <c>RetrievalToken</c>.
        /// </para>
        ///  
        /// <para>
        ///  When the <c>RetrievalStatus</c> is not <i>COMPLETE</i>, the API will return an empty
        /// response. Retry the request once the retrieval has completed to access the full list
        /// of traces.
        /// </para>
        ///  
        /// <para>
        /// For cross-account observability, this API can retrieve traces from linked accounts
        /// when CloudWatch log is set as the destination across relevant accounts. For more details,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  
        /// <para>
        /// For retrieving data from X-Ray directly as opposed to the Transaction Search generated
        /// log group, see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievedTraces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetrievedTraces service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListRetrievedTraces">REST API Reference for ListRetrievedTraces Operation</seealso>
        Task<ListRetrievedTracesResponse> ListRetrievedTracesAsync(ListRetrievedTracesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags that are applied to the specified Amazon Web Services X-Ray
        /// group or sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutEncryptionConfig



        /// <summary>
        /// Updates the encryption configuration for X-Ray data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEncryptionConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutEncryptionConfig service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutEncryptionConfig">REST API Reference for PutEncryptionConfig Operation</seealso>
        Task<PutEncryptionConfigResponse> PutEncryptionConfigAsync(PutEncryptionConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutResourcePolicy



        /// <summary>
        /// Sets the resource policy to grant one or more Amazon Web Services services and accounts
        /// permissions to access X-Ray. Each resource policy will be associated with a specific
        /// Amazon Web Services account. Each Amazon Web Services account can have a maximum of
        /// 5 resource policies, and each policy name must be unique within that account. The
        /// maximum size of each resource policy is 5KB.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidPolicyRevisionIdException">
        /// A policy revision id was provided which does not match the latest policy revision.
        /// This exception is also if a policy revision id of 0 is provided via <c>PutResourcePolicy</c>
        /// and a policy with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.LockoutPreventionException">
        /// The provided resource policy would prevent the caller of this request from calling
        /// PutResourcePolicy in the future.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.MalformedPolicyDocumentException">
        /// Invalid policy document provided in request.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.PolicyCountLimitExceededException">
        /// Exceeded the maximum number of resource policies for a target Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.PolicySizeLimitExceededException">
        /// Exceeded the maximum size for a resource policy.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTelemetryRecords



        /// <summary>
        /// Used by the Amazon Web Services X-Ray daemon to upload telemetry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTelemetryRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTelemetryRecords service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTelemetryRecords">REST API Reference for PutTelemetryRecords Operation</seealso>
        Task<PutTelemetryRecordsResponse> PutTelemetryRecordsAsync(PutTelemetryRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutTraceSegments



        /// <summary>
        /// Uploads segment documents to Amazon Web Services X-Ray. A segment document can be
        /// a completed segment, an in-progress segment, or an array of subsegments.
        /// 
        ///  
        /// <para>
        /// Segments must include the following fields. For the full segment document schema,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/devguide/aws-xray-interface-api.html#xray-api-segmentdocuments.html">Amazon
        /// Web Services X-Ray Segment Documents</a> in the <i>Amazon Web Services X-Ray Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required segment document fields</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>name</c> - The name of the service that handled the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>id</c> - A 64-bit identifier for the segment, unique among segments in the same
        /// trace, in 16 hexadecimal digits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>trace_id</c> - A unique identifier that connects all segments and subsegments
        /// originating from a single client request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>start_time</c> - Time the segment or subsegment was created, in floating point
        /// seconds in epoch time, accurate to milliseconds. For example, <c>1480615200.010</c>
        /// or <c>1.480615200010E9</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>end_time</c> - Time the segment or subsegment was closed. For example, <c>1480615200.090</c>
        /// or <c>1.480615200090E9</c>. Specify either an <c>end_time</c> or <c>in_progress</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>in_progress</c> - Set to <c>true</c> instead of specifying an <c>end_time</c>
        /// to record that a segment has been started, but is not complete. Send an in-progress
        /// segment when your application receives a request that will take a long time to serve,
        /// to trace that the request was received. When the response is sent, send the complete
        /// segment to overwrite the in-progress segment.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A <c>trace_id</c> consists of three numbers separated by hyphens. For example, 1-58406520-a006649127e371903a2de979.
        /// For trace IDs created by an X-Ray SDK, or by Amazon Web Services services integrated
        /// with X-Ray, a trace ID includes:
        /// </para>
        ///  
        /// <para>
        ///  <b>Trace ID Format</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The version number, for instance, <c>1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The time of the original request, in Unix epoch time, in 8 hexadecimal digits. For
        /// example, 10:00AM December 2nd, 2016 PST in epoch time is <c>1480615200</c> seconds,
        /// or <c>58406520</c> in hexadecimal.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A 96-bit identifier for the trace, globally unique, in 24 hexadecimal digits.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Trace IDs created via OpenTelemetry have a different format based on the <a href="https://www.w3.org/TR/trace-context/">W3C
        /// Trace Context specification</a>. A W3C trace ID must be formatted in the X-Ray trace
        /// ID format when sending to X-Ray. For example, a W3C trace ID <c>4efaaf4d1e8720b39541901950019ee5</c>
        /// should be formatted as <c>1-4efaaf4d-1e8720b39541901950019ee5</c> when sending to
        /// X-Ray. While X-Ray trace IDs include the original request timestamp in Unix epoch
        /// time, this is not required or validated. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTraceSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTraceSegments service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/PutTraceSegments">REST API Reference for PutTraceSegments Operation</seealso>
        Task<PutTraceSegmentsResponse> PutTraceSegmentsAsync(PutTraceSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartTraceRetrieval



        /// <summary>
        /// Initiates a trace retrieval process using the specified time range and for the given
        /// trace IDs in the Transaction Search generated CloudWatch log group. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>. 
        /// 
        ///  
        /// <para>
        /// API returns a <c>RetrievalToken</c>, which can be used with <c>ListRetrievedTraces</c>
        /// or <c>GetRetrievedTracesGraph</c> to fetch results. Retrievals will time out after
        /// 60 minutes. To execute long time ranges, consider segmenting into multiple retrievals.
        /// </para>
        ///  
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>, you can use this operation in a monitoring account
        /// to retrieve data from a linked source account, as long as both accounts have transaction
        /// search enabled.
        /// </para>
        ///  
        /// <para>
        /// For retrieving data from X-Ray directly as opposed to the Transaction-Search Log group,
        /// see <a href="https://docs.aws.amazon.com/xray/latest/api/API_BatchGetTraces.html">BatchGetTraces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartTraceRetrieval service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartTraceRetrieval service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/StartTraceRetrieval">REST API Reference for StartTraceRetrieval Operation</seealso>
        Task<StartTraceRetrievalResponse> StartTraceRetrievalAsync(StartTraceRetrievalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Applies tags to an existing Amazon Web Services X-Ray group or sampling rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.TooManyTagsException">
        /// You have exceeded the maximum number of tags you can apply to this resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from an Amazon Web Services X-Ray group or sampling rule. You cannot
        /// edit or delete system tags (those with an <c>aws:</c> prefix).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateGroup



        /// <summary>
        /// Updates a group resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIndexingRule



        /// <summary>
        /// Modifies an indexing rule’s configuration. 
        /// 
        ///  
        /// <para>
        /// Indexing rules are used for determining the sampling rate for spans indexed from CloudWatch
        /// Logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIndexingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ResourceNotFoundException">
        /// The resource was not found. Verify that the name or Amazon Resource Name (ARN) of
        /// the resource is correct.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateIndexingRule">REST API Reference for UpdateIndexingRule Operation</seealso>
        Task<UpdateIndexingRuleResponse> UpdateIndexingRuleAsync(UpdateIndexingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSamplingRule



        /// <summary>
        /// Modifies a sampling rule's configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSamplingRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSamplingRule service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateSamplingRule">REST API Reference for UpdateSamplingRule Operation</seealso>
        Task<UpdateSamplingRuleResponse> UpdateSamplingRuleAsync(UpdateSamplingRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTraceSegmentDestination



        /// <summary>
        /// Modifies the destination of data sent to <c>PutTraceSegments</c>. The Transaction
        /// Search feature requires the CloudWatchLogs destination. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Transaction-Search.html">Transaction
        /// Search</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTraceSegmentDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTraceSegmentDestination service method, as returned by XRay.</returns>
        /// <exception cref="Amazon.XRay.Model.InvalidRequestException">
        /// The request is missing required parameters or has invalid parameters.
        /// </exception>
        /// <exception cref="Amazon.XRay.Model.ThrottledException">
        /// The request exceeds the maximum number of requests per second.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/xray-2016-04-12/UpdateTraceSegmentDestination">REST API Reference for UpdateTraceSegmentDestination Operation</seealso>
        Task<UpdateTraceSegmentDestinationResponse> UpdateTraceSegmentDestinationAsync(UpdateTraceSegmentDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonXRayConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonXRayConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonXRayConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonXRayConfig to create AmazonXRayClient");
            }

            return awsCredentials == null ? 
                    new AmazonXRayClient(serviceClientConfig) :
                    new AmazonXRayClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}