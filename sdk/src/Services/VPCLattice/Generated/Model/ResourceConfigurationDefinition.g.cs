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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Describes a resource configuration.
    /// </summary>
    public partial class ResourceConfigurationDefinition
    {
        /// <summary>
        /// Gets and sets the property ArnResource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        public ArnResource ArnResource { get; set; }

        /// <summary>
        /// Checks to see if the ArnResource property is set.
        /// </summary>
        internal bool IsSetArnResource() => this.ArnResource != null;

        /// <summary>
        /// Gets and sets the property CidrResource. 
        /// <para>
        /// The network segment for a resource configuration of type CIDR, specified as one or
        /// more CIDR ranges (<c>cidrRanges</c>). Resources whose IP addresses fall within these
        /// ranges are reachable through a <c>Tunnel</c> VPC endpoint.
        /// </para>
        /// </summary>
        public CidrResource CidrResource { get; set; }

        /// <summary>
        /// Checks to see if the CidrResource property is set.
        /// </summary>
        internal bool IsSetCidrResource() => this.CidrResource != null;

        /// <summary>
        /// Gets and sets the property DnsResource. 
        /// <para>
        /// The DNS name of the resource.
        /// </para>
        /// </summary>
        public DnsResource DnsResource { get; set; }

        /// <summary>
        /// Checks to see if the DnsResource property is set.
        /// </summary>
        internal bool IsSetDnsResource() => this.DnsResource != null;

        /// <summary>
        /// Gets and sets the property IpResource. 
        /// <para>
        /// The IP resource.
        /// </para>
        /// </summary>
        public IpResource IpResource { get; set; }

        /// <summary>
        /// Checks to see if the IpResource property is set.
        /// </summary>
        internal bool IsSetIpResource() => this.IpResource != null;
    }
}
