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
    /// Container for the parameters to the DisassociateResolverEndpointIpAddress operation.
    /// Removes IP addresses from an inbound or an outbound resolver endpoint. If you want
    /// to remove more than one IP address, submit one <code>DisassociateResolverEndpointIpAddress</code>
    /// request for each IP address.
    /// 
    ///  
    /// <para>
    /// To add an IP address to an endpoint, see <a>AssociateResolverEndpointIpAddress</a>.
    /// </para>
    /// </summary>
    public partial class DisassociateResolverEndpointIpAddressRequest : AmazonRoute53ResolverRequest
    {
        private IpAddressUpdate _ipAddress;
        private string _resolverEndpointId;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IPv4 address that you want to remove from a resolver endpoint.
        /// </para>
        /// </summary>
        public IpAddressUpdate IpAddress
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
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the resolver endpoint that you want to disassociate an IP address from.
        /// </para>
        /// </summary>
        public string ResolverEndpointId
        {
            get { return this._resolverEndpointId; }
            set { this._resolverEndpointId = value; }
        }

        // Check to see if ResolverEndpointId property is set
        internal bool IsSetResolverEndpointId()
        {
            return this._resolverEndpointId != null;
        }

    }
}