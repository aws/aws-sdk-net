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
    /// Container for the parameters to the UpdateWorkspaceConfiguration operation.
    /// Use this operation to create or update the label sets, label set limits, and retention
    /// period of a workspace.
    /// 
    ///  
    /// <para>
    /// You must specify at least one of <c>limitsPerLabelSet</c> or <c>retentionPeriodInDays</c>
    /// for the request to be valid.
    /// </para>
    /// </summary>
    public partial class UpdateWorkspaceConfigurationRequest : AmazonPrometheusServiceRequest
    {
        private string _clientToken;
        private List<LimitsPerLabelSet> _limitsPerLabelSet = AWSConfigs.InitializeCollections ? new List<LimitsPerLabelSet>() : null;
        private int? _retentionPeriodInDays;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// You can include a token in your operation to make it an idempotent opeartion. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property LimitsPerLabelSet. 
        /// <para>
        /// This is an array of structures, where each structure defines a label set for the workspace,
        /// and defines the active time series limit for each of those label sets. Each label
        /// name in a label set must be unique.
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
        /// Specifies how many days that metrics will be retained in the workspace.
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
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that you want to update. To find the IDs of your workspaces,
        /// use the <a href="https://docs.aws.amazon.com/prometheus/latest/APIReference/API_ListWorkspaces.htm">ListWorkspaces</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}