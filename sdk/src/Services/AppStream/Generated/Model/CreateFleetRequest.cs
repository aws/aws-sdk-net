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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFleet operation.
    /// Creates a fleet. A fleet consists of streaming instances that run a specified image.
    /// </summary>
    public partial class CreateFleetRequest : AmazonAppStreamRequest
    {
        private ComputeCapacity _computeCapacity;
        private string _description;
        private int? _disconnectTimeoutInSeconds;
        private string _displayName;
        private DomainJoinInfo _domainJoinInfo;
        private bool? _enableDefaultInternetAccess;
        private FleetType _fleetType;
        private string _imageArn;
        private string _imageName;
        private string _instanceType;
        private int? _maxUserDurationInSeconds;
        private string _name;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ComputeCapacity. 
        /// <para>
        /// The desired capacity for the fleet.
        /// </para>
        /// </summary>
        public ComputeCapacity ComputeCapacity
        {
            get { return this._computeCapacity; }
            set { this._computeCapacity = value; }
        }

        // Check to see if ComputeCapacity property is set
        internal bool IsSetComputeCapacity()
        {
            return this._computeCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for display.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisconnectTimeoutInSeconds. 
        /// <para>
        /// The time after disconnection when a session is considered to have ended, in seconds.
        /// If a user who was disconnected reconnects within this time interval, the user is connected
        /// to their previous session. Specify a value between 60 and 57600.
        /// </para>
        /// </summary>
        public int DisconnectTimeoutInSeconds
        {
            get { return this._disconnectTimeoutInSeconds.GetValueOrDefault(); }
            set { this._disconnectTimeoutInSeconds = value; }
        }

        // Check to see if DisconnectTimeoutInSeconds property is set
        internal bool IsSetDisconnectTimeoutInSeconds()
        {
            return this._disconnectTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The fleet name for display.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property DomainJoinInfo. 
        /// <para>
        /// The information needed to join a Microsoft Active Directory domain.
        /// </para>
        /// </summary>
        public DomainJoinInfo DomainJoinInfo
        {
            get { return this._domainJoinInfo; }
            set { this._domainJoinInfo = value; }
        }

        // Check to see if DomainJoinInfo property is set
        internal bool IsSetDomainJoinInfo()
        {
            return this._domainJoinInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EnableDefaultInternetAccess. 
        /// <para>
        /// Enables or disables default internet access for the fleet.
        /// </para>
        /// </summary>
        public bool EnableDefaultInternetAccess
        {
            get { return this._enableDefaultInternetAccess.GetValueOrDefault(); }
            set { this._enableDefaultInternetAccess = value; }
        }

        // Check to see if EnableDefaultInternetAccess property is set
        internal bool IsSetEnableDefaultInternetAccess()
        {
            return this._enableDefaultInternetAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FleetType. 
        /// <para>
        /// The fleet type.
        /// </para>
        ///  <dl> <dt>ALWAYS_ON</dt> <dd> 
        /// <para>
        /// Provides users with instant-on access to their apps. You are charged for all running
        /// instances in your fleet, even if no users are streaming apps.
        /// </para>
        ///  </dd> <dt>ON_DEMAND</dt> <dd> 
        /// <para>
        /// Provide users with access to applications after they connect, which takes one to two
        /// minutes. You are charged for instance streaming when users are connected and a small
        /// hourly fee for instances that are not streaming apps.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public FleetType FleetType
        {
            get { return this._fleetType; }
            set { this._fleetType = value; }
        }

        // Check to see if FleetType property is set
        internal bool IsSetFleetType()
        {
            return this._fleetType != null;
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the public, private, or shared image to use.
        /// </para>
        /// </summary>
        public string ImageArn
        {
            get { return this._imageArn; }
            set { this._imageArn = value; }
        }

        // Check to see if ImageArn property is set
        internal bool IsSetImageArn()
        {
            return this._imageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The name of the image used to create the fleet.
        /// </para>
        /// </summary>
        public string ImageName
        {
            get { return this._imageName; }
            set { this._imageName = value; }
        }

        // Check to see if ImageName property is set
        internal bool IsSetImageName()
        {
            return this._imageName != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use when launching fleet instances. The following instance types
        /// are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// stream.standard.medium
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.standard.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.compute.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-design.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-desktop.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-pro.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-pro.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics-pro.16xlarge
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxUserDurationInSeconds. 
        /// <para>
        /// The maximum time that a streaming session can run, in seconds. Specify a value between
        /// 600 and 57600.
        /// </para>
        /// </summary>
        public int MaxUserDurationInSeconds
        {
            get { return this._maxUserDurationInSeconds.GetValueOrDefault(); }
            set { this._maxUserDurationInSeconds = value; }
        }

        // Check to see if MaxUserDurationInSeconds property is set
        internal bool IsSetMaxUserDurationInSeconds()
        {
            return this._maxUserDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique name for the fleet.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration for the fleet.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}