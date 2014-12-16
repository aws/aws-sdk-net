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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.SQS.Model;

namespace Amazon.SQS
{
    /// <summary>
    /// Interface for accessing SQS
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
    public partial interface IAmazonSQS : IDisposable
    {
                
        #region  AddPermission

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeMessageVisibility

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibility operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeMessageVisibilityBatch

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibilityBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQueue

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMessage

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMessageBatch

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueue

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueueAttributes

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueueUrl

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeadLetterSourceQueues

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeadLetterSourceQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListDeadLetterSourceQueuesResponse> ListDeadLetterSourceQueuesAsync(ListDeadLetterSourceQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueues

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurgeQueue

        /// <summary>
        /// Initiates the asynchronous execution of the PurgeQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurgeQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PurgeQueueResponse> PurgeQueueAsync(PurgeQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReceiveMessage

        /// <summary>
        /// Initiates the asynchronous execution of the ReceiveMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemovePermission

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendMessage

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendMessageBatch

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessageBatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetQueueAttributes

        /// <summary>
        /// Initiates the asynchronous execution of the SetQueueAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}