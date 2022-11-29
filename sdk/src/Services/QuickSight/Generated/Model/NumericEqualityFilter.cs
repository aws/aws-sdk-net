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
    /// A <code>NumericEqualityFilter</code> filters values that are equal to the specified
    /// value.
    /// </summary>
    public partial class NumericEqualityFilter
    {
        private AggregationFunction _aggregationFunction;
        private ColumnIdentifier _column;
        private string _filterId;
        private NumericEqualityMatchOperator _matchOperator;
        private FilterNullOption _nullOption;
        private string _parameterName;
        private NumericFilterSelectAllOptions _selectAllOptions;
        private double? _value;

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
        /// Gets and sets the property MatchOperator. 
        /// <para>
        /// The match operator that is used to determine if a filter should be applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NumericEqualityMatchOperator MatchOperator
        {
            get { return this._matchOperator; }
            set { this._matchOperator = value; }
        }

        // Check to see if MatchOperator property is set
        internal bool IsSetMatchOperator()
        {
            return this._matchOperator != null;
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
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The parameter whose value should be used for the filter value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ParameterName
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }

        // Check to see if ParameterName property is set
        internal bool IsSetParameterName()
        {
            return this._parameterName != null;
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

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The input value.
        /// </para>
        /// </summary>
        public double Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}