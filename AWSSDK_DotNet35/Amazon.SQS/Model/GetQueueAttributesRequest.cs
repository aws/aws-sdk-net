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
    /// Container for the parameters to the GetQueueAttributes operation.
    /// Gets attributes for the specified queue. The following attributes are supported: <ul>
    /// <li> <code>All</code> - returns all values.</li> <li> <code>ApproximateNumberOfMessages</code>
    /// - returns the approximate number of visible messages in a queue. For more information,
    /// see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
    /// Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i>.</li> <li>
    /// <code>ApproximateNumberOfMessagesNotVisible</code> - returns the approximate number
    /// of messages that are not timed-out and not deleted. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
    /// Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i>.</li> <li>
    /// <code>VisibilityTimeout</code> - returns the visibility timeout for the queue. For
    /// more information about visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility
    /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.</li> <li> <code>CreatedTimestamp</code>
    /// - returns the time when the queue was created (epoch time in seconds).</li> <li> <code>LastModifiedTimestamp</code>
    /// - returns the time when the queue was last changed (epoch time in seconds).</li> <li>
    /// <code>Policy</code> - returns the queue's policy.</li> <li> <code>MaximumMessageSize</code>
    /// - returns the limit of how many bytes a message can contain before Amazon SQS rejects
    /// it.</li> <li> <code>MessageRetentionPeriod</code> - returns the number of seconds
    /// Amazon SQS retains a message.</li> <li> <code>QueueArn</code> - returns the queue's
    /// Amazon resource name (ARN).</li> <li> <code>ApproximateNumberOfMessagesDelayed</code>
    /// - returns the approximate number of messages that are pending to be added to the queue.</li>
    /// <li> <code>DelaySeconds</code> - returns the default delay on the queue in seconds.</li>
    /// <li> <code>ReceiveMessageWaitTimeSeconds</code> - returns the time for which a ReceiveMessage
    /// call will wait for a message to arrive.</li> <li> <code>RedrivePolicy</code> - returns
    /// the parameters for dead letter queue functionality of the source queue. For more information
    /// about RedrivePolicy and dead letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using
    /// Amazon SQS Dead Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.</li> </ul>
    /// 
    /// 
    ///  <note>Going forward, new attributes might be added. If you are writing code that
    /// calls this action, we recommend that you structure your code so that it can handle
    /// new attributes gracefully.</note> <note>Some API actions take lists of parameters.
    /// These lists are specified using the <code>param.n</code> notation. Values of <code>n</code>
    /// are integers starting from 1. For example, a parameter list with two elements looks
    /// like this: </note> 
    /// <para>
    /// <code>&amp;Attribute.1=this</code>
    /// </para>
    ///  
    /// <para>
    /// <code>&amp;Attribute.2=that</code>
    /// </para>
    /// </summary>
    public partial class GetQueueAttributesRequest : AmazonSQSRequest
    {
        private List<string> _attributeNames = new List<string>();
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetQueueAttributesRequest() { }

        /// <summary>
        /// Instantiates GetQueueAttributesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to take action on.</param>
        /// <param name="attributeNames">A list of attributes to retrieve information for. </param>
        public GetQueueAttributesRequest(string queueUrl, List<string> attributeNames)
        {
            _queueUrl = queueUrl;
            _attributeNames = attributeNames;
        }

        /// <summary>
        /// Gets and sets the property AttributeNames. 
        /// <para>
        /// A list of attributes to retrieve information for. 
        /// </para>
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