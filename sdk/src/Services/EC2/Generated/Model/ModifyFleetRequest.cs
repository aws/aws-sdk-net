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
    /// Container for the parameters to the ModifyFleet operation.
    /// Modifies the specified EC2 Fleet.
    /// 
    ///  
    /// <para>
    /// You can only modify an EC2 Fleet request of type <c>maintain</c>.
    /// </para>
    ///  
    /// <para>
    /// While the EC2 Fleet is being modified, it is in the <c>modifying</c> state.
    /// </para>
    ///  
    /// <para>
    /// To scale up your EC2 Fleet, increase its target capacity. The EC2 Fleet launches the
    /// additional Spot Instances according to the allocation strategy for the EC2 Fleet request.
    /// If the allocation strategy is <c>lowest-price</c>, the EC2 Fleet launches instances
    /// using the Spot Instance pool with the lowest price. If the allocation strategy is
    /// <c>diversified</c>, the EC2 Fleet distributes the instances across the Spot Instance
    /// pools. If the allocation strategy is <c>capacity-optimized</c>, EC2 Fleet launches
    /// instances from Spot Instance pools with optimal capacity for the number of instances
    /// that are launching.
    /// </para>
    ///  
    /// <para>
    /// To scale down your EC2 Fleet, decrease its target capacity. First, the EC2 Fleet cancels
    /// any open requests that exceed the new target capacity. You can request that the EC2
    /// Fleet terminate Spot Instances until the size of the fleet no longer exceeds the new
    /// target capacity. If the allocation strategy is <c>lowest-price</c>, the EC2 Fleet
    /// terminates the instances with the highest price per unit. If the allocation strategy
    /// is <c>capacity-optimized</c>, the EC2 Fleet terminates the instances in the Spot Instance
    /// pools that have the least available Spot Instance capacity. If the allocation strategy
    /// is <c>diversified</c>, the EC2 Fleet terminates instances across the Spot Instance
    /// pools. Alternatively, you can request that the EC2 Fleet keep the fleet at its current
    /// size, but not replace any Spot Instances that are interrupted or that you terminate
    /// manually.
    /// </para>
    ///  
    /// <para>
    /// If you are finished with your EC2 Fleet for now, but will use it again later, you
    /// can set the target capacity to 0.
    /// </para>
    /// </summary>
    public partial class ModifyFleetRequest : AmazonEC2Request
    {
        private string _context;
        private bool? _dryRun;
        private FleetExcessCapacityTerminationPolicy _excessCapacityTerminationPolicy;
        private string _fleetId;
        private List<FleetLaunchTemplateConfigRequest> _launchTemplateConfigs = AWSConfigs.InitializeCollections ? new List<FleetLaunchTemplateConfigRequest>() : null;
        private TargetCapacitySpecificationRequest _targetCapacitySpecification;

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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcessCapacityTerminationPolicy. 
        /// <para>
        /// Indicates whether running instances should be terminated if the total target capacity
        /// of the EC2 Fleet is decreased below the current size of the EC2 Fleet.
        /// </para>
        ///  
        /// <para>
        /// Supported only for fleets of type <c>maintain</c>.
        /// </para>
        /// </summary>
        public FleetExcessCapacityTerminationPolicy ExcessCapacityTerminationPolicy
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
        /// Gets and sets the property FleetId. 
        /// <para>
        /// The ID of the EC2 Fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateConfigs. 
        /// <para>
        /// The launch template and overrides.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<FleetLaunchTemplateConfigRequest> LaunchTemplateConfigs
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
        /// Gets and sets the property TargetCapacitySpecification. 
        /// <para>
        /// The size of the EC2 Fleet.
        /// </para>
        /// </summary>
        public TargetCapacitySpecificationRequest TargetCapacitySpecification
        {
            get { return this._targetCapacitySpecification; }
            set { this._targetCapacitySpecification = value; }
        }

        // Check to see if TargetCapacitySpecification property is set
        internal bool IsSetTargetCapacitySpecification()
        {
            return this._targetCapacitySpecification != null;
        }

    }
}