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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the time period for a Scheduled Instance to start its first schedule.
    /// </summary>
    public partial class SlotStartTimeRangeRequest
    {
        private DateTime? _earliestTimeUtc;
        private DateTime? _latestTimeUtc;

        /// <summary>
        /// Gets and sets the property EarliestTimeUtc. 
        /// <para>
        /// The earliest date and time, in UTC, for the Scheduled Instance to start.
        /// </para>
        /// </summary>
        public DateTime EarliestTimeUtc
        {
            get { return this._earliestTimeUtc.GetValueOrDefault(); }
            set { this._earliestTime = this._earliestTimeUtc = value; }
        }

        // Check to see if EarliestTimeUtc property is set
        internal bool IsSetEarliestTimeUtc()
        {
            return this._earliestTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestTimeUtc. 
        /// <para>
        /// The latest date and time, in UTC, for the Scheduled Instance to start.
        /// </para>
        /// </summary>
        public DateTime LatestTimeUtc
        {
            get { return this._latestTimeUtc.GetValueOrDefault(); }
            set { this._latestTime = this._latestTimeUtc = value; }
        }

        // Check to see if LatestTimeUtc property is set
        internal bool IsSetLatestTimeUtc()
        {
            return this._latestTimeUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _earliestTime;
        private DateTime? _latestTime;

        /// <summary>
        /// Gets and sets the property EarliestTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use EarliestTimeUtc instead. Setting either EarliestTime
        /// or EarliestTimeUtc results in both EarliestTime and EarliestTimeUtc being assigned,
        /// the latest assignment to either one of the two property is reflected in the value
        /// of both. EarliestTime is provided for backwards compatibility only and assigning a
        /// non-Utc DateTime to it results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The earliest date and time, in UTC, for the Scheduled Instance to start.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use EarliestTimeUtc instead. Setting either EarliestTime or EarliestTimeUtc results in both EarliestTime and " +
            "EarliestTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. EarliestTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime EarliestTime
        {
            get { return this._earliestTime.GetValueOrDefault(); }
            set
            {
                this._earliestTime = value;
                this._earliestTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property LatestTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use LatestTimeUtc instead. Setting either LatestTime or
        /// LatestTimeUtc results in both LatestTime and LatestTimeUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. LatestTime
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The latest date and time, in UTC, for the Scheduled Instance to start.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use LatestTimeUtc instead. Setting either LatestTime or LatestTimeUtc results in both LatestTime and " +
            "LatestTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. LatestTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime LatestTime
        {
            get { return this._latestTime.GetValueOrDefault(); }
            set
            {
                this._latestTime = value;
                this._latestTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}