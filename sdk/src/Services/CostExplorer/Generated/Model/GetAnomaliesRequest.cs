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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetAnomalies operation.
    /// Retrieves all of the cost anomalies detected on your account during the time period
    /// that's specified by the <code>DateInterval</code> object. Anomalies are available
    /// for up to 90 days.
    /// </summary>
    public partial class GetAnomaliesRequest : AmazonCostExplorerRequest
    {
        private AnomalyDateInterval _dateInterval;
        private AnomalyFeedbackType _feedback;
        private int? _maxResults;
        private string _monitorArn;
        private string _nextPageToken;
        private TotalImpactFilter _totalImpact;

        /// <summary>
        /// Gets and sets the property DateInterval. 
        /// <para>
        /// Assigns the start and end dates for retrieving cost anomalies. The returned anomaly
        /// object will have an <code>AnomalyEndDate</code> in the specified time range. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnomalyDateInterval DateInterval
        {
            get { return this._dateInterval; }
            set { this._dateInterval = value; }
        }

        // Check to see if DateInterval property is set
        internal bool IsSetDateInterval()
        {
            return this._dateInterval != null;
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Filters anomaly results by the feedback field on the anomaly object. 
        /// </para>
        /// </summary>
        public AnomalyFeedbackType Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of entries a paginated response contains. 
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
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// Retrieves all of the cost anomalies detected for a specific cost anomaly monitor Amazon
        /// Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string MonitorArn
        {
            get { return this._monitorArn; }
            set { this._monitorArn = value; }
        }

        // Check to see if MonitorArn property is set
        internal bool IsSetMonitorArn()
        {
            return this._monitorArn != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property TotalImpact. 
        /// <para>
        /// Filters anomaly results by the total impact field on the anomaly object. For example,
        /// you can filter anomalies <code>GREATER_THAN 200.00</code> to retrieve anomalies, with
        /// an estimated dollar impact greater than 200. 
        /// </para>
        /// </summary>
        public TotalImpactFilter TotalImpact
        {
            get { return this._totalImpact; }
            set { this._totalImpact = value; }
        }

        // Check to see if TotalImpact property is set
        internal bool IsSetTotalImpact()
        {
            return this._totalImpact != null;
        }

    }
}