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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
        private ArcRoutingControlConfiguration _arcRoutingControlConfig;
        private CustomActionLambdaConfiguration _customActionLambdaConfig;
        private Ec2AsgCapacityIncreaseConfiguration _ec2AsgCapacityIncreaseConfig;
        private EcsCapacityIncreaseConfiguration _ecsCapacityIncreaseConfig;
        private EksResourceScalingConfiguration _eksResourceScalingConfig;
        private ExecutionApprovalConfiguration _executionApprovalConfig;
        private GlobalAuroraConfiguration _globalAuroraConfig;
        private ParallelExecutionBlockConfiguration _parallelConfig;
        private RegionSwitchPlanConfiguration _regionSwitchPlanConfig;
        private Route53HealthCheckConfiguration _route53HealthCheckConfig;

        /// <summary>
        /// Gets and sets the property ArcRoutingControlConfig. 
        /// <para>
        /// An ARC routing control execution block.
        /// </para>
        /// </summary>
        public ArcRoutingControlConfiguration ArcRoutingControlConfig
        {
            get { return this._arcRoutingControlConfig; }
            set { this._arcRoutingControlConfig = value; }
        }

        // Check to see if ArcRoutingControlConfig property is set
        internal bool IsSetArcRoutingControlConfig()
        {
            return this._arcRoutingControlConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CustomActionLambdaConfig. 
        /// <para>
        /// An Amazon Web Services Lambda execution block.
        /// </para>
        /// </summary>
        public CustomActionLambdaConfiguration CustomActionLambdaConfig
        {
            get { return this._customActionLambdaConfig; }
            set { this._customActionLambdaConfig = value; }
        }

        // Check to see if CustomActionLambdaConfig property is set
        internal bool IsSetCustomActionLambdaConfig()
        {
            return this._customActionLambdaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2AsgCapacityIncreaseConfig. 
        /// <para>
        /// An EC2 Auto Scaling group execution block.
        /// </para>
        /// </summary>
        public Ec2AsgCapacityIncreaseConfiguration Ec2AsgCapacityIncreaseConfig
        {
            get { return this._ec2AsgCapacityIncreaseConfig; }
            set { this._ec2AsgCapacityIncreaseConfig = value; }
        }

        // Check to see if Ec2AsgCapacityIncreaseConfig property is set
        internal bool IsSetEc2AsgCapacityIncreaseConfig()
        {
            return this._ec2AsgCapacityIncreaseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EcsCapacityIncreaseConfig. 
        /// <para>
        /// The capacity increase specified for the configuration.
        /// </para>
        /// </summary>
        public EcsCapacityIncreaseConfiguration EcsCapacityIncreaseConfig
        {
            get { return this._ecsCapacityIncreaseConfig; }
            set { this._ecsCapacityIncreaseConfig = value; }
        }

        // Check to see if EcsCapacityIncreaseConfig property is set
        internal bool IsSetEcsCapacityIncreaseConfig()
        {
            return this._ecsCapacityIncreaseConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EksResourceScalingConfig. 
        /// <para>
        /// An Amazon Web Services EKS resource scaling execution block.
        /// </para>
        /// </summary>
        public EksResourceScalingConfiguration EksResourceScalingConfig
        {
            get { return this._eksResourceScalingConfig; }
            set { this._eksResourceScalingConfig = value; }
        }

        // Check to see if EksResourceScalingConfig property is set
        internal bool IsSetEksResourceScalingConfig()
        {
            return this._eksResourceScalingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionApprovalConfig. 
        /// <para>
        /// A manual approval execution block.
        /// </para>
        /// </summary>
        public ExecutionApprovalConfiguration ExecutionApprovalConfig
        {
            get { return this._executionApprovalConfig; }
            set { this._executionApprovalConfig = value; }
        }

        // Check to see if ExecutionApprovalConfig property is set
        internal bool IsSetExecutionApprovalConfig()
        {
            return this._executionApprovalConfig != null;
        }

        /// <summary>
        /// Gets and sets the property GlobalAuroraConfig. 
        /// <para>
        /// An Aurora Global Database execution block.
        /// </para>
        /// </summary>
        public GlobalAuroraConfiguration GlobalAuroraConfig
        {
            get { return this._globalAuroraConfig; }
            set { this._globalAuroraConfig = value; }
        }

        // Check to see if GlobalAuroraConfig property is set
        internal bool IsSetGlobalAuroraConfig()
        {
            return this._globalAuroraConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ParallelConfig. 
        /// <para>
        /// A parallel configuration execution block.
        /// </para>
        /// </summary>
        public ParallelExecutionBlockConfiguration ParallelConfig
        {
            get { return this._parallelConfig; }
            set { this._parallelConfig = value; }
        }

        // Check to see if ParallelConfig property is set
        internal bool IsSetParallelConfig()
        {
            return this._parallelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RegionSwitchPlanConfig. 
        /// <para>
        /// A Region switch plan execution block.
        /// </para>
        /// </summary>
        public RegionSwitchPlanConfiguration RegionSwitchPlanConfig
        {
            get { return this._regionSwitchPlanConfig; }
            set { this._regionSwitchPlanConfig = value; }
        }

        // Check to see if RegionSwitchPlanConfig property is set
        internal bool IsSetRegionSwitchPlanConfig()
        {
            return this._regionSwitchPlanConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Route53HealthCheckConfig. 
        /// <para>
        /// The Amazon Route 53 health check configuration.
        /// </para>
        /// </summary>
        public Route53HealthCheckConfiguration Route53HealthCheckConfig
        {
            get { return this._route53HealthCheckConfig; }
            set { this._route53HealthCheckConfig = value; }
        }

        // Check to see if Route53HealthCheckConfig property is set
        internal bool IsSetRoute53HealthCheckConfig()
        {
            return this._route53HealthCheckConfig != null;
        }

    }
}