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
    /// Welcome to the <i>Amazon Simple Queue Service API Reference</i>. This section    
    ///  describes who should read this guide, how the guide is organized, and other resources
    /// related to the      Amazon Simple Queue Service (Amazon SQS).
    /// 
    ///     
    /// <para>
    /// Amazon SQS offers reliable and scalable hosted queues for storing messages as they
    /// travel      between computers. By using Amazon SQS, you can move data between distributed
    /// components of      your applications that perform different tasks without losing messages
    /// or requiring each      component to be always available.
    /// </para>
    ///     
    /// <para>
    /// Helpful Links:      <ul>        <li><a href="http://queue.amazonaws.com/doc/2012-11-05/QueueService.wsdl">Current
    /// WSDL (2012-11-05)</a></li>        <li><a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/MakingRequestsArticle.html">Making
    /// API Requests</a></li>        <li><a href="http://aws.amazon.com/sqs/">Amazon SQS product
    /// page</a></li>        <li><a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using
    /// Amazon SQS Dead Letter Queues</a></li>                <li><a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sqs_region">Regions
    /// and Endpoints</a></li>              </ul>    
    /// </para>
    ///     
    /// <para>
    /// We also provide SDKs that enable you to access Amazon SQS from your preferred programming
    /// language.     The SDKs contain functionality that automatically takes care of tasks
    /// such as:
    /// </para>
    ///     
    /// <para>
    ///       <ul>        <li>Cryptographically signing your service requests</li>       
    /// <li>Retrying requests</li>        <li>Handling error responses</li>      </ul>   
    /// 
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
        /// Adds a permission to a queue for a specific       <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
        ///      This allows for sharing access to the queue.
        /// 
        ///     
        /// <para>
        /// When you create a queue, you have full control access rights for the queue.      Only
        /// you (as owner of the queue) can grant or deny permissions to the queue.      For more
        /// information about these permissions, see      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared
        ///      Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///     <note>    
        /// <para>
        /// <code>AddPermission</code> writes an Amazon SQS-generated policy. If you want to 
        ///     write your own policy, use <a>SetQueueAttributes</a> to upload your policy. For
        /// more      information about writing your own policy, see      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AccessPolicyLanguage.html">Using
        ///      The Access Policy Language</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///     </note>        <note>Some API actions take lists of parameters. These lists are
        /// specified using the <code>param.n</code> notation. Values      of <code>n</code> are
        /// integers starting from 1. For example, a parameter list with two elements looks like
        /// this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="label">The unique identification of the permission you're setting (e.g.,   <code>AliceSendMessage</code>). Constraints: Maximum 80 characters;   alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        /// <param name="awsAccountIds">The AWS account number of the <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>   who will be given permission. The principal must have an AWS account, but does   not need to be signed up for Amazon SQS. For information about locating the AWS   account identification, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AWSCredentials.html">Your  AWS Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="actions">The action the client wants to allow for the specified principal.    The following are valid values: <code>* | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes | GetQueueUrl</code>.    For more information about these actions, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html#PermissionTypes">Understanding   Permissions</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <code>SendMessage</code>,   <code>DeleteMessage</code>, or <code>ChangeMessageVisibility</code> for the    <code>ActionName.n</code> also grants   permissions for the corresponding batch versions of those actions:   <code>SendMessageBatch</code>,   <code>DeleteMessageBatch</code>, and <code>ChangeMessageVisibilityBatch</code>.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SQS.</returns>
        /// <exception cref="OverLimitException">
        /// The action that you requested would violate a limit. For example,      ReceiveMessage
        /// returns this error if the maximum number of messages      inflight has already been
        /// reached. <a>AddPermission</a> returns this error if      the maximum number of permissions
        /// for the queue has already been reached.
        /// </exception>
        AddPermissionResponse AddPermission(string queueUrl, string label, List<string> awsAccountIds, List<string> actions);

        /// <summary>
        /// Adds a permission to a queue for a specific       <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
        ///      This allows for sharing access to the queue.
        /// 
        ///     
        /// <para>
        /// When you create a queue, you have full control access rights for the queue.      Only
        /// you (as owner of the queue) can grant or deny permissions to the queue.      For more
        /// information about these permissions, see      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared
        ///      Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///     <note>    
        /// <para>
        /// <code>AddPermission</code> writes an Amazon SQS-generated policy. If you want to 
        ///     write your own policy, use <a>SetQueueAttributes</a> to upload your policy. For
        /// more      information about writing your own policy, see      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AccessPolicyLanguage.html">Using
        ///      The Access Policy Language</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///     </note>        <note>Some API actions take lists of parameters. These lists are
        /// specified using the <code>param.n</code> notation. Values      of <code>n</code> are
        /// integers starting from 1. For example, a parameter list with two elements looks like
        /// this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SQS.</returns>
        /// <exception cref="OverLimitException">
        /// The action that you requested would violate a limit. For example,      ReceiveMessage
        /// returns this error if the maximum number of messages      inflight has already been
        /// reached. <a>AddPermission</a> returns this error if      the maximum number of permissions
        /// for the queue has already been reached.
        /// </exception>
        AddPermissionResponse AddPermission(AddPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Changes the visibility      timeout of a specified message in a queue to a new value.
        /// The maximum allowed      timeout value you can set the value to is 12 hours. This
        /// means you can't extend      the timeout of a message in an existing queue to more
        /// than a total visibility      timeout of 12 hours. (For more information visibility
        /// timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        ///        Timeout</a> in the <i>Amazon SQS Developer Guide</i>.)
        /// 
        ///     
        /// <para>
        /// For example, let's say you have a message and its default message visibility     
        /// timeout is 30 minutes. You could call <code>ChangeMessageVisiblity</code> with   
        ///   a value of two hours and the effective timeout would be two hours and 30      minutes.
        /// When that time comes near you could again extend the time out by      calling ChangeMessageVisiblity,
        /// but this time the maximum allowed timeout would      be 9 hours and 30 minutes.
        /// </para>
        ///         <note>
        /// <para>
        /// There is a 120,000 limit for the number of inflight messages per queue. Messages are
        /// inflight after they have been received from the queue by a consuming component, but
        /// have not yet been deleted from the queue. If you reach the 120,000 limit, you will
        /// receive an OverLimit error message from Amazon SQS. To help avoid reaching the limit,
        /// you should       delete the messages from the queue after they have been processed.
        /// You can also increase the number of queues you use to process the messages.    
        /// </para>
        /// </note>    <important>If you attempt to set the <code>VisibilityTimeout</code> to
        /// an      amount more than the maximum time left, Amazon SQS returns an error. It will
        ///      not automatically recalculate and increase the timeout to the maximum time  
        ///    remaining.</important>    <important>Unlike with a queue, when you change the visibility
        /// timeout for a      specific message, that timeout value is applied immediately but
        /// is not saved in      memory for that message. If you don't delete a message after
        /// it is received,      the visibility timeout for the message the next time it is received
        /// reverts to      the original timeout value, not the value you set with the      <code>ChangeMessageVisibility</code>
        /// action.</important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message whose visibility timeout   should be changed. This parameter is returned by the <a>ReceiveMessage</a> action.</param>
        /// <param name="visibilityTimeout">The new value (in seconds - from 0 to 43200 - maximum 12 hours) for the message's visibility timeout.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibility service method, as returned by SQS.</returns>
        /// <exception cref="MessageNotInflightException">
        /// The message referred to is not in flight.
        /// </exception>
        /// <exception cref="ReceiptHandleIsInvalidException">
        /// The receipt handle provided is not valid.
        /// </exception>
        ChangeMessageVisibilityResponse ChangeMessageVisibility(string queueUrl, string receiptHandle, int visibilityTimeout);

        /// <summary>
        /// Changes the visibility      timeout of a specified message in a queue to a new value.
        /// The maximum allowed      timeout value you can set the value to is 12 hours. This
        /// means you can't extend      the timeout of a message in an existing queue to more
        /// than a total visibility      timeout of 12 hours. (For more information visibility
        /// timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        ///        Timeout</a> in the <i>Amazon SQS Developer Guide</i>.)
        /// 
        ///     
        /// <para>
        /// For example, let's say you have a message and its default message visibility     
        /// timeout is 30 minutes. You could call <code>ChangeMessageVisiblity</code> with   
        ///   a value of two hours and the effective timeout would be two hours and 30      minutes.
        /// When that time comes near you could again extend the time out by      calling ChangeMessageVisiblity,
        /// but this time the maximum allowed timeout would      be 9 hours and 30 minutes.
        /// </para>
        ///         <note>
        /// <para>
        /// There is a 120,000 limit for the number of inflight messages per queue. Messages are
        /// inflight after they have been received from the queue by a consuming component, but
        /// have not yet been deleted from the queue. If you reach the 120,000 limit, you will
        /// receive an OverLimit error message from Amazon SQS. To help avoid reaching the limit,
        /// you should       delete the messages from the queue after they have been processed.
        /// You can also increase the number of queues you use to process the messages.    
        /// </para>
        /// </note>    <important>If you attempt to set the <code>VisibilityTimeout</code> to
        /// an      amount more than the maximum time left, Amazon SQS returns an error. It will
        ///      not automatically recalculate and increase the timeout to the maximum time  
        ///    remaining.</important>    <important>Unlike with a queue, when you change the visibility
        /// timeout for a      specific message, that timeout value is applied immediately but
        /// is not saved in      memory for that message. If you don't delete a message after
        /// it is received,      the visibility timeout for the message the next time it is received
        /// reverts to      the original timeout value, not the value you set with the      <code>ChangeMessageVisibility</code>
        /// action.</important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility service method.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibility service method, as returned by SQS.</returns>
        /// <exception cref="MessageNotInflightException">
        /// The message referred to is not in flight.
        /// </exception>
        /// <exception cref="ReceiptHandleIsInvalidException">
        /// The receipt handle provided is not valid.
        /// </exception>
        ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibility operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Changes the visibility timeout of multiple messages.      This is a batch version
        /// of <a>ChangeMessageVisibility</a>. The      result of the action on each message is
        /// reported individually in the      response. You can send up to 10 <a>ChangeMessageVisibility</a>
        /// requests with each <code>ChangeMessageVisibilityBatch</code> action.
        /// 
        ///        <important>Because the batch request can result in a combination of successful
        /// and unsuccessful actions,     you should check for batch errors even when the call
        /// returns an HTTP status code of 200.</important>    <note>Some API actions take lists
        /// of parameters. These lists are specified using the <code>param.n</code> notation.
        /// Values      of <code>n</code> are integers starting from 1. For example, a parameter
        /// list with two elements looks like this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="entries">A list of receipt handles of the messages for which the visibility timeout   must be changed.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by SQS.</returns>
        /// <exception cref="BatchEntryIdsNotDistinctException">
        /// Two or more batch entries have the same <code>Id</code> in the request.
        /// </exception>
        /// <exception cref="EmptyBatchRequestException">
        /// Batch request does not contain an entry.
        /// </exception>
        /// <exception cref="InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request does not abide      by the
        /// specification.
        /// </exception>
        /// <exception cref="TooManyEntriesInBatchRequestException">
        /// Batch request contains more number of entries than permissible.
        /// </exception>
        ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(string queueUrl, List<ChangeMessageVisibilityBatchRequestEntry> entries);

        /// <summary>
        /// Changes the visibility timeout of multiple messages.      This is a batch version
        /// of <a>ChangeMessageVisibility</a>. The      result of the action on each message is
        /// reported individually in the      response. You can send up to 10 <a>ChangeMessageVisibility</a>
        /// requests with each <code>ChangeMessageVisibilityBatch</code> action.
        /// 
        ///        <important>Because the batch request can result in a combination of successful
        /// and unsuccessful actions,     you should check for batch errors even when the call
        /// returns an HTTP status code of 200.</important>    <note>Some API actions take lists
        /// of parameters. These lists are specified using the <code>param.n</code> notation.
        /// Values      of <code>n</code> are integers starting from 1. For example, a parameter
        /// list with two elements looks like this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch service method.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by SQS.</returns>
        /// <exception cref="BatchEntryIdsNotDistinctException">
        /// Two or more batch entries have the same <code>Id</code> in the request.
        /// </exception>
        /// <exception cref="EmptyBatchRequestException">
        /// Batch request does not contain an entry.
        /// </exception>
        /// <exception cref="InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request does not abide      by the
        /// specification.
        /// </exception>
        /// <exception cref="TooManyEntriesInBatchRequestException">
        /// Batch request contains more number of entries than permissible.
        /// </exception>
        ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibilityBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Creates a new queue, or returns the URL      of an existing one. When you request
        /// <code>CreateQueue</code>, you provide a      name for the queue. To successfully create
        /// a new queue, you must provide a name      that is unique within the scope of your
        /// own queues.
        /// 
        ///         <note>      
        /// <para>
        /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
        /// the        same name.
        /// </para>
        ///           </note>    
        /// <para>
        /// You may pass one or more attributes in the request. If you do not      provide a value
        /// for any attribute, the queue will have the default value      for that attribute.
        /// Permitted attributes are the same that can be set      using <a>SetQueueAttributes</a>.
        /// </para>
        ///         <note>
        /// <para>
        /// Use <a>GetQueueUrl</a> to get a queue's URL.      <a>GetQueueUrl</a> requires only
        /// the <code>QueueName</code> parameter.
        /// </para>
        /// </note>        
        /// <para>
        /// If you provide the name of an existing queue, along with the exact names and values
        /// of all the queue's attributes,      <code>CreateQueue</code> returns the queue URL
        /// for the existing queue. If the queue name, attribute names,       or attribute values
        /// do not match an existing queue, <code>CreateQueue</code> returns an error.
        /// </para>
        ///         <note>Some API actions take lists of parameters. These lists are specified
        /// using the <code>param.n</code> notation. Values      of <code>n</code> are integers
        /// starting from 1. For example, a parameter list with two elements looks like this:
        ///     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="queueName">The name for the queue to be created.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by SQS.</returns>
        /// <exception cref="QueueDeletedRecentlyException">
        /// You must wait 60 seconds after deleting a queue before you can create another    
        ///  with the same name.
        /// </exception>
        /// <exception cref="QueueNameExistsException">
        /// A queue already exists with this name. Amazon SQS returns this error only if the request
        /// includes      attributes whose values differ from those of the existing queue.
        /// </exception>
        CreateQueueResponse CreateQueue(string queueName);

        /// <summary>
        /// Creates a new queue, or returns the URL      of an existing one. When you request
        /// <code>CreateQueue</code>, you provide a      name for the queue. To successfully create
        /// a new queue, you must provide a name      that is unique within the scope of your
        /// own queues.
        /// 
        ///         <note>      
        /// <para>
        /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
        /// the        same name.
        /// </para>
        ///           </note>    
        /// <para>
        /// You may pass one or more attributes in the request. If you do not      provide a value
        /// for any attribute, the queue will have the default value      for that attribute.
        /// Permitted attributes are the same that can be set      using <a>SetQueueAttributes</a>.
        /// </para>
        ///         <note>
        /// <para>
        /// Use <a>GetQueueUrl</a> to get a queue's URL.      <a>GetQueueUrl</a> requires only
        /// the <code>QueueName</code> parameter.
        /// </para>
        /// </note>        
        /// <para>
        /// If you provide the name of an existing queue, along with the exact names and values
        /// of all the queue's attributes,      <code>CreateQueue</code> returns the queue URL
        /// for the existing queue. If the queue name, attribute names,       or attribute values
        /// do not match an existing queue, <code>CreateQueue</code> returns an error.
        /// </para>
        ///         <note>Some API actions take lists of parameters. These lists are specified
        /// using the <code>param.n</code> notation. Values      of <code>n</code> are integers
        /// starting from 1. For example, a parameter list with two elements looks like this:
        ///     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by SQS.</returns>
        /// <exception cref="QueueDeletedRecentlyException">
        /// You must wait 60 seconds after deleting a queue before you can create another    
        ///  with the same name.
        /// </exception>
        /// <exception cref="QueueNameExistsException">
        /// A queue already exists with this name. Amazon SQS returns this error only if the request
        /// includes      attributes whose values differ from those of the existing queue.
        /// </exception>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Deletes the specified message from the specified      queue. You specify the
        /// message by using the message's <code>receipt        handle</code> and not the <code>message
        /// ID</code> you received when you      sent the message. Even if the message is locked
        /// by another reader due to the visibility      timeout setting, it is still deleted
        /// from the queue. If you leave a message in the queue      for longer than the queue's
        /// configured retention period, Amazon SQS automatically deletes      it.        
        /// 
        ///     <note>      
        /// <para>
        ///         The receipt handle is associated with a specific instance of receiving the
        /// message. If        you receive a message more than once, the receipt handle you get
        /// each time you receive the        message is different. When you request <code>DeleteMessage</code>,
        /// if you don't        provide the most recently received receipt handle for the message,
        /// the request will still        succeed, but the message might not be deleted.     
        /// 
        /// </para>
        ///     </note>    <important>    
        /// <para>
        ///       It is possible you will receive a message even after you have deleted it. This
        /// might      happen on rare occasions if one of the servers storing a copy of the message
        /// is unavailable      when you request to delete the message. The copy remains on the
        /// server and might be returned      to you again on a subsequent receive request. You
        /// should create your system to be idempotent      so that receiving a particular message
        /// more than once is not a problem.    
        /// </para>
        ///     </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message to delete.</param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by SQS.</returns>
        /// <exception cref="InvalidIdFormatException">
        /// The receipt handle is not valid for the current version.
        /// </exception>
        /// <exception cref="ReceiptHandleIsInvalidException">
        /// The receipt handle provided is not valid.
        /// </exception>
        DeleteMessageResponse DeleteMessage(string queueUrl, string receiptHandle);

        /// <summary>
        /// Deletes the specified message from the specified      queue. You specify the
        /// message by using the message's <code>receipt        handle</code> and not the <code>message
        /// ID</code> you received when you      sent the message. Even if the message is locked
        /// by another reader due to the visibility      timeout setting, it is still deleted
        /// from the queue. If you leave a message in the queue      for longer than the queue's
        /// configured retention period, Amazon SQS automatically deletes      it.        
        /// 
        ///     <note>      
        /// <para>
        ///         The receipt handle is associated with a specific instance of receiving the
        /// message. If        you receive a message more than once, the receipt handle you get
        /// each time you receive the        message is different. When you request <code>DeleteMessage</code>,
        /// if you don't        provide the most recently received receipt handle for the message,
        /// the request will still        succeed, but the message might not be deleted.     
        /// 
        /// </para>
        ///     </note>    <important>    
        /// <para>
        ///       It is possible you will receive a message even after you have deleted it. This
        /// might      happen on rare occasions if one of the servers storing a copy of the message
        /// is unavailable      when you request to delete the message. The copy remains on the
        /// server and might be returned      to you again on a subsequent receive request. You
        /// should create your system to be idempotent      so that receiving a particular message
        /// more than once is not a problem.    
        /// </para>
        ///     </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method.</param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by SQS.</returns>
        /// <exception cref="InvalidIdFormatException">
        /// The receipt handle is not valid for the current version.
        /// </exception>
        /// <exception cref="ReceiptHandleIsInvalidException">
        /// The receipt handle provided is not valid.
        /// </exception>
        DeleteMessageResponse DeleteMessage(DeleteMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Deletes multiple messages.      This is a batch version of <a>DeleteMessage</a>. The
        /// result of the delete      action on each message is reported individually in the response.
        /// 
        ///     <important>      
        /// <para>
        ///         Because the batch request can result in a combination of successful and unsuccessful
        /// actions,         you should check for batch errors even when the call returns an HTTP
        /// status code of 200.      
        /// </para>
        ///     </important>    <note>Some API actions take lists of parameters. These lists are
        /// specified using the <code>param.n</code> notation. Values      of <code>n</code> are
        /// integers starting from 1. For example, a parameter list with two elements looks like
        /// this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="entries">A list of receipt handles for the messages to be deleted.</param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="BatchEntryIdsNotDistinctException">
        /// Two or more batch entries have the same <code>Id</code> in the request.
        /// </exception>
        /// <exception cref="EmptyBatchRequestException">
        /// Batch request does not contain an entry.
        /// </exception>
        /// <exception cref="InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request does not abide      by the
        /// specification.
        /// </exception>
        /// <exception cref="TooManyEntriesInBatchRequestException">
        /// Batch request contains more number of entries than permissible.
        /// </exception>
        DeleteMessageBatchResponse DeleteMessageBatch(string queueUrl, List<DeleteMessageBatchRequestEntry> entries);

        /// <summary>
        /// Deletes multiple messages.      This is a batch version of <a>DeleteMessage</a>. The
        /// result of the delete      action on each message is reported individually in the response.
        /// 
        ///     <important>      
        /// <para>
        ///         Because the batch request can result in a combination of successful and unsuccessful
        /// actions,         you should check for batch errors even when the call returns an HTTP
        /// status code of 200.      
        /// </para>
        ///     </important>    <note>Some API actions take lists of parameters. These lists are
        /// specified using the <code>param.n</code> notation. Values      of <code>n</code> are
        /// integers starting from 1. For example, a parameter list with two elements looks like
        /// this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch service method.</param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="BatchEntryIdsNotDistinctException">
        /// Two or more batch entries have the same <code>Id</code> in the request.
        /// </exception>
        /// <exception cref="EmptyBatchRequestException">
        /// Batch request does not contain an entry.
        /// </exception>
        /// <exception cref="InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request does not abide      by the
        /// specification.
        /// </exception>
        /// <exception cref="TooManyEntriesInBatchRequestException">
        /// Batch request contains more number of entries than permissible.
        /// </exception>
        DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Deletes the queue specified by the <b>queue        URL</b>, regardless of whether
        /// the queue is empty. If the specified queue does not      exist, Amazon SQS returns
        /// a successful response.    
        /// 
        ///     <important>      
        /// <para>
        ///         Use <code>DeleteQueue</code> with care; once you delete your queue, any messages
        ///        in the queue are no longer available.      
        /// </para>
        ///     </important>    
        /// <para>
        ///       When you delete a queue, the deletion process takes up to 60 seconds. Requests
        /// you send      involving that queue during the 60 seconds might succeed. For example,
        /// a      <a>SendMessage</a> request might succeed, but after the 60 seconds, the queue
        /// and      that message you sent no longer exist. Also, when you delete a queue, you
        /// must wait at least 60      seconds before creating a queue with the same name.   
        /// 
        /// </para>
        ///     
        /// <para>
        ///       We reserve the right to delete queues that have had no activity for more than
        /// 30 days. For more      information, see             <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSConcepts.html">How
        ///        Amazon SQS Queues Work</a> in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by SQS.</returns>
        DeleteQueueResponse DeleteQueue(string queueUrl);

        /// <summary>
        /// Deletes the queue specified by the <b>queue        URL</b>, regardless of whether
        /// the queue is empty. If the specified queue does not      exist, Amazon SQS returns
        /// a successful response.    
        /// 
        ///     <important>      
        /// <para>
        ///         Use <code>DeleteQueue</code> with care; once you delete your queue, any messages
        ///        in the queue are no longer available.      
        /// </para>
        ///     </important>    
        /// <para>
        ///       When you delete a queue, the deletion process takes up to 60 seconds. Requests
        /// you send      involving that queue during the 60 seconds might succeed. For example,
        /// a      <a>SendMessage</a> request might succeed, but after the 60 seconds, the queue
        /// and      that message you sent no longer exist. Also, when you delete a queue, you
        /// must wait at least 60      seconds before creating a queue with the same name.   
        /// 
        /// </para>
        ///     
        /// <para>
        ///       We reserve the right to delete queues that have had no activity for more than
        /// 30 days. For more      information, see             <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSConcepts.html">How
        ///        Amazon SQS Queues Work</a> in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by SQS.</returns>
        DeleteQueueResponse DeleteQueue(DeleteQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Gets attributes for the specified queue. The following attributes are supported: 
        ///     <ul>        <li><code>All</code> - returns all values.</li>        <li><code>ApproximateNumberOfMessages</code>
        /// - returns the approximate          number of visible messages in a queue. For more
        /// information, see          <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
        /// Required to Process Messages</a>          in the <i>Amazon SQS Developer Guide</i>.</li>
        ///        <li><code>ApproximateNumberOfMessagesNotVisible</code> - returns the      
        ///    approximate number of messages that are not timed-out and not deleted.        
        ///   For more information, see           <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
        /// Required to Process Messages</a> in the          <i>Amazon SQS Developer Guide</i>.</li>
        ///        <li><code>VisibilityTimeout</code> - returns the visibility timeout for   
        ///       the queue. For more information about visibility timeout, see          <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.</li>        <li><code>CreatedTimestamp</code>
        /// - returns the time when the queue was          created (epoch time in seconds).</li>
        ///        <li><code>LastModifiedTimestamp</code> - returns the time when the queue  
        ///        was last changed (epoch time in seconds).</li>        <li><code>Policy</code>
        /// - returns the queue's policy.</li>        <li><code>MaximumMessageSize</code> - returns
        /// the limit of how many bytes          a message can contain before Amazon SQS rejects
        /// it.</li>        <li><code>MessageRetentionPeriod</code> - returns the number of seconds
        ///          Amazon SQS retains a message.</li>        <li><code>QueueArn</code> - returns
        /// the queue's Amazon resource name          (ARN).</li>        <li><code>ApproximateNumberOfMessagesDelayed</code>
        /// - returns the          approximate number of messages that are pending to be added
        /// to the          queue.</li>        <li><code>DelaySeconds</code> - returns the default
        /// delay on the queue          in seconds.</li>        <li><code>ReceiveMessageWaitTimeSeconds</code>
        /// - returns the time for which a        ReceiveMessage call will wait for a message
        /// to arrive.</li>        <li><code>RedrivePolicy</code> - returns the parameters for
        /// dead letter queue functionality of the source queue.           For more information
        /// about RedrivePolicy and dead letter queues, see          <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using
        /// Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.</li> 
        ///     </ul>     
        /// 
        ///     <note>Going forward, new attributes might be added.       If you are writing code
        /// that calls this action, we recommend that you structure your code so that it can handle
        /// new attributes gracefully.</note>    <note>Some API actions take lists of parameters.
        /// These lists are specified using the <code>param.n</code> notation. Values      of
        /// <code>n</code> are integers starting from 1. For example, a parameter list with two
        /// elements looks like this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="attributeNames">A list of attributes to retrieve information for. </param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="InvalidAttributeNameException">
        /// The attribute referred to does not exist.
        /// </exception>
        GetQueueAttributesResponse GetQueueAttributes(string queueUrl, List<string> attributeNames);

        /// <summary>
        /// Gets attributes for the specified queue. The following attributes are supported: 
        ///     <ul>        <li><code>All</code> - returns all values.</li>        <li><code>ApproximateNumberOfMessages</code>
        /// - returns the approximate          number of visible messages in a queue. For more
        /// information, see          <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
        /// Required to Process Messages</a>          in the <i>Amazon SQS Developer Guide</i>.</li>
        ///        <li><code>ApproximateNumberOfMessagesNotVisible</code> - returns the      
        ///    approximate number of messages that are not timed-out and not deleted.        
        ///   For more information, see           <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
        /// Required to Process Messages</a> in the          <i>Amazon SQS Developer Guide</i>.</li>
        ///        <li><code>VisibilityTimeout</code> - returns the visibility timeout for   
        ///       the queue. For more information about visibility timeout, see          <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.</li>        <li><code>CreatedTimestamp</code>
        /// - returns the time when the queue was          created (epoch time in seconds).</li>
        ///        <li><code>LastModifiedTimestamp</code> - returns the time when the queue  
        ///        was last changed (epoch time in seconds).</li>        <li><code>Policy</code>
        /// - returns the queue's policy.</li>        <li><code>MaximumMessageSize</code> - returns
        /// the limit of how many bytes          a message can contain before Amazon SQS rejects
        /// it.</li>        <li><code>MessageRetentionPeriod</code> - returns the number of seconds
        ///          Amazon SQS retains a message.</li>        <li><code>QueueArn</code> - returns
        /// the queue's Amazon resource name          (ARN).</li>        <li><code>ApproximateNumberOfMessagesDelayed</code>
        /// - returns the          approximate number of messages that are pending to be added
        /// to the          queue.</li>        <li><code>DelaySeconds</code> - returns the default
        /// delay on the queue          in seconds.</li>        <li><code>ReceiveMessageWaitTimeSeconds</code>
        /// - returns the time for which a        ReceiveMessage call will wait for a message
        /// to arrive.</li>        <li><code>RedrivePolicy</code> - returns the parameters for
        /// dead letter queue functionality of the source queue.           For more information
        /// about RedrivePolicy and dead letter queues, see          <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using
        /// Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.</li> 
        ///     </ul>     
        /// 
        ///     <note>Going forward, new attributes might be added.       If you are writing code
        /// that calls this action, we recommend that you structure your code so that it can handle
        /// new attributes gracefully.</note>    <note>Some API actions take lists of parameters.
        /// These lists are specified using the <code>param.n</code> notation. Values      of
        /// <code>n</code> are integers starting from 1. For example, a parameter list with two
        /// elements looks like this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes service method.</param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="InvalidAttributeNameException">
        /// The attribute referred to does not exist.
        /// </exception>
        GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Returns the URL of an existing queue.       This action provides a simple way
        /// to retrieve the URL of an Amazon SQS queue.    
        /// 
        ///     
        /// <para>
        ///       To access a queue that belongs to another AWS account, use the <code>QueueOwnerAWSAccountId</code>
        ///      parameter to specify the account ID of the queue's owner. The queue's owner must
        /// grant you permission to       access the queue. For more information about shared
        /// queue access, see <a>AddPermission</a> or go to      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared
        /// Queues</a>      in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        /// </summary>
        /// <param name="queueName">The name of the queue whose URL must be fetched.    Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.</param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by SQS.</returns>
        /// <exception cref="QueueDoesNotExistException">
        /// The queue referred to does not exist.
        /// </exception>
        GetQueueUrlResponse GetQueueUrl(string queueName);

        /// <summary>
        /// Returns the URL of an existing queue.       This action provides a simple way
        /// to retrieve the URL of an Amazon SQS queue.    
        /// 
        ///     
        /// <para>
        ///       To access a queue that belongs to another AWS account, use the <code>QueueOwnerAWSAccountId</code>
        ///      parameter to specify the account ID of the queue's owner. The queue's owner must
        /// grant you permission to       access the queue. For more information about shared
        /// queue access, see <a>AddPermission</a> or go to      <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared
        /// Queues</a>      in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl service method.</param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by SQS.</returns>
        /// <exception cref="QueueDoesNotExistException">
        /// The queue referred to does not exist.
        /// </exception>
        GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueUrl operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Returns a list of your queues that have the RedrivePolicy queue attribute configured
        /// with a dead letter queue.
        /// 
        ///             
        /// <para>
        /// For more information about using dead letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using
        /// Amazon SQS Dead Letter Queues</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues service method.</param>
        /// 
        /// <returns>The response from the ListDeadLetterSourceQueues service method, as returned by SQS.</returns>
        /// <exception cref="QueueDoesNotExistException">
        /// The queue referred to does not exist.
        /// </exception>
        ListDeadLetterSourceQueuesResponse ListDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeadLetterSourceQueues operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Returns a list of your queues. The maximum number of      queues that can be returned
        /// is 1000. If you specify a value for the optional      <code>QueueNamePrefix</code>
        /// parameter, only queues with a name beginning with the      specified value are returned.
        /// </summary>
        /// <param name="queueNamePrefix">A string to use for filtering the list results. Only those queues whose name   begins with the specified string are returned.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by SQS.</returns>
        ListQueuesResponse ListQueues(string queueNamePrefix);

        /// <summary>
        /// Returns a list of your queues. The maximum number of      queues that can be returned
        /// is 1000. If you specify a value for the optional      <code>QueueNamePrefix</code>
        /// parameter, only queues with a name beginning with the      specified value are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by SQS.</returns>
        ListQueuesResponse ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReceiveMessage

        /// <summary>
        /// Retrieves one or more messages, with a maximum limit of 10 messages, from the
        /// specified      queue. Long poll support is enabled by using the <code>WaitTimeSeconds</code>
        /// parameter.       For more information, see       <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Poll</a> in the <i>Amazon SQS Developer Guide</i>.    
        /// 
        ///     
        /// <para>
        ///       Short poll is the default behavior where a weighted random set of machines is
        /// sampled on a <code>ReceiveMessage</code> call.       This means only the messages
        /// on the sampled machines are returned. If the number of messages in the queue is small
        /// (less than 1000),       it is likely you will get fewer messages than you requested
        /// per <code>ReceiveMessage</code> call.       If the number of messages in the queue
        /// is extremely small, you might not receive any messages in      a particular <code>ReceiveMessage</code>
        /// response; in which case you should repeat the      request.    
        /// </para>
        ///     
        /// <para>
        ///       For each message returned, the response includes the following:    
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        ///           Message body        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           MD5 digest of the message body. For information about MD5, go to       
        ///    <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        ///        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           Message ID you received when you sent the message to the queue.        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           Receipt handle.        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           Message attributes.        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           MD5 digest of the message attributes.        
        /// </para>
        ///       </li>    </ul>    
        /// <para>
        ///       The receipt handle is the identifier you must provide when deleting the message.
        /// For more      information, see             <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ImportantIdentifiers.html">Queue
        ///        and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        ///     
        /// <para>
        ///       You can provide the <code>VisibilityTimeout</code> parameter in your request,
        /// which      will be applied to the messages that Amazon SQS returns in the response.
        /// If you do not include the      parameter, the overall visibility timeout for the queue
        /// is used for the returned messages. For      more information, see       <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        ///        Timeout</a> in the <i>Amazon SQS Developer Guide</i>.          
        /// </para>
        ///     <note>      
        /// <para>
        ///         Going forward, new attributes might be added. If you are writing code that
        /// calls this action,        we recommend that you structure your code so that it can
        /// handle new attributes gracefully.      
        /// </para>
        ///     </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by SQS.</returns>
        /// <exception cref="OverLimitException">
        /// The action that you requested would violate a limit. For example,      ReceiveMessage
        /// returns this error if the maximum number of messages      inflight has already been
        /// reached. <a>AddPermission</a> returns this error if      the maximum number of permissions
        /// for the queue has already been reached.
        /// </exception>
        ReceiveMessageResponse ReceiveMessage(string queueUrl);

        /// <summary>
        /// Retrieves one or more messages, with a maximum limit of 10 messages, from the
        /// specified      queue. Long poll support is enabled by using the <code>WaitTimeSeconds</code>
        /// parameter.       For more information, see       <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Poll</a> in the <i>Amazon SQS Developer Guide</i>.    
        /// 
        ///     
        /// <para>
        ///       Short poll is the default behavior where a weighted random set of machines is
        /// sampled on a <code>ReceiveMessage</code> call.       This means only the messages
        /// on the sampled machines are returned. If the number of messages in the queue is small
        /// (less than 1000),       it is likely you will get fewer messages than you requested
        /// per <code>ReceiveMessage</code> call.       If the number of messages in the queue
        /// is extremely small, you might not receive any messages in      a particular <code>ReceiveMessage</code>
        /// response; in which case you should repeat the      request.    
        /// </para>
        ///     
        /// <para>
        ///       For each message returned, the response includes the following:    
        /// </para>
        ///     <ul>      <li>        
        /// <para>
        ///           Message body        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           MD5 digest of the message body. For information about MD5, go to       
        ///    <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        ///        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           Message ID you received when you sent the message to the queue.        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           Receipt handle.        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           Message attributes.        
        /// </para>
        ///       </li>      <li>        
        /// <para>
        ///           MD5 digest of the message attributes.        
        /// </para>
        ///       </li>    </ul>    
        /// <para>
        ///       The receipt handle is the identifier you must provide when deleting the message.
        /// For more      information, see             <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ImportantIdentifiers.html">Queue
        ///        and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.    
        /// </para>
        ///     
        /// <para>
        ///       You can provide the <code>VisibilityTimeout</code> parameter in your request,
        /// which      will be applied to the messages that Amazon SQS returns in the response.
        /// If you do not include the      parameter, the overall visibility timeout for the queue
        /// is used for the returned messages. For      more information, see       <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
        ///        Timeout</a> in the <i>Amazon SQS Developer Guide</i>.          
        /// </para>
        ///     <note>      
        /// <para>
        ///         Going forward, new attributes might be added. If you are writing code that
        /// calls this action,        we recommend that you structure your code so that it can
        /// handle new attributes gracefully.      
        /// </para>
        ///     </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage service method.</param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by SQS.</returns>
        /// <exception cref="OverLimitException">
        /// The action that you requested would violate a limit. For example,      ReceiveMessage
        /// returns this error if the maximum number of messages      inflight has already been
        /// reached. <a>AddPermission</a> returns this error if      the maximum number of permissions
        /// for the queue has already been reached.
        /// </exception>
        ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReceiveMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Revokes any permissions in the queue      policy that matches the specified <code>Label</code>
        /// parameter. Only the owner      of the queue can remove permissions.
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="label">The identification of the permission to remove. This is the label added with   the <a>AddPermission</a> action.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SQS.</returns>
        RemovePermissionResponse RemovePermission(string queueUrl, string label);

        /// <summary>
        /// Revokes any permissions in the queue      policy that matches the specified <code>Label</code>
        /// parameter. Only the owner      of the queue can remove permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SQS.</returns>
        RemovePermissionResponse RemovePermission(RemovePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Delivers a message to the specified      queue. With Amazon SQS, you now have
        /// the ability to send large payload messages that are up      to 256KB (262,144 bytes)
        /// in size. To send large payloads, you must use an AWS SDK that      supports SigV4
        /// signing. To verify whether SigV4 is supported for an AWS SDK, check the SDK      release
        /// notes.    
        /// 
        ///     <important>      
        /// <para>
        ///         The following list shows the characters (in Unicode) allowed in your message,
        /// according        to the W3C XML specification. For more information, go to       
        ///         <a href="http://www.w3.org/TR/REC-xml/#charsets">http://www.w3.org/TR/REC-xml/#charsets</a>
        ///                If you send any characters not included in the list, your request will
        /// be rejected.      
        /// </para>
        ///       
        /// <para>
        ///         #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
        ///      
        /// </para>
        ///     </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="messageBody">The message to send. String maximum 256 KB in size. For a list of allowed characters, see the preceding important note.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by SQS.</returns>
        /// <exception cref="InvalidMessageContentsException">
        /// The message contains characters outside the allowed set.
        /// </exception>
        /// <exception cref="UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        SendMessageResponse SendMessage(string queueUrl, string messageBody);

        /// <summary>
        /// Delivers a message to the specified      queue. With Amazon SQS, you now have
        /// the ability to send large payload messages that are up      to 256KB (262,144 bytes)
        /// in size. To send large payloads, you must use an AWS SDK that      supports SigV4
        /// signing. To verify whether SigV4 is supported for an AWS SDK, check the SDK      release
        /// notes.    
        /// 
        ///     <important>      
        /// <para>
        ///         The following list shows the characters (in Unicode) allowed in your message,
        /// according        to the W3C XML specification. For more information, go to       
        ///         <a href="http://www.w3.org/TR/REC-xml/#charsets">http://www.w3.org/TR/REC-xml/#charsets</a>
        ///                If you send any characters not included in the list, your request will
        /// be rejected.      
        /// </para>
        ///       
        /// <para>
        ///         #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
        ///      
        /// </para>
        ///     </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by SQS.</returns>
        /// <exception cref="InvalidMessageContentsException">
        /// The message contains characters outside the allowed set.
        /// </exception>
        /// <exception cref="UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        SendMessageResponse SendMessage(SendMessageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Delivers up to ten messages to the specified queue.      This is a batch version of
        /// <a>SendMessage</a>.      The result of the send action on each message is reported
        /// individually in the response.      The maximum allowed individual message size is
        /// 256 KB (262,144 bytes).
        /// 
        ///     
        /// <para>
        /// The maximum total payload size (i.e., the sum of all a batch's individual message
        /// lengths)      is also 256 KB (262,144 bytes).
        /// </para>
        ///     
        /// <para>
        /// If the <code>DelaySeconds</code> parameter is not specified for an entry,     the
        /// default for the queue is used.
        /// </para>
        ///     <important>The following list shows the characters (in Unicode) that are allowed
        /// in your message, according      to the W3C XML specification. For more information,
        /// go to <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        ///       If you send any characters that are not included in the list, your request will
        /// be rejected.      
        /// <para>
        /// #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
        /// </para>
        ///     </important>    <important>      Because the batch request can result in a combination
        /// of successful and unsuccessful actions,       you should check for batch errors even
        /// when the call returns an HTTP status code of 200.     </important>    <note>Some API
        /// actions take lists of parameters. These lists are specified using the <code>param.n</code>
        /// notation. Values      of <code>n</code> are integers starting from 1. For example,
        /// a parameter list with two elements looks like this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="entries">A list of <a>SendMessageBatchRequestEntry</a> items.</param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="BatchEntryIdsNotDistinctException">
        /// Two or more batch entries have the same <code>Id</code> in the request.
        /// </exception>
        /// <exception cref="BatchRequestTooLongException">
        /// The length of all the messages put together is more than the limit.
        /// </exception>
        /// <exception cref="EmptyBatchRequestException">
        /// Batch request does not contain an entry.
        /// </exception>
        /// <exception cref="InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request does not abide      by the
        /// specification.
        /// </exception>
        /// <exception cref="TooManyEntriesInBatchRequestException">
        /// Batch request contains more number of entries than permissible.
        /// </exception>
        /// <exception cref="UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        SendMessageBatchResponse SendMessageBatch(string queueUrl, List<SendMessageBatchRequestEntry> entries);

        /// <summary>
        /// Delivers up to ten messages to the specified queue.      This is a batch version of
        /// <a>SendMessage</a>.      The result of the send action on each message is reported
        /// individually in the response.      The maximum allowed individual message size is
        /// 256 KB (262,144 bytes).
        /// 
        ///     
        /// <para>
        /// The maximum total payload size (i.e., the sum of all a batch's individual message
        /// lengths)      is also 256 KB (262,144 bytes).
        /// </para>
        ///     
        /// <para>
        /// If the <code>DelaySeconds</code> parameter is not specified for an entry,     the
        /// default for the queue is used.
        /// </para>
        ///     <important>The following list shows the characters (in Unicode) that are allowed
        /// in your message, according      to the W3C XML specification. For more information,
        /// go to <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a>.
        ///       If you send any characters that are not included in the list, your request will
        /// be rejected.      
        /// <para>
        /// #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF]
        /// </para>
        ///     </important>    <important>      Because the batch request can result in a combination
        /// of successful and unsuccessful actions,       you should check for batch errors even
        /// when the call returns an HTTP status code of 200.     </important>    <note>Some API
        /// actions take lists of parameters. These lists are specified using the <code>param.n</code>
        /// notation. Values      of <code>n</code> are integers starting from 1. For example,
        /// a parameter list with two elements looks like this:     </note>    
        /// <para>
        /// <code>&amp;Attribute.1=this</code>
        /// </para>
        ///     
        /// <para>
        /// <code>&amp;Attribute.2=that</code>
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch service method.</param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="BatchEntryIdsNotDistinctException">
        /// Two or more batch entries have the same <code>Id</code> in the request.
        /// </exception>
        /// <exception cref="BatchRequestTooLongException">
        /// The length of all the messages put together is more than the limit.
        /// </exception>
        /// <exception cref="EmptyBatchRequestException">
        /// Batch request does not contain an entry.
        /// </exception>
        /// <exception cref="InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request does not abide      by the
        /// specification.
        /// </exception>
        /// <exception cref="TooManyEntriesInBatchRequestException">
        /// Batch request contains more number of entries than permissible.
        /// </exception>
        /// <exception cref="UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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
        /// Sets the value of one or more queue attributes. When you change a queue's attributes,
        ///       the change can take up to 60 seconds for most of the attributes to propagate
        /// throughout the SQS system.       Changes made to the <code>MessageRetentionPeriod</code>
        /// attribute can take up to 15 minutes.
        /// 
        ///     <note>Going forward, new attributes might be added.     If you are writing code
        /// that calls this action, we recommend that you structure your code so that it can handle
        /// new attributes gracefully.</note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters the <code>SetQueueAttributes</code>   action uses:    <ul>    <li><code>DelaySeconds</code> - The time in seconds that the delivery of all messages in the queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 (zero).</li>      <li><code>MaximumMessageSize</code> - The limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this attribute is 262144 (256 KiB).</li>  <li><code>MessageRetentionPeriod</code> - The number of seconds Amazon SQS retains a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</li>  <li><code>Policy</code> - The queue's policy. A valid    form-url-encoded policy. For more information about policy    structure, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/BasicStructure.html">Basic Policy Structure</a> in the <i>Amazon SQS Developer Guide</i>.     For more information about form-url-encoding, see     <a href="http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1">http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1</a>.</li>      <li><code>ReceiveMessageWaitTimeSeconds</code> - The time for which a ReceiveMessage call will wait for a message to arrive. An integer from 0 to 20 (seconds). The default for this attribute is 0. </li>  <li><code>VisibilityTimeout</code> - The visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see Visibility Timeout in the <i>Amazon SQS Developer Guide</i>.</li>  <li><code>RedrivePolicy</code> - The parameters for dead letter queue functionality of the source queue.     For more information about RedrivePolicy and dead letter queues, see Using Amazon SQS Dead Letter Queues in the <i>Amazon SQS Developer Guide</i>.</li>   </ul> </param>
        /// 
        /// <returns>The response from the SetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="InvalidAttributeNameException">
        /// The attribute referred to does not exist.
        /// </exception>
        SetQueueAttributesResponse SetQueueAttributes(string queueUrl, Dictionary<string, string> attributes);

        /// <summary>
        /// Sets the value of one or more queue attributes. When you change a queue's attributes,
        ///       the change can take up to 60 seconds for most of the attributes to propagate
        /// throughout the SQS system.       Changes made to the <code>MessageRetentionPeriod</code>
        /// attribute can take up to 15 minutes.
        /// 
        ///     <note>Going forward, new attributes might be added.     If you are writing code
        /// that calls this action, we recommend that you structure your code so that it can handle
        /// new attributes gracefully.</note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes service method.</param>
        /// 
        /// <returns>The response from the SetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="InvalidAttributeNameException">
        /// The attribute referred to does not exist.
        /// </exception>
        SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS"/>
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