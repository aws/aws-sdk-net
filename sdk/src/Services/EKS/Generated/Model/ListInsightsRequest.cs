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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the ListInsights operation.
    /// Returns a list of all insights checked for against the specified cluster. You can
    /// filter which insights are returned by category, associated Kubernetes version, and
    /// status. The default filter lists all categories and every status.
    /// 
    ///  
    /// <para>
    /// The following lists the available categories:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>UPGRADE_READINESS</c>: Amazon EKS identifies issues that could impact your ability
    /// to upgrade to new versions of Kubernetes. These are called upgrade insights.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MISCONFIGURATION</c>: Amazon EKS identifies misconfiguration in your EKS Hybrid
    /// Nodes setup that could impair functionality of your cluster or workloads. These are
    /// called configuration insights.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListInsightsRequest : AmazonEKSRequest
    {
        private string _clusterName;
        private InsightsFilter _filter;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the Amazon EKS cluster associated with the insights.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The criteria to filter your list of insights for your cluster. You can filter which
        /// insights are returned by category, associated Kubernetes version, and status.
        /// </para>
        /// </summary>
        public InsightsFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of identity provider configurations returned by <c>ListInsights</c>
        /// in paginated output. When you use this parameter, <c>ListInsights</c> returns only
        /// <c>maxResults</c> results in a single page along with a <c>nextToken</c> response
        /// element. You can see the remaining results of the initial request by sending another
        /// <c>ListInsights</c> request with the returned <c>nextToken</c> value. This value can
        /// be between 1 and 100. If you don't use this parameter, <c>ListInsights</c> returns
        /// up to 100 results and a <c>nextToken</c> value, if applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The <c>nextToken</c> value returned from a previous paginated <c>ListInsights</c>
        /// request. When the results of a <c>ListInsights</c> request exceed <c>maxResults</c>,
        /// you can use this value to retrieve the next page of results. This value is <c>null</c>
        /// when there are no more results to return.
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