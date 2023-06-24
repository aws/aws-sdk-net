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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTimelineEvent operation.
    /// Updates a timeline event. You can update events of type <code>Custom Event</code>.
    /// </summary>
    public partial class UpdateTimelineEventRequest : AmazonSSMIncidentsRequest
    {
        private string _clientToken;
        private string _eventData;
        private string _eventId;
        private List<EventReference> _eventReferences = new List<EventReference>();
        private DateTime? _eventTime;
        private string _eventType;
        private string _incidentRecordArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures that a client calls the operation only once with the specified
        /// details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EventData. 
        /// <para>
        /// A short description of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12000)]
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
        /// The ID of the event to update. You can use <code>ListTimelineEvents</code> to find
        /// an event's ID.
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
        /// Updates all existing references in a <code>TimelineEvent</code>. A reference is an
        /// Amazon Web Services resource involved or associated with the incident. To specify
        /// a reference, enter its Amazon Resource Name (ARN). You can also specify a related
        /// item associated with that resource. For example, to specify an Amazon DynamoDB (DynamoDB)
        /// table as a resource, use its ARN. You can also specify an Amazon CloudWatch metric
        /// associated with the DynamoDB table as a related item.
        /// </para>
        ///  <important> 
        /// <para>
        /// This update action overrides all existing references. If you want to keep existing
        /// references, you must specify them in the call. If you don't, this action removes any
        /// existing references and enters only new references.
        /// </para>
        ///  </important>
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
            return this._eventReferences != null && this._eventReferences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The time that the event occurred.
        /// </para>
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
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
        /// The type of event. You can update events of type <code>Custom Event</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident that includes the timeline event.
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