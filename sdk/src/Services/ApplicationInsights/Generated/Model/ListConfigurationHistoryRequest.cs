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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationInsights.Model
{
    /// <summary>
    /// Container for the parameters to the ListConfigurationHistory operation.
    /// Lists the INFO, WARN, and ERROR events for periodic configuration updates performed
    /// by Application Insights. Examples of events represented are: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// INFO: creating a new alarm or updating an alarm threshold.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// WARN: alarm not created due to insufficient data points used to predict thresholds.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// ERROR: alarm not created due to permission errors or exceeding quotas. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListConfigurationHistoryRequest : AmazonApplicationInsightsRequest
    {
        private DateTime? _endTime;
        private ConfigurationEventStatus _eventStatus;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceGroupName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the event.
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
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The status of the configuration update event. Possible values include INFO, WARN,
        /// and ERROR.
        /// </para>
        /// </summary>
        public ConfigurationEventStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results returned by <code>ListConfigurationHistory</code> in
        /// paginated output. When this parameter is used, <code>ListConfigurationHistory</code>
        /// returns only <code>MaxResults</code> in a single page along with a <code>NextToken</code>
        /// response element. The remaining results of the initial request can be seen by sending
        /// another <code>ListConfigurationHistory</code> request with the returned <code>NextToken</code>
        /// value. If this parameter is not used, then <code>ListConfigurationHistory</code> returns
        /// all results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
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
        /// The <code>NextToken</code> value returned from a previous paginated <code>ListConfigurationHistory</code>
        /// request where <code>MaxResults</code> was used and the results exceeded the value
        /// of that parameter. Pagination continues from the end of the previous results that
        /// returned the <code>NextToken</code> value. This value is <code>null</code> when there
        /// are no more results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ResourceGroupName. 
        /// <para>
        /// Resource group to which the application belongs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceGroupName
        {
            get { return this._resourceGroupName; }
            set { this._resourceGroupName = value; }
        }

        // Check to see if ResourceGroupName property is set
        internal bool IsSetResourceGroupName()
        {
            return this._resourceGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the event. 
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