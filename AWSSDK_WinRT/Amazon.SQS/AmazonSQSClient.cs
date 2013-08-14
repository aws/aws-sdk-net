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

using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SQS
{
    /// <summary>
    /// Implementation for accessing AmazonSQS.
    /// 
    /// 
    /// </summary>
	public partial class AmazonSQSClient : AmazonWebServiceClient, Amazon.SQS.IAmazonSQS
    {

        AWS4Signer signer = new AWS4Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSQSClient(AWSCredentials credentials)
            : this(credentials, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSQSConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials and an
        /// AmazonSQSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSQSConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.OverLimitException" />
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
        /// <param name="changeMessageVisibilityRequest">Container for the necessary parameters to execute the ChangeMessageVisibility service method on
        /// AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.ReceiptHandleIsInvalidException" />
        /// <exception cref="T:Amazon.SQS.Model.MessageNotInflightException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest changeMessageVisibilityRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ChangeMessageVisibilityRequest, ChangeMessageVisibilityResponse>(changeMessageVisibilityRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="changeMessageVisibilityBatchRequest">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch service
        /// method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.BatchEntryIdsNotDistinctException" />
        /// <exception cref="T:Amazon.SQS.Model.TooManyEntriesInBatchRequestException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidBatchEntryIdException" />
        /// <exception cref="T:Amazon.SQS.Model.EmptyBatchRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest changeMessageVisibilityBatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ChangeMessageVisibilityBatchRequest, ChangeMessageVisibilityBatchResponse>(changeMessageVisibilityBatchRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="createQueueRequest">Container for the necessary parameters to execute the CreateQueue service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.QueueNameExistsException" />
        /// <exception cref="T:Amazon.SQS.Model.QueueDeletedRecentlyException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest createQueueRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateQueueRequestMarshaller();
            var unmarshaller = CreateQueueResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, CreateQueueRequest, CreateQueueResponse>(createQueueRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteMessageRequest">Container for the necessary parameters to execute the DeleteMessage service method on AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.ReceiptHandleIsInvalidException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidIdFormatException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest deleteMessageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMessageRequestMarshaller();
            var unmarshaller = DeleteMessageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteMessageRequest, DeleteMessageResponse>(deleteMessageRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteMessageBatchRequest">Container for the necessary parameters to execute the DeleteMessageBatch service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.BatchEntryIdsNotDistinctException" />
        /// <exception cref="T:Amazon.SQS.Model.TooManyEntriesInBatchRequestException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidBatchEntryIdException" />
        /// <exception cref="T:Amazon.SQS.Model.EmptyBatchRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest deleteMessageBatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var unmarshaller = DeleteMessageBatchResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteMessageBatchRequest, DeleteMessageBatchResponse>(deleteMessageBatchRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteQueueRequest">Container for the necessary parameters to execute the DeleteQueue service method on AmazonSQS.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest deleteQueueRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteQueueRequestMarshaller();
            var unmarshaller = DeleteQueueResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, DeleteQueueRequest, DeleteQueueResponse>(deleteQueueRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="getQueueAttributesRequest">Container for the necessary parameters to execute the GetQueueAttributes service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.InvalidAttributeNameException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest getQueueAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetQueueAttributesRequestMarshaller();
            var unmarshaller = GetQueueAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetQueueAttributesRequest, GetQueueAttributesResponse>(getQueueAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="getQueueUrlRequest">Container for the necessary parameters to execute the GetQueueUrl service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.QueueDoesNotExistException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest getQueueUrlRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetQueueUrlRequestMarshaller();
            var unmarshaller = GetQueueUrlResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, GetQueueUrlRequest, GetQueueUrlResponse>(getQueueUrlRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listQueuesRequest">Container for the necessary parameters to execute the ListQueues service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by AmazonSQS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest listQueuesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListQueuesRequestMarshaller();
            var unmarshaller = ListQueuesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ListQueuesRequest, ListQueuesResponse>(listQueuesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="receiveMessageRequest">Container for the necessary parameters to execute the ReceiveMessage service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.OverLimitException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest receiveMessageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReceiveMessageRequestMarshaller();
            var unmarshaller = ReceiveMessageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, ReceiveMessageRequest, ReceiveMessageResponse>(receiveMessageRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        /// AmazonSQS.</param>
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
        /// <param name="sendMessageRequest">Container for the necessary parameters to execute the SendMessage service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.InvalidMessageContentsException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SendMessageResponse> SendMessageAsync(SendMessageRequest sendMessageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendMessageRequestMarshaller();
            var unmarshaller = SendMessageResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SendMessageRequest, SendMessageResponse>(sendMessageRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="sendMessageBatchRequest">Container for the necessary parameters to execute the SendMessageBatch service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.BatchEntryIdsNotDistinctException" />
        /// <exception cref="T:Amazon.SQS.Model.TooManyEntriesInBatchRequestException" />
        /// <exception cref="T:Amazon.SQS.Model.BatchRequestTooLongException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidBatchEntryIdException" />
        /// <exception cref="T:Amazon.SQS.Model.EmptyBatchRequestException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest sendMessageBatchRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendMessageBatchRequestMarshaller();
            var unmarshaller = SendMessageBatchResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SendMessageBatchRequest, SendMessageBatchResponse>(sendMessageBatchRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="setQueueAttributesRequest">Container for the necessary parameters to execute the SetQueueAttributes service method on
        /// AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.InvalidAttributeNameException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public async Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest setQueueAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetQueueAttributesRequestMarshaller();
            var unmarshaller = SetQueueAttributesResponseUnmarshaller.GetInstance();
            var response = await Invoke<IRequest, SetQueueAttributesRequest, SetQueueAttributesResponse>(setQueueAttributesRequest, marshaller, unmarshaller, signer, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            return response;
        }
    }
}
