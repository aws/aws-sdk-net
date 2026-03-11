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
    /// Contains the directory owner account details shared with the directory consumer account.
    /// </summary>
    public partial class OwnerDirectoryDescription
    {
        private string _accountId;
        private string _directoryId;
        private List<string> _dnsIpAddrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _dnsIpv6Addrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NetworkType _networkType;
        private RadiusSettings _radiusSettings;
        private RadiusStatus _radiusStatus;
        private DirectoryVpcSettingsDescription _vpcSettings;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Identifier of the directory owner account.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the Managed Microsoft AD directory in the directory owner account.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddrs. 
        /// <para>
        /// IP address of the directory’s domain controllers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddrs
        {
            get { return this._dnsIpAddrs; }
            set { this._dnsIpAddrs = value; }
        }

        // Check to see if DnsIpAddrs property is set
        internal bool IsSetDnsIpAddrs()
        {
            return this._dnsIpAddrs != null && (this._dnsIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DnsIpv6Addrs. 
        /// <para>
        /// IPv6 addresses of the directory’s domain controllers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpv6Addrs
        {
            get { return this._dnsIpv6Addrs; }
            set { this._dnsIpv6Addrs = value; }
        }

        // Check to see if DnsIpv6Addrs property is set
        internal bool IsSetDnsIpv6Addrs()
        {
            return this._dnsIpv6Addrs != null && (this._dnsIpv6Addrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Network type of the directory in the directory owner account.
        /// </para>
        /// </summary>
        public NetworkType NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property RadiusSettings. 
        /// <para>
        /// Information about the <a>RadiusSettings</a> object server configuration.
        /// </para>
        /// </summary>
        public RadiusSettings RadiusSettings
        {
            get { return this._radiusSettings; }
            set { this._radiusSettings = value; }
        }

        // Check to see if RadiusSettings property is set
        internal bool IsSetRadiusSettings()
        {
            return this._radiusSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RadiusStatus. 
        /// <para>
        /// The status of the RADIUS server.
        /// </para>
        /// </summary>
        public RadiusStatus RadiusStatus
        {
            get { return this._radiusStatus; }
            set { this._radiusStatus = value; }
        }

        // Check to see if RadiusStatus property is set
        internal bool IsSetRadiusStatus()
        {
            return this._radiusStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSettings. 
        /// <para>
        /// Information about the VPC settings for the directory.
        /// </para>
        /// </summary>
        public DirectoryVpcSettingsDescription VpcSettings
        {
            get { return this._vpcSettings; }
            set { this._vpcSettings = value; }
        }

        // Check to see if VpcSettings property is set
        internal bool IsSetVpcSettings()
        {
            return this._vpcSettings != null;
        }

    }
}