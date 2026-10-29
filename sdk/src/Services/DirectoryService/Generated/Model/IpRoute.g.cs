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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains the IP address block. This is often the address block of the DNS server used
    /// for your self-managed domain.
    /// </summary>
    public partial class IpRoute
    {
        /// <summary>
        /// Gets and sets the property CidrIp. 
        /// <para>
        /// IP address block in CIDR format, such as 10.0.0.0/24. This is often the address block
        /// of the DNS server used for your self-managed domain. For a single IP address, use
        /// a CIDR address block with /32. For example, 10.0.0.0/32.
        /// </para>
        /// </summary>
        public string CidrIp { get; set; }

        /// <summary>
        /// Checks to see if the CidrIp property is set.
        /// </summary>
        internal bool IsSetCidrIp() => this.CidrIp != null;

        /// <summary>
        /// Gets and sets the property CidrIpv6. 
        /// <para>
        /// IPv6 address block in CIDR format, such as 2001:db8::/32. This is often the address
        /// block of the DNS server used for your self-managed domain. For a single IPv6 address,
        /// use a CIDR address block with /128. For example, 2001:db8::1/128.
        /// </para>
        /// </summary>
        public string CidrIpv6 { get; set; }

        /// <summary>
        /// Checks to see if the CidrIpv6 property is set.
        /// </summary>
        internal bool IsSetCidrIpv6() => this.CidrIpv6 != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the address block.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
