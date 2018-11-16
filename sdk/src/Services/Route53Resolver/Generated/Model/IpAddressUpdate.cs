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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In an <a>UpdateResolverEndpoint</a> request, information about an IP address to update.
    /// </summary>
    public partial class IpAddressUpdate
    {
        private string _ip;
        private string _ipId;
        private string _subnetId;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The new IP address.
        /// </para>
        /// </summary>
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property IpId. 
        /// <para>
        ///  <i>Only when removing an IP address from a resolver endpoint</i>: The ID of the IP
        /// address that you want to remove. To get this ID, use <a>GetResolverEndpoint</a>.
        /// </para>
        /// </summary>
        public string IpId
        {
            get { return this._ipId; }
            set { this._ipId = value; }
        }

        // Check to see if IpId property is set
        internal bool IsSetIpId()
        {
            return this._ipId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet that includes the IP address that you want to update. To get
        /// this ID, use <a>GetResolverEndpoint</a>.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

    }
}