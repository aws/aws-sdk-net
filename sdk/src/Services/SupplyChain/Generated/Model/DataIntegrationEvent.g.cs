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

namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The data integration event details.
    /// </summary>
    public partial class DataIntegrationEvent
    {
        /// <summary>
        /// Gets and sets the property DatasetTargetDetails. 
        /// <para>
        /// The target dataset details for a DATASET event type.
        /// </para>
        /// </summary>
        public DataIntegrationEventDatasetTargetDetails DatasetTargetDetails { get; set; }

        /// <summary>
        /// Checks to see if the DatasetTargetDetails property is set.
        /// </summary>
        internal bool IsSetDatasetTargetDetails() => this.DatasetTargetDetails != null;

        /// <summary>
        /// Gets and sets the property EventGroupId. 
        /// <para>
        /// Event identifier (for example, orderId for InboundOrder) used for data sharding or
        /// partitioning.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string EventGroupId { get; set; }

        /// <summary>
        /// Checks to see if the EventGroupId property is set.
        /// </summary>
        internal bool IsSetEventGroupId() => this.EventGroupId != null;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique event identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string EventId { get; set; }

        /// <summary>
        /// Checks to see if the EventId property is set.
        /// </summary>
        internal bool IsSetEventId() => this.EventId != null;

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The event timestamp (in epoch seconds).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EventTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the EventTimestamp property is set.
        /// </summary>
        internal bool IsSetEventTimestamp() => this.EventTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The data event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataIntegrationEventType EventType { get; set; }

        /// <summary>
        /// Checks to see if the EventType property is set.
        /// </summary>
        internal bool IsSetEventType() => this.EventType != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
