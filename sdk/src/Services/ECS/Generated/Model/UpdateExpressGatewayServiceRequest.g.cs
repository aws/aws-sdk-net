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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateExpressGatewayService operation. Updates
    /// an existing Express service configuration. Modifies container settings, resource allocation,
    /// auto-scaling configuration, and other service parameters without recreating the service.
    /// <para> Amazon ECS creates a new service revision with updated configuration and performs
    /// a rolling deployment to replace existing tasks. The service remains available during
    /// updates, ensuring zero-downtime deployments. </para> <para> Some parameters like the
    /// infrastructure role cannot be modified after service creation and require creating
    /// a new service. </para>
    /// </summary>
    public partial class UpdateExpressGatewayServiceRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the task.
        /// </para>
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property CpuArchitecture. 
        /// <para>
        /// The CPU architecture that the task runs on. If you don't specify a value, the service
        /// keeps its current architecture.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>X86_64</c> - The x86 64-bit architecture.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARM64</c> - The 64-bit ARM architecture.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Changing the architecture starts a new deployment that replaces the running tasks.
        /// Ensure that the container image you specify supports the architecture you choose.
        /// The operating system family for an Express service is always <c>LINUX</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't specify <c>cpuArchitecture</c> together with <c>taskDefinitionArn</c>.
        /// </para>
        /// </summary>
        public ExpressCpuArchitecture CpuArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the CpuArchitecture property is set.
        /// </summary>
        internal bool IsSetCpuArchitecture() => this.CpuArchitecture != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution role for the Express service.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property HealthCheckPath. 
        /// <para>
        /// The path on the container for Application Load Balancer health checks.
        /// </para>
        /// </summary>
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) used by the task.
        /// </para>
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for the Express service tasks. By default, the network configuration
        /// for an Express service uses the default VPC.
        /// </para>
        /// </summary>
        public ExpressGatewayServiceNetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property PrimaryContainer. 
        /// <para>
        /// The primary container configuration for the Express service.
        /// </para>
        /// </summary>
        public ExpressGatewayContainer PrimaryContainer { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryContainer property is set.
        /// </summary>
        internal bool IsSetPrimaryContainer() => this.PrimaryContainer != null;

        /// <summary>
        /// Gets and sets the property ScalingTarget. 
        /// <para>
        /// The auto-scaling configuration for the Express service.
        /// </para>
        /// </summary>
        public ExpressGatewayScalingTarget ScalingTarget { get; set; }

        /// <summary>
        /// Checks to see if the ScalingTarget property is set.
        /// </summary>
        internal bool IsSetScalingTarget() => this.ScalingTarget != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Express service to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a task definition to use to update the Express Gateway
        /// service. This allows you to manage your own task definition, giving you more control
        /// over the service configuration such as adding sidecar containers.
        /// </para>
        ///  
        /// <para>
        /// The task definition must have a container named <c>Main</c> with a single TCP port
        /// mapping that includes a container port and port name. The task definition must also
        /// have <c>FARGATE</c> compatibility.
        /// </para>
        ///  
        /// <para>
        /// If you provide a task definition ARN, you cannot also specify <c>primaryContainer</c>,
        /// <c>executionRoleArn</c>, <c>taskRoleArn</c>, <c>cpu</c>, <c>memory</c>, or <c>cpuArchitecture</c>.
        /// </para>
        /// </summary>
        public string TaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetTaskDefinitionArn() => this.TaskDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role for containers in this task.
        /// </para>
        /// </summary>
        public string TaskRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskRoleArn property is set.
        /// </summary>
        internal bool IsSetTaskRoleArn() => this.TaskRoleArn != null;
    }
}
