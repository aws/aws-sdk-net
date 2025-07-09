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
    /// Container for the parameters to the UpdateResolverEndpoint operation.
    /// Updates the name, or endpoint type for an inbound or an outbound Resolver endpoint.
    /// You can only update between IPV4 and DUALSTACK, IPV6 endpoint type can't be updated
    /// to other type.
    /// </summary>
    public partial class UpdateResolverEndpointRequest : AmazonRoute53ResolverRequest
    {
        private string _name;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resolverEndpointId;
        private ResolverEndpointType _resolverEndpointType;
        private List<UpdateIpAddress> _updateIpAddresses = AWSConfigs.InitializeCollections ? new List<UpdateIpAddress>() : null;

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
        /// Gets and sets the property Protocols. 
        /// <para>
        ///  The protocols you want to use for the endpoint. DoH-FIPS is applicable for default
        /// inbound endpoints only. 
        /// </para>
        ///  
        /// <para>
        /// For a default inbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 and DoH-FIPS in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH-FIPS alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a delegation inbound endpoint you can use Do53 only.
        /// </para>
        ///  
        /// <para>
        /// For an outbound endpoint you can apply the protocols as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Do53 and DoH in combination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do53 alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DoH alone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None, which is treated as Do53.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  You can't change the protocol of an inbound endpoint directly from only Do53 to only
        /// DoH, or DoH-FIPS. This is to prevent a sudden disruption to incoming traffic that
        /// relies on Do53. To change the protocol from Do53 to DoH, or DoH-FIPS, you must first
        /// enable both Do53 and DoH, or Do53 and DoH-FIPS, to make sure that all incoming traffic
        /// has transferred to using the DoH protocol, or DoH-FIPS, and then remove the Do53.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  
        /// <para>
        /// Updating to <c>IPV6</c> type isn't currently supported.
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
        ///  Specifies the IPv6 address when you update the Resolver endpoint from IPv4 to dual-stack.
        /// If you don't specify an IPv6 address, one will be automatically chosen from your subnet.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._updateIpAddresses != null && (this._updateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}