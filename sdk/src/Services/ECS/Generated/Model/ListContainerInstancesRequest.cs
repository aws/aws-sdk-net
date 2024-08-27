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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListContainerInstances operation.
    /// Returns a list of container instances in a specified cluster. You can filter the results
    /// of a <c>ListContainerInstances</c> operation with cluster query language statements
    /// inside the <c>filter</c> parameter. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
    /// Query Language</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class ListContainerInstancesRequest : AmazonECSRequest
    {
        private string _cluster;
        private string _filter;
        private int? _maxResults;
        private string _nextToken;
        private ContainerInstanceStatus _status;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster that hosts the container
        /// instances to list. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// You can filter the results of a <c>ListContainerInstances</c> operation with cluster
        /// query language statements. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
        /// Query Language</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string Filter
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
        /// The maximum number of container instance results that <c>ListContainerInstances</c>
        /// returned in paginated output. When this parameter is used, <c>ListContainerInstances</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>ListContainerInstances</c> request with the returned <c>nextToken</c> value.
        /// This value can be between 1 and 100. If this parameter isn't used, then <c>ListContainerInstances</c>
        /// returns up to 100 results and a <c>nextToken</c> value if applicable.
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
        /// The <c>nextToken</c> value returned from a <c>ListContainerInstances</c> request indicating
        /// that more results are available to fulfill the request and further calls are needed.
        /// If <c>maxResults</c> was provided, it's possible the number of results to be fewer
        /// than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Filters the container instances by status. For example, if you specify the <c>DRAINING</c>
        /// status, the results include only container instances that have been set to <c>DRAINING</c>
        /// using <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_UpdateContainerInstancesState.html">UpdateContainerInstancesState</a>.
        /// If you don't specify this parameter, the default is to include container instances
        /// set to all states other than <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        public ContainerInstanceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}