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
    /// The Auto-Tune options: the Auto-Tune desired state for the domain, rollback state
    /// when disabling Auto-Tune options and list of maintenance schedules.
    /// </summary>
    public partial class AutoTuneOptions
    {
        private AutoTuneDesiredState _desiredState;
        private List<AutoTuneMaintenanceSchedule> _maintenanceSchedules = new List<AutoTuneMaintenanceSchedule>();
        private RollbackOnDisable _rollbackOnDisable;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The Auto-Tune desired state. Valid values are ENABLED and DISABLED.
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
        /// A list of maintenance schedules. See <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html"
        /// target="_blank"> Auto-Tune for Amazon OpenSearch Service </a> for more information.
        /// 
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
        /// The rollback state while disabling Auto-Tune for the domain. Valid values are NO_ROLLBACK
        /// and DEFAULT_ROLLBACK. 
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