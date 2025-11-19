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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Defines a specific time window for maintenance operations.
    /// </summary>
    public partial class WindowMaintenanceSchedule
    {
        private DateTime? _end;
        private DateTime? _scheduledTime;
        private DateTime? _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The end time of the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledTime. 
        /// <para>
        /// The date and time when the maintenance window is scheduled to occur.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ScheduledTime
        {
            get { return this._scheduledTime.GetValueOrDefault(); }
            set { this._scheduledTime = value; }
        }

        // Check to see if ScheduledTime property is set
        internal bool IsSetScheduledTime()
        {
            return this._scheduledTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// The start time of the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

    }
}