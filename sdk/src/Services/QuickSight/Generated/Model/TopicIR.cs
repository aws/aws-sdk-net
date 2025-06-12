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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private TopicIRContributionAnalysis _contributionAnalysis;
        private List<List<TopicIRFilterOption>> _filters = AWSConfigs.InitializeCollections ? new List<List<TopicIRFilterOption>>() : null;
        private List<TopicIRGroupBy> _groupByList = AWSConfigs.InitializeCollections ? new List<TopicIRGroupBy>() : null;
        private List<TopicIRMetric> _metrics = AWSConfigs.InitializeCollections ? new List<TopicIRMetric>() : null;
        private TopicSortClause _sort;
        private VisualOptions _visual;

        /// <summary>
        /// Gets and sets the property ContributionAnalysis. 
        /// <para>
        /// The contribution analysis for the <c>TopicIR</c>.
        /// </para>
        /// </summary>
        public TopicIRContributionAnalysis ContributionAnalysis
        {
            get { return this._contributionAnalysis; }
            set { this._contributionAnalysis = value; }
        }

        // Check to see if ContributionAnalysis property is set
        internal bool IsSetContributionAnalysis()
        {
            return this._contributionAnalysis != null;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters for the <c>TopicIR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<List<TopicIRFilterOption>> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GroupByList. 
        /// <para>
        /// The GroupBy list for the <c>TopicIR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<TopicIRGroupBy> GroupByList
        {
            get { return this._groupByList; }
            set { this._groupByList = value; }
        }

        // Check to see if GroupByList property is set
        internal bool IsSetGroupByList()
        {
            return this._groupByList != null && (this._groupByList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics for the <c>TopicIR</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2000)]
        public List<TopicIRMetric> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sort for the <c>TopicIR</c>.
        /// </para>
        /// </summary>
        public TopicSortClause Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property Visual. 
        /// <para>
        /// The visual for the <c>TopicIR</c>.
        /// </para>
        /// </summary>
        public VisualOptions Visual
        {
            get { return this._visual; }
            set { this._visual = value; }
        }

        // Check to see if Visual property is set
        internal bool IsSetVisual()
        {
            return this._visual != null;
        }

    }
}