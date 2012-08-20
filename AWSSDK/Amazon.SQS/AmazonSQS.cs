/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-10-01
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.SQS.Model;

namespace Amazon.SQS
{
    /// <summary>
    /// Amazon Simple Queue Service (Amazon SQS) offers a reliable, highly scalable hosted queue for storing
    /// messages as they travel between computers. By using Amazon SQS, developers can simply move data between
    /// distributed application components performing different tasks, without losing messages or requiring each
    /// component to be always available.  Amazon SQS works by exposing Amazon's web-scale messaging infrastructure
    /// as a web service. Any computer on the Internet can add or read messages without any installed software or
    /// special firewall configurations. Components of applications using Amazon SQS can run independently, and do
    /// not need to be on the same network, developed with the same technologies, or running at the same time.
    /// </summary>
    public interface AmazonSQS : IDisposable
    {
        /// <summary>
        /// Create Queue 
        /// </summary>
        /// <param name="request">Create Queue  request</param>
        /// <returns>Create Queue  Response from the service</returns>
        /// <remarks>
        /// The CreateQueue action creates a new queue, or returns the URL of an existing one.
        /// When you request CreateQueue, you provide a name for the queue. To successfully create
        /// a new queue, you must provide a name that is unique within the scope of your own queues.
        /// If you provide the name of an existing queue, a new queue isn't created and an error
        /// isn't returned. Instead, the request succeeds and the queue URL for the existing queue is
        /// returned. Exception: if you provide a value for DefaultVisibilityTimeout that is different
        /// from the value for the existing queue, you receive an error.
        /// </remarks>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);

        /// <summary>
        /// List Queues 
        /// </summary>
        /// <param name="request">List Queues  request</param>
        /// <returns>List Queues  Response from the service</returns>
        /// <remarks>
        /// The ListQueues action returns a list of your queues.
        /// </remarks>
        ListQueuesResponse ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Add Permission 
        /// </summary>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        /// <remarks>
        /// Adds the specified permission(s) to a queue for the specified principal(s). This allows for sharing access to the queue.
        /// </remarks>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Change Message Visibility 
        /// </summary>
        /// <param name="request">Change Message Visibility  request</param>
        /// <returns>Change Message Visibility  Response from the service</returns>
        /// <remarks>
        /// The ChangeMessageVisibility action extends the read lock timeout of the specified message from the specified queue to the specified value.
        /// </remarks>
        ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request);

