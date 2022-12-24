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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetECSServiceRecommendationProjectedMetrics operation.
    /// </summary>
    public partial class GetECSServiceRecommendationProjectedMetricsResponse : AmazonWebServiceResponse
    {
        private List<ECSServiceRecommendedOptionProjectedMetric> _recommendedOptionProjectedMetrics = new List<ECSServiceRecommendedOptionProjectedMetric>();

        /// <summary>
        /// Gets and sets the property RecommendedOptionProjectedMetrics. 
        /// <para>
        ///  An array of objects that describes the projected metrics. 
        /// </para>
        /// </summary>
        public List<ECSServiceRecommendedOptionProjectedMetric> RecommendedOptionProjectedMetrics
        {
            get { return this._recommendedOptionProjectedMetrics; }
            set { this._recommendedOptionProjectedMetrics = value; }
        }

        // Check to see if RecommendedOptionProjectedMetrics property is set
        internal bool IsSetRecommendedOptionProjectedMetrics()
        {
            return this._recommendedOptionProjectedMetrics != null && this._recommendedOptionProjectedMetrics.Count > 0; 
        }

    }
}