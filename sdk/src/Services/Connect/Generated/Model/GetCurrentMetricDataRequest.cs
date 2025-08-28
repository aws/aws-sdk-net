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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetCurrentMetricData operation.
    /// Gets the real-time metric data from the specified Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// For a description of each metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html">Metrics
    /// definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// When you make a successful API request, you can expect the following metric values
    /// in the response:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    ///  <b>Metric value is null</b>: The calculation cannot be performed due to divide by
    /// zero or insufficient data
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Metric value is a number (including 0) of defined type</b>: The number provided
    /// is the calculation result
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>MetricResult list is empty</b>: The request cannot find any data in the system
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The following guidelines can help you work with the API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Each dimension in the metric response must contain a value
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Each item in MetricResult must include all requested metrics
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the response is slow due to large result sets, try these approaches:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Add filters to reduce the amount of data returned
    /// </para>
    ///  </li> </ul> </li> </ul> </note>
    /// </summary>
    public partial class GetCurrentMetricDataRequest : AmazonConnectRequest
    {
        private List<CurrentMetric> _currentMetrics = AWSConfigs.InitializeCollections ? new List<CurrentMetric>() : null;
        private Filters _filters;
        private List<string> _groupings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private List<CurrentMetricSortCriteria> _sortCriteria = AWSConfigs.InitializeCollections ? new List<CurrentMetricSortCriteria>() : null;

        /// <summary>
        /// Gets and sets the property CurrentMetrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name and unit for each metric. The following
        /// metrics are available. For a description of all the metrics, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html">Metrics
        /// definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  <dl> <dt>AGENTS_AFTER_CONTACT_WORK</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#aftercallwork-real-time">ACW</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_AVAILABLE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#available-real-time">Available</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_ERROR</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#error-real-time">Error</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_NON_PRODUCTIVE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#non-productive-time-real-time">NPT
        /// (Non-Productive Time)</a> 
        /// </para>
        ///  </dd> <dt>AGENTS_ON_CALL</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#on-call-real-time">On
        /// contact</a> 
        /// </para>
        ///  </dd> <dt>AGENTS_ON_CONTACT</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#on-call-real-time">On
        /// contact</a> 
        /// </para>
        ///  </dd> <dt>AGENTS_ONLINE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#online-real-time">Online</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_STAFFED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#staffed-real-time">Staffed</a>
        /// 
        /// </para>
        ///  </dd> <dt>CONTACTS_IN_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#in-queue-real-time">In
        /// queue</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_SCHEDULED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#scheduled-real-time">Scheduled</a>
        /// 
        /// </para>
        ///  </dd> <dt>OLDEST_CONTACT_AGE</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// When you use groupings, Unit says SECONDS and the Value is returned in SECONDS. 
        /// </para>
        ///  
        /// <para>
        /// When you do not use groupings, Unit says SECONDS but the Value is returned in MILLISECONDS.
        /// For example, if you get a response like this:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "Metric": { "Name": "OLDEST_CONTACT_AGE", "Unit": "SECONDS" }, "Value": 24113.0
        /// </c>}
        /// </para>
        ///  
        /// <para>
        /// The actual OLDEST_CONTACT_AGE is 24 seconds.
        /// </para>
        ///  
        /// <para>
        /// When the filter <c>RoutingStepExpression</c> is used, this metric is still calculated
        /// from enqueue time. For example, if a contact that has been queued under <c>&lt;Expression
        /// 1&gt;</c> for 10 seconds has expired and <c>&lt;Expression 2&gt;</c> becomes active,
        /// then <c>OLDEST_CONTACT_AGE</c> for this queue will be counted starting from 10, not
        /// 0.
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#oldest-real-time">Oldest</a>
        /// 
        /// </para>
        ///  </dd> <dt>SLOTS_ACTIVE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#active-real-time">Active</a>
        /// 
        /// </para>
        ///  </dd> <dt>SLOTS_AVAILABLE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#availability-real-time">Availability</a>
        /// 
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CurrentMetric> CurrentMetrics
        {
            get { return this._currentMetrics; }
            set { this._currentMetrics = value; }
        }

        // Check to see if CurrentMetrics property is set
        internal bool IsSetCurrentMetrics()
        {
            return this._currentMetrics != null && (this._currentMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to returned metrics. You can filter up to the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Queues: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Routing profiles: 100
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Channels: 3 (VOICE, CHAT, and TASK channels are supported.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RoutingStepExpressions: 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AgentStatuses: 50
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Metric data is retrieved only for the resources associated with the queues or routing
        /// profiles, and by any channels included in the filter. (You cannot filter by both queue
        /// AND routing profile.) You can include both resource IDs and resource ARNs in the same
        /// request.
        /// </para>
        ///  
        /// <para>
        /// When using <c>AgentStatuses</c> as filter make sure Queues is added as primary filter.
        /// </para>
        ///  
        /// <para>
        /// When using the <c>RoutingStepExpression</c> filter, you need to pass exactly one <c>QueueId</c>.
        /// The filter is also case sensitive so when using the <c>RoutingStepExpression</c> filter,
        /// grouping by <c>ROUTING_STEP_EXPRESSION</c> is required.
        /// </para>
        ///  
        /// <para>
        /// Currently tagging is only supported on the resources that are passed in the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Filters Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null;
        }

        /// <summary>
        /// Gets and sets the property Groupings. 
        /// <para>
        /// Defines the level of aggregation for metrics data by a dimension(s). Its similar to
        /// sorting items into buckets based on a common characteristic, then counting or calculating
        /// something for each bucket. For example, when grouped by <c>QUEUE</c>, the metrics
        /// returned apply to each queue rather than aggregated for all queues. 
        /// </para>
        ///  
        /// <para>
        /// The grouping list is an ordered list, with the first item in the list defined as the
        /// primary grouping. If no grouping is included in the request, the aggregation happens
        /// at the instance-level.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you group by <c>CHANNEL</c>, you should include a Channels filter. VOICE, CHAT,
        /// and TASK channels are supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you group by <c>AGENT_STATUS</c>, you must include the <c>QUEUE</c> as the primary
        /// grouping and use queue filter. When you group by <c>AGENT_STATUS</c>, the only metric
        /// available is the <c>AGENTS_ONLINE</c> metric.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you group by <c>ROUTING_PROFILE</c>, you must include either a queue or routing
        /// profile filter. In addition, a routing profile filter is required for metrics <c>CONTACTS_SCHEDULED</c>,
        /// <c>CONTACTS_IN_QUEUE</c>, and <c> OLDEST_CONTACT_AGE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When using the <c>RoutingStepExpression</c> filter, group by <c>ROUTING_STEP_EXPRESSION</c>
        /// is required.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> Groupings
        {
            get { return this._groupings; }
            set { this._groupings = value; }
        }

        // Check to see if Groupings property is set
        internal bool IsSetGroupings()
        {
            return this._groupings != null && (this._groupings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        ///  
        /// <para>
        /// The token expires after 5 minutes from the time it is created. Subsequent requests
        /// that use the token must use the same request parameters as the request that generated
        /// the token.
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
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// The way to sort the resulting response based on metrics. You can enter one sort criteria.
        /// By default resources are sorted based on <c>AGENTS_ONLINE</c>, <c>DESCENDING</c>.
        /// The metric collection is sorted based on the input metrics.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sorting on <c>SLOTS_ACTIVE</c> and <c>SLOTS_AVAILABLE</c> is not supported.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<CurrentMetricSortCriteria> SortCriteria
        {
            get { return this._sortCriteria; }
            set { this._sortCriteria = value; }
        }

        // Check to see if SortCriteria property is set
        internal bool IsSetSortCriteria()
        {
            return this._sortCriteria != null && (this._sortCriteria.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}