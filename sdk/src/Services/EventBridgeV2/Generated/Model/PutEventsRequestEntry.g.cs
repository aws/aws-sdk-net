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
    /// A single event entry in a PutEvents request.
    /// </summary>
    public partial class PutEventsRequestEntry
    {
        /// <summary>
        /// Gets and sets the property Detail. The event payload, as a valid JSON string.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Detail { get; set; }

        /// <summary>
        /// Checks to see if the Detail property is set.
        /// </summary>
        internal bool IsSetDetail() => this.Detail != null;

        /// <summary>
        /// Gets and sets the property DetailType.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DetailType { get; set; }

        /// <summary>
        /// Checks to see if the DetailType property is set.
        /// </summary>
        internal bool IsSetDetailType() => this.DetailType != null;

        /// <summary>
        /// Gets and sets the property Resources. ARNs of resources the event concerns. Included
        /// in the event delivered to subscribers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. The source of the event. The `aws.` value prefix
        /// is service-reserved and cannot be used as a value.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SystemMetadata.
        /// </summary>
        public PutEventsSystemMetadata SystemMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SystemMetadata property is set.
        /// </summary>
        internal bool IsSetSystemMetadata() => this.SystemMetadata != null;

        /// <summary>
        /// Gets and sets the property Time. The time the event occurred. Defaults to the time
        /// the service receives the event when omitted.
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time.HasValue;
    }
}
