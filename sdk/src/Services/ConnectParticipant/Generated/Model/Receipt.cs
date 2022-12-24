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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// The receipt for the message delivered to the recipient.
    /// </summary>
    public partial class Receipt
    {
        private string _deliveredTimestamp;
        private string _readTimestamp;
        private string _recipientParticipantId;

        /// <summary>
        /// Gets and sets the property DeliveredTimestamp. 
        /// <para>
        /// The time when the message was delivered to the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DeliveredTimestamp
        {
            get { return this._deliveredTimestamp; }
            set { this._deliveredTimestamp = value; }
        }

        // Check to see if DeliveredTimestamp property is set
        internal bool IsSetDeliveredTimestamp()
        {
            return this._deliveredTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property ReadTimestamp. 
        /// <para>
        /// The time when the message was read by the recipient.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ReadTimestamp
        {
            get { return this._readTimestamp; }
            set { this._readTimestamp = value; }
        }

        // Check to see if ReadTimestamp property is set
        internal bool IsSetReadTimestamp()
        {
            return this._readTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property RecipientParticipantId. 
        /// <para>
        /// The identifier of the recipient of the message. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RecipientParticipantId
        {
            get { return this._recipientParticipantId; }
            set { this._recipientParticipantId = value; }
        }

        // Check to see if RecipientParticipantId property is set
        internal bool IsSetRecipientParticipantId()
        {
            return this._recipientParticipantId != null;
        }

    }
}