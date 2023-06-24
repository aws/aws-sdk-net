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
    /// This is the response object from the ListAvailableResourceDimensions operation.
    /// </summary>
    public partial class ListAvailableResourceDimensionsResponse : AmazonWebServiceResponse
    {
        private List<MetricDimensionGroups> _metricDimensions = new List<MetricDimensionGroups>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MetricDimensions. 
        /// <para>
        /// The dimension information returned for requested metric types.
        /// </para>
        /// </summary>
        public List<MetricDimensionGroups> MetricDimensions
        {
            get { return this._metricDimensions; }
            set { this._metricDimensions = value; }
        }

        // Check to see if MetricDimensions property is set
        internal bool IsSetMetricDimensions()
        {
            return this._metricDimensions != null && this._metricDimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the token, up to the value specified
        /// by <code>MaxRecords</code>.
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