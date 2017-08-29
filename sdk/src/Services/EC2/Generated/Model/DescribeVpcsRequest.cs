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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DescribeVpcs operation.
    /// Describes one or more of your VPCs.
    /// </summary>
    public partial class DescribeVpcsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _vpcIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>cidr</code> - The primary IPv4 CIDR block of the VPC. The CIDR block you specify
        /// must exactly match the VPC's CIDR block for information to be returned for the VPC.
        /// Must contain the slash followed by one or two digits (for example, <code>/28</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cidr-block-association.cidr-block</code> - An IPv4 CIDR block associated with
        /// the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cidr-block-association.association-id</code> - The association ID for an IPv4
        /// CIDR block associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cidr-block-association.state</code> - The state of an IPv4 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dhcp-options-id</code> - The ID of a set of DHCP options.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.ipv6-cidr-block</code> - An IPv6 CIDR block associated
        /// with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.association-id</code> - The association ID for
        /// an IPv6 CIDR block associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ipv6-cidr-block-association.state</code> - The state of an IPv6 CIDR block
        /// associated with the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>isDefault</code> - Indicates whether the VPC is the default VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the VPC (<code>pending</code> | <code>available</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource. Specify the key of the tag in the filter name and the value of the
        /// tag in the filter value. For example, for the tag Purpose=X, specify <code>tag:Purpose</code>
        /// for the filter name and <code>X</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. This filter is
        /// independent of the <code>tag-value</code> filter. For example, if you use both the
        /// filter "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned
        /// both the tag key Purpose (regardless of what the tag's value is), and the tag value
        /// X (regardless of what the tag's key is). If you want to list only resources where
        /// Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-id</code> - The ID of the VPC.
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
        /// Gets and sets the property VpcIds. 
        /// <para>
        /// One or more VPC IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your VPCs.
        /// </para>
        /// </summary>
        public List<string> VpcIds
        {
            get { return this._vpcIds; }
            set { this._vpcIds = value; }
        }

        // Check to see if VpcIds property is set
        internal bool IsSetVpcIds()
        {
            return this._vpcIds != null && this._vpcIds.Count > 0; 
        }

    }
}