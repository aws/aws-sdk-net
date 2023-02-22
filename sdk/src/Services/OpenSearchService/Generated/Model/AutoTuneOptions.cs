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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Auto-Tune settings when updating a domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html">Auto-Tune
    /// for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class AutoTuneOptions
    {
        private AutoTuneDesiredState _desiredState;
        private List<AutoTuneMaintenanceSchedule> _maintenanceSchedules = new List<AutoTuneMaintenanceSchedule>();
        private RollbackOnDisable _rollbackOnDisable;
        private bool? _useOffPeakWindow;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// Whether Auto-Tune is enabled or disabled.
        /// </para>
        /// </summary>
        public AutoTuneDesiredState DesiredState
        {
            get { return this._desiredState; }
            set { this._desiredState = value; }
        }

        // Check to see if DesiredState property is set
        internal bool IsSetDesiredState()
        {
            return this._desiredState != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceSchedules. 
        /// <para>
        /// DEPRECATED. Use <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/off-peak.html">off-peak
        /// window</a> instead.
        /// </para>
        ///  
        /// <para>
        /// A list of maintenance schedules during which Auto-Tune can deploy changes.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<AutoTuneMaintenanceSchedule> MaintenanceSchedules
        {
            get { return this._maintenanceSchedules; }
            set { this._maintenanceSchedules = value; }
        }

        // Check to see if MaintenanceSchedules property is set
        internal bool IsSetMaintenanceSchedules()
        {
            return this._maintenanceSchedules != null && this._maintenanceSchedules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RollbackOnDisable. 
        /// <para>
        /// When disabling Auto-Tune, specify <code>NO_ROLLBACK</code> to retain all prior Auto-Tune
        /// settings or <code>DEFAULT_ROLLBACK</code> to revert to the OpenSearch Service defaults.
        /// If you specify <code>DEFAULT_ROLLBACK</code>, you must include a <code>MaintenanceSchedule</code>
        /// in the request. Otherwise, OpenSearch Service is unable to perform the rollback.
        /// </para>
        /// </summary>
        public RollbackOnDisable RollbackOnDisable
        {
            get { return this._rollbackOnDisable; }
            set { this._rollbackOnDisable = value; }
        }

        // Check to see if RollbackOnDisable property is set
        internal bool IsSetRollbackOnDisable()
        {
            return this._rollbackOnDisable != null;
        }

        /// <summary>
        /// Gets and sets the property UseOffPeakWindow. 
        /// <para>
        /// Whether to use the domain's <a href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_OffPeakWindow.html">off-peak
        /// window</a> to deploy configuration changes on the domain rather than a maintenance
        /// schedule.
        /// </para>
        /// </summary>
        public bool UseOffPeakWindow
        {
            get { return this._useOffPeakWindow.GetValueOrDefault(); }
            set { this._useOffPeakWindow = value; }
        }

        // Check to see if UseOffPeakWindow property is set
        internal bool IsSetUseOffPeakWindow()
        {
            return this._useOffPeakWindow.HasValue; 
        }

    }
}