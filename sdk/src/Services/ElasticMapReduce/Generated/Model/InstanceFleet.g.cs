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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Describes an instance fleet, which is a group of Amazon EC2 instances that host a
    /// particular node type (master, core, or task) in an Amazon EMR cluster. Instance fleets
    /// can consist of a mix of instance types and On-Demand and Spot Instances, which are
    /// provisioned to meet a defined target capacity. 
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceFleet
    {
        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InstanceFleetType. 
        /// <para>
        /// The node type that the instance fleet hosts. Valid values are MASTER, CORE, or TASK.
        /// 
        /// </para>
        /// </summary>
        public InstanceFleetType InstanceFleetType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceFleetType property is set.
        /// </summary>
        internal bool IsSetInstanceFleetType() => this.InstanceFleetType != null;

        /// <summary>
        /// Gets and sets the property InstanceTypeSpecifications. 
        /// <para>
        /// An array of specifications for the instance types that comprise an instance fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceTypeSpecification> InstanceTypeSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<InstanceTypeSpecification>() : null;

        /// <summary>
        /// Checks to see if the InstanceTypeSpecifications property is set.
        /// </summary>
        internal bool IsSetInstanceTypeSpecifications() => this.InstanceTypeSpecifications != null && (this.InstanceTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LaunchSpecifications. 
        /// <para>
        /// Describes the launch specification for an instance fleet. 
        /// </para>
        /// </summary>
        public InstanceFleetProvisioningSpecifications LaunchSpecifications { get; set; }

        /// <summary>
        /// Checks to see if the LaunchSpecifications property is set.
        /// </summary>
        internal bool IsSetLaunchSpecifications() => this.LaunchSpecifications != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProvisionedOnDemandCapacity. 
        /// <para>
        /// The number of On-Demand units that have been provisioned for the instance fleet to
        /// fulfill <c>TargetOnDemandCapacity</c>. This provisioned capacity might be less than
        /// or greater than <c>TargetOnDemandCapacity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ProvisionedOnDemandCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedOnDemandCapacity property is set.
        /// </summary>
        internal bool IsSetProvisionedOnDemandCapacity() => this.ProvisionedOnDemandCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ProvisionedSpotCapacity. 
        /// <para>
        /// The number of Spot units that have been provisioned for this instance fleet to fulfill
        /// <c>TargetSpotCapacity</c>. This provisioned capacity might be less than or greater
        /// than <c>TargetSpotCapacity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? ProvisionedSpotCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedSpotCapacity property is set.
        /// </summary>
        internal bool IsSetProvisionedSpotCapacity() => this.ProvisionedSpotCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ResizeSpecifications. 
        /// <para>
        /// The resize specification for the instance fleet.
        /// </para>
        /// </summary>
        public InstanceFleetResizingSpecifications ResizeSpecifications { get; set; }

        /// <summary>
        /// Checks to see if the ResizeSpecifications property is set.
        /// </summary>
        internal bool IsSetResizeSpecifications() => this.ResizeSpecifications != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance fleet. 
        /// </para>
        /// </summary>
        public InstanceFleetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetOnDemandCapacity. 
        /// <para>
        /// The target capacity of On-Demand units for the instance fleet, which determines how
        /// many On-Demand Instances to provision. When the instance fleet launches, Amazon EMR
        /// tries to provision On-Demand Instances as specified by <a>InstanceTypeConfig</a>.
        /// Each instance configuration has a specified <c>WeightedCapacity</c>. When an On-Demand
        /// Instance is provisioned, the <c>WeightedCapacity</c> units count toward the target
        /// capacity. Amazon EMR provisions instances until the target capacity is totally fulfilled,
        /// even if this results in an overage. For example, if there are 2 units remaining to
        /// fulfill capacity, and Amazon EMR can only provision an instance with a <c>WeightedCapacity</c>
        /// of 5 units, the instance is provisioned, and the target capacity is exceeded by 3
        /// units. You can use <a>InstanceFleet$ProvisionedOnDemandCapacity</a> to determine the
        /// Spot capacity units that have been provisioned for the instance fleet.
        /// </para>
        ///  <note> 
        /// <para>
        /// If not specified or set to 0, only Spot Instances are provisioned for the instance
        /// fleet using <c>TargetSpotCapacity</c>. At least one of <c>TargetSpotCapacity</c> and
        /// <c>TargetOnDemandCapacity</c> should be greater than 0. For a master instance fleet,
        /// only one of <c>TargetSpotCapacity</c> and <c>TargetOnDemandCapacity</c> can be specified,
        /// and its value must be 1.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetOnDemandCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TargetOnDemandCapacity property is set.
        /// </summary>
        internal bool IsSetTargetOnDemandCapacity() => this.TargetOnDemandCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property TargetSpotCapacity. 
        /// <para>
        /// The target capacity of Spot units for the instance fleet, which determines how many
        /// Spot Instances to provision. When the instance fleet launches, Amazon EMR tries to
        /// provision Spot Instances as specified by <a>InstanceTypeConfig</a>. Each instance
        /// configuration has a specified <c>WeightedCapacity</c>. When a Spot instance is provisioned,
        /// the <c>WeightedCapacity</c> units count toward the target capacity. Amazon EMR provisions
        /// instances until the target capacity is totally fulfilled, even if this results in
        /// an overage. For example, if there are 2 units remaining to fulfill capacity, and Amazon
        /// EMR can only provision an instance with a <c>WeightedCapacity</c> of 5 units, the
        /// instance is provisioned, and the target capacity is exceeded by 3 units. You can use
        /// <a>InstanceFleet$ProvisionedSpotCapacity</a> to determine the Spot capacity units
        /// that have been provisioned for the instance fleet.
        /// </para>
        ///  <note> 
        /// <para>
        /// If not specified or set to 0, only On-Demand Instances are provisioned for the instance
        /// fleet. At least one of <c>TargetSpotCapacity</c> and <c>TargetOnDemandCapacity</c>
        /// should be greater than 0. For a master instance fleet, only one of <c>TargetSpotCapacity</c>
        /// and <c>TargetOnDemandCapacity</c> can be specified, and its value must be 1.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TargetSpotCapacity { get; set; }

        /// <summary>
        /// Checks to see if the TargetSpotCapacity property is set.
        /// </summary>
        internal bool IsSetTargetSpotCapacity() => this.TargetSpotCapacity.HasValue;
    }
}
