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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// The Amazon ECS service configurations used for recommendations.
    /// </summary>
    public partial class ServiceConfiguration
    {
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
        ///  <c>TARGET_TRACKING_SCALING_CPU</c> — If the Amazon ECS service is configured to use
        /// target scaling on CPU, Compute Optimizer doesn't generate CPU recommendations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TARGET_TRACKING_SCALING_MEMORY</c> — If the Amazon ECS service is configured to
        /// use target scaling on memory, Compute Optimizer doesn't generate memory recommendations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about step scaling and target scaling, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">
        /// Step scaling policies for Application Auto Scaling</a> and <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html">
        /// Target tracking scaling policies for Application Auto Scaling</a> in the <i>Application
        /// Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public AutoScalingConfiguration AutoScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoScalingConfiguration() => this.AutoScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ContainerConfigurations. 
        /// <para>
        ///  The container configurations within a task of an Amazon ECS service. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ContainerConfiguration> ContainerConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ContainerConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ContainerConfigurations property is set.
        /// </summary>
        internal bool IsSetContainerConfigurations() => this.ContainerConfigurations != null && (this.ContainerConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        ///  The number of CPU units used by the tasks in the Amazon ECS service. 
        /// </para>
        /// </summary>
        public int? Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu.HasValue;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        ///  The amount of memory used by the tasks in the Amazon ECS service. 
        /// </para>
        /// </summary>
        public int? Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory.HasValue;

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        ///  The task definition ARN used by the tasks in the Amazon ECS service. 
        /// </para>
        /// </summary>
        public string TaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetTaskDefinitionArn() => this.TaskDefinitionArn != null;
    }
}
