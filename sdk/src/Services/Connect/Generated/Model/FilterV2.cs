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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains the filter to apply when retrieving metrics with the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricDataV2.html">GetMetricDataV2</a>
    /// API.
    /// </summary>
    public partial class FilterV2
    {
        private string _filterKey;
        private List<string> _filterValues = new List<string>();

        /// <summary>
        /// Gets and sets the property FilterKey. 
        /// <para>
        /// The key to use for filtering data. For example, <code>QUEUE</code>, <code>ROUTING_PROFILE,
        /// AGENT</code>, <code>CHANNEL</code>, <code>AGENT_HIERARCHY_LEVEL_ONE</code>, <code>AGENT_HIERARCHY_LEVEL_TWO</code>,
        /// <code>AGENT_HIERARCHY_LEVEL_THREE</code>, <code>AGENT_HIERARCHY_LEVEL_FOUR</code>,
        /// <code>AGENT_HIERARCHY_LEVEL_FIVE</code>. There must be at least 1 key and a maximum
        /// 5 keys. 
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
        /// <code>QUEUE</code>, you would add queue IDs or ARNs in <code>FilterValues</code>.
        /// 
        /// </para>
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
            return this._filterValues != null && this._filterValues.Count > 0; 
        }

    }
}