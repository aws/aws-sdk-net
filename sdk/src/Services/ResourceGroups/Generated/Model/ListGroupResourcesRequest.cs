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
    /// Container for the parameters to the ListGroupResources operation.
    /// Returns a list of ARNs of the resources that are members of a specified resource group.
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
    ///  <code>resource-groups:ListGroupResources</code> 
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
    public partial class ListGroupResourcesRequest : AmazonResourceGroupsRequest
    {
        private List<ResourceFilter> _filters = new List<ResourceFilter>();
        private string _group;
        private string _groupName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters, formatted as <a>ResourceFilter</a> objects, that you want to apply to a <code>ListGroupResources</code>
        /// operation. Filters the results to include only those of the specified resource types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>resource-type</code> - Filter resources by their type. Specify up to five resource
        /// types in the format <code>AWS::ServiceCode::ResourceType</code>. For example, <code>AWS::EC2::Instance</code>,
        /// or <code>AWS::S3::Bucket</code>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify a <code>resource-type</code> filter for <code>ListGroupResources</code>,
        /// Resource Groups validates your filter resource types against the types that are defined
        /// in the query associated with the group. For example, if a group contains only S3 buckets
        /// because its query specifies only that resource type, but your <code>resource-type</code>
        /// filter includes EC2 instances, AWS Resource Groups does not filter for EC2 instances.
        /// In this case, a <code>ListGroupResources</code> request returns a <code>BadRequestException</code>
        /// error with a message similar to the following:
        /// </para>
        ///  
        /// <para>
        ///  <code>The resource types specified as filters in the request are not valid.</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The error includes a list of resource types that failed the validation because they
        /// are not part of the query associated with the group. This validation doesn't occur
        /// when the group query specifies <code>AWS::AllSupported</code>, because a group based
        /// on such a query can contain any of the allowed resource types for the query type (tag-based
        /// or Amazon CloudFront stack-based queries).
        /// </para>
        /// </summary>
        public List<ResourceFilter> Filters
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
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the ARN of the resource group
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. <important> 
        /// <para>
        ///  <i> <b>Deprecated - don't use this parameter. Use the <code>Group</code> request
        /// field instead.</b> </i> 
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("This field is deprecated, use Group instead.")]
        [AWSProperty(Min=1, Max=300)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

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

    }
}