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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies the configuration details of a schedule-triggered flow as defined by the
    /// user. Currently, these settings only apply to the <code>Scheduled</code> trigger type.
    /// </summary>
    public partial class ScheduledTriggerProperties
    {
        private DataPullMode _dataPullMode;
        private DateTime? _scheduleEndTime;
        private string _scheduleExpression;
        private DateTime? _scheduleStartTime;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property DataPullMode. 
        /// <para>
        ///  Specifies whether a scheduled flow has an incremental data transfer or a complete
        /// data transfer for each flow run. 
        /// </para>
        /// </summary>
        public DataPullMode DataPullMode
        {
            get { return this._dataPullMode; }
            set { this._dataPullMode = value; }
        }

        // Check to see if DataPullMode property is set
        internal bool IsSetDataPullMode()
        {
            return this._dataPullMode != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleEndTime. 
        /// <para>
        ///  Specifies the scheduled end time for a schedule-triggered flow. 
        /// </para>
        /// </summary>
        public DateTime ScheduleEndTime
        {
            get { return this._scheduleEndTime.GetValueOrDefault(); }
            set { this._scheduleEndTime = value; }
        }

        // Check to see if ScheduleEndTime property is set
        internal bool IsSetScheduleEndTime()
        {
            return this._scheduleEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        ///  The scheduling expression that determines the rate at which the schedule will run,
        /// for example <code>rate(5minutes)</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleStartTime. 
        /// <para>
        ///  Specifies the scheduled start time for a schedule-triggered flow. 
        /// </para>
        /// </summary>
        public DateTime ScheduleStartTime
        {
            get { return this._scheduleStartTime.GetValueOrDefault(); }
            set { this._scheduleStartTime = value; }
        }

        // Check to see if ScheduleStartTime property is set
        internal bool IsSetScheduleStartTime()
        {
            return this._scheduleStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        ///  Specifies the time zone used when referring to the date and time of a scheduled-triggered
        /// flow. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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