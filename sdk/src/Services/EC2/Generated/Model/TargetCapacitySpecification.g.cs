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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The number of units to request. You can choose to set the target capacity in terms
    /// of instances or a performance characteristic that is important to your application
    /// workload, such as vCPUs, memory, or I/O. If the request type is <c>maintain</c>, you
    /// can specify a target capacity of 0 and add capacity later.
    /// 
    ///  
    /// <para>
    /// You can use the On-Demand Instance <c>MaxTotalPrice</c> parameter, the Spot Instance
    /// <c>MaxTotalPrice</c>, or both to ensure that your fleet cost does not exceed your
    /// budget. If you set a maximum price per hour for the On-Demand Instances and Spot Instances
    /// in your request, EC2 Fleet will launch instances until it reaches the maximum amount
    /// that you're willing to pay. When the maximum amount you're willing to pay is reached,
    /// the fleet stops launching instances even if it hasn’t met the target capacity. The
    /// <c>MaxTotalPrice</c> parameters are located in <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_OnDemandOptions.html">OnDemandOptions</a>
    /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SpotOptions">SpotOptions</a>.
    /// </para>
    /// </summary>
    public partial class TargetCapacitySpecification
    {
        /// <summary>
        /// Gets and sets the property DefaultTargetCapacityType. 
        /// <para>
        /// The default target capacity type.
        /// </para>
        /// </summary>
        public DefaultTargetCapacityType DefaultTargetCapacityType { get; set; }

        /// <summary>
        /// Checks to see if the DefaultTargetCapacityType property is set.
        /// </summary>
        internal bool IsSetDefaultTargetCapacityType() => this.DefaultTargetCapacityType != null;

        /// <summary>
        /// Gets and sets the property OnDemandTargetCapacity. 
        /// <para>
        /// The number of On-Demand units to request. If you specify a target capacity for Spot
        /// units, you cannot specify a target capacity for On-Demand units.
        /// </para>
        /// </summary>
        public int? OnDemandTargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the OnDemandTargetCapacity property is set.
        /// </summary>
        internal bool IsSetOnDemandTargetCapacity() => this.OnDemandTargetCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property SpotTargetCapacity. 
        /// <para>
        /// The maximum number of Spot units to launch. If you specify a target capacity for On-Demand
        /// units, you cannot specify a target capacity for Spot units.
        /// </para>
        /// </summary>
        public int? SpotTargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the SpotTargetCapacity property is set.
        /// </summary>
        internal bool IsSetSpotTargetCapacity() => this.SpotTargetCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property TargetCapacityUnitType. 
        /// <para>
        /// The unit for the target capacity.
        /// </para>
        /// </summary>
        public TargetCapacityUnitType TargetCapacityUnitType { get; set; }

        /// <summary>
        /// Checks to see if the TargetCapacityUnitType property is set.
        /// </summary>
        internal bool IsSetTargetCapacityUnitType() => this.TargetCapacityUnitType != null;

        /// <summary>
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The number of units to request, filled the default target capacity type.
        /// </para>
        /// </summary>
        public int? TotalTargetCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TotalTargetCapacity property is set.
        /// </summary>
        internal bool IsSetTotalTargetCapacity() => this.TotalTargetCapacity.HasValue;
    }
}
