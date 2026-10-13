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
    /// The metric for a scaling policy.
    /// </summary>
    public partial class ScalingPolicyMetric
    {
        /// <summary>
        /// Gets and sets the property InvocationsPerInstance. 
        /// <para>
        /// The number of invocations sent to a model, normalized by <c>InstanceCount</c> in each
        /// ProductionVariant. <c>1/numberOfInstances</c> is sent as the value on each request,
        /// where <c>numberOfInstances</c> is the number of active instances for the ProductionVariant
        /// behind the endpoint at the time of the request.
        /// </para>
        /// </summary>
        public int? InvocationsPerInstance { get; set; }

        /// <summary>
        /// Checks to see if the InvocationsPerInstance property is set.
        /// </summary>
        internal bool IsSetInvocationsPerInstance() => this.InvocationsPerInstance.HasValue;

        /// <summary>
        /// Gets and sets the property ModelLatency. 
        /// <para>
        /// The interval of time taken by a model to respond as viewed from SageMaker. This interval
        /// includes the local communication times taken to send the request and to fetch the
        /// response from the container of a model and the time taken to complete the inference
        /// in the container.
        /// </para>
        /// </summary>
        public int? ModelLatency { get; set; }

        /// <summary>
        /// Checks to see if the ModelLatency property is set.
        /// </summary>
        internal bool IsSetModelLatency() => this.ModelLatency.HasValue;
    }
}
