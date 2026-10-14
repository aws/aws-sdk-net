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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetAnomalies operation. Retrieves all of the cost
    /// anomalies detected on your account during the time period that's specified by the
    /// <c>DateInterval</c> object. Anomalies are available for up to 90 days.
    /// </summary>
    public partial class GetAnomaliesRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property DateInterval. 
        /// <para>
        /// Assigns the start and end dates for retrieving cost anomalies. The returned anomaly
        /// object will have an <c>AnomalyEndDate</c> in the specified time range. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnomalyDateInterval DateInterval { get; set; }

        /// <summary>
        /// Checks to see if the DateInterval property is set.
        /// </summary>
        internal bool IsSetDateInterval() => this.DateInterval != null;

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Filters anomaly results by the feedback field on the anomaly object. 
        /// </para>
        /// </summary>
        public AnomalyFeedbackType Feedback { get; set; }

        /// <summary>
        /// Checks to see if the Feedback property is set.
        /// </summary>
        internal bool IsSetFeedback() => this.Feedback != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of entries a paginated response contains. 
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorArn. 
        /// <para>
        /// Retrieves all of the cost anomalies detected for a specific cost anomaly monitor Amazon
        /// Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string MonitorArn { get; set; }

        /// <summary>
        /// Checks to see if the MonitorArn property is set.
        /// </summary>
        internal bool IsSetMonitorArn() => this.MonitorArn != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property TotalImpact. 
        /// <para>
        /// Filters anomaly results by the total impact field on the anomaly object. For example,
        /// you can filter anomalies <c>GREATER_THAN 200.00</c> to retrieve anomalies, with an
        /// estimated dollar impact greater than 200. 
        /// </para>
        /// </summary>
        public TotalImpactFilter TotalImpact { get; set; }

        /// <summary>
        /// Checks to see if the TotalImpact property is set.
        /// </summary>
        internal bool IsSetTotalImpact() => this.TotalImpact != null;
    }
}
