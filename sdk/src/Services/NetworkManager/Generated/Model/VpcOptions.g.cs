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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the VPC options.
    /// </summary>
    public partial class VpcOptions
    {
        /// <summary>
        /// Gets and sets the property ApplianceModeSupport. 
        /// <para>
        /// Indicates whether appliance mode is supported. If enabled, traffic flow between a
        /// source and destination use the same Availability Zone for the VPC attachment for the
        /// lifetime of that flow. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ApplianceModeSupport { get; set; }

        /// <summary>
        /// Checks to see if the ApplianceModeSupport property is set.
        /// </summary>
        internal bool IsSetApplianceModeSupport() => this.ApplianceModeSupport.HasValue;

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Indicates whether DNS is supported.
        /// </para>
        /// </summary>
        public bool? DnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the DnsSupport property is set.
        /// </summary>
        internal bool IsSetDnsSupport() => this.DnsSupport.HasValue;

        /// <summary>
        /// Gets and sets the property Ipv6Support. 
        /// <para>
        /// Indicates whether IPv6 is supported.
        /// </para>
        /// </summary>
        public bool? Ipv6Support { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Support property is set.
        /// </summary>
        internal bool IsSetIpv6Support() => this.Ipv6Support.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupReferencingSupport. 
        /// <para>
        /// Indicates whether security group referencing is enabled for this VPC attachment. The
        /// default is <c>true</c>. However, at the core network policy-level the default is set
        /// to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? SecurityGroupReferencingSupport { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupReferencingSupport property is set.
        /// </summary>
        internal bool IsSetSecurityGroupReferencingSupport() => this.SecurityGroupReferencingSupport.HasValue;
    }
}
