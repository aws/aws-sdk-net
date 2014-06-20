/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Gives you information about your subnets.
    /// </summary>
    /// <remarks>
    /// You can filter the results to return information only about
    /// subnets that match criteria you specify.
    /// For example, you could ask to get information about a particular
    /// subnet (or all) only if the subnet's state is available.
    /// You can specify multiple filters (e.g., the subnet is in a
    /// particular VPC, and the subnet's state is available).
    ///
    /// The result includes information for a particular subnet
    /// only if the subnet matches all your filters. If there's
    /// no match, no special message is returned; the response
    /// is simply empty
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeSubnetsRequest : EC2Request
    {    
        private List<string> subnetIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more subnet IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public List<string> SubnetId
        {
            get
            {
                if (this.subnetIdField == null)
                {
                    this.subnetIdField = new List<string>();
                }
                return this.subnetIdField;
            }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets subnet IDs.
        /// </summary>
        /// <param name="list">A subnet ID.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSubnetsRequest WithSubnetId(params string[] list)
        {
            foreach (string item in list)
            {
                SubnetId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return (SubnetId.Count > 0);
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>availabilityZone</c> - The Availability Zone for the subnet. You can also use <c>availability-zone</c> as
        /// the filter name. </li> <li> <c>available-ip-address-count</c> - The number of IP addresses in the subnet that are available. </li> <li>
        /// <c>cidrBlock</c> - The CIDR block of the subnet. The CIDR block you specify must exactly match the subnet's CIDR block for information to be
        /// returned for the subnet. You can also use <c>cidr</c> or <c>cidr-block</c> as the filter names. </li> <li> <c>defaultForAz</c> - Indicates
        /// whether this is the default subnet for the Availability Zone. You can also use <c>default-for-az</c> as the filter name. </li> <li>
        /// <c>state</c> - The state of the subnet (<c>pending</c> | <c>available</c>). </li> <li> <c>subnet-id</c> - The ID of the subnet. </li> <li>
        /// <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a
        /// tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>vpc-id</c> - The ID of the VPC for the subnet. </li> </ul>
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets the filter to apply on the results of DescribeSubnets.
        /// </summary>
        /// <param name="list">The filter to apply on the results of DescribeSubnets. Filters can be:
        /// a. state - The state of the subnet. (pending, available).
        /// b. vpcId - The ID of the VPC the subnet is in.
        /// c. cidrBlock - The CIDR block of the subnet. The
        /// CIDR block you specify must exactly match the subnet's CIDR block
        /// for information to be returned for the subnet.
        /// Constraints: Must contain the slash followed by one or two
        /// digits (e.g., /28)
        /// d. - The Availability Zone the subnet is in.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeSubnetsRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}
