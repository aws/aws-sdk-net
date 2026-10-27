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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the origin resource of an Amazon Lightsail content delivery network (CDN)
    /// distribution.
    /// 
    ///  
    /// <para>
    /// An origin can be a Lightsail instance, bucket, or load balancer. A distribution pulls
    /// content from an origin, caches it, and serves it to viewers via a worldwide network
    /// of edge servers.
    /// </para>
    /// </summary>
    public partial class Origin
    {
        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that the distribution uses when connecting to the origin.
        /// </para>
        ///  
        /// <para>
        /// The possible values are <c>ipv4</c> for IPv4 only, <c>ipv6</c> for IPv6 only, and
        /// <c>dualstack</c> for IPv4 and IPv6.
        /// </para>
        /// </summary>
        public OriginIpAddressTypeEnum IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property IsPrivateOriginAccessEnabled. 
        /// <para>
        /// Specifies whether private origin access is enabled for the distribution's origin.
        /// With private origin access, the distribution can serve objects that aren't publicly
        /// accessible from a Lightsail bucket.
        /// </para>
        ///  
        /// <para>
        /// This applies when you set the bucket's <c>getObject</c> access rule to <c>private</c>.
        /// It also applies when you set <c>getObject</c> to <c>public</c> but set individual
        /// objects to private.
        /// </para>
        /// </summary>
        public bool? IsPrivateOriginAccessEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IsPrivateOriginAccessEnabled property is set.
        /// </summary>
        internal bool IsSetIsPrivateOriginAccessEnabled() => this.IsPrivateOriginAccessEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the origin resource.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProtocolPolicy. 
        /// <para>
        /// The protocol that your Amazon Lightsail distribution uses when establishing a connection
        /// with your origin to pull content.
        /// </para>
        /// </summary>
        public OriginProtocolPolicyEnum ProtocolPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ProtocolPolicy property is set.
        /// </summary>
        internal bool IsSetProtocolPolicy() => this.ProtocolPolicy != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The AWS Region name of the origin resource.
        /// </para>
        /// </summary>
        public RegionName RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the origin resource (<i>Instance</i>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ResponseTimeout. 
        /// <para>
        /// The amount of time, in seconds, that the distribution waits for a response after forwarding
        /// a request to the origin. The minimum timeout is 1 second, the maximum is 60 seconds,
        /// and the default (if you don't specify otherwise) is 30 seconds.
        /// </para>
        /// </summary>
        public int? ResponseTimeout { get; set; }

        /// <summary>
        /// Checks to see if the ResponseTimeout property is set.
        /// </summary>
        internal bool IsSetResponseTimeout() => this.ResponseTimeout.HasValue;
    }
}
