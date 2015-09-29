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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifySpotFleetRequest operation.
    /// Modifies the specified Spot fleet request.
    /// 
    ///  
    /// <para>
    /// While the Spot fleet request is being modified, it is in the <code>modifying</code>
    /// state.
    /// </para>
    ///  
    /// <para>
    /// To scale up your Spot fleet, increase its target capacity. The Spot fleet launches
    /// the additional Spot instances according to the allocation strategy for the Spot fleet
    /// request. If the allocation strategy is <code>lowestPrice</code>, the Spot fleet launches
    /// instances using the Spot pool with the lowest price. If the allocation strategy is
    /// <code>diversified</code>, the Spot fleet distributes the instances across the Spot
    /// pools.
    /// </para>
    ///  
    /// <para>
    /// To scale down your Spot fleet, decrease its target capacity. First, the Spot fleet
    /// cancels any open bids that exceed the new target capacity. You can request that the
    /// Spot fleet terminate Spot instances until the size of the fleet no longer exceeds
    /// the new target capacity. If the allocation strategy is <code>lowestPrice</code>, the
    /// Spot fleet terminates the instances with the highest price per unit. If the allocation
    /// strategy is <code>diversified</code>, the Spot fleet terminates instances across the
    /// Spot pools. Alternatively, you can request that the Spot fleet keep the fleet at its
    /// current size, but not replace any Spot instances that are interrupted or that you
    /// terminate manually.
    /// </para>
    /// </summary>
    public partial class ModifySpotFleetRequestRequest : AmazonEC2Request
    {
        private ExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private string _spotFleetRequestId;
        private int? _targetCapacity;

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running Spot instances should be terminated if the target capacity
        /// of the Spot fleet request is decreased below the current size of the Spot fleet.
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
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot fleet request.
        /// </para>
        /// </summary>
        public string SpotFleetRequestId
        {
            get { return this._spotFleetRequestId; }
            set { this._spotFleetRequestId = value; }
        }

        // Check to see if SpotFleetRequestId property is set
        internal bool IsSetSpotFleetRequestId()
        {
            return this._spotFleetRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetCapacity. 
        /// <para>
        /// The size of the fleet.
        /// </para>
        /// </summary>
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

    }
}