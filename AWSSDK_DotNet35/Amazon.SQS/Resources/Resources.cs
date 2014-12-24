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
using System.IO;
using System.Collections.Generic;
using Amazon.SQS.Model;

namespace Amazon.SQS.Resources
{

    #region IMessage

    /// <summary>
    /// This interface represents the Message resource.
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// Gets the value of the QueueUrl identifier for this resource. 
        /// </summary>        
        string QueueUrl { get; }

        /// <summary>
        /// Gets the value of the ReceiptHandle identifier for this resource. 
        /// </summary>        
        string ReceiptHandle { get; }

        /// <summary>
        /// Gets the value of the property Attributes. 
        /// <para>
        /// <code>SenderId</code>, <code>SentTimestamp</code>, <code>ApproximateReceiveCount</code>,
        /// and/or <code>ApproximateFirstReceiveTimestamp</code>. <code>SentTimestamp</code> and
        /// <code>ApproximateFirstReceiveTimestamp</code> are each returned as an integer representing
        /// the <a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a> in milliseconds.
        /// </para>
        /// </summary>
        Dictionary<string, string> Attributes { get; }

        /// <summary>
        /// Gets the value of the property Body. 
        /// <para>
        /// The message's contents (not URL-encoded).
        /// </para>
        /// </summary>
        string Body { get; }

        /// <summary>
        /// Gets the value of the property MD5OfBody. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message body string.
        /// </para>
        /// </summary>
        string MD5OfBody { get; }

        /// <summary>
        /// Gets the value of the property MD5OfMessageAttributes. 
        /// <para>
        /// An MD5 digest of the non-URL-encoded message attribute string. This can be used to
        /// verify that Amazon SQS received the message correctly. Amazon SQS first URL decodes
        /// the message before creating the MD5 digest. For information about MD5, go to <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        /// </para>
        /// </summary>
        string MD5OfMessageAttributes { get; }

        /// <summary>
        /// Gets the value of the property MessageAttributes. 
        /// <para>
        /// Each message attribute consists of a Name, Type, and Value. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSMessageAttributes.html#SQSMessageAttributesNTV">Message
        /// Attribute Items</a>.
        /// </para>
        /// </summary>
        Dictionary<string, MessageAttributeValue> MessageAttributes { get; }

        /// <summary>
        /// Gets the value of the property MessageId. 
        /// <para>
        /// A unique identifier for the message. Message IDs are considered unique across all
        /// AWS accounts for an extended period of time.
        /// </para>
        /// </summary>
        string MessageId { get; }


        #region Actions

        /// <summary>
        /// Calls the ChangeVisibility operation on the Message resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ChangeMessageVisibility operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility operation.</param>
        void ChangeVisibility(ChangeMessageVisibilityRequest request);

        /// <summary>
        /// Calls the ChangeVisibility operation on the Message resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ChangeMessageVisibility operation on the service.
        /// </para>
        /// <param name="visibilityTimeout">The new value (in seconds - from 0 to 43200 - maximum 12 hours) for the message's visibility timeout.</param>
        void ChangeVisibility(int visibilityTimeout);

        /// <summary>
        /// Calls the Delete operation on the Message resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteMessage operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage operation.</param>
        void Delete(DeleteMessageRequest request);

        /// <summary>
        /// Calls the Delete operation on the Message resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteMessage operation on the service.
        /// </para>
        void Delete();


