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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Container for the parameters to the GetDataQualityMetrics operation.
    /// Returns details about the requested data quality metrics.
    /// </summary>
    public partial class GetDataQualityMetricsRequest : AmazonLookoutMetricsRequest
    {
        private string _anomalyDetectorArn;
        private string _metricSetArn;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the anomaly detector that you want to investigate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string AnomalyDetectorArn
        {
            get { return this._anomalyDetectorArn; }
            set { this._anomalyDetectorArn = value; }
        }

        // Check to see if AnomalyDetectorArn property is set
        internal bool IsSetAnomalyDetectorArn()
        {
            return this._anomalyDetectorArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a specific data quality metric set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string MetricSetArn
        {
            get { return this._metricSetArn; }
            set { this._metricSetArn = value; }
        }

        // Check to see if MetricSetArn property is set
        internal bool IsSetMetricSetArn()
        {
            return this._metricSetArn != null;
        }

    }
}