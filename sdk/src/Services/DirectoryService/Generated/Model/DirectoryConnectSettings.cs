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
    /// Contains connection settings for creating an AD Connector with the <a>ConnectDirectory</a>
    /// action.
    /// </summary>
    public partial class DirectoryConnectSettings
    {
        private List<string> _customerDnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _customerDnsIpsV6 = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _customerUserName;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CustomerDnsIps. 
        /// <para>
        /// The IP addresses of DNS servers or domain controllers in your self-managed directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomerDnsIps
        {
            get { return this._customerDnsIps; }
            set { this._customerDnsIps = value; }
        }

        // Check to see if CustomerDnsIps property is set
        internal bool IsSetCustomerDnsIps()
        {
            return this._customerDnsIps != null && (this._customerDnsIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomerDnsIpsV6. 
        /// <para>
        /// The IPv6 addresses of DNS servers or domain controllers in your self-managed directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CustomerDnsIpsV6
        {
            get { return this._customerDnsIpsV6; }
            set { this._customerDnsIpsV6 = value; }
        }

        // Check to see if CustomerDnsIpsV6 property is set
        internal bool IsSetCustomerDnsIpsV6()
        {
            return this._customerDnsIpsV6 != null && (this._customerDnsIpsV6.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomerUserName. 
        /// <para>
        /// The user name of an account in your self-managed directory that is used to connect
        /// to the directory. This account must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Read users and groups
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create computer objects
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Join computers to the domain
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet identifiers in the VPC in which the AD Connector is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The identifier of the VPC in which the AD Connector is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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