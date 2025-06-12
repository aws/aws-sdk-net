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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// This structure contains the description of the workspace configuration.
    /// </summary>
    public partial class WorkspaceConfigurationDescription
    {
        private List<LimitsPerLabelSet> _limitsPerLabelSet = AWSConfigs.InitializeCollections ? new List<LimitsPerLabelSet>() : null;
        private int? _retentionPeriodInDays;
        private WorkspaceConfigurationStatus _status;

        /// <summary>
        /// Gets and sets the property LimitsPerLabelSet. 
        /// <para>
        /// This is an array of structures, where each structure displays one label sets for the
        /// workspace and the limits for that label set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LimitsPerLabelSet> LimitsPerLabelSet
        {
            get { return this._limitsPerLabelSet; }
            set { this._limitsPerLabelSet = value; }
        }

        // Check to see if LimitsPerLabelSet property is set
        internal bool IsSetLimitsPerLabelSet()
        {
            return this._limitsPerLabelSet != null && (this._limitsPerLabelSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// This field displays how many days that metrics are retained in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This structure displays the current status of the workspace configuration, and might
        /// also contain a reason for that status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}