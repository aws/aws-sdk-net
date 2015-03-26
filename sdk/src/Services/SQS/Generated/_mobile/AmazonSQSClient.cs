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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SQS
{
    /// <summary>
    /// Implementation for accessing SQS
    ///
    /// Welcome to the <i>Amazon Simple Queue Service API Reference</i>. This section describes
    /// who should read this guide, how the guide is organized, and other resources related
    /// to the Amazon Simple Queue Service (Amazon SQS).
    /// 
    ///  
    /// <para>
    /// Amazon SQS offers reliable and scalable hosted queues for storing messages as they
    /// travel between computers. By using Amazon SQS, you can move data between distributed
    /// components of your applications that perform different tasks without losing messages
    /// or requiring each component to be always available.
    /// </para>
    ///  
    /// <para>
    /// Helpful Links: <ul> <li><a href="http://queue.amazonaws.com/doc/2012-11-05/QueueService.wsdl">Current
    /// WSDL (2012-11-05)</a></li> <li><a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/MakingRequestsArticle.html">Making
    /// API Requests</a></li> <li><a href="http://aws.amazon.com/sqs/">Amazon SQS product
    /// page</a></li> <li><a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSMessageAttributes.html">Using
    /// Amazon SQS Message Attributes</a></li> <li><a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using
    /// Amazon SQS Dead Letter Queues</a></li> <li><a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sqs_region">Regions
    /// and Endpoints</a></li> </ul> 
    /// </para>
    ///  
    /// <para>
    /// We also provide SDKs that enable you to access Amazon SQS from your preferred programming
    /// language. The SDKs contain functionality that automatically takes care of tasks such
    /// as:
    /// </para>
    ///  
    /// <para>
    ///  <ul> <li>Cryptographically signing your service requests</li> <li>Retrying requests</li>
    /// <li>Handling error responses</li> </ul> 
    /// </para>
    ///  
    /// <para>
    /// For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools for
    /// Amazon Web Services</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSQSClient : AmazonServiceClient, IAmazonSQS
    {
        
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
            : this(credentials, new AmazonSQSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials and an
        /// AmazonSQSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonSQSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSQSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.SQS.Internal.ProcessRequestHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.SQS.Internal.ValidationResponseHandler());
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddPermission

        internal AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionRequest,AddPermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AddPermissionRequest,AddPermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeMessageVisibility

        internal ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityResponseUnmarshaller.Instance;

            return Invoke<ChangeMessageVisibilityRequest,ChangeMessageVisibilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeMessageVisibilityRequest,ChangeMessageVisibilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ChangeMessageVisibilityBatch

        internal ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance;

            return Invoke<ChangeMessageVisibilityBatchRequest,ChangeMessageVisibilityBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibilityBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeMessageVisibilityBatchRequest,ChangeMessageVisibilityBatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateQueue

        internal CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var marshaller = new CreateQueueRequestMarshaller();
            var unmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueRequest,CreateQueueResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateQueueRequestMarshaller();
            var unmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQueueRequest,CreateQueueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMessage

        internal DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            var marshaller = new DeleteMessageRequestMarshaller();
            var unmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageRequest,DeleteMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMessageRequestMarshaller();
            var unmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageRequest,DeleteMessageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMessageBatch

        internal DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request)
        {
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var unmarshaller = DeleteMessageBatchResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageBatchRequest,DeleteMessageBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var unmarshaller = DeleteMessageBatchResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageBatchRequest,DeleteMessageBatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueue

        internal DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            var marshaller = new DeleteQueueRequestMarshaller();
            var unmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueRequest,DeleteQueueResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteQueueRequestMarshaller();
            var unmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQueueRequest,DeleteQueueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetQueueAttributes

        internal GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            var marshaller = new GetQueueAttributesRequestMarshaller();
            var unmarshaller = GetQueueAttributesResponseUnmarshaller.Instance;

            return Invoke<GetQueueAttributesRequest,GetQueueAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetQueueAttributesRequestMarshaller();
            var unmarshaller = GetQueueAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueueAttributesRequest,GetQueueAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetQueueUrl

        internal GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request)
        {
            var marshaller = new GetQueueUrlRequestMarshaller();
            var unmarshaller = GetQueueUrlResponseUnmarshaller.Instance;

            return Invoke<GetQueueUrlRequest,GetQueueUrlResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetQueueUrlRequestMarshaller();
            var unmarshaller = GetQueueUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueueUrlRequest,GetQueueUrlResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeadLetterSourceQueues

        internal ListDeadLetterSourceQueuesResponse ListDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request)
        {
            var marshaller = new ListDeadLetterSourceQueuesRequestMarshaller();
            var unmarshaller = ListDeadLetterSourceQueuesResponseUnmarshaller.Instance;

            return Invoke<ListDeadLetterSourceQueuesRequest,ListDeadLetterSourceQueuesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeadLetterSourceQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListDeadLetterSourceQueuesResponse> ListDeadLetterSourceQueuesAsync(ListDeadLetterSourceQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeadLetterSourceQueuesRequestMarshaller();
            var unmarshaller = ListDeadLetterSourceQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeadLetterSourceQueuesRequest,ListDeadLetterSourceQueuesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListQueues

        internal ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var marshaller = new ListQueuesRequestMarshaller();
            var unmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesRequest,ListQueuesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListQueuesRequestMarshaller();
            var unmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueuesRequest,ListQueuesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurgeQueue

        internal PurgeQueueResponse PurgeQueue(PurgeQueueRequest request)
        {
            var marshaller = new PurgeQueueRequestMarshaller();
            var unmarshaller = PurgeQueueResponseUnmarshaller.Instance;

            return Invoke<PurgeQueueRequest,PurgeQueueResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurgeQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurgeQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurgeQueueResponse> PurgeQueueAsync(PurgeQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurgeQueueRequestMarshaller();
            var unmarshaller = PurgeQueueResponseUnmarshaller.Instance;

            return InvokeAsync<PurgeQueueRequest,PurgeQueueResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReceiveMessage

        internal ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            var marshaller = new ReceiveMessageRequestMarshaller();
            var unmarshaller = ReceiveMessageResponseUnmarshaller.Instance;

            return Invoke<ReceiveMessageRequest,ReceiveMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReceiveMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReceiveMessageRequestMarshaller();
            var unmarshaller = ReceiveMessageResponseUnmarshaller.Instance;

            return InvokeAsync<ReceiveMessageRequest,ReceiveMessageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemovePermission

        internal RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePermissionRequest,RemovePermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendMessage

        internal SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var marshaller = new SendMessageRequestMarshaller();
            var unmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageRequest,SendMessageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendMessageRequestMarshaller();
            var unmarshaller = SendMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageRequest,SendMessageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SendMessageBatch

        internal SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request)
        {
            var marshaller = new SendMessageBatchRequestMarshaller();
            var unmarshaller = SendMessageBatchResponseUnmarshaller.Instance;

            return Invoke<SendMessageBatchRequest,SendMessageBatchResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessageBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendMessageBatchRequestMarshaller();
            var unmarshaller = SendMessageBatchResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageBatchRequest,SendMessageBatchResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetQueueAttributes

        internal SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            var marshaller = new SetQueueAttributesRequestMarshaller();
            var unmarshaller = SetQueueAttributesResponseUnmarshaller.Instance;

            return Invoke<SetQueueAttributesRequest,SetQueueAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetQueueAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetQueueAttributesRequestMarshaller();
            var unmarshaller = SetQueueAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetQueueAttributesRequest,SetQueueAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}