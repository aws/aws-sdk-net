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

namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// This is the response object from the DetectMetricSetConfig operation.
    /// </summary>
    public partial class DetectMetricSetConfigResponse : AmazonWebServiceResponse
    {
        private DetectedMetricSetConfig _detectedMetricSetConfig;

        /// <summary>
        /// Gets and sets the property DetectedMetricSetConfig. 
        /// <para>
        /// The inferred dataset configuration for the datasource.
        /// </para>
        /// </summary>
        public DetectedMetricSetConfig DetectedMetricSetConfig
        {
            get { return this._detectedMetricSetConfig; }
            set { this._detectedMetricSetConfig = value; }
        }

        // Check to see if DetectedMetricSetConfig property is set
        internal bool IsSetDetectedMetricSetConfig()
        {
            return this._detectedMetricSetConfig != null;
        }

    }
}