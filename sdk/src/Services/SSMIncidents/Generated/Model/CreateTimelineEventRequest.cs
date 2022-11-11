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
    /// Container for the parameters to the CreateTimelineEvent operation.
    /// Creates a custom timeline event on the incident details page of an incident record.
    /// Timeline events are automatically created by Incident Manager, marking key moment
    /// during an incident. You can create custom timeline events to mark important events
    /// that are automatically detected by Incident Manager.
    /// </summary>
    public partial class CreateTimelineEventRequest : AmazonSSMIncidentsRequest
    {
        private string _clientToken;
        private string _eventData;
        private List<EventReference> _eventReferences = new List<EventReference>();
        private DateTime? _eventTime;
        private string _eventType;
        private string _incidentRecordArn;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token ensuring that the action is called only once with the specified details.
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
        /// Gets and sets the property EventReferences. 
        /// <para>
        /// Adds one or more references to the <code>TimelineEvent</code>. A reference can be
        /// an Amazon Web Services resource involved in the incident or in some way associated
        /// with it. When you specify a reference, you enter the Amazon Resource Name (ARN) of
        /// the resource. You can also specify a related item. As an example, you could specify
        /// the ARN of an Amazon DynamoDB (DynamoDB) table. The table for this example is the
        /// resource. You could also specify a Amazon CloudWatch metric for that table. The metric
        /// is the related item.
        /// </para>
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
        [AWSProperty(Required=true)]
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
        /// The type of the event. You can create timeline events of type <code>Custom Event</code>.
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
        /// Gets and sets the property IncidentRecordArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident record to which the event will be added.
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