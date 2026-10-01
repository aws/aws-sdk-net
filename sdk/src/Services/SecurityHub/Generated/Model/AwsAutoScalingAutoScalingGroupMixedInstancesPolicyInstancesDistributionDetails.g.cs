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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the instances distribution.
    /// </summary>
    public partial class AwsAutoScalingAutoScalingGroupMixedInstancesPolicyInstancesDistributionDetails
    {
        /// <summary>
        /// Gets and sets the property OnDemandAllocationStrategy. 
        /// <para>
        /// How to allocate instance types to fulfill On-Demand capacity. The valid value is <c>prioritized</c>.
        /// </para>
        /// </summary>
        public string OnDemandAllocationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandAllocationStrategy property is set.
        /// </summary>
        internal bool IsSetOnDemandAllocationStrategy() => this.OnDemandAllocationStrategy != null;

        /// <summary>
        /// Gets and sets the property OnDemandBaseCapacity. 
        /// <para>
        /// The minimum amount of the Auto Scaling group's capacity that must be fulfilled by
        /// On-Demand Instances.
        /// </para>
        /// </summary>
        public int? OnDemandBaseCapacity { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandBaseCapacity property is set.
        /// </summary>
        internal bool IsSetOnDemandBaseCapacity() => this.OnDemandBaseCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property OnDemandPercentageAboveBaseCapacity. 
        /// <para>
        /// The percentage of On-Demand Instances and Spot Instances for additional capacity beyond
        /// <c>OnDemandBaseCapacity</c>.
        /// </para>
        /// </summary>
        public int? OnDemandPercentageAboveBaseCapacity { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandPercentageAboveBaseCapacity property is set.
        /// </summary>
        internal bool IsSetOnDemandPercentageAboveBaseCapacity() => this.OnDemandPercentageAboveBaseCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property SpotAllocationStrategy. 
        /// <para>
        /// How to allocate instances across Spot Instance pools. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>lowest-price</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capacity-optimized</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>capacity-optimized-prioritized</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string SpotAllocationStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SpotAllocationStrategy property is set.
        /// </summary>
        internal bool IsSetSpotAllocationStrategy() => this.SpotAllocationStrategy != null;

        /// <summary>
        /// Gets and sets the property SpotInstancePools. 
        /// <para>
        /// The number of Spot Instance pools across which to allocate your Spot Instances.
        /// </para>
        /// </summary>
        public int? SpotInstancePools { get; set; }

        /// <summary>
        /// Checks to see if the SpotInstancePools property is set.
        /// </summary>
        internal bool IsSetSpotInstancePools() => this.SpotInstancePools.HasValue;

        /// <summary>
        /// Gets and sets the property SpotMaxPrice. 
        /// <para>
        /// The maximum price per unit hour that you are willing to pay for a Spot Instance.
        /// </para>
        /// </summary>
        public string SpotMaxPrice { get; set; }

        /// <summary>
        /// Checks to see if the SpotMaxPrice property is set.
        /// </summary>
        internal bool IsSetSpotMaxPrice() => this.SpotMaxPrice != null;
    }
}
