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
    /// Container for the parameters to the GetCurrentMetricData operation.
    /// The <code>GetCurrentMetricData</code> operation retrieves current metric data from
    /// your Amazon Connect instance.
    /// 
    ///  
    /// <para>
    /// If you are using an IAM account, it must have permission to the <code>connect:GetCurrentMetricData</code>
    /// action.
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

        /// <summary>
        /// Gets and sets the property CurrentMetrics. 
        /// <para>
        /// A list of <code>CurrentMetric</code> objects for the metrics to retrieve. Each <code>CurrentMetric</code>
        /// includes a name of a metric to retrieve and the unit to use for it.
        /// </para>
        ///  
        /// <para>
        /// The following metrics are available:
        /// </para>
        ///  <dl> <dt>AGENTS_AVAILABLE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>AGENTS_ONLINE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>AGENTS_ON_CALL</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>AGENTS_STAFFED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>AGENTS_AFTER_CONTACT_WORK</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>AGENTS_NON_PRODUCTIVE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>AGENTS_ERROR</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>CONTACTS_IN_QUEUE</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> <dt>OLDEST_CONTACT_AGE</dt> <dd> 
        /// <para>
        /// Unit: SECONDS
        /// </para>
        ///  </dd> <dt>CONTACTS_SCHEDULED</dt> <dd> 
        /// <para>
        /// Unit: COUNT
        /// </para>
        ///  </dd> </dl>
        /// </summary>
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
        /// A <code>Filters</code> object that contains a list of queue IDs or queue ARNs, up
        /// to 100, or list of Channels to use to filter the metrics returned in the response.
        /// Metric data is retrieved only for the resources associated with the queue IDs, ARNs,
        /// or Channels included in the filter. You can include both IDs and ARNs in the same
        /// request. To retrieve metrics for all queues, add the queue ID or ARN for each queue
        /// in your instance. Only VOICE is supported for Channels.
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
        /// The grouping applied to the metrics returned. For example, when grouped by QUEUE,
        /// the metrics returned apply to each queue rather than aggregated for all queues. If
        /// you group by CHANNEL, you should include a Channels filter. The only supported channel
        /// is VOICE.
        /// </para>
        ///  
        /// <para>
        /// If no <code>Grouping</code> is included in the request, a summary of <code>CurrentMetrics</code>
        /// is returned. 
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
        ///  <code>MaxResults</code> indicates the maximum number of results to return per page
        /// in the response, between 1 and 100.
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
        ///  
        /// <para>
        /// The token expires after 5 minutes from the time it is created. Subsequent requests
        /// that use the <a href="">NextToken</a> must use the same request parameters as the
        /// request that generated the token.
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

    }
}