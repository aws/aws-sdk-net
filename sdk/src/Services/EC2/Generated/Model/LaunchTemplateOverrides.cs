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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes overrides for a launch template.
    /// </summary>
    public partial class LaunchTemplateOverrides
    {
        private string _availabilityZone;
        private InstanceRequirements _instanceRequirements;
        private InstanceType _instanceType;
        private double? _priority;
        private string _spotPrice;
        private string _subnetId;
        private double? _weightedCapacity;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to launch the instances.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The instance requirements. When you specify instance requirements, Amazon EC2 will
        /// identify instance types with the provided requirements, and then use your On-Demand
        /// and Spot allocation strategies to launch instances from these instance types, in the
        /// same way as when you specify a list of instance types.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>InstanceRequirements</c>, you can't specify <c>InstanceType</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceRequirements InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the launch template override. The highest priority is launched first.
        /// </para>
        ///  
        /// <para>
        /// If <c>OnDemandAllocationStrategy</c> is set to <c>prioritized</c>, Spot Fleet uses
        /// priority to determine which launch template override to use first in fulfilling On-Demand
        /// capacity.
        /// </para>
        ///  
        /// <para>
        /// If the Spot <c>AllocationStrategy</c> is set to <c>capacityOptimizedPrioritized</c>,
        /// Spot Fleet uses priority on a best-effort basis to determine which launch template
        /// override to use in fulfilling Spot capacity, but optimizes for capacity first.
        /// </para>
        ///  
        /// <para>
        /// Valid values are whole numbers starting at <c>0</c>. The lower the number, the higher
        /// the priority. If no number is set, the launch template override has the lowest priority.
        /// You can set the same priority for different launch template overrides.
        /// </para>
        /// </summary>
        public double? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet in which to launch the instances.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property WeightedCapacity. 
        /// <para>
        /// The number of units provided by the specified instance type. These are the same units
        /// that you chose to set the target capacity in terms of instances, or a performance
        /// characteristic such as vCPUs, memory, or I/O.
        /// </para>
        ///  
        /// <para>
        /// If the target capacity divided by this value is not a whole number, Amazon EC2 rounds
        /// the number of instances to the next whole number. If this value is not specified,
        /// the default is 1.
        /// </para>
        ///  <note> 
        /// <para>
        /// When specifying weights, the price used in the <c>lowestPrice</c> and <c>priceCapacityOptimized</c>
        /// allocation strategies is per <i>unit</i> hour (where the instance price is divided
        /// by the specified weight). However, if all the specified weights are above the requested
        /// <c>TargetCapacity</c>, resulting in only 1 instance being launched, the price used
        /// is per <i>instance</i> hour.
        /// </para>
        ///  </note>
        /// </summary>
        public double? WeightedCapacity
        {
            get { return this._weightedCapacity; }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity.HasValue; 
        }

    }
}