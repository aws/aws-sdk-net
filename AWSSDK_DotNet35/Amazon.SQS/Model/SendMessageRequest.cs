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
    /// <para> Delivers a message to the specified queue. With Amazon SQS, you now have the ability to send large payload messages that are up to
    /// 256KB (262,144 bytes) in size. To send large payloads, you must use an AWS SDK that supports SigV4 signing. To verify whether SigV4 is
    /// supported for an AWS SDK, check the SDK release notes. </para> <para><b>IMPORTANT:</b> The following list shows the characters (in Unicode)
    /// allowed in your message, according to the W3C XML specification. For more information, go to http://www.w3.org/TR/REC-xml/#charsets If you
    /// send any characters not included in the list, your request will be rejected. #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] |
    /// [#x10000 to #x10FFFF] </para>
    /// </summary>
    public partial class SendMessageRequest : AmazonSQSRequest
    {
        private string queueUrl;
        private string messageBody;
        private int? delaySeconds;


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
        /// The message to send. String maximum 256 KB in size. For a list of allowed characters, see the preceding important note.
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
        /// The number of seconds (0 to 900 - 15 minutes) to delay a specific message. Messages with a positive <c>DelaySeconds</c> value become
        /// available for processing after the delay time is finished. If you don't specify a value, the default value for the queue applies.
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
    
