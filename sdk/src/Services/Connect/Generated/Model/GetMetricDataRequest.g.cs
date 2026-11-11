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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricData operation. Gets historical metric
    /// data from the specified Connect Customer instance. <para> For a description of each
    /// historical metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html">Metrics
    /// definitions</a> in the <i>Connect Customer Administrator Guide</i>. </para> <note>
    /// <para> We recommend using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_GetMetricDataV2.html">GetMetricDataV2</a>
    /// API. It provides more flexibility, features, and the ability to query longer time
    /// ranges than <c>GetMetricData</c>. Use it to retrieve historical agent and contact
    /// metrics for the last 3 months, at varying intervals. You can also use it to build
    /// custom dashboards to measure historical queue and agent performance. For example,
    /// you can track the number of incoming contacts for the last 7 days, with data split
    /// by day, to see how contact volume changed per day of the week. </para> </note>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonConnectRequest
    {
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
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

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
        [AWSProperty(Required = true)]
        public Filters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> Groupings { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Groupings property is set.
        /// </summary>
        internal bool IsSetGroupings() => this.Groupings != null && (this.Groupings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HistoricalMetrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name, unit, and statistic for each metric. The
        /// following historical metrics are available. For a description of each metric, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/metrics-definitions.html">Metrics
        /// definition</a> in the <i>Connect Customer Administrator Guide</i>.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<HistoricalMetric> HistoricalMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<HistoricalMetric>() : null;

        /// <summary>
        /// Checks to see if the HistoricalMetrics property is set.
        /// </summary>
        internal bool IsSetHistoricalMetrics() => this.HistoricalMetrics != null && (this.HistoricalMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
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
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

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
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
