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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information for the <a>ConnectDirectory</a> operation when an AD Connector
    /// directory is being created.
    /// </summary>
    public partial class DirectoryConnectSettings
    {
        private List<string> _customerDnsIps = new List<string>();
        private string _customerUserName;
        private List<string> _subnetIds = new List<string>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CustomerDnsIps. 
        /// <para>
        /// A list of one or more IP addresses of DNS servers or domain controllers in the on-premises
        /// directory.
        /// </para>
        /// </summary>
        public List<string> CustomerDnsIps
        {
            get { return this._customerDnsIps; }
            set { this._customerDnsIps = value; }
        }

        // Check to see if CustomerDnsIps property is set
        internal bool IsSetCustomerDnsIps()
        {
            return this._customerDnsIps != null && this._customerDnsIps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomerUserName. 
        /// <para>
        /// The username of an account in the on-premises directory that is used to connect to
        /// the directory. This account must have the following privileges:
        /// </para>
        ///  <ul> <li>Read users and groups</li> <li>Create computer objects</li> <li>Join computers
        /// to the domain</li> </ul>
        /// </summary>
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
        /// A list of subnet identifiers in the VPC that the AD Connector is created in.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the AD Connector is created in.
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