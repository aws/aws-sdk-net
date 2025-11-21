/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.SQS.Model;

#pragma warning disable CS1570
namespace Amazon.SQS
{
    /// <summary>
    /// <para>Interface for accessing SQS</para>
    ///
    /// Welcome to the <i>Amazon SQS API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Amazon SQS is a reliable, highly-scalable hosted queue for storing messages as they
    /// travel between applications or microservices. Amazon SQS moves data between distributed
    /// application components and helps you decouple these components.
    /// </para>
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-authentication-and-access-control.html">Identity
    /// and access management</a> in the <i>Amazon SQS Developer Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can use <a href="http://aws.amazon.com/tools/#sdk">Amazon Web Services SDKs</a>
    /// to access Amazon SQS using your favorite programming language. The SDKs perform tasks
    /// such as the following automatically:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Cryptographically sign your service requests
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retry requests
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Handle error responses
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Additional information</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/sqs/">Amazon SQS Product Page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Amazon SQS Developer Guide</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-making-api-requests.html">Making
    /// API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes">Amazon
    /// SQS Message Attributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Amazon
    /// SQS Dead-Letter Queues</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a href="https://awscli.amazonaws.com/v2/documentation/api/latest/reference/sqs/index.html">Amazon
    /// SQS in the Command Line Interface</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Amazon Web Services General Reference</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#sqs_region">Regions
    /// and Endpoints</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial interface IAmazonSQS : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISQSPaginatorFactory Paginators { get; }
#endif
                
        #region  AddPermission


