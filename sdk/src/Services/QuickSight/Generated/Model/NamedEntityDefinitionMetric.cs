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
    /// A structure that represents a metric.
    /// </summary>
    public partial class NamedEntityDefinitionMetric
    {
        private NamedEntityAggType _aggregation;
        private Dictionary<string, string> _aggregationFunctionParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// The aggregation of a named entity. Valid values for this structure are <c>SUM</c>,
        /// <c>MIN</c>, <c>MAX</c>, <c>COUNT</c>, <c>AVERAGE</c>, <c>DISTINCT_COUNT</c>, <c>STDEV</c>,
        /// <c>STDEVP</c>, <c>VAR</c>, <c>VARP</c>, <c>PERCENTILE</c>, <c>MEDIAN</c>, and <c>CUSTOM</c>.
        /// </para>
        /// </summary>
        public NamedEntityAggType Aggregation
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
        /// The additional parameters for an aggregation function.
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

    }
}