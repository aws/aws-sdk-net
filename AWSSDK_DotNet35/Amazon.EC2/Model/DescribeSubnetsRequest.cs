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
    /// Container for the parameters to the DescribeSubnets operation.
    /// Describes one or more of your subnets.
    /// 
    ///  
    /// <para>
    /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
    /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSubnetsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _subnetIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>availabilityZone</code> - The Availability Zone for the subnet. You can also
        /// use <code>availability-zone</code> as the filter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>available-ip-address-count</code> - The number of IP addresses in the subnet
        /// that are available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>cidrBlock</code> - The CIDR block of the subnet. The CIDR block you specify
        /// must exactly match the subnet's CIDR block for information to be returned for the
        /// subnet. You can also use <code>cidr</code> or <code>cidr-block</code> as the filter
        /// names.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>defaultForAz</code> - Indicates whether this is the default subnet for the Availability
        /// Zone. You can also use <code>default-for-az</code> as the filter name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>state</code> - The state of the subnet (<code>pending</code> | <code>available</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>subnet-id</code> - The ID of the subnet.
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
        /// <code>vpc-id</code> - The ID of the VPC for the subnet.
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// One or more subnet IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your subnets.
        /// </para>
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

    }
}