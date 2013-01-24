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
    /// Gives you information about your VPCs.
    /// </summary>
    /// <remarks>
    /// You can filter the results to return information only
    /// about VPCs that match criteria you specify.
    ///
    /// For example, you could ask to get information about a
    /// particular VPC or VPCs (or all your VPCs) only if the
    /// VPC's state is available.
    ///
    /// You can specify multiple filters (e.g., the VPC uses
    /// one of several sets of DHCP options, and the VPC's
    /// state is available).
    ///
    /// The result includes information for a particular VPC
    /// only if the VPC matches all your filters.
    ///
    /// If there's no match, no special message is returned;
    /// the response is simply empty.
    ///
    /// The information returned consists of:
    /// a) The VPC ID.
    /// b) The CIDR block
    /// you've assigned to the VPC.
    /// c) The ID of the DHCP options you've associated with the VPC
    /// (or "default" if the default options are associated with the VPC)
    ///
    /// The current state of the VPC (pending or available)
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVpcsRequest
    {    
        private List<string> vpcIdField;
        private List<Filter> filterField;

        /// <summary>
        /// List of VPC IDs for which you want information.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpcId")]
        public List<string> VpcId
        {
            get
            {
                if (this.vpcIdField == null)
                {
                    this.vpcIdField = new List<string>();
                }
                return this.vpcIdField;
            }
            set { this.vpcIdField = value; }
        }

        /// <summary>
        /// Sets list of VPC IDs for which you want information.
        /// </summary>
        /// <param name="list">The ID of a VPC you want information about.</param>
        /// <returns>this instance</returns>
        public DescribeVpcsRequest WithVpcId(params string[] list)
        {
            foreach (string item in list)
            {
                VpcId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VpcId property is set
        /// </summary>
        /// <returns>true if VpcId property is set</returns>
        public bool IsSetVpcId()
        {
            return (VpcId.Count > 0);
        }

        /// <summary>
        /// List of filters used to specify which VPCs to describe.
        /// The available filters are:
        /// 1. state - The state of the VPC.
        /// Valid Values: pending, available.
        /// 2. cidrBlock - The CIDR block of the VPC. The CIDR block you
        /// specify must exactly match the VPC's CIDR block for information to be
        /// returned for the VPC.
        /// Constraints: Must contain the slash followed by one or two
        /// digits (e.g., /28).
        /// 3. dhcpOptionsId - The IP of a set of DHCP options.
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
        /// Sets filters used to specify which VPCs to describe.
        /// </summary>
        /// <param name="list">The available filters are:
        /// 1. state - The state of the VPC. Valid Values: pending,
        /// available.
        /// 2. cidrBlock - The CIDR block of the VPC. The CIDR block you
        /// specify must exactly match the VPC's CIDR block for information to be
        /// returned for the VPC.
        /// Constraints: Must contain the slash followed by one or two
        /// digits (e.g., /28).
        /// 3. dhcpOptionsId - The IP of a set of DHCP options.</param>
        /// <returns>this instance</returns>
        public DescribeVpcsRequest WithFilter(params Filter[] list)
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
