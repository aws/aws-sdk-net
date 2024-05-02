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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// A summary of information about an internet event in Amazon CloudWatch Internet Monitor.
    /// Internet events are issues that cause performance degradation or availability problems
    /// for impacted Amazon Web Services client locations. Internet Monitor displays information
    /// about recent global health events, called internet events, on a global outages map
    /// that is available to all Amazon Web Services customers.
    /// </summary>
    public partial class InternetEventSummary
    {
        private ClientLocation _clientLocation;
        private DateTime? _endedAt;
        private string _eventArn;
        private string _eventId;
        private InternetEventStatus _eventStatus;
        private InternetEventType _eventType;
        private DateTime? _startedAt;

        /// <summary>
        /// Gets and sets the property ClientLocation. 
        /// <para>
        /// The impacted location, such as a city, that Amazon Web Services clients access application
        /// resources from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ClientLocation ClientLocation
        {
            get { return this._clientLocation; }
            set { this._clientLocation = value; }
        }

        // Check to see if ClientLocation property is set
        internal bool IsSetClientLocation()
        {
            return this._clientLocation != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The time when an internet event ended. If the event hasn't ended yet, this value is
        /// empty.
        /// </para>
        /// </summary>
        public DateTime? EndedAt
        {
            get { return this._endedAt; }
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
        /// The Amazon Resource Name (ARN) of the internet event.
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
        /// The internally-generated identifier of an internet event.
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
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The status of an internet event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InternetEventStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of network impairment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InternetEventType EventType
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
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The time when an internet event started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

    }
}