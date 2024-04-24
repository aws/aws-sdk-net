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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The performance results from running an Inference Recommender job on an existing endpoint.
    /// </summary>
    public partial class EndpointPerformance
    {
        private EndpointInfo _endpointInfo;
        private InferenceMetrics _metrics;

        /// <summary>
        /// Gets and sets the property EndpointInfo.
        /// </summary>
        [AWSProperty(Required=true)]
        public EndpointInfo EndpointInfo
        {
            get { return this._endpointInfo; }
            set { this._endpointInfo = value; }
        }

        // Check to see if EndpointInfo property is set
        internal bool IsSetEndpointInfo()
        {
            return this._endpointInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics for an existing endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InferenceMetrics Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null;
        }

    }
}