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
    /// The metrics of recommendations.
    /// </summary>
    public partial class RecommendationMetrics
    {
        private float? _costPerHour;
        private float? _costPerInference;
        private float? _cpuUtilization;
        private int? _maxInvocations;
        private float? _memoryUtilization;
        private int? _modelLatency;
        private int? _modelSetupTime;

        /// <summary>
        /// Gets and sets the property CostPerHour. 
        /// <para>
        /// Defines the cost per hour for the instance. 
        /// </para>
        /// </summary>
        public float? CostPerHour
        {
            get { return this._costPerHour; }
            set { this._costPerHour = value; }
        }

        // Check to see if CostPerHour property is set
        internal bool IsSetCostPerHour()
        {
            return this._costPerHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CostPerInference. 
        /// <para>
        /// Defines the cost per inference for the instance .
        /// </para>
        /// </summary>
        public float? CostPerInference
        {
            get { return this._costPerInference; }
            set { this._costPerInference = value; }
        }

        // Check to see if CostPerInference property is set
        internal bool IsSetCostPerInference()
        {
            return this._costPerInference.HasValue; 
        }

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
        [AWSProperty(Min=0)]
        public float? CpuUtilization
        {
            get { return this._cpuUtilization; }
            set { this._cpuUtilization = value; }
        }

        // Check to see if CpuUtilization property is set
        internal bool IsSetCpuUtilization()
        {
            return this._cpuUtilization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxInvocations. 
        /// <para>
        /// The expected maximum number of requests per minute for the instance.
        /// </para>
        /// </summary>
        public int? MaxInvocations
        {
            get { return this._maxInvocations; }
            set { this._maxInvocations = value; }
        }

        // Check to see if MaxInvocations property is set
        internal bool IsSetMaxInvocations()
        {
            return this._maxInvocations.HasValue; 
        }

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
        [AWSProperty(Min=0)]
        public float? MemoryUtilization
        {
            get { return this._memoryUtilization; }
            set { this._memoryUtilization = value; }
        }

        // Check to see if MemoryUtilization property is set
        internal bool IsSetMemoryUtilization()
        {
            return this._memoryUtilization.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelLatency. 
        /// <para>
        /// The expected model latency at maximum invocation per minute for the instance.
        /// </para>
        /// </summary>
        public int? ModelLatency
        {
            get { return this._modelLatency; }
            set { this._modelLatency = value; }
        }

        // Check to see if ModelLatency property is set
        internal bool IsSetModelLatency()
        {
            return this._modelLatency.HasValue; 
        }

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
        [AWSProperty(Min=0)]
        public int? ModelSetupTime
        {
            get { return this._modelSetupTime; }
            set { this._modelSetupTime = value; }
        }

        // Check to see if ModelSetupTime property is set
        internal bool IsSetModelSetupTime()
        {
            return this._modelSetupTime.HasValue; 
        }

    }
}