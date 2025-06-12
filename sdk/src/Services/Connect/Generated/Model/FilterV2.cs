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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the filter to apply when retrieving metrics with the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricDataV2.html">GetMetricDataV2</a>
    /// API.
    /// </summary>
    public partial class FilterV2
    {
        private string _filterKey;
        private List<string> _filterValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FilterKey. 
        /// <para>
        /// The key to use for filtering data. For example, <c>QUEUE</c>, <c>ROUTING_PROFILE,
        /// AGENT</c>, <c>CHANNEL</c>, <c>AGENT_HIERARCHY_LEVEL_ONE</c>, <c>AGENT_HIERARCHY_LEVEL_TWO</c>,
        /// <c>AGENT_HIERARCHY_LEVEL_THREE</c>, <c>AGENT_HIERARCHY_LEVEL_FOUR</c>, <c>AGENT_HIERARCHY_LEVEL_FIVE</c>.
        /// There must be at least 1 key and a maximum 5 keys. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string FilterKey
        {
            get { return this._filterKey; }
            set { this._filterKey = value; }
        }

        // Check to see if FilterKey property is set
        internal bool IsSetFilterKey()
        {
            return this._filterKey != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValues. 
        /// <para>
        /// The identifiers to use for filtering data. For example, if you have a filter key of
        /// <c>QUEUE</c>, you would add queue IDs or ARNs in <c>FilterValues</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> FilterValues
        {
            get { return this._filterValues; }
            set { this._filterValues = value; }
        }

        // Check to see if FilterValues property is set
        internal bool IsSetFilterValues()
        {
            return this._filterValues != null && (this._filterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}