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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        private string _context;
        private ExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private double? _fulfilledCapacity;
        private string _iamFleetRole;
        private InstanceInterruptionBehavior _instanceInterruptionBehavior;
        private int? _instancePoolsToUseCount;
        private List<SpotFleetLaunchSpecification> _launchSpecifications = new List<SpotFleetLaunchSpecification>();
        private List<LaunchTemplateConfig> _launchTemplateConfigs = new List<LaunchTemplateConfig>();
        private LoadBalancersConfig _loadBalancersConfig;
        private OnDemandAllocationStrategy _onDemandAllocationStrategy;
        private double? _onDemandFulfilledCapacity;
        private string _onDemandMaxTotalPrice;
        private int? _onDemandTargetCapacity;
        private bool? _replaceUnhealthyInstances;
        private SpotMaintenanceStrategies _spotMaintenanceStrategies;
        private string _spotMaxTotalPrice;
        private string _spotPrice;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private int? _targetCapacity;
        private TargetCapacityUnitType _targetCapacityUnitType;
        private bool? _terminateInstancesWithExpiration;
        private FleetType _type;
        private DateTime? _validFromUtc;
        private DateTime? _validUntilUtc;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy that determines how to allocate the target Spot Instance capacity across
        /// the Spot Instance pools specified by the Spot Fleet launch configuration. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-allocation-strategy.html">Allocation
        /// strategies for Spot Instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <dl> <dt>priceCapacityOptimized (recommended)</dt> <dd> 
        /// <para>
        /// Spot Fleet identifies the pools with the highest capacity availability for the number
        /// of instances that are launching. This means that we will request Spot Instances from
        /// the pools that we believe have the lowest chance of interruption in the near term.
        /// Spot Fleet then requests Spot Instances from the lowest priced of these pools.
        /// </para>
        ///  </dd> <dt>capacityOptimized</dt> <dd> 
        /// <para>
        /// Spot Fleet identifies the pools with the highest capacity availability for the number
        /// of instances that are launching. This means that we will request Spot Instances from
        /// the pools that we believe have the lowest chance of interruption in the near term.
        /// To give certain instance types a higher chance of launching first, use <code>capacityOptimizedPrioritized</code>.
        /// Set a priority for each instance type by using the <code>Priority</code> parameter
        /// for <code>LaunchTemplateOverrides</code>. You can assign the same priority to different
        /// <code>LaunchTemplateOverrides</code>. EC2 implements the priorities on a best-effort
        /// basis, but optimizes for capacity first. <code>capacityOptimizedPrioritized</code>
        /// is supported only if your Spot Fleet uses a launch template. Note that if the <code>OnDemandAllocationStrategy</code>
        /// is set to <code>prioritized</code>, the same priority is applied when fulfilling On-Demand
        /// capacity.
        /// </para>
        ///  </dd> <dt>diversified</dt> <dd> 
        /// <para>
        /// Spot Fleet requests instances from all of the Spot Instance pools that you specify.
        /// </para>
        ///  </dd> <dt>lowestPrice</dt> <dd> 
        /// <para>
        /// Spot Fleet requests instances from the lowest priced Spot Instance pool that has available
        /// capacity. If the lowest priced pool doesn't have available capacity, the Spot Instances
        /// come from the next lowest priced pool that has available capacity. If a pool runs
        /// out of capacity before fulfilling your desired capacity, Spot Fleet will continue
        /// to fulfill your request by drawing from the next lowest priced pool. To ensure that
        /// your desired capacity is met, you might receive Spot Instances from several pools.
        /// Because this strategy only considers instance price and not capacity availability,
        /// it might lead to high interruption rates.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// Default: <code>lowestPrice</code> 
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
        /// href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
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
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if you decrease the target
        /// capacity of the Spot Fleet request below the current size of the Spot Fleet.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <code>maintain</code>.
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
        /// You cannot set this value.
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
        /// The Amazon Resource Name (ARN) of an Identity and Access Management (IAM) role that
        /// grants the Spot Fleet the permission to request, launch, terminate, and tag instances
        /// on your behalf. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-requests.html#spot-fleet-prerequisites">Spot
        /// Fleet prerequisites</a> in the <i>Amazon EC2 User Guide</i>. Spot Fleet can terminate
        /// Spot Instances on your behalf when you cancel its Spot Fleet request using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CancelSpotFleetRequests">CancelSpotFleetRequests</a>
        /// or when the Spot Fleet request expires, if you set <code>TerminateInstancesWithExpiration</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property InstancePoolsToUseCount. 
        /// <para>
        /// The number of Spot pools across which to allocate your target Spot capacity. Valid
        /// only when Spot <b>AllocationStrategy</b> is set to <code>lowest-price</code>. Spot
        /// Fleet selects the cheapest Spot pools and evenly allocates your target Spot capacity
        /// across the number of Spot pools that you specify.
        /// </para>
        ///  
        /// <para>
        /// Note that Spot Fleet attempts to draw Spot Instances from the number of pools that
        /// you specify on a best effort basis. If a pool runs out of Spot capacity before fulfilling
        /// your target capacity, Spot Fleet will continue to fulfill your request by drawing
        /// from the next cheapest pool. To ensure that your target capacity is met, you might
        /// receive Spot Instances from more than the number of pools that you specified. Similarly,
        /// if most of the pools have no Spot capacity, you might receive your full target capacity
        /// from fewer than the number of pools that you specified.
        /// </para>
        /// </summary>
        public int InstancePoolsToUseCount
        {
            get { return this._instancePoolsToUseCount.GetValueOrDefault(); }
            set { this._instancePoolsToUseCount = value; }
        }

        // Check to see if InstancePoolsToUseCount property is set
        internal bool IsSetInstancePoolsToUseCount()
        {
            return this._instancePoolsToUseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecifications. 
        /// <para>
        /// The launch specifications for the Spot Fleet request. If you specify <code>LaunchSpecifications</code>,
        /// you can't specify <code>LaunchTemplateConfigs</code>. If you include On-Demand capacity
        /// in your request, you must use <code>LaunchTemplateConfigs</code>.
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
        /// The launch template and overrides. If you specify <code>LaunchTemplateConfigs</code>,
        /// you can't specify <code>LaunchSpecifications</code>. If you include On-Demand capacity
        /// in your request, you must use <code>LaunchTemplateConfigs</code>.
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
        /// Gets and sets the property OnDemandAllocationStrategy. 
        /// <para>
        /// The order of the launch template overrides to use in fulfilling On-Demand capacity.
        /// If you specify <code>lowestPrice</code>, Spot Fleet uses price to determine the order,
        /// launching the lowest price first. If you specify <code>prioritized</code>, Spot Fleet
        /// uses the priority that you assign to each Spot Fleet launch template override, launching
        /// the highest priority first. If you do not specify a value, Spot Fleet defaults to
        /// <code>lowestPrice</code>.
        /// </para>
        /// </summary>
        public OnDemandAllocationStrategy OnDemandAllocationStrategy
        {
            get { return this._onDemandAllocationStrategy; }
            set { this._onDemandAllocationStrategy = value; }
        }

        // Check to see if OnDemandAllocationStrategy property is set
        internal bool IsSetOnDemandAllocationStrategy()
        {
            return this._onDemandAllocationStrategy != null;
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
        /// Gets and sets the property OnDemandMaxTotalPrice. 
        /// <para>
        /// The maximum amount per hour for On-Demand Instances that you're willing to pay. You
        /// can use the <code>onDemandMaxTotalPrice</code> parameter, the <code>spotMaxTotalPrice</code>
        /// parameter, or both parameters to ensure that your fleet cost does not exceed your
        /// budget. If you set a maximum price per hour for the On-Demand Instances and Spot Instances
        /// in your request, Spot Fleet will launch instances until it reaches the maximum amount
        /// you're willing to pay. When the maximum amount you're willing to pay is reached, the
        /// fleet stops launching instances even if it hasn’t met the target capacity.
        /// </para>
        /// </summary>
        public string OnDemandMaxTotalPrice
        {
            get { return this._onDemandMaxTotalPrice; }
            set { this._onDemandMaxTotalPrice = value; }
        }

        // Check to see if OnDemandMaxTotalPrice property is set
        internal bool IsSetOnDemandMaxTotalPrice()
        {
            return this._onDemandMaxTotalPrice != null;
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
        /// Gets and sets the property SpotMaintenanceStrategies. 
        /// <para>
        /// The strategies for managing your Spot Instances that are at an elevated risk of being
        /// interrupted.
        /// </para>
        /// </summary>
        public SpotMaintenanceStrategies SpotMaintenanceStrategies
        {
            get { return this._spotMaintenanceStrategies; }
            set { this._spotMaintenanceStrategies = value; }
        }

        // Check to see if SpotMaintenanceStrategies property is set
        internal bool IsSetSpotMaintenanceStrategies()
        {
            return this._spotMaintenanceStrategies != null;
        }

        /// <summary>
        /// Gets and sets the property SpotMaxTotalPrice. 
        /// <para>
        /// The maximum amount per hour for Spot Instances that you're willing to pay. You can
        /// use the <code>spotdMaxTotalPrice</code> parameter, the <code>onDemandMaxTotalPrice</code>
        /// parameter, or both parameters to ensure that your fleet cost does not exceed your
        /// budget. If you set a maximum price per hour for the On-Demand Instances and Spot Instances
        /// in your request, Spot Fleet will launch instances until it reaches the maximum amount
        /// you're willing to pay. When the maximum amount you're willing to pay is reached, the
        /// fleet stops launching instances even if it hasn’t met the target capacity.
        /// </para>
        /// </summary>
        public string SpotMaxTotalPrice
        {
            get { return this._spotMaxTotalPrice; }
            set { this._spotMaxTotalPrice = value; }
        }

        // Check to see if SpotMaxTotalPrice property is set
        internal bool IsSetSpotMaxTotalPrice()
        {
            return this._spotMaxTotalPrice != null;
        }

        /// <summary>
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. We
        /// do not recommend using this parameter because it can lead to increased interruptions.
        /// If you do not specify this parameter, you will pay the current Spot price.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your instances will be interrupted more frequently
        /// than if you do not specify this parameter.
        /// </para>
        ///  </important>
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The key-value pair for tagging the Spot Fleet request on creation. The value for <code>ResourceType</code>
        /// must be <code>spot-fleet-request</code>, otherwise the Spot Fleet request fails. To
        /// tag instances at launch, specify the tags in the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#create-launch-template">launch
        /// template</a> (valid only if you use <code>LaunchTemplateConfigs</code>) or in the
        /// <code> <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SpotFleetTagSpecification.html">SpotFleetTagSpecification</a>
        /// </code> (valid only if you use <code>LaunchSpecifications</code>). For information
        /// about tagging after launch, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html#tag-resources">Tagging
        /// Your Resources</a>.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The number of units to request for the Spot Fleet. You can choose to set the target
        /// capacity in terms of instances or a performance characteristic that is important to
        /// your application workload, such as vCPUs, memory, or I/O. If the request type is <code>maintain</code>,
        /// you can specify a target capacity of 0 and add capacity later.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TargetCapacityUnitType. 
        /// <para>
        /// The unit for the target capacity. <code>TargetCapacityUnitType</code> can only be
        /// specified when <code>InstanceRequirements</code> is specified.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>units</code> (translates to number of instances)
        /// </para>
        /// </summary>
        public TargetCapacityUnitType TargetCapacityUnitType
        {
            get { return this._targetCapacityUnitType; }
            set { this._targetCapacityUnitType = value; }
        }

        // Check to see if TargetCapacityUnitType property is set
        internal bool IsSetTargetCapacityUnitType()
        {
            return this._targetCapacityUnitType != null;
        }

        /// <summary>
        /// Gets and sets the property TerminateInstancesWithExpiration. 
        /// <para>
        /// Indicates whether running Spot Instances are terminated when the Spot Fleet request
        /// expires.
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
        /// capacity is not available. When this value is <code>maintain</code>, the Spot Fleet
        /// maintains the target capacity. The Spot Fleet places the required requests to meet
        /// capacity and automatically replenishes any interrupted instances. Default: <code>maintain</code>.
        /// <code>instant</code> is listed but is not used by Spot Fleet.
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
        /// Gets and sets the property ValidFromUtc. 
        /// <para>
        /// The start date and time of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// By default, Amazon EC2 starts fulfilling the request immediately.
        /// </para>
        /// </summary>
        public DateTime ValidFromUtc
        {
            get { return this._validFromUtc.GetValueOrDefault(); }
            set { this._validFrom = this._validFromUtc = value; }
        }

        // Check to see if ValidFromUtc property is set
        internal bool IsSetValidFromUtc()
        {
            return this._validFromUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// The end date and time of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// After the end date and time, no new Spot Instance requests are placed or able to fulfill
        /// the request. If no value is specified, the Spot Fleet request remains until you cancel
        /// it.
        /// </para>
        /// </summary>
        public DateTime ValidUntilUtc
        {
            get { return this._validUntilUtc.GetValueOrDefault(); }
            set { this._validUntil = this._validUntilUtc = value; }
        }

        // Check to see if ValidUntilUtc property is set
        internal bool IsSetValidUntilUtc()
        {
            return this._validUntilUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _validFrom;
        private DateTime? _validUntil;

        /// <summary>
        /// Gets and sets the property ValidFromUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ValidFromUtc instead. Setting either ValidFrom or
        /// ValidFromUtc results in both ValidFrom and ValidFromUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. ValidFrom
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The start date and time of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// By default, Amazon EC2 starts fulfilling the request immediately.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ValidFromUtc instead. Setting either ValidFrom or ValidFromUtc results in both ValidFrom and " +
            "ValidFromUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ValidFrom is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ValidFrom
        {
            get { return this._validFrom.GetValueOrDefault(); }
            set
            {
                this._validFrom = value;
                this._validFromUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property ValidUntilUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use ValidUntilUtc instead. Setting either ValidUntil or
        /// ValidUntilUtc results in both ValidUntil and ValidUntilUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. ValidUntil
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The end date and time of the request, in UTC format (<i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// After the end date and time, no new Spot Instance requests are placed or able to fulfill
        /// the request. If no value is specified, the Spot Fleet request remains until you cancel
        /// it.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use ValidUntilUtc instead. Setting either ValidUntil or ValidUntilUtc results in both ValidUntil and " +
            "ValidUntilUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. ValidUntil is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime ValidUntil
        {
            get { return this._validUntil.GetValueOrDefault(); }
            set
            {
                this._validUntil = value;
                this._validUntilUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}