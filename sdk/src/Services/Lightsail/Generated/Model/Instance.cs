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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes an instance (a virtual private server).
    /// </summary>
    public partial class Instance
    {
        private List<AddOn> _addOns = AWSConfigs.InitializeCollections ? new List<AddOn>() : null;
        private string _arn;
        private string _blueprintId;
        private string _blueprintName;
        private string _bundleId;
        private DateTime? _createdAt;
        private InstanceHardware _hardware;
        private IpAddressType _ipAddressType;
        private List<string> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _isStaticIp;
        private ResourceLocation _location;
        private InstanceMetadataOptions _metadataOptions;
        private string _name;
        private InstanceNetworking _networking;
        private string _privateIpAddress;
        private string _publicIpAddress;
        private ResourceType _resourceType;
        private string _sshKeyName;
        private InstanceState _state;
        private string _supportCode;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _username;

        /// <summary>
        /// Gets and sets the property AddOns. 
        /// <para>
        /// An array of objects representing the add-ons enabled on the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddOn> AddOns
        {
            get { return this._addOns; }
            set { this._addOns = value; }
        }

        // Check to see if AddOns property is set
        internal bool IsSetAddOns()
        {
            return this._addOns != null && (this._addOns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instance (<c>arn:aws:lightsail:us-east-2:123456789101:Instance/244ad76f-8aad-4741-809f-12345EXAMPLE</c>).
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
        /// The blueprint ID (<c>amazon_linux_2023</c>).
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
        /// The friendly name of the blueprint (<c>Amazon Linux 2023</c>).
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
        /// The bundle for the instance (<c>micro_x_x</c>).
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
        /// The timestamp when the instance was created (<c>1479734909.17</c>) in Unix time format.
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
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type of the instance.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// The IPv6 addresses of the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IsStaticIp. 
        /// <para>
        /// A Boolean value indicating whether this instance has a static IP assigned to it.
        /// </para>
        /// </summary>
        public bool? IsStaticIp
        {
            get { return this._isStaticIp; }
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
        /// The region name and Availability Zone where the instance is located.
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
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the Amazon Lightsail instance.
        /// </para>
        /// </summary>
        public InstanceMetadataOptions MetadataOptions
        {
            get { return this._metadataOptions; }
            set { this._metadataOptions = value; }
        }

        // Check to see if MetadataOptions property is set
        internal bool IsSetMetadataOptions()
        {
            return this._metadataOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name the user gave the instance (<c>Amazon_Linux_2023-1</c>).
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
        /// The type of resource (usually <c>Instance</c>).
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
        /// The name of the SSH key being used to connect to the instance (<c>LightsailDefaultKeyPair</c>).
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
        /// The status code and the state (<c>running</c>) for the instance.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name for connecting to the instance (<c>ec2-user</c>).
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