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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition for a <c>TopicIRContributionAnalysis</c>.
    /// </summary>
    public partial class TopicIRContributionAnalysis
    {
        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction for the <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// </summary>
        public ContributionAnalysisDirection Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property Factors. 
        /// <para>
        /// The factors for a <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ContributionAnalysisFactor> Factors { get; set; } = AWSConfigs.InitializeCollections ? new List<ContributionAnalysisFactor>() : null;

        /// <summary>
        /// Checks to see if the Factors property is set.
        /// </summary>
        internal bool IsSetFactors() => this.Factors != null && (this.Factors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SortType. 
        /// <para>
        /// The sort type for the <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// </summary>
        public ContributionAnalysisSortType SortType { get; set; }

        /// <summary>
        /// Checks to see if the SortType property is set.
        /// </summary>
        internal bool IsSetSortType() => this.SortType != null;

        /// <summary>
        /// Gets and sets the property TimeRanges. 
        /// <para>
        /// The time ranges for the <c>TopicIRContributionAnalysis</c>.
        /// </para>
        /// </summary>
        public ContributionAnalysisTimeRanges TimeRanges { get; set; }

        /// <summary>
        /// Checks to see if the TimeRanges property is set.
        /// </summary>
        internal bool IsSetTimeRanges() => this.TimeRanges != null;
    }
}
