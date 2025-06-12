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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// A significant event that happened during the incident.
    /// </summary>
    public partial class TimelineEvent
    {
        private string _eventData;
        private string _eventId;
        private List<EventReference> _eventReferences = AWSConfigs.InitializeCollections ? new List<EventReference>() : null;
        private DateTime? _eventTime;
        private string _eventType;
        private DateTime? _eventUpdatedTime;
        private string _incidentRecordArn;

        /// <summary>
        /// Gets and sets the property EventData. 
        /// <para>
        /// A short description of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=12000)]
        public string EventData
        {
            get { return this._eventData; }
            set { this._eventData = value; }
        }

        // Check to see if EventData property is set
        internal bool IsSetEventData()
        {
            return this._eventData != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the timeline event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
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
        /// Gets and sets the property EventReferences. 
        /// <para>
        /// A list of references in a <c>TimelineEvent</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<EventReference> EventReferences
        {
            get { return this._eventReferences; }
            set { this._eventReferences = value; }
        }

        // Check to see if EventReferences property is set
        internal bool IsSetEventReferences()
        {
            return this._eventReferences != null && (this._eventReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The timestamp for when the event occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of event that occurred. Currently Incident Manager supports only the <c>Custom
        /// Event</c> and <c>Note</c> types.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public string EventType
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
        /// Gets and sets the property EventUpdatedTime. 
        /// <para>
        /// The timestamp for when the timeline event was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EventUpdatedTime
        {
            get { return this._eventUpdatedTime; }
            set { this._eventUpdatedTime = value; }
        }

        // Check to see if EventUpdatedTime property is set
        internal bool IsSetEventUpdatedTime()
        {
            return this._eventUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident that the event occurred during.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string IncidentRecordArn
        {
            get { return this._incidentRecordArn; }
            set { this._incidentRecordArn = value; }
        }

        // Check to see if IncidentRecordArn property is set
        internal bool IsSetIncidentRecordArn()
        {
            return this._incidentRecordArn != null;
        }

    }
}