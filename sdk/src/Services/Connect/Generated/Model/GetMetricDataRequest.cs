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
    /// Container for the parameters to the GetMetricData operation.
    /// Gets historical metric data from the specified Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// For a description of each historical metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
    /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonConnectRequest
    {
        private DateTime? _endTime;
        private Filters _filters;
        private List<string> _groupings = new List<string>();
        private List<HistoricalMetric> _historicalMetrics = new List<HistoricalMetric>();
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
        /// The queues, up to 100, or channels, to use to filter the metrics returned. Metric
        /// data is retrieved only for the resources associated with the queues or channels included
        /// in the filter. You can include both queue IDs and queue ARNs in the same request.
        /// VOICE, CHAT, and TASK channels are supported.
        /// </para>
        ///  <note> 
        /// <para>
        /// To filter by <code>Queues</code>, enter the queue ID/ARN, not the name of the queue.
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
        /// Gets and sets the property HistoricalMetrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name, unit, and statistic for each metric. The
        /// following historical metrics are available. For a description of each metric, see
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/historical-metrics-definitions.html">Historical
        /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
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
        ///  </dd> <dt>AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>API_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CALLBACK_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_ABANDONED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_AGENT_HUNG_UP_FIRST</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_CONSULTED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_INCOMING</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_OUTBOUND</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HOLD_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_MISSED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_QUEUED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistic: SUM
        /// </para>
        ///  </dd> <dt>HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>OCCUPANCY</dt> <dd> 
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: AVG
        /// </para>
        ///  </dd> <dt>QUEUED_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistic: MAX
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
        /// Threshold: For <code>ThresholdValue</code>, enter any whole number from 1 to 604800
        /// (inclusive), in seconds. For <code>Comparison</code>, you must enter <code>LT</code>
        /// (for "Less than"). 
        /// </para>
        ///  </dd> </dl>
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
            return this._historicalMetrics != null && this._historicalMetrics.Count > 0; 
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