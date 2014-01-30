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
    /// Container for the parameters to the DescribeTags operation.
    /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i> .</para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonEC2Request
    {
        private List<Filter> filters = new List<Filter>();
        private int? maxResults;
        private string nextToken;


        /// <summary>
        /// One or more filters. <ul> <li> <c>key</c> - The tag key. </li> <li> <c>resource-id</c> - The resource ID. </li> <li> <c>resource-type</c> -
        /// The resource type (<c>customer-gateway</c> | <c>dhcp-options</c> | <c>image</c> | <c>instance</c> | <c>internet-gateway</c> |
        /// <c>network-acl</c> | <c>network-interface</c> | <c>reserved-instances</c> | <c>route-table</c> | <c>security-group</c> | <c>snapshot</c> |
        /// <c>spot-instances-request</c> | <c>subnet</c> | <c>volume</c> | <c>vpc</c> | <c>vpn-connection</c> | <c>vpn-gateway</c>). </li> <li>
        /// <c>value</c> - The tag value. </li> </ul>
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
        /// The maximum number of items to return for this call. The call also returns a token that you can specify in a subsequent call to get the next
        /// set of results. If the value is greater than 1000, we return only 1000 items.
        ///  
        /// </summary>
        public int MaxResults
        {
            get { return this.maxResults ?? default(int); }
            set { this.maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this.maxResults.HasValue;
        }

        /// <summary>
        /// The token for the next set of items to return. (You received this token from a prior call.)
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }

    }
}
    