        #endregion

    }    
    #endregion

    #region IQueue

    /// <summary>
    /// This interface represents the Queue resource.
    /// </summary>
    public interface IQueue
    {
        /// <summary>
        /// Gets the value of the Url identifier for this resource. 
        /// </summary>        
        string Url { get; }

        /// <summary>
        /// Gets the value of the property Attributes. 
        /// <para>
        /// A map of attributes to the respective values.
        /// </para>
        /// </summary>
        Dictionary<string, string> Attributes { get; }


        #region Actions

        /// <summary>
        /// Calls the AddPermission operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddPermission operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        void AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Calls the AddPermission operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddPermission operation on the service.
        /// </para>
        /// <param name="actions">The action the client wants to allow for the specified principal. The following are valid values: <code>* | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes | GetQueueUrl</code>. For more information about these actions, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html#PermissionTypes">Understanding Permissions</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <code>SendMessage</code>, <code>DeleteMessage</code>, or <code>ChangeMessageVisibility</code> for the <code>ActionName.n</code> also grants permissions for the corresponding batch versions of those actions: <code>SendMessageBatch</code>, <code>DeleteMessageBatch</code>, and <code>ChangeMessageVisibilityBatch</code>.</param>
        /// <param name="awsAccountIds">The AWS account number of the <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a> who will be given permission. The principal must have an AWS account, but does not need to be signed up for Amazon SQS. For information about locating the AWS account identification, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AWSCredentials.html">Your AWS Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="label">The unique identification of the permission you're setting (e.g., <code>AliceSendMessage</code>). Constraints: Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        void AddPermission(List<string> actions, List<string> awsAccountIds, string label);

        /// <summary>
        /// Calls the ChangeMessageVisibilityBatch operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ChangeMessageVisibilityBatch operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch operation.</param>
        void ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request);

        /// <summary>
        /// Calls the ChangeMessageVisibilityBatch operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ChangeMessageVisibilityBatch operation on the service.
        /// </para>
        /// <param name="entries">A list of receipt handles of the messages for which the visibility timeout must be changed.</param>
        void ChangeMessageVisibilityBatch(List<ChangeMessageVisibilityBatchRequestEntry> entries);

        /// <summary>
        /// Calls the Delete operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteQueue operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation.</param>
        void Delete(DeleteQueueRequest request);

        /// <summary>
        /// Calls the Delete operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteQueue operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the DeleteMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteMessageBatch operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch operation.</param>
        void DeleteMessages(DeleteMessageBatchRequest request);

        /// <summary>
        /// Calls the DeleteMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteMessageBatch operation on the service.
        /// </para>
        /// <param name="entries">A list of receipt handles for the messages to be deleted.</param>
        void DeleteMessages(List<DeleteMessageBatchRequestEntry> entries);

        /// <summary>
        /// Calls the Purge operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PurgeQueue operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the PurgeQueue operation.</param>
        void Purge(PurgeQueueRequest request);

        /// <summary>
        /// Calls the Purge operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PurgeQueue operation on the service.
        /// </para>
        void Purge();

        /// <summary>
        /// Calls the ReceiveMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ReceiveMessage operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage operation.</param>
        /// <returns>A collection of Message resources.</returns>
        IEnumerable<IMessage> ReceiveMessages(ReceiveMessageRequest request);

        /// <summary>
        /// Calls the ReceiveMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ReceiveMessage operation on the service.
        /// </para>
        /// <returns>A collection of Message resources.</returns>
        IEnumerable<IMessage> ReceiveMessages();

        /// <summary>
        /// Calls the ReceiveMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ReceiveMessage operation on the service.
        /// </para>
        /// <returns>A collection of Message resources.</returns>
        /// <param name="maxNumberOfMessages">The maximum number of messages to return. Amazon SQS never returns more messages than this value but may return fewer. Values can be from 1 to 10. Default is 1. All of the messages are not necessarily returned.</param>
        IEnumerable<IMessage> ReceiveMessages(int maxNumberOfMessages);

        /// <summary>
        /// Calls the RemovePermission operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemovePermission operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        void RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Calls the RemovePermission operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemovePermission operation on the service.
        /// </para>
        /// <param name="label">The identification of the permission to remove. This is the label added with the <a>AddPermission</a> action.</param>
        void RemovePermission(string label);

        /// <summary>
        /// Calls the SendMessage operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SendMessage operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation.</param>
        void SendMessage(SendMessageRequest request);

        /// <summary>
        /// Calls the SendMessage operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SendMessage operation on the service.
        /// </para>
        /// <param name="messageBody">The message to send. String maximum 256 KB in size. For a list of allowed characters, see the preceding important note.</param>
        void SendMessage(string messageBody);

        /// <summary>
        /// Calls the SendMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SendMessageBatch operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch operation.</param>
        void SendMessages(SendMessageBatchRequest request);

        /// <summary>
        /// Calls the SendMessages operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SendMessageBatch operation on the service.
        /// </para>
        /// <param name="entries">A list of <a>SendMessageBatchRequestEntry</a> items.</param>
        void SendMessages(List<SendMessageBatchRequestEntry> entries);

        /// <summary>
        /// Calls the SetAttributes operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetQueueAttributes operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes operation.</param>
        void SetAttributes(SetQueueAttributesRequest request);

        /// <summary>
        /// Calls the SetAttributes operation on the Queue resource.
        /// </summary>
        /// <para>
        /// This method internally calls the SetQueueAttributes operation on the service.
        /// </para>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters the <code>SetQueueAttributes</code> action uses:  <ul> <li> <code>DelaySeconds</code> - The time in seconds that the delivery of all messages in the queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 (zero).</li> <li> <code>MaximumMessageSize</code> - The limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this attribute is 262144 (256 KiB).</li> <li> <code>MessageRetentionPeriod</code> - The number of seconds Amazon SQS retains a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</li> <li> <code>Policy</code> - The queue's policy. A valid AWS policy. For more information about policy structure, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview of AWS IAM Policies</a> in the <i>Amazon IAM User Guide</i>.</li> <li> <code>ReceiveMessageWaitTimeSeconds</code> - The time for which a ReceiveMessage call will wait for a message to arrive. An integer from 0 to 20 (seconds). The default for this attribute is 0. </li> <li> <code>VisibilityTimeout</code> - The visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see Visibility Timeout in the <i>Amazon SQS Developer Guide</i>.</li> <li> <code>RedrivePolicy</code> - The parameters for dead letter queue functionality of the source queue. For more information about RedrivePolicy and dead letter queues, see Using Amazon SQS Dead Letter Queues in the <i>Amazon SQS Developer Guide</i>.</li> </ul> </param>
        void SetAttributes(Dictionary<string, string> attributes);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the DeadLetterSourceQueues associated with this Queue.        
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues operation.</param>
        /// <returns>Returns an enumerable collection of DeadLetterSourceQueues.</returns>
        IEnumerable<IQueue> GetDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request);

        /// <summary>
        /// Gets the DeadLetterSourceQueues associated with this Queue.        
        /// </summary>
        /// <returns>Returns an enumerable collection of DeadLetterSourceQueues.</returns>
        IEnumerable<IQueue> GetDeadLetterSourceQueues();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets a Message associated with this Queue resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="receiptHandle">The receiptHandle of the Message.</param>
        /// <returns>Returns an instance of Message.</returns>
        IMessage GetMessageByReceiptHandle(string receiptHandle);


        #endregion
    }    
    #endregion
}