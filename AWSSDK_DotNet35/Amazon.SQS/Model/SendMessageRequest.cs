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
    /// Container for the parameters to the SendMessage operation.
    /// <para>The <c>SendMessage</c> action delivers a message to the specified queue.</para>
    /// </summary>
    public partial class SendMessageRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private string messageBody;
        private int? delaySeconds;


        /// <summary>
        /// The URL of the SQS queue to take action on.
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
        /// The message to send.
        ///  
        /// </summary>
        public string MessageBody
        {
            get { return this.messageBody; }
            set { this.messageBody = value; }
        }

        // Check to see if MessageBody property is set
        internal bool IsSetMessageBody()
        {
            return this.messageBody != null;
        }

        /// <summary>
        /// The number of seconds the message has to be delayed.
        ///  
        /// </summary>
        public int DelaySeconds
        {
            get { return this.delaySeconds ?? default(int); }
            set { this.delaySeconds = value; }
        }

        // Check to see if DelaySeconds property is set
        internal bool IsSetDelaySeconds()
        {
            return this.delaySeconds.HasValue;
        }

    }
}
    
