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
    /// An optional configuration within the <code>SchedulingConfig</code> to setup a recurring
    /// maintenance window with a predetermined start time and duration for the rollout of
    /// a job document to all devices in a target group for a job.
    /// </summary>
    public partial class MaintenanceWindow
    {
        private int? _durationInMinutes;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// Displays the duration of the next maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=30, Max=1430)]
        public int DurationInMinutes
        {
            get { return this._durationInMinutes.GetValueOrDefault(); }
            set { this._durationInMinutes = value; }
        }

        // Check to see if DurationInMinutes property is set
        internal bool IsSetDurationInMinutes()
        {
            return this._durationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Displays the start time of the next maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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