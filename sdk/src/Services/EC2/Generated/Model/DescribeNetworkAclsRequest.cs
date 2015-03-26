/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Describes one or more of your network ACLs.
    /// 
    ///  
    /// <para>
    /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
    /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeNetworkAclsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _networkAclIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>association.association-id</code> - The ID of an association ID for the ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.network-acl-id</code> - The ID of the network ACL involved in the
        /// association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.subnet-id</code> - The ID of the subnet involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>default</code> - Indicates whether the ACL is the default network ACL for the
        /// VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.cidr</code> - The CIDR range specified in the entry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.egress</code> - Indicates whether the entry applies to egress traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.icmp.code</code> - The ICMP code specified in the entry, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.icmp.type</code> - The ICMP type specified in the entry, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.port-range.from</code> - The start of the port range specified in the
        /// entry. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.port-range.to</code> - The end of the port range specified in the entry.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.protocol</code> - The protocol specified in the entry (<code>tcp</code>
        /// | <code>udp</code> | <code>icmp</code> or a protocol number).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.rule-action</code> - Allows or denies the matching traffic (<code>allow</code>
        /// | <code>deny</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>entry.rule-number</code> - The number of an entry (in other words, rule) in
        /// the ACL's set of entries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>network-acl-id</code> - The ID of the network ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the <code>tag-value</code> filter. For example, if you use both the filter "tag-key=Purpose"
        /// and the filter "tag-value=X", you get any resources assigned both the tag key Purpose
        /// (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-id</code> - The ID of the VPC for the network ACL.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkAclIds. 
        /// <para>
        /// One or more network ACL IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your network ACLs.
        /// </para>
        /// </summary>
        public List<string> NetworkAclIds
        {
            get { return this._networkAclIds; }
            set { this._networkAclIds = value; }
        }

        // Check to see if NetworkAclIds property is set
        internal bool IsSetNetworkAclIds()
        {
            return this._networkAclIds != null && this._networkAclIds.Count > 0; 
        }

    }
}