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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

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
	public partial class AmazonSimpleNotificationServiceClient : AmazonWebServiceClient, Amazon.SimpleNotificationService.IAmazonSimpleNotificationService
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// <param name="config">The AmazonSimpleNotificationService Configuration Object</param>
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
            : this(credentials, new AmazonSimpleNotificationServiceConfig(){RegionEndpoint=region})
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSimpleNotificationServiceConfig(){RegionEndpoint = region})
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

 
        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified
        /// AWS accounts to the specified actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var task = AddPermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AddPermissionRequest, AddPermissionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
		public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            var task = ConfirmSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmSubscriptionRequestMarshaller();
            var unmarshaller = ConfirmSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ConfirmSubscriptionRequest, ConfirmSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates a platform application object for one of the supported push notification services,
        /// such as APNS and GCM, to which devices and mobile apps may register. You must
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            var task = CreatePlatformApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreatePlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreatePlatformApplicationResponse> CreatePlatformApplicationAsync(CreatePlatformApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlatformApplicationRequestMarshaller();
            var unmarshaller = CreatePlatformApplicationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreatePlatformApplicationRequest, CreatePlatformApplicationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates an endpoint for a device and mobile app on one of the supported push notification
        /// services, such as GCM and APNS.       <code>CreatePlatformEndpoint</code> requires
        /// the PlatformApplicationArn that is returned from <code>CreatePlatformApplication</code>.
        /// The EndpointArn that is      returned when using <code>CreatePlatformEndpoint</code>
        /// can then be used by the <code>Publish</code> action to send a message to a mobile
        /// app or by the <code>Subscribe</code>       action for subscription to a topic. The
        /// <code>CreatePlatformEndpoint</code> action is idempotent, so if the requester already
        /// owns an endpoint with the same device token and attributes,       that endpoint's
        /// ARN is returned without creating a new endpoint.       For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS
        /// Mobile Push Notifications</a>.
        /// 
        /// 
        /// <para>
        /// When using <code>CreatePlatformEndpoint</code> with Baidu, two attributes must be
        /// provided: ChannelId and UserId. The token field must also contain the ChannelId.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePushBaiduEndpoint.html">Creating
        /// an Amazon SNS Endpoint for Baidu</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            var task = CreatePlatformEndpointAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.CreatePlatformEndpoint"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreatePlatformEndpointResponse> CreatePlatformEndpointAsync(CreatePlatformEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlatformEndpointRequestMarshaller();
            var unmarshaller = CreatePlatformEndpointResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreatePlatformEndpointRequest, CreatePlatformEndpointResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create     at most
        /// 3000 topics. For more information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a>.
        /// This action is idempotent, so if the requester already owns a topic with the
        /// specified name, that topic's ARN is      returned without creating a new topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopic service method.</param>
        /// 
        /// <returns>The response from the CreateTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.TopicLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of topics.
        /// </exception>
		public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            var task = CreateTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTopicRequestMarshaller();
            var unmarshaller = CreateTopicResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateTopicRequest, CreateTopicResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes the endpoint from Amazon SNS. This action is idempotent.       For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var task = DeleteEndpointAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeleteEndpoint"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEndpointRequestMarshaller();
            var unmarshaller = DeleteEndpointResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteEndpointRequest, DeleteEndpointResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services,
        /// such as APNS and GCM.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication service method.</param>
        /// 
        /// <returns>The response from the DeletePlatformApplication service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            var task = DeletePlatformApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.DeletePlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeletePlatformApplicationResponse> DeletePlatformApplicationAsync(DeletePlatformApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlatformApplicationRequestMarshaller();
            var unmarshaller = DeletePlatformApplicationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeletePlatformApplicationRequest, DeletePlatformApplicationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Deletes a topic and all its subscriptions. Deleting a topic might      prevent some
        /// messages previously sent to the topic from being delivered to      subscribers. This
        /// action is idempotent, so deleting a topic that does not      exist does not result
        /// in an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopic service method.</param>
        /// 
        /// <returns>The response from the DeleteTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            var task = DeleteTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTopicRequestMarshaller();
            var unmarshaller = DeleteTopicResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteTopicRequest, DeleteTopicResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification
        /// services, such as GCM and APNS.       For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            var task = GetEndpointAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetEndpointAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetEndpointAttributesResponse> GetEndpointAttributesAsync(GetEndpointAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetEndpointAttributesRequestMarshaller();
            var unmarshaller = GetEndpointAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetEndpointAttributesRequest, GetEndpointAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push
        /// notification services,       such as APNS and GCM.      For more information, see
        /// <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon
        /// SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            var task = GetPlatformApplicationAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.GetPlatformApplicationAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlatformApplicationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetPlatformApplicationAttributesResponse> GetPlatformApplicationAttributesAsync(GetPlatformApplicationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetPlatformApplicationAttributesRequest, GetPlatformApplicationAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns all of the properties of a subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the GetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            var task = GetSubscriptionAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = GetSubscriptionAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetSubscriptionAttributesRequest, GetSubscriptionAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns all of the properties of a topic.     Topic properties returned might differ
        /// based on the authorization of the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the GetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            var task = GetTopicAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTopicAttributesRequestMarshaller();
            var unmarshaller = GetTopicAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetTopicAttributesRequest, GetTopicAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            var task = ListEndpointsByPlatformApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointsByPlatformApplication operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListEndpointsByPlatformApplication"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointsByPlatformApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListEndpointsByPlatformApplicationResponse> ListEndpointsByPlatformApplicationAsync(ListEndpointsByPlatformApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEndpointsByPlatformApplicationRequestMarshaller();
            var unmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListEndpointsByPlatformApplicationRequest, ListEndpointsByPlatformApplicationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        /// such as APNS and GCM. The results for <code>ListPlatformApplications</code>
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public ListPlatformApplicationsResponse ListPlatformApplications()
        {
            return this.ListPlatformApplications(new ListPlatformApplicationsRequest());
        }
 
        /// <summary>
        /// Lists the platform application objects for the supported push notification services,
        /// such as APNS and GCM. The results for <code>ListPlatformApplications</code>
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            var task = ListPlatformApplicationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformApplications operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.ListPlatformApplications"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(ListPlatformApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPlatformApplicationsRequestMarshaller();
            var unmarshaller = ListPlatformApplicationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListPlatformApplicationsRequest, ListPlatformApplicationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public ListSubscriptionsResponse ListSubscriptions()
        {
            return this.ListSubscriptions(new ListSubscriptionsRequest());
        }
 
        /// <summary>
        /// Returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code> parameter in a       new <code>ListSubscriptions</code>
        /// call to get further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var task = ListSubscriptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionsRequestMarshaller();
            var unmarshaller = ListSubscriptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListSubscriptionsRequest, ListSubscriptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of the subscriptions to a specific topic. Each call returns       a
        /// limited list of subscriptions, up to 100. If there are more subscriptions, a <code>NextToken</code>
        /// is also returned. Use the <code>NextToken</code>       parameter in a new <code>ListSubscriptionsByTopic</code>
        /// call to get further results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptionsByTopic service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptionsByTopic service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            var task = ListSubscriptionsByTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionsByTopicRequestMarshaller();
            var unmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListSubscriptionsByTopicRequest, ListSubscriptionsByTopicResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Returns a list of the requester's topics. Each call returns a limited list of topics,
        /// up to 100. If      there are more topics, a <code>NextToken</code> is also returned.
        /// Use the <code>NextToken</code> parameter in a new <code>ListTopics</code> call to
        /// get      further results.
        /// </summary>
        /// 
        /// <returns>The response from the ListTopics service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public ListTopicsResponse ListTopics()
        {
            return this.ListTopics(new ListTopicsRequest());
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
		public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            var task = ListTopicsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTopicsRequestMarshaller();
            var unmarshaller = ListTopicsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListTopicsRequest, ListTopicsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints. When a    <code>messageId</code>
        /// is returned, the message has been saved and Amazon SNS will attempt to deliver it
        /// to the topic's subscribers shortly. The format of the outgoing message to each
        /// subscribed endpoint depends on the notification protocol selected.
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.EndpointDisabledException">
        /// Exception error indicating endpoint disabled.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterValueException">
        /// 
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException">
        /// Exception error indicating platform application disabled.
        /// </exception>
		public PublishResponse Publish(PublishRequest request)
        {
            var task = PublishAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<PublishResponse> PublishAsync(PublishRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PublishRequestMarshaller();
            var unmarshaller = PublishResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PublishRequest, PublishResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var task = RemovePermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RemovePermissionRequest, RemovePermissionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM and APNS.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes service method.</param>
        /// 
        /// <returns>The response from the SetEndpointAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            var task = SetEndpointAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetEndpointAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetEndpointAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetEndpointAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetEndpointAttributesResponse> SetEndpointAttributesAsync(SetEndpointAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetEndpointAttributesRequestMarshaller();
            var unmarshaller = SetEndpointAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetEndpointAttributesRequest, SetEndpointAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification
        /// services,       such as APNS and GCM.      For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes service method.</param>
        /// 
        /// <returns>The response from the SetPlatformApplicationAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            var task = SetPlatformApplicationAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetPlatformApplicationAttributes operation.
        /// <seealso cref="Amazon.SimpleNotificationService.IAmazonSimpleNotificationService.SetPlatformApplicationAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetPlatformApplicationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetPlatformApplicationAttributesResponse> SetPlatformApplicationAttributesAsync(SetPlatformApplicationAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetPlatformApplicationAttributesRequest, SetPlatformApplicationAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Allows a subscription owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubscriptionAttributes service method.</param>
        /// 
        /// <returns>The response from the SetSubscriptionAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            var task = SetSubscriptionAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = SetSubscriptionAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetSubscriptionAttributesRequest, SetSubscriptionAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Allows a topic owner to set an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTopicAttributes service method.</param>
        /// 
        /// <returns>The response from the SetTopicAttributes service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            var task = SetTopicAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTopicAttributesRequestMarshaller();
            var unmarshaller = SetTopicAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetTopicAttributesRequest, SetTopicAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// To actually create a      subscription, the endpoint owner must call the <code>ConfirmSubscription</code>
        /// action with the token from the confirmation message. Confirmation tokens are
        /// valid for three days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Subscribe service method.</param>
        /// 
        /// <returns>The response from the Subscribe service method, as returned by SimpleNotificationService.</returns>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.SubscriptionLimitExceededException">
        /// Indicates that the customer already owns the maximum allowed number of subscriptions.
        /// </exception>
		public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            var task = SubscribeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SubscribeRequestMarshaller();
            var unmarshaller = SubscribeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SubscribeRequest, SubscribeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
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
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException">
        /// Indicates that the user has been denied access to the requested resource.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException">
        /// Indicates an internal service error.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException">
        /// Indicates that a request parameter does not comply with the associated constraints.
        /// </exception>
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException">
        /// Indicates that the requested resource does not exist.
        /// </exception>
		public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            var task = UnsubscribeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
          
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
		public Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnsubscribeRequestMarshaller();
            var unmarshaller = UnsubscribeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UnsubscribeRequest, UnsubscribeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
