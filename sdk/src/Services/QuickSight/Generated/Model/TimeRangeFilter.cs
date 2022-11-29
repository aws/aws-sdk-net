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
    /// A <code>TimeRangeFilter</code> filters values that are between two specified values.
    /// </summary>
    public partial class TimeRangeFilter
    {
        private ColumnIdentifier _column;
        private ExcludePeriodConfiguration _excludePeriodConfiguration;
        private string _filterId;
        private bool? _includeMaximum;
        private bool? _includeMinimum;
        private FilterNullOption _nullOption;
        private TimeRangeFilterValue _rangeMaximumValue;
        private TimeRangeFilterValue _rangeMinimumValue;
        private TimeGranularity _timeGranularity;

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
        /// Gets and sets the property ExcludePeriodConfiguration. 
        /// <para>
        /// The exclude period of the time range filter.
        /// </para>
        /// </summary>
        public ExcludePeriodConfiguration ExcludePeriodConfiguration
        {
            get { return this._excludePeriodConfiguration; }
            set { this._excludePeriodConfiguration = value; }
        }

        // Check to see if ExcludePeriodConfiguration property is set
        internal bool IsSetExcludePeriodConfiguration()
        {
            return this._excludePeriodConfiguration != null;
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
        /// Gets and sets the property RangeMaximumValue. 
        /// <para>
        /// The maximum value for the filter value range.
        /// </para>
        /// </summary>
        public TimeRangeFilterValue RangeMaximumValue
        {
            get { return this._rangeMaximumValue; }
            set { this._rangeMaximumValue = value; }
        }

        // Check to see if RangeMaximumValue property is set
        internal bool IsSetRangeMaximumValue()
        {
            return this._rangeMaximumValue != null;
        }

        /// <summary>
        /// Gets and sets the property RangeMinimumValue. 
        /// <para>
        /// The minimum value for the filter value range.
        /// </para>
        /// </summary>
        public TimeRangeFilterValue RangeMinimumValue
        {
            get { return this._rangeMinimumValue; }
            set { this._rangeMinimumValue = value; }
        }

        // Check to see if RangeMinimumValue property is set
        internal bool IsSetRangeMinimumValue()
        {
            return this._rangeMinimumValue != null;
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <code>DateTime</code> values.
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

    }
}