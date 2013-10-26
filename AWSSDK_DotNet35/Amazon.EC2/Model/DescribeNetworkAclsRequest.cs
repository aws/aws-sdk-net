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
    /// Container for the parameters to the DescribeNetworkAcls operation.
    /// <para> Gives you information about the network ACLs in your VPC. You can filter the results to return information only about ACLs that match
    /// criteria you specify. For example, you could get information only the ACL associated with a particular subnet. The ACL must match at least
    /// one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the ACL is
    /// associated with a particular subnet and has an egress entry that denies traffic to a particular port). The result includes information for a
    /// particular ACL only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty.
    /// </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
    /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
    /// for the literal string <c>*amazon?\</c> .
    /// </para>
    /// </summary>
    public partial class DescribeNetworkAclsRequest : AmazonEC2Request
    {
        private List<string> networkAclIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more network ACL IDs.
        ///  
        /// </summary>
        public List<string> NetworkAclIds
        {
            get { return this.networkAclIds; }
            set { this.networkAclIds = value; }
        }

        // Check to see if NetworkAclIds property is set
        internal bool IsSetNetworkAclIds()
        {
            return this.networkAclIds.Count > 0;
        }

        /// <summary>
        /// A list of filters used to match properties for Network ACLs. For a complete reference to the available filter keys for this operation, see
        /// the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
    
