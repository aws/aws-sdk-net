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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The metrics for an existing endpoint compared in an Inference Recommender job.
    /// </summary>
    public partial class InferenceMetrics
    {
        private int? _maxInvocations;
        private int? _modelLatency;

        /// <summary>
        /// Gets and sets the property MaxInvocations. 
        /// <para>
        /// The expected maximum number of requests per minute for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int MaxInvocations
        {
            get { return this._maxInvocations.GetValueOrDefault(); }
            set { this._maxInvocations = value; }
        }

        // Check to see if MaxInvocations property is set
        internal bool IsSetMaxInvocations()
        {
            return this._maxInvocations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelLatency. 
        /// <para>
        /// The expected model latency at maximum invocations per minute for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ModelLatency
        {
            get { return this._modelLatency.GetValueOrDefault(); }
            set { this._modelLatency = value; }
        }

        // Check to see if ModelLatency property is set
        internal bool IsSetModelLatency()
        {
            return this._modelLatency.HasValue; 
        }

    }
}