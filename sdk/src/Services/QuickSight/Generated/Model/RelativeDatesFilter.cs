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
    /// A <code>RelativeDatesFilter</code> filters relative dates values.
    /// </summary>
    public partial class RelativeDatesFilter
    {
        private AnchorDateConfiguration _anchorDateConfiguration;
        private ColumnIdentifier _column;
        private ExcludePeriodConfiguration _excludePeriodConfiguration;
        private string _filterId;
        private TimeGranularity _minimumGranularity;
        private FilterNullOption _nullOption;
        private string _parameterName;
        private RelativeDateType _relativeDateType;
        private int? _relativeDateValue;
        private TimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property AnchorDateConfiguration. 
        /// <para>
        /// The date configuration of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnchorDateConfiguration AnchorDateConfiguration
        {
            get { return this._anchorDateConfiguration; }
            set { this._anchorDateConfiguration = value; }
        }

        // Check to see if AnchorDateConfiguration property is set
        internal bool IsSetAnchorDateConfiguration()
        {
            return this._anchorDateConfiguration != null;
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
        /// Gets and sets the property ExcludePeriodConfiguration. 
        /// <para>
        /// The configuration for the exclude period of the filter.
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
        /// Gets and sets the property MinimumGranularity. 
        /// <para>
        /// The minimum granularity (period granularity) of the relative dates filter.
        /// </para>
        /// </summary>
        public TimeGranularity MinimumGranularity
        {
            get { return this._minimumGranularity; }
            set { this._minimumGranularity = value; }
        }

        // Check to see if MinimumGranularity property is set
        internal bool IsSetMinimumGranularity()
        {
            return this._minimumGranularity != null;
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
        /// Gets and sets the property RelativeDateType. 
        /// <para>
        /// The range date type of the filter. Choose one of the options below:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PREVIOUS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>THIS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LAST</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NOW</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NEXT</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RelativeDateType RelativeDateType
        {
            get { return this._relativeDateType; }
            set { this._relativeDateType = value; }
        }

        // Check to see if RelativeDateType property is set
        internal bool IsSetRelativeDateType()
        {
            return this._relativeDateType != null;
        }

        /// <summary>
        /// Gets and sets the property RelativeDateValue. 
        /// <para>
        /// The date value of the filter.
        /// </para>
        /// </summary>
        public int RelativeDateValue
        {
            get { return this._relativeDateValue.GetValueOrDefault(); }
            set { this._relativeDateValue = value; }
        }

        // Check to see if RelativeDateValue property is set
        internal bool IsSetRelativeDateValue()
        {
            return this._relativeDateValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <code>DateTime</code> values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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