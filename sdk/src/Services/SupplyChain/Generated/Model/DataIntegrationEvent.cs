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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
        private DataIntegrationEventDatasetTargetDetails _datasetTargetDetails;
        private string _eventGroupId;
        private string _eventId;
        private DateTime? _eventTimestamp;
        private DataIntegrationEventType _eventType;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property DatasetTargetDetails. 
        /// <para>
        /// The target dataset details for a DATASET event type.
        /// </para>
        /// </summary>
        public DataIntegrationEventDatasetTargetDetails DatasetTargetDetails
        {
            get { return this._datasetTargetDetails; }
            set { this._datasetTargetDetails = value; }
        }

        // Check to see if DatasetTargetDetails property is set
        internal bool IsSetDatasetTargetDetails()
        {
            return this._datasetTargetDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EventGroupId. 
        /// <para>
        /// Event identifier (for example, orderId for InboundOrder) used for data sharding or
        /// partitioning.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EventGroupId
        {
            get { return this._eventGroupId; }
            set { this._eventGroupId = value; }
        }

        // Check to see if EventGroupId property is set
        internal bool IsSetEventGroupId()
        {
            return this._eventGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique event identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventTimestamp. 
        /// <para>
        /// The event timestamp (in epoch seconds).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventTimestamp
        {
            get { return this._eventTimestamp; }
            set { this._eventTimestamp = value; }
        }

        // Check to see if EventTimestamp property is set
        internal bool IsSetEventTimestamp()
        {
            return this._eventTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The data event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationEventType EventType
        {
            get { return this._eventType; }
            set { this._eventType = value; }
        }

        // Check to see if EventType property is set
        internal bool IsSetEventType()
        {
            return this._eventType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The AWS Supply Chain instance identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}