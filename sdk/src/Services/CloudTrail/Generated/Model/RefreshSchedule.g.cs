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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// The schedule for a dashboard refresh.
    /// </summary>
    public partial class RefreshSchedule
    {
        /// <summary>
        /// Gets and sets the property Frequency. 
        /// <para>
        ///  The frequency at which you want the dashboard refreshed. 
        /// </para>
        /// </summary>
        public RefreshScheduleFrequency Frequency { get; set; }

        /// <summary>
        /// Checks to see if the Frequency property is set.
        /// </summary>
        internal bool IsSetFrequency() => this.Frequency != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  Specifies whether the refresh schedule is enabled. Set the value to <c>ENABLED</c>
        /// to enable the refresh schedule, or to <c>DISABLED</c> to turn off the refresh schedule.
        /// 
        /// </para>
        /// </summary>
        public RefreshScheduleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TimeOfDay. 
        /// <para>
        ///  The time of day in UTC to run the schedule; for hourly only refer to minutes; default
        /// is 00:00. 
        /// </para>
        /// </summary>
        public string TimeOfDay { get; set; }

        /// <summary>
        /// Checks to see if the TimeOfDay property is set.
        /// </summary>
        internal bool IsSetTimeOfDay() => this.TimeOfDay != null;
    }
}
