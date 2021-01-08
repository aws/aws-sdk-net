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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAddresses operation.
    /// Describes the specified Elastic IP addresses or all of your Elastic IP addresses.
    /// 
    ///  
    /// <para>
    /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
    /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
    /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeAddressesRequest : AmazonEC2Request
    {
        private List<string> _allocationIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();
        private List<string> _publicIps = new List<string>();

        /// <summary>
        /// Gets and sets the property AllocationIds. 
        /// <para>
        /// [EC2-VPC] Information about the allocation IDs.
        /// </para>
        /// </summary>
        public List<string> AllocationIds
        {
            get { return this._allocationIds; }
            set { this._allocationIds = value; }
        }

        // Check to see if AllocationIds property is set
        internal bool IsSetAllocationIds()
        {
            return this._allocationIds != null && this._allocationIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Filter names and values are case-sensitive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>allocation-id</code> - [EC2-VPC] The allocation ID for the address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>association-id</code> - [EC2-VPC] The association ID for the address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>domain</code> - Indicates whether the address is for use in EC2-Classic (<code>standard</code>)
        /// or in a VPC (<code>vpc</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-id</code> - The ID of the instance the address is associated with,
        /// if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-border-group</code> - A unique set of Availability Zones, Local Zones,
        /// or Wavelength Zones from where AWS advertises IP addresses. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-id</code> - [EC2-VPC] The ID of the network interface that
        /// the address is associated with, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface-owner-id</code> - The AWS account ID of the owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>private-ip-address</code> - [EC2-VPC] The private IP address associated with
        /// the Elastic IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>public-ip</code> - The Elastic IP address, or the carrier IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
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
        /// Gets and sets the property PublicIps. 
        /// <para>
        /// One or more Elastic IP addresses.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your Elastic IP addresses.
        /// </para>
        /// </summary>
        public List<string> PublicIps
        {
            get { return this._publicIps; }
            set { this._publicIps = value; }
        }

        // Check to see if PublicIps property is set
        internal bool IsSetPublicIps()
        {
            return this._publicIps != null && this._publicIps.Count > 0; 
        }

    }
}