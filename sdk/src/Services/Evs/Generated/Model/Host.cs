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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// An ESXi host that runs on an Amazon EC2 bare metal instance. Four hosts are created
    /// in an Amazon EVS environment during environment creation. You can add hosts to an
    /// environment using the <c>CreateEnvironmentHost</c> operation. Amazon EVS supports
    /// 4-16 hosts per environment.
    /// </summary>
    public partial class Host
    {
        private DateTime? _createdAt;
        private string _dedicatedHostId;
        private string _ec2InstanceId;
        private string _hostName;
        private HostState _hostState;
        private InstanceType _instanceType;
        private string _ipAddress;
        private string _keyName;
        private DateTime? _modifiedAt;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private string _placementGroupId;
        private string _stateDetails;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The date and time that the host was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedicatedHostId. 
        /// <para>
        /// The unique ID of the Amazon EC2 Dedicated Host.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string DedicatedHostId
        {
            get { return this._dedicatedHostId; }
            set { this._dedicatedHostId = value; }
        }

        // Check to see if DedicatedHostId property is set
        internal bool IsSetDedicatedHostId()
        {
            return this._dedicatedHostId != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2InstanceId. 
        /// <para>
        /// The unique ID of the EC2 instance that represents the host.
        /// </para>
        /// </summary>
        public string Ec2InstanceId
        {
            get { return this._ec2InstanceId; }
            set { this._ec2InstanceId = value; }
        }

        // Check to see if Ec2InstanceId property is set
        internal bool IsSetEc2InstanceId()
        {
            return this._ec2InstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        /// The DNS hostname of the host. DNS hostnames for hosts must be unique across Amazon
        /// EVS environments and within VCF.
        /// </para>
        /// </summary>
        public string HostName
        {
            get { return this._hostName; }
            set { this._hostName = value; }
        }

        // Check to see if HostName property is set
        internal bool IsSetHostName()
        {
            return this._hostName != null;
        }

        /// <summary>
        /// Gets and sets the property HostState. 
        /// <para>
        ///  The state of the host.
        /// </para>
        /// </summary>
        public HostState HostState
        {
            get { return this._hostState; }
            set { this._hostState = value; }
        }

        // Check to see if HostState property is set
        internal bool IsSetHostState()
        {
            return this._hostState != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The EC2 instance type of the host.
        /// </para>
        ///  <note> 
        /// <para>
        /// EC2 instances created through Amazon EVS do not support associating an IAM instance
        /// profile.
        /// </para>
        ///  </note>
        /// </summary>
        public InstanceType InstanceType
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
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the host.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the SSH key that is used to access the host.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        ///  The date and time that the host was modified.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAt
        {
            get { return this._modifiedAt; }
            set { this._modifiedAt = value; }
        }

        // Check to see if ModifiedAt property is set
        internal bool IsSetModifiedAt()
        {
            return this._modifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The elastic network interfaces that are attached to the host.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroupId. 
        /// <para>
        /// The unique ID of the placement group where the host is placed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public string PlacementGroupId
        {
            get { return this._placementGroupId; }
            set { this._placementGroupId = value; }
        }

        // Check to see if PlacementGroupId property is set
        internal bool IsSetPlacementGroupId()
        {
            return this._placementGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        ///  A detailed description of the <c>hostState</c> of a host.
        /// </para>
        /// </summary>
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

    }
}