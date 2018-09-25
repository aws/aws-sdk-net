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
 * Do not modify this file. This file is generated from the mobileanalytics-2014-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MobileAnalytics.Model
{
    /// <summary>
    /// A JSON object representing a batch of unique event occurrences in your app.
    /// </summary>
    public partial class Event
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _eventType;
        private Dictionary<string, double> _metrics = new Dictionary<string, double>();
        private Session _session;
        private DateTime? _timestampUtc;
        private string _version;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A collection of key-value pairs that give additional context to the event. The key-value
        /// pairs are specified by the developer.
        /// </para>
        ///  
        /// <para>
        /// This collection can be empty or the attribute object can be omitted.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventType. 
        /// <para>
        /// A name signifying an event that occurred in your app. This is used for grouping and
        /// aggregating like events together for reporting purposes.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// A collection of key-value pairs that gives additional, measurable context to the event.
        /// The key-value pairs are specified by the developer.
        /// </para>
        ///  
        /// <para>
        /// This collection can be empty or the attribute object can be omitted.
        /// </para>
        /// </summary>
        public Dictionary<string, double> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session the event occured within. 
        /// </para>
        /// </summary>
        public Session Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

        /// <summary>
        /// Gets and sets the property TimestampUtc. 
        /// <para>
        /// The time the event occurred in ISO 8601 standard date time format. For example, 2014-06-30T19:07:47.885Z
        /// </para>
        /// </summary>
        public DateTime TimestampUtc
        {
            get { return this._timestampUtc.GetValueOrDefault(); }
            set { this._timestamp = this._timestampUtc = value; }
        }

        // Check to see if TimestampUtc property is set
        internal bool IsSetTimestampUtc()
        {
            return this._timestampUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the event.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

#region Backwards compatible properties
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property TimestampUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use TimestampUtc instead. Setting either Timestamp or
        /// TimestampUtc results in both Timestamp and TimestampUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. Timestamp
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time the event occurred in ISO 8601 standard date time format. For example, 2014-06-30T19:07:47.885Z
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use TimestampUtc instead. Setting either Timestamp or TimestampUtc results in both Timestamp and " +
            "TimestampUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. Timestamp is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set
            {
                this._timestamp = value;
                this._timestampUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}