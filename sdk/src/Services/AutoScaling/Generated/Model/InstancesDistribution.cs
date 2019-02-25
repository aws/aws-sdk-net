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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes an instances distribution for an Auto Scaling group with <a>MixedInstancesPolicy</a>.
    /// 
    ///  
    /// <para>
    /// The instances distribution specifies the distribution of On-Demand Instances and Spot
    /// Instances, the maximum price to pay for Spot Instances, and how the Auto Scaling group
    /// allocates instance types.
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
        /// Indicates how to allocate instance types to fulfill On-Demand capacity. 
        /// </para>
        ///  
        /// <para>
        /// The only valid value is <code>prioritized</code>, which is also the default value.
        /// This strategy uses the order of instance types in the <b>Overrides</b> array of <a>LaunchTemplate</a>
        /// to define the launch priority of each instance type. The first instance type in the
        /// array is prioritized higher than the last. If all your On-Demand capacity cannot be
        /// fulfilled using your highest priority instance, then the Auto Scaling groups launches
        /// the remaining capacity using the second priority instance type, and so on. 
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
        /// </para>
        ///  
        /// <para>
        /// The default value is 0. If you leave this parameter set to 0, On-Demand Instances
        /// are launched as a percentage of the Auto Scaling group's desired capacity, per the
        /// <b>OnDemandPercentageAboveBaseCapacity</b> setting.
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
        /// capacity beyond <b>OnDemandBaseCapacity</b>. 
        /// </para>
        ///  
        /// <para>
        /// The range is 0–100. The default value is 100. If you leave this parameter set to 100,
        /// the percentages are 100% for On-Demand Instances and 0% for Spot Instances. 
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
        /// Indicates how to allocate Spot capacity across Spot pools.
        /// </para>
        ///  
        /// <para>
        /// The only valid value is <code>lowest-price</code>, which is also the default value.
        /// The Auto Scaling group selects the cheapest Spot pools and evenly allocates your Spot
        /// capacity across the number of Spot pools that you specify. 
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
        /// The number of Spot pools to use to allocate your Spot capacity. The Spot pools are
        /// determined from the different instance types in the <b>Overrides</b> array of <a>LaunchTemplate</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The range is 1–20 and the default is 2. 
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
        /// you leave the value of this parameter blank (which is the default), the maximum Spot
        /// price is set at the On-Demand price.
        /// </para>
        ///  
        /// <para>
        /// To remove a value that you previously set, include the parameter but leave the value
        /// blank.
        /// </para>
        /// </summary>
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