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
    /// Describes overrides for a launch template.
    /// </summary>
    public partial class FleetLaunchTemplateOverrides
    {
        private string _availabilityZone;
        private string _imageId;
        private InstanceRequirements _instanceRequirements;
        private InstanceType _instanceType;
        private string _maxPrice;
        private PlacementResponse _placement;
        private double? _priority;
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
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI. An AMI is required to launch an instance. The AMI ID must be specified
        /// here or in the launch template.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with those attributes.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>InstanceRequirements</code>, you can't specify <code>InstanceType</code>.
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
        ///  
        /// <para>
        ///  <code>mac1.metal</code> is not supported as a launch template override.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <code>InstanceType</code>, you can't specify <code>InstanceRequirements</code>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property MaxPrice. 
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
        public string MaxPrice
        {
            get { return this._maxPrice; }
            set { this._maxPrice = value; }
        }

        // Check to see if MaxPrice property is set
        internal bool IsSetMaxPrice()
        {
            return this._maxPrice != null;
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The location where the instance launched, if applicable.
        /// </para>
        /// </summary>
        public PlacementResponse Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority for the launch template override. The highest priority is launched first.
        /// </para>
        ///  
        /// <para>
        /// If the On-Demand <code>AllocationStrategy</code> is set to <code>prioritized</code>,
        /// EC2 Fleet uses priority to determine which launch template override to use first in
        /// fulfilling On-Demand capacity.
        /// </para>
        ///  
        /// <para>
        /// If the Spot <code>AllocationStrategy</code> is set to <code>capacity-optimized-prioritized</code>,
        /// EC2 Fleet uses priority on a best-effort basis to determine which launch template
        /// override to use in fulfilling Spot capacity, but optimizes for capacity first.
        /// </para>
        ///  
        /// <para>
        /// Valid values are whole numbers starting at <code>0</code>. The lower the number, the
        /// higher the priority. If no number is set, the override has the lowest priority. You
        /// can set the same priority for different launch template overrides.
        /// </para>
        /// </summary>
        public double Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
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
        /// The number of units provided by the specified instance type.
        /// </para>
        /// </summary>
        public double WeightedCapacity
        {
            get { return this._weightedCapacity.GetValueOrDefault(); }
            set { this._weightedCapacity = value; }
        }

        // Check to see if WeightedCapacity property is set
        internal bool IsSetWeightedCapacity()
        {
            return this._weightedCapacity.HasValue; 
        }

    }
}