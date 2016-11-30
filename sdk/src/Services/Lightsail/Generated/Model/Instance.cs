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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an instance (a virtual private server).
    /// </summary>
    public partial class Instance
    {
        private string _arn;
        private string _blueprintId;
        private string _blueprintName;
        private string _bundleId;
        private DateTime? _createdAt;
        private InstanceHardware _hardware;
        private string _ipv6Address;
        private bool? _isStaticIp;
        private ResourceLocation _location;
        private string _name;
        private InstanceNetworking _networking;
        private string _privateIpAddress;
        private string _publicIpAddress;
        private ResourceType _resourceType;
        private string _sshKeyName;
        private InstanceState _state;
        private string _supportCode;
        private string _username;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance (e.g., <code>arn:aws:lightsail:us-east-1:123456789101:Instance/244ad76f-8aad-4741-809f-12345EXAMPLE</code>).
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
        /// Gets and sets the property BlueprintId. 
        /// <para>
        /// The blueprint ID (e.g., <code>os_amlinux_2016_03</code>).
        /// </para>
        /// </summary>
        public string BlueprintId
        {
            get { return this._blueprintId; }
            set { this._blueprintId = value; }
        }

        // Check to see if BlueprintId property is set
        internal bool IsSetBlueprintId()
        {
            return this._blueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property BlueprintName. 
        /// <para>
        /// The friendly name of the blueprint (e.g., <code>Amazon Linux</code>).
        /// </para>
        /// </summary>
        public string BlueprintName
        {
            get { return this._blueprintName; }
            set { this._blueprintName = value; }
        }

        // Check to see if BlueprintName property is set
        internal bool IsSetBlueprintName()
        {
            return this._blueprintName != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle for the instance (e.g., <code>micro_1_0</code>).
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the instance was created (e.g., <code>1479734909.17</code>).
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Hardware. 
        /// <para>
        /// The size of the vCPU and the amount of RAM for the instance.
        /// </para>
        /// </summary>
        public InstanceHardware Hardware
        {
            get { return this._hardware; }
            set { this._hardware = value; }
        }

        // Check to see if Hardware property is set
        internal bool IsSetHardware()
        {
            return this._hardware != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address of the instance.
        /// </para>
        /// </summary>
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property IsStaticIp. 
        /// <para>
        /// A Boolean value indicating whether this instance has a static IP assigned to it.
        /// </para>
        /// </summary>
        public bool IsStaticIp
        {
            get { return this._isStaticIp.GetValueOrDefault(); }
            set { this._isStaticIp = value; }
        }

        // Check to see if IsStaticIp property is set
        internal bool IsSetIsStaticIp()
        {
            return this._isStaticIp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The region name and availability zone where the instance is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name the user gave the instance (e.g., <code>Amazon_Linux-1GB-Virginia-1</code>).
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
        /// Gets and sets the property Networking. 
        /// <para>
        /// Information about the public ports and monthly data transfer rates for the instance.
        /// </para>
        /// </summary>
        public InstanceNetworking Networking
        {
            get { return this._networking; }
            set { this._networking = value; }
        }

        // Check to see if Networking property is set
        internal bool IsSetNetworking()
        {
            return this._networking != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// The private IP address of the instance.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IP address of the instance.
        /// </para>
        /// </summary>
        public string PublicIpAddress
        {
            get { return this._publicIpAddress; }
            set { this._publicIpAddress = value; }
        }

        // Check to see if PublicIpAddress property is set
        internal bool IsSetPublicIpAddress()
        {
            return this._publicIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource (usually <code>Instance</code>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SshKeyName. 
        /// <para>
        /// The name of the SSH key being used to connect to the instance (e.g., <code>LightsailDefaultKeyPair</code>).
        /// </para>
        /// </summary>
        public string SshKeyName
        {
            get { return this._sshKeyName; }
            set { this._sshKeyName = value; }
        }

        // Check to see if SshKeyName property is set
        internal bool IsSetSshKeyName()
        {
            return this._sshKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status code and the state (e.g., <code>running</code>) for the instance.
        /// </para>
        /// </summary>
        public InstanceState State
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
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about an instance or another resource in Lightsail. This code enables our support
        /// team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name for connecting to the instance (e.g., <code>ec2-user</code>).
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

    }
}