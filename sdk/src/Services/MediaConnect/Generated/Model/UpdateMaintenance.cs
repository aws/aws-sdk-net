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
    /// Update maintenance setting for a flow.
    /// </summary>
    public partial class UpdateMaintenance
    {
        private MaintenanceDay _maintenanceDay;
        private string _maintenanceScheduledDate;
        private string _maintenanceStartHour;

        /// <summary>
        /// Gets and sets the property MaintenanceDay. 
        /// <para>
        ///  A day of a week when the maintenance will happen.
        /// </para>
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
        /// Gets and sets the property MaintenanceScheduledDate. 
        /// <para>
        ///  A scheduled date in ISO UTC format when the maintenance will happen. Use YYYY-MM-DD
        /// format. Example: 2021-01-30.
        /// </para>
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
        /// Gets and sets the property MaintenanceStartHour. 
        /// <para>
        ///  UTC time when the maintenance will happen. Use 24-hour HH:MM format. Minutes must
        /// be 00. Example: 13:00. The default value is 02:00.
        /// </para>
        /// </summary>
        public string MaintenanceStartHour
        {
            get { return this._maintenanceStartHour; }
            set { this._maintenanceStartHour = value; }
        }

        // Check to see if MaintenanceStartHour property is set
        internal bool IsSetMaintenanceStartHour()
        {
            return this._maintenanceStartHour != null;
        }

    }
}