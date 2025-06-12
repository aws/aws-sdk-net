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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroupResources operation.
    /// Returns a list of Amazon resource names (ARNs) of the resources that are members of
    /// a specified resource group.
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
    ///  <c>resource-groups:ListGroupResources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudformation:DescribeStacks</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>cloudformation:ListStackResources</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>tag:GetResources</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListGroupResourcesRequest : AmazonResourceGroupsRequest
    {
        private List<ResourceFilter> _filters = AWSConfigs.InitializeCollections ? new List<ResourceFilter>() : null;
        private string _group;
        private string _groupName;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters, formatted as <a>ResourceFilter</a> objects, that you want to apply to a <c>ListGroupResources</c>
        /// operation. Filters the results to include only those of the specified resource types.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resource-type</c> - Filter resources by their type. Specify up to five resource
        /// types in the format <c>AWS::ServiceCode::ResourceType</c>. For example, <c>AWS::EC2::Instance</c>,
        /// or <c>AWS::S3::Bucket</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you specify a <c>resource-type</c> filter for <c>ListGroupResources</c>, Resource
        /// Groups validates your filter resource types against the types that are defined in
        /// the query associated with the group. For example, if a group contains only S3 buckets
        /// because its query specifies only that resource type, but your <c>resource-type</c>
        /// filter includes EC2 instances, AWS Resource Groups does not filter for EC2 instances.
        /// In this case, a <c>ListGroupResources</c> request returns a <c>BadRequestException</c>
        /// error with a message similar to the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>The resource types specified as filters in the request are not valid.</c> 
        /// </para>
        ///  
        /// <para>
        /// The error includes a list of resource types that failed the validation because they
        /// are not part of the query associated with the group. This validation doesn't occur
        /// when the group query specifies <c>AWS::AllSupported</c>, because a group based on
        /// such a query can contain any of the allowed resource types for the query type (tag-based
        /// or Amazon CloudFront stack-based queries).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ResourceFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or the Amazon resource name (ARN) of the resource group. 
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
        ///  <i> <b>Deprecated - don't use this parameter. Use the <c>Group</c> request field
        /// instead.</b> </i> 
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
        /// operation. If additional items exist beyond the maximum you specify, the <c>NextToken</c>
        /// response element is present and has a value (is not null). Include that value as the
        /// <c>NextToken</c> request parameter in the next call to the operation to get the next
        /// part of the results. Note that the service might return fewer results than the maximum
        /// even when there are more results available. You should check <c>NextToken</c> after
        /// every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The parameter for receiving additional results if you receive a <c>NextToken</c> response
        /// in a previous request. A <c>NextToken</c> response indicates that more output is available.
        /// Set this parameter to the value provided by a previous call's <c>NextToken</c> response
        /// to indicate where the output should continue from.
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