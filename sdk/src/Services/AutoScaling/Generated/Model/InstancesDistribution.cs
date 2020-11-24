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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an instances distribution for an Auto Scaling group with a <a>MixedInstancesPolicy</a>.
    /// 
    ///  
    /// <para>
    /// The instances distribution specifies the distribution of On-Demand Instances and Spot
    /// Instances, the maximum price to pay for Spot Instances, and how the Auto Scaling group
    /// allocates instance types to fulfill On-Demand and Spot capacities.
    /// </para>
    ///  
    /// <para>
    /// When you update <code>SpotAllocationStrategy</code>, <code>SpotInstancePools</code>,
    /// or <code>SpotMaxPrice</code>, this update action does not deploy any changes across
    /// the running Amazon EC2 instances in the group. Your existing Spot Instances continue
    /// to run as long as the maximum price for those instances is higher than the current
    /// Spot price. When scale out occurs, Amazon EC2 Auto Scaling launches instances based
    /// on the new settings. When scale in occurs, Amazon EC2 Auto Scaling terminates instances
    /// according to the group's termination policies.
    /// </para>
    /// </summary>
    public partial class InstancesDistribution
    {
        private string _onDemandAllocationStrategy;
        private int? _onDemandBaseCapacity;
        private int? _onDemandPercentageAboveBaseCapacity;
        private string _spotAllocationStrategy;
        private int? _spotInstancePools;
        private string _spotMaxPrice;

        /// <summary>
        /// Gets and sets the property OnDemandAllocationStrategy. 
        /// <para>
        /// Indicates how to allocate instance types to fulfill On-Demand capacity. The only valid
        /// value is <code>prioritized</code>, which is also the default value. This strategy
        /// uses the order of instance types in the overrides to define the launch priority of
        /// each instance type. The first instance type in the array is prioritized higher than
        /// the last. If all your On-Demand capacity cannot be fulfilled using your highest priority
        /// instance, then the Auto Scaling groups launches the remaining capacity using the second
        /// priority instance type, and so on.
        /// </para>
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
        /// On-Demand Instances. This base portion is provisioned first as your group scales.
        /// Defaults to 0 if not specified. If you specify weights for the instance types in the
        /// overrides, set the value of <code>OnDemandBaseCapacity</code> in terms of the number
        /// of capacity units, and not the number of instances.
        /// </para>
        /// </summary>
        public int OnDemandBaseCapacity
        {
            get { return this._onDemandBaseCapacity.GetValueOrDefault(); }
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
        /// capacity beyond <code>OnDemandBaseCapacity</code>. Expressed as a number (for example,
        /// 20 specifies 20% On-Demand Instances, 80% Spot Instances). Defaults to 100 if not
        /// specified. If set to 100, only On-Demand Instances are provisioned.
        /// </para>
        /// </summary>
        public int OnDemandPercentageAboveBaseCapacity
        {
            get { return this._onDemandPercentageAboveBaseCapacity.GetValueOrDefault(); }
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
        /// Indicates how to allocate instances across Spot Instance pools. If the allocation
        /// strategy is <code>capacity-optimized</code> (recommended), the Auto Scaling group
        /// launches instances using Spot pools that are optimally chosen based on the available
        /// Spot capacity. If the allocation strategy is <code>lowest-price</code>, the Auto Scaling
        /// group launches instances using the Spot pools with the lowest price, and evenly allocates
        /// your instances across the number of Spot pools that you specify. Defaults to <code>lowest-price</code>
        /// if not specified.
        /// </para>
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
        /// only when the Spot allocation strategy is <code>lowest-price</code>. Value must be
        /// in the range of 1 to 20. Defaults to 2 if not specified.
        /// </para>
        /// </summary>
        public int SpotInstancePools
        {
            get { return this._spotInstancePools.GetValueOrDefault(); }
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
        /// you leave the value at its default (empty), Amazon EC2 Auto Scaling uses the On-Demand
        /// price as the maximum Spot price. To remove a value that you previously set, include
        /// the property but specify an empty string ("") for the value.
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