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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The start day and time and the end day and time of the time range, in UTC.
    /// </summary>
    public partial class InstanceEventWindowTimeRange
    {
        /// <summary>
        /// Gets and sets the property EndHour. 
        /// <para>
        /// The hour when the time range ends.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 23)]
        public int? EndHour { get; set; }

        /// <summary>
        /// Checks to see if the EndHour property is set.
        /// </summary>
        internal bool IsSetEndHour() => this.EndHour.HasValue;

        /// <summary>
        /// Gets and sets the property EndWeekDay. 
        /// <para>
        /// The day on which the time range ends.
        /// </para>
        /// </summary>
        public WeekDay EndWeekDay { get; set; }

        /// <summary>
        /// Checks to see if the EndWeekDay property is set.
        /// </summary>
        internal bool IsSetEndWeekDay() => this.EndWeekDay != null;

        /// <summary>
        /// Gets and sets the property StartHour. 
        /// <para>
        /// The hour when the time range begins.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 23)]
        public int? StartHour { get; set; }

        /// <summary>
        /// Checks to see if the StartHour property is set.
        /// </summary>
        internal bool IsSetStartHour() => this.StartHour.HasValue;

        /// <summary>
        /// Gets and sets the property StartWeekDay. 
        /// <para>
        /// The day on which the time range begins.
        /// </para>
        /// </summary>
        public WeekDay StartWeekDay { get; set; }

        /// <summary>
        /// Checks to see if the StartWeekDay property is set.
        /// </summary>
        internal bool IsSetStartWeekDay() => this.StartWeekDay != null;
    }
}
