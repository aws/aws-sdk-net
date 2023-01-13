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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the SearchResources operation.
    /// Returns a list of Amazon Web Services resource identifiers that matches the specified
    /// query. The query uses the same format as a resource query in a <a>CreateGroup</a>
    /// or <a>UpdateGroupQuery</a> operation.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>resource-groups:SearchResources</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>cloudformation:DescribeStacks</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>cloudformation:ListStackResources</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>tag:GetResources</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class SearchResourcesRequest : AmazonResourceGroupsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private ResourceQuery _resourceQuery;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of results that you want included on each page of the response. If
        /// you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the maximum you specify, the <code>NextToken</code>
        /// response element is present and has a value (is not null). Include that value as the
        /// <code>NextToken</code> request parameter in the next call to the operation to get
        /// the next part of the results. Note that the service might return fewer results than
        /// the maximum even when there are more results available. You should check <code>NextToken</code>
        /// after every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The parameter for receiving additional results if you receive a <code>NextToken</code>
        /// response in a previous request. A <code>NextToken</code> response indicates that more
        /// output is available. Set this parameter to the value provided by a previous call's
        /// <code>NextToken</code> response to indicate where the output should continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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

        /// <summary>
        /// Gets and sets the property ResourceQuery. 
        /// <para>
        /// The search query, using the same formats that are supported for resource group definition.
        /// For more information, see <a>CreateGroup</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceQuery ResourceQuery
        {
            get { return this._resourceQuery; }
            set { this._resourceQuery = value; }
        }

        // Check to see if ResourceQuery property is set
        internal bool IsSetResourceQuery()
        {
            return this._resourceQuery != null;
        }

    }
}