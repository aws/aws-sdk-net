/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using System;
using System.IO;
using System.Collections.Generic;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService.Resources
{

    #region IPlatformApplication

    /// <summary>
    /// This interface represents the PlatformApplication resource.
    /// </summary>
    public interface IPlatformApplication
    {
        /// <summary>
        /// Gets the value of the Arn identifier for this resource. 
        /// </summary>        
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property Attributes. 
        /// <para>
        /// Attributes include the following:
        /// </para>
        ///  <ul> <li> <code>EventEndpointCreated</code> -- Topic ARN to which EndpointCreated
        /// event notifications should be sent.</li> <li> <code>EventEndpointDeleted</code> --
        /// Topic ARN to which EndpointDeleted event notifications should be sent.</li> <li> <code>EventEndpointUpdated</code>
        /// -- Topic ARN to which EndpointUpdate event notifications should be sent.</li> <li>
        /// <code>EventDeliveryFailure</code> -- Topic ARN to which DeliveryFailure event notifications
        /// should be sent upon Direct Publish delivery failure (permanent) to one of the application's
        /// endpoints.</li> </ul>
        /// </summary>
        Dictionary<string, string> Attributes { get; }


        #region Actions

        /// <summary>
        /// Calls the CreatePlatformEndpoint operation on the PlatformApplication resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreatePlatformEndpoint operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint operation.</param>
        /// <returns>An instance of PlatformEndpoint resource.</returns>
        IPlatformEndpoint CreatePlatformEndpoint(CreatePlatformEndpointRequest request);

        /// <summary>
        /// Calls the CreatePlatformEndpoint operation on the PlatformApplication resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreatePlatformEndpoint operation on the service.
        /// </para>
        /// <returns>An instance of PlatformEndpoint resource.</returns>
        /// <param name="token">Unique identifier created by the notification service for an app on a device. The specific name for Token will vary, depending on which notification service is being used. For example, when using APNS as the notification service, you need the device token. Alternatively, when using GCM or ADM, the device token equivalent is called the registration ID.</param>
        IPlatformEndpoint CreatePlatformEndpoint(string token);

        /// <summary>
        /// Calls the Delete operation on the PlatformApplication resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeletePlatformApplication operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication operation.</param>
        void Delete(DeletePlatformApplicationRequest request);

        /// <summary>
        /// Calls the Delete operation on the PlatformApplication resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeletePlatformApplication operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the SetAttributes operation on the PlatformApplication resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetPlatformApplicationAttributes operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes operation.</param>
        void SetAttributes(SetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Calls the SetAttributes operation on the PlatformApplication resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetPlatformApplicationAttributes operation on the service.
        /// </para>
        /// <param name="attributes">A map of the platform application attributes. Attributes in this map include the following: <ul> <li> <code>PlatformCredential</code> -- The credential received from the notification service. For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret".</li> <li> <code>PlatformPrincipal</code> -- The principal received from the notification service. For APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". For GCM, PlatformPrincipal is not applicable. For ADM, PlatformPrincipal is "client id".</li> <li> <code>EventEndpointCreated</code> -- Topic ARN to which EndpointCreated event notifications should be sent.</li> <li> <code>EventEndpointDeleted</code> -- Topic ARN to which EndpointDeleted event notifications should be sent.</li> <li> <code>EventEndpointUpdated</code> -- Topic ARN to which EndpointUpdate event notifications should be sent.</li> <li> <code>EventDeliveryFailure</code> -- Topic ARN to which DeliveryFailure event notifications should be sent upon Direct Publish delivery failure (permanent) to one of the application's endpoints.</li> </ul></param>
        void SetAttributes(Dictionary<string, string> attributes);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the Endpoints associated with this PlatformApplication.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplicationEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Endpoints.</returns>
        IEnumerable<IPlatformEndpoint> GetEndpoints(ListEndpointsByPlatformApplicationRequest request);

        /// <summary>
        /// Gets the Endpoints associated with this PlatformApplication.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Endpoints.</returns>
        IEnumerable<IPlatformEndpoint> GetEndpoints();


        #endregion
    }    
    #endregion

    #region IPlatformEndpoint

    /// <summary>
    /// This interface represents the PlatformEndpoint resource.
    /// </summary>
    public interface IPlatformEndpoint
    {
        /// <summary>
        /// Gets the value of the Arn identifier for this resource. 
        /// </summary>        
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property Attributes. 
        /// <para>
        /// Attributes include the following:
        /// </para>
        ///  <ul> <li> <code>CustomUserData</code> -- arbitrary user data to associate with the
        /// endpoint. Amazon SNS does not use this data. The data must be in UTF-8 format and
        /// less than 2KB.</li> <li> <code>Enabled</code> -- flag that enables/disables delivery
        /// to the endpoint. Amazon SNS will set this to false when a notification service indicates
        /// to Amazon SNS that the endpoint is invalid. Users can set it back to true, typically
        /// after updating Token.</li> <li> <code>Token</code> -- device token, also referred
        /// to as a registration id, for an app and mobile device. This is returned from the notification
        /// service when an app and mobile device are registered with the notification service.</li>
        /// </ul>
        /// </summary>
        Dictionary<string, string> Attributes { get; }


        #region Actions

        /// <summary>
        /// Calls the Delete operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteEndpoint operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        void Delete(DeleteEndpointRequest request);

        /// <summary>
        /// Calls the Delete operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteEndpoint operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Publish operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Publish operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the Publish operation.</param>
        /// <returns>An instance of  resource.</returns>
        PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Calls the Publish operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Publish operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        /// <param name="message">The message you want to send to the topic. If you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter. See the Examples section for the format of the JSON object.  Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints: <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li>The values will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li> <li>Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes).</li> <li>Non-string values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols are ignored.</li> <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery).</li> </ul> </param>
        /// <param name="topicArn">The topic you want to publish to.</param>
        PublishResponse Publish(string message, string topicArn);

        /// <summary>
        /// Calls the Publish operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Publish operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        /// <param name="message">The message you want to send to the topic. If you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter. See the Examples section for the format of the JSON object.  Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints: <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li>The values will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li> <li>Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes).</li> <li>Non-string values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols are ignored.</li> <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery).</li> </ul> </param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter, number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters long.</param>
        /// <param name="topicArn">The topic you want to publish to.</param>
        PublishResponse Publish(string message, string subject, string topicArn);

        /// <summary>
        /// Calls the SetAttributes operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetEndpointAttributes operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes operation.</param>
        void SetAttributes(SetEndpointAttributesRequest request);

        /// <summary>
        /// Calls the SetAttributes operation on the PlatformEndpoint resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetEndpointAttributes operation on the service.
        /// </para>
        /// <param name="attributes">A map of the endpoint attributes. Attributes in this map include the following: <ul> <li> <code>CustomUserData</code> -- arbitrary user data to associate with the endpoint. Amazon SNS does not use this data. The data must be in UTF-8 format and less than 2KB.</li> <li> <code>Enabled</code> -- flag that enables/disables delivery to the endpoint. Amazon SNS will set this to false when a notification service indicates to Amazon SNS that the endpoint is invalid. Users can set it back to true, typically after updating Token.</li> <li> <code>Token</code> -- device token, also referred to as a registration id, for an app and mobile device. This is returned from the notification service when an app and mobile device are registered with the notification service.</li> </ul></param>
        void SetAttributes(Dictionary<string, string> attributes);


        #endregion

    }    
    #endregion

    #region ISubscription

    /// <summary>
    /// This interface represents the Subscription resource.
    /// </summary>
    public interface ISubscription
    {
        /// <summary>
        /// Gets the value of the Arn identifier for this resource. 
        /// </summary>        
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property Attributes. 
        /// <para>
        /// A map of the subscription's attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> <code>SubscriptionArn</code> -- the subscription's ARN</li> <li> <code>TopicArn</code>
        /// -- the topic ARN that the subscription is associated with</li> <li> <code>Owner</code>
        /// -- the AWS account ID of the subscription's owner</li> <li> <code>ConfirmationWasAuthenticated</code>
        /// -- true if the subscription confirmation request was authenticated</li> <li> <code>DeliveryPolicy</code>
        /// -- the JSON serialization of the subscription's delivery policy</li> <li> <code>EffectiveDeliveryPolicy</code>
        /// -- the JSON serialization of the effective delivery policy that takes into account
        /// the topic delivery policy and account system defaults</li> </ul>
        /// </summary>
        Dictionary<string, string> Attributes { get; }


        #region Actions

        /// <summary>
        /// Calls the Delete operation on the Subscription resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Unsubscribe operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation.</param>
        void Delete(UnsubscribeRequest request);

        /// <summary>
        /// Calls the Delete operation on the Subscription resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Unsubscribe operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the SetAttributes operation on the Subscription resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetSubscriptionAttributes operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes operation.</param>
        void SetAttributes(SetSubscriptionAttributesRequest request);

        /// <summary>
        /// Calls the SetAttributes operation on the Subscription resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetSubscriptionAttributes operation on the service.
        /// </para>
        /// <param name="attributeName">The name of the attribute you want to set. Only a subset of the subscriptions attributes are mutable. Valid values: <code>DeliveryPolicy</code> | <code>RawMessageDelivery</code></param>
        /// <param name="attributeValue">The new value for the attribute in JSON format.</param>
        void SetAttributes(string attributeName, string attributeValue);


        #endregion

    }    
    #endregion

    #region ITopic

    /// <summary>
    /// This interface represents the Topic resource.
    /// </summary>
    public interface ITopic
    {
        /// <summary>
        /// Gets the value of the Arn identifier for this resource. 
        /// </summary>        
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property Attributes. 
        /// <para>
        /// A map of the topic's attributes. Attributes in this map include the following:
        /// </para>
        ///  <ul> <li> <code>TopicArn</code> -- the topic's ARN</li> <li> <code>Owner</code> --
        /// the AWS account ID of the topic's owner</li> <li> <code>Policy</code> -- the JSON
        /// serialization of the topic's access control policy</li> <li> <code>DisplayName</code>
        /// -- the human-readable name used in the "From" field for notifications to email and
        /// email-json endpoints</li> <li> <code>SubscriptionsPending</code> -- the number of
        /// subscriptions pending confirmation on this topic</li> <li> <code>SubscriptionsConfirmed</code>
        /// -- the number of confirmed subscriptions on this topic</li> <li> <code>SubscriptionsDeleted</code>
        /// -- the number of deleted subscriptions on this topic</li> <li> <code>DeliveryPolicy</code>
        /// -- the JSON serialization of the topic's delivery policy</li> <li> <code>EffectiveDeliveryPolicy</code>
        /// -- the JSON serialization of the effective delivery policy that takes into account
        /// system defaults</li> </ul>
        /// </summary>
        Dictionary<string, string> Attributes { get; }


        #region Actions

        /// <summary>
        /// Calls the AddPermission operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddPermission operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        void AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Calls the AddPermission operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddPermission operation on the service.
        /// </para>
        /// <param name="actionName">The action you want to allow for the specified principal(s). Valid values: any Amazon SNS action name.</param>
        /// <param name="awsAccountId">The AWS account IDs of the users (principals) who will be given access to the specified actions. The users must have AWS accounts, but do not need to be signed up for this service. </param>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        void AddPermission(List<string> actionName, List<string> awsAccountId, string label);

        /// <summary>
        /// Calls the ConfirmSubscription operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ConfirmSubscription operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription operation.</param>
        /// <returns>An instance of Subscription resource.</returns>
        ISubscription ConfirmSubscription(ConfirmSubscriptionRequest request);

        /// <summary>
        /// Calls the ConfirmSubscription operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ConfirmSubscription operation on the service.
        /// </para>
        /// <returns>An instance of Subscription resource.</returns>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        ISubscription ConfirmSubscription(string token);

        /// <summary>
        /// Calls the ConfirmSubscription operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ConfirmSubscription operation on the service.
        /// </para>
        /// <returns>An instance of Subscription resource.</returns>
        /// <param name="authenticateOnUnsubscribe">Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is <code>true</code> and the request has an AWS signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe action requires AWS authentication. </param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        ISubscription ConfirmSubscription(string authenticateOnUnsubscribe, string token);

        /// <summary>
        /// Calls the Delete operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteTopic operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic operation.</param>
        void Delete(DeleteTopicRequest request);

        /// <summary>
        /// Calls the Delete operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteTopic operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Publish operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Publish operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the Publish operation.</param>
        /// <returns>An instance of  resource.</returns>
        PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Calls the Publish operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Publish operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        /// <param name="message">The message you want to send to the topic. If you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter. See the Examples section for the format of the JSON object.  Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints: <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li>The values will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li> <li>Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes).</li> <li>Non-string values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols are ignored.</li> <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery).</li> </ul> </param>
        PublishResponse Publish(string message);

        /// <summary>
        /// Calls the Publish operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Publish operation on the service.
        /// </para>
        /// <returns>An instance of  resource.</returns>
        /// <param name="message">The message you want to send to the topic. If you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter. See the Examples section for the format of the JSON object.  Constraints: Messages must be UTF-8 encoded strings at most 256 KB in size (262144 bytes, not 262144 characters). JSON-specific constraints: <ul> <li>Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li>The values will be parsed (unescaped) before they are used in outgoing messages.</li> <li>Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending).</li> <li>Values have a minimum length of 0 (the empty string, "", is allowed).</li> <li>Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes).</li> <li>Non-string values will cause the key to be ignored.</li> <li>Keys that do not correspond to supported transport protocols are ignored.</li> <li>Duplicate keys are not allowed.</li> <li>Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery).</li> </ul> </param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter, number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters long.</param>
        PublishResponse Publish(string message, string subject);

        /// <summary>
        /// Calls the RemovePermission operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemovePermission operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        void RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Calls the RemovePermission operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemovePermission operation on the service.
        /// </para>
        /// <param name="label">The unique label of the statement you want to remove.</param>
        void RemovePermission(string label);

        /// <summary>
        /// Calls the SetAttributes operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetTopicAttributes operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes operation.</param>
        void SetAttributes(SetTopicAttributesRequest request);

        /// <summary>
        /// Calls the SetAttributes operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetTopicAttributes operation on the service.
        /// </para>
        /// <param name="attributeName">The name of the attribute you want to set. Only a subset of the topic's attributes are mutable. Valid values: <code>Policy</code> | <code>DisplayName</code> | <code>DeliveryPolicy</code></param>
        /// <param name="attributeValue">The new value for the attribute.</param>
        void SetAttributes(string attributeName, string attributeValue);

        /// <summary>
        /// Calls the Subscribe operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Subscribe operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation.</param>
        /// <returns>An instance of Subscription resource.</returns>
        ISubscription Subscribe(SubscribeRequest request);

        /// <summary>
        /// Calls the Subscribe operation on the Topic resource.
        /// </summary>
        /// <para>
        /// This method internally calls the Subscribe operation on the service.
        /// </para>
        /// <returns>An instance of Subscription resource.</returns>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li>For the <code>http</code> protocol, the endpoint is an URL beginning with "http://"</li> <li>For the <code>https</code> protocol, the endpoint is a URL beginning with "https://"</li> <li>For the <code>email</code> protocol, the endpoint is an email address</li> <li>For the <code>email-json</code> protocol, the endpoint is an email address</li> <li>For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device</li> <li>For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue</li> <li>For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device.</li> </ul></param>
        /// <param name="protocol">The protocol you want to use. Supported protocols include: <ul> <li> <code>http</code> -- delivery of JSON-encoded message via HTTP POST</li> <li> <code>https</code> -- delivery of JSON-encoded message via HTTPS POST</li> <li> <code>email</code> -- delivery of message via SMTP</li> <li> <code>email-json</code> -- delivery of JSON-encoded message via SMTP</li> <li> <code>sms</code> -- delivery of message via SMS</li> <li> <code>sqs</code> -- delivery of JSON-encoded message to an Amazon SQS queue</li> <li> <code>application</code> -- delivery of JSON-encoded message to an EndpointArn for a mobile app and device.</li> </ul></param>
        ISubscription Subscribe(string endpoint, string protocol);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the Subscriptions associated with this Topic.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopicEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Subscriptions.</returns>
        IEnumerable<ISubscription> GetSubscriptions(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Gets the Subscriptions associated with this Topic.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Subscriptions.</returns>
        IEnumerable<ISubscription> GetSubscriptions();


        #endregion
    }    
    #endregion
}