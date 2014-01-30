/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeNetworkAcls operation.
    /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
    /// Guide</i> .</para>
    /// </summary>
    public partial class DescribeNetworkAclsRequest : AmazonEC2Request
    {
        private List<string> networkAclIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more network ACL IDs. Default: Describes all your network ACLs.
        ///  
        /// </summary>
        public List<string> NetworkAclIds
        {
            get { return this.networkAclIds; }
            set { this.networkAclIds = value; }
        }

        // Check to see if NetworkAclIds property is set
        internal bool IsSetNetworkAclIds()
        {
            return this.networkAclIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>association.association-id</c> - The ID of an association ID for the ACL. </li> <li>
        /// <c>association.network-acl-id</c> - The ID of the network ACL involved in the association. </li> <li> <c>association.subnet-id</c> - The ID
        /// of the subnet involved in the association. </li> <li> <c>default</c> - Indicates whether the ACL is the default network ACL for the VPC.
        /// </li> <li> <c>entry.cidr</c> - The CIDR range specified in the entry. </li> <li> <c>entry.egress</c> - Indicates whether the entry applies
        /// to egress traffic. </li> <li> <c>entry.icmp.code</c> - The ICMP code specified in the entry, if any. </li> <li> <c>entry.icmp.type</c> - The
        /// ICMP type specified in the entry, if any. </li> <li> <c>entry.port-range.from</c> - The start of the port range specified in the entry.
        /// </li> <li> <c>entry.port-range.to</c> - The end of the port range specified in the entry. </li> <li> <c>entry.protocol</c> - The protocol
        /// specified in the entry (<c>tcp</c> | <c>udp</c> | <c>icmp</c> or a protocol number). </li> <li> <c>entry.rule-action</c> - Allows or denies
        /// the matching traffic (<c>allow</c> | <c>deny</c>). </li> <li> <c>entry.rule-number</c> - The number of an entry (in other words, rule) in
        /// the ACL's set of entries. </li> <li> <c>network-acl-id</c> - The ID of the network ACL. </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The
        /// key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter
        /// is independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you
        /// get any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li>
        /// <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li>
        /// <c>vpc-id</c> - The ID of the VPC for the network ACL. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
