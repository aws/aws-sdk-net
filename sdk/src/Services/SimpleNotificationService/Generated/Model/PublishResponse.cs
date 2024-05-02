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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Response for Publish action.
    /// </summary>
    public partial class PublishResponse : AmazonWebServiceResponse
    {
        private string _messageId;
        private string _sequenceNumber;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// Unique identifier assigned to the published message.
        /// </para>
        ///  
        /// <para>
        /// Length Constraint: Maximum 100 characters
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// This response element applies only to FIFO (first-in-first-out) topics. 
        /// </para>
        ///  
        /// <para>
        /// The sequence number is a large, non-consecutive number that Amazon SNS assigns to
        /// each message. The length of <c>SequenceNumber</c> is 128 bits. <c>SequenceNumber</c>
        /// continues to increase for each <c>MessageGroupId</c>.
        /// </para>
        /// </summary>
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

    }
}