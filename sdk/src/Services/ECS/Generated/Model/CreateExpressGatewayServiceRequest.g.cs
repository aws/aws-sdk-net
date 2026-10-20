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
    /// Container for the parameters to the CreateExpressGatewayService operation. Creates
    /// an Express service that simplifies deploying containerized web applications on Amazon
    /// ECS with managed Amazon Web Services infrastructure. This operation provisions and
    /// configures Application Load Balancers, target groups, security groups, and auto-scaling
    /// policies automatically. <para> Specify a primary container configuration with your
    /// application image and basic settings. Amazon ECS creates the necessary Amazon Web
    /// Services resources for traffic distribution, health monitoring, network access control,
    /// and capacity management. </para> <para> Provide an execution role for task operations
    /// and an infrastructure role for managing Amazon Web Services resources on your behalf.
    /// </para>
    /// </summary>
    public partial class CreateExpressGatewayServiceRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster on which to create
        /// the Express service. If you do not specify a cluster, the <c>default</c> cluster is
        /// assumed.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the task. This parameter determines the CPU allocation
        /// for each task in the Express service. The default value for an Express service is
        /// 256 (.25 vCPU).
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
        /// The CPU architecture that the task runs on. If you don't specify a value, the default
        /// is <c>X86_64</c>.
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
        /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS
        /// container agent permission to make Amazon Web Services API calls on your behalf. This
        /// role is required for Amazon ECS to pull container images from Amazon ECR, send container
        /// logs to Amazon CloudWatch Logs, and retrieve sensitive data from Amazon Web Services
        /// Systems Manager Parameter Store or Amazon Web Services Secrets Manager.
        /// </para>
        ///  
        /// <para>
        /// The execution role must include the <c>AmazonECSTaskExecutionRolePolicy</c> managed
        /// policy or equivalent permissions. For Express services, this role is used during task
        /// startup and runtime for container management operations.
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
        /// The path on the container that the Application Load Balancer uses for health checks.
        /// This should be a valid HTTP endpoint that returns a successful response (HTTP 200)
        /// when the application is healthy.
        /// </para>
        ///  
        /// <para>
        /// If not specified, the default health check path is <c>/ping</c>. The health check
        /// path must start with a forward slash and can include query parameters. Examples: <c>/health</c>,
        /// <c>/api/status</c>, <c>/ping?format=json</c>.
        /// </para>
        /// </summary>
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property InfrastructureRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the infrastructure role that grants Amazon ECS permission
        /// to create and manage Amazon Web Services resources on your behalf for the Express
        /// service. This role is used to provision and manage Application Load Balancers, target
        /// groups, security groups, auto-scaling policies, and other Amazon Web Services infrastructure
        /// components.
        /// </para>
        ///  
        /// <para>
        /// The infrastructure role must include permissions for Elastic Load Balancing, Application
        /// Auto Scaling, Amazon EC2 (for security groups), and other services required for managed
        /// infrastructure. This role is only used during Express service creation, updates, and
        /// deletion operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InfrastructureRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureRoleArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureRoleArn() => this.InfrastructureRoleArn != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) used by the task. This parameter determines the memory
        /// allocation for each task in the Express service. The default value for an express
        /// service is 512 MiB.
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
        /// The network configuration for the Express service tasks. This specifies the VPC subnets
        /// and security groups for the tasks.
        /// </para>
        ///  
        /// <para>
        /// For Express services, you can specify custom security groups and subnets. If not provided,
        /// Amazon ECS will use the default VPC configuration and create appropriate security
        /// groups automatically. The network configuration determines how your service integrates
        /// with your VPC and what network access it has.
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
        /// The primary container configuration for the Express service. This defines the main
        /// application container that will receive traffic from the Application Load Balancer.
        /// </para>
        ///  
        /// <para>
        /// The primary container must specify at minimum a container image. You can also configure
        /// the container port (defaults to 80), logging configuration, environment variables,
        /// secrets, and startup commands. The container image can be from Amazon ECR, Docker
        /// Hub, or any other container registry accessible to your execution role.
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
        /// The auto-scaling configuration for the Express service. This defines how the service
        /// automatically adjusts the number of running tasks based on demand.
        /// </para>
        ///  
        /// <para>
        /// You can specify the minimum and maximum number of tasks, the scaling metric (CPU utilization,
        /// memory utilization, or request count per target), and the target value for the metric.
        /// If not specified, the default target value for an Express service is 60.
        /// </para>
        /// </summary>
        public ExpressGatewayScalingTarget ScalingTarget { get; set; }

        /// <summary>
        /// Checks to see if the ScalingTarget property is set.
        /// </summary>
        internal bool IsSetScalingTarget() => this.ScalingTarget != null;

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the Express service. This name must be unique within the specified cluster
        /// and can contain up to 255 letters (uppercase and lowercase), numbers, underscores,
        /// and hyphens. The name is used to identify the service in the Amazon ECS console and
        /// API operations.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a service name, Amazon ECS generates a unique name for the service.
        /// The service name becomes part of the service ARN and cannot be changed after the service
        /// is created.
        /// </para>
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceName property is set.
        /// </summary>
        internal bool IsSetServiceName() => this.ServiceName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the Express service to help categorize and organize
        /// it. Each tag consists of a key and an optional value. You can apply up to 50 tags
        /// to a service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a task definition to use to create the Express Gateway
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
        /// The Amazon Resource Name (ARN) of the IAM role that containers in this task can assume.
        /// This role allows your application code to access other Amazon Web Services services
        /// securely.
        /// </para>
        ///  
        /// <para>
        /// The task role is different from the execution role. While the execution role is used
        /// by the Amazon ECS agent to set up the task, the task role is used by your application
        /// code running inside the container to make Amazon Web Services API calls. If your application
        /// doesn't need to access Amazon Web Services services, you can omit this parameter.
        /// </para>
        /// </summary>
        public string TaskRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskRoleArn property is set.
        /// </summary>
        internal bool IsSetTaskRoleArn() => this.TaskRoleArn != null;
    }
}
