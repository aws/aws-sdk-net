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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// In the response to a <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_GetResolverEndpoint.html">GetResolverEndpoint</a>
    /// request, information about the IP addresses that the Resolver endpoint uses for DNS
    /// queries.
    /// </summary>
    public partial class IpAddressResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the IP address was created, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// One IPv4 address that the Resolver endpoint uses for DNS queries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 36)]
        public string Ip { get; set; }

        /// <summary>
        /// Checks to see if the Ip property is set.
        /// </summary>
        internal bool IsSetIp() => this.Ip != null;

        /// <summary>
        /// Gets and sets the property IpId. 
        /// <para>
        /// The ID of one IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string IpId { get; set; }

        /// <summary>
        /// Checks to see if the IpId property is set.
        /// </summary>
        internal bool IsSetIpId() => this.IpId != null;

        /// <summary>
        /// Gets and sets the property Ipv6. 
        /// <para>
        ///  One IPv6 address that the Resolver endpoint uses for DNS queries. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 39)]
        public string Ipv6 { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6 property is set.
        /// </summary>
        internal bool IsSetIpv6() => this.Ipv6 != null;

        /// <summary>
        /// Gets and sets the property ModificationTime. 
        /// <para>
        /// The date and time that the IP address was last modified, in Unix time format and Coordinated
        /// Universal Time (UTC).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 40)]
        public string ModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the ModificationTime property is set.
        /// </summary>
        internal bool IsSetModificationTime() => this.ModificationTime != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code that gives the current status of the request.
        /// </para>
        /// </summary>
        public IpAddressStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message that provides additional information about the status of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of one subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;
    }
}
