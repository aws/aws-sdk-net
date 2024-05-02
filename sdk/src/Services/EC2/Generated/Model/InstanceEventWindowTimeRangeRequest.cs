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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The start day and time and the end day and time of the time range, in UTC.
    /// </summary>
    public partial class InstanceEventWindowTimeRangeRequest
    {
        private int? _endHour;
        private WeekDay _endWeekDay;
        private int? _startHour;
        private WeekDay _startWeekDay;

        /// <summary>
        /// Gets and sets the property EndHour. 
        /// <para>
        /// The hour when the time range ends.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
        public int? EndHour
        {
            get { return this._endHour; }
            set { this._endHour = value; }
        }

        // Check to see if EndHour property is set
        internal bool IsSetEndHour()
        {
            return this._endHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndWeekDay. 
        /// <para>
        /// The day on which the time range ends.
        /// </para>
        /// </summary>
        public WeekDay EndWeekDay
        {
            get { return this._endWeekDay; }
            set { this._endWeekDay = value; }
        }

        // Check to see if EndWeekDay property is set
        internal bool IsSetEndWeekDay()
        {
            return this._endWeekDay != null;
        }

        /// <summary>
        /// Gets and sets the property StartHour. 
        /// <para>
        /// The hour when the time range begins.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
        public int? StartHour
        {
            get { return this._startHour; }
            set { this._startHour = value; }
        }

        // Check to see if StartHour property is set
        internal bool IsSetStartHour()
        {
            return this._startHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartWeekDay. 
        /// <para>
        /// The day on which the time range begins.
        /// </para>
        /// </summary>
        public WeekDay StartWeekDay
        {
            get { return this._startWeekDay; }
            set { this._startWeekDay = value; }
        }

        // Check to see if StartWeekDay property is set
        internal bool IsSetStartWeekDay()
        {
            return this._startWeekDay != null;
        }

    }
}