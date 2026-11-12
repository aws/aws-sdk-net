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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about your detection coverage, such as the status of protection
    /// plans and foundational data sources.
    /// </summary>
    public partial class DetectionCoverage
    {
        /// <summary>
        /// Gets and sets the property CoverageGaps. 
        /// <para>
        /// A description of the gaps in detection coverage. A record doesn't include both <c>CoverageGaps</c>
        /// and <c>KeyObservation</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string CoverageGaps { get; set; }

        /// <summary>
        /// Checks to see if the CoverageGaps property is set.
        /// </summary>
        internal bool IsSetCoverageGaps() => this.CoverageGaps != null;

        /// <summary>
        /// Gets and sets the property FoundationalDataSources. 
        /// <para>
        /// The foundational data sources, such as <c>CLOUD_TRAIL</c>, <c>DNS_LOGS</c>, and <c>FLOW_LOGS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<string> FoundationalDataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FoundationalDataSources property is set.
        /// </summary>
        internal bool IsSetFoundationalDataSources() => this.FoundationalDataSources != null && (this.FoundationalDataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyObservation. 
        /// <para>
        /// A key observation about detection coverage.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string KeyObservation { get; set; }

        /// <summary>
        /// Checks to see if the KeyObservation property is set.
        /// </summary>
        internal bool IsSetKeyObservation() => this.KeyObservation != null;

        /// <summary>
        /// Gets and sets the property ProtectionPlans. 
        /// <para>
        /// The protection plans and their status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ProtectionPlan> ProtectionPlans { get; set; } = AWSConfigs.InitializeCollections ? new List<ProtectionPlan>() : null;

        /// <summary>
        /// Checks to see if the ProtectionPlans property is set.
        /// </summary>
        internal bool IsSetProtectionPlans() => this.ProtectionPlans != null && (this.ProtectionPlans.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
