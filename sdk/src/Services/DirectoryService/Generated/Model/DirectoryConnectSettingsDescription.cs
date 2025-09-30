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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about an AD Connector directory.
    /// </summary>
    public partial class DirectoryConnectSettingsDescription
    {
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _connectIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _connectIpsV6 = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _customerUserName;
        private string _securityGroupId;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// The Availability Zones that the directory is in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectIps. 
        /// <para>
        /// The IP addresses of the AD Connector servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectIps
        {
            get { return this._connectIps; }
            set { this._connectIps = value; }
        }

        // Check to see if ConnectIps property is set
        internal bool IsSetConnectIps()
        {
            return this._connectIps != null && (this._connectIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConnectIpsV6. 
        /// <para>
        /// The IPv6 addresses of the AD Connector servers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ConnectIpsV6
        {
            get { return this._connectIpsV6; }
            set { this._connectIpsV6 = value; }
        }

        // Check to see if ConnectIpsV6 property is set
        internal bool IsSetConnectIpsV6()
        {
            return this._connectIpsV6 != null && (this._connectIpsV6.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomerUserName. 
        /// <para>
        /// The user name of the service account in your self-managed directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string CustomerUserName
        {
            get { return this._customerUserName; }
            set { this._customerUserName = value; }
        }

        // Check to see if CustomerUserName property is set
        internal bool IsSetCustomerUserName()
        {
            return this._customerUserName != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupId. 
        /// <para>
        /// The security group identifier for the AD Connector directory.
        /// </para>
        /// </summary>
        public string SecurityGroupId
        {
            get { return this._securityGroupId; }
            set { this._securityGroupId = value; }
        }

        // Check to see if SecurityGroupId property is set
        internal bool IsSetSecurityGroupId()
        {
            return this._securityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet identifiers in the VPC that the AD Connector is in.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the AD Connector is in.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}