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
    /// Container for the parameters to the StartQueryWorkloadInsightsTopContributorsData operation.
    /// Return the data for a query with the Network Flow Monitor query interface. Specify
    /// the query that you want to return results for by providing a query ID and a scope
    /// ID. This query returns data for the top contributors for workload insights. Workload
    /// insights provide a high level view of network flow performance data collected by agents
    /// for a scope.
    /// 
    ///  
    /// <para>
    /// A query ID is returned from an API call to start a query of a specific type; for example
    /// 
    /// </para>
    ///  
    /// <para>
    /// Top contributors in Network Flow Monitor are network flows with the highest values
    /// for a specific metric type, related to a scope (for workload insights) or a monitor.
    /// </para>
    ///  
    /// <para>
    /// The top contributor network flows overall for a specific metric type, for example,
    /// the number of retransmissions.
    /// </para>
    /// </summary>
    public partial class StartQueryWorkloadInsightsTopContributorsDataRequest : AmazonNetworkFlowMonitorRequest
    {
        private DestinationCategory _destinationCategory;
        private DateTime? _endTime;
        private WorkloadInsightsMetric _metricName;
        private string _scopeId;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property DestinationCategory. 
        /// <para>
        /// The destination category for a top contributors. Destination categories can be one
        /// of the following: 
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
        ///  <c>INTER_VPC</c>: Top contributor network flows between VPCs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SERVICES</c>: Top contributor network flows to or from Amazon Web Services
        /// services
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
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The metric that you want to query top contributors for. That is, you can specify this
        /// metric to return the top contributor network flows, for this type of metric, for a
        /// monitor and (optionally) within a specific category, such as network flows between
        /// Availability Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkloadInsightsMetric MetricName
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
        /// Gets and sets the property ScopeId. 
        /// <para>
        /// The identifier for the scope that includes the resources you want to get data results
        /// for. A scope ID is an internally-generated identifier that includes all the resources
        /// for a specific root account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScopeId
        {
            get { return this._scopeId; }
            set { this._scopeId = value; }
        }

        // Check to see if ScopeId property is set
        internal bool IsSetScopeId()
        {
            return this._scopeId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that is the date and time beginning of the period that you want to retrieve
        /// results for with your query.
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