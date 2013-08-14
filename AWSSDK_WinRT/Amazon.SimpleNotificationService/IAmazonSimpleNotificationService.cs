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
using System.Threading;
using System.Threading.Tasks;

using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Interface for accessing AmazonSimpleNotificationService.
    /// 
    /// 
    /// </summary>
	public partial interface IAmazonSimpleNotificationService : IDisposable
    {
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest addPermissionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="confirmSubscriptionRequest">Container for the necessary parameters to execute the ConfirmSubscription service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest confirmSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createTopicRequest">Container for the necessary parameters to execute the CreateTopic service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.TopicLimitExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest createTopicRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteTopicRequest">Container for the necessary parameters to execute the DeleteTopic service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest deleteTopicRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="getSubscriptionAttributesRequest">Container for the necessary parameters to execute the GetSubscriptionAttributes service
        /// method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="getTopicAttributesRequest">Container for the necessary parameters to execute the GetTopicAttributes service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest getTopicAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsRequest">Container for the necessary parameters to execute the ListSubscriptions service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest listSubscriptionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsByTopicRequest">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method
        /// on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listTopicsRequest">Container for the necessary parameters to execute the ListTopics service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest listTopicsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="publishRequest">Container for the necessary parameters to execute the Publish service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PublishResponse> PublishAsync(PublishRequest publishRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest removePermissionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setSubscriptionAttributesRequest">Container for the necessary parameters to execute the SetSubscriptionAttributes service
        /// method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setTopicAttributesRequest">Container for the necessary parameters to execute the SetTopicAttributes service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest setTopicAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="subscribeRequest">Container for the necessary parameters to execute the Subscribe service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SubscribeResponse> SubscribeAsync(SubscribeRequest subscribeRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="unsubscribeRequest">Container for the necessary parameters to execute the Unsubscribe service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest unsubscribeRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
