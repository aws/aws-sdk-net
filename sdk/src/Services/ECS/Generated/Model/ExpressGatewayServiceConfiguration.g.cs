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
    /// Represents a specific configuration revision of an Express service, containing all
    /// the settings and parameters for that revision.
    /// </summary>
    public partial class ExpressGatewayServiceConfiguration
    {
        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The CPU allocation for tasks in this service revision.
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
        /// The CPU architecture that the task runs on.
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
        /// Different service revisions can report different architectures. This value isn't returned
        /// when the service uses a customer-provided task definition that doesn't specify a CPU
        /// architecture.
        /// </para>
        /// </summary>
        public ExpressCpuArchitecture CpuArchitecture { get; set; }

        /// <summary>
        /// Checks to see if the CpuArchitecture property is set.
        /// </summary>
        internal bool IsSetCpuArchitecture() => this.CpuArchitecture != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp for when this service revision was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the task execution role for the service revision.
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
        /// The health check path for this service revision.
        /// </para>
        /// </summary>
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Checks to see if the HealthCheckPath property is set.
        /// </summary>
        internal bool IsSetHealthCheckPath() => this.HealthCheckPath != null;

        /// <summary>
        /// Gets and sets the property IngressPaths. 
        /// <para>
        /// The entry point into this service revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IngressPathSummary> IngressPaths { get; set; } = AWSConfigs.InitializeCollections ? new List<IngressPathSummary>() : null;

        /// <summary>
        /// Checks to see if the IngressPaths property is set.
        /// </summary>
        internal bool IsSetIngressPaths() => this.IngressPaths != null && (this.IngressPaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The memory allocation for tasks in this service revision.
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
        /// The network configuration for tasks in this service revision.
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
        /// The primary container configuration for this service revision.
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
        /// The auto-scaling configuration for this service revision.
        /// </para>
        /// </summary>
        public ExpressGatewayScalingTarget ScalingTarget { get; set; }

        /// <summary>
        /// Checks to see if the ScalingTarget property is set.
        /// </summary>
        internal bool IsSetScalingTarget() => this.ScalingTarget != null;

        /// <summary>
        /// Gets and sets the property ServiceRevisionArn. 
        /// <para>
        /// The ARN of the service revision.
        /// </para>
        /// </summary>
        public string ServiceRevisionArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRevisionArn property is set.
        /// </summary>
        internal bool IsSetServiceRevisionArn() => this.ServiceRevisionArn != null;

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of the task definition used by this service revision. This is present for
        /// all Express services and reflects the task definition in use, whether managed by Amazon
        /// ECS or provided by the customer.
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
        /// The ARN of the task role for the service revision.
        /// </para>
        /// </summary>
        public string TaskRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskRoleArn property is set.
        /// </summary>
        internal bool IsSetTaskRoleArn() => this.TaskRoleArn != null;
    }
}
