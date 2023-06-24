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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A <code>NumericRangeFilter</code> filters values that are within the value range.
    /// </summary>
    public partial class NumericRangeFilter
    {
        private AggregationFunction _aggregationFunction;
        private ColumnIdentifier _column;
        private string _filterId;
        private bool? _includeMaximum;
        private bool? _includeMinimum;
        private FilterNullOption _nullOption;
        private NumericRangeFilterValue _rangeMaximum;
        private NumericRangeFilterValue _rangeMinimum;
        private NumericFilterSelectAllOptions _selectAllOptions;

        /// <summary>
        /// Gets and sets the property AggregationFunction. 
        /// <para>
        /// The aggregation function of the filter.
        /// </para>
        /// </summary>
        public AggregationFunction AggregationFunction
        {
            get { return this._aggregationFunction; }
            set { this._aggregationFunction = value; }
        }

        // Check to see if AggregationFunction property is set
        internal bool IsSetAggregationFunction()
        {
            return this._aggregationFunction != null;
        }

        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ColumnIdentifier Column
        {
            get { return this._column; }
            set { this._column = value; }
        }

        // Check to see if Column property is set
        internal bool IsSetColumn()
        {
            return this._column != null;
        }

        /// <summary>
        /// Gets and sets the property FilterId. 
        /// <para>
        /// An identifier that uniquely identifies a filter within a dashboard, analysis, or template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FilterId
        {
            get { return this._filterId; }
            set { this._filterId = value; }
        }

        // Check to see if FilterId property is set
        internal bool IsSetFilterId()
        {
            return this._filterId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeMaximum. 
        /// <para>
        /// Determines whether the maximum value in the filter value range should be included
        /// in the filtered results.
        /// </para>
        /// </summary>
        public bool IncludeMaximum
        {
            get { return this._includeMaximum.GetValueOrDefault(); }
            set { this._includeMaximum = value; }
        }

        // Check to see if IncludeMaximum property is set
        internal bool IsSetIncludeMaximum()
        {
            return this._includeMaximum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeMinimum. 
        /// <para>
        /// Determines whether the minimum value in the filter value range should be included
        /// in the filtered results.
        /// </para>
        /// </summary>
        public bool IncludeMinimum
        {
            get { return this._includeMinimum.GetValueOrDefault(); }
            set { this._includeMinimum = value; }
        }

        // Check to see if IncludeMinimum property is set
        internal bool IsSetIncludeMinimum()
        {
            return this._includeMinimum.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NullOption. 
        /// <para>
        /// This option determines how null values should be treated when filtering data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ALL_VALUES</code>: Include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NULLS_ONLY</code>: Only include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NON_NULLS_ONLY</code>: Exclude null values from filtered results.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterNullOption NullOption
        {
            get { return this._nullOption; }
            set { this._nullOption = value; }
        }

        // Check to see if NullOption property is set
        internal bool IsSetNullOption()
        {
            return this._nullOption != null;
        }

        /// <summary>
        /// Gets and sets the property RangeMaximum. 
        /// <para>
        /// The maximum value for the filter value range.
        /// </para>
        /// </summary>
        public NumericRangeFilterValue RangeMaximum
        {
            get { return this._rangeMaximum; }
            set { this._rangeMaximum = value; }
        }

        // Check to see if RangeMaximum property is set
        internal bool IsSetRangeMaximum()
        {
            return this._rangeMaximum != null;
        }

        /// <summary>
        /// Gets and sets the property RangeMinimum. 
        /// <para>
        /// The minimum value for the filter value range.
        /// </para>
        /// </summary>
        public NumericRangeFilterValue RangeMinimum
        {
            get { return this._rangeMinimum; }
            set { this._rangeMinimum = value; }
        }

        // Check to see if RangeMinimum property is set
        internal bool IsSetRangeMinimum()
        {
            return this._rangeMinimum != null;
        }

        /// <summary>
        /// Gets and sets the property SelectAllOptions. 
        /// <para>
        /// Select all of the values. Null is not the assigned value of select all.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>FILTER_ALL_VALUES</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NumericFilterSelectAllOptions SelectAllOptions
        {
            get { return this._selectAllOptions; }
            set { this._selectAllOptions = value; }
        }

        // Check to see if SelectAllOptions property is set
        internal bool IsSetSelectAllOptions()
        {
            return this._selectAllOptions != null;
        }

    }
}