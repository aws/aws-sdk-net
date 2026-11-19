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
    /// Contains a breakdown of findings along a dimension, such as severity or finding type.
    /// </summary>
    public partial class Distribution
    {
        /// <summary>
        /// Gets and sets the property Archive. 
        /// <para>
        /// The number and percentage of archived and unarchived findings.
        /// </para>
        /// </summary>
        public ArchiveDistribution Archive { get; set; }

        /// <summary>
        /// Checks to see if the Archive property is set.
        /// </summary>
        internal bool IsSetArchive() => this.Archive != null;

        /// <summary>
        /// Gets and sets the property AttackVectors. 
        /// <para>
        /// The findings broken down by MITRE ATT&amp;CK tactic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<TacticCoverage> AttackVectors { get; set; } = AWSConfigs.InitializeCollections ? new List<TacticCoverage>() : null;

        /// <summary>
        /// Checks to see if the AttackVectors property is set.
        /// </summary>
        internal bool IsSetAttackVectors() => this.AttackVectors != null && (this.AttackVectors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The dimension of the breakdown. The value identifies the breakdown that the record
        /// describes: <c>SEVERITY</c> (<c>SeverityBreakdown</c>), <c>TYPE</c> (<c>FindingTypes</c>
        /// or <c>TopFindingTypes</c>), <c>RESOURCE</c> (<c>Resources</c>), <c>ATTACK_VECTOR</c>
        /// (<c>AttackVectors</c>), and <c>ARCHIVE</c> (<c>Archive</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistributionDimension Dimension { get; set; }

        /// <summary>
        /// Checks to see if the Dimension property is set.
        /// </summary>
        internal bool IsSetDimension() => this.Dimension != null;

        /// <summary>
        /// Gets and sets the property FindingTypes. 
        /// <para>
        /// The findings broken down by finding type, with counts and percentages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TypeDistribution> FindingTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<TypeDistribution>() : null;

        /// <summary>
        /// Checks to see if the FindingTypes property is set.
        /// </summary>
        internal bool IsSetFindingTypes() => this.FindingTypes != null && (this.FindingTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// The findings broken down by affected resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ResourceDistribution> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceDistribution>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The total number of findings in the breakdown.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;
    }
}
