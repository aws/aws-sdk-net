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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateResolverEndpointIpAddress operation.
    /// Adds IP addresses to an inbound or an outbound Resolver endpoint. If you want to add
    /// more than one IP address, submit one <c>AssociateResolverEndpointIpAddress</c> request
    /// for each IP address.
    /// 
    ///  
    /// <para>
    /// To remove an IP address from an endpoint, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverEndpointIpAddress.html">DisassociateResolverEndpointIpAddress</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class AssociateResolverEndpointIpAddressRequest : AmazonRoute53ResolverRequest
    {
        private IpAddressUpdate _ipAddress;
        private string _resolverEndpointId;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// Either the IPv4 address that you want to add to a Resolver endpoint or a subnet ID.
        /// If you specify a subnet ID, Resolver chooses an IP address for you from the available
        /// IPs in the specified subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the Resolver endpoint that you want to associate IP addresses with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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