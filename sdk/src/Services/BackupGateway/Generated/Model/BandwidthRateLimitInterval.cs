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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Describes a bandwidth rate limit interval for a gateway. A bandwidth rate limit schedule
    /// consists of one or more bandwidth rate limit intervals. A bandwidth rate limit interval
    /// defines a period of time on one or more days of the week, during which bandwidth rate
    /// limits are specified for uploading, downloading, or both.
    /// </summary>
    public partial class BandwidthRateLimitInterval
    {
        private long? _averageUploadRateLimitInBitsPerSec;
        private List<int> _daysOfWeek = new List<int>();
        private int? _endHourOfDay;
        private int? _endMinuteOfHour;
        private int? _startHourOfDay;
        private int? _startMinuteOfHour;

        /// <summary>
        /// Gets and sets the property AverageUploadRateLimitInBitsPerSec. 
        /// <para>
        /// The average upload rate limit component of the bandwidth rate limit interval, in bits
        /// per second. This field does not appear in the response if the upload rate limit is
        /// not set.
        /// </para>
        ///  <note> 
        /// <para>
        /// For Backup Gateway, the minimum value is <code>(Value)</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=51200, Max=8000000000000)]
        public long AverageUploadRateLimitInBitsPerSec
        {
            get { return this._averageUploadRateLimitInBitsPerSec.GetValueOrDefault(); }
            set { this._averageUploadRateLimitInBitsPerSec = value; }
        }

        // Check to see if AverageUploadRateLimitInBitsPerSec property is set
        internal bool IsSetAverageUploadRateLimitInBitsPerSec()
        {
            return this._averageUploadRateLimitInBitsPerSec.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DaysOfWeek. 
        /// <para>
        /// The days of the week component of the bandwidth rate limit interval, represented as
        /// ordinal numbers from 0 to 6, where 0 represents Sunday and 6 represents Saturday.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public List<int> DaysOfWeek
        {
            get { return this._daysOfWeek; }
            set { this._daysOfWeek = value; }
        }

        // Check to see if DaysOfWeek property is set
        internal bool IsSetDaysOfWeek()
        {
            return this._daysOfWeek != null && this._daysOfWeek.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndHourOfDay. 
        /// <para>
        /// The hour of the day to end the bandwidth rate limit interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int EndHourOfDay
        {
            get { return this._endHourOfDay.GetValueOrDefault(); }
            set { this._endHourOfDay = value; }
        }

        // Check to see if EndHourOfDay property is set
        internal bool IsSetEndHourOfDay()
        {
            return this._endHourOfDay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndMinuteOfHour. 
        /// <para>
        /// The minute of the hour to end the bandwidth rate limit interval.
        /// </para>
        ///  <important> 
        /// <para>
        /// The bandwidth rate limit interval ends at the end of the minute. To end an interval
        /// at the end of an hour, use the value <code>59</code>.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=59)]
        public int EndMinuteOfHour
        {
            get { return this._endMinuteOfHour.GetValueOrDefault(); }
            set { this._endMinuteOfHour = value; }
        }

        // Check to see if EndMinuteOfHour property is set
        internal bool IsSetEndMinuteOfHour()
        {
            return this._endMinuteOfHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartHourOfDay. 
        /// <para>
        /// The hour of the day to start the bandwidth rate limit interval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int StartHourOfDay
        {
            get { return this._startHourOfDay.GetValueOrDefault(); }
            set { this._startHourOfDay = value; }
        }

        // Check to see if StartHourOfDay property is set
        internal bool IsSetStartHourOfDay()
        {
            return this._startHourOfDay.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartMinuteOfHour. 
        /// <para>
        /// The minute of the hour to start the bandwidth rate limit interval. The interval begins
        /// at the start of that minute. To begin an interval exactly at the start of the hour,
        /// use the value <code>0</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=59)]
        public int StartMinuteOfHour
        {
            get { return this._startMinuteOfHour.GetValueOrDefault(); }
            set { this._startMinuteOfHour = value; }
        }

        // Check to see if StartMinuteOfHour property is set
        internal bool IsSetStartMinuteOfHour()
        {
            return this._startMinuteOfHour.HasValue; 
        }

    }
}