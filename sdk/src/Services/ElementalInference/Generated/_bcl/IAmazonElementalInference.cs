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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ElementalInference.Model;

#pragma warning disable CS1570
namespace Amazon.ElementalInference
{
    /// <summary>
    /// <para>Interface for accessing ElementalInference</para>
    ///
    /// This is the AWS Elemental Inference REST API Reference. It provides information on
    /// the URL, request contents, and response contents of each AWS Elemental Inference REST
    /// operation. 
    /// 
    ///  
    /// <para>
    /// We assume that you have the IAM permissions that you need to use AWS Elemental Inference
    /// via the REST API. We also assume that you are familiar with the features and operations
    /// of AWS Elemental Inference as described in <i>AWS Elemental Inference User Guide</i>.
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonElementalInference : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IElementalInferencePaginatorFactory Paginators { get; }

        
        #region  AssociateFeed


        /// <summary>
        /// Associates a resource with the feed. The resource provides the input that Elemental
        /// Inference needs needs in order to perform an Elemental Inference feature, such as
        /// cropping video. You always provide the resource by associating it with a feed. You
        /// can associate only one resource with each feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFeed service method.</param>
        /// 
        /// <returns>The response from the AssociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        AssociateFeedResponse AssociateFeed(AssociateFeedRequest request);



        /// <summary>
        /// Associates a resource with the feed. The resource provides the input that Elemental
        /// Inference needs needs in order to perform an Elemental Inference feature, such as
        /// cropping video. You always provide the resource by associating it with a feed. You
        /// can associate only one resource with each feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/AssociateFeed">REST API Reference for AssociateFeed Operation</seealso>
        Task<AssociateFeedResponse> AssociateFeedAsync(AssociateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateFeed


        /// <summary>
        /// Creates a feed. The feed is the target for live streams being sent by the calling
        /// application. An example of a calling application is AWS Elemental MediaLive. After
        /// you create the feed, you can associate a resource with the feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeed service method.</param>
        /// 
        /// <returns>The response from the CreateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        CreateFeedResponse CreateFeed(CreateFeedRequest request);



        /// <summary>
        /// Creates a feed. The feed is the target for live streams being sent by the calling
        /// application. An example of a calling application is AWS Elemental MediaLive. After
        /// you create the feed, you can associate a resource with the feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/CreateFeed">REST API Reference for CreateFeed Operation</seealso>
        Task<CreateFeedResponse> CreateFeedAsync(CreateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFeed


        /// <summary>
        /// Deletes the specified feed. The feed can be deleted at any time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeed service method.</param>
        /// 
        /// <returns>The response from the DeleteFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        DeleteFeedResponse DeleteFeed(DeleteFeedRequest request);



        /// <summary>
        /// Deletes the specified feed. The feed can be deleted at any time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DeleteFeed">REST API Reference for DeleteFeed Operation</seealso>
        Task<DeleteFeedResponse> DeleteFeedAsync(DeleteFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateFeed


        /// <summary>
        /// Releases the resource (for example, an MediaLive channel) that is associated with
        /// this feed. The outputs in the feed become disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFeed service method.</param>
        /// 
        /// <returns>The response from the DisassociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        DisassociateFeedResponse DisassociateFeed(DisassociateFeedRequest request);



        /// <summary>
        /// Releases the resource (for example, an MediaLive channel) that is associated with
        /// this feed. The outputs in the feed become disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/DisassociateFeed">REST API Reference for DisassociateFeed Operation</seealso>
        Task<DisassociateFeedResponse> DisassociateFeedAsync(DisassociateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFeed


        /// <summary>
        /// Retrieves information about the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeed service method.</param>
        /// 
        /// <returns>The response from the GetFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        GetFeedResponse GetFeed(GetFeedRequest request);



        /// <summary>
        /// Retrieves information about the specified feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/GetFeed">REST API Reference for GetFeed Operation</seealso>
        Task<GetFeedResponse> GetFeedAsync(GetFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFeeds


        /// <summary>
        /// Displays a list of feeds that belong to this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeeds service method.</param>
        /// 
        /// <returns>The response from the ListFeeds service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        ListFeedsResponse ListFeeds(ListFeedsRequest request);



        /// <summary>
        /// Displays a list of feeds that belong to this AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFeeds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFeeds service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListFeeds">REST API Reference for ListFeeds Operation</seealso>
        Task<ListFeedsResponse> ListFeedsAsync(ListFeedsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags that are on an Elemental Inference resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List all tags that are on an Elemental Inference resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates the specified tags to the resource identified by the specified resourceArn
        /// in the current region. If existing tags on a resource are not specified in the request
        /// parameters, they are not changed. When a resource is deleted, the tags associated
        /// with that resource are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Associates the specified tags to the resource identified by the specified resourceArn
        /// in the current region. If existing tags on a resource are not specified in the request
        /// parameters, they are not changed. When a resource is deleted, the tags associated
        /// with that resource are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes specified tags from the specified resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes specified tags from the specified resource in the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFeed


        /// <summary>
        /// Updates the name and/or outputs in a feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeed service method.</param>
        /// 
        /// <returns>The response from the UpdateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        UpdateFeedResponse UpdateFeed(UpdateFeedRequest request);



        /// <summary>
        /// Updates the name and/or outputs in a feed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFeed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFeed service method, as returned by ElementalInference.</returns>
        /// <exception cref="Amazon.ElementalInference.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ConflictException">
        /// The request could not be completed due to a conflict.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.InternalServerErrorException">
        /// An internal server error occurred. This is a temporary condition and the request can
        /// be retried. If the problem persists, contact AWS Support.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ResourceNotFoundException">
        /// The resource specified in the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed one or more service quotas for your
        /// account. Review your service quotas and either delete unused resources or request
        /// a quota increase.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.TooManyRequestException">
        /// The request was denied due to request throttling. Too many requests have been made
        /// within a given time period. Reduce the frequency of requests and use exponential backoff
        /// when retrying.
        /// </exception>
        /// <exception cref="Amazon.ElementalInference.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service. Check the error
        /// message for details about which parameter or field is invalid and correct the request
        /// before retrying.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elementalinference-2018-11-14/UpdateFeed">REST API Reference for UpdateFeed Operation</seealso>
        Task<UpdateFeedResponse> UpdateFeedAsync(UpdateFeedRequest request, CancellationToken cancellationToken = default(CancellationToken));

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