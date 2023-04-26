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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateResolverEndpoint operation.
    /// Updates the name, or enpoint type for an inbound or an outbound Resolver endpoint.
    /// You can only update between IPV4 and DUALSTACK, IPV6 endpoint type can't be updated
    /// to other type.
    /// </summary>
    public partial class UpdateResolverEndpointRequest : AmazonRoute53ResolverRequest
    {
        private string _name;
        private string _resolverEndpointId;
        private ResolverEndpointType _resolverEndpointType;
        private List<UpdateIpAddress> _updateIpAddresses = new List<UpdateIpAddress>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Resolver endpoint that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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
        /// Gets and sets the property ResolverEndpointId. 
        /// <para>
        /// The ID of the Resolver endpoint that you want to update.
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

        /// <summary>
        /// Gets and sets the property ResolverEndpointType. 
        /// <para>
        ///  Specifies the endpoint type for what type of IP address the endpoint uses to forward
        /// DNS queries. 
        /// </para>
        /// </summary>
        public ResolverEndpointType ResolverEndpointType
        {
            get { return this._resolverEndpointType; }
            set { this._resolverEndpointType = value; }
        }

        // Check to see if ResolverEndpointType property is set
        internal bool IsSetResolverEndpointType()
        {
            return this._resolverEndpointType != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateIpAddresses. 
        /// <para>
        ///  Updates the Resolver endpoint type to IpV4, Ipv6, or dual-stack. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<UpdateIpAddress> UpdateIpAddresses
        {
            get { return this._updateIpAddresses; }
            set { this._updateIpAddresses = value; }
        }

        // Check to see if UpdateIpAddresses property is set
        internal bool IsSetUpdateIpAddresses()
        {
            return this._updateIpAddresses != null && this._updateIpAddresses.Count > 0; 
        }

    }
}