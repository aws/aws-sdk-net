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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListClusterNodes operation.
    /// Retrieves the list of instances (also called <i>nodes</i> interchangeably) in a SageMaker
    /// HyperPod cluster.
    /// </summary>
    public partial class ListClusterNodesRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private bool? _includeNodeLogicalIds;
        private string _instanceGroupNameContains;
        private int? _maxResults;
        private string _nextToken;
        private ClusterSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The string name or the Amazon Resource Name (ARN) of the SageMaker HyperPod cluster
        /// in which you want to retrieve the list of nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
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
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns nodes in a SageMaker HyperPod cluster created after the specified
        /// time. Timestamps are formatted according to the ISO 8601 standard. 
        /// </para>
        ///  
        /// <para>
        /// Acceptable formats include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDThh:mm:ss.sssTZD</c> (UTC), for example, <c>2014-10-01T20:30:00.000Z</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDThh:mm:ss.sssTZD</c> (with offset), for example, <c>2014-10-01T12:30:00.000-08:00</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DD</c>, for example, <c>2014-10-01</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Unix time in seconds, for example, <c>1412195400</c>. This is also referred to as
        /// Unix Epoch time and represents the number of seconds since midnight, January 1, 1970
        /// UTC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about the timestamp format, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">Timestamp</a>
        /// in the <i>Amazon Web Services Command Line Interface User Guide</i>.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns nodes in a SageMaker HyperPod cluster created before the specified
        /// time. The acceptable formats are the same as the timestamp formats for <c>CreationTimeAfter</c>.
        /// For more information about the timestamp format, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-types.html#parameter-type-timestamp">Timestamp</a>
        /// in the <i>Amazon Web Services Command Line Interface User Guide</i>.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeNodeLogicalIds. 
        /// <para>
        /// Specifies whether to include nodes that are still being provisioned in the response.
        /// When set to true, the response includes all nodes regardless of their provisioning
        /// status. When set to <c>False</c> (default), only nodes with assigned <c>InstanceIds</c>
        /// are returned.
        /// </para>
        /// </summary>
        public bool? IncludeNodeLogicalIds
        {
            get { return this._includeNodeLogicalIds; }
            set { this._includeNodeLogicalIds = value; }
        }

        // Check to see if IncludeNodeLogicalIds property is set
        internal bool IsSetIncludeNodeLogicalIds()
        {
            return this._includeNodeLogicalIds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupNameContains. 
        /// <para>
        /// A filter that returns the instance groups whose name contain a specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string InstanceGroupNameContains
        {
            get { return this._instanceGroupNameContains; }
            set { this._instanceGroupNameContains = value; }
        }

        // Check to see if InstanceGroupNameContains property is set
        internal bool IsSetInstanceGroupNameContains()
        {
            return this._instanceGroupNameContains != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of nodes to return in the response.
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
        /// If the result of the previous <c>ListClusterNodes</c> request was truncated, the response
        /// includes a <c>NextToken</c>. To retrieve the next set of cluster nodes, use the token
        /// in the next request.
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
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field by which to sort results. The default value is <c>CREATION_TIME</c>.
        /// </para>
        /// </summary>
        public ClusterSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for results. The default value is <c>Ascending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}