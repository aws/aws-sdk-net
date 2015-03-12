/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Contains information about an event that was returned by a lookup request. The result
    /// includes a representation of a CloudTrail event.
    /// </summary>
    public partial class Event
    {
        private string _cloudTrailEvent;
        private string _eventId;
        private string _eventName;
        private DateTime? _eventTime;
        private List<Resource> _resources = new List<Resource>();
        private string _username;

        /// <summary>
        /// Gets and sets the property CloudTrailEvent. 
        /// <para>
        /// A JSON string that contains a representation of the event returned.
        /// </para>
        /// </summary>
        public string CloudTrailEvent
        {
            get { return this._cloudTrailEvent; }
            set { this._cloudTrailEvent = value; }
        }

        // Check to see if CloudTrailEvent property is set
        internal bool IsSetCloudTrailEvent()
        {
            return this._cloudTrailEvent != null;
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The CloudTrail ID of the event returned.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the event returned.
        /// </para>
        /// </summary>
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The date and time of the event returned.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// A list of resources referenced by the event returned.
        /// </para>
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// A user name or role name of the requester that called the API in the event returned.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}