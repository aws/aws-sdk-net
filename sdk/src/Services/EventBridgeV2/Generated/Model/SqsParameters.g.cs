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

namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// SQS invocation parameters for subscribers. Values are forwarded to the SQS SendMessageBatch
    /// API. All scalar values accept a literal or a JSONata expression (e.g. "{% $events.Data.groupId
    /// %}").
    /// </summary>
    public partial class SqsParameters
    {
        /// <summary>
        /// Gets and sets the property DelaySeconds. Delay in seconds before the message becomes
        /// visible, standard queues only. Accepts JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string DelaySeconds { get; set; }

        /// <summary>
        /// Checks to see if the DelaySeconds property is set.
        /// </summary>
        internal bool IsSetDelaySeconds() => this.DelaySeconds != null;

        /// <summary>
        /// Gets and sets the property MessageAttributes. Custom message attributes (name/type/value).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, SqsMessageAttributeValue> MessageAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SqsMessageAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the MessageAttributes property is set.
        /// </summary>
        internal bool IsSetMessageAttributes() => this.MessageAttributes != null && (this.MessageAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MessageDeduplicationId. Message deduplication ID for FIFO
        /// queues. Accepts JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string MessageDeduplicationId { get; set; }

        /// <summary>
        /// Checks to see if the MessageDeduplicationId property is set.
        /// </summary>
        internal bool IsSetMessageDeduplicationId() => this.MessageDeduplicationId != null;

        /// <summary>
        /// Gets and sets the property MessageGroupId. Message group ID for FIFO queues. Accepts
        /// JSONata expression.
        /// </summary>
        [AWSProperty(Max = 8192)]
        public string MessageGroupId { get; set; }

        /// <summary>
        /// Checks to see if the MessageGroupId property is set.
        /// </summary>
        internal bool IsSetMessageGroupId() => this.MessageGroupId != null;

        /// <summary>
        /// Gets and sets the property MessageSystemAttributes. System message attributes (e.g.,
        /// AWSTraceHeader).
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, SqsMessageAttributeValue> MessageSystemAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SqsMessageAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the MessageSystemAttributes property is set.
        /// </summary>
        internal bool IsSetMessageSystemAttributes() => this.MessageSystemAttributes != null && (this.MessageSystemAttributes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
