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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Use this structure to specify how a mixed instances policy distributes capacity across
    /// On-Demand, Spot, and supported Capacity Reservation types, and to specify the allocation
    /// strategies that are used to fulfill the capacity.
    /// </summary>
    public partial class InstancesDistribution
    {
        private List<DistributionSegment> _distributionSegments = AWSConfigs.InitializeCollections ? new List<DistributionSegment>() : null;
        private string _onDemandAllocationStrategy;
        private int? _onDemandBaseCapacity;
        private int? _onDemandPercentageAboveBaseCapacity;
        private string _spotAllocationStrategy;
        private int? _spotInstancePools;
        private string _spotMaxPrice;

        /// <summary>
        /// Gets and sets the property DistributionSegments. 
        /// <para>
        /// The Distribution Segments configuration. Each segment contains an ordered list of
        /// capacity types to prioritize.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/use-distribution-segments.html">Use
        /// Distribution Segments to target multiple capacity types</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DistributionSegment> DistributionSegments
        {
            get { return this._distributionSegments; }
            set { this._distributionSegments = value; }
        }

        // Check to see if DistributionSegments property is set
        internal bool IsSetDistributionSegments()
        {
            return this._distributionSegments != null && (this._distributionSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnDemandAllocationStrategy. 
        /// <para>
        /// The allocation strategy to apply to your On-Demand Instances when they are launched.
        /// Possible instance types are determined by the launch template overrides that you specify.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <dl> <dt>lowest-price</dt> <dd> 
        /// <para>
        /// Uses price to determine which instance types are the highest priority, launching the
        /// lowest priced instance types within an Availability Zone first. This is the default
        /// value for Auto Scaling groups that specify <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_InstanceRequirements.html">InstanceRequirements</a>.
        /// 
        /// </para>
        ///  </dd> <dt>prioritized</dt> <dd> 
        /// <para>
        /// You set the order of instance types for the launch template overrides from highest
        /// to lowest priority (from first to last in the list). Amazon EC2 Auto Scaling launches
        /// your highest priority instance types first. If all your On-Demand capacity cannot
        /// be fulfilled using your highest priority instance type, then Amazon EC2 Auto Scaling
        /// launches the remaining capacity using the second priority instance type, and so on.
        /// This is the default value for Auto Scaling groups that don't specify <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_InstanceRequirements.html">InstanceRequirements</a>
        /// and cannot be used for groups that do.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string OnDemandAllocationStrategy
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
        /// Gets and sets the property OnDemandBaseCapacity. 
        /// <para>
        /// The minimum amount of the Auto Scaling group's capacity that must be fulfilled by
        /// On-Demand Instances. This base portion is launched first as your group scales.
        /// </para>
        ///  
        /// <para>
        /// This number has the same unit of measurement as the group's desired capacity. If you
        /// change the default unit of measurement (number of instances) by specifying weighted
        /// capacity values in your launch template overrides list, or by changing the default
        /// desired capacity type setting of the group, you must specify this number using the
        /// same unit of measurement.
        /// </para>
        ///  
        /// <para>
        /// Default: 0
        /// </para>
        /// </summary>
        public int? OnDemandBaseCapacity
        {
            get { return this._onDemandBaseCapacity; }
            set { this._onDemandBaseCapacity = value; }
        }

        // Check to see if OnDemandBaseCapacity property is set
        internal bool IsSetOnDemandBaseCapacity()
        {
            return this._onDemandBaseCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnDemandPercentageAboveBaseCapacity. 
        /// <para>
        /// Controls the percentages of On-Demand Instances and Spot Instances for your additional
        /// capacity beyond <c>OnDemandBaseCapacity</c>. Expressed as a number (for example, 20
        /// specifies 20% On-Demand Instances, 80% Spot Instances). If set to 100, only On-Demand
        /// Instances are used.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        /// </summary>
        public int? OnDemandPercentageAboveBaseCapacity
        {
            get { return this._onDemandPercentageAboveBaseCapacity; }
            set { this._onDemandPercentageAboveBaseCapacity = value; }
        }

        // Check to see if OnDemandPercentageAboveBaseCapacity property is set
        internal bool IsSetOnDemandPercentageAboveBaseCapacity()
        {
            return this._onDemandPercentageAboveBaseCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotAllocationStrategy. 
        /// <para>
        /// The allocation strategy to apply to your Spot Instances when they are launched. Possible
        /// instance types are determined by the launch template overrides that you specify.
        /// </para>
        ///  
        /// <para>
        /// The following lists the valid values:
        /// </para>
        ///  <dl> <dt>capacity-optimized</dt> <dd> 
        /// <para>
        /// Requests Spot Instances using pools that are optimally chosen based on the available
        /// Spot capacity. This strategy has the lowest risk of interruption. To give certain
        /// instance types a higher chance of launching first, use <c>capacity-optimized-prioritized</c>.
        /// </para>
        ///  </dd> <dt>capacity-optimized-prioritized</dt> <dd> 
        /// <para>
        /// You set the order of instance types for the launch template overrides from highest
        /// to lowest priority (from first to last in the list). Amazon EC2 Auto Scaling honors
        /// the instance type priorities on a best effort basis but optimizes for capacity first.
        /// Note that if the On-Demand allocation strategy is set to <c>prioritized</c>, the same
        /// priority is applied when fulfilling On-Demand capacity. This is not a valid value
        /// for Auto Scaling groups that specify <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_InstanceRequirements.html">InstanceRequirements</a>.
        /// </para>
        ///  </dd> <dt>lowest-price</dt> <dd> 
        /// <para>
        /// Requests Spot Instances using the lowest priced pools within an Availability Zone,
        /// across the number of Spot pools that you specify for the <c>SpotInstancePools</c>
        /// property. To ensure that your desired capacity is met, you might receive Spot Instances
        /// from several pools. This is the default value, but it might lead to high interruption
        /// rates because this strategy only considers instance price and not available capacity.
        /// </para>
        ///  </dd> <dt>price-capacity-optimized (recommended)</dt> <dd> 
        /// <para>
        /// The price and capacity optimized allocation strategy looks at both price and capacity
        /// to select the Spot Instance pools that are the least likely to be interrupted and
        /// have the lowest possible price.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string SpotAllocationStrategy
        {
            get { return this._spotAllocationStrategy; }
            set { this._spotAllocationStrategy = value; }
        }

        // Check to see if SpotAllocationStrategy property is set
        internal bool IsSetSpotAllocationStrategy()
        {
            return this._spotAllocationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property SpotInstancePools. 
        /// <para>
        /// The number of Spot Instance pools across which to allocate your Spot Instances. The
        /// Spot pools are determined from the different instance types in the overrides. Valid
        /// only when the <c>SpotAllocationStrategy</c> is <c>lowest-price</c>. Value must be
        /// in the range of 1–20.
        /// </para>
        ///  
        /// <para>
        /// Default: 2
        /// </para>
        /// </summary>
        public int? SpotInstancePools
        {
            get { return this._spotInstancePools; }
            set { this._spotInstancePools = value; }
        }

        // Check to see if SpotInstancePools property is set
        internal bool IsSetSpotInstancePools()
        {
            return this._spotInstancePools.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotMaxPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance. If
        /// your maximum price is lower than the Spot price for the instance types that you selected,
        /// your Spot Instances are not launched. We do not recommend specifying a maximum price
        /// because it can lead to increased interruptions. When Spot Instances launch, you pay
        /// the current Spot price. To remove a maximum price that you previously set, include
        /// the property but specify an empty string ("") for the value.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you specify a maximum price, your instances will be interrupted more frequently
        /// than if you do not specify one.
        /// </para>
        ///  </important> 
        /// <para>
        /// Valid Range: Minimum value of 0.001
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string SpotMaxPrice
        {
            get { return this._spotMaxPrice; }
            set { this._spotMaxPrice = value; }
        }

        // Check to see if SpotMaxPrice property is set
        internal bool IsSetSpotMaxPrice()
        {
            return this._spotMaxPrice != null;
        }

    }
}