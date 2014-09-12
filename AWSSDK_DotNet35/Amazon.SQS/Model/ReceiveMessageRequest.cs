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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the ReceiveMessage operation.
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
    public partial class ReceiveMessageRequest : AmazonSQSRequest
    {
        private List<string> _attributeNames = new List<string>();
        private int? _maxNumberOfMessages;
        private List<string> _messageAttributeNames = new List<string>();
        private string _queueUrl;
        private int? _visibilityTimeout;
        private int? _waitTimeSeconds;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ReceiveMessageRequest() { }

        /// <summary>
        /// Instantiates ReceiveMessageRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        public ReceiveMessageRequest(string queueUrl)
        {
            _queueUrl = queueUrl;
        }

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of attributes that need to be returned along with each message.           
        /// </para>
        ///     
        /// <para>
        ///       The following lists the names and descriptions of the attributes that can be
        /// returned:    
        /// </para>
        ///     <ul>            <li><code>All</code> - returns all values.</li>      <li><code>ApproximateFirstReceiveTimestamp</code>
        /// - returns      the time when the message was first received (epoch time in milliseconds).</li>
        ///      <li><code>ApproximateReceiveCount</code> - returns the        number of times
        /// a message has been received but not deleted.</li>      <li><code>SenderId</code> -
        /// returns the AWS account        number (or the IP address, if anonymous access is allowed)
        /// of the        sender.</li>      <li><code>SentTimestamp</code> - returns the time
        /// when        the message was sent (epoch time in milliseconds).</li>         </ul>
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this._attributeNames; }
            set { this._attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this._attributeNames != null && this._attributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxNumberOfMessages. 
        /// <para>
        /// The maximum number of messages to return. Amazon SQS never returns more      messages
        /// than this value but may return fewer. Values can be from 1 to 10. Default is 1.
        /// </para>
        ///     
        /// <para>
        /// All of the messages are not necessarily returned.
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
        /// The message attribute Name can contain the following characters: A-Z, a-z, 0-9, underscore(_),
        /// hyphen(-), and period (.).       The message attribute name must not start or end
        /// with a period, and it should not have successive periods. The message attribute name
        /// is case sensitive and must be unique among all attribute       names for the message.
        /// The message attribute name can be up to 256 characters long. Attribute names cannot
        /// start with "AWS." or "Amazon." because these prefixes are reserved for use by Amazon
        /// Web Services.
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
            return this._messageAttributeNames != null && this._messageAttributeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to take action on.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VisibilityTimeout. 
        /// <para>
        /// The duration (in seconds) that the received messages are hidden from      subsequent
        /// retrieve requests after being retrieved by a      <code>ReceiveMessage</code> request.
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
        /// The duration (in seconds) for which the call will wait for a message to arrive   
        ///   in the queue before returning.  If a message is available, the call will      return
        /// sooner than WaitTimeSeconds.
        /// </para>
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