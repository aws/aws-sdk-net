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
    /// Container for the parameters to the CreateQueue operation.
    /// <para>Creates a new queue, or returns the URL of an existing one. When you request <c>CreateQueue</c> , you provide a name for the queue. To
    /// successfully create a new queue, you must provide a name that is unique within the scope of your own queues.</para> <para><b>NOTE:</b> If
    /// you delete a queue, you must wait at least 60 seconds before creating a queue with the same name. </para> <para>You may pass one or more
    /// attributes in the request. If you do not provide a value for any attribute, the queue will have the default value for that attribute.
    /// Permitted attributes are the same that can be set using SetQueueAttributes.</para> <para><b>NOTE:</b> Use GetQueueUrl to get a queue's URL.
    /// GetQueueUrl requires only the QueueName parameter. </para> <para>If you provide the name of an existing queue, along with the exact names
    /// and values of all the queue's attributes, <c>CreateQueue</c> returns the queue URL for the existing queue. If the queue name, attribute
    /// names, or attribute values do not match an existing queue, <c>CreateQueue</c> returns an error.</para> <para><b>NOTE:</b>Some API actions
    /// take lists of parameters. These lists are specified using the param.n notation. Values of n are integers starting from 1. For example, a
    /// parameter list with two elements looks like this: </para> <para> <c>&amp;amp;Attribute.1=this</c> </para> <para>
    /// <c>&amp;amp;Attribute.2=that</c> </para>
    /// </summary>
    public partial class CreateQueueRequest : AmazonSQSRequest
    {
        private string queueName;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// The name for the queue to be created.
        ///  
        /// </summary>
        public string QueueName
        {
            get { return this.queueName; }
            set { this.queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this.queueName != null;
        }

        /// <summary>
        /// A map of attributes with their corresponding values. The following lists the names, descriptions, and values of the special request
        /// parameters the <c>CreateQueue</c> action uses: <ul> <li><c>DelaySeconds</c> - The time in seconds that the delivery of all messages in the
        /// queue will be delayed. An integer from 0 to 900 (15 minutes). The default for this attribute is 0 (zero).</li> <li><c>MaximumMessageSize</c>
        /// - The limit of how many bytes a message can contain before Amazon SQS rejects it. An integer from 1024 bytes (1 KiB) up to 262144 bytes (256
        /// KiB). The default for this attribute is 262144 (256 KiB).</li> <li><c>MessageRetentionPeriod</c> - The number of seconds Amazon SQS retains
        /// a message. Integer representing seconds, from 60 (1 minute) to 1209600 (14 days). The default for this attribute is 345600 (4 days).</li>
        /// <li><c>Policy</c> - The queue's policy. A valid form-url-encoded policy. For more information about policy structure, see <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/BasicStructure.html">Basic Policy Structure</a> in the
        /// <i>Amazon SQS Developer Guide</i>. For more information about form-url-encoding, see <a
        /// href="http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1">http://www.w3.org/MarkUp/html-spec/html-spec_8.html#SEC8.2.1</a>.</li>
        /// <li><c>ReceiveMessageWaitTimeSeconds</c> - The time for which a <a>ReceiveMessage</a> call will wait for a message to arrive. An integer
        /// from 0 to 20 (seconds). The default for this attribute is 0. </li> <li><c>VisibilityTimeout</c> - The visibility timeout for the queue. An
        /// integer from 0 to 43200 (12 hours). The default for this attribute is 30. For more information about visibility timeout, see <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility Timeout</a> in the <i>Amazon SQS
        /// Developer Guide</i>.</li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }

    }
}
    
