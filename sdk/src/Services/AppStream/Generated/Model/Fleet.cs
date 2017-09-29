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
    /// Contains the parameters for a fleet.
    /// </summary>
    public partial class Fleet
    {
        private string _arn;
        private ComputeCapacityStatus _computeCapacityStatus;
        private DateTime? _createdTime;
        private string _description;
        private int? _disconnectTimeoutInSeconds;
        private string _displayName;
        private DomainJoinInfo _domainJoinInfo;
        private bool? _enableDefaultInternetAccess;
        private List<FleetError> _fleetErrors = new List<FleetError>();
        private FleetType _fleetType;
        private string _imageName;
        private string _instanceType;
        private int? _maxUserDurationInSeconds;
        private string _name;
        private FleetState _state;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN for the fleet.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeCapacityStatus. 
        /// <para>
        /// The capacity status for the fleet.
        /// </para>
        /// </summary>
        public ComputeCapacityStatus ComputeCapacityStatus
        {
            get { return this._computeCapacityStatus; }
            set { this._computeCapacityStatus = value; }
        }

        // Check to see if ComputeCapacityStatus property is set
        internal bool IsSetComputeCapacityStatus()
        {
            return this._computeCapacityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time the fleet was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description displayed to end users.
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
        /// The fleet name displayed to end users.
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
        /// The information needed for streaming instances to join a domain.
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
        /// Indicates whether default internet access is enabled for the fleet.
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
        /// Gets and sets the property FleetErrors. 
        /// <para>
        /// The fleet errors.
        /// </para>
        /// </summary>
        public List<FleetError> FleetErrors
        {
            get { return this._fleetErrors; }
            set { this._fleetErrors = value; }
        }

        // Check to see if FleetErrors property is set
        internal bool IsSetFleetErrors()
        {
            return this._fleetErrors != null && this._fleetErrors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FleetType.
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
        /// Gets and sets the property ImageName. 
        /// <para>
        /// The image used by the fleet.
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
        /// The instance type to use when launching fleet instances.
        /// </para>
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
        /// The name of the fleet.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The current state for the fleet.
        /// </para>
        /// </summary>
        public FleetState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
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