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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEcsClusters operation.
    /// Describes Amazon ECS clusters that are registered with a stack. If you specify only
    /// a stack ID, you can use the <code>MaxResults</code> and <code>NextToken</code> parameters
    /// to paginate the response. However, AWS OpsWorks currently supports only one cluster
    /// per layer, so the result set has a maximum of one element.
    /// 
    ///  
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack or an attached policy that explicitly grants
    /// permission. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeEcsClustersRequest : AmazonOpsWorksRequest
    {
        private List<string> _ecsClusterArns = new List<string>();
        private int? _maxResults;
        private string _nextToken;
        private string _stackId;

        /// <summary>
        /// Gets and sets the property EcsClusterArns. 
        /// <para>
        /// A list of ARNs, one for each cluster to be described.
        /// </para>
        /// </summary>
        public List<string> EcsClusterArns
        {
            get { return this._ecsClusterArns; }
            set { this._ecsClusterArns = value; }
        }

        // Check to see if EcsClusterArns property is set
        internal bool IsSetEcsClusterArns()
        {
            return this._ecsClusterArns != null && this._ecsClusterArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// To receive a paginated response, use this parameter to specify the maximum number
        /// of results to be returned with a single call. If the number of available results exceeds
        /// this maximum, the response includes a <code>NextToken</code> value that you can assign
        /// to the <code>NextToken</code> request parameter to get the next set of results.
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
        /// If the previous paginated request did not return all of the remaining results, the
        /// response object's<code>NextToken</code> parameter value is set to a token. To retrieve
        /// the next set of results, call <code>DescribeEcsClusters</code> again and assign that
        /// token to the request object's <code>NextToken</code> parameter. If there are no remaining
        /// results, the previous response object's <code>NextToken</code> parameter is set to
        /// <code>null</code>.
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
        /// A stack ID. <code>DescribeEcsClusters</code> returns a description of the cluster
        /// that is registered with the stack.
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