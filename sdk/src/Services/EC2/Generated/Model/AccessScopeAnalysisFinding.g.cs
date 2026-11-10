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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a finding for a Network Access Scope.
    /// </summary>
    public partial class AccessScopeAnalysisFinding
    {
        /// <summary>
        /// Gets and sets the property FindingComponents. 
        /// <para>
        /// The finding components.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PathComponent> FindingComponents { get; set; } = AWSConfigs.InitializeCollections ? new List<PathComponent>() : null;

        /// <summary>
        /// Checks to see if the FindingComponents property is set.
        /// </summary>
        internal bool IsSetFindingComponents() => this.FindingComponents != null && (this.FindingComponents.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The ID of the finding.
        /// </para>
        /// </summary>
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeAnalysisId. 
        /// <para>
        /// The ID of the Network Access Scope analysis.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeAnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAccessScopeAnalysisId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAccessScopeAnalysisId() => this.NetworkInsightsAccessScopeAnalysisId != null;

        /// <summary>
        /// Gets and sets the property NetworkInsightsAccessScopeId. 
        /// <para>
        /// The ID of the Network Access Scope.
        /// </para>
        /// </summary>
        public string NetworkInsightsAccessScopeId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInsightsAccessScopeId property is set.
        /// </summary>
        internal bool IsSetNetworkInsightsAccessScopeId() => this.NetworkInsightsAccessScopeId != null;
    }
}
