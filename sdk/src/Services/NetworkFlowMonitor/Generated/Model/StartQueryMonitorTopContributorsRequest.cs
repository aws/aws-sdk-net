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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
    /// Container for the parameters to the StartQueryMonitorTopContributors operation.
    /// Create a query that you can use with the Network Flow Monitor query interface to return
    /// the top contributors for a monitor. Specify the monitor that you want to create the
    /// query for. 
    /// 
    ///  
    /// <para>
    /// The call returns a query ID that you can use with <a href="https://docs.aws.amazon.com/networkflowmonitor/2.0/APIReference/API_GetQueryResultsMonitorTopContributors.html">
    /// GetQueryResultsMonitorTopContributors</a> to run the query and return the top contributors
    /// for a specific monitor.
    /// </para>
    ///  
    /// <para>
    /// Top contributors in Network Flow Monitor are network flows with the highest values
    /// for a specific metric type. Top contributors can be across all workload insights,
    /// for a given scope, or for a specific monitor. Use the applicable APIs for the top
    /// contributors that you want to be returned.
    /// </para>
    /// </summary>
    public partial class StartQueryMonitorTopContributorsRequest : AmazonNetworkFlowMonitorRequest
    {
        private DestinationCategory _destinationCategory;
        private DateTime? _endTime;
        private int? _limit;
        private MonitorMetric _metricName;
        private string _monitorName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property DestinationCategory. 
        /// <para>
        /// The category that you want to query top contributors for, for a specific monitor.
        /// Destination categories can be one of the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTRA_AZ</c>: Top contributor network flows within a single Availability Zone
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTER_AZ</c>: Top contributor network flows between Availability Zones
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTER_REGION</c>: Top contributor network flows between Regions (to the edge of
        /// another Region)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTER_VPC</c>: Top contributor network flows between VPCs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AMAZON_S3</c>: Top contributor network flows to or from Amazon S3
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AMAZON_DYNAMODB</c>: Top contributor network flows to or from Amazon Dynamo DB
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNCLASSIFIED</c>: Top contributor network flows that do not have a bucket classification
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationCategory DestinationCategory
        {
            get { return this._destinationCategory; }
            set { this._destinationCategory = value; }
        }

        // Check to see if DestinationCategory property is set
        internal bool IsSetDestinationCategory()
        {
            return this._destinationCategory != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that is the date and time end of the period that you want to retrieve
        /// results for with your query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of top contributors to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric that you want to query top contributors for. That is, you can specify a
        /// metric with this call and return the top contributor network flows, for that type
        /// of metric, for a monitor and (optionally) within a specific category, such as network
        /// flows between Availability Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonitorMetric MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that is the date and time that is the beginning of the period that you
        /// want to retrieve results for with your query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}