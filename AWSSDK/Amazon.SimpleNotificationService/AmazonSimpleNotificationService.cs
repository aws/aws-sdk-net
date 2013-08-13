/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// Verifies an endpoint owner's intent to receive messages by validating the token
        /// sent to the endpoint by an earlier Subscribe action.
        /// If the token is valid, the action creates a new subscription and returns its
        /// Amazon Resource Name (ARN).
        /// </summary>
        /// <remarks>
        /// This call requires an AWS signature only when the AuthenticateOnUnsubscribe
        /// flag is set to "true".
        /// </remarks>
        /// <param name="request">Confirm Subscription  request</param>
        /// <returns>Confirm Subscription  Response from the service</returns>
        ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request);

        /// <summary>
        /// Returns all of the properties of a topic customers have created. Topic
        /// properties returned might differ based on the authorization of the user.
        /// </summary>
        /// <param name="request">Get Topic Attributes  request</param>
        /// <returns>Get Topic Attributes  Response from the service</returns>
        GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request);

        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// </summary>
        /// <remarks>
        /// To actually create a subscription, the endpoint owner must call the ConfirmSubscription
        /// action with the token from the confirmation message. Confirmation tokens are valid for three days.
        /// </remarks>
        /// <param name="request">Subscribe  request</param>
        /// <returns>Subscribe  Response from the service</returns>
        SubscribeResponse Subscribe(SubscribeRequest request);

        /// <summary>
        /// Sets an attribute of a topic to a new value.
        /// </summary>
        /// <param name="request">Set Topic Attributes  request</param>
        /// <returns>Set Topic Attributes  Response from the service</returns>
        SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request);

        /// <summary>
        /// Returns all of the properties of a subscription customers have created. Subscription
        /// properties returned might differ based on the authorization of the user.
        /// </summary>
        /// <param name="request">Get Subscription Attributes  request</param>
        /// <returns>Get Subscription Attributes  Response from the service</returns>
        GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request);

        /// <summary>
        /// Sets an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Set Subscription Attributes  request</param>
        /// <returns>Set Subscription Attributes  Response from the service</returns>
        SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request);


        /// <summary>
        /// Deletes a topic and all its subscriptions.
        /// Deleting a topic might prevent some messages previously sent to the topic from being delivered to
        /// subscribers.
        /// </summary>
        /// <remarks>
        /// This operation is idempotent, so deleting a topic that does not
        /// exist will not result in an error.
        /// </remarks>
        /// <param name="request">Delete Topic  request</param>
        /// <returns>Delete Topic  Response from the service</returns>
        DeleteTopicResponse DeleteTopic(DeleteTopicRequest request);

        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Returns a list of the requester's subscriptions.
        /// </summary>
        /// <remarks>
        /// Each call returns a limited list of subscriptions. If there are more subscriptions,
        /// a NextToken is also returned. Use the NextToken parameter in a new ListSubscriptions
        /// call to get further results.
        /// </remarks>
        /// <param name="request">List Subscriptions  request</param>
        /// <returns>List Subscriptions  Response from the service</returns>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified AWS accounts to the specified actions.
        /// </summary>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create
        /// at most 25 topics.
        /// </summary>
        /// <remarks>
        /// This action is idempotent, so if the requester
        /// already owns a topic with the specified name, that topic's ARN will be
        /// returned without creating a new topic.
        /// </remarks>
        /// <param name="request">Create Topic  request</param>
        /// <returns>Create Topic  Response from the service</returns>
        CreateTopicResponse CreateTopic(CreateTopicRequest request);

        /// <summary>
        /// Returns a list of the requester's topics.
        /// </summary>
        /// <remarks>
        /// Each call returns a limited list of topics. If there are more topics,
        /// a NextToken is also returned. Use the NextToken parameter in a new
        /// ListTopics call to get further results.
        /// </remarks>
        /// <param name="request">List Topics  request</param>
        /// <returns>List Topics  Response from the service</returns>
        ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <remarks>
        /// If the subscription requires authentication for deletion, only the owner
        /// of the subscription or the its topic's owner can unsubscribe, and an AWS
        /// signature is required.
        /// If the Unsubscribe call does not require authentication and the requester is not
        /// the subscription owner, a final cancellation message is delivered to the
        /// endpoint, so that the endpoint owner can easily resubscribe to the topic if
        /// the Unsubscribe request was unintended.
        /// </remarks>
        /// <param name="request">Unsubscribe  request</param>
        /// <returns>Unsubscribe  Response from the service</returns>
        UnsubscribeResponse Unsubscribe(UnsubscribeRequest request);

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic.
        /// </summary>
        /// <remarks>
        /// Each call returns a limited list of subscriptions. If there are more subscriptions,
        /// a NextToken is also returned. Use the NextToken parameter in a new ListSubscriptionsByTopic
        /// call to get further results.
        /// </remarks>
        /// <param name="request">List Subscriptions By Topic  request</param>
        /// <returns>List Subscriptions By Topic  Response from the service</returns>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints.
        /// </summary>
        /// <remarks>
        /// When a messageId is returned, the message has been saved and Amazon SNS will
        /// attempt to deliver it to the topic's subscribers shortly.
        /// The format of the outgoing message to each subscribed endpoint depends on the
        /// notification protocol selected.
        /// </remarks>
        /// <param name="request">Publish  request</param>
        /// <returns>Publish  Response from the service</returns>
        PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Creates a platform application object for one of the supported push notification services, 
        /// such as APNS and GCM, to which devices and mobile apps may register.
        /// </summary>
        /// <remarks>
        /// You must specify PlatformPrincipal and PlatformCredential attributes when using this method.
        /// The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". 
        /// For GCM, PlatformPrincipal is not applicable. For ADM PlatformPrincipal is "client id". The PlatformCredential is also received from the notification service. 
        /// For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret".   
        /// The PlatformApplicationArn that is returned by this method is then used as an attribute for the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.CreatePlatformEndpoint"/> method.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>. 
        /// </remarks>
        /// <param name="request">Create Platform Application request.</param>
        /// <returns>Create Platform Application response from the service.</returns>
        CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request);

        /// <summary>
        /// Creates an endpoint for a device on one of the supported push notification services, such as GCM and APNS.
        /// </summary>
        /// <remarks>
        /// This method requires the PlatformApplicationArn that is returned from <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.CreatePlatformApplication"/>. 
        /// The EndpointArn that is returned when using this method can then be used by the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.Publish"/> method to 
        /// send a message to a mobile app or by the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.Subscribe"/> action for subscription to a topic.        
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Create Platform Endpoint request.</param>
        /// <returns>Create Platform Endpoint response from the service.</returns>
        CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request);

        /// <summary>
        /// Deletes the endpoint for a device on one of the supported push notification services, such as GCM and APNS. 
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Delete Endpoint request.</param>
        /// <returns>Delete Endpoint response from the service.</returns>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Delete Platform Application request.</param>
        /// <returns>Delete Platform Application response from the service.</returns>
        DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request);

        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Set Platform Application Attributes request.</param>
        /// <returns>Set Platform Application Attributes response from the service.</returns>
        SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Sets the attributes for the an endpoint for a device on one of the supported push notification services, such as GCM and APNS.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Set Endpoint Attributes request.</param>
        /// <returns>Set Endpoint Attributes response from the service.</returns>
        SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request);

        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Get Platform Application Attributes request.</param>
        /// <returns>Get Platform Application Attributes response from the service.</returns>
        GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification services, such as GCM and APNS. 
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Get Endpoint Attributes request.</param>
        /// <returns>Get Endpoint Attributes response from the service.</returns>
        GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request);

        /// <summary>
        /// Lists the platform application objects for the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// The results for this method are paginated and return a limited list of applications, up to 100.
        /// If additional records are available after the first page results, then a NextToken string will be returned. 
        /// To receive the next page, you call this method again using the NextToken string received from the previous call. 
        /// When there are no more records to return, NextToken will be null.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">List Platform Applications request.</param>
        /// <returns>List Platform Applications response from the service.</returns>
        ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request);

        /// <summary>
        /// Lists the endpoints and endpoint attributes for devices in a supported push notification service, such as GCM and APNS.
        /// </summary>
        /// <remarks>
        /// The results for this method are paginated and return a limited list of endpoints, up to 100.
        /// If additional records are available after the first page results, then a NextToken string will be returned. 
        /// To receive the next page, you call this method again using the NextToken string received from the previous call. 
        /// When there are no more records to return, NextToken will be null.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">List Endpoints By Platform Application request.</param>
        /// <returns>List Endpoints By Platform Application response from the service.</returns>
        ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request);
    }
}
