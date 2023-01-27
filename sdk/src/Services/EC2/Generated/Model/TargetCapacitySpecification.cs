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
    /// The number of units to request. You can choose to set the target capacity in terms
    /// of instances or a performance characteristic that is important to your application
    /// workload, such as vCPUs, memory, or I/O. If the request type is <code>maintain</code>,
    /// you can specify a target capacity of 0 and add capacity later.
    /// 
    ///  
    /// <para>
    /// You can use the On-Demand Instance <code>MaxTotalPrice</code> parameter, the Spot
    /// Instance <code>MaxTotalPrice</code>, or both to ensure that your fleet cost does not
    /// exceed your budget. If you set a maximum price per hour for the On-Demand Instances
    /// and Spot Instances in your request, EC2 Fleet will launch instances until it reaches
    /// the maximum amount that you're willing to pay. When the maximum amount you're willing
    /// to pay is reached, the fleet stops launching instances even if it hasn’t met the target
    /// capacity. The <code>MaxTotalPrice</code> parameters are located in <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_OnDemandOptions.html">OnDemandOptions</a>
    /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_SpotOptions">SpotOptions</a>.
    /// </para>
    /// </summary>
    public partial class TargetCapacitySpecification
    {
        private DefaultTargetCapacityType _defaultTargetCapacityType;
        private int? _onDemandTargetCapacity;
        private int? _spotTargetCapacity;
        private TargetCapacityUnitType _targetCapacityUnitType;
        private int? _totalTargetCapacity;

        /// <summary>
        /// Gets and sets the property DefaultTargetCapacityType. 
        /// <para>
        /// The default <code>TotalTargetCapacity</code>, which is either <code>Spot</code> or
        /// <code>On-Demand</code>.
        /// </para>
        /// </summary>
        public DefaultTargetCapacityType DefaultTargetCapacityType
        {
            get { return this._defaultTargetCapacityType; }
            set { this._defaultTargetCapacityType = value; }
        }

        // Check to see if DefaultTargetCapacityType property is set
        internal bool IsSetDefaultTargetCapacityType()
        {
            return this._defaultTargetCapacityType != null;
        }

        /// <summary>
        /// Gets and sets the property OnDemandTargetCapacity. 
        /// <para>
        /// The number of On-Demand units to request. If you specify a target capacity for Spot
        /// units, you cannot specify a target capacity for On-Demand units.
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
        /// Gets and sets the property SpotTargetCapacity. 
        /// <para>
        /// The maximum number of Spot units to launch. If you specify a target capacity for On-Demand
        /// units, you cannot specify a target capacity for Spot units.
        /// </para>
        /// </summary>
        public int SpotTargetCapacity
        {
            get { return this._spotTargetCapacity.GetValueOrDefault(); }
            set { this._spotTargetCapacity = value; }
        }

        // Check to see if SpotTargetCapacity property is set
        internal bool IsSetSpotTargetCapacity()
        {
            return this._spotTargetCapacity.HasValue; 
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
        /// Gets and sets the property TotalTargetCapacity. 
        /// <para>
        /// The number of units to request, filled using <code>DefaultTargetCapacityType</code>.
        /// </para>
        /// </summary>
        public int TotalTargetCapacity
        {
            get { return this._totalTargetCapacity.GetValueOrDefault(); }
            set { this._totalTargetCapacity = value; }
        }

        // Check to see if TotalTargetCapacity property is set
        internal bool IsSetTotalTargetCapacity()
        {
            return this._totalTargetCapacity.HasValue; 
        }

    }
}