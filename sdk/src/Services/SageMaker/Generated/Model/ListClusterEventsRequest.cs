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
    /// Container for the parameters to the ListClusterEvents operation.
    /// Retrieves a list of event summaries for a specified HyperPod cluster. The operation
    /// supports filtering, sorting, and pagination of results. This functionality is only
    /// supported when the <c>NodeProvisioningMode</c> is set to <c>Continuous</c>.
    /// </summary>
    public partial class ListClusterEventsRequest : AmazonSageMakerRequest
    {
        private string _clusterName;
        private DateTime? _eventTimeAfter;
        private DateTime? _eventTimeBefore;
        private string _instanceGroupName;
        private int? _maxResults;
        private string _nextToken;
        private string _nodeId;
        private ClusterEventResourceType _resourceType;
        private EventSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the HyperPod cluster for which to list events.
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
        /// Gets and sets the property EventTimeAfter. 
        /// <para>
        /// The start of the time range for filtering events. Only events that occurred after
        /// this time are included in the results.
        /// </para>
        /// </summary>
        public DateTime? EventTimeAfter
        {
            get { return this._eventTimeAfter; }
            set { this._eventTimeAfter = value; }
        }

        // Check to see if EventTimeAfter property is set
        internal bool IsSetEventTimeAfter()
        {
            return this._eventTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventTimeBefore. 
        /// <para>
        /// The end of the time range for filtering events. Only events that occurred before this
        /// time are included in the results.
        /// </para>
        /// </summary>
        public DateTime? EventTimeBefore
        {
            get { return this._eventTimeBefore; }
            set { this._eventTimeBefore = value; }
        }

        // Check to see if EventTimeBefore property is set
        internal bool IsSetEventTimeBefore()
        {
            return this._eventTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group to filter events. If specified, only events related
        /// to this instance group are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string InstanceGroupName
        {
            get { return this._instanceGroupName; }
            set { this._instanceGroupName = value; }
        }

        // Check to see if InstanceGroupName property is set
        internal bool IsSetInstanceGroupName()
        {
            return this._instanceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of events to return in the response. Valid range is 1 to 100.
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
        /// A token to retrieve the next set of results. This token is obtained from the output
        /// of a previous <c>ListClusterEvents</c> call.
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
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The EC2 instance ID to filter events. If specified, only events related to this instance
        /// are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NodeId
        {
            get { return this._nodeId; }
            set { this._nodeId = value; }
        }

        // Check to see if NodeId property is set
        internal bool IsSetNodeId()
        {
            return this._nodeId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for which to filter events. Valid values are <c>Cluster</c>,
        /// <c>InstanceGroup</c>, or <c>Instance</c>.
        /// </para>
        /// </summary>
        public ClusterEventResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to use for sorting the event list. Currently, the only supported value is
        /// <c>EventTime</c>.
        /// </para>
        /// </summary>
        public EventSortBy SortBy
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
        /// The order in which to sort the results. Valid values are <c>Ascending</c> or <c>Descending</c>
        /// (the default is <c>Descending</c>).
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