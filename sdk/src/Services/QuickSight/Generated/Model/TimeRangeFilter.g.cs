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
    /// A <c>TimeRangeFilter</c> filters values that are between two specified values.
    /// </summary>
    public partial class TimeRangeFilter
    {
        /// <summary>
        /// Gets and sets the property Column. 
        /// <para>
        /// The column that the filter is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ColumnIdentifier Column { get; set; }

        /// <summary>
        /// Checks to see if the Column property is set.
        /// </summary>
        internal bool IsSetColumn() => this.Column != null;

        /// <summary>
        /// Gets and sets the property DefaultFilterControlConfiguration. 
        /// <para>
        /// The default configurations for the associated controls. This applies only for filters
        /// that are scoped to multiple sheets.
        /// </para>
        /// </summary>
        public DefaultFilterControlConfiguration DefaultFilterControlConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DefaultFilterControlConfiguration property is set.
        /// </summary>
        internal bool IsSetDefaultFilterControlConfiguration() => this.DefaultFilterControlConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExcludePeriodConfiguration. 
        /// <para>
        /// The exclude period of the time range filter.
        /// </para>
        /// </summary>
        public ExcludePeriodConfiguration ExcludePeriodConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExcludePeriodConfiguration property is set.
        /// </summary>
        internal bool IsSetExcludePeriodConfiguration() => this.ExcludePeriodConfiguration != null;

        /// <summary>
        /// Gets and sets the property FilterId. 
        /// <para>
        /// An identifier that uniquely identifies a filter within a dashboard, analysis, or template.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FilterId { get; set; }

        /// <summary>
        /// Checks to see if the FilterId property is set.
        /// </summary>
        internal bool IsSetFilterId() => this.FilterId != null;

        /// <summary>
        /// Gets and sets the property IncludeMaximum. 
        /// <para>
        /// Determines whether the maximum value in the filter value range should be included
        /// in the filtered results.
        /// </para>
        /// </summary>
        public bool? IncludeMaximum { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMaximum property is set.
        /// </summary>
        internal bool IsSetIncludeMaximum() => this.IncludeMaximum.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeMinimum. 
        /// <para>
        /// Determines whether the minimum value in the filter value range should be included
        /// in the filtered results.
        /// </para>
        /// </summary>
        public bool? IncludeMinimum { get; set; }

        /// <summary>
        /// Checks to see if the IncludeMinimum property is set.
        /// </summary>
        internal bool IsSetIncludeMinimum() => this.IncludeMinimum.HasValue;

        /// <summary>
        /// Gets and sets the property NullOption. 
        /// <para>
        /// This option determines how null values should be treated when filtering data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL_VALUES</c>: Include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NULLS_ONLY</c>: Only include null values in filtered results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_NULLS_ONLY</c>: Exclude null values from filtered results.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public FilterNullOption NullOption { get; set; }

        /// <summary>
        /// Checks to see if the NullOption property is set.
        /// </summary>
        internal bool IsSetNullOption() => this.NullOption != null;

        /// <summary>
        /// Gets and sets the property RangeMaximumValue. 
        /// <para>
        /// The maximum value for the filter value range.
        /// </para>
        /// </summary>
        public TimeRangeFilterValue RangeMaximumValue { get; set; }

        /// <summary>
        /// Checks to see if the RangeMaximumValue property is set.
        /// </summary>
        internal bool IsSetRangeMaximumValue() => this.RangeMaximumValue != null;

        /// <summary>
        /// Gets and sets the property RangeMinimumValue. 
        /// <para>
        /// The minimum value for the filter value range.
        /// </para>
        /// </summary>
        public TimeRangeFilterValue RangeMinimumValue { get; set; }

        /// <summary>
        /// Checks to see if the RangeMinimumValue property is set.
        /// </summary>
        internal bool IsSetRangeMinimumValue() => this.RangeMinimumValue != null;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        public TimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;
    }
}
