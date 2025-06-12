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
    /// The definition for a <c>TopicIRFilterOption</c>.
    /// </summary>
    public partial class TopicIRFilterOption
    {
        private List<FilterAggMetrics> _aggMetrics = AWSConfigs.InitializeCollections ? new List<FilterAggMetrics>() : null;
        private AggType _aggregation;
        private Dictionary<string, string> _aggregationFunctionParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<AggregationPartitionBy> _aggregationPartitionBy = AWSConfigs.InitializeCollections ? new List<AggregationPartitionBy>() : null;
        private Anchor _anchor;
        private TopicConstantValue _constant;
        private FilterClass _filterClass;
        private TopicIRFilterType _filterType;
        private TopicIRFilterFunction _function;
        private bool? _inclusive;
        private bool? _inverse;
        private TopicConstantValue _lastNextOffset;
        private NullFilterOption _nullFilter;
        private Identifier _operandField;
        private TopicConstantValue _range;
        private TopicSortDirection _sortDirection;
        private TimeGranularity _timeGranularity;
        private TopicConstantValue _topBottomLimit;

        /// <summary>
        /// Gets and sets the property AggMetrics. 
        /// <para>
        /// The agg metrics for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<FilterAggMetrics> AggMetrics
        {
            get { return this._aggMetrics; }
            set { this._aggMetrics = value; }
        }

        // Check to see if AggMetrics property is set
        internal bool IsSetAggMetrics()
        {
            return this._aggMetrics != null && (this._aggMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public AggType Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property AggregationFunctionParameters. 
        /// <para>
        /// The aggregation function parameters for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AggregationFunctionParameters
        {
            get { return this._aggregationFunctionParameters; }
            set { this._aggregationFunctionParameters = value; }
        }

        // Check to see if AggregationFunctionParameters property is set
        internal bool IsSetAggregationFunctionParameters()
        {
            return this._aggregationFunctionParameters != null && (this._aggregationFunctionParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AggregationPartitionBy. 
        /// <para>
        /// The <c>AggregationPartitionBy</c> for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<AggregationPartitionBy> AggregationPartitionBy
        {
            get { return this._aggregationPartitionBy; }
            set { this._aggregationPartitionBy = value; }
        }

        // Check to see if AggregationPartitionBy property is set
        internal bool IsSetAggregationPartitionBy()
        {
            return this._aggregationPartitionBy != null && (this._aggregationPartitionBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Anchor. 
        /// <para>
        /// The anchor for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public Anchor Anchor
        {
            get { return this._anchor; }
            set { this._anchor = value; }
        }

        // Check to see if Anchor property is set
        internal bool IsSetAnchor()
        {
            return this._anchor != null;
        }

        /// <summary>
        /// Gets and sets the property Constant. 
        /// <para>
        /// The constant for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue Constant
        {
            get { return this._constant; }
            set { this._constant = value; }
        }

        // Check to see if Constant property is set
        internal bool IsSetConstant()
        {
            return this._constant != null;
        }

        /// <summary>
        /// Gets and sets the property FilterClass. 
        /// <para>
        /// The filter class for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public FilterClass FilterClass
        {
            get { return this._filterClass; }
            set { this._filterClass = value; }
        }

        // Check to see if FilterClass property is set
        internal bool IsSetFilterClass()
        {
            return this._filterClass != null;
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The filter type for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicIRFilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

        /// <summary>
        /// Gets and sets the property Function. 
        /// <para>
        /// The function for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicIRFilterFunction Function
        {
            get { return this._function; }
            set { this._function = value; }
        }

        // Check to see if Function property is set
        internal bool IsSetFunction()
        {
            return this._function != null;
        }

        /// <summary>
        /// Gets and sets the property Inclusive. 
        /// <para>
        /// The inclusive for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public bool? Inclusive
        {
            get { return this._inclusive; }
            set { this._inclusive = value; }
        }

        // Check to see if Inclusive property is set
        internal bool IsSetInclusive()
        {
            return this._inclusive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Inverse. 
        /// <para>
        /// The inverse for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public bool? Inverse
        {
            get { return this._inverse; }
            set { this._inverse = value; }
        }

        // Check to see if Inverse property is set
        internal bool IsSetInverse()
        {
            return this._inverse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastNextOffset. 
        /// <para>
        /// The last next offset for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue LastNextOffset
        {
            get { return this._lastNextOffset; }
            set { this._lastNextOffset = value; }
        }

        // Check to see if LastNextOffset property is set
        internal bool IsSetLastNextOffset()
        {
            return this._lastNextOffset != null;
        }

        /// <summary>
        /// Gets and sets the property NullFilter. 
        /// <para>
        /// The null filter for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public NullFilterOption NullFilter
        {
            get { return this._nullFilter; }
            set { this._nullFilter = value; }
        }

        // Check to see if NullFilter property is set
        internal bool IsSetNullFilter()
        {
            return this._nullFilter != null;
        }

        /// <summary>
        /// Gets and sets the property OperandField. 
        /// <para>
        /// The operand field for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public Identifier OperandField
        {
            get { return this._operandField; }
            set { this._operandField = value; }
        }

        // Check to see if OperandField property is set
        internal bool IsSetOperandField()
        {
            return this._operandField != null;
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The range for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property SortDirection. 
        /// <para>
        /// The sort direction for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicSortDirection SortDirection
        {
            get { return this._sortDirection; }
            set { this._sortDirection = value; }
        }

        // Check to see if SortDirection property is set
        internal bool IsSetSortDirection()
        {
            return this._sortDirection != null;
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The time granularity for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TimeGranularity TimeGranularity
        {
            get { return this._timeGranularity; }
            set { this._timeGranularity = value; }
        }

        // Check to see if TimeGranularity property is set
        internal bool IsSetTimeGranularity()
        {
            return this._timeGranularity != null;
        }

        /// <summary>
        /// Gets and sets the property TopBottomLimit. 
        /// <para>
        /// The <c>TopBottomLimit</c> for the <c>TopicIRFilterOption</c>.
        /// </para>
        /// </summary>
        public TopicConstantValue TopBottomLimit
        {
            get { return this._topBottomLimit; }
            set { this._topBottomLimit = value; }
        }

        // Check to see if TopBottomLimit property is set
        internal bool IsSetTopBottomLimit()
        {
            return this._topBottomLimit != null;
        }

    }
}