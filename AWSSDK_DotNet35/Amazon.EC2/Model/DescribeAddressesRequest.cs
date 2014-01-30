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
    /// Container for the parameters to the DescribeAddresses operation.
    /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
    /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic
    /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeAddressesRequest : AmazonEC2Request
    {
        private List<string> publicIps = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private List<string> allocationIds = new List<string>();


        /// <summary>
        /// [EC2-Classic] One or more Elastic IP addresses. Default: Describes all your Elastic IP addresses.
        ///  
        /// </summary>
        public List<string> PublicIps
        {
            get { return this.publicIps; }
            set { this.publicIps = value; }
        }

        // Check to see if PublicIps property is set
        internal bool IsSetPublicIps()
        {
            return this.publicIps.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>allocation-id</c> - [EC2-VPC] The allocation ID for the address. </li> <li> <c>association-id</c> -
        /// [EC2-VPC] The association ID for the address. </li> <li> <c>domain</c> - Indicates whether the address is for use in EC2-Classic
        /// (<c>standard</c>) or in a VPC (<c>vpc</c>). </li> <li> <c>instance-id</c> - The ID of the instance the address is associated with, if any.
        /// </li> <li> <c>network-interface-id</c> - [EC2-VPC] The ID of the network interface that the address is associated with, if any. </li> <li>
        /// <c>network-interface-owner-id</c> - The AWS account ID of the owner. </li> <li> <c>private-ip-address</c> - [EC2-VPC] The private IP address
        /// associated with the Elastic IP address. </li> <li> <c>public-ip</c> - The Elastic IP address. </li> </ul>
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

        /// <summary>
        /// [EC2-VPC] One or more allocation IDs. Default: Describes all your Elastic IP addresses.
        ///  
        /// </summary>
        public List<string> AllocationIds
        {
            get { return this.allocationIds; }
            set { this.allocationIds = value; }
        }

        // Check to see if AllocationIds property is set
        internal bool IsSetAllocationIds()
        {
            return this.allocationIds.Count > 0;
        }

    }
}
    
