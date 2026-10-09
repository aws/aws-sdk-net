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

namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Execution block configurations for a workflow in a Region switch plan. An execution
    /// block represents a specific type of action to perform during a Region switch.
    /// </summary>
    public partial class ExecutionBlockConfiguration
    {
        /// <summary>
        /// Gets and sets the property ArcRoutingControlConfig. 
        /// <para>
        /// An ARC routing control execution block.
        /// </para>
        /// </summary>
        public ArcRoutingControlConfiguration ArcRoutingControlConfig { get; set; }

        /// <summary>
        /// Checks to see if the ArcRoutingControlConfig property is set.
        /// </summary>
        internal bool IsSetArcRoutingControlConfig() => this.ArcRoutingControlConfig != null;

        /// <summary>
        /// Gets and sets the property AuroraProvisionedScalingConfig. 
        /// <para>
        /// An Aurora provisioned cluster scaling execution block.
        /// </para>
        /// </summary>
        public AuroraProvisionedScalingConfiguration AuroraProvisionedScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuroraProvisionedScalingConfig property is set.
        /// </summary>
        internal bool IsSetAuroraProvisionedScalingConfig() => this.AuroraProvisionedScalingConfig != null;

        /// <summary>
        /// Gets and sets the property AuroraServerlessScalingConfig. 
        /// <para>
        /// An Aurora Serverless scaling execution block.
        /// </para>
        /// </summary>
        public AuroraServerlessScalingConfiguration AuroraServerlessScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the AuroraServerlessScalingConfig property is set.
        /// </summary>
        internal bool IsSetAuroraServerlessScalingConfig() => this.AuroraServerlessScalingConfig != null;

        /// <summary>
        /// Gets and sets the property CustomActionLambdaConfig. 
        /// <para>
        /// An Amazon Web Services Lambda execution block.
        /// </para>
        /// </summary>
        public CustomActionLambdaConfiguration CustomActionLambdaConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomActionLambdaConfig property is set.
        /// </summary>
        internal bool IsSetCustomActionLambdaConfig() => this.CustomActionLambdaConfig != null;

        /// <summary>
        /// Gets and sets the property DocumentDbConfig.
        /// </summary>
        public DocumentDbConfiguration DocumentDbConfig { get; set; }

        /// <summary>
        /// Checks to see if the DocumentDbConfig property is set.
        /// </summary>
        internal bool IsSetDocumentDbConfig() => this.DocumentDbConfig != null;

        /// <summary>
        /// Gets and sets the property Ec2AsgCapacityIncreaseConfig. 
        /// <para>
        /// An EC2 Auto Scaling group execution block.
        /// </para>
        /// </summary>
        public Ec2AsgCapacityIncreaseConfiguration Ec2AsgCapacityIncreaseConfig { get; set; }

        /// <summary>
        /// Checks to see if the Ec2AsgCapacityIncreaseConfig property is set.
        /// </summary>
        internal bool IsSetEc2AsgCapacityIncreaseConfig() => this.Ec2AsgCapacityIncreaseConfig != null;

        /// <summary>
        /// Gets and sets the property EcsCapacityIncreaseConfig. 
        /// <para>
        /// The capacity increase specified for the configuration.
        /// </para>
        /// </summary>
        public EcsCapacityIncreaseConfiguration EcsCapacityIncreaseConfig { get; set; }

        /// <summary>
        /// Checks to see if the EcsCapacityIncreaseConfig property is set.
        /// </summary>
        internal bool IsSetEcsCapacityIncreaseConfig() => this.EcsCapacityIncreaseConfig != null;

        /// <summary>
        /// Gets and sets the property EksResourceScalingConfig. 
        /// <para>
        /// An Amazon Web Services EKS resource scaling execution block.
        /// </para>
        /// </summary>
        public EksResourceScalingConfiguration EksResourceScalingConfig { get; set; }

        /// <summary>
        /// Checks to see if the EksResourceScalingConfig property is set.
        /// </summary>
        internal bool IsSetEksResourceScalingConfig() => this.EksResourceScalingConfig != null;

        /// <summary>
        /// Gets and sets the property ExecutionApprovalConfig. 
        /// <para>
        /// A manual approval execution block.
        /// </para>
        /// </summary>
        public ExecutionApprovalConfiguration ExecutionApprovalConfig { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionApprovalConfig property is set.
        /// </summary>
        internal bool IsSetExecutionApprovalConfig() => this.ExecutionApprovalConfig != null;

        /// <summary>
        /// Gets and sets the property GlobalAuroraConfig. 
        /// <para>
        /// An Aurora Global Database execution block.
        /// </para>
        /// </summary>
        public GlobalAuroraConfiguration GlobalAuroraConfig { get; set; }

        /// <summary>
        /// Checks to see if the GlobalAuroraConfig property is set.
        /// </summary>
        internal bool IsSetGlobalAuroraConfig() => this.GlobalAuroraConfig != null;

        /// <summary>
        /// Gets and sets the property LambdaEventSourceMappingConfig. 
        /// <para>
        /// A Lambda event source mapping execution block.
        /// </para>
        /// </summary>
        public LambdaEventSourceMappingConfiguration LambdaEventSourceMappingConfig { get; set; }

        /// <summary>
        /// Checks to see if the LambdaEventSourceMappingConfig property is set.
        /// </summary>
        internal bool IsSetLambdaEventSourceMappingConfig() => this.LambdaEventSourceMappingConfig != null;

        /// <summary>
        /// Gets and sets the property NeptuneGlobalDatabaseConfig. 
        /// <para>
        /// A Neptune global database execution block.
        /// </para>
        /// </summary>
        public NeptuneGlobalDatabaseConfiguration NeptuneGlobalDatabaseConfig { get; set; }

        /// <summary>
        /// Checks to see if the NeptuneGlobalDatabaseConfig property is set.
        /// </summary>
        internal bool IsSetNeptuneGlobalDatabaseConfig() => this.NeptuneGlobalDatabaseConfig != null;

        /// <summary>
        /// Gets and sets the property ParallelConfig. 
        /// <para>
        /// A parallel configuration execution block.
        /// </para>
        /// </summary>
        public ParallelExecutionBlockConfiguration ParallelConfig { get; set; }

        /// <summary>
        /// Checks to see if the ParallelConfig property is set.
        /// </summary>
        internal bool IsSetParallelConfig() => this.ParallelConfig != null;

        /// <summary>
        /// Gets and sets the property RdsCreateCrossRegionReadReplicaConfig. 
        /// <para>
        /// An Amazon RDS create cross-Region replica execution block.
        /// </para>
        /// </summary>
        public RdsCreateCrossRegionReplicaConfiguration RdsCreateCrossRegionReadReplicaConfig { get; set; }

        /// <summary>
        /// Checks to see if the RdsCreateCrossRegionReadReplicaConfig property is set.
        /// </summary>
        internal bool IsSetRdsCreateCrossRegionReadReplicaConfig() => this.RdsCreateCrossRegionReadReplicaConfig != null;

        /// <summary>
        /// Gets and sets the property RdsPromoteReadReplicaConfig. 
        /// <para>
        /// An Amazon RDS promote read replica execution block.
        /// </para>
        /// </summary>
        public RdsPromoteReadReplicaConfiguration RdsPromoteReadReplicaConfig { get; set; }

        /// <summary>
        /// Checks to see if the RdsPromoteReadReplicaConfig property is set.
        /// </summary>
        internal bool IsSetRdsPromoteReadReplicaConfig() => this.RdsPromoteReadReplicaConfig != null;

        /// <summary>
        /// Gets and sets the property RdsSwitchoverReadReplicaConfig. 
        /// <para>
        /// An Amazon RDS switchover read replica execution block.
        /// </para>
        /// </summary>
        public RdsSwitchoverReadReplicaConfiguration RdsSwitchoverReadReplicaConfig { get; set; }

        /// <summary>
        /// Checks to see if the RdsSwitchoverReadReplicaConfig property is set.
        /// </summary>
        internal bool IsSetRdsSwitchoverReadReplicaConfig() => this.RdsSwitchoverReadReplicaConfig != null;

        /// <summary>
        /// Gets and sets the property RegionSwitchPlanConfig. 
        /// <para>
        /// A Region switch plan execution block.
        /// </para>
        /// </summary>
        public RegionSwitchPlanConfiguration RegionSwitchPlanConfig { get; set; }

        /// <summary>
        /// Checks to see if the RegionSwitchPlanConfig property is set.
        /// </summary>
        internal bool IsSetRegionSwitchPlanConfig() => this.RegionSwitchPlanConfig != null;

        /// <summary>
        /// Gets and sets the property Route53HealthCheckConfig. 
        /// <para>
        /// The Amazon Route 53 health check configuration.
        /// </para>
        /// </summary>
        public Route53HealthCheckConfiguration Route53HealthCheckConfig { get; set; }

        /// <summary>
        /// Checks to see if the Route53HealthCheckConfig property is set.
        /// </summary>
        internal bool IsSetRoute53HealthCheckConfig() => this.Route53HealthCheckConfig != null;
    }
}
