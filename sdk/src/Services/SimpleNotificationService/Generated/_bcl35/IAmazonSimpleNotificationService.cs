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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Interface for accessing SimpleNotificationService
    ///
    /// Amazon Simple Notification Service 
    /// <para>
    /// Amazon Simple Notification Service (Amazon SNS) is a web service that enables you
    /// to build distributed web-enabled applications. Applications can use Amazon SNS to
    /// easily push real-time notification messages to interested subscribers over multiple
    /// delivery protocols. For more information about this product see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
    /// For detailed information about Amazon SNS features and their associated API calls,
    /// see the <a href="http://docs.aws.amazon.com/sns/latest/dg/">Amazon SNS Developer Guide</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// We also provide SDKs that enable you to access Amazon SNS from your preferred programming
    /// language. The SDKs contain functionality that automatically takes care of tasks such
    /// as: cryptographically signing your service requests, retrying requests, and handling
    /// error responses. For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>. 
    /// </para>
    /// </summary>
    public partial interface IAmazonSimpleNotificationService : IAmazonService, IDisposable
    {

        
        #region  AddPermission


        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// AWS accounts to the specified actions.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        /// <param name="awsAccountId">The AWS account IDs of the users (principals) who will be given access to the specified actions. The users must have AWS accounts, but do not need to be signed up for this service.</param>
        /// <param name="actionName">The action you want to allow for the specified principal(s). Valid values: any Amazon SNS action name.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        AddPermissionResponse AddPermission(string topicArn, string label, List<string> awsAccountId, List<string> actionName);

        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// AWS accounts to the specified actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        IAsyncResult BeginAddPermission(AddPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        /// 
        /// <returns>Returns a  AddPermissionResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/AddPermission">REST API Reference for AddPermission Operation</seealso>
        AddPermissionResponse EndAddPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckIfPhoneNumberIsOptedOut


        /// <summary>
        /// Accepts a phone number and indicates whether the phone holder has opted out of receiving
        /// SMS messages from your account. You cannot send SMS messages to a number that is opted
        /// out.
        /// 
        ///  
        /// <para>
        /// To resume sending messages, you can opt in the number by using the <code>OptInPhoneNumber</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckIfPhoneNumberIsOptedOut service method.</param>
        /// 
        /// <returns>The response from the CheckIfPhoneNumberIsOptedOut service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CheckIfPhoneNumberIsOptedOut">REST API Reference for CheckIfPhoneNumberIsOptedOut Operation</seealso>
        CheckIfPhoneNumberIsOptedOutResponse CheckIfPhoneNumberIsOptedOut(CheckIfPhoneNumberIsOptedOutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckIfPhoneNumberIsOptedOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckIfPhoneNumberIsOptedOut operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckIfPhoneNumberIsOptedOut
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CheckIfPhoneNumberIsOptedOut">REST API Reference for CheckIfPhoneNumberIsOptedOut Operation</seealso>
        IAsyncResult BeginCheckIfPhoneNumberIsOptedOut(CheckIfPhoneNumberIsOptedOutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckIfPhoneNumberIsOptedOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckIfPhoneNumberIsOptedOut.</param>
        /// 
        /// <returns>Returns a  CheckIfPhoneNumberIsOptedOutResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CheckIfPhoneNumberIsOptedOut">REST API Reference for CheckIfPhoneNumberIsOptedOut Operation</seealso>
        CheckIfPhoneNumberIsOptedOutResponse EndCheckIfPhoneNumberIsOptedOut(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmSubscription


        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token sent
        /// to the endpoint by an earlier <code>Subscribe</code> action. If the token is valid,
        /// the action creates a new subscription and returns its Amazon Resource Name (ARN).
        /// This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        /// <param name="authenticateOnUnsubscribe">Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is <code>true</code> and the request has an AWS signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe action requires AWS authentication. </param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        ConfirmSubscriptionResponse ConfirmSubscription(string topicArn, string token, string authenticateOnUnsubscribe);

        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token sent
        /// to the endpoint by an earlier <code>Subscribe</code> action. If the token is valid,
        /// the action creates a new subscription and returns its Amazon Resource Name (ARN).
        /// This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to confirm a subscription.</param>
        /// <param name="token">Short-lived token sent to an endpoint during the <code>Subscribe</code> action.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        ConfirmSubscriptionResponse ConfirmSubscription(string topicArn, string token);

        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token sent
        /// to the endpoint by an earlier <code>Subscribe</code> action. If the token is valid,
        /// the action creates a new subscription and returns its Amazon Resource Name (ARN).
        /// This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription service method.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        IAsyncResult BeginConfirmSubscription(ConfirmSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSubscription.</param>
        /// 
        /// <returns>Returns a  ConfirmSubscriptionResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ConfirmSubscription">REST API Reference for ConfirmSubscription Operation</seealso>
        ConfirmSubscriptionResponse EndConfirmSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlatformApplication


        /// <summary>
        /// Creates a platform application object for one of the supported push notification services,
        /// such as APNS and GCM, to which devices and mobile apps may register. You must specify
        /// PlatformPrincipal and PlatformCredential attributes when using the <code>CreatePlatformApplication</code>
        /// action. The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX,
        /// PlatformPrincipal is "SSL certificate". For GCM, PlatformPrincipal is not applicable.
        /// For ADM, PlatformPrincipal is "client id". The PlatformCredential is also received
        /// from the notification service. For WNS, PlatformPrincipal is "Package Security Identifier".
        /// For MPNS, PlatformPrincipal is "TLS certificate". For Baidu, PlatformPrincipal is
        /// "API key".
        /// 
        ///  
        /// <para>
        /// For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM, PlatformCredential
        /// is "API key". For ADM, PlatformCredential is "client secret". For WNS, PlatformCredential
        /// is "secret key". For MPNS, PlatformCredential is "private key". For Baidu, PlatformCredential
        /// is "secret key". The PlatformApplicationArn that is returned when using <code>CreatePlatformApplication</code>
        /// is then used as an attribute for the <code>CreatePlatformEndpoint</code> action. For
        /// more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. For more information about obtaining the
        /// PlatformPrincipal and PlatformCredential for each of the supported push notification
        /// services, see <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-apns.html">Getting
        /// Started with Apple Push Notification Service</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-adm.html">Getting
        /// Started with Amazon Device Messaging</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-baidu.html">Getting
        /// Started with Baidu Cloud Push</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-gcm.html">Getting
        /// Started with Google Cloud Messaging for Android</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-mpns.html">Getting
        /// Started with MPNS</a>, or <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-wns.html">Getting
        /// Started with WNS</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformApplication">REST API Reference for CreatePlatformApplication Operation</seealso>
        CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlatformApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformApplication">REST API Reference for CreatePlatformApplication Operation</seealso>
        IAsyncResult BeginCreatePlatformApplication(CreatePlatformApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformApplication.</param>
        /// 
        /// <returns>Returns a  CreatePlatformApplicationResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformApplication">REST API Reference for CreatePlatformApplication Operation</seealso>
        CreatePlatformApplicationResponse EndCreatePlatformApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlatformEndpoint


        /// <summary>
        /// Creates an endpoint for a device and mobile app on one of the supported push notification
        /// services, such as GCM and APNS. <code>CreatePlatformEndpoint</code> requires the PlatformApplicationArn
        /// that is returned from <code>CreatePlatformApplication</code>. The EndpointArn that
        /// is returned when using <code>CreatePlatformEndpoint</code> can then be used by the
        /// <code>Publish</code> action to send a message to a mobile app or by the <code>Subscribe</code>
        /// action for subscription to a topic. The <code>CreatePlatformEndpoint</code> action
        /// is idempotent, so if the requester already owns an endpoint with the same device token
        /// and attributes, that endpoint's ARN is returned without creating a new endpoint. For
        /// more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// When using <code>CreatePlatformEndpoint</code> with Baidu, two attributes must be
        /// provided: ChannelId and UserId. The token field must also contain the ChannelId. For
        /// more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePushBaiduEndpoint.html">Creating
        /// an Amazon SNS Endpoint for Baidu</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformEndpoint">REST API Reference for CreatePlatformEndpoint Operation</seealso>
        CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlatformEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformEndpoint">REST API Reference for CreatePlatformEndpoint Operation</seealso>
        IAsyncResult BeginCreatePlatformEndpoint(CreatePlatformEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformEndpoint.</param>
        /// 
        /// <returns>Returns a  CreatePlatformEndpointResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreatePlatformEndpoint">REST API Reference for CreatePlatformEndpoint Operation</seealso>
        CreatePlatformEndpointResponse EndCreatePlatformEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopic


        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create at most
        /// 100,000 topics. For more information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
        /// This action is idempotent, so if the requester already owns a topic with the specified
        /// name, that topic's ARN is returned without creating a new topic.
        /// </summary>
        /// <param name="name">The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        CreateTopicResponse CreateTopic(string name);

        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create at most
        /// 100,000 topics. For more information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
        /// This action is idempotent, so if the requester already owns a topic with the specified
        /// name, that topic's ARN is returned without creating a new topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        CreateTopicResponse CreateTopic(CreateTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        IAsyncResult BeginCreateTopic(CreateTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopic.</param>
        /// 
        /// <returns>Returns a  CreateTopicResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        CreateTopicResponse EndCreateTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes the endpoint for a device and mobile app from Amazon SNS. This action is idempotent.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// When you delete an endpoint that is also subscribed to a topic, then you must also
        /// unsubscribe the endpoint from the topic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlatformApplication


        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services,
        /// such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the DeletePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeletePlatformApplication">REST API Reference for DeletePlatformApplication Operation</seealso>
        DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlatformApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeletePlatformApplication">REST API Reference for DeletePlatformApplication Operation</seealso>
        IAsyncResult BeginDeletePlatformApplication(DeletePlatformApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlatformApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlatformApplication.</param>
        /// 
        /// <returns>Returns a  DeletePlatformApplicationResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeletePlatformApplication">REST API Reference for DeletePlatformApplication Operation</seealso>
        DeletePlatformApplicationResponse EndDeletePlatformApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTopic


        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might prevent some messages
        /// previously sent to the topic from being delivered to subscribers. This action is idempotent,
        /// so deleting a topic that does not exist does not result in an error.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to delete.</param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        DeleteTopicResponse DeleteTopic(string topicArn);

        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might prevent some messages
        /// previously sent to the topic from being delivered to subscribers. This action is idempotent,
        /// so deleting a topic that does not exist does not result in an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        DeleteTopicResponse DeleteTopic(DeleteTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        IAsyncResult BeginDeleteTopic(DeleteTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopic.</param>
        /// 
        /// <returns>Returns a  DeleteTopicResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteTopic">REST API Reference for DeleteTopic Operation</seealso>
        DeleteTopicResponse EndDeleteTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEndpointAttributes


        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification
        /// services, such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetEndpointAttributes">REST API Reference for GetEndpointAttributes Operation</seealso>
        GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpointAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetEndpointAttributes">REST API Reference for GetEndpointAttributes Operation</seealso>
        IAsyncResult BeginGetEndpointAttributes(GetEndpointAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpointAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a  GetEndpointAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetEndpointAttributes">REST API Reference for GetEndpointAttributes Operation</seealso>
        GetEndpointAttributesResponse EndGetEndpointAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPlatformApplicationAttributes


        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push
        /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetPlatformApplicationAttributes">REST API Reference for GetPlatformApplicationAttributes Operation</seealso>
        GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlatformApplicationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlatformApplicationAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetPlatformApplicationAttributes">REST API Reference for GetPlatformApplicationAttributes Operation</seealso>
        IAsyncResult BeginGetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlatformApplicationAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a  GetPlatformApplicationAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetPlatformApplicationAttributes">REST API Reference for GetPlatformApplicationAttributes Operation</seealso>
        GetPlatformApplicationAttributesResponse EndGetPlatformApplicationAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSMSAttributes


        /// <summary>
        /// Returns the settings for sending SMS messages from your account.
        /// 
        ///  
        /// <para>
        /// These settings are set with the <code>SetSMSAttributes</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSMSAttributes service method.</param>
        /// 
        /// <returns>The response from the GetSMSAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSAttributes">REST API Reference for GetSMSAttributes Operation</seealso>
        GetSMSAttributesResponse GetSMSAttributes(GetSMSAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSMSAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSMSAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSMSAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSAttributes">REST API Reference for GetSMSAttributes Operation</seealso>
        IAsyncResult BeginGetSMSAttributes(GetSMSAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSMSAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSMSAttributes.</param>
        /// 
        /// <returns>Returns a  GetSMSAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSAttributes">REST API Reference for GetSMSAttributes Operation</seealso>
        GetSMSAttributesResponse EndGetSMSAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubscriptionAttributes


        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription whose properties you want to get.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSubscriptionAttributes">REST API Reference for GetSubscriptionAttributes Operation</seealso>
        GetSubscriptionAttributesResponse GetSubscriptionAttributes(string subscriptionArn);

        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSubscriptionAttributes">REST API Reference for GetSubscriptionAttributes Operation</seealso>
        GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSubscriptionAttributes">REST API Reference for GetSubscriptionAttributes Operation</seealso>
        IAsyncResult BeginGetSubscriptionAttributes(GetSubscriptionAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSubscriptionAttributes">REST API Reference for GetSubscriptionAttributes Operation</seealso>
        GetSubscriptionAttributesResponse EndGetSubscriptionAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTopicAttributes


        /// <summary>
        /// Returns all of the properties of a topic. Topic properties returned might differ based
        /// on the authorization of the user.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose properties you want to get.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetTopicAttributes">REST API Reference for GetTopicAttributes Operation</seealso>
        GetTopicAttributesResponse GetTopicAttributes(string topicArn);

        /// <summary>
        /// Returns all of the properties of a topic. Topic properties returned might differ based
        /// on the authorization of the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetTopicAttributes">REST API Reference for GetTopicAttributes Operation</seealso>
        GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTopicAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetTopicAttributes">REST API Reference for GetTopicAttributes Operation</seealso>
        IAsyncResult BeginGetTopicAttributes(GetTopicAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTopicAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicAttributes.</param>
        /// 
        /// <returns>Returns a  GetTopicAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetTopicAttributes">REST API Reference for GetTopicAttributes Operation</seealso>
        GetTopicAttributesResponse EndGetTopicAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpointsByPlatformApplication


        /// <summary>
        /// Lists the endpoints and endpoint attributes for devices in a supported push notification
        /// service, such as GCM and APNS. The results for <code>ListEndpointsByPlatformApplication</code>
        /// are paginated and return a limited list of endpoints, up to 100. If additional records
        /// are available after the first page results, then a NextToken string will be returned.
        /// To receive the next page, you call <code>ListEndpointsByPlatformApplication</code>
        /// again using the NextToken string received from the previous call. When there are no
        /// more records to return, NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication service method.</param>
        /// 
        /// <returns>The response from the ListEndpointsByPlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListEndpointsByPlatformApplication">REST API Reference for ListEndpointsByPlatformApplication Operation</seealso>
        ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointsByPlatformApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointsByPlatformApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListEndpointsByPlatformApplication">REST API Reference for ListEndpointsByPlatformApplication Operation</seealso>
        IAsyncResult BeginListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointsByPlatformApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointsByPlatformApplication.</param>
        /// 
        /// <returns>Returns a  ListEndpointsByPlatformApplicationResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListEndpointsByPlatformApplication">REST API Reference for ListEndpointsByPlatformApplication Operation</seealso>
        ListEndpointsByPlatformApplicationResponse EndListEndpointsByPlatformApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPhoneNumbersOptedOut


        /// <summary>
        /// Returns a list of phone numbers that are opted out, meaning you cannot send SMS messages
        /// to them.
        /// 
        ///  
        /// <para>
        /// The results for <code>ListPhoneNumbersOptedOut</code> are paginated, and each page
        /// returns up to 100 phone numbers. If additional phone numbers are available after the
        /// first page of results, then a <code>NextToken</code> string will be returned. To receive
        /// the next page, you call <code>ListPhoneNumbersOptedOut</code> again using the <code>NextToken</code>
        /// string received from the previous call. When there are no more records to return,
        /// <code>NextToken</code> will be null.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbersOptedOut service method.</param>
        /// 
        /// <returns>The response from the ListPhoneNumbersOptedOut service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPhoneNumbersOptedOut">REST API Reference for ListPhoneNumbersOptedOut Operation</seealso>
        ListPhoneNumbersOptedOutResponse ListPhoneNumbersOptedOut(ListPhoneNumbersOptedOutRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPhoneNumbersOptedOut operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPhoneNumbersOptedOut operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPhoneNumbersOptedOut
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPhoneNumbersOptedOut">REST API Reference for ListPhoneNumbersOptedOut Operation</seealso>
        IAsyncResult BeginListPhoneNumbersOptedOut(ListPhoneNumbersOptedOutRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPhoneNumbersOptedOut operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPhoneNumbersOptedOut.</param>
        /// 
        /// <returns>Returns a  ListPhoneNumbersOptedOutResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPhoneNumbersOptedOut">REST API Reference for ListPhoneNumbersOptedOut Operation</seealso>
        ListPhoneNumbersOptedOutResponse EndListPhoneNumbersOptedOut(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPlatformApplications


        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        /// such as APNS and GCM. The results for <code>ListPlatformApplications</code> are paginated
        /// and return a limited list of applications, up to 100. If additional records are available
        /// after the first page results, then a NextToken string will be returned. To receive
        /// the next page, you call <code>ListPlatformApplications</code> using the NextToken
        /// string received from the previous call. When there are no more records to return,
        /// NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// This action is throttled at 15 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPlatformApplications">REST API Reference for ListPlatformApplications Operation</seealso>
        ListPlatformApplicationsResponse ListPlatformApplications();

        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        /// such as APNS and GCM. The results for <code>ListPlatformApplications</code> are paginated
        /// and return a limited list of applications, up to 100. If additional records are available
        /// after the first page results, then a NextToken string will be returned. To receive
        /// the next page, you call <code>ListPlatformApplications</code> using the NextToken
        /// string received from the previous call. When there are no more records to return,
        /// NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// This action is throttled at 15 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications service method.</param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPlatformApplications">REST API Reference for ListPlatformApplications Operation</seealso>
        ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlatformApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPlatformApplications">REST API Reference for ListPlatformApplications Operation</seealso>
        IAsyncResult BeginListPlatformApplications(ListPlatformApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlatformApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlatformApplications.</param>
        /// 
        /// <returns>Returns a  ListPlatformApplicationsResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListPlatformApplications">REST API Reference for ListPlatformApplications Operation</seealso>
        ListPlatformApplicationsResponse EndListPlatformApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptions


        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptions</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse ListSubscriptions();

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptions</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptions</code> request.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse ListSubscriptions(string nextToken);

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptions</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptionsByTopic


        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns a limited
        /// list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// <param name="nextToken">Token returned by the previous <code>ListSubscriptionsByTopic</code> request.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn, string nextToken);

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns a limited
        /// list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic for which you wish to find subscriptions.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(string topicArn);

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns a limited
        /// list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionsByTopic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        IAsyncResult BeginListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionsByTopic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionsByTopic.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsByTopicResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSubscriptionsByTopic">REST API Reference for ListSubscriptionsByTopic Operation</seealso>
        ListSubscriptionsByTopicResponse EndListSubscriptionsByTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopics


        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If there are more topics, a <code>NextToken</code> is also returned. Use
        /// the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to get
        /// further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse ListTopics();

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If there are more topics, a <code>NextToken</code> is also returned. Use
        /// the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to get
        /// further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="nextToken">Token returned by the previous <code>ListTopics</code> request.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse ListTopics(string nextToken);

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If there are more topics, a <code>NextToken</code> is also returned. Use
        /// the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to get
        /// further results.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 30 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        IAsyncResult BeginListTopics(ListTopicsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a  ListTopicsResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTopics">REST API Reference for ListTopics Operation</seealso>
        ListTopicsResponse EndListTopics(IAsyncResult asyncResult);

        #endregion
        
        #region  OptInPhoneNumber


        /// <summary>
        /// Use this request to opt in a phone number that is opted out, which enables you to
        /// resume sending SMS messages to the number.
        /// 
        ///  
        /// <para>
        /// You can opt in a phone number only once every 30 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptInPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the OptInPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/OptInPhoneNumber">REST API Reference for OptInPhoneNumber Operation</seealso>
        OptInPhoneNumberResponse OptInPhoneNumber(OptInPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OptInPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OptInPhoneNumber operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOptInPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/OptInPhoneNumber">REST API Reference for OptInPhoneNumber Operation</seealso>
        IAsyncResult BeginOptInPhoneNumber(OptInPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OptInPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOptInPhoneNumber.</param>
        /// 
        /// <returns>Returns a  OptInPhoneNumberResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/OptInPhoneNumber">REST API Reference for OptInPhoneNumber Operation</seealso>
        OptInPhoneNumberResponse EndOptInPhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  Publish


        /// <summary>
        /// Sends a message to an Amazon SNS topic or sends a text message (SMS message) directly
        /// to a phone number. 
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
        /// will attempt to deliver it shortly.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262144 bytes, not 262144 characters). </li> <li> For SMS, each message can contain up to 140 bytes, and the character limit depends on the encoding scheme. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds the size limit, Amazon SNS sends it as multiple messages, each fitting within the size limit. Messages are not cut off in the middle of a word but on whole-word boundaries. The total size limit for a single SMS publish action is 1600 bytes. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse Publish(string topicArn, string message);

        /// <summary>
        /// Sends a message to an Amazon SNS topic or sends a text message (SMS message) directly
        /// to a phone number. 
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
        /// will attempt to deliver it shortly.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262144 bytes, not 262144 characters). </li> <li> For SMS, each message can contain up to 140 bytes, and the character limit depends on the encoding scheme. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds the size limit, Amazon SNS sends it as multiple messages, each fitting within the size limit. Messages are not cut off in the middle of a word but on whole-word boundaries. The total size limit for a single SMS publish action is 1600 bytes. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
        /// <param name="subject">Optional parameter to be used as the "Subject" line when the message is delivered to email endpoints. This field will also be included, if present, in the standard JSON messages delivered to other endpoints. Constraints: Subjects must be ASCII text that begins with a letter, number, or punctuation mark; must not include line breaks or control characters; and must be less than 100 characters long.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse Publish(string topicArn, string message, string subject);

        /// <summary>
        /// Sends a message to an Amazon SNS topic or sends a text message (SMS message) directly
        /// to a phone number. 
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message has been saved and Amazon SNS
        /// will attempt to deliver it shortly.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublish
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        IAsyncResult BeginPublish(PublishRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Publish operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a  PublishResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse EndPublish(IAsyncResult asyncResult);

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">The unique label of the statement you want to remove.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(string topicArn, string label);

        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  SetEndpointAttributes


        /// <summary>
        /// Sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the SetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetEndpointAttributes">REST API Reference for SetEndpointAttributes Operation</seealso>
        SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetEndpointAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetEndpointAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetEndpointAttributes">REST API Reference for SetEndpointAttributes Operation</seealso>
        IAsyncResult BeginSetEndpointAttributes(SetEndpointAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetEndpointAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a  SetEndpointAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetEndpointAttributes">REST API Reference for SetEndpointAttributes Operation</seealso>
        SetEndpointAttributesResponse EndSetEndpointAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetPlatformApplicationAttributes


        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification
        /// services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. For information on configuring attributes
        /// for message delivery status, see <a href="http://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using
        /// Amazon SNS Application Attributes for Message Delivery Status</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the SetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetPlatformApplicationAttributes">REST API Reference for SetPlatformApplicationAttributes Operation</seealso>
        SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetPlatformApplicationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetPlatformApplicationAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetPlatformApplicationAttributes">REST API Reference for SetPlatformApplicationAttributes Operation</seealso>
        IAsyncResult BeginSetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetPlatformApplicationAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a  SetPlatformApplicationAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetPlatformApplicationAttributes">REST API Reference for SetPlatformApplicationAttributes Operation</seealso>
        SetPlatformApplicationAttributesResponse EndSetPlatformApplicationAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetSMSAttributes


        /// <summary>
        /// Use this request to set the default settings for sending SMS messages and receiving
        /// daily SMS usage reports.
        /// 
        ///  
        /// <para>
        /// You can override some of these settings for a single message when you use the <code>Publish</code>
        /// action with the <code>MessageAttributes.entry.N</code> parameter. For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/sms_publish-to-phone.html">Sending
        /// an SMS Message</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSMSAttributes service method.</param>
        /// 
        /// <returns>The response from the SetSMSAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSMSAttributes">REST API Reference for SetSMSAttributes Operation</seealso>
        SetSMSAttributesResponse SetSMSAttributes(SetSMSAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSMSAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSMSAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetSMSAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSMSAttributes">REST API Reference for SetSMSAttributes Operation</seealso>
        IAsyncResult BeginSetSMSAttributes(SetSMSAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSMSAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSMSAttributes.</param>
        /// 
        /// <returns>Returns a  SetSMSAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSMSAttributes">REST API Reference for SetSMSAttributes Operation</seealso>
        SetSMSAttributesResponse EndSetSMSAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetSubscriptionAttributes


        /// <summary>
        /// Allows a subscription owner to set an attribute of the subscription to a new value.
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to modify.</param>
        /// <param name="attributeName">The name of the attribute you want to set. Only a subset of the subscriptions attributes are mutable. Valid values: <code>DeliveryPolicy</code> | <code>FilterPolicy</code> | <code>RawMessageDelivery</code> </param>
        /// <param name="attributeValue">The new value for the attribute in JSON format.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your AWS account exceeds the limit.
        /// To add more filter polices, submit an SNS Limit Increase case in the AWS Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSubscriptionAttributes">REST API Reference for SetSubscriptionAttributes Operation</seealso>
        SetSubscriptionAttributesResponse SetSubscriptionAttributes(string subscriptionArn, string attributeName, string attributeValue);

        /// <summary>
        /// Allows a subscription owner to set an attribute of the subscription to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your AWS account exceeds the limit.
        /// To add more filter polices, submit an SNS Limit Increase case in the AWS Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSubscriptionAttributes">REST API Reference for SetSubscriptionAttributes Operation</seealso>
        SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubscriptionAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetSubscriptionAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSubscriptionAttributes">REST API Reference for SetSubscriptionAttributes Operation</seealso>
        IAsyncResult BeginSetSubscriptionAttributes(SetSubscriptionAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSubscriptionAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a  SetSubscriptionAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetSubscriptionAttributes">REST API Reference for SetSubscriptionAttributes Operation</seealso>
        SetSubscriptionAttributesResponse EndSetSubscriptionAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetTopicAttributes


        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic to modify.</param>
        /// <param name="attributeName">The name of the attribute you want to set. Only a subset of the topic's attributes are mutable. Valid values: <code>Policy</code> | <code>DisplayName</code> | <code>DeliveryPolicy</code> </param>
        /// <param name="attributeValue">The new value for the attribute.</param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        SetTopicAttributesResponse SetTopicAttributes(string topicArn, string attributeName, string attributeValue);

        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTopicAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTopicAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        IAsyncResult BeginSetTopicAttributes(SetTopicAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTopicAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTopicAttributes.</param>
        /// 
        /// <returns>Returns a  SetTopicAttributesResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        SetTopicAttributesResponse EndSetTopicAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  Subscribe


        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// To actually create a subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
        /// action with the token from the confirmation message. Confirmation tokens are valid
        /// for three days.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to subscribe to.</param>
        /// <param name="protocol">The protocol you want to use. Supported protocols include: <ul> <li>  <code>http</code> -- delivery of JSON-encoded message via HTTP POST </li> <li>  <code>https</code> -- delivery of JSON-encoded message via HTTPS POST </li> <li>  <code>email</code> -- delivery of message via SMTP </li> <li>  <code>email-json</code> -- delivery of JSON-encoded message via SMTP </li> <li>  <code>sms</code> -- delivery of message via SMS </li> <li>  <code>sqs</code> -- delivery of JSON-encoded message to an Amazon SQS queue </li> <li>  <code>application</code> -- delivery of JSON-encoded message to an EndpointArn for a mobile app and device. </li> <li>  <code>lambda</code> -- delivery of JSON-encoded message to an AWS Lambda function. </li> </ul></param>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li> For the <code>http</code> protocol, the endpoint is an URL beginning with "http://" </li> <li> For the <code>https</code> protocol, the endpoint is a URL beginning with "https://" </li> <li> For the <code>email</code> protocol, the endpoint is an email address </li> <li> For the <code>email-json</code> protocol, the endpoint is an email address </li> <li> For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device </li> <li> For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue </li> <li> For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device. </li> <li> For the <code>lambda</code> protocol, the endpoint is the ARN of an AWS Lambda function. </li> </ul></param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your AWS account exceeds the limit.
        /// To add more filter polices, submit an SNS Limit Increase case in the AWS Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Subscribe">REST API Reference for Subscribe Operation</seealso>
        SubscribeResponse Subscribe(string topicArn, string protocol, string endpoint);

        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// To actually create a subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
        /// action with the token from the confirmation message. Confirmation tokens are valid
        /// for three days.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your AWS account exceeds the limit.
        /// To add more filter polices, submit an SNS Limit Increase case in the AWS Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Subscribe">REST API Reference for Subscribe Operation</seealso>
        SubscribeResponse Subscribe(SubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Subscribe">REST API Reference for Subscribe Operation</seealso>
        IAsyncResult BeginSubscribe(SubscribeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Subscribe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a  SubscribeResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Subscribe">REST API Reference for Subscribe Operation</seealso>
        SubscribeResponse EndSubscribe(IAsyncResult asyncResult);

        #endregion
        
        #region  Unsubscribe


        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for deletion,
        /// only the owner of the subscription or the topic's owner can unsubscribe, and an AWS
        /// signature is required. If the <code>Unsubscribe</code> call does not require authentication
        /// and the requester is not the subscription owner, a final cancellation message is delivered
        /// to the endpoint, so that the endpoint owner can easily resubscribe to the topic if
        /// the <code>Unsubscribe</code> request was unintended.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="subscriptionArn">The ARN of the subscription to be deleted.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        UnsubscribeResponse Unsubscribe(string subscriptionArn);

        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for deletion,
        /// only the owner of the subscription or the topic's owner can unsubscribe, and an AWS
        /// signature is required. If the <code>Unsubscribe</code> call does not require authentication
        /// and the requester is not the subscription owner, a final cancellation message is delivered
        /// to the endpoint, so that the endpoint owner can easily resubscribe to the topic if
        /// the <code>Unsubscribe</code> request was unintended.
        /// 
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        UnsubscribeResponse Unsubscribe(UnsubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribe
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        IAsyncResult BeginUnsubscribe(UnsubscribeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Unsubscribe operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        /// 
        /// <returns>Returns a  UnsubscribeResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult);

        #endregion
        
    }
}