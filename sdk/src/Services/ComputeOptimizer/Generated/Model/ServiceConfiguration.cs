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
    /// The Amazon ECS service configurations used for recommendations.
    /// </summary>
    public partial class ServiceConfiguration
    {
        private AutoScalingConfiguration _autoScalingConfiguration;
        private List<ContainerConfiguration> _containerConfigurations = new List<ContainerConfiguration>();
        private int? _cpu;
        private int? _memory;
        private string _taskDefinitionArn;

        /// <summary>
        /// Gets and sets the property AutoScalingConfiguration. 
        /// <para>
        ///  Describes the Auto Scaling configuration methods for an Amazon ECS service. This
        /// affects the generated recommendations. For example, if Auto Scaling is configured
        /// on a service’s CPU, then Compute Optimizer doesn’t generate CPU size recommendations.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The Auto Scaling configuration methods include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TARGET_TRACKING_SCALING_CPU</code> — If the Amazon ECS service is configured
        /// to use target scaling on CPU, Compute Optimizer doesn't generate CPU recommendations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TARGET_TRACKING_SCALING_MEMORY</code> — If the Amazon ECS service is configured
        /// to use target scaling on memory, Compute Optimizer doesn't generate memory recommendations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about step scaling and target scaling, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">
        /// Step scaling policies for Application Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html">
        /// Target tracking scaling policies for Application Auto Scaling</a> in the <i>Application
        /// Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public AutoScalingConfiguration AutoScalingConfiguration
        {
            get { return this._autoScalingConfiguration; }
            set { this._autoScalingConfiguration = value; }
        }

        // Check to see if AutoScalingConfiguration property is set
        internal bool IsSetAutoScalingConfiguration()
        {
            return this._autoScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerConfigurations. 
        /// <para>
        ///  The container configurations within a task of an Amazon ECS service. 
        /// </para>
        /// </summary>
        public List<ContainerConfiguration> ContainerConfigurations
        {
            get { return this._containerConfigurations; }
            set { this._containerConfigurations = value; }
        }

        // Check to see if ContainerConfigurations property is set
        internal bool IsSetContainerConfigurations()
        {
            return this._containerConfigurations != null && this._containerConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The number of CPU units used by the tasks in the Amazon ECS service. 
        /// </para>
        /// </summary>
        public int Cpu
        {
            get { return this._cpu.GetValueOrDefault(); }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        ///  The amount of memory used by the tasks in the Amazon ECS service. 
        /// </para>
        /// </summary>
        public int Memory
        {
            get { return this._memory.GetValueOrDefault(); }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        ///  The task definition ARN used by the tasks in the Amazon ECS service. 
        /// </para>
        /// </summary>
        public string TaskDefinitionArn
        {
            get { return this._taskDefinitionArn; }
            set { this._taskDefinitionArn = value; }
        }

        // Check to see if TaskDefinitionArn property is set
        internal bool IsSetTaskDefinitionArn()
        {
            return this._taskDefinitionArn != null;
        }

    }
}