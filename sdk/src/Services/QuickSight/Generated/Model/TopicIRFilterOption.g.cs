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
    /// The definition for a <c>TopicIRFilterOption</c>.
    /// </summary>
    public partial class TopicIRFilterOption
    {
        /// <summary>
        /// Gets and sets the property AggMetrics. 
        /// <para>
        /// The agg metrics for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<FilterAggMetrics> AggMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterAggMetrics>() : null;

        /// <summary>
        /// Checks to see if the AggMetrics property is set.
        /// </summary>
        internal bool IsSetAggMetrics() => this.AggMetrics != null && (this.AggMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public AggType Aggregation { get; set; }

        /// <summary>
        /// Checks to see if the Aggregation property is set.
        /// </summary>
        internal bool IsSetAggregation() => this.Aggregation != null;

        /// <summary>
        /// Gets and sets the property AggregationFunctionParameters. 
        /// <para>
        /// The aggregation function parameters for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AggregationFunctionParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AggregationFunctionParameters property is set.
        /// </summary>
        internal bool IsSetAggregationFunctionParameters() => this.AggregationFunctionParameters != null && (this.AggregationFunctionParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AggregationPartitionBy. 
        /// <para>
        /// The <c>AggregationPartitionBy</c> for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<AggregationPartitionBy> AggregationPartitionBy { get; set; } = AWSConfigs.InitializeCollections ? new List<AggregationPartitionBy>() : null;

        /// <summary>
        /// Checks to see if the AggregationPartitionBy property is set.
        /// </summary>
        internal bool IsSetAggregationPartitionBy() => this.AggregationPartitionBy != null && (this.AggregationPartitionBy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Anchor. 
        /// <para>
        /// The anchor for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public Anchor Anchor { get; set; }

        /// <summary>
        /// Checks to see if the Anchor property is set.
        /// </summary>
        internal bool IsSetAnchor() => this.Anchor != null;

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue Constant { get; set; }

        /// <summary>
        /// Checks to see if the Constant property is set.
        /// </summary>
        internal bool IsSetConstant() => this.Constant != null;

        /// <summary>
        /// Gets and sets the property FilterClass. 
        /// <para>
        /// The filter class for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public FilterClass FilterClass { get; set; }

        /// <summary>
        /// Checks to see if the FilterClass property is set.
        /// </summary>
        internal bool IsSetFilterClass() => this.FilterClass != null;

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The filter type for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicIRFilterType FilterType { get; set; }

        /// <summary>
        /// Checks to see if the FilterType property is set.
        /// </summary>
        internal bool IsSetFilterType() => this.FilterType != null;

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicIRFilterFunction Function { get; set; }

        /// <summary>
        /// Checks to see if the Function property is set.
        /// </summary>
        internal bool IsSetFunction() => this.Function != null;

        /// <summary>
        /// Gets and sets the property Inclusive. 
        /// <para>
        /// The inclusive for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public bool? Inclusive { get; set; }

        /// <summary>
        /// Checks to see if the Inclusive property is set.
        /// </summary>
        internal bool IsSetInclusive() => this.Inclusive.HasValue;

        /// <summary>
        /// Gets and sets the property Inverse. 
        /// <para>
        /// The inverse for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public bool? Inverse { get; set; }

        /// <summary>
        /// Checks to see if the Inverse property is set.
        /// </summary>
        internal bool IsSetInverse() => this.Inverse.HasValue;

        /// <summary>
        /// Gets and sets the property LastNextOffset. 
        /// <para>
        /// The last next offset for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue LastNextOffset { get; set; }

        /// <summary>
        /// Checks to see if the LastNextOffset property is set.
        /// </summary>
        internal bool IsSetLastNextOffset() => this.LastNextOffset != null;

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The null filter for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public NullFilterOption NullFilter { get; set; }

        /// <summary>
        /// Checks to see if the NullFilter property is set.
        /// </summary>
        internal bool IsSetNullFilter() => this.NullFilter != null;

        /// <summary>
        /// Gets and sets the property OperandField. 
        /// <para>
        /// The operand field for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public Identifier OperandField { get; set; }

        /// <summary>
        /// Checks to see if the OperandField property is set.
        /// </summary>
        internal bool IsSetOperandField() => this.OperandField != null;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The range for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The sort direction for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicSortDirection SortDirection { get; set; }

        /// <summary>
        /// Checks to see if the SortDirection property is set.
        /// </summary>
        internal bool IsSetSortDirection() => this.SortDirection != null;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The time granularity for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;

        /// <summary>
        /// Gets and sets the property TopBottomLimit. 
        /// <para>
        /// The <c>TopBottomLimit</c> for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue TopBottomLimit { get; set; }

        /// <summary>
        /// Checks to see if the TopBottomLimit property is set.
        /// </summary>
        internal bool IsSetTopBottomLimit() => this.TopBottomLimit != null;
    }
}
