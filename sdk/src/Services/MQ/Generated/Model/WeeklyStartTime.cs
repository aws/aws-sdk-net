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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// The scheduled time period relative to UTC during which Amazon MQ begins to apply pending
    /// updates or patches to the broker.
    /// </summary>
    public partial class WeeklyStartTime
    {
        private DayOfWeek _dayOfWeek;
        private string _timeOfDay;
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// Required. The day of the week.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DayOfWeek DayOfWeek
        {
            get { return this._dayOfWeek; }
            set { this._dayOfWeek = value; }
        }

        // Check to see if DayOfWeek property is set
        internal bool IsSetDayOfWeek()
        {
            return this._dayOfWeek != null;
        }

        /// <summary>
        /// Gets and sets the property TimeOfDay. 
        /// <para>
        /// Required. The time, in 24-hour format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TimeOfDay
        {
            get { return this._timeOfDay; }
            set { this._timeOfDay = value; }
        }

        // Check to see if TimeOfDay property is set
        internal bool IsSetTimeOfDay()
        {
            return this._timeOfDay != null;
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone, UTC by default, in either the Country/City format, or the UTC offset
        /// format.
        /// </para>
        /// </summary>
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

    }
}