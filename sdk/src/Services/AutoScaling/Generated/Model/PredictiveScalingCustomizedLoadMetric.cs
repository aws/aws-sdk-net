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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a custom load metric for a predictive scaling policy.
    /// </summary>
    public partial class PredictiveScalingCustomizedLoadMetric
    {
        private List<MetricDataQuery> _metricDataQueries = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;

        /// <summary>
        /// Gets and sets the property MetricDataQueries. 
        /// <para>
        /// One or more metric data queries to provide the data points for a load metric. Use
        /// multiple metric data queries only if you are performing a math expression on returned
        /// data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricDataQuery> MetricDataQueries
        {
            get { return this._metricDataQueries; }
            set { this._metricDataQueries = value; }
        }

        // Check to see if MetricDataQueries property is set
        internal bool IsSetMetricDataQueries()
        {
            return this._metricDataQueries != null && (this._metricDataQueries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}