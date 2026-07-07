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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains details about a VM instance involved in a finding.
    /// </summary>
    public partial class Vm
    {
        private string _executionRole;
        private List<string> _ipv4Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyName;
        private DateTime? _launchedAt;
        private string _networkId;
        private string _platform;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _type;
        private string _vmImageReference;
        private string _vmName;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The execution role of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property IpV4Addresses. 
        /// <para>
        /// The IPv4 addresses of the VM instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV4Addresses
        {
            get { return this._ipv4Addresses; }
            set { this._ipv4Addresses = value; }
        }

        // Check to see if IpV4Addresses property is set
        internal bool IsSetIpV4Addresses()
        {
            return this._ipv4Addresses != null && (this._ipv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpV6Addresses. 
        /// <para>
        /// The IPv6 addresses of the VM instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if IpV6Addresses property is set
        internal bool IsSetIpV6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The key name associated with the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// The date and time the VM instance was launched.
        /// </para>
        /// </summary>
        public DateTime? LaunchedAt
        {
            get { return this._launchedAt; }
            set { this._launchedAt = value; }
        }

        // Check to see if LaunchedAt property is set
        internal bool IsSetLaunchedAt()
        {
            return this._launchedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The network ID associated with the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs associated with the VM instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The subnet IDs of the VM instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VmImageReference. 
        /// <para>
        /// The image reference of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string VmImageReference
        {
            get { return this._vmImageReference; }
            set { this._vmImageReference = value; }
        }

        // Check to see if VmImageReference property is set
        internal bool IsSetVmImageReference()
        {
            return this._vmImageReference != null;
        }

        /// <summary>
        /// Gets and sets the property VmName. 
        /// <para>
        /// The name of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string VmName
        {
            get { return this._vmName; }
            set { this._vmName = value; }
        }

        // Check to see if VmName property is set
        internal bool IsSetVmName()
        {
            return this._vmName != null;
        }

    }
}