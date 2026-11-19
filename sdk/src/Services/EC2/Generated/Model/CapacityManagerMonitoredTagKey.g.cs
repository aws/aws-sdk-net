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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a tag key that is being monitored by Capacity Manager, including its activation
    /// status and the earliest available data point.
    /// </summary>
    public partial class CapacityManagerMonitoredTagKey
    {
        /// <summary>
        /// Gets and sets the property CapacityManagerProvided. 
        /// <para>
        ///  Indicates whether this tag key is provided by Capacity Manager by default, rather
        /// than being user-activated. 
        /// </para>
        /// </summary>
        public bool? CapacityManagerProvided { get; set; }

        /// <summary>
        /// Checks to see if the CapacityManagerProvided property is set.
        /// </summary>
        internal bool IsSetCapacityManagerProvided() => this.CapacityManagerProvided.HasValue;

        /// <summary>
        /// Gets and sets the property EarliestDatapointTimestamp. 
        /// <para>
        ///  The earliest timestamp from which tag data is available for queries, in UTC ISO 8601
        /// format. 
        /// </para>
        /// </summary>
        public DateTime? EarliestDatapointTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EarliestDatapointTimestamp property is set.
        /// </summary>
        internal bool IsSetEarliestDatapointTimestamp() => this.EarliestDatapointTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the monitored tag key. Valid values are <c>activating</c>,
        /// <c>activated</c>, <c>deactivating</c>, and <c>suspended</c>. 
        /// </para>
        /// </summary>
        public CapacityManagerMonitoredTagKeyStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  A message providing additional details about the current status of the monitored
        /// tag key. 
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        ///  The tag key being monitored. 
        /// </para>
        /// </summary>
        public string TagKey { get; set; }

        /// <summary>
        /// Checks to see if the TagKey property is set.
        /// </summary>
        internal bool IsSetTagKey() => this.TagKey != null;
    }
}
