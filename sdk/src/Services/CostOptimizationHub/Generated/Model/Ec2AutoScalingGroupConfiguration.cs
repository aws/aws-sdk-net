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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// The EC2 Auto Scaling group configuration used for recommendations.
    /// </summary>
    public partial class Ec2AutoScalingGroupConfiguration
    {
        private AllocationStrategy _allocationStrategy;
        private InstanceConfiguration _instance;
        private List<MixedInstanceConfiguration> _mixedInstances = AWSConfigs.InitializeCollections ? new List<MixedInstanceConfiguration>() : null;
        private Ec2AutoScalingGroupType _type;

        /// <summary>
        /// Gets and sets the property AllocationStrategy. 
        /// <para>
        /// The strategy used for allocating instances, based on a predefined priority order or
        /// based on the lowest available price.
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
        /// Gets and sets the property Instance. 
        /// <para>
        /// Details about the instance for the EC2 Auto Scaling group with a single instance type.
        /// </para>
        /// </summary>
        public InstanceConfiguration Instance
        {
            get { return this._instance; }
            set { this._instance = value; }
        }

        // Check to see if Instance property is set
        internal bool IsSetInstance()
        {
            return this._instance != null;
        }

        /// <summary>
        /// Gets and sets the property MixedInstances. 
        /// <para>
        /// A list of instance types for an EC2 Auto Scaling group with mixed instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MixedInstanceConfiguration> MixedInstances
        {
            get { return this._mixedInstances; }
            set { this._mixedInstances = value; }
        }

        // Check to see if MixedInstances property is set
        internal bool IsSetMixedInstances()
        {
            return this._mixedInstances != null && (this._mixedInstances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of EC2 Auto Scaling group, showing whether it consists of a single instance
        /// type or mixed instance types.
        /// </para>
        /// </summary>
        public Ec2AutoScalingGroupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}