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
    /// Container for the parameters to the DescribeReservedInstancesListings operation.
    /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeReservedInstancesListingsRequest : AmazonEC2Request
    {
        private string reservedInstancesId;
        private string reservedInstancesListingId;
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more Reserved Instance IDs.
        ///  
        /// </summary>
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesId; }
            set { this.reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this.reservedInstancesId != null;
        }

        /// <summary>
        /// One or more Reserved Instance Listing IDs.
        ///  
        /// </summary>
        public string ReservedInstancesListingId
        {
            get { return this.reservedInstancesListingId; }
            set { this.reservedInstancesListingId = value; }
        }

        // Check to see if ReservedInstancesListingId property is set
        internal bool IsSetReservedInstancesListingId()
        {
            return this.reservedInstancesListingId != null;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>reserved-instances-id</c> - The ID of the Reserved Instances. </li> <li>
        /// <c>reserved-instances-listing-id</c> - The ID of the Reserved Instances listing. </li> <li> <c>status</c> - The status of the Reserved
        /// Instance listing (<c>pending</c> | <c>active</c> | <c>cancelled</c> | <c>closed</c>). </li> <li> <c>status-message</c> - The reason for the
        /// status. </li> </ul>
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
    
