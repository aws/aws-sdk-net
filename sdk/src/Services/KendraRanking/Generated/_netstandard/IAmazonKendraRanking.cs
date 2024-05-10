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
 * Do not modify this file. This file is generated from the kendra-ranking-2022-10-19.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KendraRanking.Model;

#pragma warning disable CS1570
namespace Amazon.KendraRanking
{
    /// <summary>
    /// <para>Interface for accessing KendraRanking</para>
    ///
    /// Amazon Kendra Intelligent Ranking uses Amazon Kendra semantic search capabilities
    /// to intelligently re-rank a search service's results.
    /// </summary>
    public partial interface IAmazonKendraRanking : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKendraRankingPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateRescoreExecutionPlan



        /// <summary>
        /// Creates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <c>Rescore</c> API. You set the number
        /// of capacity units that you require for Amazon Kendra Intelligent Ranking to rescore
        /// or re-rank a search service's results.
        /// 
        ///  
        /// <para>
        /// For an example of using the <c>CreateRescoreExecutionPlan</c> API, including using
        /// the Python and Java SDKs, see <a href="https://docs.aws.amazon.com/kendra/latest/dg/search-service-rerank.html">Semantically
        /// ranking a search service's results</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra Intelligent Ranking service.
        /// Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/CreateRescoreExecutionPlan">REST API Reference for CreateRescoreExecutionPlan Operation</seealso>
        Task<CreateRescoreExecutionPlanResponse> CreateRescoreExecutionPlanAsync(CreateRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRescoreExecutionPlan



        /// <summary>
        /// Deletes a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <c>Rescore</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DeleteRescoreExecutionPlan">REST API Reference for DeleteRescoreExecutionPlan Operation</seealso>
        Task<DeleteRescoreExecutionPlanResponse> DeleteRescoreExecutionPlanAsync(DeleteRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRescoreExecutionPlan



        /// <summary>
        /// Gets information about a rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <c>Rescore</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/DescribeRescoreExecutionPlan">REST API Reference for DescribeRescoreExecutionPlan Operation</seealso>
        Task<DescribeRescoreExecutionPlanResponse> DescribeRescoreExecutionPlanAsync(DescribeRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRescoreExecutionPlans



        /// <summary>
        /// Lists your rescore execution plans. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <c>Rescore</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRescoreExecutionPlans service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRescoreExecutionPlans service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListRescoreExecutionPlans">REST API Reference for ListRescoreExecutionPlans Operation</seealso>
        Task<ListRescoreExecutionPlansResponse> ListRescoreExecutionPlansAsync(ListRescoreExecutionPlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Gets a list of tags associated with a specified resource. A rescore execution plan
        /// is an example of a resource that can have tags associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Rescore



        /// <summary>
        /// Rescores or re-ranks search results from a search service such as OpenSearch (self
        /// managed). You use the semantic search capabilities of Amazon Kendra Intelligent Ranking
        /// to improve the search service's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Rescore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Rescore service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/Rescore">REST API Reference for Rescore Operation</seealso>
        Task<RescoreResponse> RescoreAsync(RescoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds a specified tag to a specified rescore execution plan. A rescore execution plan
        /// is an Amazon Kendra Intelligent Ranking resource used for provisioning the <c>Rescore</c>
        /// API. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes a tag from a rescore execution plan. A rescore execution plan is an Amazon
        /// Kendra Intelligent Ranking resource used for provisioning the <c>Rescore</c> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceUnavailableException">
        /// The resource you want to use is unavailable. Please check you have provided the correct
        /// resource information and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRescoreExecutionPlan



        /// <summary>
        /// Updates a rescore execution plan. A rescore execution plan is an Amazon Kendra Intelligent
        /// Ranking resource used for provisioning the <c>Rescore</c> API. You can update the
        /// number of capacity units you require for Amazon Kendra Intelligent Ranking to rescore
        /// or re-rank a search service's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRescoreExecutionPlan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRescoreExecutionPlan service method, as returned by KendraRanking.</returns>
        /// <exception cref="Amazon.KendraRanking.Model.AccessDeniedException">
        /// You don’t have sufficient access to perform this action. Please ensure you have the
        /// required permission policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ConflictException">
        /// A conflict occurred with the request. Please fix any inconsistencies with your resources
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Kendra Intelligent
        /// Ranking service. Please wait a few minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ResourceNotFoundException">
        /// The resource you want to use doesn't exist. Please check you have provided the correct
        /// resource and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Kendra Intelligent Ranking service.
        /// Please see <a href="https://docs.aws.amazon.com/kendra/latest/dg/quotas.html">Quotas</a>
        /// for more information, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// to inquire about an increase of limits.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ThrottlingException">
        /// The request was denied due to request throttling. Please reduce the number of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.KendraRanking.Model.ValidationException">
        /// The input fails to satisfy the constraints set by the Amazon Kendra Intelligent Ranking
        /// service. Please provide the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kendra-ranking-2022-10-19/UpdateRescoreExecutionPlan">REST API Reference for UpdateRescoreExecutionPlan Operation</seealso>
        Task<UpdateRescoreExecutionPlanResponse> UpdateRescoreExecutionPlanAsync(UpdateRescoreExecutionPlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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