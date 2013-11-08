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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// <para>Contains the details of a single SQS message along with a <c>Id</c> . </para>
    /// </summary>
    public class SendMessageBatchRequestEntry
    {
        
        private string id;
        private string messageBody;
        private int? delaySeconds;


        /// <summary>
        /// An identifier for the message in this batch. This is used to communicate the result. Note that the the <c>Id</c>s of a batch request need to
        /// be unique within the request.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// Body of the message.
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
        /// The number of seconds for which the message has to be delayed.
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
