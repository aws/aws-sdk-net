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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Encloses data related to a successful message in a batch request for topic.
    /// </summary>
    public partial class PublishBatchResultEntry
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The <c>Id</c> of an entry in a batch request.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// An identifier for the message.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// This parameter applies only to FIFO (first-in-first-out) topics.
        /// </para>
        ///  
        /// <para>
        /// The large, non-consecutive number that Amazon SNS assigns to each message.
        /// </para>
        ///  
        /// <para>
        /// The length of <c>SequenceNumber</c> is 128 bits. <c>SequenceNumber</c> continues to
        /// increase for a particular <c>MessageGroupId</c>.
        /// </para>
        /// </summary>
        public string SequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the SequenceNumber property is set.
        /// </summary>
        internal bool IsSetSequenceNumber() => this.SequenceNumber != null;
    }
}
