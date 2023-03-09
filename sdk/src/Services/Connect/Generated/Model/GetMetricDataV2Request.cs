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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricDataV2 operation.
    /// Gets metric data from the specified Amazon Connect instance. 
    /// 
    ///  
    /// <para>
    ///  <code>GetMetricDataV2</code> offers more features than <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricData.html">GetMetricData</a>,
    /// the previous version of this API. It has new metrics, offers filtering at a metric
    /// level, and offers the ability to filter and group data by channels, queues, routing
    /// profiles, agents, and agent hierarchy levels. It can retrieve historical data for
    /// last the 14 days, in 24-hour intervals.
    /// </para>
    ///  
    /// <para>
    /// For a description of the historical metrics that are supported by <code>GetMetricDataV2</code>
    /// and <code>GetMetricData</code>, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
    /// metrics definitions</a> in the <i>Amazon Connect Administrator's Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// This API is not available in the Amazon Web Services GovCloud (US) Regions.
    /// </para>
    /// </summary>
    public partial class GetMetricDataV2Request : AmazonConnectRequest
    {
        private DateTime? _endTime;
        private List<FilterV2> _filters = new List<FilterV2>();
        private List<string> _groupings = new List<string>();
        private int? _maxResults;
        private List<MetricV2> _metrics = new List<MetricV2>();
        private string _nextToken;
        private string _resourceArn;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp, in UNIX Epoch time format, at which to end the reporting interval for
        /// the retrieval of historical metrics data. The time must be later than the start time
        /// timestamp.
        /// </para>
        ///  
        /// <para>
        /// The time range between the start and end time must be less than 24 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters to apply to returned metrics. You can filter on the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Queues
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Routing profiles
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Agents
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Channels
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User hierarchy groups
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At least one filter must be passed from queues, routing profiles, agents, or user
        /// hierarchy groups.
        /// </para>
        ///  
        /// <para>
        /// To filter by phone number, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/create-historical-metrics-report.html">Create
        /// a historical metrics report</a> in the <i>Amazon Connect Administrator's Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Note the following limits:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Filter keys</b>: A maximum of 5 filter keys are supported in a single request.
        /// Valid filter keys: <code>QUEUE</code> | <code>ROUTING_PROFILE</code> | <code>AGENT</code>
        /// | <code>CHANNEL</code> | <code>AGENT_HIERARCHY_LEVEL_ONE</code> | <code>AGENT_HIERARCHY_LEVEL_TWO</code>
        /// | <code>AGENT_HIERARCHY_LEVEL_THREE</code> | <code>AGENT_HIERARCHY_LEVEL_FOUR</code>
        /// | <code>AGENT_HIERARCHY_LEVEL_FIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Filter values</b>: A maximum of 100 filter values are supported in a single request.
        /// For example, a <code>GetMetricDataV2</code> request can filter by 50 queues, 35 agents,
        /// and 15 routing profiles for a total of 100 filter values. <code>VOICE</code>, <code>CHAT</code>,
        /// and <code>TASK</code> are valid <code>filterValue</code> for the <code>CHANNEL</code>
        /// filter key.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<FilterV2> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Groupings. 
        /// <para>
        /// The grouping applied to the metrics that are returned. For example, when results are
        /// grouped by queue, the metrics returned are grouped by queue. The values that are returned
        /// apply to the metrics for each queue. They are not aggregated for all queues.
        /// </para>
        ///  
        /// <para>
        /// If no grouping is specified, a summary of all metrics is returned.
        /// </para>
        ///  
        /// <para>
        /// Valid grouping keys: <code>QUEUE</code> | <code>ROUTING_PROFILE</code> | <code>AGENT</code>
        /// | <code>CHANNEL</code> | <code>AGENT_HIERARCHY_LEVEL_ONE</code> | <code>AGENT_HIERARCHY_LEVEL_TWO</code>
        /// | <code>AGENT_HIERARCHY_LEVEL_THREE</code> | <code>AGENT_HIERARCHY_LEVEL_FOUR</code>
        /// | <code>AGENT_HIERARCHY_LEVEL_FIVE</code> 
        /// </para>
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
            return this._groupings != null && this._groupings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name, groupings, and filters for each metric.
        /// The following historical metrics are available. For a description of each metric,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// metrics definitions</a> in the <i>Amazon Connect Administrator's Guide</i>.
        /// </para>
        ///  <dl> <dt>AGENT_ADHERENT_TIME</dt> <dd> 
        /// <para>
        /// This metric is available only in Amazon Web Services Regions where <a href="https://docs.aws.amazon.com/connect/latest/adminguide/regions.html#optimization_region">Forecasting,
        /// capacity planning, and scheduling</a> is available.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// 
        /// </para>
        ///  </dd> <dt>AGENT_NON_RESPONSE</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// 
        /// </para>
        ///  </dd> <dt>AGENT_OCCUPANCY</dt> <dd> 
        /// <para>
        /// Unit: Percentage
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy 
        /// </para>
        ///  </dd> <dt>AGENT_SCHEDULE_ADHERENCE</dt> <dd> 
        /// <para>
        /// This metric is available only in Amazon Web Services Regions where <a href="https://docs.aws.amazon.com/connect/latest/adminguide/regions.html#optimization_region">Forecasting,
        /// capacity planning, and scheduling</a> is available.
        /// </para>
        ///  
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AGENT_SCHEDULED_TIME</dt> <dd> 
        /// <para>
        /// This metric is available only in Amazon Web Services Regions where <a href="https://docs.aws.amazon.com/connect/latest/adminguide/regions.html#optimization_region">Forecasting,
        /// capacity planning, and scheduling</a> is available.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_ABANDON_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_AGENT_CONNECTING_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <code>INITIATION_METHOD</code>. For now, this metric only
        /// supports the following as <code>INITIATION_METHOD</code>: <code>INBOUND</code> | <code>OUTBOUND</code>
        /// | <code>CALLBACK</code> | <code>API</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> <dt>AVG_QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> <dt>CONTACTS_ABANDONED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_CREATED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <code>INITIATION_METHOD</code> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <code>INITIATION_METHOD</code>, <code>DISCONNECT_REASON</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_HOLD_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_QUEUED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_BY_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>MAX_QUEUED_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SERVICE_LEVEL</dt> <dd> 
        /// <para>
        /// You can include up to 20 SERVICE_LEVEL metrics in a request.
        /// </para>
        ///  
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  
        /// <para>
        /// Threshold: For <code>ThresholdValue</code>, enter any whole number from 1 to 604800
        /// (inclusive), in seconds. For <code>Comparison</code>, you must enter <code>LT</code>
        /// (for "Less than"). 
        /// </para>
        ///  </dd> <dt>SUM_CONTACTS_ANSWERED_IN_X</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> <dt>SUM_CONTACTS_ABANDONED_IN_X</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> <dt>SUM_CONTACTS_DISCONNECTED </dt> <dd> 
        /// <para>
        /// Valid metric filter key: <code>DISCONNECT_REASON</code> 
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> <dt>SUM_RETRY_CALLBACK_ATTEMPTS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricV2> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2500)]
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource. This includes the <code>instanceId</code>
        /// an Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp, in UNIX Epoch time format, at which to start the reporting interval
        /// for the retrieval of historical metrics data. The time must be before the end time
        /// timestamp. The time range between the start and end time must be less than 24 hours.
        /// The start time cannot be earlier than 14 days before the time of the request. Historical
        /// metrics are available for 14 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}