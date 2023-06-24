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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// This is the response object from the ListAvailableResourceMetrics operation.
    /// </summary>
    public partial class ListAvailableResourceMetricsResponse : AmazonWebServiceResponse
    {
        private List<ResponseResourceMetric> _metrics = new List<ResponseResourceMetric>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// An array of metrics available to query. Each array element contains the full name,
        /// description, and unit of the metric. 
        /// </para>
        /// </summary>
        public List<ResponseResourceMetric> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that indicates the response didn’t return all available records
        /// because <code>MaxRecords</code> was specified in the previous request. To get the
        /// remaining records, specify <code>NextToken</code> in a separate request with this
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}