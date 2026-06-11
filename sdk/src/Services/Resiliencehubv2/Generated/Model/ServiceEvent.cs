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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Represents an event in the service event log.
    /// </summary>
    public partial class ServiceEvent
    {
        private EventActor _actor;
        private ServiceEventDetails _eventDetails;
        private string _eventId;
        private ServiceEventType _eventType;
        private string _serviceArn;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property Actor. 
        /// <para>
        /// The actor that triggered the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventActor Actor
        {
            get { return this._actor; }
            set { this._actor = value; }
        }

        // Check to see if Actor property is set
        internal bool IsSetActor()
        {
            return this._actor != null;
        }

        /// <summary>
        /// Gets and sets the property EventDetails. 
        /// <para>
        /// The details of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceEventDetails EventDetails
        {
            get { return this._eventDetails; }
            set { this._eventDetails = value; }
        }

        // Check to see if EventDetails property is set
        internal bool IsSetEventDetails()
        {
            return this._eventDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The unique identifier of the event.
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
        /// Gets and sets the property EventType. 
        /// <para>
        /// The type of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceEventType EventType
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
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}