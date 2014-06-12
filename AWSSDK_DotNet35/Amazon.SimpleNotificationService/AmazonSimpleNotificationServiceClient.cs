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
using System.Threading;

using Amazon.SimpleNotificationService.Model;
using Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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
    public partial class AmazonSimpleNotificationServiceClient : AmazonWebServiceClient, IAmazonSimpleNotificationService
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSimpleNotificationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AmazonSimpleNotificationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Credentials and an
        /// AmazonSimpleNotificationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSimpleNotificationServiceClient Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSimpleNotificationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
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
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            IAsyncResult asyncResult = invokeAddPermission(request, null, null, true);
            return EndAddPermission(asyncResult);
        }

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
        public IAsyncResult BeginAddPermission(AddPermissionRequest request, AsyncCallback callback, object state)
        {
            return invokeAddPermission(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  AddPermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        /// 
        /// <returns>Returns a  AddPermissionResult from SimpleNotificationService.</returns>
        public  AddPermissionResponse EndAddPermission(IAsyncResult asyncResult)
        {
            return endOperation< AddPermissionResponse>(asyncResult);
        }

        IAsyncResult invokeAddPermission(AddPermissionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddPermissionRequestMarshaller().Marshall(request);
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            IAsyncResult asyncResult = invokeConfirmSubscription(request, null, null, true);
            return EndConfirmSubscription(asyncResult);
        }

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
        public IAsyncResult BeginConfirmSubscription(ConfirmSubscriptionRequest request, AsyncCallback callback, object state)
        {
            return invokeConfirmSubscription(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmSubscription operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmSubscription.</param>
        /// 
        /// <returns>Returns a  ConfirmSubscriptionResult from SimpleNotificationService.</returns>
        public  ConfirmSubscriptionResponse EndConfirmSubscription(IAsyncResult asyncResult)
        {
            return endOperation< ConfirmSubscriptionResponse>(asyncResult);
        }

        IAsyncResult invokeConfirmSubscription(ConfirmSubscriptionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfirmSubscriptionRequestMarshaller().Marshall(request);
            var unmarshaller = ConfirmSubscriptionResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            IAsyncResult asyncResult = invokeCreatePlatformApplication(request, null, null, true);
            return EndCreatePlatformApplication(asyncResult);
        }

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
        public IAsyncResult BeginCreatePlatformApplication(CreatePlatformApplicationRequest request, AsyncCallback callback, object state)
        {
            return invokeCreatePlatformApplication(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformApplication.</param>
        /// 
        /// <returns>Returns a  CreatePlatformApplicationResult from SimpleNotificationService.</returns>
        public  CreatePlatformApplicationResponse EndCreatePlatformApplication(IAsyncResult asyncResult)
        {
            return endOperation< CreatePlatformApplicationResponse>(asyncResult);
        }

        IAsyncResult invokeCreatePlatformApplication(CreatePlatformApplicationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePlatformApplicationRequestMarshaller().Marshall(request);
            var unmarshaller = CreatePlatformApplicationResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            IAsyncResult asyncResult = invokeCreatePlatformEndpoint(request, null, null, true);
            return EndCreatePlatformEndpoint(asyncResult);
        }

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
        public IAsyncResult BeginCreatePlatformEndpoint(CreatePlatformEndpointRequest request, AsyncCallback callback, object state)
        {
            return invokeCreatePlatformEndpoint(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlatformEndpoint.</param>
        /// 
        /// <returns>Returns a  CreatePlatformEndpointResult from SimpleNotificationService.</returns>
        public  CreatePlatformEndpointResponse EndCreatePlatformEndpoint(IAsyncResult asyncResult)
        {
            return endOperation< CreatePlatformEndpointResponse>(asyncResult);
        }

        IAsyncResult invokeCreatePlatformEndpoint(CreatePlatformEndpointRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePlatformEndpointRequestMarshaller().Marshall(request);
            var unmarshaller = CreatePlatformEndpointResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            IAsyncResult asyncResult = invokeCreateTopic(request, null, null, true);
            return EndCreateTopic(asyncResult);
        }

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
        public IAsyncResult BeginCreateTopic(CreateTopicRequest request, AsyncCallback callback, object state)
        {
            return invokeCreateTopic(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopic.</param>
        /// 
        /// <returns>Returns a  CreateTopicResult from SimpleNotificationService.</returns>
        public  CreateTopicResponse EndCreateTopic(IAsyncResult asyncResult)
        {
            return endOperation< CreateTopicResponse>(asyncResult);
        }

        IAsyncResult invokeCreateTopic(CreateTopicRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateTopicRequestMarshaller().Marshall(request);
            var unmarshaller = CreateTopicResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteEndpoint(request, null, null, true);
            return EndDeleteEndpoint(asyncResult);
        }

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
        public IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteEndpoint(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from SimpleNotificationService.</returns>
        public  DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult)
        {
            return endOperation< DeleteEndpointResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteEndpointRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            IAsyncResult asyncResult = invokeDeletePlatformApplication(request, null, null, true);
            return EndDeletePlatformApplication(asyncResult);
        }

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
        public IAsyncResult BeginDeletePlatformApplication(DeletePlatformApplicationRequest request, AsyncCallback callback, object state)
        {
            return invokeDeletePlatformApplication(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlatformApplication.</param>
        /// 
        /// <returns>Returns a  DeletePlatformApplicationResult from SimpleNotificationService.</returns>
        public  DeletePlatformApplicationResponse EndDeletePlatformApplication(IAsyncResult asyncResult)
        {
            return endOperation< DeletePlatformApplicationResponse>(asyncResult);
        }

        IAsyncResult invokeDeletePlatformApplication(DeletePlatformApplicationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePlatformApplicationRequestMarshaller().Marshall(request);
            var unmarshaller = DeletePlatformApplicationResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            IAsyncResult asyncResult = invokeDeleteTopic(request, null, null, true);
            return EndDeleteTopic(asyncResult);
        }

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
        public IAsyncResult BeginDeleteTopic(DeleteTopicRequest request, AsyncCallback callback, object state)
        {
            return invokeDeleteTopic(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopic.</param>
        /// 
        /// <returns>Returns a  DeleteTopicResult from SimpleNotificationService.</returns>
        public  DeleteTopicResponse EndDeleteTopic(IAsyncResult asyncResult)
        {
            return endOperation< DeleteTopicResponse>(asyncResult);
        }

        IAsyncResult invokeDeleteTopic(DeleteTopicRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTopicRequestMarshaller().Marshall(request);
            var unmarshaller = DeleteTopicResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeGetEndpointAttributes(request, null, null, true);
            return EndGetEndpointAttributes(asyncResult);
        }

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
        public IAsyncResult BeginGetEndpointAttributes(GetEndpointAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeGetEndpointAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a  GetEndpointAttributesResult from SimpleNotificationService.</returns>
        public  GetEndpointAttributesResponse EndGetEndpointAttributes(IAsyncResult asyncResult)
        {
            return endOperation< GetEndpointAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeGetEndpointAttributes(GetEndpointAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetEndpointAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = GetEndpointAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeGetPlatformApplicationAttributes(request, null, null, true);
            return EndGetPlatformApplicationAttributes(asyncResult);
        }

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
        public IAsyncResult BeginGetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeGetPlatformApplicationAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a  GetPlatformApplicationAttributesResult from SimpleNotificationService.</returns>
        public  GetPlatformApplicationAttributesResponse EndGetPlatformApplicationAttributes(IAsyncResult asyncResult)
        {
            return endOperation< GetPlatformApplicationAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeGetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetPlatformApplicationAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeGetSubscriptionAttributes(request, null, null, true);
            return EndGetSubscriptionAttributes(asyncResult);
        }

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
        public IAsyncResult BeginGetSubscriptionAttributes(GetSubscriptionAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeGetSubscriptionAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a  GetSubscriptionAttributesResult from SimpleNotificationService.</returns>
        public  GetSubscriptionAttributesResponse EndGetSubscriptionAttributes(IAsyncResult asyncResult)
        {
            return endOperation< GetSubscriptionAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeGetSubscriptionAttributes(GetSubscriptionAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetSubscriptionAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = GetSubscriptionAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeGetTopicAttributes(request, null, null, true);
            return EndGetTopicAttributes(asyncResult);
        }

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
        public IAsyncResult BeginGetTopicAttributes(GetTopicAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeGetTopicAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicAttributes.</param>
        /// 
        /// <returns>Returns a  GetTopicAttributesResult from SimpleNotificationService.</returns>
        public  GetTopicAttributesResponse EndGetTopicAttributes(IAsyncResult asyncResult)
        {
            return endOperation< GetTopicAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeGetTopicAttributes(GetTopicAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetTopicAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = GetTopicAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            IAsyncResult asyncResult = invokeListEndpointsByPlatformApplication(request, null, null, true);
            return EndListEndpointsByPlatformApplication(asyncResult);
        }

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
        public IAsyncResult BeginListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request, AsyncCallback callback, object state)
        {
            return invokeListEndpointsByPlatformApplication(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointsByPlatformApplication.</param>
        /// 
        /// <returns>Returns a  ListEndpointsByPlatformApplicationResult from SimpleNotificationService.</returns>
        public  ListEndpointsByPlatformApplicationResponse EndListEndpointsByPlatformApplication(IAsyncResult asyncResult)
        {
            return endOperation< ListEndpointsByPlatformApplicationResponse>(asyncResult);
        }

        IAsyncResult invokeListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListEndpointsByPlatformApplicationRequestMarshaller().Marshall(request);
            var unmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public ListPlatformApplicationsResponse ListPlatformApplications()
        {
            return ListPlatformApplications(new ListPlatformApplicationsRequest());
        }

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
        public ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            IAsyncResult asyncResult = invokeListPlatformApplications(request, null, null, true);
            return EndListPlatformApplications(asyncResult);
        }

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
        public IAsyncResult BeginListPlatformApplications(ListPlatformApplicationsRequest request, AsyncCallback callback, object state)
        {
            return invokeListPlatformApplications(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlatformApplications.</param>
        /// 
        /// <returns>Returns a  ListPlatformApplicationsResult from SimpleNotificationService.</returns>
        public  ListPlatformApplicationsResponse EndListPlatformApplications(IAsyncResult asyncResult)
        {
            return endOperation< ListPlatformApplicationsResponse>(asyncResult);
        }

        IAsyncResult invokeListPlatformApplications(ListPlatformApplicationsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListPlatformApplicationsRequestMarshaller().Marshall(request);
            var unmarshaller = ListPlatformApplicationsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public ListSubscriptionsResponse ListSubscriptions()
        {
            return ListSubscriptions(new ListSubscriptionsRequest());
        }

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
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            IAsyncResult asyncResult = invokeListSubscriptions(request, null, null, true);
            return EndListSubscriptions(asyncResult);
        }

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
        public IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state)
        {
            return invokeListSubscriptions(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptions operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsResult from SimpleNotificationService.</returns>
        public  ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult)
        {
            return endOperation< ListSubscriptionsResponse>(asyncResult);
        }

        IAsyncResult invokeListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListSubscriptionsRequestMarshaller().Marshall(request);
            var unmarshaller = ListSubscriptionsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            IAsyncResult asyncResult = invokeListSubscriptionsByTopic(request, null, null, true);
            return EndListSubscriptionsByTopic(asyncResult);
        }

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
        public IAsyncResult BeginListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request, AsyncCallback callback, object state)
        {
            return invokeListSubscriptionsByTopic(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptionsByTopic operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptionsByTopic.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsByTopicResult from SimpleNotificationService.</returns>
        public  ListSubscriptionsByTopicResponse EndListSubscriptionsByTopic(IAsyncResult asyncResult)
        {
            return endOperation< ListSubscriptionsByTopicResponse>(asyncResult);
        }

        IAsyncResult invokeListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListSubscriptionsByTopicRequestMarshaller().Marshall(request);
            var unmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public ListTopicsResponse ListTopics()
        {
            return ListTopics(new ListTopicsRequest());
        }

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
        public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            IAsyncResult asyncResult = invokeListTopics(request, null, null, true);
            return EndListTopics(asyncResult);
        }

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
        public IAsyncResult BeginListTopics(ListTopicsRequest request, AsyncCallback callback, object state)
        {
            return invokeListTopics(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopics operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopics.</param>
        /// 
        /// <returns>Returns a  ListTopicsResult from SimpleNotificationService.</returns>
        public  ListTopicsResponse EndListTopics(IAsyncResult asyncResult)
        {
            return endOperation< ListTopicsResponse>(asyncResult);
        }

        IAsyncResult invokeListTopics(ListTopicsRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListTopicsRequestMarshaller().Marshall(request);
            var unmarshaller = ListTopicsResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public PublishResponse Publish(PublishRequest request)
        {
            IAsyncResult asyncResult = invokePublish(request, null, null, true);
            return EndPublish(asyncResult);
        }

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
        public IAsyncResult BeginPublish(PublishRequest request, AsyncCallback callback, object state)
        {
            return invokePublish(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  Publish operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublish.</param>
        /// 
        /// <returns>Returns a  PublishResult from SimpleNotificationService.</returns>
        public  PublishResponse EndPublish(IAsyncResult asyncResult)
        {
            return endOperation< PublishResponse>(asyncResult);
        }

        IAsyncResult invokePublish(PublishRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PublishRequestMarshaller().Marshall(request);
            var unmarshaller = PublishResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            IAsyncResult asyncResult = invokeRemovePermission(request, null, null, true);
            return EndRemovePermission(asyncResult);
        }

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
        public IAsyncResult BeginRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state)
        {
            return invokeRemovePermission(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  RemovePermission operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        /// 
        /// <returns>Returns a  RemovePermissionResult from SimpleNotificationService.</returns>
        public  RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return endOperation< RemovePermissionResponse>(asyncResult);
        }

        IAsyncResult invokeRemovePermission(RemovePermissionRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemovePermissionRequestMarshaller().Marshall(request);
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeSetEndpointAttributes(request, null, null, true);
            return EndSetEndpointAttributes(asyncResult);
        }

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
        public IAsyncResult BeginSetEndpointAttributes(SetEndpointAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeSetEndpointAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetEndpointAttributes.</param>
        /// 
        /// <returns>Returns a  SetEndpointAttributesResult from SimpleNotificationService.</returns>
        public  SetEndpointAttributesResponse EndSetEndpointAttributes(IAsyncResult asyncResult)
        {
            return endOperation< SetEndpointAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeSetEndpointAttributes(SetEndpointAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetEndpointAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = SetEndpointAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeSetPlatformApplicationAttributes(request, null, null, true);
            return EndSetPlatformApplicationAttributes(asyncResult);
        }

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
        public IAsyncResult BeginSetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeSetPlatformApplicationAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetPlatformApplicationAttributes.</param>
        /// 
        /// <returns>Returns a  SetPlatformApplicationAttributesResult from SimpleNotificationService.</returns>
        public  SetPlatformApplicationAttributesResponse EndSetPlatformApplicationAttributes(IAsyncResult asyncResult)
        {
            return endOperation< SetPlatformApplicationAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeSetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetPlatformApplicationAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeSetSubscriptionAttributes(request, null, null, true);
            return EndSetSubscriptionAttributes(asyncResult);
        }

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
        public IAsyncResult BeginSetSubscriptionAttributes(SetSubscriptionAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeSetSubscriptionAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSubscriptionAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSubscriptionAttributes.</param>
        /// 
        /// <returns>Returns a  SetSubscriptionAttributesResult from SimpleNotificationService.</returns>
        public  SetSubscriptionAttributesResponse EndSetSubscriptionAttributes(IAsyncResult asyncResult)
        {
            return endOperation< SetSubscriptionAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeSetSubscriptionAttributes(SetSubscriptionAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetSubscriptionAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = SetSubscriptionAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            IAsyncResult asyncResult = invokeSetTopicAttributes(request, null, null, true);
            return EndSetTopicAttributes(asyncResult);
        }

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
        public IAsyncResult BeginSetTopicAttributes(SetTopicAttributesRequest request, AsyncCallback callback, object state)
        {
            return invokeSetTopicAttributes(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  SetTopicAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetTopicAttributes.</param>
        /// 
        /// <returns>Returns a  SetTopicAttributesResult from SimpleNotificationService.</returns>
        public  SetTopicAttributesResponse EndSetTopicAttributes(IAsyncResult asyncResult)
        {
            return endOperation< SetTopicAttributesResponse>(asyncResult);
        }

        IAsyncResult invokeSetTopicAttributes(SetTopicAttributesRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetTopicAttributesRequestMarshaller().Marshall(request);
            var unmarshaller = SetTopicAttributesResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            IAsyncResult asyncResult = invokeSubscribe(request, null, null, true);
            return EndSubscribe(asyncResult);
        }

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
        public IAsyncResult BeginSubscribe(SubscribeRequest request, AsyncCallback callback, object state)
        {
            return invokeSubscribe(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  Subscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSubscribe.</param>
        /// 
        /// <returns>Returns a  SubscribeResult from SimpleNotificationService.</returns>
        public  SubscribeResponse EndSubscribe(IAsyncResult asyncResult)
        {
            return endOperation< SubscribeResponse>(asyncResult);
        }

        IAsyncResult invokeSubscribe(SubscribeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SubscribeRequestMarshaller().Marshall(request);
            var unmarshaller = SubscribeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

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
        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            IAsyncResult asyncResult = invokeUnsubscribe(request, null, null, true);
            return EndUnsubscribe(asyncResult);
        }

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
        public IAsyncResult BeginUnsubscribe(UnsubscribeRequest request, AsyncCallback callback, object state)
        {
            return invokeUnsubscribe(request, callback, state, false);
        }



        /// <summary>
        /// Finishes the asynchronous execution of the  Unsubscribe operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnsubscribe.</param>
        /// 
        /// <returns>Returns a  UnsubscribeResult from SimpleNotificationService.</returns>
        public  UnsubscribeResponse EndUnsubscribe(IAsyncResult asyncResult)
        {
            return endOperation< UnsubscribeResponse>(asyncResult);
        }

        IAsyncResult invokeUnsubscribe(UnsubscribeRequest request, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UnsubscribeRequestMarshaller().Marshall(request);
            var unmarshaller = UnsubscribeResponseUnmarshaller.Instance;
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }

        #endregion
        
    }
}