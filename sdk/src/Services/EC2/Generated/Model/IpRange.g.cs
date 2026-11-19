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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an IPv4 address range.
    /// </summary>
    public partial class IpRange
    {
        /// <summary>
        /// Gets and sets the property CidrIp. 
        /// <para>
        /// The IPv4 address range. You can either specify a CIDR block or a source security group,
        /// not both. To specify a single IPv4 address, use the /32 prefix length.
        /// </para>
        ///  <note> 
        /// <para>
        ///  Amazon Web Services <a href="https://en.wikipedia.org/wiki/Canonicalization">canonicalizes</a>
        /// IPv4 and IPv6 CIDRs. For example, if you specify 100.68.0.18/18 for the CIDR block,
        /// Amazon Web Services canonicalizes the CIDR block to 100.68.0.0/18. Any subsequent
        /// DescribeSecurityGroups and DescribeSecurityGroupRules calls will return the canonicalized
        /// form of the CIDR block. Additionally, if you attempt to add another rule with the
        /// non-canonical form of the CIDR (such as 100.68.0.18/18) and there is already a rule
        /// for the canonicalized form of the CIDR block (such as 100.68.0.0/18), the API throws
        /// an duplicate rule error.
        /// </para>
        ///  </note>
        /// </summary>
        public string CidrIp { get; set; }

        /// <summary>
        /// Checks to see if the CidrIp property is set.
        /// </summary>
        internal bool IsSetCidrIp() => this.CidrIp != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the security group rule that references this IPv4 address range.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length. Allowed characters are a-z, A-Z, 0-9,
        /// spaces, and ._-:/()#,@[]+=&amp;;{}!$*
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;
    }
}
