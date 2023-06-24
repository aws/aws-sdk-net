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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Specifies the date and time that a job will begin the rollout of the job document
    /// to all devices in the target group. Additionally, you can specify the end behavior
    /// for each job execution when it reaches the scheduled end time.
    /// </summary>
    public partial class SchedulingConfig
    {
        private JobEndBehavior _endBehavior;
        private string _endTime;
        private List<MaintenanceWindow> _maintenanceWindows = new List<MaintenanceWindow>();
        private string _startTime;

        /// <summary>
        /// Gets and sets the property EndBehavior. 
        /// <para>
        /// Specifies the end behavior for all job executions after a job reaches the selected
        /// <code>endTime</code>. If <code>endTime</code> is not selected when creating the job,
        /// then <code>endBehavior</code> does not apply.
        /// </para>
        /// </summary>
        public JobEndBehavior EndBehavior
        {
            get { return this._endBehavior; }
            set { this._endBehavior = value; }
        }

        // Check to see if EndBehavior property is set
        internal bool IsSetEndBehavior()
        {
            return this._endBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time a job will stop rollout of the job document to all devices in the target
        /// group for a job. The <code>endTime</code> must take place no later than two years
        /// from the current time and be scheduled a minimum of thirty minutes from the current
        /// time. The minimum duration between <code>startTime</code> and <code>endTime</code>
        /// is thirty minutes. The maximum duration between <code>startTime</code> and <code>endTime</code>
        /// is two years. The date and time format for the <code>endTime</code> is YYYY-MM-DD
        /// for the date and HH:MM for the time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceWindows. 
        /// <para>
        /// An optional configuration within the <code>SchedulingConfig</code> to setup a recurring
        /// maintenance window with a predetermined start time and duration for the rollout of
        /// a job document to all devices in a target group for a job.
        /// </para>
        /// </summary>
        public List<MaintenanceWindow> MaintenanceWindows
        {
            get { return this._maintenanceWindows; }
            set { this._maintenanceWindows = value; }
        }

        // Check to see if MaintenanceWindows property is set
        internal bool IsSetMaintenanceWindows()
        {
            return this._maintenanceWindows != null && this._maintenanceWindows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time a job will begin rollout of the job document to all devices in the target
        /// group for a job. The <code>startTime</code> can be scheduled up to a year in advance
        /// and must be scheduled a minimum of thirty minutes from the current time. The date
        /// and time format for the <code>startTime</code> is YYYY-MM-DD for the date and HH:MM
        /// for the time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

    }
}