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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private MaintenanceDay _maintenanceDay;
        private string _maintenanceDeadline;
        private string _maintenanceScheduledDate;
        private string _maintenanceStartTime;

        /// <summary>
        /// Gets and sets the property MaintenanceDay. The currently selected maintenance day.
        /// </summary>
        public MaintenanceDay MaintenanceDay
        {
            get { return this._maintenanceDay; }
            set { this._maintenanceDay = value; }
        }

        // Check to see if MaintenanceDay property is set
        internal bool IsSetMaintenanceDay()
        {
            return this._maintenanceDay != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceDeadline. Maintenance is required by the displayed
        /// date and time. Date and time is in ISO.
        /// </summary>
        public string MaintenanceDeadline
        {
            get { return this._maintenanceDeadline; }
            set { this._maintenanceDeadline = value; }
        }

        // Check to see if MaintenanceDeadline property is set
        internal bool IsSetMaintenanceDeadline()
        {
            return this._maintenanceDeadline != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceScheduledDate. The currently scheduled maintenance
        /// date and time. Date and time is in ISO.
        /// </summary>
        public string MaintenanceScheduledDate
        {
            get { return this._maintenanceScheduledDate; }
            set { this._maintenanceScheduledDate = value; }
        }

        // Check to see if MaintenanceScheduledDate property is set
        internal bool IsSetMaintenanceScheduledDate()
        {
            return this._maintenanceScheduledDate != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceStartTime. The currently selected maintenance
        /// start time. Time is in UTC.
        /// </summary>
        public string MaintenanceStartTime
        {
            get { return this._maintenanceStartTime; }
            set { this._maintenanceStartTime = value; }
        }

        // Check to see if MaintenanceStartTime property is set
        internal bool IsSetMaintenanceStartTime()
        {
            return this._maintenanceStartTime != null;
        }

    }
}