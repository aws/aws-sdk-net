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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for MaintenanceStatus
    /// </summary>
    public partial class MaintenanceStatus
    {
        /// <summary>
        /// Gets and sets the property MaintenanceDay. The currently selected maintenance day.
        /// </summary>
        public MaintenanceDay MaintenanceDay { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceDay property is set.
        /// </summary>
        internal bool IsSetMaintenanceDay() => this.MaintenanceDay != null;

        /// <summary>
        /// Gets and sets the property MaintenanceDeadline. Maintenance is required by the displayed
        /// date and time. Date and time is in ISO.
        /// </summary>
        public string MaintenanceDeadline { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceDeadline property is set.
        /// </summary>
        internal bool IsSetMaintenanceDeadline() => this.MaintenanceDeadline != null;

        /// <summary>
        /// Gets and sets the property MaintenanceScheduledDate. The currently scheduled maintenance
        /// date and time. Date and time is in ISO.
        /// </summary>
        public string MaintenanceScheduledDate { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceScheduledDate property is set.
        /// </summary>
        internal bool IsSetMaintenanceScheduledDate() => this.MaintenanceScheduledDate != null;

        /// <summary>
        /// Gets and sets the property MaintenanceStartTime. The currently selected maintenance
        /// start time. Time is in UTC.
        /// </summary>
        public string MaintenanceStartTime { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceStartTime property is set.
        /// </summary>
        internal bool IsSetMaintenanceStartTime() => this.MaintenanceStartTime != null;
    }
}
