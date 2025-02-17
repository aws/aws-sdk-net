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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the ReceiveMessage operation.
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
    public partial class ReceiveMessageRequest : AmazonSQSRequest
    {
        private List<string> _attributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxNumberOfMessages;
        private List<string> _messageAttributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _messageSystemAttributeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _queueUrl;
        private string _receiveRequestAttemptId;
        private int? _visibilityTimeout;
        private int? _waitTimeSeconds;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ReceiveMessageRequest() { }

        /// <summary>
        /// Instantiates ReceiveMessageRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are received. Queue URLs and names are case-sensitive.</param>
        public ReceiveMessageRequest(string queueUrl)
        {
            _queueUrl = queueUrl;
        }

        /// <summary>
        /// Gets and sets the property AttributeNames. <important> 
        /// <para>
        /// This parameter has been discontinued but will be supported for backward compatibility.
        /// To provide attribute names, you are encouraged to use <c>MessageSystemAttributeNames</c>.
        /// 
        /// </para>
        ///  </important> 
        /// <para>
        /// A list of attributes that need to be returned along with each message. These attributes
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>All</c> – Returns all values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateFirstReceiveTimestamp</c> – Returns the time the message was first
        /// received from the queue (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>
        /// in milliseconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateReceiveCount</c> – Returns the number of times a message has been received
        /// across all queues but not deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSTraceHeader</c> – Returns the X-Ray trace header string. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SenderId</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a user, returns the user ID, for example <c>ABCDEFGHI1JKLMNOPQ23R</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an IAM role, returns the IAM role ID, for example <c>ABCDE1F2GH3I4JK5LMNOP:i-a123b456</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SentTimestamp</c> – Returns the time the message was sent to the queue (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch
        /// time</a> in milliseconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SqsManagedSseEnabled</c> – Enables server-side queue encryption using SQS owned
        /// encryption keys. Only one server-side encryption option is supported per queue (for
        /// example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a>
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageDeduplicationId</c> – Returns the value provided by the producer that calls
        /// the <c> <a>SendMessage</a> </c> action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageGroupId</c> – Returns the value provided by the producer that calls the
        /// <c> <a>SendMessage</a> </c> action. Messages with the same <c>MessageGroupId</c> are
        /// returned in sequence.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SequenceNumber</c> – Returns the value provided by Amazon SQS.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [Obsolete("AttributeNames has been replaced by MessageSystemAttributeNames")]
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && (this._attributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxNumberOfMessages. 
        /// <para>
        /// The maximum number of messages to return. Amazon SQS never returns more messages than
        /// this value (however, fewer messages might be returned). Valid values: 1 to 10. Default:
        /// 1.
        /// </para>
        /// </summary>
        public int MaxNumberOfMessages
        {
            get { return this._maxNumberOfMessages.GetValueOrDefault(); }
            set { this._maxNumberOfMessages = value; }
        }

        // Check to see if MaxNumberOfMessages property is set
        internal bool IsSetMaxNumberOfMessages()
        {
            return this._maxNumberOfMessages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageAttributeNames. 
        /// <para>
        /// The name of the message attribute, where <i>N</i> is the index.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name can contain alphanumeric characters and the underscore (<c>_</c>), hyphen
        /// (<c>-</c>), and period (<c>.</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name is case-sensitive and must be unique among all attribute names for the message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name must not start with AWS-reserved prefixes such as <c>AWS.</c> or <c>Amazon.</c>
        /// (or any casing variants).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name must not start or end with a period (<c>.</c>), and it should not have periods
        /// in succession (<c>..</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The name can be up to 256 characters long.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When using <c>ReceiveMessage</c>, you can send a list of attribute names to receive,
        /// or you can return all of the attributes by specifying <c>All</c> or <c>.*</c> in your
        /// request. You can also use all message attributes starting with a prefix, for example
        /// <c>bar.*</c>.
        /// </para>
        /// </summary>
        public List<string> MessageAttributeNames
        {
            get { return this._messageAttributeNames; }
            set { this._messageAttributeNames = value; }
        }

        // Check to see if MessageAttributeNames property is set
        internal bool IsSetMessageAttributeNames()
        {
            return this._messageAttributeNames != null && (this._messageAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageSystemAttributeNames. 
        /// <para>
        /// A list of attributes that need to be returned along with each message. These attributes
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>All</c> – Returns all values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateFirstReceiveTimestamp</c> – Returns the time the message was first
        /// received from the queue (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>
        /// in milliseconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApproximateReceiveCount</c> – Returns the number of times a message has been received
        /// across all queues but not deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWSTraceHeader</c> – Returns the X-Ray trace header string. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SenderId</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For a user, returns the user ID, for example <c>ABCDEFGHI1JKLMNOPQ23R</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an IAM role, returns the IAM role ID, for example <c>ABCDE1F2GH3I4JK5LMNOP:i-a123b456</c>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SentTimestamp</c> – Returns the time the message was sent to the queue (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch
        /// time</a> in milliseconds).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SqsManagedSseEnabled</c> – Enables server-side queue encryption using SQS owned
        /// encryption keys. Only one server-side encryption option is supported per queue (for
        /// example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a>
        /// or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageDeduplicationId</c> – Returns the value provided by the producer that calls
        /// the <c> <a>SendMessage</a> </c> action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MessageGroupId</c> – Returns the value provided by the producer that calls the
        /// <c> <a>SendMessage</a> </c> action. Messages with the same <c>MessageGroupId</c> are
        /// returned in sequence.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SequenceNumber</c> – Returns the value provided by Amazon SQS.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> MessageSystemAttributeNames
        {
            get { return this._messageSystemAttributeNames; }
            set { this._messageSystemAttributeNames = value; }
        }

        // Check to see if MessageSystemAttributeNames property is set
        internal bool IsSetMessageSystemAttributeNames()
        {
            return this._messageSystemAttributeNames != null && (this._messageSystemAttributeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue from which messages are received.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

        /// <summary>
        /// Gets and sets the property ReceiveRequestAttemptId. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) queues.
        /// </para>
        ///  
        /// <para>
        /// The token used for deduplication of <c>ReceiveMessage</c> calls. If a networking issue
        /// occurs after a <c>ReceiveMessage</c> action, and instead of a response you receive
        /// a generic error, it is possible to retry the same action with an identical <c>ReceiveRequestAttemptId</c>
        /// to retrieve the same set of messages, even if their visibility timeout has not yet
        /// expired.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can use <c>ReceiveRequestAttemptId</c> only for 5 minutes after a <c>ReceiveMessage</c>
        /// action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you set <c>FifoQueue</c>, a caller of the <c>ReceiveMessage</c> action can provide
        /// a <c>ReceiveRequestAttemptId</c> explicitly.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It is possible to retry the <c>ReceiveMessage</c> action with the same <c>ReceiveRequestAttemptId</c>
        /// if none of the messages have been modified (deleted or had their visibility changes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// During a visibility timeout, subsequent calls with the same <c>ReceiveRequestAttemptId</c>
        /// return the same messages and receipt handles. If a retry occurs within the deduplication
        /// interval, it resets the visibility timeout. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a caller of the <c>ReceiveMessage</c> action still processes messages when the
        /// visibility timeout expires and messages become visible, another worker consuming from
        /// the same queue can receive the same messages and therefore process duplicates. Also,
        /// if a consumer whose message processing time is longer than the visibility timeout
        /// tries to delete the processed messages, the action fails with an error.
        /// </para>
        ///  
        /// <para>
        /// To mitigate this effect, ensure that your application observes a safe threshold before
        /// the visibility timeout expires and extend the visibility timeout as necessary.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        /// While messages with a particular <c>MessageGroupId</c> are invisible, no more messages
        /// belonging to the same <c>MessageGroupId</c> are returned until the visibility timeout
        /// expires. You can still receive messages with another <c>MessageGroupId</c> as long
        /// as it is also visible.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a caller of <c>ReceiveMessage</c> can't track the <c>ReceiveRequestAttemptId</c>,
        /// no retries work until the original visibility timeout expires. As a result, delays
        /// might occur but the messages in the queue remain in a strict order.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The maximum length of <c>ReceiveRequestAttemptId</c> is 128 characters. <c>ReceiveRequestAttemptId</c>
        /// can contain alphanumeric characters (<c>a-z</c>, <c>A-Z</c>, <c>0-9</c>) and punctuation
        /// (<c>!"#$%&amp;'()*+,-./:;&lt;=&gt;?@[\]^_`{|}~</c>).
        /// </para>
        ///  
        /// <para>
        /// For best practices of using <c>ReceiveRequestAttemptId</c>, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/using-receiverequestattemptid-request-parameter.html">Using
        /// the ReceiveRequestAttemptId Request Parameter</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        public string ReceiveRequestAttemptId
        {
            get { return this._receiveRequestAttemptId; }
            set { this._receiveRequestAttemptId = value; }
        }

        // Check to see if ReceiveRequestAttemptId property is set
        internal bool IsSetReceiveRequestAttemptId()
        {
            return this._receiveRequestAttemptId != null;
        }

        /// <summary>
        /// Gets and sets the property VisibilityTimeout. 
        /// <para>
        /// The duration (in seconds) that the received messages are hidden from subsequent retrieve
        /// requests after being retrieved by a <c>ReceiveMessage</c> request. If not specified,
        /// the default visibility timeout for the queue is used, which is 30 seconds.
        /// </para>
        ///  
        /// <para>
        /// Understanding <c>VisibilityTimeout</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When a message is received from a queue, it becomes temporarily invisible to other
        /// consumers for the duration of the visibility timeout. This prevents multiple consumers
        /// from processing the same message simultaneously. If the message is not deleted or
        /// its visibility timeout is not extended before the timeout expires, it becomes visible
        /// again and can be retrieved by other consumers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Setting an appropriate visibility timeout is crucial. If it's too short, the message
        /// might become visible again before processing is complete, leading to duplicate processing.
        /// If it's too long, it delays the reprocessing of messages if the initial processing
        /// fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can adjust the visibility timeout using the <c>--visibility-timeout</c> parameter
        /// in the <c>receive-message</c> command to match the processing time required by your
        /// application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A message that isn't deleted or a message whose visibility isn't extended before the
        /// visibility timeout expires counts as a failed receive. Depending on the configuration
        /// of the queue, the message might be sent to the dead-letter queue.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        public int VisibilityTimeout
        {
            get { return this._visibilityTimeout.GetValueOrDefault(); }
            set { this._visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this._visibilityTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WaitTimeSeconds. 
        /// <para>
        /// The duration (in seconds) for which the call waits for a message to arrive in the
        /// queue before returning. If a message is available, the call returns sooner than <c>WaitTimeSeconds</c>.
        /// If no messages are available and the wait time expires, the call does not return a
        /// message list. If you are using the Java SDK, it returns a <c>ReceiveMessageResponse</c>
        /// object, which has a empty list instead of a Null object.
        /// </para>
        ///  <important> 
        /// <para>
        /// To avoid HTTP errors, ensure that the HTTP response timeout for <c>ReceiveMessage</c>
        /// requests is longer than the <c>WaitTimeSeconds</c> parameter. For example, with the
        /// Java SDK, you can set HTTP transport settings using the <a href="https://sdk.amazonaws.com/java/api/latest/software/amazon/awssdk/http/nio/netty/NettyNioAsyncHttpClient.html">
        /// NettyNioAsyncHttpClient</a> for asynchronous clients, or the <a href="https://sdk.amazonaws.com/java/api/latest/software/amazon/awssdk/http/apache/ApacheHttpClient.html">
        /// ApacheHttpClient</a> for synchronous clients. 
        /// </para>
        ///  </important>
        /// </summary>
        public int WaitTimeSeconds
        {
            get { return this._waitTimeSeconds.GetValueOrDefault(); }
            set { this._waitTimeSeconds = value; }
        }

        // Check to see if WaitTimeSeconds property is set
        internal bool IsSetWaitTimeSeconds()
        {
            return this._waitTimeSeconds.HasValue; 
        }

    }
}