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
    /// <para> The DescribeAddresses operation lists elastic IP addresses assigned to your account. </para>
    /// </summary>
    public partial class DescribeAddressesRequest : AmazonEC2Request
    {
        private List<string> publicIps = new List<string>();
        private List<Filter> filters = new List<Filter>();
        private List<string> allocationIds = new List<string>();


        /// <summary>
        /// The optional list of Elastic IP addresses to describe.
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
        /// A list of filters used to match properties for Addresses. For a complete reference to the available filter keys for this operation, see the
        /// <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
    
