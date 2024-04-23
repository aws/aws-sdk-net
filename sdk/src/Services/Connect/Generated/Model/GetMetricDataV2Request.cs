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
        private List<FilterV2> _filters = AWSConfigs.InitializeCollections ? new List<FilterV2>() : null;
        private List<string> _groupings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IntervalDetails _interval;
        private int? _maxResults;
        private List<MetricV2> _metrics = AWSConfigs.InitializeCollections ? new List<MetricV2>() : null;
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
        /// | <c>CASE_TEMPLATE_ARN</c> | <c>CASE_STATUS</c> | <c>contact/segmentAttributes/connect:Subtype</c>
        /// | <c>ROUTING_STEP_EXPRESSION</c> 
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// | <c>AGENT_HIERARCHY_LEVEL_FOUR</c> | <c>AGENT_HIERARCHY_LEVEL_FIVE</c> | <c>CASE_TEMPLATE_ARN</c>
        /// | <c>CASE_STATUS</c> | <c>contact/segmentAttributes/connect:Subtype</c> | <c>ROUTING_STEP_EXPRESSION</c>
        /// 
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
            return this._groupings != null && (this._groupings.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  <dl> <dt>ABANDONMENT_RATE</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy,
        /// Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#abandonment-rate-historical">Abandonment
        /// rate</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#adherent-time-historical">Adherent
        /// time</a> 
        /// </para>
        ///  </dd> <dt>AGENT_ANSWER_RATE</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-answer-rate-historical">Agent
        /// answer rate</a> 
        /// </para>
        ///  </dd> <dt>AGENT_NON_ADHERENT_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#non-adherent-time">Non-adherent
        /// time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-non-response">Agent
        /// non-response</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-nonresponse-no-abandon-historical">Agent
        /// non-response without customer abandons</a> 
        /// </para>
        ///  </dd> <dt>AGENT_OCCUPANCY</dt> <dd> 
        /// <para>
        /// Unit: Percentage
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy 
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#occupancy-historical">Occupancy</a>
        /// 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#adherence-historical">Adherence</a>
        /// 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#scheduled-time-historical">Scheduled
        /// time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-queue-abandon-time-historical">Average
        /// queue abandon time</a> 
        /// </para>
        ///  </dd> <dt>AVG_ACTIVE_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-active-time-historical">Average
        /// active time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-acw-time-historical">Average
        /// after contact work time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#htm-avg-agent-api-connecting-time">Average
        /// agent API connecting time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-agent-pause-time-historical">Average
        /// agent pause time</a> 
        /// </para>
        ///  </dd> <dt>AVG_CASE_RELATED_CONTACTS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-contacts-case-historical">Average
        /// contacts per case</a> 
        /// </para>
        ///  </dd> <dt>AVG_CASE_RESOLUTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-case-resolution-time-historical">Average
        /// case resolution time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-contact-duration-historical">Average
        /// contact duration</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-conversation-duration-historical">Average
        /// conversation duration</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-greeting-time-agent-historical">Average
        /// greeting time agent </a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-handle-time-historical">Average
        /// handle time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-customer-hold-time-historical">Average
        /// customer hold time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#avg-customer-hold-time-all-contacts-historical">Average
        /// customer hold time all contacts</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-holds-historical">Average
        /// holds</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-agent-interaction-customer-hold-time-historical">Average
        /// agent interaction and customer hold time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-agent-interaction-time-historical">Average
        /// agent interaction time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-interruptions-agent-historical">Average
        /// interruptions agent </a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-interruptions-time-agent-historical">Average
        /// interruption time agent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html##average-non-talk-time-historical">Average
        /// non-talk time</a> 
        /// </para>
        ///  </dd> <dt>AVG_QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Feature, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-queue-answer-time-historical">Average
        /// queue answer time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-resolution-time-historical">Average
        /// resolution time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-talk-time-historical">Average
        /// talk time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-talk-time-agent-historical">Average
        /// talk time agent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#average-talk-time-customer-historical">Average
        /// talk time customer</a> 
        /// </para>
        ///  </dd> <dt>CASES_CREATED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html##cases-created-historical">Cases
        /// created</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-abandoned-historical">Contact
        /// abandoned</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-created-historical">Contacts
        /// created</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#api-contacts-handled-historical">API
        /// contacts handled</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-handled-by-connected-to-agent-historical">Contacts
        /// handled by Connected to agent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-handled-by-connected-to-agent-historical">Contacts
        /// hold disconnect</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_ON_HOLD_AGENT_DISCONNECT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-hold-agent-disconnect-historical">Contacts
        /// hold agent disconnect</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_ON_HOLD_CUSTOMER_DISCONNECT</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-hold-customer-disconnect-historical">Contacts
        /// hold customer disconnect</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_PUT_ON_HOLD</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-hold-customer-disconnect-historical">Contacts
        /// put on hold</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_EXTERNAL</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-transferred-out-external-historical">Contacts
        /// transferred out external</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_INTERNAL</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-transferred-out-internal-historical">Contacts
        /// transferred out internal</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-queued-historical">Contacts
        /// queued</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_QUEUED_BY_ENQUEUE</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Agent, Agent Hierarchy, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-queued-by-enqueue-historical">Contacts
        /// queued by Enqueue</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-resolved-historical">Contacts
        /// resolved in X</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-transferred-out-historical">Contacts
        /// transferred out</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-transferred-out-by-agent-historical">Contacts
        /// transferred out by agent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-transferred-out-by-agent-historical">Contacts
        /// transferred out queue</a> 
        /// </para>
        ///  </dd> <dt>CURRENT_CASES</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#current-cases-historical">Current
        /// cases</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#maximum-queued-time-historical">Maximum
        /// queued time</a> 
        /// </para>
        ///  </dd> <dt>PERCENT_CASES_FIRST_CONTACT_RESOLVED</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#cases-resolved-first-contact-historical">Cases
        /// resolved on first contact</a> 
        /// </para>
        ///  </dd> <dt>PERCENT_CONTACTS_STEP_EXPIRED</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, RoutingStepExpression
        /// </para>
        ///  
        /// <para>
        /// UI name: Not available 
        /// </para>
        ///  </dd> <dt>PERCENT_CONTACTS_STEP_JOINED</dt> <dd> 
        /// <para>
        /// Unit: Percent
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, RoutingStepExpression
        /// </para>
        ///  
        /// <para>
        /// UI name: Not available 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#ntt-historical">Non-talk
        /// time percent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#tt-historical">Talk
        /// time percent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#ttagent-historical">Talk
        /// time agent percent</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#ttcustomer-historical">Talk
        /// time customer percent</a> 
        /// </para>
        ///  </dd> <dt>REOPENED_CASE_ACTIONS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#cases-reopened-historical">Cases
        /// reopened</a> 
        /// </para>
        ///  </dd> <dt>RESOLVED_CASE_ACTIONS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Required filter key: CASE_TEMPLATE_ARN
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: CASE_TEMPLATE_ARN, CASE_STATUS
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#cases-resolved-historicall">Cases
        /// resolved</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#service-level-historical">Service
        /// level X</a> 
        /// </para>
        ///  </dd> <dt>STEP_CONTACTS_QUEUED</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, RoutingStepExpression
        /// </para>
        ///  
        /// <para>
        /// UI name: Not available
        /// </para>
        ///  </dd> <dt>SUM_AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#acw-historical">After
        /// contact work time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#htm-agent-api-connecting-time">Agent
        /// API connecting time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contact-flow-time-historical">Contact
        /// flow time</a> 
        /// </para>
        ///  </dd> <dt>SUM_CONTACT_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-on-contact-time-historical">Agent
        /// on contact time</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-answered-x-historical">Contacts
        /// answered in X seconds</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contacts-abandoned-x-historical">Contacts
        /// abandoned in X seconds</a> 
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
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contact-disconnected-historical">Contact
        /// disconnected</a> 
        /// </para>
        ///  </dd> <dt>SUM_ERROR_STATUS_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#error-status-time-historical">Error
        /// status time</a> 
        /// </para>
        ///  </dd> <dt>SUM_HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#contact-handle-time-historical">Contact
        /// handle time</a> 
        /// </para>
        ///  </dd> <dt>SUM_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#customer-hold-time-historical">Customer
        /// hold time</a> 
        /// </para>
        ///  </dd> <dt>SUM_IDLE_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-idle-time-historica">Agent
        /// idle time</a> 
        /// </para>
        ///  </dd> <dt>SUM_INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-interaction-hold-time-historical">Agent
        /// interaction and hold time</a> 
        /// </para>
        ///  </dd> <dt>SUM_INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#agent-interaction-time-historical">Agent
        /// interaction time</a> 
        /// </para>
        ///  </dd> <dt>SUM_NON_PRODUCTIVE_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#npt-historical">Non-Productive
        /// Time</a> 
        /// </para>
        ///  </dd> <dt>SUM_ONLINE_TIME_AGENT</dt> <dd> 
        /// <para>
        /// Unit: Seconds
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Routing Profile, Agent, Agent Hierarchy
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#online-time-historical">Online
        /// time</a> 
        /// </para>
        ///  </dd> <dt>SUM_RETRY_CALLBACK_ATTEMPTS</dt> <dd> 
        /// <para>
        /// Unit: Count
        /// </para>
        ///  
        /// <para>
        /// Valid groupings and filters: Queue, Channel, Routing Profile, contact/segmentAttributes/connect:Subtype
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html#callback-attempts-historical">Callback
        /// attempts</a> 
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
            return this._metrics != null && (this._metrics.Count > 0 || !AWSConfigs.InitializeCollections); 
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