/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2012-11-05
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
        /// Creates a new queue, or returns the URL of an existing one.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When you request CreateQueue, you provide a name for the queue. To successfully
        /// create a new queue, you must provide a name that is unique within the scope of
        /// your own queues. If you provide the name of an existing queue, a new queue isn't
        /// created and an error isn't returned. Instead, the request succeeds and the queue
        /// URL for the existing queue is returned.
        /// </para>
        /// <para>
        /// Exception: if you provide a value for DefaultVisibilityTimeout that is different
        /// from the value for the existing queue, you receive an error.
        /// </para>
        /// </remarks>
        /// <param name="request">Create Queue  request</param>
        /// <returns>Create Queue  Response from the service</returns>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);

        /// <summary>
        /// Returns a list of your queues. The maximum number of queues that can be returned is 1000.
        /// </summary>
        /// <remarks>
        /// If you specify a value for the optional QueueNamePrefix parameter, only queues with a name beginning with the
        /// specified value are returned.
        /// </remarks>
        /// <param name="request">List Queues  request</param>
        /// <returns>List Queues  Response from the service</returns>
        ListQueuesResponse ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Adds the specified permission(s) to a queue for the specified principal(s).
        /// </summary>
        /// <remarks>
        /// This allows for sharing access to the queue.
        /// </remarks>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Extends the read lock timeout of a single message in a queue.
        /// </summary>
        /// <param name="request">Change Message Visibility  request</param>
        /// <returns>Change Message Visibility  Response from the service</returns>
        ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request);

        /// <summary>
        /// Extends the read lock timeout of multiple messages in a queue.
        /// </summary>
        /// <remarks>
        /// This operation takes multiple receipt handles and extends the lock timeout for each of the them.
        /// The result of the operation on each message is reported individually in the response.
        /// </remarks>
        /// <param name="request">Change Message Visibility Batch request</param>
        /// <returns>Change Message Visibility Response from the service</returns>
        ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request);


        /// <summary>
        /// Unconditionally removes the specified message from the specified queue.
        /// </summary>
        /// <remarks>
        /// Even if the message is locked by another reader due to the visibility timeout setting, it is still deleted from the queue.
        /// </remarks>
        /// <param name="request">Delete Message  request</param>
        /// <returns>Delete Message  Response from the service</returns>
        DeleteMessageResponse DeleteMessage(DeleteMessageRequest request);

        /// <summary>
        /// Removes multiple messages from the specified queue.
        /// </summary>
        /// <remarks>
        /// This operation takes multiple receipt handles and deletes each one of the messages.
        /// The result of the delete operation on each message is reported individually in the response.
        /// </remarks>
        /// <param name="request">DeleteMessageBatch request</param>
        /// <returns>DeleteMessageBatch Response from the service</returns>
        DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request);

        /// <summary>
        /// <para>
        /// Deletes the queue specified by the queue URL, regardless of whether the queue is empty.
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the specified queue does not exist, SQS returns a successful response. Use DeleteQueue with care; once you
        /// delete your queue, any messages in the queue are no longer available.
        /// </para>
        /// <para>
        /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you send involving that queue
        /// during the 60 seconds might succeed. For example, a SendMessage request might succeed, but after the 60 seconds,
        /// the queue and that message you sent no longer exist. Also, when you delete a queue, you must wait at least 60 seconds
        /// before creating a queue with the same name.
        /// </para>
        /// <para>
        /// We reserve the right to delete queues that have had no activity for more than 30 days.
        /// </para>
        /// </remarks>
        /// <param name="request">Delete Queue  request</param>
        /// <returns>Delete Queue  Response from the service</returns>
        DeleteQueueResponse DeleteQueue(DeleteQueueRequest request);

        /// <summary>
        /// Gets one or all attributes of a queue.
        /// </summary>
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
        /// <param name="request">Get Queue Attributes  request</param>
        /// <returns>Get Queue Attributes  Response from the service</returns>
        GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request);


        /// <summary>
        /// Returns the URL of an existing queue.
        /// </summary>
        /// <param name="request">GetQueueUrl  request</param>
        /// <returns>GetQueueUrl Response from the service</returns>
        GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request);

        /// <summary>
        /// Removes the permission with the specified statement id from the queue.
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// <para>
        /// Retrieves one or more messages from the specified queue, including the message
        /// body and message ID of each message. Messages returned by this action stay in
        /// the queue until you delete them. However, once a message is returned to a
        /// ReceiveMessage request, it is not returned on subsequent ReceiveMessage requests
        /// for the duration of the VisibilityTimeout. If you do not specify a
        /// VisibilityTimeout in the request, the overall visibility timeout for the queue
        /// is used for the returned messages.
        /// </para>
        /// <para>
        /// If a message is available in the queue, the call will return immediately. Otherwise,
        /// it will wait up to WaitTimeSeconds for a message to arrive. If you do not specify
        /// WaitTimeSeconds in the request, the queue attribute by the same name is used to
        /// determine how long to wait.
        /// </para>
        /// <para>
        /// You could ask for additional information about each message through the attributes.
        /// Attributes that can be requested are [SenderId, ApproximateFirstReceiveTimestamp,
        /// ApproximateReceiveCount, SentTimestamp].
        /// </para>
        /// </summary>
        /// <remarks>
        /// Messages returned by this action stay in the queue until you delete them. However, once a message is returned to a
        /// ReceiveMessage request, it is not returned on subsequent ReceiveMessage requests for the duration of the
        /// VisibilityTimeout. If you do not specify a VisibilityTimeout in the request, the overall visibility timeout for the
        /// queue is used for the returned messages.
        /// </remarks>
        /// <param name="request">Receive Message  request</param>
        /// <returns>Receive Message  Response from the service</returns>
        ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request);

        /// <summary>
        /// Delivers a message to the specified queue.
        /// </summary>
        /// <param name="request">Send Message  request</param>
        /// <returns>Send Message  Response from the service</returns>
        SendMessageResponse SendMessage(SendMessageRequest request);

        /// <summary>
        /// Sends multiple messages to a queue.
        /// </summary>
        /// <remarks>
        /// This operation takes multiple messages and adds each of them to the queue.
        /// The result of each add operation is reported individually in the response.
        /// </remarks>
        /// <param name="request">SendMessageBatch  request</param>
        /// <returns>SendMessageBatch Response from the service</returns>
        SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request);

        /// <summary>
        /// <para>
        /// Sets the value of one or more queue attributes. Currently, you can set only one attribute per request. Valid attributes that
        /// can be set are [VisibilityTimeout, Policy, MaximumMessageSize,
        /// MessageRetentionPeriod, WaitTimeSeconds].
        /// </para>
        /// </summary>
        /// <param name="request">Set Queue Attributes  request</param>
        /// <returns>Set Queue Attributes  Response from the service</returns>
        SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request);

    }
}
