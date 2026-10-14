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
    /// The metrics of recommendations.
    /// </summary>
    public partial class RecommendationMetrics
    {
        /// <summary>
        /// Gets and sets the property CostPerHour. 
        /// <para>
        /// Defines the cost per hour for the instance. 
        /// </para>
        /// </summary>
        public float? CostPerHour { get; set; }

        /// <summary>
        /// Checks to see if the CostPerHour property is set.
        /// </summary>
        internal bool IsSetCostPerHour() => this.CostPerHour.HasValue;

        /// <summary>
        /// Gets and sets the property CostPerInference. 
        /// <para>
        /// Defines the cost per inference for the instance .
        /// </para>
        /// </summary>
        public float? CostPerInference { get; set; }

        /// <summary>
        /// Checks to see if the CostPerInference property is set.
        /// </summary>
        internal bool IsSetCostPerInference() => this.CostPerInference.HasValue;

        /// <summary>
        /// Gets and sets the property CpuUtilization. 
        /// <para>
        /// The expected CPU utilization at maximum invocations per minute for the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>NaN</c> indicates that the value is not available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? CpuUtilization { get; set; }

        /// <summary>
        /// Checks to see if the CpuUtilization property is set.
        /// </summary>
        internal bool IsSetCpuUtilization() => this.CpuUtilization.HasValue;

        /// <summary>
        /// Gets and sets the property MaxInvocations. 
        /// <para>
        /// The expected maximum number of requests per minute for the instance.
        /// </para>
        /// </summary>
        public int? MaxInvocations { get; set; }

        /// <summary>
        /// Checks to see if the MaxInvocations property is set.
        /// </summary>
        internal bool IsSetMaxInvocations() => this.MaxInvocations.HasValue;

        /// <summary>
        /// Gets and sets the property MemoryUtilization. 
        /// <para>
        /// The expected memory utilization at maximum invocations per minute for the instance.
        /// </para>
        ///  
        /// <para>
        ///  <c>NaN</c> indicates that the value is not available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public float? MemoryUtilization { get; set; }

        /// <summary>
        /// Checks to see if the MemoryUtilization property is set.
        /// </summary>
        internal bool IsSetMemoryUtilization() => this.MemoryUtilization.HasValue;

        /// <summary>
        /// Gets and sets the property ModelLatency. 
        /// <para>
        /// The expected model latency at maximum invocation per minute for the instance.
        /// </para>
        /// </summary>
        public int? ModelLatency { get; set; }

        /// <summary>
        /// Checks to see if the ModelLatency property is set.
        /// </summary>
        internal bool IsSetModelLatency() => this.ModelLatency.HasValue;

        /// <summary>
        /// Gets and sets the property ModelSetupTime. 
        /// <para>
        /// The time it takes to launch new compute resources for a serverless endpoint. The time
        /// can vary depending on the model size, how long it takes to download the model, and
        /// the start-up time of the container.
        /// </para>
        ///  
        /// <para>
        ///  <c>NaN</c> indicates that the value is not available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ModelSetupTime { get; set; }

        /// <summary>
        /// Checks to see if the ModelSetupTime property is set.
        /// </summary>
        internal bool IsSetModelSetupTime() => this.ModelSetupTime.HasValue;
    }
}
