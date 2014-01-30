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
    /// <para>Gets attributes for the specified queue. The following attributes are supported:
    /// <ul>
    /// <li> <c>All</c> - returns all values.</li>
    /// <li> <c>ApproximateNumberOfMessages</c> - returns the approximate number of visible messages in a queue. For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html" >Resources Required to Process
    /// Messages</a> in the <i>Amazon SQS Developer Guide</i> .</li>
    /// <li> <c>ApproximateNumberOfMessagesNotVisible</c> - returns the approximate number of messages that are not timed-out and not deleted. For
    /// more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html" >Resources
    /// Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i> .</li>
    /// <li> <c>VisibilityTimeout</c> - returns the visibility timeout for the queue. For more information about visibility timeout, see <a
    /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html" >Visibility Timeout</a> in the <i>Amazon SQS
    /// Developer Guide</i> .</li>
    /// <li> <c>CreatedTimestamp</c> - returns the time when the queue was created (epoch time in seconds).</li>
    /// <li> <c>LastModifiedTimestamp</c> - returns the time when the queue was last changed (epoch time in seconds).</li>
    /// <li> <c>Policy</c> - returns the queue's policy.</li>
    /// <li> <c>MaximumMessageSize</c> - returns the limit of how many bytes a message can contain before Amazon SQS rejects it.</li>
    /// <li> <c>MessageRetentionPeriod</c> - returns the number of seconds Amazon SQS retains a message.</li>
    /// <li> <c>QueueArn</c> - returns the queue's Amazon resource name (ARN).</li>
    /// <li> <c>ApproximateNumberOfMessagesDelayed</c> - returns the approximate number of messages that are pending to be added to the queue.</li>
    /// <li> <c>DelaySeconds</c> - returns the default delay on the queue in seconds.</li>
    /// <li> <c>ReceiveMessageWaitTimeSeconds</c> - returns the time for which a ReceiveMessage call will wait for a message to arrive.</li>
    /// <li> <c>RedrivePolicy</c> - returns the parameters for dead letter queue functionality of the source queue. For more information about
    /// RedrivePolicy and dead letter queues, see <a
    /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html" >Using Amazon SQS Dead Letter
    /// Queues</a> in the <i>Amazon SQS Developer Guide</i> .</li>
    /// 
    /// </ul>
    /// </para> <para><b>NOTE:</b>Going forward, new attributes might be added. If you are writing code that calls this action, we recommend that
    /// you structure your code so that it can handle new attributes gracefully.</para> <para><b>NOTE:</b>Some API actions take lists of parameters.
    /// These lists are specified using the param.n notation. Values of n are integers starting from 1. For example, a parameter list with two
    /// elements looks like this: </para> <para> <c>&amp;amp;Attribute.1=this</c> </para> <para> <c>&amp;amp;Attribute.2=that</c> </para>
    /// </summary>
    public partial class GetQueueAttributesRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private List<string> attributeNames = new List<string>();


        /// <summary>
        /// The URL of the Amazon SQS queue to take action on.
        ///  
        /// </summary>
        public string QueueUrl
        {
            get { return this.queueUrl; }
            set { this.queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this.queueUrl != null;
        }

        /// <summary>
        /// A list of attributes to retrieve information for.
        ///  
        /// </summary>
        public List<string> AttributeNames
        {
            get { return this.attributeNames; }
            set { this.attributeNames = value; }
        }

        // Check to see if AttributeNames property is set
        internal bool IsSetAttributeNames()
        {
            return this.attributeNames.Count > 0;
        }

    }
}
    
