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
    /// Container for the parameters to the SetQueueAttributes operation.
    /// Sets the value of one or more queue attributes. When you change a queue's attributes,
    ///       the change can take up to 60 seconds for most of the attributes to propagate
    /// throughout the SQS system.       Changes made to the <code>MessageRetentionPeriod</code>
    /// attribute can take up to 15 minutes.
    /// 
    ///     <note>Going forward, new attributes might be added.     If you are writing code
    /// that calls this action, we recommend that you structure your code so that it can handle
    /// new attributes gracefully.</note>
    /// </summary>
    public partial class SetQueueAttributesRequest : AmazonSQSRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public SetQueueAttributesRequest() { }

        /// <summary>
        /// Instantiates SetQueueAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters the <code>SetQueueAttributes</code>   action uses:    <ul>    <li><code>DelaySeconds</code> - The time in seconds that the delivery of all messages in the queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 (zero).</li>      <li><code>MaximumMessageSize</code> - The limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this attribute is 262144 (256 KiB).</li>  <li><code>MessageRetentionPeriod</code> - The number of seconds Amazon SQS retains a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</li>  <li><code>Policy</code> - The queue's policy. A valid    form-url-encoded policy. For more information about policy    structure, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/BasicStructure.html">Basic Policy Structure</a> in the <i>Amazon SQS Developer Guide</i>.     For more information about form-url-encoding, see     <a href="http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1">http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1</a>.</li>      <li><code>ReceiveMessageWaitTimeSeconds</code> - The time for which a ReceiveMessage call will wait for a message to arrive. An integer from 0 to 20 (seconds). The default for this attribute is 0. </li>  <li><code>VisibilityTimeout</code> - The visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see Visibility Timeout in the <i>Amazon SQS Developer Guide</i>.</li>  <li><code>RedrivePolicy</code> - The parameters for dead letter queue functionality of the source queue.     For more information about RedrivePolicy and dead letter queues, see Using Amazon SQS Dead Letter Queues in the <i>Amazon SQS Developer Guide</i>.</li>   </ul> </param>
        public SetQueueAttributesRequest(string queueUrl, Dictionary<string, string> attributes)
        {
            _queueUrl = queueUrl;
            _attributes = attributes;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attributes to set.
        /// </para>
        ///     
        /// <para>
        /// The following lists the names, descriptions, and values of the special request parameters
        /// the <code>SetQueueAttributes</code>      action uses:
        /// </para>
        ///     
        /// <para>
        ///       <ul>                <li><code>DelaySeconds</code> - The time in seconds that
        /// the delivery of all messages in the queue will be delayed. An integer from 0 to 900
        /// (15 minutes). The default for this attribute is 0 (zero).</li>               <li><code>MaximumMessageSize</code>
        /// - The limit of how many bytes a message can contain before Amazon SQS rejects it.
        /// An integer from 1024 bytes (1 KiB) up to 262144 bytes (256 KiB). The default for this
        /// attribute is 262144 (256 KiB).</li>        <li><code>MessageRetentionPeriod</code>
        /// - The number of seconds Amazon SQS retains a message. Integer representing seconds,
        /// from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600
        /// (4 days).</li>        <li><code>Policy</code> - The queue's policy. A valid      
        ///    form-url-encoded policy. For more information about policy          structure,
        /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/BasicStructure.html">Basic
        /// Policy Structure</a> in the <i>Amazon SQS Developer Guide</i>.           For more
        /// information about form-url-encoding, see           <a href="http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1">http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1</a>.</li>
        ///                        <li><code>ReceiveMessageWaitTimeSeconds</code> - The time for
        /// which a ReceiveMessage call will wait for a message to arrive. An integer from 0 to
        /// 20 (seconds). The default for this attribute is 0. </li>        <li><code>VisibilityTimeout</code>
        /// - The visibility timeout for the queue. An integer from 0 to 43200 (12 hours). The
        /// default for this attribute is 30. For more information about visibility timeout, see
        /// Visibility Timeout in the <i>Amazon SQS Developer Guide</i>.</li>        <li><code>RedrivePolicy</code>
        /// - The parameters for dead letter queue functionality of the source queue.        
        ///   For more information about RedrivePolicy and dead letter queues, see Using Amazon
        /// SQS Dead Letter Queues in the <i>Amazon SQS Developer Guide</i>.</li>      </ul> 
        ///   
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
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

    }
}