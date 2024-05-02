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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Specifies the interval between each scheduled refresh of a dataset.
    /// </summary>
    public partial class RefreshFrequency
    {
        private RefreshInterval _interval;
        private ScheduleRefreshOnEntity _refreshOnDay;
        private string _timeOfTheDay;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval between scheduled refreshes. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MINUTE15</c>: The dataset refreshes every 15 minutes. This value is only supported
        /// for incremental refreshes. This interval can only be used for one schedule per dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MINUTE30</c>:The dataset refreshes every 30 minutes. This value is only supported
        /// for incremental refreshes. This interval can only be used for one schedule per dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOURLY</c>: The dataset refreshes every hour. This interval can only be used for
        /// one schedule per dataset.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DAILY</c>: The dataset refreshes every day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WEEKLY</c>: The dataset refreshes every week.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MONTHLY</c>: The dataset refreshes every month.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RefreshInterval Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshOnDay. 
        /// <para>
        /// The day of the week that you want to schedule the refresh on. This value is required
        /// for weekly and monthly refresh intervals.
        /// </para>
        /// </summary>
        public ScheduleRefreshOnEntity RefreshOnDay
        {
            get { return this._refreshOnDay; }
            set { this._refreshOnDay = value; }
        }

        // Check to see if RefreshOnDay property is set
        internal bool IsSetRefreshOnDay()
        {
            return this._refreshOnDay != null;
        }

        /// <summary>
        /// Gets and sets the property TimeOfTheDay. 
        /// <para>
        /// The time of day that you want the datset to refresh. This value is expressed in HH:MM
        /// format. This field is not required for schedules that refresh hourly.
        /// </para>
        /// </summary>
        public string TimeOfTheDay
        {
            get { return this._timeOfTheDay; }
            set { this._timeOfTheDay = value; }
        }

        // Check to see if TimeOfTheDay property is set
        internal bool IsSetTimeOfTheDay()
        {
            return this._timeOfTheDay != null;
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone that you want the refresh schedule to use. The timezone ID must match
        /// a corresponding ID found on <c>java.util.time.getAvailableIDs()</c>.
        /// </para>
        /// </summary>
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}