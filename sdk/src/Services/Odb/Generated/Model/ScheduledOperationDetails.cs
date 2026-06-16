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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The scheduled start and stop times for an Autonomous Database on a specific day of
    /// the week.
    /// </summary>
    public partial class ScheduledOperationDetails
    {
        private DayOfWeek _dayOfWeek;
        private string _scheduledStartTime;
        private string _scheduledStopTime;

        /// <summary>
        /// Gets and sets the property DayOfWeek. 
        /// <para>
        /// The day of the week on which the scheduled operation occurs.
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
        /// Gets and sets the property ScheduledStartTime. 
        /// <para>
        /// The scheduled start time for the Autonomous Database, in UTC.
        /// </para>
        /// </summary>
        public string ScheduledStartTime
        {
            get { return this._scheduledStartTime; }
            set { this._scheduledStartTime = value; }
        }

        // Check to see if ScheduledStartTime property is set
        internal bool IsSetScheduledStartTime()
        {
            return this._scheduledStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledStopTime. 
        /// <para>
        /// The scheduled stop time for the Autonomous Database, in UTC.
        /// </para>
        /// </summary>
        public string ScheduledStopTime
        {
            get { return this._scheduledStopTime; }
            set { this._scheduledStopTime = value; }
        }

        // Check to see if ScheduledStopTime property is set
        internal bool IsSetScheduledStopTime()
        {
            return this._scheduledStopTime != null;
        }

    }
}