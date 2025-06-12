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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The configuration that defines an instance fleet.
    /// 
    ///  <note> 
    /// <para>
    /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
    /// later, excluding 5.0.x versions.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class InstanceFleetConfig
    {
        private string _context;
        private InstanceFleetType _instanceFleetType;
        private List<InstanceTypeConfig> _instanceTypeConfigs = AWSConfigs.InitializeCollections ? new List<InstanceTypeConfig>() : null;
        private InstanceFleetProvisioningSpecifications _launchSpecifications;
        private string _name;
        private InstanceFleetResizingSpecifications _resizeSpecifications;
        private int? _targetOnDemandCapacity;
        private int? _targetSpotCapacity;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property InstanceFleetType. 
        /// <para>
        /// The node type that the instance fleet hosts. Valid values are MASTER, CORE, and TASK.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property InstanceTypeConfigs. 
        /// <para>
        /// The instance type configurations that define the Amazon EC2 instances in the instance
        /// fleet.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceTypeConfig> InstanceTypeConfigs
        {
            get { return this._instanceTypeConfigs; }
            set { this._instanceTypeConfigs = value; }
        }

        // Check to see if InstanceTypeConfigs property is set
        internal bool IsSetInstanceTypeConfigs()
        {
            return this._instanceTypeConfigs != null && (this._instanceTypeConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LaunchSpecifications. 
        /// <para>
        /// The launch specification for the instance fleet.
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
        /// The friendly name of the instance fleet.
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
        /// units.
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
        [AWSProperty(Min=0)]
        public int? TargetOnDemandCapacity
        {
            get { return this._targetOnDemandCapacity; }
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
        /// configuration has a specified <c>WeightedCapacity</c>. When a Spot Instance is provisioned,
        /// the <c>WeightedCapacity</c> units count toward the target capacity. Amazon EMR provisions
        /// instances until the target capacity is totally fulfilled, even if this results in
        /// an overage. For example, if there are 2 units remaining to fulfill capacity, and Amazon
        /// EMR can only provision an instance with a <c>WeightedCapacity</c> of 5 units, the
        /// instance is provisioned, and the target capacity is exceeded by 3 units.
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
        [AWSProperty(Min=0)]
        public int? TargetSpotCapacity
        {
            get { return this._targetSpotCapacity; }
            set { this._targetSpotCapacity = value; }
        }

        // Check to see if TargetSpotCapacity property is set
        internal bool IsSetTargetSpotCapacity()
        {
            return this._targetSpotCapacity.HasValue; 
        }

    }
}