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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListClusterEvents operation. Retrieves a list
    /// of event summaries for a specified HyperPod cluster. The operation supports filtering,
    /// sorting, and pagination of results. This functionality is only supported when the
    /// <c>NodeProvisioningMode</c> is set to <c>Continuous</c>.
    /// </summary>
    public partial class ListClusterEventsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the HyperPod cluster for which to list events.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property EventTimeAfter. 
        /// <para>
        /// The start of the time range for filtering events. Only events that occurred after
        /// this time are included in the results.
        /// </para>
        /// </summary>
        public DateTime? EventTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the EventTimeAfter property is set.
        /// </summary>
        internal bool IsSetEventTimeAfter() => this.EventTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property EventTimeBefore. 
        /// <para>
        /// The end of the time range for filtering events. Only events that occurred before this
        /// time are included in the results.
        /// </para>
        /// </summary>
        public DateTime? EventTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the EventTimeBefore property is set.
        /// </summary>
        internal bool IsSetEventTimeBefore() => this.EventTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceGroupName. 
        /// <para>
        /// The name of the instance group to filter events. If specified, only events related
        /// to this instance group are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string InstanceGroupName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceGroupName property is set.
        /// </summary>
        internal bool IsSetInstanceGroupName() => this.InstanceGroupName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of events to return in the response. Valid range is 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to retrieve the next set of results. This token is obtained from the output
        /// of a previous <c>ListClusterEvents</c> call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NodeId. 
        /// <para>
        /// The EC2 instance ID to filter events. If specified, only events related to this instance
        /// are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NodeId { get; set; }

        /// <summary>
        /// Checks to see if the NodeId property is set.
        /// </summary>
        internal bool IsSetNodeId() => this.NodeId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource for which to filter events. Valid values are <c>Cluster</c>,
        /// <c>InstanceGroup</c>, or <c>Instance</c>.
        /// </para>
        /// </summary>
        public ClusterEventResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field to use for sorting the event list. Currently, the only supported value is
        /// <c>EventTime</c>.
        /// </para>
        /// </summary>
        public EventSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which to sort the results. Valid values are <c>Ascending</c> or <c>Descending</c>
        /// (the default is <c>Descending</c>).
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
