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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Route53GlobalResolver.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAccessSource operation. Creates an access
    /// source for a DNS view. Access sources define IP addresses or CIDR ranges that are
    /// allowed to send DNS queries to the Route 53 Global Resolver, along with the permitted
    /// DNS protocols. <important> <para> Route 53 Global Resolver is a global service that
    /// supports resolvers in multiple Amazon Web Services Regions but you must specify the
    /// US East (Ohio) Region to create, update, or otherwise work with Route 53 Global Resolver
    /// resources. That is, for example, specify <c>--region us-east-2</c> on Amazon Web Services
    /// CLI commands. </para> </important>
    /// </summary>
    public partial class CreateAccessSourceRequest : AmazonRoute53GlobalResolverRequest
    {
        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP address or CIDR range that is allowed to send DNS queries to the Route 53 Global
        /// Resolver.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 43)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique string that identifies the request and ensures idempotency.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DnsViewId. 
        /// <para>
        /// The ID of the DNS view to associate with this access source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DnsViewId { get; set; }

        /// <summary>
        /// Checks to see if the DnsViewId property is set.
        /// </summary>
        internal bool IsSetDnsViewId() => this.DnsViewId != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type for this access source. Valid values are IPv4 and IPv6 (if the
        /// Route 53 Global Resolver supports dual-stack).
        /// </para>
        /// </summary>
        public IpAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for the access source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The DNS protocol that is permitted for this access source. Valid values are Do53 (DNS
        /// over port 53), DoT (DNS over TLS), and DoH (DNS over HTTPS).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DnsProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the access source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
