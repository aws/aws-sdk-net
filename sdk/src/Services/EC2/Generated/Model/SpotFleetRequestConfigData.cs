/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the configuration of a Spot Fleet request.
    /// </summary>
    public partial class SpotFleetRequestConfigData
    {
        private AllocationStrategy _allocationStrategy;
        private string _clientToken;
        private ExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private double? _fulfilledCapacity;
        private string _iamFleetRole;
        private InstanceInterruptionBehavior _instanceInterruptionBehavior;
        private List<SpotFleetLaunchSpecification> _launchSpecifications = new List<SpotFleetLaunchSpecification>();
        private List<LaunchTemplateConfig> _launchTemplateConfigs = new List<LaunchTemplateConfig>();
        private LoadBalancersConfig _loadBalancersConfig;
        private double? _onDemandFulfilledCapacity;
        private int? _onDemandTargetCapacity;
        private bool? _replaceUnhealthyInstances;
        private string _spotPrice;
        private int? _targetCapacity;
        private bool? _terminateInstancesWithExpiration;
        private FleetType _type;
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// Indicates how to allocate the target capacity across the Spot pools specified by the
        /// Spot Fleet request. The default is <code>lowestPrice</code>.
        /// </para>
        /// </summary>
        public AllocationStrategy AllocationStrategy
        {
            get { return this._allocationStrategy; }
            set { this._allocationStrategy = value; }
        }

        // Check to see if AllocationStrategy property is set
        internal bool IsSetAllocationStrategy()
        {
            return this._allocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// your listings. This helps to avoid duplicate listings. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running Spot Instances should be terminated if the target capacity
        /// of the Spot Fleet request is decreased below the current size of the Spot Fleet.
        /// </para>
        /// </summary>
        public ExcessCapacityTerminationPolicy ExcessCapacityTerminationPolicy
        {
            get { return this._excessCapacityTerminationPolicy; }
            set { this._excessCapacityTerminationPolicy = value; }
        }

        // Check to see if ExcessCapacityTerminationPolicy property is set
        internal bool IsSetExcessCapacityTerminationPolicy()
        {
            return this._excessCapacityTerminationPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property FulfilledCapacity. 
        /// <para>
        /// The number of units fulfilled by this request compared to the set target capacity.
        /// </para>
        /// </summary>
        public double FulfilledCapacity
        {
            get { return this._fulfilledCapacity.GetValueOrDefault(); }
            set { this._fulfilledCapacity = value; }
        }

        // Check to see if FulfilledCapacity property is set
        internal bool IsSetFulfilledCapacity()
        {
            return this._fulfilledCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamFleetRole. 
        /// <para>
        /// Grants the Spot Fleet permission to terminate Spot Instances on your behalf when you
        /// cancel its Spot Fleet request using <a>CancelSpotFleetRequests</a> or when the Spot
        /// Fleet request expires, if you set <code>terminateInstancesWithExpiration</code>.
        /// </para>
        /// </summary>
        public string IamFleetRole
        {
            get { return this._iamFleetRole; }
            set { this._iamFleetRole = value; }
        }

        // Check to see if IamFleetRole property is set
        internal bool IsSetIamFleetRole()
        {
            return this._iamFleetRole != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInterruptionBehavior. 
        /// <para>
        /// The behavior when a Spot Instance is interrupted. The default is <code>terminate</code>.
        /// </para>
        /// </summary>
        public InstanceInterruptionBehavior InstanceInterruptionBehavior
        {
            get { return this._instanceInterruptionBehavior; }
            set { this._instanceInterruptionBehavior = value; }
        }

        // Check to see if InstanceInterruptionBehavior property is set
        internal bool IsSetInstanceInterruptionBehavior()
        {
            return this._instanceInterruptionBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecifications. 
        /// <para>
        /// The launch specifications for the Spot Fleet request.
        /// </para>
        /// </summary>
        public List<SpotFleetLaunchSpecification> LaunchSpecifications
        {
            get { return this._launchSpecifications; }
            set { this._launchSpecifications = value; }
        }

        // Check to see if LaunchSpecifications property is set
        internal bool IsSetLaunchSpecifications()
        {
            return this._launchSpecifications != null && this._launchSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The launch template and overrides.
        /// </para>
        /// </summary>
        public List<LaunchTemplateConfig> LaunchTemplateConfigs
        {
            get { return this._launchTemplateConfigs; }
            set { this._launchTemplateConfigs = value; }
        }

        // Check to see if LaunchTemplateConfigs property is set
        internal bool IsSetLaunchTemplateConfigs()
        {
            return this._launchTemplateConfigs != null && this._launchTemplateConfigs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancersConfig. 
        /// <para>
        /// One or more Classic Load Balancers and target groups to attach to the Spot Fleet request.
        /// Spot Fleet registers the running Spot Instances with the specified Classic Load Balancers
        /// and target groups.
        /// </para>
        ///  
        /// <para>
        /// With Network Load Balancers, Spot Fleet cannot register instances that have the following
        /// instance types: C1, CC1, CC2, CG1, CG2, CR1, CS1, G1, G2, HI1, HS1, M1, M2, M3, and
        /// T1.
        /// </para>
        /// </summary>
        public LoadBalancersConfig LoadBalancersConfig
        {
            get { return this._loadBalancersConfig; }
            set { this._loadBalancersConfig = value; }
        }

        // Check to see if LoadBalancersConfig property is set
        internal bool IsSetLoadBalancersConfig()
        {
            return this._loadBalancersConfig != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandFulfilledCapacity. 
        /// <para>
        /// The number of On-Demand units fulfilled by this request compared to the set target
        /// On-Demand capacity.
        /// </para>
        /// </summary>
        public double OnDemandFulfilledCapacity
        {
            get { return this._onDemandFulfilledCapacity.GetValueOrDefault(); }
            set { this._onDemandFulfilledCapacity = value; }
        }

        // Check to see if OnDemandFulfilledCapacity property is set
        internal bool IsSetOnDemandFulfilledCapacity()
        {
            return this._onDemandFulfilledCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnDemandTargetCapacity. 
        /// <para>
        /// The number of On-Demand units to request. You can choose to set the target capacity
        /// in terms of instances or a performance characteristic that is important to your application
        /// workload, such as vCPUs, memory, or I/O. If the request type is <code>maintain</code>,
        /// you can specify a target capacity of 0 and add capacity later.
        /// </para>
        /// </summary>
        public int OnDemandTargetCapacity
        {
            get { return this._onDemandTargetCapacity.GetValueOrDefault(); }
            set { this._onDemandTargetCapacity = value; }
        }

        // Check to see if OnDemandTargetCapacity property is set
        internal bool IsSetOnDemandTargetCapacity()
        {
            return this._onDemandTargetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplaceUnhealthyInstances. 
        /// <para>
        /// Indicates whether Spot Fleet should replace unhealthy instances.
        /// </para>
        /// </summary>
        public bool ReplaceUnhealthyInstances
        {
            get { return this._replaceUnhealthyInstances.GetValueOrDefault(); }
            set { this._replaceUnhealthyInstances = value; }
        }

        // Check to see if ReplaceUnhealthyInstances property is set
        internal bool IsSetReplaceUnhealthyInstances()
        {
            return this._replaceUnhealthyInstances.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. The
        /// default is the On-Demand price.
        /// </para>
        /// </summary>
        public string SpotPrice
        {
            get { return this._spotPrice; }
            set { this._spotPrice = value; }
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this._spotPrice != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The number of units to request. You can choose to set the target capacity in terms
        /// of instances or a performance characteristic that is important to your application
        /// workload, such as vCPUs, memory, or I/O. If the request type is <code>maintain</code>,
        /// you can specify a target capacity of 0 and add capacity later.
        /// </para>
        /// </summary>
        public int TargetCapacity
        {
            get { return this._targetCapacity.GetValueOrDefault(); }
            set { this._targetCapacity = value; }
        }

        // Check to see if TargetCapacity property is set
        internal bool IsSetTargetCapacity()
        {
            return this._targetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminateInstancesWithExpiration. 
        /// <para>
        /// Indicates whether running Spot Instances should be terminated when the Spot Fleet
        /// request expires.
        /// </para>
        /// </summary>
        public bool TerminateInstancesWithExpiration
        {
            get { return this._terminateInstancesWithExpiration.GetValueOrDefault(); }
            set { this._terminateInstancesWithExpiration = value; }
        }

        // Check to see if TerminateInstancesWithExpiration property is set
        internal bool IsSetTerminateInstancesWithExpiration()
        {
            return this._terminateInstancesWithExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of request. Indicates whether the Spot Fleet only requests the target capacity
        /// or also attempts to maintain it. When this value is <code>request</code>, the Spot
        /// Fleet only places the required requests. It does not attempt to replenish Spot Instances
        /// if capacity is diminished, nor does it submit requests in alternative Spot pools if
        /// capacity is not available. To maintain a certain target capacity, the Spot Fleet places
        /// the required requests to meet capacity and automatically replenishes any interrupted
        /// instances. Default: <code>maintain</code>.
        /// </para>
        /// </summary>
        public FleetType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The start date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// The default is to start fulfilling the request immediately.
        /// </para>
        /// </summary>
        public DateTime ValidFrom
        {
            get { return this._validFrom.GetValueOrDefault(); }
            set { this._validFrom = value; }
        }

        // Check to see if ValidFrom property is set
        internal bool IsSetValidFrom()
        {
            return this._validFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The end date and time of the request, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// At this point, no new Spot Instance requests are placed or able to fulfill the request.
        /// The default end date is 7 days from the current date.
        /// </para>
        /// </summary>
        public DateTime ValidUntil
        {
            get { return this._validUntil.GetValueOrDefault(); }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}