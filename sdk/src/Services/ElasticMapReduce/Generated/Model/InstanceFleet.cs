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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Describes an instance fleet, which is a group of EC2 instances that host a particular
    /// node type (master, core, or task) in an Amazon EMR cluster. Instance fleets can consist
    /// of a mix of instance types and On-Demand and Spot Instances, which are provisioned
    /// to meet a defined target capacity. 
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceFleet
    {
        private string _id;
        private InstanceFleetType _instanceFleetType;
        private List<InstanceTypeSpecification> _instanceTypeSpecifications = new List<InstanceTypeSpecification>();
        private InstanceFleetProvisioningSpecifications _launchSpecifications;
        private string _name;
        private int? _provisionedOnDemandCapacity;
        private int? _provisionedSpotCapacity;
        private InstanceFleetResizingSpecifications _resizeSpecifications;
        private InstanceFleetStatus _status;
        private int? _targetOnDemandCapacity;
        private int? _targetSpotCapacity;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the instance fleet.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFleetType. 
        /// <para>
        /// The node type that the instance fleet hosts. Valid values are MASTER, CORE, or TASK.
        /// 
        /// </para>
        /// </summary>
        public InstanceFleetType InstanceFleetType
        {
            get { return this._instanceFleetType; }
            set { this._instanceFleetType = value; }
        }

        // Check to see if InstanceFleetType property is set
        internal bool IsSetInstanceFleetType()
        {
            return this._instanceFleetType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypeSpecifications. 
        /// <para>
        /// An array of specifications for the instance types that comprise an instance fleet.
        /// </para>
        /// </summary>
        public List<InstanceTypeSpecification> InstanceTypeSpecifications
        {
            get { return this._instanceTypeSpecifications; }
            set { this._instanceTypeSpecifications = value; }
        }

        // Check to see if InstanceTypeSpecifications property is set
        internal bool IsSetInstanceTypeSpecifications()
        {
            return this._instanceTypeSpecifications != null && this._instanceTypeSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecifications. 
        /// <para>
        /// Describes the launch specification for an instance fleet. 
        /// </para>
        /// </summary>
        public InstanceFleetProvisioningSpecifications LaunchSpecifications
        {
            get { return this._launchSpecifications; }
            set { this._launchSpecifications = value; }
        }

        // Check to see if LaunchSpecifications property is set
        internal bool IsSetLaunchSpecifications()
        {
            return this._launchSpecifications != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for the instance fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedOnDemandCapacity. 
        /// <para>
        /// The number of On-Demand units that have been provisioned for the instance fleet to
        /// fulfill <code>TargetOnDemandCapacity</code>. This provisioned capacity might be less
        /// than or greater than <code>TargetOnDemandCapacity</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ProvisionedOnDemandCapacity
        {
            get { return this._provisionedOnDemandCapacity.GetValueOrDefault(); }
            set { this._provisionedOnDemandCapacity = value; }
        }

        // Check to see if ProvisionedOnDemandCapacity property is set
        internal bool IsSetProvisionedOnDemandCapacity()
        {
            return this._provisionedOnDemandCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedSpotCapacity. 
        /// <para>
        /// The number of Spot units that have been provisioned for this instance fleet to fulfill
        /// <code>TargetSpotCapacity</code>. This provisioned capacity might be less than or greater
        /// than <code>TargetSpotCapacity</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int ProvisionedSpotCapacity
        {
            get { return this._provisionedSpotCapacity.GetValueOrDefault(); }
            set { this._provisionedSpotCapacity = value; }
        }

        // Check to see if ProvisionedSpotCapacity property is set
        internal bool IsSetProvisionedSpotCapacity()
        {
            return this._provisionedSpotCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResizeSpecifications. 
        /// <para>
        /// The resize specification for the instance fleet.
        /// </para>
        /// </summary>
        public InstanceFleetResizingSpecifications ResizeSpecifications
        {
            get { return this._resizeSpecifications; }
            set { this._resizeSpecifications = value; }
        }

        // Check to see if ResizeSpecifications property is set
        internal bool IsSetResizeSpecifications()
        {
            return this._resizeSpecifications != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the instance fleet. 
        /// </para>
        /// </summary>
        public InstanceFleetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetOnDemandCapacity. 
        /// <para>
        /// The target capacity of On-Demand units for the instance fleet, which determines how
        /// many On-Demand Instances to provision. When the instance fleet launches, Amazon EMR
        /// tries to provision On-Demand Instances as specified by <a>InstanceTypeConfig</a>.
        /// Each instance configuration has a specified <code>WeightedCapacity</code>. When an
        /// On-Demand Instance is provisioned, the <code>WeightedCapacity</code> units count toward
        /// the target capacity. Amazon EMR provisions instances until the target capacity is
        /// totally fulfilled, even if this results in an overage. For example, if there are 2
        /// units remaining to fulfill capacity, and Amazon EMR can only provision an instance
        /// with a <code>WeightedCapacity</code> of 5 units, the instance is provisioned, and
        /// the target capacity is exceeded by 3 units. You can use <a>InstanceFleet$ProvisionedOnDemandCapacity</a>
        /// to determine the Spot capacity units that have been provisioned for the instance fleet.
        /// </para>
        ///  <note> 
        /// <para>
        /// If not specified or set to 0, only Spot Instances are provisioned for the instance
        /// fleet using <code>TargetSpotCapacity</code>. At least one of <code>TargetSpotCapacity</code>
        /// and <code>TargetOnDemandCapacity</code> should be greater than 0. For a master instance
        /// fleet, only one of <code>TargetSpotCapacity</code> and <code>TargetOnDemandCapacity</code>
        /// can be specified, and its value must be 1.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TargetOnDemandCapacity
        {
            get { return this._targetOnDemandCapacity.GetValueOrDefault(); }
            set { this._targetOnDemandCapacity = value; }
        }

        // Check to see if TargetOnDemandCapacity property is set
        internal bool IsSetTargetOnDemandCapacity()
        {
            return this._targetOnDemandCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetSpotCapacity. 
        /// <para>
        /// The target capacity of Spot units for the instance fleet, which determines how many
        /// Spot Instances to provision. When the instance fleet launches, Amazon EMR tries to
        /// provision Spot Instances as specified by <a>InstanceTypeConfig</a>. Each instance
        /// configuration has a specified <code>WeightedCapacity</code>. When a Spot instance
        /// is provisioned, the <code>WeightedCapacity</code> units count toward the target capacity.
        /// Amazon EMR provisions instances until the target capacity is totally fulfilled, even
        /// if this results in an overage. For example, if there are 2 units remaining to fulfill
        /// capacity, and Amazon EMR can only provision an instance with a <code>WeightedCapacity</code>
        /// of 5 units, the instance is provisioned, and the target capacity is exceeded by 3
        /// units. You can use <a>InstanceFleet$ProvisionedSpotCapacity</a> to determine the Spot
        /// capacity units that have been provisioned for the instance fleet.
        /// </para>
        ///  <note> 
        /// <para>
        /// If not specified or set to 0, only On-Demand Instances are provisioned for the instance
        /// fleet. At least one of <code>TargetSpotCapacity</code> and <code>TargetOnDemandCapacity</code>
        /// should be greater than 0. For a master instance fleet, only one of <code>TargetSpotCapacity</code>
        /// and <code>TargetOnDemandCapacity</code> can be specified, and its value must be 1.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0)]
        public int TargetSpotCapacity
        {
            get { return this._targetSpotCapacity.GetValueOrDefault(); }
            set { this._targetSpotCapacity = value; }
        }

        // Check to see if TargetSpotCapacity property is set
        internal bool IsSetTargetSpotCapacity()
        {
            return this._targetSpotCapacity.HasValue; 
        }

    }
}