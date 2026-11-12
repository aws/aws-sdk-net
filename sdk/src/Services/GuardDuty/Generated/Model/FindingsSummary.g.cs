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
    /// Contains a summary of findings.
    /// </summary>
    public partial class FindingsSummary
    {
        /// <summary>
        /// Gets and sets the property ByTimeWindow. 
        /// <para>
        /// The number of findings in each time window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<TimeWindowGroup> ByTimeWindow { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeWindowGroup>() : null;

        /// <summary>
        /// Checks to see if the ByTimeWindow property is set.
        /// </summary>
        internal bool IsSetByTimeWindow() => this.ByTimeWindow != null && (this.ByTimeWindow.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SeverityBreakdown. 
        /// <para>
        /// The number of findings at each severity level.
        /// </para>
        /// </summary>
        public SeverityBreakdown SeverityBreakdown { get; set; }

        /// <summary>
        /// Checks to see if the SeverityBreakdown property is set.
        /// </summary>
        internal bool IsSetSeverityBreakdown() => this.SeverityBreakdown != null;

        /// <summary>
        /// Gets and sets the property TopFindingTypes. 
        /// <para>
        /// The finding types that have the most findings, with counts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public List<FindingTypeCount> TopFindingTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<FindingTypeCount>() : null;

        /// <summary>
        /// Checks to see if the TopFindingTypes property is set.
        /// </summary>
        internal bool IsSetTopFindingTypes() => this.TopFindingTypes != null && (this.TopFindingTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings.
        /// </para>
        /// </summary>
        public int? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
