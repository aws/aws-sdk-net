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
    /// Container for the parameters to the ListServiceDeployments operation.
    /// This operation lists all the service deployments that meet the specified filter criteria.
    /// 
    ///  
    /// <para>
    /// A service deployment happens when you release a software update for the service. You
    /// route traffic from the running service revisions to the new service revison and control
    /// the number of running tasks. 
    /// </para>
    ///  
    /// <para>
    /// This API returns the values that you use for the request parameters in <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_DescribeServiceRevisions.html">DescribeServiceRevisions</a>.
    /// </para>
    /// </summary>
    public partial class ListServiceDeploymentsRequest : AmazonECSRequest
    {
        private string _cluster;
        private CreatedAt _createdAt;
        private int? _maxResults;
        private string _nextToken;
        private string _service;
        private List<string> _status = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The cluster that hosts the service. This can either be the cluster name or ARN. Starting
        /// April 15, 2023, Amazon Web Services will not onboard new customers to Amazon Elastic
        /// Inference (EI), and will help current customers migrate their workloads to options
        /// that offer better price and performance. If you don't specify a cluster, <c>default</c>
        /// is used.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// An optional filter you can use to narrow the results by the service creation date.
        /// If you do not specify a value, the result includes all services created before the
        /// current time. The format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public CreatedAt CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of service deployment results that <c>ListServiceDeployments</c>
        /// returned in paginated output. When this parameter is used, <c>ListServiceDeployments</c>
        /// only returns <c>maxResults</c> results in a single page along with a <c>nextToken</c>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <c>ListServiceDeployments</c> request with the returned <c>nextToken</c> value.
        /// This value can be between 1 and 100. If this parameter isn't used, then <c>ListServiceDeployments</c>
        /// returns up to 20 results and a <c>nextToken</c> value if applicable.
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
        /// The <c>nextToken</c> value returned from a <c>ListServiceDeployments</c> request indicating
        /// that more results are available to fulfill the request and further calls are needed.
        /// If you provided <c>maxResults</c>, it's possible the number of results is fewer than
        /// <c>maxResults</c>.
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
        /// Gets and sets the property Service. 
        /// <para>
        /// The ARN or name of the service
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Service
        {
            get { return this._service; }
            set { this._service = value; }
        }

        // Check to see if Service property is set
        internal bool IsSetService()
        {
            return this._service != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// An optional filter you can use to narrow the results. If you do not specify a status,
        /// then all status values are included in the result.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null && (this._status.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}