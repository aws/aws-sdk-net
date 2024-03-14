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
    ///  <c>GetMetricDataV2</c> offers more features than <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricData.html">GetMetricData</a>,
    /// the previous version of this API. It has new metrics, offers filtering at a metric
    /// level, and offers the ability to filter and group data by channels, queues, routing
    /// profiles, agents, and agent hierarchy levels. It can retrieve historical data for
    /// the last 3 months, at varying intervals. 
    /// </para>
    ///  
    /// <para>
    /// For a description of the historical metrics that are supported by <c>GetMetricDataV2</c>
    /// and <c>GetMetricData</c>, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
    /// metrics definitions</a> in the <i>Amazon Connect Administrator's Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetMetricDataV2Request : AmazonConnectRequest
    {
        private DateTime? _endTime;
        private List<FilterV2> _filters = new List<FilterV2>();
        private List<string> _groupings = new List<string>();
        private IntervalDetails _interval;
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
        /// timestamp. It cannot be later than the current timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
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
        ///  </li> <li> 
        /// <para>
        /// Feature
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Routing step expression
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
        /// Valid filter keys: <c>QUEUE</c> | <c>ROUTING_PROFILE</c> | <c>AGENT</c> | <c>CHANNEL</c>
        /// | <c>AGENT_HIERARCHY_LEVEL_ONE</c> | <c>AGENT_HIERARCHY_LEVEL_TWO</c> | <c>AGENT_HIERARCHY_LEVEL_THREE</c>
        /// | <c>AGENT_HIERARCHY_LEVEL_FOUR</c> | <c>AGENT_HIERARCHY_LEVEL_FIVE</c> | <c>FEATURE</c>
        /// | <c>contact/segmentAttributes/connect:Subtype</c> | <c>ROUTING_STEP_EXPRESSION</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Filter values</b>: A maximum of 100 filter values are supported in a single request.
        /// VOICE, CHAT, and TASK are valid <c>filterValue</c> for the CHANNEL filter key. They
        /// do not count towards limitation of 100 filter values. For example, a GetMetricDataV2
        /// request can filter by 50 queues, 35 agents, and 15 routing profiles for a total of
        /// 100 filter values, along with 3 channel filters. 
        /// </para>
        ///  
        /// <para>
        ///  <c>contact_lens_conversational_analytics</c> is a valid filterValue for the <c>FEATURE</c>
        /// filter key. It is available only to contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        ///  <c>connect:Chat</c>, <c>connect:SMS</c>, <c>connect:Telephony</c>, and <c>connect:WebRTC</c>
        /// are valid <c>filterValue</c> examples (not exhaustive) for the <c>contact/segmentAttributes/connect:Subtype
        /// filter</c> key.
        /// </para>
        ///  
        /// <para>
        ///  <c>ROUTING_STEP_EXPRESSION</c> is a valid filter key with a filter value up to 3000
        /// length. This filter is case and order sensitive. JSON string fields must be sorted
        /// in ascending order and JSON array order should be kept as is.
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
        /// Valid grouping keys: <c>QUEUE</c> | <c>ROUTING_PROFILE</c> | <c>AGENT</c> | <c>CHANNEL</c>
        /// | <c>AGENT_HIERARCHY_LEVEL_ONE</c> | <c>AGENT_HIERARCHY_LEVEL_TWO</c> | <c>AGENT_HIERARCHY_LEVEL_THREE</c>
        /// | <c>AGENT_HIERARCHY_LEVEL_FOUR</c> | <c>AGENT_HIERARCHY_LEVEL_FIVE</c>, <c>contact/segmentAttributes/connect:Subtype</c>
        /// | <c>ROUTING_STEP_EXPRESSION</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Max=3)]
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
        /// Gets and sets the property Interval. 
        /// <para>
        /// The interval period and timezone to apply to returned metrics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IntervalPeriod</c>: An aggregated grouping applied to request metrics. Valid <c>IntervalPeriod</c>
        /// values are: <c>FIFTEEN_MIN</c> | <c>THIRTY_MIN</c> | <c>HOUR</c> | <c>DAY</c> | <c>WEEK</c>
        /// | <c>TOTAL</c>. 
        /// </para>
        ///  
        /// <para>
        /// For example, if <c>IntervalPeriod</c> is selected <c>THIRTY_MIN</c>, <c>StartTime</c>
        /// and <c>EndTime</c> differs by 1 day, then Amazon Connect returns 48 results in the
        /// response. Each result is aggregated by the THIRTY_MIN period. By default Amazon Connect
        /// aggregates results based on the <c>TOTAL</c> interval period. 
        /// </para>
        ///  
        /// <para>
        /// The following list describes restrictions on <c>StartTime</c> and <c>EndTime</c> based
        /// on which <c>IntervalPeriod</c> is requested. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FIFTEEN_MIN</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must
        /// be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>THIRTY_MIN</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must
        /// be less than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOUR</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be less
        /// than 3 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DAY</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be less
        /// than 35 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WEEK</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be less
        /// than 35 days.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOTAL</c>: The difference between <c>StartTime</c> and <c>EndTime</c> must be
        /// less than 35 days.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>TimeZone</c>: The timezone applied to requested metrics.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IntervalDetails Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval != null;
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
        /// Gets and sets the property Metrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name, groupings, and filters for each metric.
        /// The following historical metrics are available. For a description of each metric,
        /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// metrics definitions</a> in the <i>Amazon Connect Administrator's Guide</i>.
        /// </para>
        ///  <dl> <dt>ABANDONMENT_RATE</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AGENT_ADHERENT_TIME</dt> <dd> 
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
        ///  </dd> <dt>AGENT_ANSWER_RATE</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AGENT_NON_ADHERENT_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
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
        ///  </dd> <dt>AGENT_NON_RESPONSE_WITHOUT_CUSTOMER_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// Data for this metric is available starting from October 1, 2023 0:00:00 GMT.
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
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_ACTIVE_TIME</dt> <dd> 
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
        /// Valid metric filter key: <c>INITIATION_METHOD</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_AGENT_CONNECTING_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <c>INITIATION_METHOD</c>. For now, this metric only supports
        /// the following as <c>INITIATION_METHOD</c>: <c>INBOUND</c> | <c>OUTBOUND</c> | <c>CALLBACK</c>
        /// | <c>API</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Negate</c> key in Metric Level Filters is not applicable for this metric.
        /// </para>
        ///  </note> </dd> <dt>AVG_AGENT_PAUSE_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>AVG_CONTACT_DURATION</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_CONVERSATION_DURATION</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_GREETING_TIME_AGENT</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype, RoutingStepExpression
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_HOLD_TIME_ALL_CONTACTS</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_HOLDS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <c>INITIATION_METHOD</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_INTERRUPTIONS_AGENT</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_INTERRUPTION_TIME_AGENT</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_NON_TALK_TIME</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>AVG_RESOLUTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_TALK_TIME</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_TALK_TIME_AGENT</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>AVG_TALK_TIME_CUSTOMER</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>CONTACTS_ABANDONED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype, RoutingStepExpression
        /// </para>
        ///  </dd> <dt>CONTACTS_CREATED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <c>INITIATION_METHOD</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <c>INITIATION_METHOD</c>, <c>DISCONNECT_REASON</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype, RoutingStepExpression
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>CONTACTS_HANDLED_BY_CONNECTED_TO_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <c>INITIATION_METHOD</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Agent, Agent Hierarchy, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>CONTACTS_HOLD_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>CONTACTS_ON_HOLD_AGENT_DISCONNECT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_ON_HOLD_CUSTOMER_DISCONNECT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_PUT_ON_HOLD</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_EXTERNAL</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_INTERNAL</dt> <dd> 
        /// <para>
        /// Unit: Percent
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
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>CONTACTS_QUEUED_BY_ENQUEUE</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Agent, Agent Hierarchy, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>CONTACTS_RESOLVED_IN_X</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// Threshold: For <c>ThresholdValue</c> enter any whole number from 1 to 604800 (inclusive),
        /// in seconds. For <c>Comparison</c>, you must enter <c>LT</c> (for "Less than").
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  <note> 
        /// <para>
        /// Feature is a valid filter but not a valid grouping.
        /// </para>
        ///  </note> </dd> <dt>CONTACTS_TRANSFERRED_OUT_BY_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>MAX_QUEUED_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>PERCENT_CONTACTS_STEP_EXPIRED</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, RoutingStepExpression
        /// </para>
        ///  </dd> <dt>PERCENT_CONTACTS_STEP_JOINED</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, RoutingStepExpression
        /// </para>
        ///  </dd> <dt>PERCENT_NON_TALK_TIME</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Percentage
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>PERCENT_TALK_TIME</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Percentage
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>PERCENT_TALK_TIME_AGENT</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Percentage
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>PERCENT_TALK_TIME_CUSTOMER</dt> <dd> 
        /// <para>
        /// This metric is available only for contacts analyzed by Contact Lens conversational
        /// analytics.
        /// </para>
        ///  
        /// <para>
        /// Unit: Percentage
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
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
        /// Threshold: For <c>ThresholdValue</c>, enter any whole number from 1 to 604800 (inclusive),
        /// in seconds. For <c>Comparison</c>, you must enter <c>LT</c> (for "Less than"). 
        /// </para>
        ///  </dd> <dt>STEP_CONTACTS_QUEUED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, RoutingStepExpression
        /// </para>
        ///  </dd> <dt>SUM_AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_CONNECTING_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid metric filter key: <c>INITIATION_METHOD</c>. This metric only supports the following
        /// filter keys as <c>INITIATION_METHOD</c>: <c>INBOUND</c> | <c>OUTBOUND</c> | <c>CALLBACK</c>
        /// | <c>API</c> 
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Negate</c> key in Metric Level Filters is not applicable for this metric.
        /// </para>
        ///  </note> </dd> <dt>SUM_CONTACT_FLOW_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_CONTACT_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_CONTACTS_ANSWERED_IN_X</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// Threshold: For <c>ThresholdValue</c>, enter any whole number from 1 to 604800 (inclusive),
        /// in seconds. For <c>Comparison</c>, you must enter <c>LT</c> (for "Less than"). 
        /// </para>
        ///  </dd> <dt>SUM_CONTACTS_ABANDONED_IN_X</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// Threshold: For <c>ThresholdValue</c>, enter any whole number from 1 to 604800 (inclusive),
        /// in seconds. For <c>Comparison</c>, you must enter <c>LT</c> (for "Less than"). 
        /// </para>
        ///  </dd> <dt>SUM_CONTACTS_DISCONNECTED </dt> <dd> 
        /// <para>
        /// Valid metric filter key: <c>DISCONNECT_REASON</c> 
        /// </para>
        ///  
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  </dd> <dt>SUM_ERROR_STATUS_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_IDLE_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_NON_PRODUCTIVE_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_ONLINE_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  </dd> <dt>SUM_RETRY_CALLBACK_ATTEMPTS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, contact/segmentAttributes/connect:Subtype
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
        /// The Amazon Resource Name (ARN) of the resource. This includes the <c>instanceId</c>
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
        /// timestamp. The start and end time depends on the <c>IntervalPeriod</c> selected. By
        /// default the time range between start and end time is 35 days. Historical metrics are
        /// available for 3 months.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}