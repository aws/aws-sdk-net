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
using Amazon.SimpleNotificationService.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// Implementation for accessing AmazonSimpleNotificationService.
    /// 
    /// Amazon Simple Notification Service <para>Amazon Simple Notification Service (Amazon SNS) is a web service that enables you to build
    /// distributed web-enabled applications. Applications can use Amazon SNS to easily push real-time notification messages to interested
    /// subscribers over multiple delivery protocols. For more information about this product see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a> . For detailed information about Amazon SNS features and their associated API calls, see the <a href="http://docs.aws.amazon.com/sns/latest/dg/">Amazon SNS Developer Guide</a> .
    /// </para> <para>We also provide SDKs that enable you to access Amazon SNS from your preferred programming language. The SDKs contain
    /// functionality that automatically takes care of tasks such as: cryptographically signing your service requests, retrying requests, and
    /// handling error responses. For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a> .
    /// </para>
    /// </summary>
	public partial class AmazonSimpleNotificationServiceClient : AmazonWebServiceClient, Amazon.SimpleNotificationService.IAmazonSimpleNotificationService
    {

        QueryStringSigner signer = new QueryStringSigner();
        #region Constructors

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
        /// AmazonSimpleNotificationServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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
        /// AmazonSimpleNotificationServiceClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
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

 
		internal AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var task = AddPermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest addPermissionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, AddPermissionRequest, AddPermissionResponse>(addPermissionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            var task = ConfirmSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ConfirmSubscriptionResponse> ConfirmSubscriptionAsync(ConfirmSubscriptionRequest confirmSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmSubscriptionRequestMarshaller();
            var unmarshaller = ConfirmSubscriptionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ConfirmSubscriptionRequest, ConfirmSubscriptionResponse>(confirmSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            var task = CreatePlatformApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>CreatePlatformApplication</c> action creates a platform application object for one of the supported push notification services,
        /// such as APNS and GCM, to which devices and mobile apps may register. You must specify PlatformPrincipal and PlatformCredential attributes
        /// when using the <c>CreatePlatformApplication</c> action. The PlatformPrincipal is received from the notification service. For
        /// APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". For GCM, PlatformPrincipal is not applicable. For ADM, PlatformPrincipal is
        /// "client id". The PlatformCredential is also received from the notification service. For APNS/APNS_SANDBOX, PlatformCredential is "private
        /// key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret". The PlatformApplicationArn that is returned
        /// when using <c>CreatePlatformApplication</c> is then used as an attribute for the <c>CreatePlatformEndpoint</c> action. For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createPlatformApplicationRequest">Container for the necessary parameters to execute the CreatePlatformApplication service
        /// method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreatePlatformApplication service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreatePlatformApplicationResponse> CreatePlatformApplicationAsync(CreatePlatformApplicationRequest createPlatformApplicationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlatformApplicationRequestMarshaller();
            var unmarshaller = CreatePlatformApplicationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreatePlatformApplicationRequest, CreatePlatformApplicationResponse>(createPlatformApplicationRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            var task = CreatePlatformEndpointAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>CreatePlatformEndpoint</c> creates an endpoint for a device and mobile app on one of the supported push notification services,
        /// such as GCM and APNS. <c>CreatePlatformEndpoint</c> requires the PlatformApplicationArn that is returned from
        /// <c>CreatePlatformApplication</c> . The EndpointArn that is returned when using <c>CreatePlatformEndpoint</c> can then be used by the
        /// <c>Publish</c> action to send a message to a mobile app or by the <c>Subscribe</c> action for subscription to a topic. For more information,
        /// see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createPlatformEndpointRequest">Container for the necessary parameters to execute the CreatePlatformEndpoint service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the CreatePlatformEndpoint service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreatePlatformEndpointResponse> CreatePlatformEndpointAsync(CreatePlatformEndpointRequest createPlatformEndpointRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlatformEndpointRequestMarshaller();
            var unmarshaller = CreatePlatformEndpointResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreatePlatformEndpointRequest, CreatePlatformEndpointResponse>(createPlatformEndpointRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            var task = CreateTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>CreateTopic</c> action creates a topic to which notifications can be published. Users can create at most 100 topics. For more
        /// information, see <a href="http://aws.amazon.com/sns/">http://aws.amazon.com/sns</a> .
        /// This action is idempotent, so if the requester already owns a topic with the specified name, that topic's ARN is returned without
        /// creating a new topic.</para>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest createTopicRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTopicRequestMarshaller();
            var unmarshaller = CreateTopicResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateTopicRequest, CreateTopicResponse>(createTopicRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var task = DeleteEndpointAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>DeleteEndpoint</c> action, which is idempotent, deletes the endpoint from SNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteEndpointRequest">Container for the necessary parameters to execute the DeleteEndpoint service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest deleteEndpointRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteEndpointRequestMarshaller();
            var unmarshaller = DeleteEndpointResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteEndpointRequest, DeleteEndpointResponse>(deleteEndpointRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            var task = DeletePlatformApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>DeletePlatformApplication</c> action deletes a platform application object for one of the supported push notification services,
        /// such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deletePlatformApplicationRequest">Container for the necessary parameters to execute the DeletePlatformApplication service
        /// method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeletePlatformApplicationResponse> DeletePlatformApplicationAsync(DeletePlatformApplicationRequest deletePlatformApplicationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlatformApplicationRequestMarshaller();
            var unmarshaller = DeletePlatformApplicationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeletePlatformApplicationRequest, DeletePlatformApplicationResponse>(deletePlatformApplicationRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            var task = DeleteTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest deleteTopicRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTopicRequestMarshaller();
            var unmarshaller = DeleteTopicResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteTopicRequest, DeleteTopicResponse>(deleteTopicRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            var task = GetEndpointAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>GetEndpointAttributes</c> retrieves the endpoint attributes for a device on one of the supported push notification services,
        /// such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getEndpointAttributesRequest">Container for the necessary parameters to execute the GetEndpointAttributes service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetEndpointAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetEndpointAttributesResponse> GetEndpointAttributesAsync(GetEndpointAttributesRequest getEndpointAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetEndpointAttributesRequestMarshaller();
            var unmarshaller = GetEndpointAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetEndpointAttributesRequest, GetEndpointAttributesResponse>(getEndpointAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            var task = GetPlatformApplicationAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>GetPlatformApplicationAttributes</c> action retrieves the attributes of the platform application object for the supported push
        /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="getPlatformApplicationAttributesRequest">Container for the necessary parameters to execute the GetPlatformApplicationAttributes
        /// service method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the GetPlatformApplicationAttributes service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetPlatformApplicationAttributesResponse> GetPlatformApplicationAttributesAsync(GetPlatformApplicationAttributesRequest getPlatformApplicationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = GetPlatformApplicationAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetPlatformApplicationAttributesRequest, GetPlatformApplicationAttributesResponse>(getPlatformApplicationAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            var task = GetSubscriptionAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest getSubscriptionAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = GetSubscriptionAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetSubscriptionAttributesRequest, GetSubscriptionAttributesResponse>(getSubscriptionAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            var task = GetTopicAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest getTopicAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetTopicAttributesRequestMarshaller();
            var unmarshaller = GetTopicAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetTopicAttributesRequest, GetTopicAttributesResponse>(getTopicAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            var task = ListEndpointsByPlatformApplicationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>ListEndpointsByPlatformApplication</c> action lists the endpoints and endpoint attributes for devices in a supported push
        /// notification service, such as GCM and APNS. The results for <c>ListEndpointsByPlatformApplication</c> are paginated and return a limited
        /// list of endpoints, up to 100. If additional records are available after the first page results, then a NextToken string will be returned. To
        /// receive the next page, you call <c>ListEndpointsByPlatformApplication</c> again using the NextToken string received from the previous call.
        /// When there are no more records to return, NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="listEndpointsByPlatformApplicationRequest">Container for the necessary parameters to execute the
        /// ListEndpointsByPlatformApplication service method on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListEndpointsByPlatformApplication service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListEndpointsByPlatformApplicationResponse> ListEndpointsByPlatformApplicationAsync(ListEndpointsByPlatformApplicationRequest listEndpointsByPlatformApplicationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListEndpointsByPlatformApplicationRequestMarshaller();
            var unmarshaller = ListEndpointsByPlatformApplicationResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListEndpointsByPlatformApplicationRequest, ListEndpointsByPlatformApplicationResponse>(listEndpointsByPlatformApplicationRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            var task = ListPlatformApplicationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>ListPlatformApplications</c> action lists the platform application objects for the supported push notification services, such
        /// as APNS and GCM. The results for <c>ListPlatformApplications</c> are paginated and return a limited list of applications, up to 100. If
        /// additional records are available after the first page results, then a NextToken string will be returned. To receive the next page, you call
        /// <c>ListPlatformApplications</c> using the NextToken string received from the previous call. When there are no more records to return,
        /// NextToken will be null. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS
        /// Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="listPlatformApplicationsRequest">Container for the necessary parameters to execute the ListPlatformApplications service method
        /// on AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the ListPlatformApplications service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListPlatformApplicationsResponse> ListPlatformApplicationsAsync(ListPlatformApplicationsRequest listPlatformApplicationsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListPlatformApplicationsRequestMarshaller();
            var unmarshaller = ListPlatformApplicationsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListPlatformApplicationsRequest, ListPlatformApplicationsResponse>(listPlatformApplicationsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            var task = ListSubscriptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest listSubscriptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionsRequestMarshaller();
            var unmarshaller = ListSubscriptionsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListSubscriptionsRequest, ListSubscriptionsResponse>(listSubscriptionsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            var task = ListSubscriptionsByTopicAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListSubscriptionsByTopicRequestMarshaller();
            var unmarshaller = ListSubscriptionsByTopicResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListSubscriptionsByTopicRequest, ListSubscriptionsByTopicResponse>(listSubscriptionsByTopicRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            var task = ListTopicsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest listTopicsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTopicsRequestMarshaller();
            var unmarshaller = ListTopicsResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListTopicsRequest, ListTopicsResponse>(listTopicsRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal PublishResponse Publish(PublishRequest request)
        {
            var task = PublishAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.PlatformApplicationDisabledException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.EndpointDisabledException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<PublishResponse> PublishAsync(PublishRequest publishRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PublishRequestMarshaller();
            var unmarshaller = PublishResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, PublishRequest, PublishResponse>(publishRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var task = RemovePermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest removePermissionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, RemovePermissionRequest, RemovePermissionResponse>(removePermissionRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            var task = SetEndpointAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>SetEndpointAttributes</c> action sets the attributes for an endpoint for a device on one of the supported push notification
        /// services, such as GCM and APNS. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
        /// Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="setEndpointAttributesRequest">Container for the necessary parameters to execute the SetEndpointAttributes service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetEndpointAttributesResponse> SetEndpointAttributesAsync(SetEndpointAttributesRequest setEndpointAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetEndpointAttributesRequestMarshaller();
            var unmarshaller = SetEndpointAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetEndpointAttributesRequest, SetEndpointAttributesResponse>(setEndpointAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            var task = SetPlatformApplicationAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>The <c>SetPlatformApplicationAttributes</c> action sets the attributes of the platform application object for the supported push
        /// notification services, such as APNS and GCM. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="setPlatformApplicationAttributesRequest">Container for the necessary parameters to execute the SetPlatformApplicationAttributes
        /// service method on AmazonSimpleNotificationService.</param>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.AuthorizationErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InternalErrorException" />
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.InvalidParameterException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetPlatformApplicationAttributesResponse> SetPlatformApplicationAttributesAsync(SetPlatformApplicationAttributesRequest setPlatformApplicationAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetPlatformApplicationAttributesRequestMarshaller();
            var unmarshaller = SetPlatformApplicationAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetPlatformApplicationAttributesRequest, SetPlatformApplicationAttributesResponse>(setPlatformApplicationAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            var task = SetSubscriptionAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest setSubscriptionAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetSubscriptionAttributesRequestMarshaller();
            var unmarshaller = SetSubscriptionAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetSubscriptionAttributesRequest, SetSubscriptionAttributesResponse>(setSubscriptionAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            var task = SetTopicAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest setTopicAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetTopicAttributesRequestMarshaller();
            var unmarshaller = SetTopicAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetTopicAttributesRequest, SetTopicAttributesResponse>(setTopicAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal SubscribeResponse Subscribe(SubscribeRequest request)
        {
            var task = SubscribeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SubscribeResponse> SubscribeAsync(SubscribeRequest subscribeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SubscribeRequestMarshaller();
            var unmarshaller = SubscribeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SubscribeRequest, SubscribeResponse>(subscribeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
		internal UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            var task = UnsubscribeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest unsubscribeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnsubscribeRequestMarshaller();
            var unmarshaller = UnsubscribeResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, UnsubscribeRequest, UnsubscribeResponse>(unsubscribeRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
