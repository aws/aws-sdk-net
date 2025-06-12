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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
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
namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Specifies the Auto-Tune options: the Auto-Tune desired state for the domain, rollback
    /// state when disabling Auto-Tune options and list of maintenance schedules.
    /// </summary>
    public partial class AutoTuneOptions
    {
        private AutoTuneDesiredState _desiredState;
        private List<AutoTuneMaintenanceSchedule> _maintenanceSchedules = AWSConfigs.InitializeCollections ? new List<AutoTuneMaintenanceSchedule>() : null;
        private RollbackOnDisable _rollbackOnDisable;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// Specifies the Auto-Tune desired state. Valid values are ENABLED, DISABLED. 
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
        /// Specifies list of maitenance schedules. See the <a href="https://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank">Developer Guide</a> for more information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._maintenanceSchedules != null && (this._maintenanceSchedules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RollbackOnDisable. 
        /// <para>
        /// Specifies the rollback state while disabling Auto-Tune for the domain. Valid values
        /// are NO_ROLLBACK, DEFAULT_ROLLBACK. 
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

    }
}