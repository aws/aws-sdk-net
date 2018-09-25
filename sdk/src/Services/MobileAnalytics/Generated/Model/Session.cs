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
    /// Describes the session. Session information is required on ALL events.
    /// </summary>
    public partial class Session
    {
        private long? _duration;
        private string _id;
        private DateTime? _startTimestampUtc;
        private DateTime? _stopTimestampUtc;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the session.
        /// </para>
        /// </summary>
        public long Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the session
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestampUtc. 
        /// <para>
        /// The time the event started in ISO 8601 standard date time format. For example, 2014-06-30T19:07:47.885Z
        /// </para>
        /// </summary>
        public DateTime StartTimestampUtc
        {
            get { return this._startTimestampUtc.GetValueOrDefault(); }
            set { this._startTimestamp = this._startTimestampUtc = value; }
        }

        // Check to see if StartTimestampUtc property is set
        internal bool IsSetStartTimestampUtc()
        {
            return this._startTimestampUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopTimestampUtc. 
        /// <para>
        /// The time the event terminated in ISO 8601 standard date time format. For example,
        /// 2014-06-30T19:07:47.885Z
        /// </para>
        /// </summary>
        public DateTime StopTimestampUtc
        {
            get { return this._stopTimestampUtc.GetValueOrDefault(); }
            set { this._stopTimestamp = this._stopTimestampUtc = value; }
        }

        // Check to see if StopTimestampUtc property is set
        internal bool IsSetStopTimestampUtc()
        {
            return this._stopTimestampUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _startTimestamp;
        private DateTime? _stopTimestamp;

        /// <summary>
        /// Gets and sets the property StartTimestampUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StartTimestampUtc instead. Setting either StartTimestamp
        /// or StartTimestampUtc results in both StartTimestamp and StartTimestampUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value
        /// of both. StartTimestamp is provided for backwards compatibility only and assigning
        /// a non-Utc DateTime to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time the event started in ISO 8601 standard date time format. For example, 2014-06-30T19:07:47.885Z
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StartTimestampUtc instead. Setting either StartTimestamp or StartTimestampUtc results in both StartTimestamp and " +
            "StartTimestampUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StartTimestamp is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StartTimestamp
        {
            get { return this._startTimestamp.GetValueOrDefault(); }
            set
            {
                this._startTimestamp = value;
                this._startTimestampUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property StopTimestampUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StopTimestampUtc instead. Setting either StopTimestamp
        /// or StopTimestampUtc results in both StopTimestamp and StopTimestampUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value
        /// of both. StopTimestamp is provided for backwards compatibility only and assigning
        /// a non-Utc DateTime to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time the event terminated in ISO 8601 standard date time format. For example,
        /// 2014-06-30T19:07:47.885Z
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StopTimestampUtc instead. Setting either StopTimestamp or StopTimestampUtc results in both StopTimestamp and " +
            "StopTimestampUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StopTimestamp is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StopTimestamp
        {
            get { return this._stopTimestamp.GetValueOrDefault(); }
            set
            {
                this._stopTimestamp = value;
                this._stopTimestampUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}