        /// <summary>
        /// This is a batch version of ChangeMessageVisibility. It takes
        /// multiple receipt handles and performs the operation on each of the them. The
        /// result of the operation on each message is reported individually in the
        /// response.
        /// </summary>
        /// <param name="request">Change Message Visibility Batch request</param>
        /// <returns>Change Message Visibility Response from the service</returns>
        /// <remarks>
        /// The ChangeMessageVisibilityBatch action extends the read lock timeout of the specified message from the specified queue to the specified value.
        /// </remarks>
        ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request);


        /// <summary>
        /// Delete Message 
        /// </summary>
        /// <param name="request">Delete Message  request</param>
        /// <returns>Delete Message  Response from the service</returns>
        /// <remarks>
        /// The DeleteMessage action unconditionally removes the specified message from the specified queue. Even if the message is locked by another reader due to the visibility timeout setting, it is still deleted from the queue.
        /// </remarks>
        DeleteMessageResponse DeleteMessage(DeleteMessageRequest request);

        /// <summary>
        /// This is a batch version of <c>DeleteMessage</c>. It takes multiple
        /// receipt handles and deletes each one of the messages. The result of the delete
        /// operation on each message is reported individually in the response.
        /// </summary>
        /// <param name="request">DeleteMessageBatch request</param>
        /// <returns>DeleteMessageBatch Response from the service</returns>
        DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request);

        /// <summary>
        /// Delete Queue 
        /// </summary>
        /// <param name="request">Delete Queue  request</param>
        /// <returns>Delete Queue  Response from the service</returns>
        /// <remarks>
        /// This action unconditionally deletes the queue specified by the queue URL. Use this operation WITH CARE!  The queue is deleted even if it is NOT empty.
        /// </remarks>
        DeleteQueueResponse DeleteQueue(DeleteQueueRequest request);

        /// <summary>
        /// Get Queue Attributes 
        /// </summary>
        /// <param name="request">Get Queue Attributes  request</param>
        /// <returns>Get Queue Attributes  Response from the service</returns>
        /// <remarks>
        /// Gets one or all attributes of a queue. The following table lists the valid values for attributes to be returned.
        /// <list type="definition">
        ///     <item>
        ///         <term>All</term>
        ///         <description>All values.</description>
        ///     </item>
        ///     <item>
        ///         <term>ApproximateNumberOfMessages</term>
        ///         <description>The approximate number of visible messages in a queue.</description>
        ///     </item>
        ///     <item>
        ///         <term>ApproximateNumberOfMessagesNotVisible</term>
        ///         <description>The approximate number of messages that are not timed-out and not deleted.</description>
        ///     </item>
        ///     <item>
        ///         <term>VisibilityTimeout</term>
        ///         <description>The visibility timeout for the queue.</description>
        ///     </item>
        ///     <item>
        ///         <term>CreatedTimestamp</term>
        ///         <description>The time when the queue was created (epoch time in seconds).</description>
        ///     </item>
        ///     <item>
        ///         <term>LastModifiedTimestamp</term>
        ///         <description>The time when the queue was last changed (epoch time in seconds).</description>
        ///     </item>
        ///     <item>
        ///         <term>Policy</term>
        ///         <description>The queue's policy.</description>
        ///     </item>
        ///     <item>
        ///         <term>MaximumMessageSize</term>
        ///         <description>The limit of how many bytes a message can contain before Amazon SQS rejects it.</description>
        ///     </item>
        ///     <item>
        ///         <term>MessageRetentionPeriod</term>
        ///         <description>The number of seconds Amazon SQS retains a message.</description>
        ///     </item>
        ///     <item>
        ///         <term>QueueArn</term>
        ///         <description>The queue's Amazon resource name (ARN).</description>
        ///     </item>
        ///     <item>
        ///         <term>DelaySeconds</term>
        ///         <description>The default delay for messages to be delivered.</description>
        ///     </item>
        ///     <item>
        ///         <term>ApproximateNumberOfMessagesDelayed</term>
        ///         <description>The approximate number of messages that are delayed from delivery.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request);


        /// <summary>
        /// The <c>GetQueueUrl</c> action returns the URL of an existing queue.
        /// </summary>
        /// <param name="request">GetQueueUrl  request</param>
        /// <returns>GetQueueUrl Response from the service</returns>
        GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request);

        /// <summary>
        /// Remove Permission 
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        /// <remarks>
        /// Removes the permission with the specified statement id from the queue.
        /// </remarks>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Receive Message 
        /// </summary>
        /// <param name="request">Receive Message  request</param>
        /// <returns>Receive Message  Response from the service</returns>
        /// <remarks>
        /// Retrieves one or more messages from the specified queue.  For each message returned, the response includes
        /// the message body; MD5 digest of the message body; receipt handle, which is the identifier you must provide
        /// when deleting the message; and message ID of each message. Messages returned by this action stay in the queue
        /// until you delete them. However, once a message is returned to a ReceiveMessage request, it is not returned
        /// on subsequent ReceiveMessage requests for the duration of the VisibilityTimeout. If you do not specify a
        /// VisibilityTimeout in the request, the overall visibility timeout for the queue is used for the returned messages.
        /// </remarks>
        ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request);

        /// <summary>
        /// Send Message 
        /// </summary>
        /// <param name="request">Send Message  request</param>
        /// <returns>Send Message  Response from the service</returns>
        /// <remarks>
        /// The SendMessage action delivers a message to the specified queue.
        /// </remarks>
        SendMessageResponse SendMessage(SendMessageRequest request);

        /// <summary>
        /// This is a batch version of <c>SendMessage</c>. It takes
        /// multiple messages and adds each of them to the queue. The result of each 
        /// add operation is reported individually in the response.
        /// </summary>
        /// <param name="request">SendMessageBatch  request</param>
        /// <returns>SendMessageBatch Response from the service</returns>
        SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request);

        /// <summary>
        /// Set Queue Attributes 
        /// </summary>
        /// <param name="request">Set Queue Attributes  request</param>
        /// <returns>Set Queue Attributes  Response from the service</returns>
        /// <remarks>
        /// Sets an attribute of a queue. Currently, you can set only the VisibilityTimeout attribute for a queue.
        /// </remarks>
        SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request);

    }
}
