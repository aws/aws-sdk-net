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
    /// A <c>TopBottomFilter</c> filters values that are at the top or the bottom.
    /// </summary>
    public partial class TopBottomFilter
    {
        private List<AggregationSortConfiguration> _aggregationSortConfigurations = AWSConfigs.InitializeCollections ? new List<AggregationSortConfiguration>() : null;
        private ColumnIdentifier _column;
        private DefaultFilterControlConfiguration _defaultFilterControlConfiguration;
        private string _filterId;
        private int? _limit;
        private string _parameterName;
        private TimeGranularity _timeGranularity;

        /// <summary>
        /// Gets and sets the property AggregationSortConfigurations. 
        /// <para>
        /// The aggregation and sort configuration of the top bottom filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public List<AggregationSortConfiguration> AggregationSortConfigurations
        {
            get { return this._aggregationSortConfigurations; }
            set { this._aggregationSortConfigurations = value; }
        }

        // Check to see if AggregationSortConfigurations property is set
        internal bool IsSetAggregationSortConfigurations()
        {
            return this._aggregationSortConfigurations != null && (this._aggregationSortConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property DefaultFilterControlConfiguration. 
        /// <para>
        /// The default configurations for the associated controls. This applies only for filters
        /// that are scoped to multiple sheets.
        /// </para>
        /// </summary>
        public DefaultFilterControlConfiguration DefaultFilterControlConfiguration
        {
            get { return this._defaultFilterControlConfiguration; }
            set { this._defaultFilterControlConfiguration = value; }
        }

        // Check to see if DefaultFilterControlConfiguration property is set
        internal bool IsSetDefaultFilterControlConfiguration()
        {
            return this._defaultFilterControlConfiguration != null;
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
        /// Gets and sets the property Limit. 
        /// <para>
        /// The number of items to include in the top bottom filter results.
        /// </para>
        /// </summary>
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
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
        /// Gets and sets the property TimeGranularity. 
        /// <para>
        /// The level of time precision that is used to aggregate <c>DateTime</c> values.
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