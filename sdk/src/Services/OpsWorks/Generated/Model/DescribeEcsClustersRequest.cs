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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEcsClusters operation.
    /// Describes Amazon ECS clusters that are registered with a stack. If you specify only
    /// a stack ID, you can use the <c>MaxResults</c> and <c>NextToken</c> parameters to paginate
    /// the response. However, OpsWorks Stacks currently supports only one cluster per layer,
    /// so the result set has a maximum of one element.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack or an attached policy that explicitly grants
    /// permission. For more information about user permissions, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// This call accepts only one resource-identifying parameter.
    /// </para>
    /// </summary>
    public partial class DescribeEcsClustersRequest : AmazonOpsWorksRequest
    {
        private List<string> _ecsClusterArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property EcsClusterArns. 
        /// <para>
        /// A list of ARNs, one for each cluster to be described.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EcsClusterArns
        {
            get { return this._ecsClusterArns; }
            set { this._ecsClusterArns = value; }
        }

        // Check to see if EcsClusterArns property is set
        internal bool IsSetEcsClusterArns()
        {
            return this._ecsClusterArns != null && (this._ecsClusterArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// To receive a paginated response, use this parameter to specify the maximum number
        /// of results to be returned with a single call. If the number of available results exceeds
        /// this maximum, the response includes a <c>NextToken</c> value that you can assign to
        /// the <c>NextToken</c> request parameter to get the next set of results.
        /// </para>
        /// </summary>
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
        /// If the previous paginated request did not return all of the remaining results, the
        /// response object's<c>NextToken</c> parameter value is set to a token. To retrieve the
        /// next set of results, call <c>DescribeEcsClusters</c> again and assign that token to
        /// the request object's <c>NextToken</c> parameter. If there are no remaining results,
        /// the previous response object's <c>NextToken</c> parameter is set to <c>null</c>.
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

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// A stack ID. <c>DescribeEcsClusters</c> returns a description of the cluster that is
        /// registered with the stack.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}