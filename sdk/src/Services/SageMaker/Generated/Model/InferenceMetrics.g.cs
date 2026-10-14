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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// The metrics for an existing endpoint compared in an Inference Recommender job.
    /// </summary>
    public partial class InferenceMetrics
    {
        /// <summary>
        /// Gets and sets the property MaxInvocations. 
        /// <para>
        /// The expected maximum number of requests per minute for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? MaxInvocations { get; set; }

        /// <summary>
        /// Checks to see if the MaxInvocations property is set.
        /// </summary>
        internal bool IsSetMaxInvocations() => this.MaxInvocations.HasValue;

        /// <summary>
        /// Gets and sets the property ModelLatency. 
        /// <para>
        /// The expected model latency at maximum invocations per minute for the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ModelLatency { get; set; }

        /// <summary>
        /// Checks to see if the ModelLatency property is set.
        /// </summary>
        internal bool IsSetModelLatency() => this.ModelLatency.HasValue;
    }
}
