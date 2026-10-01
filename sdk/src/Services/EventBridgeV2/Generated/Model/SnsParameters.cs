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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// SNS invocation parameters for subscribers. Values are forwarded to the SNS PublishBatch
    /// API. All scalar values accept a literal or a JSONata expression (e.g. &quot;{% $events.Data.groupId
    /// %}&quot;).
    /// </summary>
    public partial class SnsParameters
    {
        private Dictionary<string, SnsMessageAttributeValue> _messageAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SnsMessageAttributeValue>() : null;
        private string _messageDeduplicationId;
        private string _messageGroupId;
        private string _messageStructure;
        private string _subject;

        /// <summary>
        /// Gets and sets the property MessageAttributes. 
        /// <para>
        /// Custom message attributes for SNS filtering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, SnsMessageAttributeValue> MessageAttributes
        {
            get { return this._messageAttributes; }
            set { this._messageAttributes = value; }
        }

        // Check to see if MessageAttributes property is set
        internal bool IsSetMessageAttributes()
        {
            return this._messageAttributes != null && (this._messageAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MessageDeduplicationId. 
        /// <para>
        /// Message deduplication ID for FIFO topics. Accepts JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string MessageDeduplicationId
        {
            get { return this._messageDeduplicationId; }
            set { this._messageDeduplicationId = value; }
        }

        // Check to see if MessageDeduplicationId property is set
        internal bool IsSetMessageDeduplicationId()
        {
            return this._messageDeduplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageGroupId. 
        /// <para>
        /// Message group ID for FIFO topics. Accepts JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string MessageGroupId
        {
            get { return this._messageGroupId; }
            set { this._messageGroupId = value; }
        }

        // Check to see if MessageGroupId property is set
        internal bool IsSetMessageGroupId()
        {
            return this._messageGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageStructure. 
        /// <para>
        /// Per-protocol message formatting mode, forwarded to SNS Publish unchanged. Accepts
        /// JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string MessageStructure
        {
            get { return this._messageStructure; }
            set { this._messageStructure = value; }
        }

        // Check to see if MessageStructure property is set
        internal bool IsSetMessageStructure()
        {
            return this._messageStructure != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// Subject line for email protocol subscriptions. Accepts JSONata expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

    }
}