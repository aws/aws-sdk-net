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

namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the StartQueryPerformanceMonitor operation. Create
    /// a query that you can use with the Network Flow Monitor query interface to return the
    /// top paths for a performance monitor. Specify the performance monitor that you want
    /// to create the query for. <para> The call returns a query ID that you can use with
    /// <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsPerformanceMonitor.html">
    /// GetQueryResultsPerformanceMonitor</a> to return the results of the query. </para>
    /// <para> Top paths in Network Flow Monitor are the network paths used by the traffic
    /// for the resources that a performance monitor tracks, ranked by impact score and then
    /// by traffic volume. Each path includes the traffic and round-trip time for the path,
    /// together with a breakdown of the subnet pairs that the path includes. </para>
    /// </summary>
    public partial class StartQueryPerformanceMonitorRequest : AmazonNetworkFlowMonitorRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that is the date and time end of the period that you want to retrieve
        /// results for with your query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FilterParameters. 
        /// <para>
        /// The filters for the query, to return a subset of the top paths. For a <c>TOP_PATHS</c>
        /// query, you can filter on the following fields:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>local_az_id</c>: The Availability Zone ID of the local end of a path
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>remote_az_id</c>: The Availability Zone ID of the remote end of a path
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>impact_level</c>: The impact level of a path
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you filter on <c>impact_level</c>, Network Flow Monitor compares the filter with
        /// the most severe impact level for the path over the time period of the query, and the
        /// traffic and round-trip time that Network Flow Monitor returns for each path still
        /// cover the full time period. Paths that have no impact data don't match an <c>impact_level</c>
        /// filter, including a <c>NOT_EQUALS</c> filter. Network Flow Monitor doesn't filter
        /// the subnet pairs within a path by impact level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FilterParameter> FilterParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterParameter>() : null;

        /// <summary>
        /// Checks to see if the FilterParameters property is set.
        /// </summary>
        internal bool IsSetFilterParameters() => this.FilterParameters != null && (this.FilterParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of top paths that you want the query to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the performance monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string MonitorName { get; set; }

        /// <summary>
        /// Checks to see if the MonitorName property is set.
        /// </summary>
        internal bool IsSetMonitorName() => this.MonitorName != null;

        /// <summary>
        /// Gets and sets the property QueryType. 
        /// <para>
        /// The type of query that you want to create. Specify <c>TOP_PATHS</c> to return the
        /// top paths for the performance monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PerformanceMonitorQueryType QueryType { get; set; }

        /// <summary>
        /// Checks to see if the QueryType property is set.
        /// </summary>
        internal bool IsSetQueryType() => this.QueryType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that is the date and time that is the beginning of the period that you
        /// want to retrieve results for with your query.
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
