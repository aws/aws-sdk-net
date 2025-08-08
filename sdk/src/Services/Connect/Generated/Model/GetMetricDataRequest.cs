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
    /// Container for the parameters to the GetMetricData operation.
    /// Gets historical metric data from the specified Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// For a description of each historical metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html">Metrics
    /// definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// We recommend using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricDataV2.html">GetMetricDataV2</a>
    /// API. It provides more flexibility, features, and the ability to query longer time
    /// ranges than <c>GetMetricData</c>. Use it to retrieve historical agent and contact
    /// metrics for the last 3 months, at varying intervals. You can also use it to build
    /// custom dashboards to measure historical queue and agent performance. For example,
    /// you can track the number of incoming contacts for the last 7 days, with data split
    /// by day, to see how contact volume changed per day of the week.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonConnectRequest
    {
        private DateTime? _endTime;
        private Filters _filters;
        private List<string> _groupings = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<HistoricalMetric> _historicalMetrics = AWSConfigs.InitializeCollections ? new List<HistoricalMetric>() : null;
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp, in UNIX Epoch time format, at which to end the reporting interval for
        /// the retrieval of historical metrics data. The time must be specified using an interval
        /// of 5 minutes, such as 11:00, 11:05, 11:10, and must be later than the start time timestamp.
        /// </para>
        ///  
        /// <para>
        /// The time range between the start and end time must be less than 24 hours.
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
        /// The queues, up to 100, or channels, to use to filter the metrics returned. Metric
        /// data is retrieved only for the resources associated with the queues or channels included
        /// in the filter. You can include both queue IDs and queue ARNs in the same request.
        /// VOICE, CHAT, and TASK channels are supported.
        /// </para>
        ///  
        /// <para>
        /// RoutingStepExpression is not a valid filter for GetMetricData and we recommend switching
        /// to GetMetricDataV2 for more up-to-date features.
        /// </para>
        ///  <note> 
        /// <para>
        /// To filter by <c>Queues</c>, enter the queue ID/ARN, not the name of the queue.
        /// </para>
        ///  </note>
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
        /// The grouping applied to the metrics returned. For example, when results are grouped
        /// by queue, the metrics returned are grouped by queue. The values returned apply to
        /// the metrics for each queue rather than aggregated for all queues.
        /// </para>
        ///  
        /// <para>
        /// If no grouping is specified, a summary of metrics for all queues is returned.
        /// </para>
        ///  
        /// <para>
        /// RoutingStepExpression is not a valid filter for GetMetricData and we recommend switching
        /// to GetMetricDataV2 for more up-to-date features.
        /// </para>
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
        /// Gets and sets the property HistoricalMetrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name, unit, and statistic for each metric. The
        /// following historical metrics are available. For a description of each metric, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html">Metrics
        /// definition</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This API does not support a contacts incoming metric (there's no CONTACTS_INCOMING
        /// metric missing from the documented list). 
        /// </para>
        ///  </note> <dl> <dt>ABANDON_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-queue-abandon-time">Average
        /// queue abandon time</a> 
        /// </para>
        ///  </dd> <dt>AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#after-contact-work-time">After
        /// contact work time</a> 
        /// </para>
        ///  </dd> <dt>API_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#api-contacts-handled">API
        /// contacts handled</a> 
        /// </para>
        ///  </dd> <dt>AVG_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-customer-hold-time">Average
        /// customer hold time</a> 
        /// </para>
        ///  </dd> <dt>CALLBACK_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#callback-contacts-handled">Callback
        /// contacts handled</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_ABANDONED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-abandoned">Contacts
        /// abandoned</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_AGENT_HUNG_UP_FIRST</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-agent-hung-up-first">Contacts
        /// agent hung up first</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_CONSULTED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-consulted">Contacts
        /// consulted</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-handled">Contacts
        /// handled</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_INCOMING</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-handled-incoming">Contacts
        /// handled incoming</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_OUTBOUND</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-handled-outbound">Contacts
        /// handled outbound</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_HOLD_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-hold-disconnect">Contacts
        /// hold disconnect</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_MISSED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#agent-non-response">AGENT_NON_RESPONSE</a>
        /// 
        /// </para>
        ///  </dd> <dt>CONTACTS_QUEUED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-queued">Contacts
        /// queued</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-in">Contacts
        /// transferred in</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-out-queue">Contacts
        /// transferred out queue</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-out">Contacts
        /// transferred out</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#contacts-transferred-out-queue">Contacts
        /// transferred out queue</a> 
        /// </para>
        ///  </dd> <dt>HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-handle-time">Average
        /// handle time</a> 
        /// </para>
        ///  </dd> <dt>INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-agent-interaction-and-customer-hold-time">Average
        /// agent interaction and customer hold time</a> 
        /// </para>
        ///  </dd> <dt>INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#aaverage-agent-interaction-time">Average
        /// agent interaction time</a> 
        /// </para>
        ///  </dd> <dt>OCCUPANCY</dt> <dd> 
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#occupancy">Occupancy</a>
        /// 
        /// </para>
        ///  </dd> <dt>QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html##average-queue-answer-time">Average
        /// queue answer time</a> 
        /// </para>
        ///  </dd> <dt>QUEUED_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: MAX
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#minimum-flow-time">Minimum
        /// flow time</a> 
        /// </para>
        ///  </dd> <dt>SERVICE_LEVEL</dt> <dd> 
        /// <para>
        /// You can include up to 20 SERVICE_LEVEL metrics in a request.
        /// </para>
        ///  
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  
        /// <para>
        /// Threshold: For <c>ThresholdValue</c>, enter any whole number from 1 to 604800 (inclusive),
        /// in seconds. For <c>Comparison</c>, you must enter <c>LT</c> (for "Less than"). 
        /// </para>
        ///  
        /// <para>
        /// UI name: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html#average-queue-abandon-time">Average
        /// queue abandon time</a> 
        /// </para>
        ///  </dd> </dl>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HistoricalMetric> HistoricalMetrics
        {
            get { return this._historicalMetrics; }
            set { this._historicalMetrics = value; }
        }

        // Check to see if HistoricalMetrics property is set
        internal bool IsSetHistoricalMetrics()
        {
            return this._historicalMetrics != null && (this._historicalMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp, in UNIX Epoch time format, at which to start the reporting interval
        /// for the retrieval of historical metrics data. The time must be specified using a multiple
        /// of 5 minutes, such as 10:05, 10:10, 10:15.
        /// </para>
        ///  
        /// <para>
        /// The start time cannot be earlier than 24 hours before the time of the request. Historical
        /// metrics are available only for 24 hours.
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