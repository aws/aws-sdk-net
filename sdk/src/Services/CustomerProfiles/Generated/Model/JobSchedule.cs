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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The day and time when do you want to start the Identity Resolution Job every week.
    /// </summary>
    public partial class JobSchedule
    {
        private JobScheduleDayOfTheWeek _dayOfTheWeek;
        private string _time;

        /// <summary>
        /// Gets and sets the property DayOfTheWeek. 
        /// <para>
        /// The day when the Identity Resolution Job should run every week.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobScheduleDayOfTheWeek DayOfTheWeek
        {
            get { return this._dayOfTheWeek; }
            set { this._dayOfTheWeek = value; }
        }

        // Check to see if DayOfTheWeek property is set
        internal bool IsSetDayOfTheWeek()
        {
            return this._dayOfTheWeek != null;
        }

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The time when the Identity Resolution Job should run every week.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=5)]
        public string Time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        // Check to see if Time property is set
        internal bool IsSetTime()
        {
            return this._time != null;
        }

    }
}