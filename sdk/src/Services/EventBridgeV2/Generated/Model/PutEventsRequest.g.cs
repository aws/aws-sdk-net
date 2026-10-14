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
    /// Container for the parameters to the PutEvents operation. Publishes events to an event
    /// bus.
    /// </summary>
    public partial class PutEventsRequest : AmazonEventBridgeV2Request
    {
        /// <summary>
        /// Gets and sets the property DeduplicationConfiguration. Request-level deduplication
        /// settings, applied to every entry in the batch.
        /// </summary>
        public DeduplicationConfiguration DeduplicationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeduplicationConfiguration property is set.
        /// </summary>
        internal bool IsSetDeduplicationConfiguration() => this.DeduplicationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Entries.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<PutEventsRequestEntry> Entries { get; set; } = AWSConfigs.InitializeCollections ? new List<PutEventsRequestEntry>() : null;

        /// <summary>
        /// Checks to see if the Entries property is set.
        /// </summary>
        internal bool IsSetEntries() => this.Entries != null && (this.Entries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EventBusArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string EventBusArn { get; set; }

        /// <summary>
        /// Checks to see if the EventBusArn property is set.
        /// </summary>
        internal bool IsSetEventBusArn() => this.EventBusArn != null;
    }
}
