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


using System;

using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Implementation for accessing SimpleNotificationService
    ///
    /// Amazon Simple Notification Service        
    /// <para>
    /// Amazon Simple Notification Service (Amazon SNS) is a web service that enables you
    /// to build distributed web-enabled applications.         Applications can use Amazon SNS
    /// to easily push real-time notification messages         to interested subscribers over
    /// multiple delivery protocols. For more information about this product        see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
    /// For detailed information about Amazon SNS features and their associated API calls,        see
    /// the <a href="http://docs.aws.amazon.com/sns/latest/dg/">Amazon SNS Developer Guide</a>.    
    /// </para>
    ///     
    /// <para>
    /// We also provide SDKs that enable you to access Amazon SNS from your preferred programming
    /// language.       The SDKs contain functionality that automatically takes care of tasks
    /// such as: cryptographically signing your service requests,       retrying requests,
    /// and handling error responses. For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.      
    /// </para>
    /// </summary>
    public partial interface IAmazonSimpleNotificationService : IDisposable
    {

        
        #region  AddPermission


        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// AWS accounts to the specified actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPermission
        ///         operation.</returns>
        IAsyncResult BeginAddPermission(AddPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        /// 
        /// <returns>Returns a  AddPermissionResult from SimpleNotificationService.</returns>
        AddPermissionResponse EndAddPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmSubscription


        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating      the token
        /// sent to the endpoint by an earlier <code>Subscribe</code> action. If the      token
        /// is valid, the action creates a new subscription and returns its      Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <code>AuthenticateOnUnsubscribe</code>
        /// flag is set to "true".
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription service method.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmSubscription operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmSubscription
        ///         operation.</returns>
        IAsyncResult BeginConfirmSubscription(ConfirmSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSubscription.</param>
        /// 
        /// <returns>Returns a  ConfirmSubscriptionResult from SimpleNotificationService.</returns>
        ConfirmSubscriptionResponse EndConfirmSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlatformApplication


        /// <summary>
        /// Creates a platform application object for one of the supported push notification services,
        ///       such as APNS and GCM, to which devices and mobile apps may register. You must
        /// specify PlatformPrincipal and PlatformCredential attributes when using       the <code>CreatePlatformApplication</code>
        /// action. The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX,
        /// PlatformPrincipal is "SSL certificate".       For GCM, PlatformPrincipal is not applicable.
        /// For ADM, PlatformPrincipal is "client id". The PlatformCredential is also received
        /// from the notification service.       For APNS/APNS_SANDBOX, PlatformCredential is
        /// "private key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential
        /// is "client secret".            The PlatformApplicationArn that is returned when using
        /// <code>CreatePlatformApplication</code> is then used as an attribute for the <code>CreatePlatformEndpoint</code>
        /// action.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlatformApplication
        ///         operation.</returns>
        IAsyncResult BeginCreatePlatformApplication(CreatePlatformApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformApplication.</param>
        /// 
        /// <returns>Returns a  CreatePlatformApplicationResult from SimpleNotificationService.</returns>
        CreatePlatformApplicationResponse EndCreatePlatformApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlatformEndpoint


        /// <summary>
        /// Creates an endpoint for a device and mobile app on one of the supported push notification
        /// services, such as GCM and APNS.       <code>CreatePlatformEndpoint</code> requires
        /// the PlatformApplicationArn that is returned from <code>CreatePlatformApplication</code>.
        /// The EndpointArn that is      returned when using <code>CreatePlatformEndpoint</code>
        /// can then be used by the <code>Publish</code> action to send a message to a mobile
        /// app or by the <code>Subscribe</code>       action for subscription to a topic. The
        /// <code>CreatePlatformEndpoint</code> action is idempotent, so if the requester already
        /// owns an endpoint with the same device token and attributes,       that endpoint's
        /// ARN is returned without creating a new endpoint.       For more information, see <a
        /// href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS
        /// Mobile Push Notifications</a>.    
        /// 
        ///     
        /// <para>
        /// When using <code>CreatePlatformEndpoint</code> with Baidu, two attributes must be
        /// provided: ChannelId and UserId. The token field must also contain the ChannelId. 
        ///      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePushBaiduEndpoint.html">Creating
        /// an Amazon SNS Endpoint for Baidu</a>.          
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlatformEndpoint
        ///         operation.</returns>
        IAsyncResult BeginCreatePlatformEndpoint(CreatePlatformEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformEndpoint.</param>
        /// 
        /// <returns>Returns a  CreatePlatformEndpointResult from SimpleNotificationService.</returns>
        CreatePlatformEndpointResponse EndCreatePlatformEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopic


        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create     at most
        /// 3000 topics. For more information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
        ///      This action is idempotent, so if the requester already owns a topic with the
        /// specified name, that topic's ARN is      returned without creating a new topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
        CreateTopicResponse CreateTopic(CreateTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopic
        ///         operation.</returns>
        IAsyncResult BeginCreateTopic(CreateTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopic.</param>
        /// 
        /// <returns>Returns a  CreateTopicResult from SimpleNotificationService.</returns>
        CreateTopicResponse EndCreateTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes the endpoint from Amazon SNS. This action is idempotent.       For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from SimpleNotificationService.</returns>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlatformApplication


        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services,
        ///       such as APNS and GCM.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the DeletePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlatformApplication
        ///         operation.</returns>
        IAsyncResult BeginDeletePlatformApplication(DeletePlatformApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlatformApplication.</param>
        /// 
        /// <returns>Returns a  DeletePlatformApplicationResult from SimpleNotificationService.</returns>
        DeletePlatformApplicationResponse EndDeletePlatformApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTopic


        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might      prevent some
        /// messages previously sent to the topic from being delivered to      subscribers. This
        /// action is idempotent, so deleting a topic that does not      exist does not result
        /// in an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        DeleteTopicResponse DeleteTopic(DeleteTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTopic
        ///         operation.</returns>
        IAsyncResult BeginDeleteTopic(DeleteTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopic.</param>
        /// 
        /// <returns>Returns a  DeleteTopicResult from SimpleNotificationService.</returns>
        DeleteTopicResponse EndDeleteTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEndpointAttributes


        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification
        /// services, such as GCM and APNS.       For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEndpointAttributes
        ///         operation.</returns>
        IAsyncResult BeginGetEndpointAttributes(GetEndpointAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a  GetEndpointAttributesResult from SimpleNotificationService.</returns>
        GetEndpointAttributesResponse EndGetEndpointAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPlatformApplicationAttributes


        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push
        /// notification services,       such as APNS and GCM.      For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlatformApplicationAttributes
        ///         operation.</returns>
        IAsyncResult BeginGetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a  GetPlatformApplicationAttributesResult from SimpleNotificationService.</returns>
        GetPlatformApplicationAttributesResponse EndGetPlatformApplicationAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSubscriptionAttributes


        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSubscriptionAttributes
        ///         operation.</returns>
        IAsyncResult BeginGetSubscriptionAttributes(GetSubscriptionAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionAttributesResult from SimpleNotificationService.</returns>
        GetSubscriptionAttributesResponse EndGetSubscriptionAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTopicAttributes


        /// <summary>
        /// Returns all of the properties of a topic.     Topic properties returned might differ
        /// based on the authorization of the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTopicAttributes
        ///         operation.</returns>
        IAsyncResult BeginGetTopicAttributes(GetTopicAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicAttributes.</param>
        /// 
        /// <returns>Returns a  GetTopicAttributesResult from SimpleNotificationService.</returns>
        GetTopicAttributesResponse EndGetTopicAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpointsByPlatformApplication


        /// <summary>
        /// Lists the endpoints and endpoint attributes for devices in a supported push notification
        /// service, such as GCM and APNS.       The results for <code>ListEndpointsByPlatformApplication</code>
        /// are paginated and return a limited list of endpoints, up to 100.      If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned.       To receive the next page, you call <code>ListEndpointsByPlatformApplication</code>
        /// again using the NextToken string received from the previous call.       When there
        /// are no more records to return, NextToken will be null.      For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication service method.</param>
        /// 
        /// <returns>The response from the ListEndpointsByPlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointsByPlatformApplication
        ///         operation.</returns>
        IAsyncResult BeginListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointsByPlatformApplication.</param>
        /// 
        /// <returns>Returns a  ListEndpointsByPlatformApplicationResult from SimpleNotificationService.</returns>
        ListEndpointsByPlatformApplicationResponse EndListEndpointsByPlatformApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPlatformApplications

        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        ///       such as APNS and GCM. The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100.      If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned.       To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call.       When there are no
        /// more records to return, NextToken will be null.            For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        ListPlatformApplicationsResponse ListPlatformApplications();

        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        ///       such as APNS and GCM. The results for <code>ListPlatformApplications</code>
        /// are paginated and return a limited list of applications, up to 100.      If additional
        /// records are available after the first page results, then a NextToken string will be
        /// returned.       To receive the next page, you call <code>ListPlatformApplications</code>
        /// using the NextToken string received from the previous call.       When there are no
        /// more records to return, NextToken will be null.            For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications service method.</param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlatformApplications
        ///         operation.</returns>
        IAsyncResult BeginListPlatformApplications(ListPlatformApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlatformApplications.</param>
        /// 
        /// <returns>Returns a  ListPlatformApplicationsResult from SimpleNotificationService.</returns>
        ListPlatformApplicationsResponse EndListPlatformApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptions

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        ///      of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        ListSubscriptionsResponse ListSubscriptions();

        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        ///      of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsResult from SimpleNotificationService.</returns>
        ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptionsByTopic


        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns       a
        /// limited list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code>       parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptionsByTopic
        ///         operation.</returns>
        IAsyncResult BeginListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionsByTopic.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsByTopicResult from SimpleNotificationService.</returns>
        ListSubscriptionsByTopicResponse EndListSubscriptionsByTopic(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopics

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        ListTopicsResponse ListTopics();

        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopics service method.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        ListTopicsResponse ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopics operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopics
        ///         operation.</returns>
        IAsyncResult BeginListTopics(ListTopicsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a  ListTopicsResult from SimpleNotificationService.</returns>
        ListTopicsResponse EndListTopics(IAsyncResult asyncResult);

        #endregion
        
        #region  Publish


        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints. When a    <code>messageId</code>
        /// is returned, the message has been saved and Amazon SNS will attempt to deliver it
        ///       to the topic's subscribers shortly. The format of the outgoing message to each
        ///      subscribed endpoint depends on the notification protocol selected.
        /// 
        ///     
        /// <para>
        /// To use the <code>Publish</code> action for sending a message to a mobile endpoint,
        /// such as an app on a Kindle device or mobile phone,       you must specify the EndpointArn.
        /// The EndpointArn is returned when making a call with the <code>CreatePlatformEndpoint</code>
        /// action.       The second example below shows a request and response for publishing
        /// to a mobile endpoint.    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
        PublishResponse Publish(PublishRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublish
        ///         operation.</returns>
        IAsyncResult BeginPublish(PublishRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a  PublishResult from SimpleNotificationService.</returns>
        PublishResponse EndPublish(IAsyncResult asyncResult);

        #endregion
        
        #region  RemovePermission


        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemovePermission
        ///         operation.</returns>
        IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from SimpleNotificationService.</returns>
        RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  SetEndpointAttributes


        /// <summary>
        /// Sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM and APNS.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the SetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetEndpointAttributes
        ///         operation.</returns>
        IAsyncResult BeginSetEndpointAttributes(SetEndpointAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a  SetEndpointAttributesResult from SimpleNotificationService.</returns>
        SetEndpointAttributesResponse EndSetEndpointAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetPlatformApplicationAttributes


        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification
        /// services,       such as APNS and GCM.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the SetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetPlatformApplicationAttributes
        ///         operation.</returns>
        IAsyncResult BeginSetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a  SetPlatformApplicationAttributesResult from SimpleNotificationService.</returns>
        SetPlatformApplicationAttributesResponse EndSetPlatformApplicationAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetSubscriptionAttributes


        /// <summary>
        /// Allows a subscription owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetSubscriptionAttributes
        ///         operation.</returns>
        IAsyncResult BeginSetSubscriptionAttributes(SetSubscriptionAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a  SetSubscriptionAttributesResult from SimpleNotificationService.</returns>
        SetSubscriptionAttributesResponse EndSetSubscriptionAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  SetTopicAttributes


        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetTopicAttributes
        ///         operation.</returns>
        IAsyncResult BeginSetTopicAttributes(SetTopicAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTopicAttributes.</param>
        /// 
        /// <returns>Returns a  SetTopicAttributesResult from SimpleNotificationService.</returns>
        SetTopicAttributesResponse EndSetTopicAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  Subscribe


        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// To actually create a      subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
        ///      action with the token from the confirmation message. Confirmation tokens are
        ///      valid for three days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
        SubscribeResponse Subscribe(SubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Subscribe operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribe
        ///         operation.</returns>
        IAsyncResult BeginSubscribe(SubscribeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a  SubscribeResult from SimpleNotificationService.</returns>
        SubscribeResponse EndSubscribe(IAsyncResult asyncResult);

        #endregion
        
        #region  Unsubscribe


        /// <summary>
        /// Deletes a subscription. If the subscription requires authentication for       deletion,
        /// only the owner of the subscription or the topic's owner       can unsubscribe, and
        /// an AWS signature is required. If the       <code>Unsubscribe</code> call does not
        /// require authentication and the requester is not       the subscription owner, a final
        /// cancellation message is delivered to the       endpoint, so that the endpoint owner
        /// can easily resubscribe to the topic if       the <code>Unsubscribe</code> request
        /// was unintended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe service method.</param>
        /// 
        /// <returns>The response from the Unsubscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        UnsubscribeResponse Unsubscribe(UnsubscribeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Unsubscribe operation on AmazonSimpleNotificationServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnsubscribe
        ///         operation.</returns>
        IAsyncResult BeginUnsubscribe(UnsubscribeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        /// 
        /// <returns>Returns a  UnsubscribeResult from SimpleNotificationService.</returns>
        UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult);

        #endregion
        
    }
}