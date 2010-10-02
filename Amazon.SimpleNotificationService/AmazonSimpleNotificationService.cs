/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-03-31
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Amazon Simple Notification Service
    /// </summary>
    public interface AmazonSimpleNotificationService : IDisposable
    {
        /// <summary>
        /// Confirm Subscription
        /// </summary>
        /// <param name="request">Confirm Subscription  request</param>
        /// <returns>Confirm Subscription  Response from the service</returns>
        /// <remarks>
        /// The ConfirmSubscription action verifies an endpoint owner's intent to receive messages by validating
        /// the token sent to the endpoint by an earlier Subscribe action. If the
        /// token is valid, the action creates a new subscription and returns its
        /// Amazon Resource Name (ARN). This call requires an AWS signature only when the AuthenticateOnUnsubscribe flag is set to "true".
        /// </remarks>
        ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request);

        /// <summary>
        /// Get Topic Attributes
        /// </summary>
        /// <param name="request">Get Topic Attributes  request</param>
        /// <returns>Get Topic Attributes  Response from the service</returns>
        /// <remarks>
        /// The GetTopicAttribtues action returns all of the properties of a topic customers have created. Topic
        /// properties returned might differ based on the authorization of the user.
        /// </remarks>
        GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request);

        /// <summary>
        /// Subscribe
        /// </summary>
        /// <param name="request">Subscribe  request</param>
        /// <returns>Subscribe  Response from the service</returns>
        /// <remarks>
        /// The Subscribe action prepares to subscribe an endpoint by sending the endpoint a confirmation message. To actually create a
        /// subscription, the endpoint owner must call the ConfirmSubscription
        /// action with the token from the confirmation message. Confirmation tokens are
        /// valid for twenty-four hours.
        /// </remarks>
        SubscribeResponse Subscribe(SubscribeRequest request);

        /// <summary>
        /// Set Topic Attributes
        /// </summary>
        /// <param name="request">Set Topic Attributes  request</param>
        /// <returns>Set Topic Attributes  Response from the service</returns>
        /// <remarks>
        /// The SetTopicAttributes action allows a topic owner to set an attribute of the topic to a new value.
        /// </remarks>
        SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request);

        /// <summary>
        /// Delete Topic
        /// </summary>
        /// <param name="request">Delete Topic  request</param>
        /// <returns>Delete Topic  Response from the service</returns>
        /// <remarks>
        /// The DeleteTopic action deletes a topic and all its subscriptions. Deleting a topic might
        /// prevent some messages previously sent to the topic from being delivered to
        /// subscribers. This action is idempotent, so deleting a topic that does not
        /// exist will not result in an error.
        /// </remarks>
        DeleteTopicResponse DeleteTopic(DeleteTopicRequest request);

        /// <summary>
        /// Remove Permission
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        /// <remarks>
        /// The RemovePermission action removes a statement from a topic's access control policy.
        /// </remarks>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// List Subscriptions
        /// </summary>
        /// <param name="request">List Subscriptions  request</param>
        /// <returns>List Subscriptions  Response from the service</returns>
        /// <remarks>
        /// The ListSubscriptions action returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions. If there are more subscriptions, a NextToken is also returned. Use the NextToken parameter in a
        /// new ListSubscriptions call to get further results.
        /// </remarks>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Add Permission
        /// </summary>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        /// <remarks>
        /// The AddPermission action adds a statement to a topic's access control policy, granting access for the specified AWS accounts to the specified actions.
        /// </remarks>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Create Topic
        /// </summary>
        /// <param name="request">Create Topic  request</param>
        /// <returns>Create Topic  Response from the service</returns>
        /// <remarks>
        /// The CreateTopic action creates a topic to which notifications can be published. Users can create
        /// at most 25 topics. This action is idempotent, so if the requester
        /// already owns a topic with the specified name, that topic's ARN will be
        /// returned without creating a new topic.
        /// </remarks>
        CreateTopicResponse CreateTopic(CreateTopicRequest request);

        /// <summary>
        /// List Topics
        /// </summary>
        /// <param name="request">List Topics  request</param>
        /// <returns>List Topics  Response from the service</returns>
        /// <remarks>
        /// The ListTopics action returns a list of the requester's topics. Each call returns a limited list of topics. If
        /// there are more topics, a NextToken is also returned. Use the NextToken parameter in a new ListTopics call to get
        /// further results.
        /// </remarks>
        ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Unsubscribe
        /// </summary>
        /// <param name="request">Unsubscribe  request</param>
        /// <returns>Unsubscribe  Response from the service</returns>
        /// <remarks>
        /// The Unsubscribe action deletes a subscription. If the subscription requires authentication for
        /// deletion, only the owner of the subscription or the its topic's owner
        /// can unsubscribe, and an AWS signature is required. If the
        /// Unsubscribe call does not require authentication and the requester is not
        /// the subscription owner, a final cancellation message is delivered to the
        /// endpoint, so that the endpoint owner can easily resubscribe to the topic if
        /// the Unsubscribe request was unintended.
        /// </remarks>
        UnsubscribeResponse Unsubscribe(UnsubscribeRequest request);

        /// <summary>
        /// List Subscriptions By Topic
        /// </summary>
        /// <param name="request">List Subscriptions By Topic  request</param>
        /// <returns>List Subscriptions By Topic  Response from the service</returns>
        /// <remarks>
        /// The ListSubscriptionsByTopic action returns a list of the subscriptions to a specific topic. Each call returns
        /// a limited list of subscriptions. If there are more subscriptions, a NextToken is also returned. Use the NextToken
        /// parameter in a new ListSubscriptionsByTopic call to get further results.
        /// </remarks>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Publish
        /// </summary>
        /// <param name="request">Publish  request</param>
        /// <returns>Publish  Response from the service</returns>
        /// <remarks>
        /// The Publish action sends a message to all of a topic's subscribed endpoints. When a
        /// messageId is returned, the message has been saved and Amazon SNS will attempt to deliver it
        /// to the topic's subscribers shortly. The format of the outgoing message to each
        /// subscribed endpoint depends on the notification protocol selected.
        /// </remarks>
        PublishResponse Publish(PublishRequest request);

    }
}
