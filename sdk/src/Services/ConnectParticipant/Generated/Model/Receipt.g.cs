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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// The receipt for the message delivered to the recipient.
    /// </summary>
    public partial class Receipt
    {
        /// <summary>
        /// Gets and sets the property DeliveredTimestamp. 
        /// <para>
        /// The time when the message was delivered to the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DeliveredTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeliveredTimestamp property is set.
        /// </summary>
        internal bool IsSetDeliveredTimestamp() => this.DeliveredTimestamp != null;

        /// <summary>
        /// Gets and sets the property ReadTimestamp. 
        /// <para>
        /// The time when the message was read by the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ReadTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReadTimestamp property is set.
        /// </summary>
        internal bool IsSetReadTimestamp() => this.ReadTimestamp != null;

        /// <summary>
        /// Gets and sets the property RecipientParticipantId. 
        /// <para>
        /// The identifier of the recipient of the message. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RecipientParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the RecipientParticipantId property is set.
        /// </summary>
        internal bool IsSetRecipientParticipantId() => this.RecipientParticipantId != null;
    }
}
