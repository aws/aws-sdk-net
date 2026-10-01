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

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the ListRumMetricsDestinations operation. Returns
    /// a list of destinations that you have created to receive RUM extended metrics, for
    /// the specified app monitor. <para> For more information about extended metrics, see
    /// <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_AddRumMetrcs.html">AddRumMetrics</a>.
    /// </para>
    /// </summary>
    public partial class ListRumMetricsDestinationsRequest : AmazonCloudWatchRUMRequest
    {
        /// <summary>
        /// Gets and sets the property AppMonitorName. 
        /// <para>
        /// The name of the app monitor associated with the destinations that you want to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AppMonitorName { get; set; }

        /// <summary>
        /// Checks to see if the AppMonitorName property is set.
        /// </summary>
        internal bool IsSetAppMonitorName() => this.AppMonitorName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one operation. The default is 50. The maximum
        /// that you can specify is 100.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the remaining results, make another call with the returned <c>NextToken</c>
        /// value. 
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
        /// Use the token returned by the previous operation to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
