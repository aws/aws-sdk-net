/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricData operation.
    /// The <code>GetMetricData</code> operation retrieves historical metrics data from your
    /// Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// If you are using an IAM account, it must have permission to the <code>connect:GetMetricData</code>
    /// action.
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
        /// of 5 minutes, such as 11:00, 11:05, 11:10, and must be later than the <code>StartTime</code>
        /// timestamp.
        /// </para>
        ///  
        /// <para>
        /// The time range between <code>StartTime</code> and <code>EndTime</code> must be less
        /// than 24 hours.
        /// </para>
        /// </summary>
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
        /// A <code>Filters</code> object that contains a list of queue IDs or queue ARNs, up
        /// to 100, or a list of Channels to use to filter the metrics returned in the response.
        /// Metric data is retrieved only for the resources associated with the IDs, ARNs, or
        /// Channels included in the filter. You can use both IDs and ARNs together in a request.
        /// Only VOICE is supported for Channel.
        /// </para>
        ///  
        /// <para>
        /// To find the ARN for a queue, open the queue you want to use in the Amazon Connect
        /// Queue editor. The ARN for the queue is displayed in the address bar as part of the
        /// URL. For example, the queue ARN is the set of characters at the end of the URL, after
        /// 'id=' such as <code>arn:aws:connect:us-east-1:270923740243:instance/78fb859d-1b7d-44b1-8aa3-12f0835c5855/queue/1d1a4575-9618-40ab-bbeb-81e45795fe61</code>.
        /// The queue ID is also included in the URL, and is the string after 'queue/'.
        /// </para>
        /// </summary>
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
        /// by queueId, the metrics returned are grouped by queue. The values returned apply to
        /// the metrics for each queue rather than aggregated for all queues.
        /// </para>
        ///  
        /// <para>
        /// The current version supports grouping by Queue
        /// </para>
        ///  
        /// <para>
        /// If no <code>Grouping</code> is included in the request, a summary of <code>HistoricalMetrics</code>
        /// for all queues is returned.
        /// </para>
        /// </summary>
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
        /// A list of <code>HistoricalMetric</code> objects that contain the metrics to retrieve
        /// with the request.
        /// </para>
        ///  
        /// <para>
        /// A <code>HistoricalMetric</code> object contains: <code>HistoricalMetricName</code>,
        /// <code>Statistic</code>, <code>Threshold</code>, and <code>Unit</code>.
        /// </para>
        ///  
        /// <para>
        /// For each historical metric you include in the request, you must include a <code>Unit</code>
        /// and a <code>Statistic</code>. 
        /// </para>
        ///  
        /// <para>
        /// The following historical metrics are available:
        /// </para>
        ///  <dl> <dt>CONTACTS_QUEUED</dt> <dd> 
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
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_ABANDONED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_CONSULTED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_AGENT_HUNG_UP_FIRST</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_INCOMING</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HANDLED_OUTBOUND</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_HOLD_ABANDONS</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_IN_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_TRANSFERRED_OUT_FROM_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CALLBACK_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CALLBACK_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>API_CONTACTS_HANDLED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>CONTACTS_MISSED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>OCCUPANCY</dt> <dd> 
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>HANDLE_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>AFTER_CONTACT_WORK_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>QUEUED_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: MAX
        /// </para>
        ///  </dd> <dt>ABANDON_TIME</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Statistics: SUM
        /// </para>
        ///  </dd> <dt>QUEUE_ANSWER_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>INTERACTION_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>INTERACTION_AND_HOLD_TIME</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  </dd> <dt>SERVICE_LEVEL</dt> <dd> 
        /// <para>
        /// Unit: PERCENT
        /// </para>
        ///  
        /// <para>
        /// Statistics: AVG
        /// </para>
        ///  
        /// <para>
        /// Threshold: Only "Less than" comparisons are supported, with the following service
        /// level thresholds: 15, 20, 25, 30, 45, 60, 90, 120, 180, 240, 300, 600
        /// </para>
        ///  </dd> </dl>
        /// </summary>
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
        /// The identifier for your Amazon Connect instance. To find the ID of your instance,
        /// open the AWS console and select Amazon Connect. Select the alias of the instance in
        /// the Instance alias column. The instance ID is displayed in the Overview section of
        /// your instance settings. For example, the instance ID is the set of characters at the
        /// end of the instance ARN, after instance/, such as 10a4c4eb-f57e-4d4c-b602-bf39176ced07.
        /// </para>
        /// </summary>
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
        /// Indicates the maximum number of results to return per page in the response, between
        /// 1-100.
        /// </para>
        /// </summary>
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
        ///  <code>StartTime</code> cannot be earlier than 24 hours before the time of the request.
        /// Historical metrics are available in Amazon Connect only for 24 hours.
        /// </para>
        /// </summary>
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