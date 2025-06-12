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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
    /// Over-the-air (OTA) task scheduling config.
    /// </summary>
    public partial class OtaTaskSchedulingConfig
    {
        private SchedulingConfigEndBehavior _endBehavior;
        private string _endTime;
        private List<ScheduleMaintenanceWindow> _maintenanceWindows = AWSConfigs.InitializeCollections ? new List<ScheduleMaintenanceWindow>() : null;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property EndBehavior. 
        /// <para>
        /// Specifies the end behavior for all task executions after a task reaches the selected
        /// <c>endTime</c>. If <c>endTime</c> is not selected when creating the task, then <c>endBehavior</c>
        /// does not apply.
        /// </para>
        /// </summary>
        public SchedulingConfigEndBehavior EndBehavior
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
        /// The time an over-the-air (OTA) task will stop.
        /// </para>
        /// </summary>
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
        /// Maintenance window list for over-the-air (OTA) task scheduling config.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduleMaintenanceWindow> MaintenanceWindows
        {
            get { return this._maintenanceWindows; }
            set { this._maintenanceWindows = value; }
        }

        // Check to see if MaintenanceWindows property is set
        internal bool IsSetMaintenanceWindows()
        {
            return this._maintenanceWindows != null && (this._maintenanceWindows.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time an over-the-air (OTA) task will start.
        /// </para>
        /// </summary>
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