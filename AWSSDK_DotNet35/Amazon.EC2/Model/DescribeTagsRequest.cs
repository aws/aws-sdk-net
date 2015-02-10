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
    /// Container for the parameters to the DescribeTags operation.
    /// Describes one or more of the tags for your EC2 resources.
    /// 
    ///  
    /// <para>
    /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DescribeTagsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeTagsRequest() { }

        /// <summary>
        /// Instantiates DescribeTagsRequest with the parameterized properties
        /// </summary>
        /// <param name="filters">One or more filters. <ul> <li> <code>key</code> - The tag key. </li> <li> <code>resource-id</code> - The resource ID. </li> <li> <code>resource-type</code> - The resource type (<code>customer-gateway</code> | <code>dhcp-options</code> | <code>image</code> | <code>instance</code> | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-interface</code> | <code>reserved-instances</code> | <code>route-table</code> | <code>security-group</code> | <code>snapshot</code> | <code>spot-instances-request</code> | <code>subnet</code> | <code>volume</code> | <code>vpc</code> | <code>vpn-connection</code> | <code>vpn-gateway</code>). </li> <li> <code>value</code> - The tag value. </li> </ul></param>
        public DescribeTagsRequest(List<Filter> filters)
        {
            _filters = filters;
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>key</code> - The tag key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>resource-id</code> - The resource ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>resource-type</code> - The resource type (<code>customer-gateway</code> | <code>dhcp-options</code>
        /// | <code>image</code> | <code>instance</code> | <code>internet-gateway</code> | <code>network-acl</code>
        /// | <code>network-interface</code> | <code>reserved-instances</code> | <code>route-table</code>
        /// | <code>security-group</code> | <code>snapshot</code> | <code>spot-instances-request</code>
        /// | <code>subnet</code> | <code>volume</code> | <code>vpc</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>value</code> - The tag value.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results. If the value
        /// is greater than 1000, we return only 1000 items.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a prior
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}