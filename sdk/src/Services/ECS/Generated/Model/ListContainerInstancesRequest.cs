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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListContainerInstances operation.
    /// Returns a list of container instances in a specified cluster. You can filter the results
    /// of a <code>ListContainerInstances</code> operation with cluster query language statements
    /// inside the <code>filter</code> parameter. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
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
        /// You can filter the results of a <code>ListContainerInstances</code> operation with
        /// cluster query language statements. For more information, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguide/cluster-query-language.html">Cluster
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
        /// The maximum number of container instance results returned by <code>ListContainerInstances</code>
        /// in paginated output. When this parameter is used, <code>ListContainerInstances</code>
        /// only returns <code>maxResults</code> results in a single page along with a <code>nextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListContainerInstances</code> request with the returned <code>nextToken</code>
        /// value. This value can be between 1 and 100. If this parameter is not used, then <code>ListContainerInstances</code>
        /// returns up to 100 results and a <code>nextToken</code> value if applicable.
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
        /// The <code>nextToken</code> value returned from a previous paginated <code>ListContainerInstances</code>
        /// request where <code>maxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>nextToken</code> value.
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
        /// Filters the container instances by status. For example, if you specify the <code>DRAINING</code>
        /// status, the results include only container instances that have been set to <code>DRAINING</code>
        /// using <a>UpdateContainerInstancesState</a>. If you do not specify this parameter,
        /// the default is to include container instances set to <code>ACTIVE</code> and <code>DRAINING</code>.
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