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
    /// Container for the parameters to the DescribeVpcs operation.
    /// <para>Describes one or more of your VPCs.</para>
    /// </summary>
    public partial class DescribeVpcsRequest : AmazonEC2Request
    {
        private List<string> vpcIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more VPC IDs. Default: Describes all your VPCs.
        ///  
        /// </summary>
        public List<string> VpcIds
        {
            get { return this.vpcIds; }
            set { this.vpcIds = value; }
        }

        // Check to see if VpcIds property is set
        internal bool IsSetVpcIds()
        {
            return this.vpcIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>cidr</c> - The CIDR block of the VPC. The CIDR block you specify must exactly match the VPC's CIDR block
        /// for information to be returned for the VPC. </li> <li> <c>dhcp-options-id</c> - The ID of a set of DHCP options. </li> <li> <c>isDefault</c>
        /// - Indicates whether the VPC is the default VPC. </li> <li> <c>state</c> - The state of the VPC (<c>pending</c> | <c>available</c>). </li>
        /// <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key
        /// of a tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>vpc-id</c> - The ID of the VPC. </li> </ul>
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
    
