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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Auto-Tune settings when updating a domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html">Auto-Tune
    /// for Amazon OpenSearch Service</a>.
    /// </summary>
    public partial class AutoTuneOptions
    {
        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// Whether Auto-Tune is enabled or disabled.
        /// </para>
        /// </summary>
        public AutoTuneDesiredState DesiredState { get; set; }

        /// <summary>
        /// Checks to see if the DesiredState property is set.
        /// </summary>
        internal bool IsSetDesiredState() => this.DesiredState != null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<AutoTuneMaintenanceSchedule> MaintenanceSchedules { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoTuneMaintenanceSchedule>() : null;

        /// <summary>
        /// Checks to see if the MaintenanceSchedules property is set.
        /// </summary>
        internal bool IsSetMaintenanceSchedules() => this.MaintenanceSchedules != null && (this.MaintenanceSchedules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RollbackOnDisable. 
        /// <para>
        /// When disabling Auto-Tune, specify <c>NO_ROLLBACK</c> to retain all prior Auto-Tune
        /// settings or <c>DEFAULT_ROLLBACK</c> to revert to the OpenSearch Service defaults.
        /// If you specify <c>DEFAULT_ROLLBACK</c>, you must include a <c>MaintenanceSchedule</c>
        /// in the request. Otherwise, OpenSearch Service is unable to perform the rollback.
        /// </para>
        /// </summary>
        public RollbackOnDisable RollbackOnDisable { get; set; }

        /// <summary>
        /// Checks to see if the RollbackOnDisable property is set.
        /// </summary>
        internal bool IsSetRollbackOnDisable() => this.RollbackOnDisable != null;

        /// <summary>
        /// Gets and sets the property UseOffPeakWindow. 
        /// <para>
        /// Whether to use the domain's <a href="https://docs.aws.amazon.com/opensearch-service/latest/APIReference/API_OffPeakWindow.html">off-peak
        /// window</a> to deploy configuration changes on the domain rather than a maintenance
        /// schedule.
        /// </para>
        /// </summary>
        public bool? UseOffPeakWindow { get; set; }

        /// <summary>
        /// Checks to see if the UseOffPeakWindow property is set.
        /// </summary>
        internal bool IsSetUseOffPeakWindow() => this.UseOffPeakWindow.HasValue;
    }
}
