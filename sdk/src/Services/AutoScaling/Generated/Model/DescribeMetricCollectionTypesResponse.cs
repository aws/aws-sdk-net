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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This is the response object from the DescribeMetricCollectionTypes operation.
    /// </summary>
    public partial class DescribeMetricCollectionTypesResponse : AmazonWebServiceResponse
    {
        private List<MetricGranularityType> _granularities = new List<MetricGranularityType>();
        private List<MetricCollectionType> _metrics = new List<MetricCollectionType>();

        /// <summary>
        /// Gets and sets the property Granularities. 
        /// <para>
        /// The granularities for the metrics.
        /// </para>
        /// </summary>
        public List<MetricGranularityType> Granularities
        {
            get { return this._granularities; }
            set { this._granularities = value; }
        }

        // Check to see if Granularities property is set
        internal bool IsSetGranularities()
        {
            return this._granularities != null && this._granularities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// One or more metrics.
        /// </para>
        /// </summary>
        public List<MetricCollectionType> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

    }
}