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

using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Interface for accessing AmazonSimpleNotificationService.
    ///  
    ///  Amazon Simple Notification Service <para>Amazon Simple Notification Service (Amazon SNS) is a web service that enables you to build
    /// distributed web-enabled applications. Applications can use Amazon SNS to easily push real-time notification messages to interested
    /// subscribers over multiple delivery protocols. For more information about this product see <a href="http://aws.amazon.com/sns/"
    /// >http://aws.amazon.com/sns</a> . For detailed information about Amazon SNS features and their associated API calls, see the <a
    /// href="http://docs.aws.amazon.com/sns/latest/dg/" >Amazon SNS Developer Guide</a> .
    /// </para> <para>We also provide SDKs that enable you to access Amazon SNS from your preferred programming language. The SDKs contain
    /// functionality that automatically takes care of tasks such as: cryptographically signing your service requests, retrying requests, and
    /// handling error responses. For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/" >Tools for Amazon Web Services</a> .
    /// </para>
    /// </summary>
    public partial interface IAmazonSimpleNotificationService : IDisposable
    {


        #region AddPermission

        /// <summary>
        /// <para>The <c>AddPermission</c> action adds a statement to a topic's access control policy, granting access for the specified AWS accounts to
        /// the specified actions.</para>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        AddPermissionResponse AddPermission(AddPermissionRequest addPermissionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAddPermission(AddPermissionRequest addPermissionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        AddPermissionResponse EndAddPermission(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ConfirmSubscription

        /// <summary>
        /// <para>The <c>ConfirmSubscription</c> action verifies an endpoint owner's intent to receive messages by validating the token sent to the
        /// endpoint by an earlier <c>Subscribe</c> action. If the token is valid, the action creates a new subscription and returns its Amazon Resource
        /// Name (ARN). This call requires an AWS signature only when the <c>AuthenticateOnUnsubscribe</c> flag is set to "true".</para>
        /// </summary>
        /// 
        /// <param name="confirmSubscriptionRequest">Container for the necessary parameters to execute the ConfirmSubscription service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ConfirmSubscription service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="SubscriptionLimitExceededException"/>
        /// <exception cref="InvalidParameterException"/>
        ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest confirmSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ConfirmSubscription"/>
        /// </summary>
        /// 
        /// <param name="confirmSubscriptionRequest">Container for the necessary parameters to execute the ConfirmSubscription operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmSubscription operation.</returns>
        IAsyncResult BeginConfirmSubscription(ConfirmSubscriptionRequest confirmSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ConfirmSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSubscription.</param>
        /// 
        /// <returns>Returns a ConfirmSubscriptionResult from AmazonSimpleNotificationService.</returns>
        ConfirmSubscriptionResponse EndConfirmSubscription(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePlatformApplication

        /// <summary>
        /// <para>The <c>CreatePlatformApplication</c> action creates a platform application object for one of the supported push notification services,
        /// such as APNS and GCM, to which devices and mobile apps may register. You must specify PlatformPrincipal and PlatformCredential attributes
        /// when using the <c>CreatePlatformApplication</c> action. The PlatformPrincipal is received from the notification service. For
        /// APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". For GCM, PlatformPrincipal is not applicable. For ADM, PlatformPrincipal is
        /// "client id". The PlatformCredential is also received from the notification service. For APNS/APNS_SANDBOX, PlatformCredential is "private
        /// key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret". The PlatformApplicationArn that is returned
        /// when using <c>CreatePlatformApplication</c> is then used as an attribute for the <c>CreatePlatformEndpoint</c> action. For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createPlatformApplicationRequest">Container for the necessary parameters to execute the CreatePlatformApplication service
        ///          method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreatePlatformApplication service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest createPlatformApplicationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreatePlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="createPlatformApplicationRequest">Container for the necessary parameters to execute the CreatePlatformApplication operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreatePlatformApplication operation.</returns>
        IAsyncResult BeginCreatePlatformApplication(CreatePlatformApplicationRequest createPlatformApplicationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreatePlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformApplication.</param>
        /// 
        /// <returns>Returns a CreatePlatformApplicationResult from AmazonSimpleNotificationService.</returns>
        CreatePlatformApplicationResponse EndCreatePlatformApplication(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePlatformEndpoint

        /// <summary>
        /// <para>The <c>CreatePlatformEndpoint</c> action creates an endpoint for a device and mobile app on one of the supported push notification
        /// services, such as GCM and APNS. <c>CreatePlatformEndpoint</c> requires the PlatformApplicationArn that is returned from
        /// <c>CreatePlatformApplication</c> . The EndpointArn that is returned when using <c>CreatePlatformEndpoint</c> can then be used by the
        /// <c>Publish</c> action to send a message to a mobile app or by the <c>Subscribe</c> action for subscription to a topic. The
        /// <c>CreatePlatformEndpoint</c> action is idempotent, so if the requester already owns an endpoint with the same device token and attributes,
        /// that endpoint's ARN is returned without creating a new endpoint. For more information, see <a
        /// href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createPlatformEndpointRequest">Container for the necessary parameters to execute the CreatePlatformEndpoint service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest createPlatformEndpointRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreatePlatformEndpoint"/>
        /// </summary>
        /// 
        /// <param name="createPlatformEndpointRequest">Container for the necessary parameters to execute the CreatePlatformEndpoint operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreatePlatformEndpoint operation.</returns>
        IAsyncResult BeginCreatePlatformEndpoint(CreatePlatformEndpointRequest createPlatformEndpointRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreatePlatformEndpoint"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformEndpoint.</param>
        /// 
        /// <returns>Returns a CreatePlatformEndpointResult from AmazonSimpleNotificationService.</returns>
        CreatePlatformEndpointResponse EndCreatePlatformEndpoint(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateTopic

        /// <summary>
        /// <para>The <c>CreateTopic</c> action creates a topic to which notifications can be published. Users can create at most 3000 topics. For more
        /// information, see <a href="http://aws.amazon.com/sns/" >http://aws.amazon.com/sns</a> .
        /// This action is idempotent, so if the requester already owns a topic with the specified name, that topic's ARN is returned without
        /// creating a new topic.</para>
        /// </summary>
        /// 
        /// <param name="createTopicRequest">Container for the necessary parameters to execute the CreateTopic service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        /// <exception cref="TopicLimitExceededException"/>
        CreateTopicResponse CreateTopic(CreateTopicRequest createTopicRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreateTopic"/>
        /// </summary>
        /// 
        /// <param name="createTopicRequest">Container for the necessary parameters to execute the CreateTopic operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopic
        ///         operation.</returns>
        IAsyncResult BeginCreateTopic(CreateTopicRequest createTopicRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreateTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopic.</param>
        /// 
        /// <returns>Returns a CreateTopicResult from AmazonSimpleNotificationService.</returns>
        CreateTopicResponse EndCreateTopic(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteEndpoint

        /// <summary>
        /// <para>The <c>DeleteEndpoint</c> action, which is idempotent, deletes the endpoint from SNS. For more information, see <a
        /// href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteEndpointRequest">Container for the necessary parameters to execute the DeleteEndpoint service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest deleteEndpointRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteEndpoint"/>
        /// </summary>
        /// 
        /// <param name="deleteEndpointRequest">Container for the necessary parameters to execute the DeleteEndpoint operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest deleteEndpointRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteEndpoint"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeletePlatformApplication

        /// <summary>
        /// <para>The <c>DeletePlatformApplication</c> action deletes a platform application object for one of the supported push notification services,
        /// such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deletePlatformApplicationRequest">Container for the necessary parameters to execute the DeletePlatformApplication service
        ///          method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest deletePlatformApplicationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeletePlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="deletePlatformApplicationRequest">Container for the necessary parameters to execute the DeletePlatformApplication operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeletePlatformApplication(DeletePlatformApplicationRequest deletePlatformApplicationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeletePlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlatformApplication.</param>
        DeletePlatformApplicationResponse EndDeletePlatformApplication(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteTopic

        /// <summary>
        /// <para>The <c>DeleteTopic</c> action deletes a topic and all its subscriptions. Deleting a topic might prevent some messages previously sent
        /// to the topic from being delivered to subscribers. This action is idempotent, so deleting a topic that does not exist does not result in an
        /// error.</para>
        /// </summary>
        /// 
        /// <param name="deleteTopicRequest">Container for the necessary parameters to execute the DeleteTopic service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        DeleteTopicResponse DeleteTopic(DeleteTopicRequest deleteTopicRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteTopic"/>
        /// </summary>
        /// 
        /// <param name="deleteTopicRequest">Container for the necessary parameters to execute the DeleteTopic operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteTopic(DeleteTopicRequest deleteTopicRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopic.</param>
        DeleteTopicResponse EndDeleteTopic(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetEndpointAttributes

        /// <summary>
        /// <para>The <c>GetEndpointAttributes</c> retrieves the endpoint attributes for a device on one of the supported push notification services,
        /// such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getEndpointAttributesRequest">Container for the necessary parameters to execute the GetEndpointAttributes service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest getEndpointAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetEndpointAttributes"/>
        /// </summary>
        /// 
        /// <param name="getEndpointAttributesRequest">Container for the necessary parameters to execute the GetEndpointAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetEndpointAttributes operation.</returns>
        IAsyncResult BeginGetEndpointAttributes(GetEndpointAttributesRequest getEndpointAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetEndpointAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a GetEndpointAttributesResult from AmazonSimpleNotificationService.</returns>
        GetEndpointAttributesResponse EndGetEndpointAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetPlatformApplicationAttributes

        /// <summary>
        /// <para>The <c>GetPlatformApplicationAttributes</c> action retrieves the attributes of the platform application object for the supported push
        /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html"
        /// >Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getPlatformApplicationAttributesRequest">Container for the necessary parameters to execute the GetPlatformApplicationAttributes
        ///          service method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest getPlatformApplicationAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetPlatformApplicationAttributes"/>
        /// </summary>
        /// 
        /// <param name="getPlatformApplicationAttributesRequest">Container for the necessary parameters to execute the GetPlatformApplicationAttributes
        ///          operation on AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetPlatformApplicationAttributes operation.</returns>
        IAsyncResult BeginGetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest getPlatformApplicationAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetPlatformApplicationAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a GetPlatformApplicationAttributesResult from AmazonSimpleNotificationService.</returns>
        GetPlatformApplicationAttributesResponse EndGetPlatformApplicationAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetSubscriptionAttributes

        /// <summary>
        /// <para>The <c>GetSubscriptionAttribtues</c> action returns all of the properties of a subscription.</para>
        /// </summary>
        /// 
        /// <param name="getSubscriptionAttributesRequest">Container for the necessary parameters to execute the GetSubscriptionAttributes service
        ///          method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="getSubscriptionAttributesRequest">Container for the necessary parameters to execute the GetSubscriptionAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetSubscriptionAttributes operation.</returns>
        IAsyncResult BeginGetSubscriptionAttributes(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a GetSubscriptionAttributesResult from AmazonSimpleNotificationService.</returns>
        GetSubscriptionAttributesResponse EndGetSubscriptionAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetTopicAttributes

        /// <summary>
        /// <para>The <c>GetTopicAttributes</c> action returns all of the properties of a topic. Topic properties returned might differ based on the
        /// authorization of the user. </para>
        /// </summary>
        /// 
        /// <param name="getTopicAttributesRequest">Container for the necessary parameters to execute the GetTopicAttributes service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest getTopicAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="getTopicAttributesRequest">Container for the necessary parameters to execute the GetTopicAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetTopicAttributes operation.</returns>
        IAsyncResult BeginGetTopicAttributes(GetTopicAttributesRequest getTopicAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicAttributes.</param>
        /// 
        /// <returns>Returns a GetTopicAttributesResult from AmazonSimpleNotificationService.</returns>
        GetTopicAttributesResponse EndGetTopicAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListEndpointsByPlatformApplication

        /// <summary>
        /// <para>The <c>ListEndpointsByPlatformApplication</c> action lists the endpoints and endpoint attributes for devices in a supported push
        /// notification service, such as GCM and APNS. The results for <c>ListEndpointsByPlatformApplication</c> are paginated and return a limited
        /// list of endpoints, up to 100. If additional records are available after the first page results, then a NextToken string will be returned. To
        /// receive the next page, you call <c>ListEndpointsByPlatformApplication</c> again using the NextToken string received from the previous call.
        /// When there are no more records to return, NextToken will be null. For more information, see <a
        /// href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="listEndpointsByPlatformApplicationRequest">Container for the necessary parameters to execute the
        ///          ListEndpointsByPlatformApplication service method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListEndpointsByPlatformApplication service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest listEndpointsByPlatformApplicationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListEndpointsByPlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="listEndpointsByPlatformApplicationRequest">Container for the necessary parameters to execute the
        ///          ListEndpointsByPlatformApplication operation on AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListEndpointsByPlatformApplication operation.</returns>
        IAsyncResult BeginListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest listEndpointsByPlatformApplicationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListEndpointsByPlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointsByPlatformApplication.</param>
        /// 
        /// <returns>Returns a ListEndpointsByPlatformApplicationResult from AmazonSimpleNotificationService.</returns>
        ListEndpointsByPlatformApplicationResponse EndListEndpointsByPlatformApplication(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListPlatformApplications

        /// <summary>
        /// <para>The <c>ListPlatformApplications</c> action lists the platform application objects for the supported push notification services, such
        /// as APNS and GCM. The results for <c>ListPlatformApplications</c> are paginated and return a limited list of applications, up to 100. If
        /// additional records are available after the first page results, then a NextToken string will be returned. To receive the next page, you call
        /// <c>ListPlatformApplications</c> using the NextToken string received from the previous call. When there are no more records to return,
        /// NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="listPlatformApplicationsRequest">Container for the necessary parameters to execute the ListPlatformApplications service method
        ///          on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest listPlatformApplicationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListPlatformApplications"/>
        /// </summary>
        /// 
        /// <param name="listPlatformApplicationsRequest">Container for the necessary parameters to execute the ListPlatformApplications operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListPlatformApplications operation.</returns>
        IAsyncResult BeginListPlatformApplications(ListPlatformApplicationsRequest listPlatformApplicationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListPlatformApplications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlatformApplications.</param>
        /// 
        /// <returns>Returns a ListPlatformApplicationsResult from AmazonSimpleNotificationService.</returns>
        ListPlatformApplicationsResponse EndListPlatformApplications(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <c>ListPlatformApplications</c> action lists the platform application objects for the supported push notification services, such
        /// as APNS and GCM. The results for <c>ListPlatformApplications</c> are paginated and return a limited list of applications, up to 100. If
        /// additional records are available after the first page results, then a NextToken string will be returned. To receive the next page, you call
        /// <c>ListPlatformApplications</c> using the NextToken string received from the previous call. When there are no more records to return,
        /// NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListPlatformApplicationsResponse ListPlatformApplications();
        
        #endregion
        
    

        #region ListSubscriptions

        /// <summary>
        /// <para>The <c>ListSubscriptions</c> action returns a list of the requester's subscriptions. Each call returns a limited list of
        /// subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new
        /// <c>ListSubscriptions</c> call to get further results.</para>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsRequest">Container for the necessary parameters to execute the ListSubscriptions service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsRequest">Container for the necessary parameters to execute the ListSubscriptions operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a ListSubscriptionsResult from AmazonSimpleNotificationService.</returns>
        ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <c>ListSubscriptions</c> action returns a list of the requester's subscriptions. Each call returns a limited list of
        /// subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new
        /// <c>ListSubscriptions</c> call to get further results.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListSubscriptionsResponse ListSubscriptions();
        
        #endregion
        
    

        #region ListSubscriptionsByTopic

        /// <summary>
        /// <para>The <c>ListSubscriptionsByTopic</c> action returns a list of the subscriptions to a specific topic. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a
        /// new <c>ListSubscriptionsByTopic</c> call to get further results.</para>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsByTopicRequest">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method
        ///          on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptionsByTopic"/>
        /// </summary>
        /// 
        /// <param name="listSubscriptionsByTopicRequest">Container for the necessary parameters to execute the ListSubscriptionsByTopic operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListSubscriptionsByTopic operation.</returns>
        IAsyncResult BeginListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListSubscriptionsByTopic"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionsByTopic.</param>
        /// 
        /// <returns>Returns a ListSubscriptionsByTopicResult from AmazonSimpleNotificationService.</returns>
        ListSubscriptionsByTopicResponse EndListSubscriptionsByTopic(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListTopics

        /// <summary>
        /// <para>The <c>ListTopics</c> action returns a list of the requester's topics. Each call returns a limited list of topics, up to 100. If there
        /// are more topics, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further
        /// results.</para>
        /// </summary>
        /// 
        /// <param name="listTopicsRequest">Container for the necessary parameters to execute the ListTopics service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListTopicsResponse ListTopics(ListTopicsRequest listTopicsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListTopics"/>
        /// </summary>
        /// 
        /// <param name="listTopicsRequest">Container for the necessary parameters to execute the ListTopics operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopics
        ///         operation.</returns>
        IAsyncResult BeginListTopics(ListTopicsRequest listTopicsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListTopics"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a ListTopicsResult from AmazonSimpleNotificationService.</returns>
        ListTopicsResponse EndListTopics(IAsyncResult asyncResult);

        /// <summary>
        /// <para>The <c>ListTopics</c> action returns a list of the requester's topics. Each call returns a limited list of topics, up to 100. If there
        /// are more topics, a <c>NextToken</c> is also returned. Use the <c>NextToken</c> parameter in a new <c>ListTopics</c> call to get further
        /// results.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        ListTopicsResponse ListTopics();
        
        #endregion
        
    

        #region Publish

        /// <summary>
        /// <para>The <c>Publish</c> action sends a message to all of a topic's subscribed endpoints. When a <c>messageId</c> is returned, the message
        /// has been saved and Amazon SNS will attempt to deliver it to the topic's subscribers shortly. The format of the outgoing message to each
        /// subscribed endpoint depends on the notification protocol selected.</para> <para>To use the <c>Publish</c> action for sending a message to a
        /// mobile endpoint, such as an app on a Kindle device or mobile phone, you must specify the EndpointArn. The EndpointArn is returned when
        /// making a call with the <c>CreatePlatformEndpoint</c> action. The second example below shows a request and response for publishing to a
        /// mobile endpoint. </para>
        /// </summary>
        /// 
        /// <param name="publishRequest">Container for the necessary parameters to execute the Publish service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="PlatformApplicationDisabledException"/>
        /// <exception cref="EndpointDisabledException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        PublishResponse Publish(PublishRequest publishRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Publish"/>
        /// </summary>
        /// 
        /// <param name="publishRequest">Container for the necessary parameters to execute the Publish operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublish
        ///         operation.</returns>
        IAsyncResult BeginPublish(PublishRequest publishRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Publish"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a PublishResult from AmazonSimpleNotificationService.</returns>
        PublishResponse EndPublish(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RemovePermission

        /// <summary>
        /// <para>The <c>RemovePermission</c> action removes a statement from a topic's access control policy.</para>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest removePermissionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRemovePermission(RemovePermissionRequest removePermissionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetEndpointAttributes

        /// <summary>
        /// <para>The <c>SetEndpointAttributes</c> action sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html" >Using
        /// Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="setEndpointAttributesRequest">Container for the necessary parameters to execute the SetEndpointAttributes service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest setEndpointAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetEndpointAttributes"/>
        /// </summary>
        /// 
        /// <param name="setEndpointAttributesRequest">Container for the necessary parameters to execute the SetEndpointAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetEndpointAttributes(SetEndpointAttributesRequest setEndpointAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetEndpointAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetEndpointAttributes.</param>
        SetEndpointAttributesResponse EndSetEndpointAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetPlatformApplicationAttributes

        /// <summary>
        /// <para>The <c>SetPlatformApplicationAttributes</c> action sets the attributes of the platform application object for the supported push
        /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html"
        /// >Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="setPlatformApplicationAttributesRequest">Container for the necessary parameters to execute the SetPlatformApplicationAttributes
        ///          service method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest setPlatformApplicationAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetPlatformApplicationAttributes"/>
        /// </summary>
        /// 
        /// <param name="setPlatformApplicationAttributesRequest">Container for the necessary parameters to execute the SetPlatformApplicationAttributes
        ///          operation on AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest setPlatformApplicationAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetPlatformApplicationAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPlatformApplicationAttributes.</param>
        SetPlatformApplicationAttributesResponse EndSetPlatformApplicationAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetSubscriptionAttributes

        /// <summary>
        /// <para>The <c>SetSubscriptionAttributes</c> action allows a subscription owner to set an attribute of the topic to a new value.</para>
        /// </summary>
        /// 
        /// <param name="setSubscriptionAttributesRequest">Container for the necessary parameters to execute the SetSubscriptionAttributes service
        ///          method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="setSubscriptionAttributesRequest">Container for the necessary parameters to execute the SetSubscriptionAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetSubscriptionAttributes(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetSubscriptionAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSubscriptionAttributes.</param>
        SetSubscriptionAttributesResponse EndSetSubscriptionAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region SetTopicAttributes

        /// <summary>
        /// <para>The <c>SetTopicAttributes</c> action allows a topic owner to set an attribute of the topic to a new value.</para>
        /// </summary>
        /// 
        /// <param name="setTopicAttributesRequest">Container for the necessary parameters to execute the SetTopicAttributes service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest setTopicAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="setTopicAttributesRequest">Container for the necessary parameters to execute the SetTopicAttributes operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginSetTopicAttributes(SetTopicAttributesRequest setTopicAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetTopicAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTopicAttributes.</param>
        SetTopicAttributesResponse EndSetTopicAttributes(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region Subscribe

        /// <summary>
        /// <para>The <c>Subscribe</c> action prepares to subscribe an endpoint by sending the endpoint a confirmation message. To actually create a
        /// subscription, the endpoint owner must call the <c>ConfirmSubscription</c> action with the token from the confirmation message. Confirmation
        /// tokens are valid for three days.</para>
        /// </summary>
        /// 
        /// <param name="subscribeRequest">Container for the necessary parameters to execute the Subscribe service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="SubscriptionLimitExceededException"/>
        /// <exception cref="InvalidParameterException"/>
        SubscribeResponse Subscribe(SubscribeRequest subscribeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Subscribe"/>
        /// </summary>
        /// 
        /// <param name="subscribeRequest">Container for the necessary parameters to execute the Subscribe operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSubscribe
        ///         operation.</returns>
        IAsyncResult BeginSubscribe(SubscribeRequest subscribeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Subscribe"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a SubscribeResult from AmazonSimpleNotificationService.</returns>
        SubscribeResponse EndSubscribe(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region Unsubscribe

        /// <summary>
        /// <para>The <c>Unsubscribe</c> action deletes a subscription. If the subscription requires authentication for deletion, only the owner of the
        /// subscription or the topic's owner can unsubscribe, and an AWS signature is required. If the <c>Unsubscribe</c> call does not require
        /// authentication and the requester is not the subscription owner, a final cancellation message is delivered to the endpoint, so that the
        /// endpoint owner can easily resubscribe to the topic if the <c>Unsubscribe</c> request was unintended.</para>
        /// </summary>
        /// 
        /// <param name="unsubscribeRequest">Container for the necessary parameters to execute the Unsubscribe service method on
        ///          AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="NotFoundException"/>
        /// <exception cref="AuthorizationErrorException"/>
        /// <exception cref="InternalErrorException"/>
        /// <exception cref="InvalidParameterException"/>
        UnsubscribeResponse Unsubscribe(UnsubscribeRequest unsubscribeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Unsubscribe"/>
        /// </summary>
        /// 
        /// <param name="unsubscribeRequest">Container for the necessary parameters to execute the Unsubscribe operation on
        ///          AmazonSimpleNotificationService.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUnsubscribe(UnsubscribeRequest unsubscribeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.Unsubscribe"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
