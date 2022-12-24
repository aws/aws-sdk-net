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
    /// Container for the parameters to the GetCurrentMetricData operation.
    /// Gets the real-time metric data from the specified Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// For a description of each metric, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html">Real-time
    /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetCurrentMetricDataRequest : AmazonConnectRequest
    {
        private List<CurrentMetric> _currentMetrics = new List<CurrentMetric>();
        private Filters _filters;
        private List<string> _groupings = new List<string>();
        private string _instanceId;
        private int? _maxResults;
        private string _nextToken;
        private List<CurrentMetricSortCriteria> _sortCriteria = new List<CurrentMetricSortCriteria>();

        /// <summary>
        /// Gets and sets the property CurrentMetrics. 
        /// <para>
        /// The metrics to retrieve. Specify the name and unit for each metric. The following
        /// metrics are available. For a description of all the metrics, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html">Real-time
        /// Metrics Definitions</a> in the <i>Amazon Connect Administrator Guide</i>.
        /// </para>
        ///  <dl> <dt>AGENTS_AFTER_CONTACT_WORK</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#aftercallwork-real-time">ACW</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_AVAILABLE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#available-real-time">Available</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_ERROR</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#error-real-time">Error</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_NON_PRODUCTIVE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#non-productive-time-real-time">NPT
        /// (Non-Productive Time)</a> 
        /// </para>
        ///  </dd> <dt>AGENTS_ON_CALL</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#on-call-real-time">On
        /// contact</a> 
        /// </para>
        ///  </dd> <dt>AGENTS_ON_CONTACT</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#on-call-real-time">On
        /// contact</a> 
        /// </para>
        ///  </dd> <dt>AGENTS_ONLINE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#online-real-time">Online</a>
        /// 
        /// </para>
        ///  </dd> <dt>AGENTS_STAFFED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#staffed-real-time">Staffed</a>
        /// 
        /// </para>
        ///  </dd> <dt>CONTACTS_IN_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#in-queue-real-time">In
        /// queue</a> 
        /// </para>
        ///  </dd> <dt>CONTACTS_SCHEDULED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#scheduled-real-time">Scheduled</a>
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
        ///  <code>{ "Metric": { "Name": "OLDEST_CONTACT_AGE", "Unit": "SECONDS" }, "Value": 24113.0
        /// </code>}
        /// </para>
        ///  
        /// <para>
        /// The actual OLDEST_CONTACT_AGE is 24 seconds.
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#oldest-real-time">Oldest</a>
        /// 
        /// </para>
        ///  </dd> <dt>SLOTS_ACTIVE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#active-real-time">Active</a>
        /// 
        /// </para>
        ///  </dd> <dt>SLOTS_AVAILABLE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  
        /// <para>
        /// Name in real-time metrics report: <a href="https://docs.aws.amazon.com/connect/latest/adminguide/real-time-metrics-definitions.html#availability-real-time">Availability</a>
        /// 
        /// </para>
        ///  </dd> </dl>
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
            return this._currentMetrics != null && this._currentMetrics.Count > 0; 
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
        ///  </li> </ul> 
        /// <para>
        /// Metric data is retrieved only for the resources associated with the queues or routing
        /// profiles, and by any channels included in the filter. (You cannot filter by both queue
        /// AND routing profile.) You can include both resource IDs and resource ARNs in the same
        /// request. 
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
        /// The grouping applied to the metrics returned. For example, when grouped by <code>QUEUE</code>,
        /// the metrics returned apply to each queue rather than aggregated for all queues. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you group by <code>CHANNEL</code>, you should include a Channels filter. VOICE,
        /// CHAT, and TASK channels are supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you group by <code>ROUTING_PROFILE</code>, you must include either a queue or routing
        /// profile filter. In addition, a routing profile filter is required for metrics <code>CONTACTS_SCHEDULED</code>,
        /// <code>CONTACTS_IN_QUEUE</code>, and <code> OLDEST_CONTACT_AGE</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If no <code>Grouping</code> is included in the request, a summary of metrics is returned.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instanceId in the
        /// ARN of the instance.
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
        /// By default resources are sorted based on <code>AGENTS_ONLINE</code>, <code>DESCENDING</code>.
        /// The metric collection is sorted based on the input metrics.
        /// </para>
        ///  
        /// <para>
        /// Note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sorting on <code>SLOTS_ACTIVE</code> and <code>SLOTS_AVAILABLE</code> is not supported.
        /// </para>
        ///  </li> </ul>
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
            return this._sortCriteria != null && this._sortCriteria.Count > 0; 
        }

    }
}