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
    /// Amazon Simple Notification Service <para>Amazon Simple Notification Service (Amazon SNS) is a web service that enables you to build
    /// distributed web-enabled applications. Applications can use Amazon SNS to easily push real-time notification messages to interested
    /// subscribers over multiple delivery protocols. For more information about this product see http://aws.amazon.com/sns. For detailed
    /// information about Amazon SNS features and their associated API calls, see the Amazon SNS Getting Started Guide. </para> <para>We also
    /// provide SDKs that enable you to access Amazon SNS from your preferred programming language. The SDKs contain functionality that
    /// automatically takes care of tasks such as: cryptographically signing your service requests, retrying requests, and handling error responses.
    /// For a list of available SDKs, go to Tools for Amazon Web Services. </para>
    /// </summary>
	public partial interface IAmazonSimpleNotificationService : IDisposable
    {
 

        /// <summary>
        /// <para>The <c>AddPermission</c> action adds a statement to a topic's access control policy, granting access for the specified AWS accounts to
        /// the specified actions.</para>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
		AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>ConfirmSubscription</c> action verifies an endpoint owner's intent to receive messages by validating the token sent to the
        /// endpoint by an earlier <c>Subscribe</c> action. If the token is valid, the action creates a new subscription and returns its Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <c>AuthenticateOnUnsubscribe</c> flag is set to "true".</para>
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
		ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ConfirmSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>CreateTopic</c> action creates a topic to which notifications can be published. Users can create at most 100 topics. For more
        /// information, see http://aws.amazon.com/sns. This action is idempotent, so if the requester already owns a topic with the specified name,
        /// that topic's ARN is returned without creating a new topic.</para>
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
		CreateTopicResponse CreateTopic(CreateTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreateTopic"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>DeleteTopic</c> action deletes a topic and all its subscriptions. Deleting a topic might prevent some messages previously sent
        /// to the topic from being delivered to subscribers. This action is idempotent, so deleting a topic that does not exist does not result in an
        /// error.</para>
        /// </summary>
        /// 
        /// <param name="deleteTopicRequest">Container for the necessary parameters to execute the DeleteTopic service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
		DeleteTopicResponse DeleteTopic(DeleteTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteTopic"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>GetSubscriptionAttribtues</c> action returns all of the properties of a subscription.</para>
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
		GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>GetTopicAttributes</c> action returns all of the properties of a topic. Topic properties returned might differ based on the
        /// authorization of the user. </para>
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
		GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>ListSubscriptions</c> action returns a list of the requester's subscriptions. Each call returns a limited list of
        /// subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new
        /// <c>ListSubscriptions</c> call to get further results.</para>
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
		ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <c>ListSubscriptions</c> action returns a list of the requester's subscriptions. Each call returns a limited list of
        /// subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new
        /// <c>ListSubscriptions</c> call to get further results.</para>
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
		ListSubscriptionsResponse ListSubscriptions();
 

        /// <summary>
        /// <para>The <c>ListSubscriptionsByTopic</c> action returns a list of the subscriptions to a specific topic. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a
        /// new <c>ListSubscriptionsByTopic</c> call to get further results.</para>
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
		ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptionsByTopic"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>ListTopics</c> action returns a list of the requester's topics. Each call returns a limited list of topics, up to 100. If there
        /// are more topics, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further
        /// results.</para>
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
		ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListTopics"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <c>ListTopics</c> action returns a list of the requester's topics. Each call returns a limited list of topics, up to 100. If there
        /// are more topics, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further
        /// results.</para>
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
		ListTopicsResponse ListTopics();
 

        /// <summary>
        /// <para>The <c>Publish</c> action sends a message to all of a topic's subscribed endpoints. When a <c>messageId</c> is returned, the message
        /// has been saved and Amazon SNS will attempt to deliver it to the topic's subscribers shortly. The format of the outgoing message to each
        /// subscribed endpoint depends on the notification protocol selected.</para>
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
		PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Publish"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PublishResponse> PublishAsync(PublishRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>RemovePermission</c> action removes a statement from a topic's access control policy.</para>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
		RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>SetSubscriptionAttributes</c> action allows a subscription owner to set an attribute of the topic to a new value.</para>
        /// </summary>
        /// 
        /// <param name="setSubscriptionAttributesRequest">Container for the necessary parameters to execute the SetSubscriptionAttributes service
        /// method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
		SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>SetTopicAttributes</c> action allows a topic owner to set an attribute of the topic to a new value.</para>
        /// </summary>
        /// 
        /// <param name="setTopicAttributesRequest">Container for the necessary parameters to execute the SetTopicAttributes service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
		SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>Subscribe</c> action prepares to subscribe an endpoint by sending the endpoint a confirmation message. To actually create a
        /// subscription, the endpoint owner must call the <c>ConfirmSubscription</c> action with the token from the confirmation message. Confirmation
        /// tokens are valid for three days.</para>
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
		SubscribeResponse Subscribe(SubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Subscribe"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>The <c>Unsubscribe</c> action deletes a subscription. If the subscription requires authentication for deletion, only the owner of the
        /// subscription or the topic's owner can unsubscribe, and an AWS signature is required. If the <c>Unsubscribe</c> call does not require
        /// authentication and the requester is not the subscription owner, a final cancellation message is delivered to the endpoint, so that the
        /// endpoint owner can easily resubscribe to the topic if the <c>Unsubscribe</c> request was unintended.</para>
        /// </summary>
        /// 
        /// <param name="unsubscribeRequest">Container for the necessary parameters to execute the Unsubscribe service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
		UnsubscribeResponse Unsubscribe(UnsubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Unsubscribe"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
