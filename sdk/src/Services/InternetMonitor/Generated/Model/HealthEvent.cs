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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Information about a health event created in a monitor in Amazon CloudWatch Internet
    /// Monitor.
    /// </summary>
    public partial class HealthEvent
    {
        private DateTime? _createdAt;
        private DateTime? _endedAt;
        private string _eventArn;
        private string _eventId;
        private List<ImpactedLocation> _impactedLocations = new List<ImpactedLocation>();
        private HealthEventImpactType _impactType;
        private DateTime? _lastUpdatedAt;
        private double? _percentOfTotalTrafficImpacted;
        private DateTime? _startedAt;
        private HealthEventStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// When the health event was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time when a health event ended. If the health event is still active, then the
        /// end time is not set.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EventArn
        {
            get { return this._eventArn; }
            set { this._eventArn = value; }
        }

        // Check to see if EventArn property is set
        internal bool IsSetEventArn()
        {
            return this._eventArn != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The internally generated identifier of a specific network traffic impairment health
        /// event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property ImpactedLocations. 
        /// <para>
        /// The locations impacted by the health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ImpactedLocation> ImpactedLocations
        {
            get { return this._impactedLocations; }
            set { this._impactedLocations = value; }
        }

        // Check to see if ImpactedLocations property is set
        internal bool IsSetImpactedLocations()
        {
            return this._impactedLocations != null && this._impactedLocations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ImpactType. 
        /// <para>
        /// The type of impairment for a health event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthEventImpactType ImpactType
        {
            get { return this._impactType; }
            set { this._impactType = value; }
        }

        // Check to see if ImpactType property is set
        internal bool IsSetImpactType()
        {
            return this._impactType != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// When the health event was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PercentOfTotalTrafficImpacted. 
        /// <para>
        /// The impact on global traffic monitored by this monitor for this health event.
        /// </para>
        /// </summary>
        public double PercentOfTotalTrafficImpacted
        {
            get { return this._percentOfTotalTrafficImpacted.GetValueOrDefault(); }
            set { this._percentOfTotalTrafficImpacted = value; }
        }

        // Check to see if PercentOfTotalTrafficImpacted property is set
        internal bool IsSetPercentOfTotalTrafficImpacted()
        {
            return this._percentOfTotalTrafficImpacted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// When a health event started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Health event list member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HealthEventStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}