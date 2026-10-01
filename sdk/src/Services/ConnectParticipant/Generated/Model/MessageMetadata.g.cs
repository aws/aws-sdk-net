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
    /// Contains metadata related to a message.
    /// </summary>
    public partial class MessageMetadata
    {
        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the message that contains the metadata information. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property MessageProcessingStatus. 
        /// <para>
        /// The status of Message Processing for the message.
        /// </para>
        /// </summary>
        public MessageProcessingStatus MessageProcessingStatus { get; set; }

        /// <summary>
        /// Checks to see if the MessageProcessingStatus property is set.
        /// </summary>
        internal bool IsSetMessageProcessingStatus() => this.MessageProcessingStatus != null;

        /// <summary>
        /// Gets and sets the property Receipts. 
        /// <para>
        /// The list of receipt information for a message for different recipients.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Receipt> Receipts { get; set; } = AWSConfigs.InitializeCollections ? new List<Receipt>() : null;

        /// <summary>
        /// Checks to see if the Receipts property is set.
        /// </summary>
        internal bool IsSetReceipts() => this.Receipts != null && (this.Receipts.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
