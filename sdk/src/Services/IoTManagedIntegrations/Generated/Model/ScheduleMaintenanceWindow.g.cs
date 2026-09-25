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

namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing scheduling maintenance window.
    /// </summary>
    public partial class ScheduleMaintenanceWindow
    {
        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// Displays the duration of the next maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1430)]
        public int? DurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DurationInMinutes property is set.
        /// </summary>
        internal bool IsSetDurationInMinutes() => this.DurationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Displays the start time of the next maintenance window.
        /// </para>
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;
    }
}
