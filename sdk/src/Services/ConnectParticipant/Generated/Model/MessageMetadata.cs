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
    /// Contains metadata related to a message.
    /// </summary>
    public partial class MessageMetadata
    {
        private string _messageId;
        private List<Receipt> _receipts = new List<Receipt>();

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the message that contains the metadata information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Receipts. 
        /// <para>
        /// The list of receipt information for a message for different recipients.
        /// </para>
        /// </summary>
        public List<Receipt> Receipts
        {
            get { return this._receipts; }
            set { this._receipts = value; }
        }

        // Check to see if Receipts property is set
        internal bool IsSetReceipts()
        {
            return this._receipts != null && this._receipts.Count > 0; 
        }

    }
}