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
    /// The definition for a <c>TopicIR</c>.
    /// </summary>
    public partial class TopicIR
    {
        /// <summary>
        /// Gets and sets the property ContributionAnalysis. 
        /// <para>
        /// The contribution analysis for the <c>TopicIR</c>.
        /// </para>
        /// </summary>
        public TopicIRContributionAnalysis ContributionAnalysis { get; set; }

        /// <summary>
        /// Checks to see if the ContributionAnalysis property is set.
        /// </summary>
        internal bool IsSetContributionAnalysis() => this.ContributionAnalysis != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters for the <c>TopicIR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<List<TopicIRFilterOption>> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<List<TopicIRFilterOption>>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupByList. 
        /// <para>
        /// The GroupBy list for the <c>TopicIR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<TopicIRGroupBy> GroupByList { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicIRGroupBy>() : null;

        /// <summary>
        /// Checks to see if the GroupByList property is set.
        /// </summary>
        internal bool IsSetGroupByList() => this.GroupByList != null && (this.GroupByList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics for the <c>TopicIR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<TopicIRMetric> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicIRMetric>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort for the <c>TopicIR</c>.
        /// </para>
        /// </summary>
        public TopicSortClause Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property Visual. 
        /// <para>
        /// The visual for the <c>TopicIR</c>.
        /// </para>
        /// </summary>
        public VisualOptions Visual { get; set; }

        /// <summary>
        /// Checks to see if the Visual property is set.
        /// </summary>
        internal bool IsSetVisual() => this.Visual != null;
    }
}
