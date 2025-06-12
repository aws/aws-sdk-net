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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
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
namespace Amazon.InternetMonitor.Model
{
    /// <summary>
    /// Container for the parameters to the StartQuery operation.
    /// Start a query to return data for a specific query type for the Amazon CloudWatch Internet
    /// Monitor query interface. Specify a time period for the data that you want returned
    /// by using <c>StartTime</c> and <c>EndTime</c>. You filter the query results to return
    /// by providing parameters that you specify with <c>FilterParameters</c>.
    /// 
    ///  
    /// <para>
    /// For more information about using the query interface, including examples, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
    /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
    /// Internet Monitor User Guide.
    /// </para>
    /// </summary>
    public partial class StartQueryRequest : AmazonInternetMonitorRequest
    {
        private DateTime? _endTime;
        private List<FilterParameter> _filterParameters = AWSConfigs.InitializeCollections ? new List<FilterParameter>() : null;
        private string _linkedAccountId;
        private string _monitorName;
        private QueryType _queryType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp that is the end of the period that you want to retrieve data for with
        /// your query.
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
        /// Gets and sets the property FilterParameters. 
        /// <para>
        /// The <c>FilterParameters</c> field that you use with Amazon CloudWatch Internet Monitor
        /// queries is a string the defines how you want a query to be filtered. The filter parameters
        /// that you can specify depend on the query type, since each query type returns a different
        /// set of Internet Monitor data.
        /// </para>
        ///  
        /// <para>
        /// For more information about specifying filter parameters, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">Using
        /// the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
        /// Internet Monitor User Guide.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FilterParameter> FilterParameters
        {
            get { return this._filterParameters; }
            set { this._filterParameters = value; }
        }

        // Check to see if FilterParameters property is set
        internal bool IsSetFilterParameters()
        {
            return this._filterParameters != null && (this._filterParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LinkedAccountId. 
        /// <para>
        /// The account ID for an account that you've set up cross-account sharing for in Amazon
        /// CloudWatch Internet Monitor. You configure cross-account sharing by using Amazon CloudWatch
        /// Observability Access Manager. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cwim-cross-account.html">Internet
        /// Monitor cross-account observability</a> in the Amazon CloudWatch Internet Monitor
        /// User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string LinkedAccountId
        {
            get { return this._linkedAccountId; }
            set { this._linkedAccountId = value; }
        }

        // Check to see if LinkedAccountId property is set
        internal bool IsSetLinkedAccountId()
        {
            return this._linkedAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor to query.
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
        /// Gets and sets the property QueryType. 
        /// <para>
        /// The type of query to run. The following are the three types of queries that you can
        /// run using the Internet Monitor query interface:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>MEASUREMENTS</c>: Provides availability score, performance score, total traffic,
        /// and round-trip times, at 5 minute intervals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOP_LOCATIONS</c>: Provides availability score, performance score, total traffic,
        /// and time to first byte (TTFB) information, for the top location and ASN combinations
        /// that you're monitoring, by traffic volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TOP_LOCATION_DETAILS</c>: Provides TTFB for Amazon CloudFront, your current configuration,
        /// and the best performing EC2 configuration, at 1 hour intervals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OVERALL_TRAFFIC_SUGGESTIONS</c>: Provides TTFB, using a 30-day weighted average,
        /// for all traffic in each Amazon Web Services location that is monitored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OVERALL_TRAFFIC_SUGGESTIONS_DETAILS</c>: Provides TTFB, using a 30-day weighted
        /// average, for each top location, for a proposed Amazon Web Services location. Must
        /// provide an Amazon Web Services location to search.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROUTING_SUGGESTIONS</c>: Provides the predicted average round-trip time (RTT)
        /// from an IP prefix toward an Amazon Web Services location for a DNS resolver. The RTT
        /// is calculated at one hour intervals, over a one hour period.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For lists of the fields returned with each query type and more information about how
        /// each type of query is performed, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-IM-view-cw-tools-cwim-query.html">
        /// Using the Amazon CloudWatch Internet Monitor query interface</a> in the Amazon CloudWatch
        /// Internet Monitor User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueryType QueryType
        {
            get { return this._queryType; }
            set { this._queryType = value; }
        }

        // Check to see if QueryType property is set
        internal bool IsSetQueryType()
        {
            return this._queryType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp that is the beginning of the period that you want to retrieve data for
        /// with your query.
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