        /// <summary>
        /// Adds a permission to a queue for a specific <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
        /// This allows sharing access to the queue.
        /// 
        ///  
        /// <para>
        /// When you create a queue, you have full control access rights for the queue. Only you,
        /// the owner of the queue, can grant or deny permissions to the queue. For more information
        /// about these permissions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <c>AddPermission</c> generates a policy for you. You can use <c> <a>SetQueueAttributes</a>
        /// </c> to upload your policy. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-creating-custom-policies.html">Using
        /// Custom Policies with the Amazon SQS Access Policy Language</a> in the <i>Amazon SQS
        /// Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon SQS policy can have a maximum of seven actions per statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
        /// in your IAM policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS <c>AddPermission</c> does not support adding a non-account principal.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which permissions are added. Queue URLs and names are case-sensitive.</param>
        /// <param name="label">The unique identification of the permission you're setting (for example, <c>AliceSendMessage</c>). Maximum 80 characters. Allowed characters include alphanumeric characters, hyphens (<c>-</c>), and underscores (<c>_</c>).</param>
        /// <param name="awsAccountIds">The Amazon Web Services account numbers of the <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principals</a> who are to receive permission. For information about locating the Amazon Web Services account identification, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-making-api-requests.html#sqs-api-request-authentication">Your Amazon Web Services Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="actions">The action the client wants to allow for the specified principal. Valid values: the name of any action or <c>*</c>. For more information about these actions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-overview-of-managing-access.html">Overview of Managing Access Permissions to Your Amazon Simple Queue Service Resource</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <c>SendMessage</c>, <c>DeleteMessage</c>, or <c>ChangeMessageVisibility</c> for <c>ActionName.n</c> also grants permissions for the corresponding batch versions of those actions: <c>SendMessageBatch</c>, <c>DeleteMessageBatch</c>, and <c>ChangeMessageVisibilityBatch</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <c>ReceiveMessage</c> returns
        /// this error if the maximum number of in flight messages is reached and <c>AddPermission</c>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/AddPermission">REST API Reference for AddPermission Operation</seealso>
        Task<AddPermissionResponse> AddPermissionAsync(string queueUrl, string label, List<string> awsAccountIds, List<string> actions, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Adds a permission to a queue for a specific <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
        /// This allows sharing access to the queue.
        /// 
        ///  
        /// <para>
        /// When you create a queue, you have full control access rights for the queue. Only you,
        /// the owner of the queue, can grant or deny permissions to the queue. For more information
        /// about these permissions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <c>AddPermission</c> generates a policy for you. You can use <c> <a>SetQueueAttributes</a>
        /// </c> to upload your policy. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-creating-custom-policies.html">Using
        /// Custom Policies with the Amazon SQS Access Policy Language</a> in the <i>Amazon SQS
        /// Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon SQS policy can have a maximum of seven actions per statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
        /// in your IAM policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS <c>AddPermission</c> does not support adding a non-account principal.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <c>ReceiveMessage</c> returns
        /// this error if the maximum number of in flight messages is reached and <c>AddPermission</c>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/AddPermission">REST API Reference for AddPermission Operation</seealso>
        Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelMessageMoveTask



        /// <summary>
        /// Cancels a specified message movement task. A message movement can only be cancelled
        /// when the current status is RUNNING. Cancelling a message movement task does not revert
        /// the messages that have already been moved. It can only stop the messages that have
        /// not been moved yet.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This action is currently limited to supporting message redrive from <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter
        /// queues (DLQs)</a> only. In this context, the source queue is the dead-letter queue
        /// (DLQ), while the destination queue can be the original source queue (from which the
        /// messages were driven to the dead-letter-queue), or a custom destination queue. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only one active message movement task is supported per queue at any given time.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMessageMoveTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMessageMoveTask service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ResourceNotFoundException">
        /// One or more specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/CancelMessageMoveTask">REST API Reference for CancelMessageMoveTask Operation</seealso>
        Task<CancelMessageMoveTaskResponse> CancelMessageMoveTaskAsync(CancelMessageMoveTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeMessageVisibility


        /// <summary>
        /// Changes the visibility timeout of a specified message in a queue to a new value. The
        /// default visibility timeout for a message is 30 seconds. The minimum is 0 seconds.
        /// The maximum is 12 hours. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// For example, if the default timeout for a queue is 60 seconds, 15 seconds have elapsed
        /// since you received the message, and you send a ChangeMessageVisibility call with <c>VisibilityTimeout</c>
        /// set to 10 seconds, the 10 seconds begin to count from the time that you make the <c>ChangeMessageVisibility</c>
        /// call. Thus, any attempt to change the visibility timeout or to delete that message
        /// 10 seconds after you initially change the visibility timeout (a total of 25 seconds)
        /// might result in an error.
        /// </para>
        ///  
        /// <para>
        /// An Amazon SQS message has three basic states:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Sent to a queue by a producer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Received from the queue by a consumer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted from the queue.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// A message is considered to be <i>stored</i> after it is sent to a queue by a producer,
        /// but not yet received from the queue by a consumer (that is, between states 1 and 2).
        /// There is no limit to the number of stored messages. A message is considered to be
        /// <i>in flight</i> after it is received from a queue by a consumer, but not yet deleted
        /// from the queue (that is, between states 2 and 3). There is a limit to the number of
        /// in flight messages.
        /// </para>
        ///  
        /// <para>
        /// Limits that apply to in flight messages are unrelated to the <i>unlimited</i> number
        /// of stored messages.
        /// </para>
        ///  
        /// <para>
        /// For most standard queues (depending on queue traffic and message backlog), there can
        /// be a maximum of approximately 120,000 in flight messages (received from a queue by
        /// a consumer, but not yet deleted from the queue). If you reach this limit, Amazon SQS
        /// returns the <c>OverLimit</c> error message. To avoid reaching the limit, you should
        /// delete messages from the queue after they're processed. You can also increase the
        /// number of queues you use to process your messages. To request a limit increase, <a
        /// href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-sqs">file
        /// a support request</a>.
        /// </para>
        ///  
        /// <para>
        /// For FIFO queues, there can be a maximum of 120,000 in flight messages (received from
        /// a queue by a consumer, but not yet deleted from the queue). If you reach this limit,
        /// Amazon SQS returns no error messages.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you attempt to set the <c>VisibilityTimeout</c> to a value greater than the maximum
        /// time left, Amazon SQS returns an error. Amazon SQS doesn't automatically recalculate
        /// and increase the timeout to the maximum remaining time.
        /// </para>
        ///  
        /// <para>
        /// Unlike with a queue, when you change the visibility timeout for a specific message
        /// the timeout value is applied immediately but isn't saved in memory for that message.
        /// If you don't delete a message after it is received, the visibility timeout for the
        /// message reverts to the original timeout value (not to the value you set using the
        /// <c>ChangeMessageVisibility</c> action) the next time the message is received.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose message's visibility is changed. Queue URLs and names are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message, whose visibility timeout is changed. This parameter is returned by the <c> <a>ReceiveMessage</a> </c> action.</param>
        /// <param name="visibilityTimeout">The new value for the message's visibility timeout (in seconds). Values range: <c>0</c> to <c>43200</c>. Maximum: 12 hours.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibility service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.MessageNotInflightException">
        /// The specified message isn't in flight.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibility">REST API Reference for ChangeMessageVisibility Operation</seealso>
        Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(string queueUrl, string receiptHandle, int? visibilityTimeout, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Changes the visibility timeout of a specified message in a queue to a new value. The
        /// default visibility timeout for a message is 30 seconds. The minimum is 0 seconds.
        /// The maximum is 12 hours. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// For example, if the default timeout for a queue is 60 seconds, 15 seconds have elapsed
        /// since you received the message, and you send a ChangeMessageVisibility call with <c>VisibilityTimeout</c>
        /// set to 10 seconds, the 10 seconds begin to count from the time that you make the <c>ChangeMessageVisibility</c>
        /// call. Thus, any attempt to change the visibility timeout or to delete that message
        /// 10 seconds after you initially change the visibility timeout (a total of 25 seconds)
        /// might result in an error.
        /// </para>
        ///  
        /// <para>
        /// An Amazon SQS message has three basic states:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Sent to a queue by a producer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Received from the queue by a consumer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted from the queue.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// A message is considered to be <i>stored</i> after it is sent to a queue by a producer,
        /// but not yet received from the queue by a consumer (that is, between states 1 and 2).
        /// There is no limit to the number of stored messages. A message is considered to be
        /// <i>in flight</i> after it is received from a queue by a consumer, but not yet deleted
        /// from the queue (that is, between states 2 and 3). There is a limit to the number of
        /// in flight messages.
        /// </para>
        ///  
        /// <para>
        /// Limits that apply to in flight messages are unrelated to the <i>unlimited</i> number
        /// of stored messages.
        /// </para>
        ///  
        /// <para>
        /// For most standard queues (depending on queue traffic and message backlog), there can
        /// be a maximum of approximately 120,000 in flight messages (received from a queue by
        /// a consumer, but not yet deleted from the queue). If you reach this limit, Amazon SQS
        /// returns the <c>OverLimit</c> error message. To avoid reaching the limit, you should
        /// delete messages from the queue after they're processed. You can also increase the
        /// number of queues you use to process your messages. To request a limit increase, <a
        /// href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-sqs">file
        /// a support request</a>.
        /// </para>
        ///  
        /// <para>
        /// For FIFO queues, there can be a maximum of 120,000 in flight messages (received from
        /// a queue by a consumer, but not yet deleted from the queue). If you reach this limit,
        /// Amazon SQS returns no error messages.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you attempt to set the <c>VisibilityTimeout</c> to a value greater than the maximum
        /// time left, Amazon SQS returns an error. Amazon SQS doesn't automatically recalculate
        /// and increase the timeout to the maximum remaining time.
        /// </para>
        ///  
        /// <para>
        /// Unlike with a queue, when you change the visibility timeout for a specific message
        /// the timeout value is applied immediately but isn't saved in memory for that message.
        /// If you don't delete a message after it is received, the visibility timeout for the
        /// message reverts to the original timeout value (not to the value you set using the
        /// <c>ChangeMessageVisibility</c> action) the next time the message is received.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibility service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.MessageNotInflightException">
        /// The specified message isn't in flight.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibility">REST API Reference for ChangeMessageVisibility Operation</seealso>
        Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ChangeMessageVisibilityBatch


        /// <summary>
        /// Changes the visibility timeout of multiple messages. This is a batch version of <c>
        /// <a>ChangeMessageVisibility</a>.</c> The result of the action on each message is reported
        /// individually in the response. You can send up to 10 <c> <a>ChangeMessageVisibility</a>
        /// </c> requests with each <c>ChangeMessageVisibilityBatch</c> action.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <c>200</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose messages' visibility is changed. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">Lists the receipt handles of the messages for which the visibility timeout must be changed.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <c>Id</c>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <c>Id</c> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible. For Amazon SQS, the maximum
        /// number of entries you can include in a single <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessageBatch.html">SendMessageBatch</a>,
        /// <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_DeleteMessageBatch.html">DeleteMessageBatch</a>,
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_ChangeMessageVisibilityBatch.html">ChangeMessageVisibilityBatch</a>
        /// request is 10.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibilityBatch">REST API Reference for ChangeMessageVisibilityBatch Operation</seealso>
        Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(string queueUrl, List<ChangeMessageVisibilityBatchRequestEntry> entries, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Changes the visibility timeout of multiple messages. This is a batch version of <c>
        /// <a>ChangeMessageVisibility</a>.</c> The result of the action on each message is reported
        /// individually in the response. You can send up to 10 <c> <a>ChangeMessageVisibility</a>
        /// </c> requests with each <c>ChangeMessageVisibilityBatch</c> action.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <c>200</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <c>Id</c>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <c>Id</c> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible. For Amazon SQS, the maximum
        /// number of entries you can include in a single <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessageBatch.html">SendMessageBatch</a>,
        /// <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_DeleteMessageBatch.html">DeleteMessageBatch</a>,
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_ChangeMessageVisibilityBatch.html">ChangeMessageVisibilityBatch</a>
        /// request is 10.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibilityBatch">REST API Reference for ChangeMessageVisibilityBatch Operation</seealso>
        Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQueue


        /// <summary>
        /// Creates a new standard or FIFO queue. You can pass one or more attributes in the request.
        /// Keep the following in mind:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify the <c>FifoQueue</c> attribute, Amazon SQS creates a standard
        /// queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't change the queue type after you create it and you can't convert an existing
        /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
        /// application or delete your existing standard queue and recreate it as a FIFO queue.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">Moving
        /// From a standard queue to a FIFO queue</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If you don't provide a value for an attribute, the queue is created with the default
        /// value for the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
        /// the same name.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To successfully create a new queue, you must provide a queue name that adheres to
        /// the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/limits-queues.html">limits
        /// related to queues</a> and is unique within the scope of your queues.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you create a queue, you must wait at least one second after the queue is created
        /// to be able to use the queue.
        /// </para>
        ///  </note> 
        /// <para>
        /// To retrieve the URL of a queue, use the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_GetQueueUrl.html">
        /// <c>GetQueueUrl</c> </a> action. This action only requires the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_CreateQueue.html#API_CreateQueue_RequestSyntax">
        /// <c>QueueName</c> </a> parameter.
        /// </para>
        ///  
        /// <para>
        /// When creating queues, keep the following points in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify the name of an existing queue and provide the exact same names and
        /// values for all its attributes, the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_CreateQueue.html">
        /// <c>CreateQueue</c> </a> action will return the URL of the existing queue instead of
        /// creating a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you attempt to create a queue with a name that already exists but with different
        /// attribute names or values, the <c>CreateQueue</c> action will return an error. This
        /// ensures that existing queues are not inadvertently altered.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueName">The name of the new queue. The following limits apply to this name: <ul> <li> A queue name can have up to 80 characters. </li> <li> Valid values: alphanumeric characters, hyphens (<c>-</c>), and underscores (<c>_</c>). </li> <li> A FIFO queue name must end with the <c>.fifo</c> suffix. </li> </ul> Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeValueException">
        /// A queue attribute value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDeletedRecentlyException">
        /// You must wait 60 seconds after deleting a queue before you can create another queue
        /// with the same name.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueNameExistsException">
        /// A queue with this name already exists. Amazon SQS returns this error only if the request
        /// includes attributes whose values differ from those of the existing queue.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        Task<CreateQueueResponse> CreateQueueAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Creates a new standard or FIFO queue. You can pass one or more attributes in the request.
        /// Keep the following in mind:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify the <c>FifoQueue</c> attribute, Amazon SQS creates a standard
        /// queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't change the queue type after you create it and you can't convert an existing
        /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
        /// application or delete your existing standard queue and recreate it as a FIFO queue.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">Moving
        /// From a standard queue to a FIFO queue</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If you don't provide a value for an attribute, the queue is created with the default
        /// value for the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
        /// the same name.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To successfully create a new queue, you must provide a queue name that adheres to
        /// the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/limits-queues.html">limits
        /// related to queues</a> and is unique within the scope of your queues.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you create a queue, you must wait at least one second after the queue is created
        /// to be able to use the queue.
        /// </para>
        ///  </note> 
        /// <para>
        /// To retrieve the URL of a queue, use the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_GetQueueUrl.html">
        /// <c>GetQueueUrl</c> </a> action. This action only requires the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_CreateQueue.html#API_CreateQueue_RequestSyntax">
        /// <c>QueueName</c> </a> parameter.
        /// </para>
        ///  
        /// <para>
        /// When creating queues, keep the following points in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you specify the name of an existing queue and provide the exact same names and
        /// values for all its attributes, the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_CreateQueue.html">
        /// <c>CreateQueue</c> </a> action will return the URL of the existing queue instead of
        /// creating a new one.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you attempt to create a queue with a name that already exists but with different
        /// attribute names or values, the <c>CreateQueue</c> action will return an error. This
        /// ensures that existing queues are not inadvertently altered.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeValueException">
        /// A queue attribute value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDeletedRecentlyException">
        /// You must wait 60 seconds after deleting a queue before you can create another queue
        /// with the same name.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueNameExistsException">
        /// A queue with this name already exists. Amazon SQS returns this error only if the request
        /// includes attributes whose values differ from those of the existing queue.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMessage


        /// <summary>
        /// Deletes the specified message from the specified queue. To select the message to delete,
        /// use the <c>ReceiptHandle</c> of the message (<i>not</i> the <c>MessageId</c> which
        /// you receive when you send the message). Amazon SQS can delete a message from a queue
        /// even if a visibility timeout setting causes the message to be locked by another consumer.
        /// Amazon SQS automatically deletes messages left in a queue longer than the retention
        /// period configured for the queue. 
        /// 
        ///  <note> 
        /// <para>
        /// Each time you receive a message, meaning when a consumer retrieves a message from
        /// the queue, it comes with a unique <c>ReceiptHandle</c>. If you receive the same message
        /// more than once, you will get a different <c>ReceiptHandle</c> each time. When you
        /// want to delete a message using the <c>DeleteMessage</c> action, you must use the <c>ReceiptHandle</c>
        /// from the most recent time you received the message. If you use an old <c>ReceiptHandle</c>,
        /// the request will succeed, but the message might not be deleted. 
        /// </para>
        ///  
        /// <para>
        /// For standard queues, it is possible to receive a message even after you delete it.
        /// This might happen on rare occasions if one of the servers which stores a copy of the
        /// message is unavailable when you send the request to delete the message. The copy remains
        /// on the server and might be returned to you during a subsequent receive request. You
        /// should ensure that your application is idempotent, so that receiving a message more
        /// than once does not cause issues.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are deleted. Queue URLs and names are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidIdFormatException">
        /// The specified receipt handle isn't valid for the current version.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        Task<DeleteMessageResponse> DeleteMessageAsync(string queueUrl, string receiptHandle, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the specified message from the specified queue. To select the message to delete,
        /// use the <c>ReceiptHandle</c> of the message (<i>not</i> the <c>MessageId</c> which
        /// you receive when you send the message). Amazon SQS can delete a message from a queue
        /// even if a visibility timeout setting causes the message to be locked by another consumer.
        /// Amazon SQS automatically deletes messages left in a queue longer than the retention
        /// period configured for the queue. 
        /// 
        ///  <note> 
        /// <para>
        /// Each time you receive a message, meaning when a consumer retrieves a message from
        /// the queue, it comes with a unique <c>ReceiptHandle</c>. If you receive the same message
        /// more than once, you will get a different <c>ReceiptHandle</c> each time. When you
        /// want to delete a message using the <c>DeleteMessage</c> action, you must use the <c>ReceiptHandle</c>
        /// from the most recent time you received the message. If you use an old <c>ReceiptHandle</c>,
        /// the request will succeed, but the message might not be deleted. 
        /// </para>
        ///  
        /// <para>
        /// For standard queues, it is possible to receive a message even after you delete it.
        /// This might happen on rare occasions if one of the servers which stores a copy of the
        /// message is unavailable when you send the request to delete the message. The copy remains
        /// on the server and might be returned to you during a subsequent receive request. You
        /// should ensure that your application is idempotent, so that receiving a message more
        /// than once does not cause issues.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidIdFormatException">
        /// The specified receipt handle isn't valid for the current version.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMessageBatch


        /// <summary>
        /// Deletes up to ten messages from the specified queue. This is a batch version of <c>
        /// <a>DeleteMessage</a>.</c> The result of the action on each message is reported individually
        /// in the response.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <c>200</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are deleted. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">Lists the receipt handles for the messages to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <c>Id</c>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <c>Id</c> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible. For Amazon SQS, the maximum
        /// number of entries you can include in a single <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessageBatch.html">SendMessageBatch</a>,
        /// <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_DeleteMessageBatch.html">DeleteMessageBatch</a>,
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_ChangeMessageVisibilityBatch.html">ChangeMessageVisibilityBatch</a>
        /// request is 10.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessageBatch">REST API Reference for DeleteMessageBatch Operation</seealso>
        Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(string queueUrl, List<DeleteMessageBatchRequestEntry> entries, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes up to ten messages from the specified queue. This is a batch version of <c>
        /// <a>DeleteMessage</a>.</c> The result of the action on each message is reported individually
        /// in the response.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <c>200</c>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <c>Id</c>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <c>Id</c> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible. For Amazon SQS, the maximum
        /// number of entries you can include in a single <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessageBatch.html">SendMessageBatch</a>,
        /// <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_DeleteMessageBatch.html">DeleteMessageBatch</a>,
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_ChangeMessageVisibilityBatch.html">ChangeMessageVisibilityBatch</a>
        /// request is 10.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessageBatch">REST API Reference for DeleteMessageBatch Operation</seealso>
        Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueue


        /// <summary>
        /// Deletes the queue specified by the <c>QueueUrl</c>, regardless of the queue's contents.
        /// 
        ///  <important> 
        /// <para>
        /// Be careful with the <c>DeleteQueue</c> action: When you delete a queue, any messages
        /// in the queue are no longer available. 
        /// </para>
        ///  </important> 
        /// <para>
        /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you
        /// send involving that queue during the 60 seconds might succeed. For example, a <c>
        /// <a>SendMessage</a> </c> request might succeed, but after 60 seconds the queue and
        /// the message you sent no longer exist.
        /// </para>
        ///  
        /// <para>
        /// When you delete a queue, you must wait at least 60 seconds before creating a queue
        /// with the same name.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The delete operation uses the HTTP <c>GET</c> verb.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to delete. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        Task<DeleteQueueResponse> DeleteQueueAsync(string queueUrl, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the queue specified by the <c>QueueUrl</c>, regardless of the queue's contents.
        /// 
        ///  <important> 
        /// <para>
        /// Be careful with the <c>DeleteQueue</c> action: When you delete a queue, any messages
        /// in the queue are no longer available. 
        /// </para>
        ///  </important> 
        /// <para>
        /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you
        /// send involving that queue during the 60 seconds might succeed. For example, a <c>
        /// <a>SendMessage</a> </c> request might succeed, but after 60 seconds the queue and
        /// the message you sent no longer exist.
        /// </para>
        ///  
        /// <para>
        /// When you delete a queue, you must wait at least 60 seconds before creating a queue
        /// with the same name.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The delete operation uses the HTTP <c>GET</c> verb.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueueAttributes


        /// <summary>
        /// Gets attributes for the specified queue.
        /// 
        ///  <note> 
        /// <para>
        /// To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
        /// you can check whether <c>QueueName</c> ends with the <c>.fifo</c> suffix.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attribute information is retrieved. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributeNames">A list of attributes for which to retrieve information. The <c>AttributeNames</c> parameter is optional, but if you don't specify values for this parameter, the request returns empty results. <note> In the future, new attributes might be added. If you write code that calls this action, we recommend that you structure your code so that it can handle new attributes gracefully. </note> The following attributes are supported: <important> The <c>ApproximateNumberOfMessagesDelayed</c>, <c>ApproximateNumberOfMessagesNotVisible</c>, and <c>ApproximateNumberOfMessages</c> metrics may not achieve consistency until at least 1 minute after the producers stop sending messages. This period is required for the queue metadata to reach eventual consistency.  </important> <ul> <li>  <c>All</c> – Returns all values.  </li> <li>  <c>ApproximateNumberOfMessages</c> – Returns the approximate number of messages available for retrieval from the queue. </li> <li>  <c>ApproximateNumberOfMessagesDelayed</c> – Returns the approximate number of messages in the queue that are delayed and not available for reading immediately. This can happen when the queue is configured as a delay queue or when a message has been sent with a delay parameter. </li> <li>  <c>ApproximateNumberOfMessagesNotVisible</c> – Returns the approximate number of messages that are in flight. Messages are considered to be <i>in flight</i> if they have been sent to a client but have not yet been deleted or have not yet reached the end of their visibility window.  </li> <li>  <c>CreatedTimestamp</c> – Returns the time when the queue was created in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <c>DelaySeconds</c> – Returns the default delay on the queue in seconds. </li> <li>  <c>LastModifiedTimestamp</c> – Returns the time when the queue was last changed in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <c>MaximumMessageSize</c> – Returns the limit of how many bytes a message can contain before Amazon SQS rejects it. </li> <li>  <c>MessageRetentionPeriod</c> – Returns the length of time, in seconds, for which Amazon SQS retains a message. When you change a queue's attributes, the change can take up to 60 seconds for most of the attributes to propagate throughout the Amazon SQS system. Changes made to the <c>MessageRetentionPeriod</c> attribute can take up to 15 minutes and will impact existing messages in the queue potentially causing them to be expired and deleted if the <c>MessageRetentionPeriod</c> is reduced below the age of existing messages. </li> <li>  <c>Policy</c> – Returns the policy of the queue. </li> <li>  <c>QueueArn</c> – Returns the Amazon resource name (ARN) of the queue. </li> <li>  <c>ReceiveMessageWaitTimeSeconds</c> – Returns the length of time, in seconds, for which the <c>ReceiveMessage</c> action waits for a message to arrive.  </li> <li>  <c>VisibilityTimeout</c> – Returns the visibility timeout for the queue. For more information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter queues:</a>  <ul> <li>  <c>RedrivePolicy</c> – The string that includes the parameters for the dead-letter queue functionality of the source queue as a JSON object. The parameters are as follows: <ul> <li>  <c>deadLetterTargetArn</c> – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <c>maxReceiveCount</c> is exceeded. </li> <li>  <c>maxReceiveCount</c> – The number of times a message is delivered to the source queue before being moved to the dead-letter queue. Default: 10. When the <c>ReceiveCount</c> for a message exceeds the <c>maxReceiveCount</c> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <c>RedriveAllowPolicy</c> – The string that includes the parameters for the permissions for the dead-letter queue redrive permission and which source queues can specify dead-letter queues as a JSON object. The parameters are as follows: <ul> <li>  <c>redrivePermission</c> – The permission type that defines which source queues can specify the current queue as the dead-letter queue. Valid values are: <ul> <li>  <c>allowAll</c> – (Default) Any source queues in this Amazon Web Services account in the same Region can specify this queue as the dead-letter queue. </li> <li>  <c>denyAll</c> – No source queues can specify this queue as the dead-letter queue. </li> <li>  <c>byQueue</c> – Only queues specified by the <c>sourceQueueArns</c> parameter can specify this queue as the dead-letter queue. </li> </ul> </li> <li>  <c>sourceQueueArns</c> – The Amazon Resource Names (ARN)s of the source queues that can specify this queue as the dead-letter queue and redrive messages. You can specify this parameter only when the <c>redrivePermission</c> parameter is set to <c>byQueue</c>. You can specify up to 10 source queue ARNs. To allow more than 10 source queues to specify dead-letter queues, set the <c>redrivePermission</c> parameter to <c>allowAll</c>. </li> </ul> </li> </ul> <note> The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter queue of a standard queue must also be a standard queue. </note> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <c>KmsMasterKeyId</c> – Returns the ID of an Amazon Web Services managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>.  </li> <li>  <c>KmsDataKeyReusePeriodSeconds</c> – Returns the length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling KMS again. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> <li>  <c>SqsManagedSseEnabled</c> – Returns information about whether the queue is using SSE-SQS encryption using SQS owned encryption keys. Only one server-side encryption option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a> or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>). </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <c>FifoQueue</c> – Returns information about whether the queue is FIFO. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-understanding-logic.html">FIFO queue logic</a> in the <i>Amazon SQS Developer Guide</i>. <note> To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>, you can check whether <c>QueueName</c> ends with the <c>.fifo</c> suffix. </note> </li> <li>  <c>ContentBasedDeduplication</c> – Returns whether content-based deduplication is enabled for the queue. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high throughput for FIFO queues</a>: <ul> <li>  <c>DeduplicationScope</c> – Specifies whether message deduplication occurs at the message group or queue level. Valid values are <c>messageGroup</c> and <c>queue</c>. </li> <li>  <c>FifoThroughputLimit</c> – Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are <c>perQueue</c> and <c>perMessageGroupId</c>. The <c>perMessageGroupId</c> value is allowed only when the value for <c>DeduplicationScope</c> is <c>messageGroup</c>. </li> </ul> To enable high throughput for FIFO queues, do the following: <ul> <li> Set <c>DeduplicationScope</c> to <c>messageGroup</c>. </li> <li> Set <c>FifoThroughputLimit</c> to <c>perMessageGroupId</c>. </li> </ul> If you set these attributes to anything other than the values shown for enabling high throughput, normal throughput is in effect and deduplication occurs as specified. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas related to messages</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueAttributes">REST API Reference for GetQueueAttributes Operation</seealso>
        Task<GetQueueAttributesResponse> GetQueueAttributesAsync(string queueUrl, List<string> attributeNames, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets attributes for the specified queue.
        /// 
        ///  <note> 
        /// <para>
        /// To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
        /// you can check whether <c>QueueName</c> ends with the <c>.fifo</c> suffix.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueAttributes">REST API Reference for GetQueueAttributes Operation</seealso>
        Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetQueueUrl


        /// <summary>
        /// The <c>GetQueueUrl</c> API returns the URL of an existing Amazon SQS queue. This is
        /// useful when you know the queue's name but need to retrieve its URL for further operations.
        /// 
        ///  
        /// <para>
        /// To access a queue owned by another Amazon Web Services account, use the <c>QueueOwnerAWSAccountId</c>
        /// parameter to specify the account ID of the queue's owner. Note that the queue owner
        /// must grant you the necessary permissions to access the queue. For more information
        /// about accessing shared queues, see the <c> <a>AddPermission</a> </c> API or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// developers to write messages to a shared queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="queueName">(Required) The name of the queue for which you want to fetch the URL. The name can be up to 80 characters long and can include alphanumeric characters, hyphens (-), and underscores (_). Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueUrl">REST API Reference for GetQueueUrl Operation</seealso>
        Task<GetQueueUrlResponse> GetQueueUrlAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// The <c>GetQueueUrl</c> API returns the URL of an existing Amazon SQS queue. This is
        /// useful when you know the queue's name but need to retrieve its URL for further operations.
        /// 
        ///  
        /// <para>
        /// To access a queue owned by another Amazon Web Services account, use the <c>QueueOwnerAWSAccountId</c>
        /// parameter to specify the account ID of the queue's owner. Note that the queue owner
        /// must grant you the necessary permissions to access the queue. For more information
        /// about accessing shared queues, see the <c> <a>AddPermission</a> </c> API or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// developers to write messages to a shared queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueUrl">REST API Reference for GetQueueUrl Operation</seealso>
        Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDeadLetterSourceQueues



        /// <summary>
        /// Returns a list of your queues that have the <c>RedrivePolicy</c> queue attribute configured
        /// with a dead-letter queue.
        /// 
        ///  
        /// <para>
        ///  The <c>ListDeadLetterSourceQueues</c> methods supports pagination. Set parameter
        /// <c>MaxResults</c> in the request to specify the maximum number of results to be returned
        /// in the response. If you do not set <c>MaxResults</c>, the response includes a maximum
        /// of 1,000 results. If you set <c>MaxResults</c> and there are additional results to
        /// display, the response includes a value for <c>NextToken</c>. Use <c>NextToken</c>
        /// as a parameter in your next request to <c>ListDeadLetterSourceQueues</c> to receive
        /// the next page of results. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using dead-letter queues, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
        /// Amazon SQS Dead-Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeadLetterSourceQueues service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListDeadLetterSourceQueues">REST API Reference for ListDeadLetterSourceQueues Operation</seealso>
        Task<ListDeadLetterSourceQueuesResponse> ListDeadLetterSourceQueuesAsync(ListDeadLetterSourceQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMessageMoveTasks



        /// <summary>
        /// Gets the most recent message movement tasks (up to 10) under a specific source queue.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This action is currently limited to supporting message redrive from <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter
        /// queues (DLQs)</a> only. In this context, the source queue is the dead-letter queue
        /// (DLQ), while the destination queue can be the original source queue (from which the
        /// messages were driven to the dead-letter-queue), or a custom destination queue. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only one active message movement task is supported per queue at any given time.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageMoveTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMessageMoveTasks service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ResourceNotFoundException">
        /// One or more specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListMessageMoveTasks">REST API Reference for ListMessageMoveTasks Operation</seealso>
        Task<ListMessageMoveTasksResponse> ListMessageMoveTasksAsync(ListMessageMoveTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueues


        /// <summary>
        /// Returns a list of your queues in the current region. The response includes a maximum
        /// of 1,000 results. If you specify a value for the optional <c>QueueNamePrefix</c> parameter,
        /// only queues with a name that begins with the specified value are returned.
        /// 
        ///  
        /// <para>
        ///  The <c>listQueues</c> methods supports pagination. Set parameter <c>MaxResults</c>
        /// in the request to specify the maximum number of results to be returned in the response.
        /// If you do not set <c>MaxResults</c>, the response includes a maximum of 1,000 results.
        /// If you set <c>MaxResults</c> and there are additional results to display, the response
        /// includes a value for <c>NextToken</c>. Use <c>NextToken</c> as a parameter in your
        /// next request to <c>listQueues</c> to receive the next page of results. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueNamePrefix">A string to use for filtering the list results. Only those queues whose name begins with the specified string are returned. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListQueues">REST API Reference for ListQueues Operation</seealso>
        Task<ListQueuesResponse> ListQueuesAsync(string queueNamePrefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns a list of your queues in the current region. The response includes a maximum
        /// of 1,000 results. If you specify a value for the optional <c>QueueNamePrefix</c> parameter,
        /// only queues with a name that begins with the specified value are returned.
        /// 
        ///  
        /// <para>
        ///  The <c>listQueues</c> methods supports pagination. Set parameter <c>MaxResults</c>
        /// in the request to specify the maximum number of results to be returned in the response.
        /// If you do not set <c>MaxResults</c>, the response includes a maximum of 1,000 results.
        /// If you set <c>MaxResults</c> and there are additional results to display, the response
        /// includes a value for <c>NextToken</c>. Use <c>NextToken</c> as a parameter in your
        /// next request to <c>listQueues</c> to receive the next page of results. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListQueues">REST API Reference for ListQueues Operation</seealso>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListQueueTags



        /// <summary>
        /// List all cost allocation tags added to the specified Amazon SQS queue. For an overview,
        /// see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueTags service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListQueueTags">REST API Reference for ListQueueTags Operation</seealso>
        Task<ListQueueTagsResponse> ListQueueTagsAsync(ListQueueTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurgeQueue


        /// <summary>
        /// Deletes available messages in a queue (including in-flight messages) specified by
        /// the <c>QueueURL</c> parameter.
        /// 
        ///  <important> 
        /// <para>
        /// When you use the <c>PurgeQueue</c> action, you can't retrieve any messages deleted
        /// from a queue.
        /// </para>
        ///  
        /// <para>
        /// The message deletion process takes up to 60 seconds. We recommend waiting for 60 seconds
        /// regardless of your queue's size. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Messages sent to the queue <i>before</i> you call <c>PurgeQueue</c> might be received
        /// but are deleted within the next minute.
        /// </para>
        ///  
        /// <para>
        /// Messages sent to the queue <i>after</i> you call <c>PurgeQueue</c> might be deleted
        /// while the queue is being purged.
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the queue from which the <c>PurgeQueue</c> action deletes messages. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurgeQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.PurgeQueueInProgressException">
        /// Indicates that the specified queue previously received a <c>PurgeQueue</c> request
        /// within the last 60 seconds (the time it can take to delete the messages in the queue).
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/PurgeQueue">REST API Reference for PurgeQueue Operation</seealso>
        Task<PurgeQueueResponse> PurgeQueueAsync(string queueUrl, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes available messages in a queue (including in-flight messages) specified by
        /// the <c>QueueURL</c> parameter.
        /// 
        ///  <important> 
        /// <para>
        /// When you use the <c>PurgeQueue</c> action, you can't retrieve any messages deleted
        /// from a queue.
        /// </para>
        ///  
        /// <para>
        /// The message deletion process takes up to 60 seconds. We recommend waiting for 60 seconds
        /// regardless of your queue's size. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Messages sent to the queue <i>before</i> you call <c>PurgeQueue</c> might be received
        /// but are deleted within the next minute.
        /// </para>
        ///  
        /// <para>
        /// Messages sent to the queue <i>after</i> you call <c>PurgeQueue</c> might be deleted
        /// while the queue is being purged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurgeQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurgeQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.PurgeQueueInProgressException">
        /// Indicates that the specified queue previously received a <c>PurgeQueue</c> request
        /// within the last 60 seconds (the time it can take to delete the messages in the queue).
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/PurgeQueue">REST API Reference for PurgeQueue Operation</seealso>
        Task<PurgeQueueResponse> PurgeQueueAsync(PurgeQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReceiveMessage


        /// <summary>
        /// Retrieves one or more messages (up to 10), from the specified queue. Using the <c>WaitTimeSeconds</c>
        /// parameter enables long-poll support. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Polling</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// 
        ///  
        /// <para>
        /// Short poll is the default behavior where a weighted random set of machines is sampled
        /// on a <c>ReceiveMessage</c> call. Therefore, only the messages on the sampled machines
        /// are returned. If the number of messages in the queue is small (fewer than 1,000),
        /// you most likely get fewer messages than you requested per <c>ReceiveMessage</c> call.
        /// If the number of messages in the queue is extremely small, you might not receive any
        /// messages in a particular <c>ReceiveMessage</c> response. If this happens, repeat the
        /// request.
        /// </para>
        ///  
        /// <para>
        /// For each message returned, the response includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message body. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>MessageId</c> you received when you sent the message to the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The receipt handle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message attributes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The receipt handle is the identifier you must provide when deleting the message. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-message-identifiers.html">Queue
        /// and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can provide the <c>VisibilityTimeout</c> parameter in your request. The parameter
        /// is applied to the messages that Amazon SQS returns in the response. If you don't include
        /// the parameter, the overall visibility timeout for the queue is used for the returned
        /// messages. The default visibility timeout for a queue is 30 seconds. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are received. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsAccessDeniedException">
        /// The caller doesn't have the required KMS access.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsDisabledException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The KeyUsage value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (KeySpec).
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsNotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsOptInRequiredException">
        /// The request was rejected because the specified key policy isn't syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsThrottledException">
        /// Amazon Web Services KMS throttles requests for the following conditions.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <c>ReceiveMessage</c> returns
        /// this error if the maximum number of in flight messages is reached and <c>AddPermission</c>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ReceiveMessage">REST API Reference for ReceiveMessage Operation</seealso>
        Task<ReceiveMessageResponse> ReceiveMessageAsync(string queueUrl, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Retrieves one or more messages (up to 10), from the specified queue. Using the <c>WaitTimeSeconds</c>
        /// parameter enables long-poll support. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Polling</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// 
        ///  
        /// <para>
        /// Short poll is the default behavior where a weighted random set of machines is sampled
        /// on a <c>ReceiveMessage</c> call. Therefore, only the messages on the sampled machines
        /// are returned. If the number of messages in the queue is small (fewer than 1,000),
        /// you most likely get fewer messages than you requested per <c>ReceiveMessage</c> call.
        /// If the number of messages in the queue is extremely small, you might not receive any
        /// messages in a particular <c>ReceiveMessage</c> response. If this happens, repeat the
        /// request.
        /// </para>
        ///  
        /// <para>
        /// For each message returned, the response includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message body. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>MessageId</c> you received when you sent the message to the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The receipt handle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message attributes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The receipt handle is the identifier you must provide when deleting the message. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-message-identifiers.html">Queue
        /// and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can provide the <c>VisibilityTimeout</c> parameter in your request. The parameter
        /// is applied to the messages that Amazon SQS returns in the response. If you don't include
        /// the parameter, the overall visibility timeout for the queue is used for the returned
        /// messages. The default visibility timeout for a queue is 30 seconds. 
        /// </para>
        ///  <note> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsAccessDeniedException">
        /// The caller doesn't have the required KMS access.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsDisabledException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The KeyUsage value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (KeySpec).
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsNotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsOptInRequiredException">
        /// The request was rejected because the specified key policy isn't syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsThrottledException">
        /// Amazon Web Services KMS throttles requests for the following conditions.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <c>ReceiveMessage</c> returns
        /// this error if the maximum number of in flight messages is reached and <c>AddPermission</c>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ReceiveMessage">REST API Reference for ReceiveMessage Operation</seealso>
        Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemovePermission


        /// <summary>
        /// Revokes any permissions in the queue policy that matches the specified <c>Label</c>
        /// parameter.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Only the owner of a queue can remove permissions from it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
        /// in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which permissions are removed. Queue URLs and names are case-sensitive.</param>
        /// <param name="label">The identification of the permission to remove. This is the label added using the <c> <a>AddPermission</a> </c> action.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        Task<RemovePermissionResponse> RemovePermissionAsync(string queueUrl, string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Revokes any permissions in the queue policy that matches the specified <c>Label</c>
        /// parameter.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Only the owner of a queue can remove permissions from it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
        /// in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendMessage


        /// <summary>
        /// Delivers a message to the specified queue.
        /// 
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C
        /// specification for characters</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>#x9</c> | <c>#xA</c> | <c>#xD</c> | <c>#x20</c> to <c>#xD7FF</c> | <c>#xE000</c>
        /// to <c>#xFFFD</c> | <c>#x10000</c> to <c>#x10FFFF</c> 
        /// </para>
        ///  
        /// <para>
        /// If a message contains characters outside the allowed set, Amazon SQS rejects the message
        /// and returns an InvalidMessageContents error. Ensure that your message body includes
        /// only valid characters to avoid this exception.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which a message is sent. Queue URLs and names are case-sensitive.</param>
        /// <param name="messageBody">The message to send. The minimum size is one character. The maximum size is 1 MiB or 1,048,576 bytes <important> A message can include only XML, JSON, and unformatted text. The following Unicode characters are allowed. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>.  <c>#x9</c> | <c>#xA</c> | <c>#xD</c> | <c>#x20</c> to <c>#xD7FF</c> | <c>#xE000</c> to <c>#xFFFD</c> | <c>#x10000</c> to <c>#x10FFFF</c>  If a message contains characters outside the allowed set, Amazon SQS rejects the message and returns an InvalidMessageContents error. Ensure that your message body includes only valid characters to avoid this exception. </important></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidMessageContentsException">
        /// The message contains characters outside the allowed set.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsAccessDeniedException">
        /// The caller doesn't have the required KMS access.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsDisabledException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The KeyUsage value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (KeySpec).
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsNotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsOptInRequiredException">
        /// The request was rejected because the specified key policy isn't syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsThrottledException">
        /// Amazon Web Services KMS throttles requests for the following conditions.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessage">REST API Reference for SendMessage Operation</seealso>
        Task<SendMessageResponse> SendMessageAsync(string queueUrl, string messageBody, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Delivers a message to the specified queue.
        /// 
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C
        /// specification for characters</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>#x9</c> | <c>#xA</c> | <c>#xD</c> | <c>#x20</c> to <c>#xD7FF</c> | <c>#xE000</c>
        /// to <c>#xFFFD</c> | <c>#x10000</c> to <c>#x10FFFF</c> 
        /// </para>
        ///  
        /// <para>
        /// If a message contains characters outside the allowed set, Amazon SQS rejects the message
        /// and returns an InvalidMessageContents error. Ensure that your message body includes
        /// only valid characters to avoid this exception.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidMessageContentsException">
        /// The message contains characters outside the allowed set.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsAccessDeniedException">
        /// The caller doesn't have the required KMS access.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsDisabledException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The KeyUsage value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (KeySpec).
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsNotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsOptInRequiredException">
        /// The request was rejected because the specified key policy isn't syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsThrottledException">
        /// Amazon Web Services KMS throttles requests for the following conditions.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessage">REST API Reference for SendMessage Operation</seealso>
        Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendMessageBatch


        /// <summary>
        /// You can use <c>SendMessageBatch</c> to send up to 10 messages to the specified queue
        /// by assigning either identical or different values to each message (or by not assigning
        /// values at all). This is a batch version of <c> <a>SendMessage</a>.</c> For a FIFO
        /// queue, multiple messages within a single batch are enqueued in the order they are
        /// sent.
        /// 
        ///  
        /// <para>
        /// The result of sending each message is reported individually in the response. Because
        /// the batch request can result in a combination of successful and unsuccessful actions,
        /// you should check for batch errors even when the call returns an HTTP status code of
        /// <c>200</c>.
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed individual message size and the maximum total payload size (the
        /// sum of the individual lengths of all of the batched messages) are both 1 MiB 1,048,576
        /// bytes.
        /// </para>
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C
        /// specification for characters</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>#x9</c> | <c>#xA</c> | <c>#xD</c> | <c>#x20</c> to <c>#xD7FF</c> | <c>#xE000</c>
        /// to <c>#xFFFD</c> | <c>#x10000</c> to <c>#x10FFFF</c> 
        /// </para>
        ///  
        /// <para>
        /// If a message contains characters outside the allowed set, Amazon SQS rejects the message
        /// and returns an InvalidMessageContents error. Ensure that your message body includes
        /// only valid characters to avoid this exception.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you don't specify the <c>DelaySeconds</c> parameter for an entry, Amazon SQS uses
        /// the default value for the queue.
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which batched messages are sent. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">A list of <c> <a>SendMessageBatchRequestEntry</a> </c> items.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <c>Id</c>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.BatchRequestTooLongException">
        /// The length of all the messages put together is more than the limit.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <c>Id</c> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsAccessDeniedException">
        /// The caller doesn't have the required KMS access.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsDisabledException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The KeyUsage value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (KeySpec).
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsNotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsOptInRequiredException">
        /// The request was rejected because the specified key policy isn't syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsThrottledException">
        /// Amazon Web Services KMS throttles requests for the following conditions.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible. For Amazon SQS, the maximum
        /// number of entries you can include in a single <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessageBatch.html">SendMessageBatch</a>,
        /// <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_DeleteMessageBatch.html">DeleteMessageBatch</a>,
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_ChangeMessageVisibilityBatch.html">ChangeMessageVisibilityBatch</a>
        /// request is 10.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessageBatch">REST API Reference for SendMessageBatch Operation</seealso>
        Task<SendMessageBatchResponse> SendMessageBatchAsync(string queueUrl, List<SendMessageBatchRequestEntry> entries, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// You can use <c>SendMessageBatch</c> to send up to 10 messages to the specified queue
        /// by assigning either identical or different values to each message (or by not assigning
        /// values at all). This is a batch version of <c> <a>SendMessage</a>.</c> For a FIFO
        /// queue, multiple messages within a single batch are enqueued in the order they are
        /// sent.
        /// 
        ///  
        /// <para>
        /// The result of sending each message is reported individually in the response. Because
        /// the batch request can result in a combination of successful and unsuccessful actions,
        /// you should check for batch errors even when the call returns an HTTP status code of
        /// <c>200</c>.
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed individual message size and the maximum total payload size (the
        /// sum of the individual lengths of all of the batched messages) are both 1 MiB 1,048,576
        /// bytes.
        /// </para>
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C
        /// specification for characters</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>#x9</c> | <c>#xA</c> | <c>#xD</c> | <c>#x20</c> to <c>#xD7FF</c> | <c>#xE000</c>
        /// to <c>#xFFFD</c> | <c>#x10000</c> to <c>#x10FFFF</c> 
        /// </para>
        ///  
        /// <para>
        /// If a message contains characters outside the allowed set, Amazon SQS rejects the message
        /// and returns an InvalidMessageContents error. Ensure that your message body includes
        /// only valid characters to avoid this exception.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you don't specify the <c>DelaySeconds</c> parameter for an entry, Amazon SQS uses
        /// the default value for the queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <c>Id</c>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.BatchRequestTooLongException">
        /// The length of all the messages put together is more than the limit.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <c>Id</c> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsAccessDeniedException">
        /// The caller doesn't have the required KMS access.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsDisabledException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidKeyUsageException">
        /// The request was rejected for one of the following reasons:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The KeyUsage value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key (KeySpec).
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsNotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsOptInRequiredException">
        /// The request was rejected because the specified key policy isn't syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.KmsThrottledException">
        /// Amazon Web Services KMS throttles requests for the following conditions.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible. For Amazon SQS, the maximum
        /// number of entries you can include in a single <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_SendMessageBatch.html">SendMessageBatch</a>,
        /// <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_DeleteMessageBatch.html">DeleteMessageBatch</a>,
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/API_ChangeMessageVisibilityBatch.html">ChangeMessageVisibilityBatch</a>
        /// request is 10.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessageBatch">REST API Reference for SendMessageBatch Operation</seealso>
        Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SetQueueAttributes


        /// <summary>
        /// Sets the value of one or more queue attributes, like a policy. When you change a queue's
        /// attributes, the change can take up to 60 seconds for most of the attributes to propagate
        /// throughout the Amazon SQS system. Changes made to the <c>MessageRetentionPeriod</c>
        /// attribute can take up to 15 minutes and will impact existing messages in the queue
        /// potentially causing them to be expired and deleted if the <c>MessageRetentionPeriod</c>
        /// is reduced below the age of existing messages.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
        /// in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attributes are set. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters that the <c>SetQueueAttributes</c> action uses: <ul> <li>  <c>DelaySeconds</c> – The length of time, in seconds, for which the delivery of all messages in the queue is delayed. Valid values: An integer from 0 to 900 (15 minutes). Default: 0.  </li> <li>  <c>MaximumMessageSize</c> – The limit of how many bytes a message can contain before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) up to 1,048,576 bytes (1 MiB). Default: 1,048,576 bytes (1 MiB).  </li> <li>  <c>MessageRetentionPeriod</c> – The length of time, in seconds, for which Amazon SQS retains a message. Valid values: An integer representing seconds, from 60 (1 minute) to 1,209,600 (14 days). Default: 345,600 (4 days). When you change a queue's attributes, the change can take up to 60 seconds for most of the attributes to propagate throughout the Amazon SQS system. Changes made to the <c>MessageRetentionPeriod</c> attribute can take up to 15 minutes and will impact existing messages in the queue potentially causing them to be expired and deleted if the <c>MessageRetentionPeriod</c> is reduced below the age of existing messages. </li> <li>  <c>Policy</c> – The queue's policy. A valid Amazon Web Services policy. For more information about policy structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview of Amazon Web Services IAM Policies</a> in the <i>Identity and Access Management User Guide</i>.  </li> <li>  <c>ReceiveMessageWaitTimeSeconds</c> – The length of time, in seconds, for which a <c> <a>ReceiveMessage</a> </c> action waits for a message to arrive. Valid values: An integer from 0 to 20 (seconds). Default: 0.  </li> <li>  <c>VisibilityTimeout</c> – The visibility timeout for the queue, in seconds. Valid values: An integer from 0 to 43,200 (12 hours). Default: 30. For more information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>. </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter queues:</a>  <ul> <li>  <c>RedrivePolicy</c> – The string that includes the parameters for the dead-letter queue functionality of the source queue as a JSON object. The parameters are as follows: <ul> <li>  <c>deadLetterTargetArn</c> – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <c>maxReceiveCount</c> is exceeded. </li> <li>  <c>maxReceiveCount</c> – The number of times a message is delivered to the source queue before being moved to the dead-letter queue. Default: 10. When the <c>ReceiveCount</c> for a message exceeds the <c>maxReceiveCount</c> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <c>RedriveAllowPolicy</c> – The string that includes the parameters for the permissions for the dead-letter queue redrive permission and which source queues can specify dead-letter queues as a JSON object. The parameters are as follows: <ul> <li>  <c>redrivePermission</c> – The permission type that defines which source queues can specify the current queue as the dead-letter queue. Valid values are: <ul> <li>  <c>allowAll</c> – (Default) Any source queues in this Amazon Web Services account in the same Region can specify this queue as the dead-letter queue. </li> <li>  <c>denyAll</c> – No source queues can specify this queue as the dead-letter queue. </li> <li>  <c>byQueue</c> – Only queues specified by the <c>sourceQueueArns</c> parameter can specify this queue as the dead-letter queue. </li> </ul> </li> <li>  <c>sourceQueueArns</c> – The Amazon Resource Names (ARN)s of the source queues that can specify this queue as the dead-letter queue and redrive messages. You can specify this parameter only when the <c>redrivePermission</c> parameter is set to <c>byQueue</c>. You can specify up to 10 source queue ARNs. To allow more than 10 source queues to specify dead-letter queues, set the <c>redrivePermission</c> parameter to <c>allowAll</c>. </li> </ul> </li> </ul> <note> The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter queue of a standard queue must also be a standard queue. </note> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <c>KmsMasterKeyId</c> – The ID of an Amazon Web Services managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>. While the alias of the AWS-managed CMK for Amazon SQS is always <c>alias/aws/sqs</c>, the alias of a custom CMK can, for example, be <c>alias/<i>MyAlias</i> </c>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a> in the <i>Key Management Service API Reference</i>.  </li> <li>  <c>KmsDataKeyReusePeriodSeconds</c> – The length of time, in seconds, for which Amazon SQS can reuse a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data key</a> to encrypt or decrypt messages before calling KMS again. An integer representing seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). Default: 300 (5 minutes). A shorter time period provides better security but results in more calls to KMS which might incur charges after Free Tier. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> <li>  <c>SqsManagedSseEnabled</c> – Enables server-side queue encryption using SQS owned encryption keys. Only one server-side encryption option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a> or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>). </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <c>ContentBasedDeduplication</c> – Enables content-based deduplication. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>. Note the following:  <ul> <li> Every message must have a unique <c>MessageDeduplicationId</c>. <ul> <li> You may provide a <c>MessageDeduplicationId</c> explicitly. </li> <li> If you aren't able to provide a <c>MessageDeduplicationId</c> and you enable <c>ContentBasedDeduplication</c> for your queue, Amazon SQS uses a SHA-256 hash to generate the <c>MessageDeduplicationId</c> using the body of the message (but not the attributes of the message).  </li> <li> If you don't provide a <c>MessageDeduplicationId</c> and the queue doesn't have <c>ContentBasedDeduplication</c> set, the action fails with an error. </li> <li> If the queue has <c>ContentBasedDeduplication</c> set, your <c>MessageDeduplicationId</c> overrides the generated one. </li> </ul> </li> <li> When <c>ContentBasedDeduplication</c> is in effect, messages with identical content sent within the deduplication interval are treated as duplicates and only one copy of the message is delivered. </li> <li> If you send one message with <c>ContentBasedDeduplication</c> enabled and then another message with a <c>MessageDeduplicationId</c> that is the same as the one generated for the first <c>MessageDeduplicationId</c>, the two messages are treated as duplicates and only one copy of the message is delivered.  </li> </ul> </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high throughput for FIFO queues</a>: <ul> <li>  <c>DeduplicationScope</c> – Specifies whether message deduplication occurs at the message group or queue level. Valid values are <c>messageGroup</c> and <c>queue</c>. </li> <li>  <c>FifoThroughputLimit</c> – Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are <c>perQueue</c> and <c>perMessageGroupId</c>. The <c>perMessageGroupId</c> value is allowed only when the value for <c>DeduplicationScope</c> is <c>messageGroup</c>. </li> </ul> To enable high throughput for FIFO queues, do the following: <ul> <li> Set <c>DeduplicationScope</c> to <c>messageGroup</c>. </li> <li> Set <c>FifoThroughputLimit</c> to <c>perMessageGroupId</c>. </li> </ul> If you set these attributes to anything other than the values shown for enabling high throughput, normal throughput is in effect and deduplication occurs as specified. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas related to messages</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeValueException">
        /// A queue attribute value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <c>ReceiveMessage</c> returns
        /// this error if the maximum number of in flight messages is reached and <c>AddPermission</c>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SetQueueAttributes">REST API Reference for SetQueueAttributes Operation</seealso>
        Task<SetQueueAttributesResponse> SetQueueAttributesAsync(string queueUrl, Dictionary<string, string> attributes, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Sets the value of one or more queue attributes, like a policy. When you change a queue's
        /// attributes, the change can take up to 60 seconds for most of the attributes to propagate
        /// throughout the Amazon SQS system. Changes made to the <c>MessageRetentionPeriod</c>
        /// attribute can take up to 15 minutes and will impact existing messages in the queue
        /// potentially causing them to be expired and deleted if the <c>MessageRetentionPeriod</c>
        /// is reduced below the age of existing messages.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetQueueAttributes</c> actions
        /// in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeValueException">
        /// A queue attribute value is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <c>ReceiveMessage</c> returns
        /// this error if the maximum number of in flight messages is reached and <c>AddPermission</c>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SetQueueAttributes">REST API Reference for SetQueueAttributes Operation</seealso>
        Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartMessageMoveTask



        /// <summary>
        /// Starts an asynchronous task to move messages from a specified source queue to a specified
        /// destination queue.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This action is currently limited to supporting message redrive from queues that are
        /// configured as <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter
        /// queues (DLQs)</a> of other Amazon SQS queues only. Non-SQS queue sources of dead-letter
        /// queues, such as Lambda or Amazon SNS topics, are currently not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In dead-letter queues redrive context, the <c>StartMessageMoveTask</c> the source
        /// queue is the DLQ, while the destination queue can be the original source queue (from
        /// which the messages were driven to the dead-letter-queue), or a custom destination
        /// queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only one active message movement task is supported per queue at any given time.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMessageMoveTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMessageMoveTask service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ResourceNotFoundException">
        /// One or more specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/StartMessageMoveTask">REST API Reference for StartMessageMoveTask Operation</seealso>
        Task<StartMessageMoveTaskResponse> StartMessageMoveTaskAsync(StartMessageMoveTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagQueue



        /// <summary>
        /// Add cost allocation tags to the specified Amazon SQS queue. For an overview, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you use queue tags, keep the following guidelines in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Adding more than 50 tags to a queue isn't recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags don't have any semantic meaning. Amazon SQS interprets tags as character strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new tag with a key identical to that of an existing tag overwrites the existing
        /// tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a full list of tag restrictions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-limits.html#limits-queues">Quotas
        /// related to queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/TagQueue">REST API Reference for TagQueue Operation</seealso>
        Task<TagQueueResponse> TagQueueAsync(TagQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagQueue



        /// <summary>
        /// Remove cost allocation tags from the specified Amazon SQS queue. For an overview,
        /// see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAddressException">
        /// The specified ID is invalid.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidSecurityException">
        /// The request was not made over HTTPS or did not use SigV4 for signing.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// Ensure that the <c>QueueUrl</c> is correct and that the queue has not been deleted.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.RequestThrottledException">
        /// The request was denied due to request throttling.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Exceeds the permitted request rate for the queue or for the recipient of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ensure that the request rate is within the Amazon SQS limits for sending messages.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-quotas.html#quotas-requests">Amazon
        /// SQS quotas</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/UntagQueue">REST API Reference for UntagQueue Operation</seealso>
        Task<UntagQueueResponse> UntagQueueAsync(UntagQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSQSConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSQSConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSQSConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSQSConfig to create AmazonSQSClient");
            }

            return awsCredentials == null ? 
                    new AmazonSQSClient(serviceClientConfig) :
                    new AmazonSQSClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}