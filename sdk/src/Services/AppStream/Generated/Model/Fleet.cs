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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes a fleet.
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
        private string _iamRoleArn;
        private int? _idleDisconnectTimeoutInSeconds;
        private string _imageArn;
        private string _imageName;
        private string _instanceType;
        private int? _maxUserDurationInSeconds;
        private string _name;
        private FleetState _state;
        private StreamView _streamView;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// The description to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The amount of time that a streaming session remains active after users disconnect.
        /// If they try to reconnect to the streaming session after a disconnection or network
        /// interruption within this time interval, they are connected to their previous session.
        /// Otherwise, they are connected to a new session with a new streaming instance.
        /// </para>
        ///  
        /// <para>
        /// Specify a value between 60 and 360000.
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
        /// The fleet name to display.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The name of the directory and organizational unit (OU) to use to join the fleet to
        /// a Microsoft Active Directory domain. 
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The ARN of the IAM role that is applied to the fleet. To assume a role, the fleet
        /// instance calls the AWS Security Token Service (STS) <code>AssumeRole</code> API operation
        /// and passes the ARN of the role to use. The operation creates a new session with temporary
        /// credentials. AppStream 2.0 retrieves the temporary credentials and creates the <b>appstream_machine_role</b>
        /// credential profile on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/appstream2/latest/developerguide/using-iam-roles-to-grant-permissions-to-applications-scripts-streaming-instances.html">Using
        /// an IAM Role to Grant Permissions to Applications and Scripts Running on AppStream
        /// 2.0 Streaming Instances</a> in the <i>Amazon AppStream 2.0 Administration Guide</i>.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IdleDisconnectTimeoutInSeconds. 
        /// <para>
        /// The amount of time that users can be idle (inactive) before they are disconnected
        /// from their streaming session and the <code>DisconnectTimeoutInSeconds</code> time
        /// interval begins. Users are notified before they are disconnected due to inactivity.
        /// If users try to reconnect to the streaming session before the time interval specified
        /// in <code>DisconnectTimeoutInSeconds</code> elapses, they are connected to their previous
        /// session. Users are considered idle when they stop providing keyboard or mouse input
        /// during their streaming session. File uploads and downloads, audio in, audio out, and
        /// pixels changing do not qualify as user activity. If users continue to be idle after
        /// the time interval in <code>IdleDisconnectTimeoutInSeconds</code> elapses, they are
        /// disconnected.
        /// </para>
        ///  
        /// <para>
        /// To prevent users from being disconnected due to inactivity, specify a value of 0.
        /// Otherwise, specify a value between 60 and 3600. The default value is 0.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you enable this feature, we recommend that you specify a value that corresponds
        /// exactly to a whole number of minutes (for example, 60, 120, and 180). If you don't
        /// do this, the value is rounded to the nearest minute. For example, if you specify a
        /// value of 70, users are disconnected after 1 minute of inactivity. If you specify a
        /// value that is at the midpoint between two different minutes, the value is rounded
        /// up. For example, if you specify a value of 90, users are disconnected after 2 minutes
        /// of inactivity. 
        /// </para>
        ///  </note>
        /// </summary>
        public int IdleDisconnectTimeoutInSeconds
        {
            get { return this._idleDisconnectTimeoutInSeconds.GetValueOrDefault(); }
            set { this._idleDisconnectTimeoutInSeconds = value; }
        }

        // Check to see if IdleDisconnectTimeoutInSeconds property is set
        internal bool IsSetIdleDisconnectTimeoutInSeconds()
        {
            return this._idleDisconnectTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN for the public, private, or shared image.
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
        [AWSProperty(Min=1)]
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
        /// stream.memory.z1d.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.3xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.6xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.memory.z1d.12xlarge
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
        /// stream.graphics.g4dn.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.2xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.4xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.12xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// stream.graphics.g4dn.16xlarge
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
        [AWSProperty(Required=true, Min=1)]
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
        /// The maximum amount of time that a streaming session can remain active, in seconds.
        /// If users are still connected to a streaming instance five minutes before this limit
        /// is reached, they are prompted to save any open documents before being disconnected.
        /// After this time elapses, the instance is terminated and replaced by a new instance.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Specify a value between 600 and 360000.
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
        [AWSProperty(Required=true, Min=1)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StreamView. 
        /// <para>
        /// The AppStream 2.0 view that is displayed to your users when they stream from the fleet.
        /// When <code>APP</code> is specified, only the windows of applications opened by users
        /// display. When <code>DESKTOP</code> is specified, the standard desktop that is provided
        /// by the operating system displays.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>APP</code>.
        /// </para>
        /// </summary>
        public StreamView StreamView
        {
            get { return this._streamView; }
            set { this._streamView = value; }
        }

        // Check to see if StreamView property is set
        internal bool IsSetStreamView()
        {
            return this._streamView != null;
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