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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Hours of entry.
    /// </summary>
    public partial class WaypointOptimizationAccessHoursEntry
    {
        private DayOfWeek _dayOfWeek;
        private string _timeOfDay;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// Day of the week.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Time of the day.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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

    }
}