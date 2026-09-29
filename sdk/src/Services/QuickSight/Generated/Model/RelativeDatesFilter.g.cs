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
    /// A <c>RelativeDatesFilter</c> filters relative dates values.
    /// </summary>
    public partial class RelativeDatesFilter
    {
        /// <summary>
        /// Gets and sets the property AnchorDateConfiguration. 
        /// <para>
        /// The date configuration of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnchorDateConfiguration AnchorDateConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AnchorDateConfiguration property is set.
        /// </summary>
        internal bool IsSetAnchorDateConfiguration() => this.AnchorDateConfiguration != null;

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
        /// The configuration for the exclude period of the filter.
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
        /// Gets and sets the property MinimumGranularity. 
        /// <para>
        /// The minimum granularity (period granularity) of the relative dates filter.
        /// </para>
        /// </summary>
        public TimeGranularity MinimumGranularity { get; set; }

        /// <summary>
        /// Checks to see if the MinimumGranularity property is set.
        /// </summary>
        internal bool IsSetMinimumGranularity() => this.MinimumGranularity != null;

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
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The parameter whose value should be used for the filter value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;

        /// <summary>
        /// Gets and sets the property RelativeDateType. 
        /// <para>
        /// The range date type of the filter. Choose one of the options below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PREVIOUS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THIS</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LAST</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOW</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEXT</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelativeDateType RelativeDateType { get; set; }

        /// <summary>
        /// Checks to see if the RelativeDateType property is set.
        /// </summary>
        internal bool IsSetRelativeDateType() => this.RelativeDateType != null;

        /// <summary>
        /// Gets and sets the property RelativeDateValue. 
        /// <para>
        /// The date value of the filter.
        /// </para>
        /// </summary>
        public int? RelativeDateValue { get; set; }

        /// <summary>
        /// Checks to see if the RelativeDateValue property is set.
        /// </summary>
        internal bool IsSetRelativeDateValue() => this.RelativeDateValue.HasValue;

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeGranularity TimeGranularity { get; set; }

        /// <summary>
        /// Checks to see if the TimeGranularity property is set.
        /// </summary>
        internal bool IsSetTimeGranularity() => this.TimeGranularity != null;
    }
}
