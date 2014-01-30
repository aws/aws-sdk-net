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
    /// Container for the parameters to the DescribeSubnets operation.
    /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
    /// Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeSubnetsRequest : AmazonEC2Request
    {
        private List<string> subnetIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more subnet IDs. Default: Describes all your subnets.
        ///  
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this.subnetIds; }
            set { this.subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this.subnetIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>availability-zone</c> - The Availability Zone for the subnet. </li> <li> <c>available-ip-address-count</c>
        /// - The number of IP addresses in the subnet that are available. </li> <li> <c>cidr</c> - The CIDR block of the subnet. The CIDR block you
        /// specify must exactly match the subnet's CIDR block for information to be returned for the subnet. </li> <li> <c>defaultForAz</c> - Indicates
        /// whether this is the default subnet for the Availability Zone. </li> <li> <c>state</c> - The state of the subnet (<c>pending</c> |
        /// <c>available</c>). </li> <li> <c>subnet-id</c> - The ID of the subnet. </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value
        /// combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you get
        /// any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the tag's
        /// key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li>
        /// <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li>
        /// <c>vpc-id</c> - The ID of the VPC for the subnet. </li> </ul>
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
    
