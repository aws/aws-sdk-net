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
    /// 
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
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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

 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="publishRequest">Container for the necessary parameters to execute the Publish service method on
        /// AmazonSimpleNotificationService.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by AmazonSimpleNotificationService.</returns>
        /// 
        /// <exception cref="T:Amazon.SimpleNotificationService.Model.NotFoundException" />
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
 
        /// <summary>
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
