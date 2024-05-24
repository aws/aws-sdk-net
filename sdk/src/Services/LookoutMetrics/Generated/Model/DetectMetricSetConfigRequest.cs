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
    /// Container for the parameters to the DetectMetricSetConfig operation.
    /// Detects an Amazon S3 dataset's file format, interval, and offset.
    /// </summary>
    public partial class DetectMetricSetConfigRequest : AmazonLookoutMetricsRequest
    {
        private string _anomalyDetectorArn;
        private AutoDetectionMetricSource _autoDetectionMetricSource;

        /// <summary>
        /// Gets and sets the property AnomalyDetectorArn. 
        /// <para>
        /// An anomaly detector ARN.
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
        /// Gets and sets the property AutoDetectionMetricSource. 
        /// <para>
        /// A data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoDetectionMetricSource AutoDetectionMetricSource
        {
            get { return this._autoDetectionMetricSource; }
            set { this._autoDetectionMetricSource = value; }
        }

        // Check to see if AutoDetectionMetricSource property is set
        internal bool IsSetAutoDetectionMetricSource()
        {
            return this._autoDetectionMetricSource != null;
        }

    }
}