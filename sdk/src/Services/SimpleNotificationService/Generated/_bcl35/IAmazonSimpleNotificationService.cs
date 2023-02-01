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
    /// delivery protocols. For more information about this product see the <a href="http://aws.amazon.com/sns/">Amazon
    /// SNS product page</a>. For detailed information about Amazon SNS features and their
    /// associated API calls, see the <a href="https://docs.aws.amazon.com/sns/latest/dg/">Amazon
    /// SNS Developer Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-authentication-and-access-control.html">Identity
    /// and access management in Amazon SNS</a> in the <i>Amazon SNS Developer Guide.</i>
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISimpleNotificationServicePaginatorFactory Paginators { get; }
#endif


        
        #region  AddPermission


        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// Amazon Web Services accounts to the specified actions.
        /// 
        ///  <note> 
        /// <para>
        /// To remove the ability to change topic permissions, you must deny permissions to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetTopicAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        /// <param name="awsAccountId">The Amazon Web Services account IDs of the users (principals) who will be given access to the specified actions. The users must have Amazon Web Services account, but do not need to be signed up for this service.</param>
        /// <param name="actionName">The action you want to allow for the specified principal(s). Valid values: Any Amazon SNS action name, for example <code>Publish</code>.</param>
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
        /// Amazon Web Services accounts to the specified actions.
        /// 
        ///  <note> 
        /// <para>
        /// To remove the ability to change topic permissions, you must deny permissions to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetTopicAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </note>
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
        /// SMS messages from your Amazon Web Services account. You cannot send SMS messages to
        /// a number that is opted out.
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
        /// the limit for your Amazon Web Services account.
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
        /// <param name="authenticateOnUnsubscribe">Disallows unauthenticated unsubscribes of the subscription. If the value of this parameter is <code>true</code> and the request has an Amazon Web Services signature, then only the topic owner and the subscription owner can unsubscribe the endpoint. The unsubscribe action requires Amazon Web Services authentication. </param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
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
        /// such as APNS and GCM (Firebase Cloud Messaging), to which devices and mobile apps
        /// may register. You must specify <code>PlatformPrincipal</code> and <code>PlatformCredential</code>
        /// attributes when using the <code>CreatePlatformApplication</code> action.
        /// 
        ///  
        /// <para>
        ///  <code>PlatformPrincipal</code> and <code>PlatformCredential</code> are received from
        /// the notification service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <code>ADM</code>, <code>PlatformPrincipal</code> is <code>client id</code> and
        /// <code>PlatformCredential</code> is <code>client secret</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>Baidu</code>, <code>PlatformPrincipal</code> is <code>API key</code> and
        /// <code>PlatformCredential</code> is <code>secret key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>APNS</code> and <code>APNS_SANDBOX</code> using certificate credentials,
        /// <code>PlatformPrincipal</code> is <code>SSL certificate</code> and <code>PlatformCredential</code>
        /// is <code>private key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>APNS</code> and <code>APNS_SANDBOX</code> using token credentials, <code>PlatformPrincipal</code>
        /// is <code>signing key ID</code> and <code>PlatformCredential</code> is <code>signing
        /// key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>GCM</code> (Firebase Cloud Messaging), there is no <code>PlatformPrincipal</code>
        /// and the <code>PlatformCredential</code> is <code>API key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>MPNS</code>, <code>PlatformPrincipal</code> is <code>TLS certificate</code>
        /// and <code>PlatformCredential</code> is <code>private key</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <code>WNS</code>, <code>PlatformPrincipal</code> is <code>Package Security Identifier</code>
        /// and <code>PlatformCredential</code> is <code>secret key</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use the returned <code>PlatformApplicationArn</code> as an attribute for the
        /// <code>CreatePlatformEndpoint</code> action.
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
        /// services, such as GCM (Firebase Cloud Messaging) and APNS. <code>CreatePlatformEndpoint</code>
        /// requires the <code>PlatformApplicationArn</code> that is returned from <code>CreatePlatformApplication</code>.
        /// You can use the returned <code>EndpointArn</code> to send a message to a mobile app
        /// or by the <code>Subscribe</code> action for subscription to a topic. The <code>CreatePlatformEndpoint</code>
        /// action is idempotent, so if the requester already owns an endpoint with the same device
        /// token and attributes, that endpoint's ARN is returned without creating a new endpoint.
        /// For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>. 
        /// 
        ///  
        /// <para>
        /// When using <code>CreatePlatformEndpoint</code> with Baidu, two attributes must be
        /// provided: ChannelId and UserId. The token field must also contain the ChannelId. For
        /// more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePushBaiduEndpoint.html">Creating
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
        
        #region  CreateSMSSandboxPhoneNumber


        /// <summary>
        /// Adds a destination phone number to an Amazon Web Services account in the SMS sandbox
        /// and sends a one-time password (OTP) to that phone number.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your Amazon Web Services account
        /// is in the <i>SMS sandbox</i>. The SMS sandbox provides a safe environment for you
        /// to try Amazon SNS features without risking your reputation as an SMS sender. While
        /// your Amazon Web Services account is in the SMS sandbox, you can use all of the features
        /// of Amazon SNS. However, you can send SMS messages only to verified destination phone
        /// numbers. For more information, including how to move out of the sandbox to send messages
        /// without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSMSSandboxPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the CreateSMSSandboxPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.OptedOutException">
        /// Indicates that the specified phone number opted out of receiving SMS messages from
        /// your Amazon Web Services account. You can't send SMS messages to phone numbers that
        /// opt out.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.UserErrorException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateSMSSandboxPhoneNumber">REST API Reference for CreateSMSSandboxPhoneNumber Operation</seealso>
        CreateSMSSandboxPhoneNumberResponse CreateSMSSandboxPhoneNumber(CreateSMSSandboxPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSMSSandboxPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSMSSandboxPhoneNumber operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSMSSandboxPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateSMSSandboxPhoneNumber">REST API Reference for CreateSMSSandboxPhoneNumber Operation</seealso>
        IAsyncResult BeginCreateSMSSandboxPhoneNumber(CreateSMSSandboxPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSMSSandboxPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSMSSandboxPhoneNumber.</param>
        /// 
        /// <returns>Returns a  CreateSMSSandboxPhoneNumberResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateSMSSandboxPhoneNumber">REST API Reference for CreateSMSSandboxPhoneNumber Operation</seealso>
        CreateSMSSandboxPhoneNumberResponse EndCreateSMSSandboxPhoneNumber(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopic


        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create at most
        /// 100,000 standard topics (at most 1,000 FIFO topics). For more information, see <a
        /// href="https://docs.aws.amazon.com/sns/latest/dg/sns-create-topic.html">Creating an
        /// Amazon SNS topic</a> in the <i>Amazon SNS Developer Guide</i>. This action is idempotent,
        /// so if the requester already owns a topic with the specified name, that topic's ARN
        /// is returned without creating a new topic.
        /// </summary>
        /// <param name="name">The name of the topic you want to create. Constraints: Topic names must be made up of only uppercase and lowercase ASCII letters, numbers, underscores, and hyphens, and must be between 1 and 256 characters long. For a FIFO (first-in-first-out) topic, the name must end with the <code>.fifo</code> suffix. </param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/CreateTopic">REST API Reference for CreateTopic Operation</seealso>
        CreateTopicResponse CreateTopic(string name);

        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create at most
        /// 100,000 standard topics (at most 1,000 FIFO topics). For more information, see <a
        /// href="https://docs.aws.amazon.com/sns/latest/dg/sns-create-topic.html">Creating an
        /// Amazon SNS topic</a> in the <i>Amazon SNS Developer Guide</i>. This action is idempotent,
        /// so if the requester already owns a topic with the specified name, that topic's ARN
        /// is returned without creating a new topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
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
        /// For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
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
        /// such as APNS and GCM (Firebase Cloud Messaging). For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
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
        
        #region  DeleteSMSSandboxPhoneNumber


        /// <summary>
        /// Deletes an Amazon Web Services account's verified or pending phone number from the
        /// SMS sandbox.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your Amazon Web Services account
        /// is in the <i>SMS sandbox</i>. The SMS sandbox provides a safe environment for you
        /// to try Amazon SNS features without risking your reputation as an SMS sender. While
        /// your Amazon Web Services account is in the SMS sandbox, you can use all of the features
        /// of Amazon SNS. However, you can send SMS messages only to verified destination phone
        /// numbers. For more information, including how to move out of the sandbox to send messages
        /// without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSMSSandboxPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the DeleteSMSSandboxPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.UserErrorException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteSMSSandboxPhoneNumber">REST API Reference for DeleteSMSSandboxPhoneNumber Operation</seealso>
        DeleteSMSSandboxPhoneNumberResponse DeleteSMSSandboxPhoneNumber(DeleteSMSSandboxPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSMSSandboxPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSMSSandboxPhoneNumber operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSMSSandboxPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteSMSSandboxPhoneNumber">REST API Reference for DeleteSMSSandboxPhoneNumber Operation</seealso>
        IAsyncResult BeginDeleteSMSSandboxPhoneNumber(DeleteSMSSandboxPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSMSSandboxPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSMSSandboxPhoneNumber.</param>
        /// 
        /// <returns>Returns a  DeleteSMSSandboxPhoneNumberResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/DeleteSMSSandboxPhoneNumber">REST API Reference for DeleteSMSSandboxPhoneNumber Operation</seealso>
        DeleteSMSSandboxPhoneNumberResponse EndDeleteSMSSandboxPhoneNumber(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
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
        
        #region  GetDataProtectionPolicy


        /// <summary>
        /// Retrieves the specified inline <code>DataProtectionPolicy</code> document that is
        /// stored in the specified Amazon SNS topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDataProtectionPolicy service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        GetDataProtectionPolicyResponse GetDataProtectionPolicy(GetDataProtectionPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionPolicy operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataProtectionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        IAsyncResult BeginGetDataProtectionPolicy(GetDataProtectionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataProtectionPolicy.</param>
        /// 
        /// <returns>Returns a  GetDataProtectionPolicyResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        GetDataProtectionPolicyResponse EndGetDataProtectionPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEndpointAttributes


        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification
        /// services, such as GCM (Firebase Cloud Messaging) and APNS. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
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
        /// notification services, such as APNS and GCM (Firebase Cloud Messaging). For more information,
        /// see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
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
        /// Returns the settings for sending SMS messages from your Amazon Web Services account.
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
        /// the limit for your Amazon Web Services account.
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
        
        #region  GetSMSSandboxAccountStatus


        /// <summary>
        /// Retrieves the SMS sandbox status for the calling Amazon Web Services account in the
        /// target Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your Amazon Web Services account
        /// is in the <i>SMS sandbox</i>. The SMS sandbox provides a safe environment for you
        /// to try Amazon SNS features without risking your reputation as an SMS sender. While
        /// your Amazon Web Services account is in the SMS sandbox, you can use all of the features
        /// of Amazon SNS. However, you can send SMS messages only to verified destination phone
        /// numbers. For more information, including how to move out of the sandbox to send messages
        /// without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSMSSandboxAccountStatus service method.</param>
        /// 
        /// <returns>The response from the GetSMSSandboxAccountStatus service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSSandboxAccountStatus">REST API Reference for GetSMSSandboxAccountStatus Operation</seealso>
        GetSMSSandboxAccountStatusResponse GetSMSSandboxAccountStatus(GetSMSSandboxAccountStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSMSSandboxAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSMSSandboxAccountStatus operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSMSSandboxAccountStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSSandboxAccountStatus">REST API Reference for GetSMSSandboxAccountStatus Operation</seealso>
        IAsyncResult BeginGetSMSSandboxAccountStatus(GetSMSSandboxAccountStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSMSSandboxAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSMSSandboxAccountStatus.</param>
        /// 
        /// <returns>Returns a  GetSMSSandboxAccountStatusResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/GetSMSSandboxAccountStatus">REST API Reference for GetSMSSandboxAccountStatus Operation</seealso>
        GetSMSSandboxAccountStatusResponse EndGetSMSSandboxAccountStatus(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
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
        /// service, such as GCM (Firebase Cloud Messaging) and APNS. The results for <code>ListEndpointsByPlatformApplication</code>
        /// are paginated and return a limited list of endpoints, up to 100. If additional records
        /// are available after the first page results, then a NextToken string will be returned.
        /// To receive the next page, you call <code>ListEndpointsByPlatformApplication</code>
        /// again using the NextToken string received from the previous call. When there are no
        /// more records to return, NextToken will be null. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
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
        
        #region  ListOriginationNumbers


        /// <summary>
        /// Lists the calling Amazon Web Services account's dedicated origination numbers and
        /// their metadata. For more information about origination numbers, see <a href="https://docs.aws.amazon.com/sns/latest/dg/channels-sms-originating-identities-origination-numbers.html">Origination
        /// numbers</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOriginationNumbers service method.</param>
        /// 
        /// <returns>The response from the ListOriginationNumbers service method, as returned by SimpleNotificationService.</returns>
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
        /// the limit for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ValidationException">
        /// Indicates that a parameter in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListOriginationNumbers">REST API Reference for ListOriginationNumbers Operation</seealso>
        ListOriginationNumbersResponse ListOriginationNumbers(ListOriginationNumbersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOriginationNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOriginationNumbers operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOriginationNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListOriginationNumbers">REST API Reference for ListOriginationNumbers Operation</seealso>
        IAsyncResult BeginListOriginationNumbers(ListOriginationNumbersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOriginationNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOriginationNumbers.</param>
        /// 
        /// <returns>Returns a  ListOriginationNumbersResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListOriginationNumbers">REST API Reference for ListOriginationNumbers Operation</seealso>
        ListOriginationNumbersResponse EndListOriginationNumbers(IAsyncResult asyncResult);

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
        /// the limit for your Amazon Web Services account.
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
        /// such as APNS and GCM (Firebase Cloud Messaging). The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100. If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned. To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call. When there are no more
        /// records to return, <code>NextToken</code> will be null. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>. 
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
        /// such as APNS and GCM (Firebase Cloud Messaging). The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100. If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned. To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call. When there are no more
        /// records to return, <code>NextToken</code> will be null. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>. 
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
        
        #region  ListSMSSandboxPhoneNumbers


        /// <summary>
        /// Lists the calling Amazon Web Services account's current verified and pending destination
        /// phone numbers in the SMS sandbox.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your Amazon Web Services account
        /// is in the <i>SMS sandbox</i>. The SMS sandbox provides a safe environment for you
        /// to try Amazon SNS features without risking your reputation as an SMS sender. While
        /// your Amazon Web Services account is in the SMS sandbox, you can use all of the features
        /// of Amazon SNS. However, you can send SMS messages only to verified destination phone
        /// numbers. For more information, including how to move out of the sandbox to send messages
        /// without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSMSSandboxPhoneNumbers service method.</param>
        /// 
        /// <returns>The response from the ListSMSSandboxPhoneNumbers service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your Amazon Web Services account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSMSSandboxPhoneNumbers">REST API Reference for ListSMSSandboxPhoneNumbers Operation</seealso>
        ListSMSSandboxPhoneNumbersResponse ListSMSSandboxPhoneNumbers(ListSMSSandboxPhoneNumbersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSMSSandboxPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSMSSandboxPhoneNumbers operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSMSSandboxPhoneNumbers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSMSSandboxPhoneNumbers">REST API Reference for ListSMSSandboxPhoneNumbers Operation</seealso>
        IAsyncResult BeginListSMSSandboxPhoneNumbers(ListSMSSandboxPhoneNumbersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSMSSandboxPhoneNumbers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSMSSandboxPhoneNumbers.</param>
        /// 
        /// <returns>Returns a  ListSMSSandboxPhoneNumbersResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListSMSSandboxPhoneNumbers">REST API Reference for ListSMSSandboxPhoneNumbers Operation</seealso>
        ListSMSSandboxPhoneNumbersResponse EndListSMSSandboxPhoneNumbers(IAsyncResult asyncResult);

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
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags added to the specified Amazon SNS topic. For an overview, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-tags.html">Amazon
        /// SNS Tags</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// the limit for your Amazon Web Services account.
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
        /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
        /// phone number, or a message to a mobile platform endpoint (when you specify the <code>TargetArn</code>).
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message is saved and Amazon SNS immediately
        /// delivers it to subscribers.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for publishing a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can publish messages only to topics and endpoints in the same Amazon Web Services
        /// Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262,144 bytes, not 262,144 characters). </li> <li> For SMS, each message can contain up to 140 characters. This character limit depends on the encoding schema. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds this size limit, Amazon SNS sends the message as multiple messages, each fitting within the size limit. Messages aren't truncated mid-word but are cut off at whole-word boundaries. The total size limit for a single SMS <code>Publish</code> action is 1,600 characters. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ValidationException">
        /// Indicates that a parameter in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse Publish(string topicArn, string message);

        /// <summary>
        /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
        /// phone number, or a message to a mobile platform endpoint (when you specify the <code>TargetArn</code>).
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message is saved and Amazon SNS immediately
        /// delivers it to subscribers.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for publishing a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can publish messages only to topics and endpoints in the same Amazon Web Services
        /// Region.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="topicArn">The topic you want to publish to. If you don't specify a value for the <code>TopicArn</code> parameter, you must specify a value for the <code>PhoneNumber</code> or <code>TargetArn</code> parameters.</param>
        /// <param name="message">The message you want to send. If you are publishing to a topic and you want to send the same message to all transport protocols, include the text of the message as a String value. If you want to send different messages for each transport protocol, set the value of the <code>MessageStructure</code> parameter to <code>json</code> and use a JSON object for the <code>Message</code> parameter.  <p/> Constraints: <ul> <li> With the exception of SMS, messages must be UTF-8 encoded strings and at most 256 KB in size (262,144 bytes, not 262,144 characters). </li> <li> For SMS, each message can contain up to 140 characters. This character limit depends on the encoding schema. For example, an SMS message can contain 160 GSM characters, 140 ASCII characters, or 70 UCS-2 characters. If you publish a message that exceeds this size limit, Amazon SNS sends the message as multiple messages, each fitting within the size limit. Messages aren't truncated mid-word but are cut off at whole-word boundaries. The total size limit for a single SMS <code>Publish</code> action is 1,600 characters. </li> </ul> JSON-specific constraints: <ul> <li> Keys in the JSON object that correspond to supported transport protocols must have simple JSON string values. </li> <li> The values will be parsed (unescaped) before they are used in outgoing messages. </li> <li> Outbound notifications are JSON encoded (meaning that the characters will be reescaped for sending). </li> <li> Values have a minimum length of 0 (the empty string, "", is allowed). </li> <li> Values have a maximum length bounded by the overall message size (so, including multiple protocols may limit message sizes). </li> <li> Non-string values will cause the key to be ignored. </li> <li> Keys that do not correspond to supported transport protocols are ignored. </li> <li> Duplicate keys are not allowed. </li> <li> Failure to parse or validate any key or value in the message will cause the <code>Publish</code> call to return an error (no partial delivery). </li> </ul></param>
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ValidationException">
        /// Indicates that a parameter in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Publish">REST API Reference for Publish Operation</seealso>
        PublishResponse Publish(string topicArn, string message, string subject);

        /// <summary>
        /// Sends a message to an Amazon SNS topic, a text message (SMS message) directly to a
        /// phone number, or a message to a mobile platform endpoint (when you specify the <code>TargetArn</code>).
        /// 
        ///  
        /// <para>
        /// If you send a message to a topic, Amazon SNS delivers the message to each endpoint
        /// that is subscribed to the topic. The format of the message depends on the notification
        /// protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the message is saved and Amazon SNS immediately
        /// delivers it to subscribers.
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Publish</code> action for publishing a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone, you must specify the EndpointArn
        /// for the TargetArn parameter. The EndpointArn is returned when making a call with the
        /// <code>CreatePlatformEndpoint</code> action. 
        /// </para>
        ///  
        /// <para>
        /// For more information about formatting messages, see <a href="https://docs.aws.amazon.com/sns/latest/dg/mobile-push-send-custommessage.html">Send
        /// Custom Platform-Specific Payloads in Messages to Mobile Devices</a>. 
        /// </para>
        ///  <important> 
        /// <para>
        /// You can publish messages only to topics and endpoints in the same Amazon Web Services
        /// Region.
        /// </para>
        ///  </important>
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ValidationException">
        /// Indicates that a parameter in the request is invalid.
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
        
        #region  PublishBatch


        /// <summary>
        /// Publishes up to ten messages to the specified topic. This is a batch version of <code>Publish</code>.
        /// For FIFO topics, multiple messages within a single batch are published in the order
        /// they are sent, and messages are deduplicated within the batch and across batches for
        /// 5 minutes.
        /// 
        ///  
        /// <para>
        /// The result of publishing each message is reported individually in the response. Because
        /// the batch request can result in a combination of successful and unsuccessful actions,
        /// you should check for batch errors even when the call returns an HTTP status code of
        /// <code>200</code>.
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed individual message size and the maximum total payload size (the
        /// sum of the individual lengths of all of the batched messages) are both 256 KB (262,144
        /// bytes). 
        /// </para>
        ///  
        /// <para>
        /// Some actions take lists of parameters. These lists are specified using the <code>param.n</code>
        /// notation. Values of <code>n</code> are integers starting from 1. For example, a parameter
        /// list with two elements looks like this: 
        /// </para>
        ///  
        /// <para>
        /// &amp;AttributeName.1=first
        /// </para>
        ///  
        /// <para>
        /// &amp;AttributeName.2=second
        /// </para>
        ///  
        /// <para>
        /// If you send a batch message to a topic, Amazon SNS publishes the batch message to
        /// each endpoint that is subscribed to the topic. The format of the batch message depends
        /// on the notification protocol for each subscribed endpoint.
        /// </para>
        ///  
        /// <para>
        /// When a <code>messageId</code> is returned, the batch message is saved and Amazon SNS
        /// immediately delivers the message to subscribers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishBatch service method.</param>
        /// 
        /// <returns>The response from the PublishBatch service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.BatchRequestTooLongException">
        /// The length of all the batch messages put together is more than the limit.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSAccessDeniedException">
        /// The ciphertext references a key that doesn't exist or that you don't have access to.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSDisabledException">
        /// The request was rejected because the specified customer master key (CMK) isn't enabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource isn't valid for
        /// this request. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSNotFoundException">
        /// The request was rejected because the specified entity or resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSOptInRequiredException">
        /// The Amazon Web Services access key ID needs a subscription for the service.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.KMSThrottlingException">
        /// The request was denied due to request throttling. For more information about throttling,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#requests-per-second">Limits</a>
        /// in the <i>Key Management Service Developer Guide.</i>
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ValidationException">
        /// Indicates that a parameter in the request is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/PublishBatch">REST API Reference for PublishBatch Operation</seealso>
        PublishBatchResponse PublishBatch(PublishBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishBatch operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishBatch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/PublishBatch">REST API Reference for PublishBatch Operation</seealso>
        IAsyncResult BeginPublishBatch(PublishBatchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishBatch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishBatch.</param>
        /// 
        /// <returns>Returns a  PublishBatchResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/PublishBatch">REST API Reference for PublishBatch Operation</seealso>
        PublishBatchResponse EndPublishBatch(IAsyncResult asyncResult);

        #endregion
        
        #region  PutDataProtectionPolicy


        /// <summary>
        /// Adds or updates an inline policy document that is stored in the specified Amazon SNS
        /// topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataProtectionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDataProtectionPolicy service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        PutDataProtectionPolicyResponse PutDataProtectionPolicy(PutDataProtectionPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataProtectionPolicy operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataProtectionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        IAsyncResult BeginPutDataProtectionPolicy(PutDataProtectionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataProtectionPolicy.</param>
        /// 
        /// <returns>Returns a  PutDataProtectionPolicyResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        PutDataProtectionPolicyResponse EndPutDataProtectionPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// 
        ///  <note> 
        /// <para>
        /// To remove the ability to change topic permissions, you must deny permissions to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetTopicAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </note>
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
        /// 
        ///  <note> 
        /// <para>
        /// To remove the ability to change topic permissions, you must deny permissions to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetTopicAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </note>
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
        /// services, such as GCM (Firebase Cloud Messaging) and APNS. For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
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
        /// services, such as APNS and GCM (Firebase Cloud Messaging). For more information, see
        /// <a href="https://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>. For information on configuring attributes for message
        /// delivery status, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using
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
        /// see <a href="https://docs.aws.amazon.com/sns/latest/dg/sms_publish-to-phone.html">Publishing
        /// to a mobile phone</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To use this operation, you must grant the Amazon SNS service principal (<code>sns.amazonaws.com</code>)
        /// permission to perform the <code>s3:ListBucket</code> action. 
        /// </para>
        ///  </note>
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
        /// the limit for your Amazon Web Services account.
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
        /// <param name="attributeName">A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request parameters that this action uses: <ul> <li>  <code>DeliveryPolicy</code> – The policy that defines how Amazon SNS retries failed deliveries to HTTP/S endpoints. </li> <li>  <code>FilterPolicy</code> – The simple JSON object that lets your subscriber receive only a subset of messages, rather than receiving every message published to the topic. </li> <li>  <code>FilterPolicyScope</code> – This attribute lets you choose the filtering scope by using one of the following string value types: <ul> <li>  <code>MessageAttributes</code> (default) – The filter is applied on the message attributes. </li> <li>  <code>MessageBody</code> – The filter is applied on the message body. </li> </ul> </li> <li>  <code>RawMessageDelivery</code> – When set to <code>true</code>, enables raw message delivery to Amazon SQS or HTTP/S endpoints. This eliminates the need for the endpoints to process JSON formatting, which is otherwise created for Amazon SNS metadata. </li> <li>  <code>RedrivePolicy</code> – When specified, sends undeliverable messages to the specified Amazon SQS dead-letter queue. Messages that can't be delivered due to client errors (for example, when the subscribed endpoint is unreachable) or server errors (for example, when the service that powers the subscribed endpoint becomes unavailable) are held in the dead-letter queue for further analysis or reprocessing. </li> </ul> The following attribute applies only to Amazon Kinesis Data Firehose delivery stream subscriptions: <ul> <li>  <code>SubscriptionRoleArn</code> – The ARN of the IAM role that has the following: <ul> <li> Permission to write to the Kinesis Data Firehose delivery stream </li> <li> Amazon SNS listed as a trusted entity </li> </ul> Specifying a valid ARN for this attribute is required for Kinesis Data Firehose delivery stream subscriptions. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-firehose-as-subscriber.html">Fanout to Kinesis Data Firehose delivery streams</a> in the <i>Amazon SNS Developer Guide</i>. </li> </ul></param>
        /// <param name="attributeValue">The new value for the attribute in JSON format.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
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
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
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
        /// 
        ///  <note> 
        /// <para>
        /// To remove the ability to change topic permissions, you must deny permissions to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetTopicAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic to modify.</param>
        /// <param name="attributeName">A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request parameters that the <code>SetTopicAttributes</code> action uses: <ul> <li>  <code>ApplicationSuccessFeedbackRoleArn</code> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to a platform application endpoint. </li> <li>  <code>DeliveryPolicy</code> – The policy that defines how Amazon SNS retries failed deliveries to HTTP/S endpoints. </li> <li>  <code>DisplayName</code> – The display name to use for a topic with SMS subscriptions. </li> <li>  <code>Policy</code> – The policy that defines who can access your topic. By default, only the topic owner can publish or subscribe to the topic. </li> <li> HTTP <ul> <li>  <code>HTTPSuccessFeedbackRoleArn</code> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an HTTP endpoint.  </li> <li>  <code>HTTPSuccessFeedbackSampleRate</code> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an HTTP endpoint. </li> <li>  <code>HTTPFailureFeedbackRoleArn</code> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an HTTP endpoint. </li> </ul> </li> <li> Amazon Kinesis Data Firehose <ul> <li>  <code>FirehoseSuccessFeedbackRoleArn</code> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Amazon Kinesis Data Firehose endpoint. </li> <li>  <code>FirehoseSuccessFeedbackSampleRate</code> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Amazon Kinesis Data Firehose endpoint. </li> <li>  <code>FirehoseFailureFeedbackRoleArn</code> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Amazon Kinesis Data Firehose endpoint.  </li> </ul> </li> <li> Lambda <ul> <li>  <code>LambdaSuccessFeedbackRoleArn</code> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Lambda endpoint. </li> <li>  <code>LambdaSuccessFeedbackSampleRate</code> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Lambda endpoint. </li> <li>  <code>LambdaFailureFeedbackRoleArn</code> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Lambda endpoint.  </li> </ul> </li> <li> Platform application endpoint <ul> <li>  <code>ApplicationSuccessFeedbackRoleArn</code> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Amazon Web Services application endpoint. </li> <li>  <code>ApplicationSuccessFeedbackSampleRate</code> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Amazon Web Services application endpoint. </li> <li>  <code>ApplicationFailureFeedbackRoleArn</code> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Amazon Web Services application endpoint. </li> </ul> <note> In addition to being able to configure topic attributes for message delivery status of notification messages sent to Amazon SNS application endpoints, you can also configure application attributes for the delivery status of push notification messages sent to push notification services. For example, For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-msg-status.html">Using Amazon SNS Application Attributes for Message Delivery Status</a>.  </note> </li> <li> Amazon SQS <ul> <li>  <code>SQSSuccessFeedbackRoleArn</code> – Indicates successful message delivery status for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint.  </li> <li>  <code>SQSSuccessFeedbackSampleRate</code> – Indicates percentage of successful messages to sample for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint.  </li> <li>  <code>SQSFailureFeedbackRoleArn</code> – Indicates failed message delivery status for an Amazon SNS topic that is subscribed to an Amazon SQS endpoint.  </li> </ul> </li> </ul> <note> The &lt;ENDPOINT&gt;SuccessFeedbackRoleArn and &lt;ENDPOINT&gt;FailureFeedbackRoleArn attributes are used to give Amazon SNS write access to use CloudWatch Logs on your behalf. The &lt;ENDPOINT&gt;SuccessFeedbackSampleRate attribute is for specifying the sample rate percentage (0-100) of successfully delivered messages. After you configure the &lt;ENDPOINT&gt;FailureFeedbackRoleArn attribute, then all failed message deliveries generate CloudWatch Logs.  </note> The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <code>KmsMasterKeyId</code> – The ID of an Amazon Web Services managed customer master key (CMK) for Amazon SNS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-server-side-encryption.html#sse-key-terms">Key Terms</a>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a> in the <i>Key Management Service API Reference</i>.  </li> <li>  <code>SignatureVersion</code> – The signature version corresponds to the hashing algorithm used while creating the signature of the notifications, subscription confirmations, or unsubscribe confirmation messages sent by Amazon SNS. </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-fifo-topics.html">FIFO topics</a>: <ul> <li>  <code>ContentBasedDeduplication</code> – Enables content-based deduplication for FIFO topics. <ul> <li> By default, <code>ContentBasedDeduplication</code> is set to <code>false</code>. If you create a FIFO topic and this attribute is <code>false</code>, you must specify a value for the <code>MessageDeduplicationId</code> parameter for the <a href="https://docs.aws.amazon.com/sns/latest/api/API_Publish.html">Publish</a> action.  </li> <li> When you set <code>ContentBasedDeduplication</code> to <code>true</code>, Amazon SNS uses a SHA-256 hash to generate the <code>MessageDeduplicationId</code> using the body of the message (but not the attributes of the message). (Optional) To override the generated value, you can specify a value for the <code>MessageDeduplicationId</code> parameter for the <code>Publish</code> action. </li> </ul> </li> </ul></param>
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/SetTopicAttributes">REST API Reference for SetTopicAttributes Operation</seealso>
        SetTopicAttributesResponse SetTopicAttributes(string topicArn, string attributeName, string attributeValue);

        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// 
        ///  <note> 
        /// <para>
        /// To remove the ability to change topic permissions, you must deny permissions to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetTopicAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </note>
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
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
        /// Subscribes an endpoint to an Amazon SNS topic. If the endpoint type is HTTP/S or email,
        /// or if the endpoint and the topic are not in the same Amazon Web Services account,
        /// the endpoint owner must run the <code>ConfirmSubscription</code> action to confirm
        /// the subscription.
        /// 
        ///  
        /// <para>
        /// You call the <code>ConfirmSubscription</code> action with the token from the subscription
        /// response. Confirmation tokens are valid for three days.
        /// </para>
        ///  
        /// <para>
        /// This action is throttled at 100 transactions per second (TPS).
        /// </para>
        /// </summary>
        /// <param name="topicArn">The ARN of the topic you want to subscribe to.</param>
        /// <param name="protocol">The protocol that you want to use. Supported protocols include: <ul> <li>  <code>http</code> – delivery of JSON-encoded message via HTTP POST </li> <li>  <code>https</code> – delivery of JSON-encoded message via HTTPS POST </li> <li>  <code>email</code> – delivery of message via SMTP </li> <li>  <code>email-json</code> – delivery of JSON-encoded message via SMTP </li> <li>  <code>sms</code> – delivery of message via SMS </li> <li>  <code>sqs</code> – delivery of JSON-encoded message to an Amazon SQS queue </li> <li>  <code>application</code> – delivery of JSON-encoded message to an EndpointArn for a mobile app and device </li> <li>  <code>lambda</code> – delivery of JSON-encoded message to an Lambda function </li> <li>  <code>firehose</code> – delivery of JSON-encoded message to an Amazon Kinesis Data Firehose delivery stream. </li> </ul></param>
        /// <param name="endpoint">The endpoint that you want to receive notifications. Endpoints vary by protocol: <ul> <li> For the <code>http</code> protocol, the (public) endpoint is a URL beginning with <code>http://</code>. </li> <li> For the <code>https</code> protocol, the (public) endpoint is a URL beginning with <code>https://</code>. </li> <li> For the <code>email</code> protocol, the endpoint is an email address. </li> <li> For the <code>email-json</code> protocol, the endpoint is an email address. </li> <li> For the <code>sms</code> protocol, the endpoint is a phone number of an SMS-enabled device. </li> <li> For the <code>sqs</code> protocol, the endpoint is the ARN of an Amazon SQS queue. </li> <li> For the <code>application</code> protocol, the endpoint is the EndpointArn of a mobile app and device. </li> <li> For the <code>lambda</code> protocol, the endpoint is the ARN of an Lambda function. </li> <li> For the <code>firehose</code> protocol, the endpoint is the ARN of an Amazon Kinesis Data Firehose delivery stream. </li> </ul></param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.FilterPolicyLimitExceededException">
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
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
        /// Subscribes an endpoint to an Amazon SNS topic. If the endpoint type is HTTP/S or email,
        /// or if the endpoint and the topic are not in the same Amazon Web Services account,
        /// the endpoint owner must run the <code>ConfirmSubscription</code> action to confirm
        /// the subscription.
        /// 
        ///  
        /// <para>
        /// You call the <code>ConfirmSubscription</code> action with the token from the subscription
        /// response. Confirmation tokens are valid for three days.
        /// </para>
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
        /// Indicates that the number of filter polices in your Amazon Web Services account exceeds
        /// the limit. To add more filter polices, submit an Amazon SNS Limit Increase case in
        /// the Amazon Web Services Support Center.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
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
        
        #region  TagResource


        /// <summary>
        /// Add tags to the specified Amazon SNS topic. For an overview, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-tags.html">Amazon
        /// SNS Tags</a> in the <i>Amazon SNS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you use topic tags, keep the following guidelines in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Adding more than 50 tags to a topic isn't recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags don't have any semantic meaning. Amazon SNS interprets tags as character strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new tag with a key identical to that of an existing tag overwrites the existing
        /// tag.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tagging actions are limited to 10 TPS per Amazon Web Services account, per Amazon
        /// Web Services Region. If your application requires a higher throughput, file a <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=technical">technical
        /// support request</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  Unsubscribe


        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for deletion,
        /// only the owner of the subscription or the topic's owner can unsubscribe, and an Amazon
        /// Web Services signature is required. If the <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not the subscription owner, a final cancellation
        /// message is delivered to the endpoint, so that the endpoint owner can easily resubscribe
        /// to the topic if the <code>Unsubscribe</code> request was unintended.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon SQS queue subscriptions require authentication for deletion. Only the owner
        /// of the subscription, or the owner of the topic can unsubscribe using the required
        /// Amazon Web Services signature.
        /// </para>
        ///  </note> 
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/Unsubscribe">REST API Reference for Unsubscribe Operation</seealso>
        UnsubscribeResponse Unsubscribe(string subscriptionArn);

        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for deletion,
        /// only the owner of the subscription or the topic's owner can unsubscribe, and an Amazon
        /// Web Services signature is required. If the <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not the subscription owner, a final cancellation
        /// message is delivered to the endpoint, so that the endpoint owner can easily resubscribe
        /// to the topic if the <code>Unsubscribe</code> request was unintended.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon SQS queue subscriptions require authentication for deletion. Only the owner
        /// of the subscription, or the owner of the topic can unsubscribe using the required
        /// Amazon Web Services signature.
        /// </para>
        ///  </note> 
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
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidSecurityException">
        /// The credential signature isn't valid. You must use an HTTPS endpoint and sign your
        /// request using Signature Version 4.
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
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from the specified Amazon SNS topic. For an overview, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-tags.html">Amazon
        /// SNS Tags</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ConcurrentAccessException">
        /// Can't perform multiple operations on a tag simultaneously. Perform the operations
        /// sequentially.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.StaleTagException">
        /// A tag has been added to a resource with the same ARN as a deleted resource. Wait a
        /// short while and then retry the operation.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagLimitExceededException">
        /// Can't add more than 50 tags to a topic.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.TagPolicyException">
        /// The request doesn't comply with the IAM tag policy. Correct your request and then
        /// retry it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifySMSSandboxPhoneNumber


        /// <summary>
        /// Verifies a destination phone number with a one-time password (OTP) for the calling
        /// Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// When you start using Amazon SNS to send SMS messages, your Amazon Web Services account
        /// is in the <i>SMS sandbox</i>. The SMS sandbox provides a safe environment for you
        /// to try Amazon SNS features without risking your reputation as an SMS sender. While
        /// your Amazon Web Services account is in the SMS sandbox, you can use all of the features
        /// of Amazon SNS. However, you can send SMS messages only to verified destination phone
        /// numbers. For more information, including how to move out of the sandbox to send messages
        /// without restrictions, see <a href="https://docs.aws.amazon.com/sns/latest/dg/sns-sms-sandbox.html">SMS
        /// sandbox</a> in the <i>Amazon SNS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifySMSSandboxPhoneNumber service method.</param>
        /// 
        /// <returns>The response from the VerifySMSSandboxPhoneNumber service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ResourceNotFoundException">
        /// Can’t perform the action on the specified resource. Make sure that the resource exists.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.ThrottledException">
        /// Indicates that the rate at which requests have been submitted for this action exceeds
        /// the limit for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.SimpleNotificationService.Model.VerificationException">
        /// Indicates that the one-time password (OTP) used for verification is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/VerifySMSSandboxPhoneNumber">REST API Reference for VerifySMSSandboxPhoneNumber Operation</seealso>
        VerifySMSSandboxPhoneNumberResponse VerifySMSSandboxPhoneNumber(VerifySMSSandboxPhoneNumberRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifySMSSandboxPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifySMSSandboxPhoneNumber operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifySMSSandboxPhoneNumber
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/VerifySMSSandboxPhoneNumber">REST API Reference for VerifySMSSandboxPhoneNumber Operation</seealso>
        IAsyncResult BeginVerifySMSSandboxPhoneNumber(VerifySMSSandboxPhoneNumberRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifySMSSandboxPhoneNumber operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifySMSSandboxPhoneNumber.</param>
        /// 
        /// <returns>Returns a  VerifySMSSandboxPhoneNumberResult from SimpleNotificationService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sns-2010-03-31/VerifySMSSandboxPhoneNumber">REST API Reference for VerifySMSSandboxPhoneNumber Operation</seealso>
        VerifySMSSandboxPhoneNumberResponse EndVerifySMSSandboxPhoneNumber(IAsyncResult asyncResult);

        #endregion
        
    }
}