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

namespace Amazon.SQS
{
    /// <summary>
    /// Interface for accessing AmazonSQS.
    /// 
    /// 
    /// </summary>
	public partial interface IAmazonSQS : IDisposable
    {
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.OverLimitException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest addPermissionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest changeMessageVisibilityRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest changeMessageVisibilityBatchRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest createQueueRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest deleteMessageRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest deleteMessageBatchRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteQueueRequest">Container for the necessary parameters to execute the DeleteQueue service method on AmazonSQS.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest deleteQueueRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest getQueueAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest getQueueUrlRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="listQueuesRequest">Container for the necessary parameters to execute the ListQueues service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by AmazonSQS.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest listQueuesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest receiveMessageRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        /// AmazonSQS.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest removePermissionRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<SendMessageResponse> SendMessageAsync(SendMessageRequest sendMessageRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest sendMessageBatchRequest, CancellationToken cancellationToken = default(CancellationToken));
 
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
		Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest setQueueAttributesRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
