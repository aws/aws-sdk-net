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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Details about the source of the anomalous operational data that triggered the anomaly.
    /// The one supported source is Amazon CloudWatch metrics.
    /// </summary>
    public partial class AnomalySourceDetails
    {
        private List<CloudWatchMetricsDetail> _cloudWatchMetrics = new List<CloudWatchMetricsDetail>();

        /// <summary>
        /// Gets and sets the property CloudWatchMetrics. 
        /// <para>
        ///  An array of <code>CloudWatchMetricsDetail</code> object that contains information
        /// about the analyzed metrics that displayed anomalous behavior. 
        /// </para>
        /// </summary>
        public List<CloudWatchMetricsDetail> CloudWatchMetrics
        {
            get { return this._cloudWatchMetrics; }
            set { this._cloudWatchMetrics = value; }
        }

        // Check to see if CloudWatchMetrics property is set
        internal bool IsSetCloudWatchMetrics()
        {
            return this._cloudWatchMetrics != null && this._cloudWatchMetrics.Count > 0; 
        }

    }
}