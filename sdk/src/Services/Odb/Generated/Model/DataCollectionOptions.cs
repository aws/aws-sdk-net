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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Information about the data collection options enabled for a VM cluster.
    /// </summary>
    public partial class DataCollectionOptions
    {
        private bool? _isDiagnosticsEventsEnabled;
        private bool? _isHealthMonitoringEnabled;
        private bool? _isIncidentLogsEnabled;

        /// <summary>
        /// Gets and sets the property IsDiagnosticsEventsEnabled. 
        /// <para>
        /// Indicates whether diagnostic collection is enabled for the VM cluster.
        /// </para>
        /// </summary>
        public bool? IsDiagnosticsEventsEnabled
        {
            get { return this._isDiagnosticsEventsEnabled; }
            set { this._isDiagnosticsEventsEnabled = value; }
        }

        // Check to see if IsDiagnosticsEventsEnabled property is set
        internal bool IsSetIsDiagnosticsEventsEnabled()
        {
            return this._isDiagnosticsEventsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsHealthMonitoringEnabled. 
        /// <para>
        /// Indicates whether health monitoring is enabled for the VM cluster.
        /// </para>
        /// </summary>
        public bool? IsHealthMonitoringEnabled
        {
            get { return this._isHealthMonitoringEnabled; }
            set { this._isHealthMonitoringEnabled = value; }
        }

        // Check to see if IsHealthMonitoringEnabled property is set
        internal bool IsSetIsHealthMonitoringEnabled()
        {
            return this._isHealthMonitoringEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsIncidentLogsEnabled. 
        /// <para>
        /// Indicates whether incident logs are enabled for the cloud VM cluster.
        /// </para>
        /// </summary>
        public bool? IsIncidentLogsEnabled
        {
            get { return this._isIncidentLogsEnabled; }
            set { this._isIncidentLogsEnabled = value; }
        }

        // Check to see if IsIncidentLogsEnabled property is set
        internal bool IsSetIsIncidentLogsEnabled()
        {
            return this._isIncidentLogsEnabled.HasValue; 
        }

    }
}