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
    /// Container for the parameters to the ModifySpotFleetRequest operation.
    /// Modifies the specified Spot Fleet request.
    /// 
    ///  
    /// <para>
    /// You can only modify a Spot Fleet request of type <c>maintain</c>.
    /// </para>
    ///  
    /// <para>
    /// While the Spot Fleet request is being modified, it is in the <c>modifying</c> state.
    /// </para>
    ///  
    /// <para>
    /// To scale up your Spot Fleet, increase its target capacity. The Spot Fleet launches
    /// the additional Spot Instances according to the allocation strategy for the Spot Fleet
    /// request. If the allocation strategy is <c>lowestPrice</c>, the Spot Fleet launches
    /// instances using the Spot Instance pool with the lowest price. If the allocation strategy
    /// is <c>diversified</c>, the Spot Fleet distributes the instances across the Spot Instance
    /// pools. If the allocation strategy is <c>capacityOptimized</c>, Spot Fleet launches
    /// instances from Spot Instance pools with optimal capacity for the number of instances
    /// that are launching.
    /// </para>
    ///  
    /// <para>
    /// To scale down your Spot Fleet, decrease its target capacity. First, the Spot Fleet
    /// cancels any open requests that exceed the new target capacity. You can request that
    /// the Spot Fleet terminate Spot Instances until the size of the fleet no longer exceeds
    /// the new target capacity. If the allocation strategy is <c>lowestPrice</c>, the Spot
    /// Fleet terminates the instances with the highest price per unit. If the allocation
    /// strategy is <c>capacityOptimized</c>, the Spot Fleet terminates the instances in the
    /// Spot Instance pools that have the least available Spot Instance capacity. If the allocation
    /// strategy is <c>diversified</c>, the Spot Fleet terminates instances across the Spot
    /// Instance pools. Alternatively, you can request that the Spot Fleet keep the fleet
    /// at its current size, but not replace any Spot Instances that are interrupted or that
    /// you terminate manually.
    /// </para>
    ///  
    /// <para>
    /// If you are finished with your Spot Fleet for now, but will use it again later, you
    /// can set the target capacity to 0.
    /// </para>
    /// </summary>
    public partial class ModifySpotFleetRequestRequest : AmazonEC2Request
    {
        private string _context;
        private ExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private List<LaunchTemplateConfig> _launchTemplateConfigs = AWSConfigs.InitializeCollections ? new List<LaunchTemplateConfig>() : null;
        private int? _onDemandTargetCapacity;
        private string _spotFleetRequestId;
        private int? _targetCapacity;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if the target capacity of
        /// the Spot Fleet request is decreased below the current size of the Spot Fleet.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>maintain</c>.
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
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The launch template and overrides. You can only use this parameter if you specified
        /// a launch template (<c>LaunchTemplateConfigs</c>) in your Spot Fleet request. If you
        /// specified <c>LaunchSpecifications</c> in your Spot Fleet request, then omit this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateConfig> LaunchTemplateConfigs
        {
            get { return this._launchTemplateConfigs; }
            set { this._launchTemplateConfigs = value; }
        }

        // Check to see if LaunchTemplateConfigs property is set
        internal bool IsSetLaunchTemplateConfigs()
        {
            return this._launchTemplateConfigs != null && (this._launchTemplateConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnDemandTargetCapacity. 
        /// <para>
        /// The number of On-Demand Instances in the fleet.
        /// </para>
        /// </summary>
        public int? OnDemandTargetCapacity
        {
            get { return this._onDemandTargetCapacity; }
            set { this._onDemandTargetCapacity = value; }
        }

        // Check to see if OnDemandTargetCapacity property is set
        internal bool IsSetOnDemandTargetCapacity()
        {
            return this._onDemandTargetCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotFleetRequestId. 
        /// <para>
        /// The ID of the Spot Fleet request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        public int? TargetCapacity
        {
            get { return this._targetCapacity; }
            set { this._targetCapacity = value; }
        }

        // Check to see if TargetCapacity property is set
        internal bool IsSetTargetCapacity()
        {
            return this._targetCapacity.HasValue; 
        }

    }
}